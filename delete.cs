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
using System.Xml.Linq;

namespace Quadiro_Technologies
{
    public partial class delete : Form
    {

        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST;DATABASE=user;UID=root;PASSWORD=Mom@123;");


        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(" DELETE FROM cardetails WHERE name='"+namenew.Text+"' and manufacturingyear="+yearnew.Text+";", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("item is deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" item is not deleted");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            namenew.Clear();
            yearnew.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
        }
    }
}
