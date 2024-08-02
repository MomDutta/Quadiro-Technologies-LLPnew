using MySql.Data.MySqlClient;
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
    public partial class update : Form
    {

        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST;DATABASE=user;UID=root;PASSWORD=Mom@123;");


        public update()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(" update cardetails set price="+price.Text+" where name='"+name.Text+"' and manufacturingyear="+year.Text+";", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("item is updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" item is not updated");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            price.Clear();
            year.Clear();
            name.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin am = new admin();
            am.Show();
            this.Hide();
        }
    }
}
