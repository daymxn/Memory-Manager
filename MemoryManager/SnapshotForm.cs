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
    public partial class SnapshotForm : Form
    {
        public SnapshotForm()
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
        public delegate void SnapshotChoseEventHandler(object source, Snapshot args);
        public event SnapshotChoseEventHandler SnapshotChosen;

        protected virtual void OnSnapshotChosen(Snapshot snapshot)
        {
            SnapshotChosen?.Invoke(this, snapshot);
            this.Close();
        }

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

        public void AddSnapshot(Snapshot snapshot)
        {
            Panel newPanel = new Panel
            {
                BackColor = Color.FromArgb(231, 231, 231),
                Size = new Size(398, 49)
            };
            Label creationDateLabel = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font(new FontFamily("Verdana"), 8.25f),
                Text = "Creation Date:",
                Parent = newPanel,
                Location = new Point(3, 10)
            };
            Label creationDate = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font(new FontFamily("Verdana"), 8.25f),
                Text = snapshot.DateTaken.ToShortDateString() + " " + snapshot.DateTaken.ToLongTimeString(),
                Parent = newPanel,
                Location = new Point(3, 23)
            };
            creationDate.BringToFront();
            Label safeModeLabel = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font(new FontFamily("Verdana"), 8.25f),
                Text = "Safe Mode:",
                Parent = newPanel,
                Location = new Point(131, 10)
            };
            Label safeMode = new Label
            {
                BackColor = Color.Transparent,
                Font = new Font(new FontFamily("Verdana"), 8.25f),
                Text = (snapshot.SafeMode) ? "ON " : "OFF",
                Parent = newPanel,
                Location = new Point(148, 23)
            };
            safeMode.BringToFront();
            Button selectButton = new Button
            {
                BackColor = Color.FromArgb(231, 231, 231),
                Font = new Font(new FontFamily("Verdana"), 8.25f),
                Parent = newPanel,
                Text = "SELECT",
                FlatStyle = FlatStyle.Flat,
                Location = new Point(224, 3),
                Size = new Size(171, 43)
            };
            selectButton.BringToFront();
            selectButton.Click += (sender, args) =>
            {
                // raise event for selection
                OnSnapshotChosen(snapshot);
            };

            newPanel.Parent = this.snapshotLayoutPanel;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
