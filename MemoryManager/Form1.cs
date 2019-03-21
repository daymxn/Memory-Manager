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
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.Devices;
using System.IO;
using Newtonsoft.Json;

namespace MemoryManager
{

    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.titleBar.MouseDown += new MouseEventHandler(titleBar_MouseDown);
            this.titleBar.MouseUp += new MouseEventHandler(titleBar_MouseUp);
            this.titleBar.MouseMove += new MouseEventHandler(titleBar_MouseMove);
            this.titleLabel.MouseDown += new MouseEventHandler(titleBar_MouseDown);
            this.titleLabel.MouseUp += new MouseEventHandler(titleBar_MouseUp);
            this.titleLabel.MouseMove += new MouseEventHandler(titleBar_MouseMove);
            this.windowIcon.MouseDown += new MouseEventHandler(titleBar_MouseDown);
            this.windowIcon.MouseUp += new MouseEventHandler(titleBar_MouseUp);
            this.windowIcon.MouseMove += new MouseEventHandler(titleBar_MouseMove);

            totalPhysicalMemory = new ComputerInfo().TotalPhysicalMemory;
            worker.SnapshotCreated += this.OnSnapshotCreaated;
            SnapshotForm.SnapshotChosen += this.OnSnapshotChosen;

        }

        SnapshotForm SnapshotForm = new SnapshotForm();
        Worker worker = new Worker();
        public List<Snapshot> snapshots = new List<Snapshot>();
        public List<Snapshot> loadedSnapshots = new List<Snapshot>();
        public bool safeMode = false; // only keep top 10 in process list to save local memory
        public int snapshotTime = 60;
        public Snapshot snapshotLoaded;
        public bool enabled = false;
        public bool usageAlerts = false;
        public bool expanded = false;
        public bool saveLocally = false;
        public bool loadLocally = false;
        public int timeActive = 0;
        private bool mouseDown;
        private Point lastLocation;
        public ulong totalPhysicalMemory;

        
                
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
                timeActive = 0;
                this.snapshotrateNumeric.Enabled = false;
                this.safemodeCheckBox.Enabled = false;
                this.usagealertsCheckBox.Enabled = false;
                this.loadlocallyCheckBox.Enabled = false;
                this.savelocallyCheckBox.Enabled = false;
                worker.ChangeSafeMode(safeMode);
                worker.ChangeWaitTime(snapshotTime);
                worker.CreateSnapshot();
            }
            else
            {
                this.enabledCheckBox.Enabled = false;
                this.snapshotrateNumeric.Enabled = false;
                this.safemodeCheckBox.Enabled = false;
                this.usagealertsCheckBox.Enabled = false;
                this.loadlocallyCheckBox.Enabled = false;
                this.savelocallyCheckBox.Enabled = false;
            }
        }

        public void LoadSnapshot(Snapshot snapshot)
        {
            this.nosnapshotloadedPictureBox.Visible = false;
            this.CurrentSnapshotChart.Visible = true;
            this.CurrentSnapshotChart.Titles.FindByName("title1").Text = snapshot.DateTaken.ToString() + " Snapshot";
            this.CurrentSnapshotChart.Series["PieData"].Points.Clear();
            Font dataFont = new Font(new FontFamily("Microsoft Sans Serif"), 8f);
            if (snapshot.ProcessList.Count >= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    Process currentProcess = snapshot.ProcessList[i];


                    DataPoint data = new DataPoint(0, Convert.ToString(((currentProcess.MemoryUsage / (double)totalPhysicalMemory) * 100)))
                    {
                        Label = currentProcess.ProcessName + " (" + Convert.ToString(Math.Round(((currentProcess.MemoryUsage / (double)totalPhysicalMemory) * 100), 2)) + "%)",
                        Font = dataFont,
                        LabelForeColor = Color.Transparent,
                        LabelToolTip = currentProcess.ProcessName + " (" + Convert.ToString(Math.Round(((currentProcess.MemoryUsage / (double)totalPhysicalMemory) * 100), 2)) + "%)"

                    };
                    this.CurrentSnapshotChart.Series["PieData"].Points.Add(data);
                }

            }
            else
            {
                foreach (Process currentProcess in snapshot.ProcessList)
                {
                    // do the exact same as above, this is for less than 10 active processes

                    DataPoint data = new DataPoint(0, Convert.ToString(((currentProcess.MemoryUsage / (double)totalPhysicalMemory) * 100)))
                    {
                        Label = currentProcess.ProcessName + " (" + Convert.ToString(Math.Round(((currentProcess.MemoryUsage / (double)totalPhysicalMemory) * 100), 2)) + "%)",
                        Font = dataFont,
                        LabelForeColor = Color.Transparent,
                        LabelToolTip = currentProcess.ProcessName + " (" + Convert.ToString(Math.Round(((currentProcess.MemoryUsage / (double)totalPhysicalMemory) * 100), 2)) + "%)"

                    };
                    this.CurrentSnapshotChart.Series["PieData"].Points.Add(data);
                }
            }
        }

        public void OnSnapshotChosen(object source, Snapshot snapshot)
        {
            LoadSnapshot(snapshot);
        }

        public void UpdateHourlyGraph(List<Process> snapshotList)
        {
            
        }

        public bool withinPastHour(DateTime time)
        {
            TimeSpan ts = new TimeSpan(DateTime.UtcNow.Ticks - time.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);
            if(delta <= 5400)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OnSnapshotCreaated(object source, Snapshot snapshot)
        {
            expanded = true; // debuging
            timeActive += snapshotTime;
            if (usageAlerts)
            {
                // if a process is using more than 20% of physical memory
                Process highUsage = snapshot.ProcessList.Find(p => p.MemoryUsage >= (totalPhysicalMemory * .2));
                if(highUsage != null && this.WindowState == FormWindowState.Minimized)
                {
                    this.notifyIcon1.ShowBalloonTip(3000, "Daymon's Memory Manager", "High usage from " + highUsage.ProcessName, ToolTipIcon.Warning);
                }
            }
            

            //save to file if enabled
            if (saveLocally)
            {
                Directory.CreateDirectory(@Directory.GetCurrentDirectory() + "\\Export\\");
                using (StreamWriter file = File.CreateText(@Directory.GetCurrentDirectory() + "\\Export\\snapshot.txt"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, snapshot);
                }
            }
            snapshots.Add(snapshot);
            SnapshotForm.AddSnapshot(snapshot);


            // add snapshot to graphs
            if (snapshotLoaded == null && expanded)
            {
                LoadSnapshot(snapshot);
            }

            List<Process> hourlyProcessList = new List<Process>();
            
            foreach(Snapshot currentSnpshot in snapshots)
            {
                if (withinPastHour(currentSnpshot.DateTaken))
                {
                    // doesnt combine same programs from seperate snapshots
                    // probably gonna have to just scrap concat and manually loop through entire list
                    // find out why chrome wasn't appearing at top first though, because the way I would do this would be similiar to that (kind of)
                    hourlyProcessList = hourlyProcessList.Concat(currentSnpshot.ProcessList).ToList();
                }
            }
            hourlyProcessList.Sort((x, y) => y.MemoryUsage.CompareTo(x.MemoryUsage));
            UpdateHourlyGraph(hourlyProcessList);

            if (!enabled)
            {
                this.enabledCheckBox.Enabled = true;
                this.snapshotrateNumeric.Enabled = true;
                this.safemodeCheckBox.Enabled = true;
                this.usagealertsCheckBox.Enabled = true;
                this.loadlocallyCheckBox.Enabled = true;
                this.savelocallyCheckBox.Enabled = true;
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

        private void savelocallyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            saveLocally = (this.savelocallyCheckBox.CheckState == CheckState.Checked) ? true : false;
        }

        private void loadlocallyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            loadLocally = (this.loadlocallyCheckBox.CheckState == CheckState.Checked) ? true : false;
        }
        private void LoadSnapshotsFromFile()
        {
            
            if(Directory.Exists(@Directory.GetCurrentDirectory() + "\\Export"))
            {
                
                IEnumerable<String> files = Directory.EnumerateFiles(@Directory.GetCurrentDirectory() + "\\Export\\", "*.txt", SearchOption.TopDirectoryOnly);
                foreach(string currentFile in files)
                {

                    try
                    {
                        string file = File.ReadAllText(currentFile);
                        Snapshot newSnapshot = JsonConvert.DeserializeObject<Snapshot>(file);
                        //check if in loadedSnapshots
                        if (!(loadedSnapshots.Contains(newSnapshot)))
                        {
                            loadedSnapshots.Add(newSnapshot);
                            SnapshotForm.AddSnapshot(newSnapshot);
                        }
                    }
                    catch
                    {
                        // not a valid file
                        Console.WriteLine("Attempted to load an invalid snapshot. Please clean your ./Export/ folder of any non snapshot .txt files.");
                    }
                }
            }
        }

        private void changesnapshotButton_Click(object sender, EventArgs e)
        {
            if (loadLocally)
            {
                LoadSnapshotsFromFile();
            }
            SnapshotForm.ShowDialog();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide(); 
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.ShowBalloonTip(3000, "Daymon's Memory Manager", "Minimized to system tray", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
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
            DateTime newDate = DateTime.Now;
            foreach (System.Diagnostics.Process currentProcess in processList)
            {
                try
                {
                    if(currentProcess.MainModule.FileVersionInfo.FileDescription == "")
                    {
                        Process result = newProcessList.Find(x => x.ProcessName == currentProcess.ProcessName);
                        if(result == null)
                        {
                            Process newProcess = new Process(currentProcess.ProcessName, currentProcess.WorkingSet64);
                            newProcessList.Add(newProcess);
                        }
                        else
                        {
                            result.AddMemoryUsage(currentProcess.WorkingSet64);
                        }
                        
                    }
                    else
                    {
                        Process result = newProcessList.Find(x => x.ProcessName == currentProcess.MainModule.FileVersionInfo.FileDescription);
                        if (result == null)
                        {
                            Process newProcess = new Process(currentProcess.MainModule.FileVersionInfo.FileDescription, currentProcess.WorkingSet64);
                            newProcessList.Add(newProcess);
                        }
                        else
                        {
                            result.AddMemoryUsage(currentProcess.WorkingSet64);
                        }
                    }
                    
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
        public void AddMemoryUsage(long MemoryUsage)
        {
            this.MemoryUsage += MemoryUsage;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Process s = obj as Process;
            if ((object)s == null)
                return false;
            return (ProcessName == s.ProcessName) && (MemoryUsage == s.MemoryUsage);
        }
        public override int GetHashCode()
        {
            return ProcessName.GetHashCode() ^ MemoryUsage.GetHashCode();
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
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Snapshot s = obj as Snapshot;
            if ((object)s == null)
                return false;
            return (ProcessList.All(s.ProcessList.Contains) && ProcessList.Count == s.ProcessList.Count) && (DateTaken.ToString() == s.DateTaken.ToString()) && (SafeMode == s.SafeMode);
        }
        public override int GetHashCode()
        {
            return ProcessList.GetHashCode() ^ DateTaken.GetHashCode() ^ SafeMode.GetHashCode();
        }
    }
}
