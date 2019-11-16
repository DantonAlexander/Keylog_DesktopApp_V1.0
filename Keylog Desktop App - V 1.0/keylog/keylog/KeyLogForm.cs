using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///
/// Code by - Danton Alexander
/// 
/// Version 1.0 - June 2019
/// 

namespace keylog
{
    public partial class KeyLogForm : Form
    {
        public KeyLogForm()
        {
            InitializeComponent();
        }


        //// Variables ////

        ListViewItem lvEventLog;
        int a, b;


        ///Form Load ////

        private void KeyLogForm_Load(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
        }


        //// Timers ////

        private void timer1_Tick(object sender, EventArgs e)
        {
            lvEventLog = new ListViewItem(Cursor.Position.X.ToString());
            lvEventLog.SubItems.Add(Cursor.Position.Y.ToString());
            listView1.Items.Add(lvEventLog);
            b++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (a != b)
            {
                Cursor.Position = new Point(int.Parse(listView1.Items[a].SubItems[0].Text), int.Parse(listView1.Items[a].SubItems[1].Text));
                a++;
            }
        }


        //// Buttons ////

        private void btnRec_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}
