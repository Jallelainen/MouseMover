using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseMover
{
    /// <summary>
    /// This code was taken from: http://www.aspdotnet-pools.com/2017/10/move-mouse-cursor-automatically-c.html
    /// Added Random class to do random moves.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Random rn = new();
            Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - rn.Next(-400, 400), Cursor.Position.Y - rn.Next(-400, 400));
        }
    }
}
