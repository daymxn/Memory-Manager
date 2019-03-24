using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryManager
{
    public partial class HelpForm : Form
    {
        public HelpForm()
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
        }

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

        public void LoadHelp(string option)
        {
            switch (option)
            {
                case "SnapshotRate":
                    this.helpTitleLabel.Text = "Snapshot Rate";
                    this.helpBodyLabel.Text = "Snapshot Rate is the interval at which the program takes a snapshot of the proccess list (in seconds). A lower value means higher accuracy, but could also flood you with snapshots or cause CPU usage to rise. Keeping between 20-60 seconds is a nice middle ground.";
                    this.Size = new Size(469, 277);
                    break;
                case "UsageAlerts":
                    this.helpTitleLabel.Text = "Usage Alerts";
                    this.helpBodyLabel.Text = "Usage Alerts only works when the application is minimized to the system tray. When enabled, it'll monitor your snapshots for any (very) high usage applications and alert you on the fly via a ballon tip.";
                    this.Size = new Size(469, 240);
                    break;
                case "SafeMode":
                    this.helpTitleLabel.Text = "Safe Mode";
                    this.helpBodyLabel.Text = "Safe Mode changes the way snapshots are saved. Normally, all your processes (and their memory usage) are saved in memory. Although the graphs only display the top 10 users, in the background all the proccesses are being saved. Usually this isn't an issue, but if you're running the app for very long periods (weeks on end) with a low snapshot rate, this may cause some issues. When Safe Mode is enabled, each snapshot will only hold the top 10 spenders- and throw away the rest. This can save a ton of local memory, but this could also provide some inaccuracies for the hourly graph.";
                    this.Size = new Size(469, 402);
                    break;
                case "SaveLocally":
                    this.helpTitleLabel.Text = "Save Locally";
                    this.helpBodyLabel.Text = "Save Locally saves each snapshot taken (while enabled) to your local hdd. Each snapshot will be exported to your ./Export folder. You can manually inspect each snapshot, or load them later (in app) for inspection.";
                    this.Size = new Size(469, 236);
                    break;
                case "LoadLocally":
                    this.helpTitleLabel.Text = "Load Locally";
                    this.helpBodyLabel.Text = "Load Locally will load any snapshots previously exported to your ./Export folder with the 'Save Locally' option. This will NOT affect your hourly graph, and these are only actually loaded once you open the 'Change Snapshot' prompt.";
                    this.Size = new Size(469, 236);
                    break;
            }
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
