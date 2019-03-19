using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryManager
{

    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            worker.SnapshotCreated += this.OnSnapshotCreaated;
        }

        Worker worker = new Worker();
        public List<Snapshot> snapshots = new List<Snapshot>();
        public bool safeMode = false; // only keep top 10 in process list to save local memory
        public int snapshotTime = 60;
        public bool enabled = false;
        public bool usageAlerts = false;
        public bool snapshotManagerOpened = false;
        private bool mouseDown;
        private Point lastLocation;

        
                
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.titleBar.MouseDown += new MouseEventHandler(titleBar_MouseDown);
            this.titleBar.MouseUp += new MouseEventHandler(titleBar_MouseUp);
            this.titleBar.MouseMove += new MouseEventHandler(titleBar_MouseMove);
            this.titleLabel.MouseDown += new MouseEventHandler(titleBar_MouseDown);
            this.titleLabel.MouseUp += new MouseEventHandler(titleBar_MouseUp);
            this.titleLabel.MouseMove += new MouseEventHandler(titleBar_MouseMove);
            this.windowIcon.MouseDown += new MouseEventHandler(titleBar_MouseDown);
            this.windowIcon.MouseUp += new MouseEventHandler(titleBar_MouseUp);
            this.windowIcon.MouseMove += new MouseEventHandler(titleBar_MouseMove);

        }

        

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Make sure no snapshots are going on in the background as well
            this.Close();
        }

        private void enabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            enabled = (this.enabledCheckBox.CheckState == CheckState.Checked) ? true : false;
            
            if (enabled)
            {
                this.snapshotrateNumeric.Enabled = false;
                this.safemodeCheckBox.Enabled = false;
                this.usagealertsCheckBox.Enabled = false;
                worker.ChangeSafeMode(safeMode);
                worker.ChangeWaitTime(snapshotTime);
                worker.CreateSnapshot();
            }
            else
            {
                this.enabledCheckBox.Enabled = false;
                this.snapshotrateNumeric.Enabled = true;
                this.safemodeCheckBox.Enabled = true;
                this.usagealertsCheckBox.Enabled = true;    
            }
        }
        public void OnSnapshotCreaated(object source, Snapshot snapshot)
        {
            // add snapshot to list and graphs
            if (!enabled)
            {
                this.enabledCheckBox.Enabled = true;
            }
            else
            {
                // activate again
                worker.ChangeSafeMode(safeMode);
                worker.ChangeWaitTime(snapshotTime);
                worker.CreateSnapshot();
                
            }
            
        }

        private void snapshotrateNumeric_ValueChanged(object sender, EventArgs e)
        {
            snapshotTime = Convert.ToInt32(this.snapshotrateNumeric.Value);
        }

        private void safemodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            safeMode = (this.safemodeCheckBox.CheckState == CheckState.Checked) ? true : false;
        }

        private void usagealertsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            usageAlerts = (this.usagealertsCheckBox.CheckState == CheckState.Checked) ? true : false;
        }
    }

    public class Worker
    {
        public delegate void SnapshotCreatedEventHandler(object source, Snapshot args);
        public event SnapshotCreatedEventHandler SnapshotCreated;
        public bool SafeMode { get; private set; }
        public bool Active { get; private set; }
        public int WaitTime { get; private set; }
        public void ChangeSafeMode(bool SafeMode)
        {
            this.SafeMode = SafeMode;
        }
        public void ChangeWaitTime(int WaitTime)
        {
            this.WaitTime = WaitTime;
        }
        private void wait(int milliseconds) // Non blocking sleep alternative
        {
            Timer timer1 = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        private Snapshot _CreateSnapshot()
        {
            System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();
            List<Process> newProcessList = new List<Process>();
            DateTime newDate = DateTime.Now; // this could be a reference to DateTime.Now and not the value of DateTime.Now at call, so be careful
            foreach (System.Diagnostics.Process currentProcess in processList)
            {
                try
                {
                    Process newProcess = new Process(currentProcess.MainWindowTitle, currentProcess.PrivateMemorySize64);
                    newProcessList.Add(newProcess);
                }
                catch
                {
                    // Process closed while creating snapshot
                }
            }

            newProcessList.Sort((x, y) => y.MemoryUsage.CompareTo(x.MemoryUsage)); // Sort list in decending order of memory usage

            if (SafeMode)
            {
                if (newProcessList.Count > 10)
                {
                    newProcessList.RemoveRange(9, (newProcessList.Count - 9)); // Trim down snapshot to top 10 memory eaters (safe mode)
                }
            }
            wait(WaitTime * 1000); // Convert seconds to miliseconds
            return(new Snapshot(newDate, newProcessList, SafeMode));
        }
        public async void CreateSnapshot()
        {
            Active = true;
            Task<Snapshot> createSnapshot = new Task<Snapshot>(_CreateSnapshot);
            createSnapshot.Start();
            Snapshot newSnapshot = await createSnapshot;
            OnSnapshotCreated(newSnapshot);
        }

        protected virtual void OnSnapshotCreated(Snapshot snapshot)
        {
            Active = false;
            SnapshotCreated?.Invoke(this, snapshot);
        }
    }

    public class Process
    {
        public string ProcessName { get; private set; }
        public long MemoryUsage { get; private set; }
        public Process(string ProcessName, long MemoryUsage)
        {
            this.ProcessName = ProcessName;
            this.MemoryUsage = MemoryUsage;
        }

    }
    
    public class Snapshot
    {
        public List<Process> ProcessList { get; private set; } = new List<Process>();
        public DateTime DateTaken { get; private set; }
        public bool SafeMode { get; private set; }
        public Snapshot(DateTime DateTaken, List<Process> ProcessList, bool SafeMode)
        {
            this.DateTaken = DateTaken;
            this.ProcessList = ProcessList;
            this.SafeMode = SafeMode;
        }
    }
}
