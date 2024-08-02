using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;



namespace Quadiro_Technologies
{
    public partial class insert : Form
    {
        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST;DATABASE=user;UID=root;PASSWORD=Mom@123;");

        public insert()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
               // int p = int.Parse(textBox2.Text);
                //int q = int.Parse(textBox3.Text);
                MySqlDataAdapter db = new MySqlDataAdapter("insert into cardetails values('"+textBox1.Text+"',"+textBox2.Text+","+textBox3.Text+");", con);
                DataSet ds = new DataSet();
                db.Fill(ds);
                MessageBox.Show("item is added sucessfully");

                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
        }
    }
}
