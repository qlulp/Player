using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player.Controls
{
    public partial class Track : UserControl
    {
        public Track()
        {
            InitializeComponent();
        }

        public bool IsSelected = false;
        private void Track_MouseDown(object sender, MouseEventArgs e)
        {
            IsSelected = !IsSelected;
            if (IsSelected)
            {
                this.BackColor = Color.FromArgb(132, 103, 195);
                this.Line.BackColor = Color.FromArgb(132, 103, 195);
            }
            else
            {
                this.BackColor = Color.Transparent;
                this.Line.BackColor = Color.FromArgb(149, 119, 217);
            }
        }
    }
}
