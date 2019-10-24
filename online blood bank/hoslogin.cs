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

namespace online_blood_bank
{
    public partial class hoslogin : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\online blood bank\online blood bank\hospitalregistration.mdf';Integrated Security=True;Connect Timeout=30";
        public hoslogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hosreg f1 = new hosreg();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            try
            {
                SqlConnection loginCon = default(SqlConnection);
                loginCon = new SqlConnection(cs);

                SqlCommand loginCom = default(SqlCommand);
                loginCom = new SqlCommand("SELECT email,Password FROM reg WHERE email = @email AND Password = @password", loginCon);

                SqlParameter uName = new SqlParameter("@email", SqlDbType.VarChar);
                SqlParameter uPass = new SqlParameter("@Password", SqlDbType.VarChar);
                uName.Value = textBox1.Text;
                uPass.Value = textBox2.Text;


                loginCom.Parameters.Add(uName);
                loginCom.Parameters.Add(uPass);

                loginCom.Connection.Open();

                SqlDataReader loginRead = loginCom.ExecuteReader(CommandBehavior.CloseConnection);

                if (loginRead.Read() == true)
                {
                    request mm = new request();
                    mm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (loginCon.State == ConnectionState.Open)
                    loginCon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hoslogin_Load(object sender, EventArgs e)
        {

        }
    }
}
