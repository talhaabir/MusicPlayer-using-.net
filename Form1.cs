using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginXMusicplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=testlogin;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source= PIYAL\SQLEXPRESS; Initial Catalog = testlogin; Integrated Security = True;");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login_1 where username= '" + textBox1.Text + "' and password= '" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")


            {
                this.Hide();
                Main mm = new Main();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct username & password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
