using Player.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class MainForm : Form
    {
        SettingsPage settings;
        public MainForm()
        {
            InitializeComponent();
            settings = new SettingsPage();
            settings.Location = new Point(0, -settings.Size.Height);
            this.Controls.Add(settings);
            settings.BringToFront();
        }
    }
}
