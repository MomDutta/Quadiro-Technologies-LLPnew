using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadiro_Technologies
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert cs = new insert();
            cs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select cs = new select();
            cs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update cs = new update();
            cs.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delete db = new delete();
            db.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
