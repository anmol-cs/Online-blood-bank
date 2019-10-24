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
    public partial class donar_registeration : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\online blood bank\online blood bank\hospitalregistration.mdf';Integrated Security=True;Connect Timeout=30";
        public donar_registeration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void donar_registeration_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            try
            {
                using (SqlConnection signupCon = new SqlConnection(cs))
                {
                    signupCon.Open();
                    using (SqlCommand signupCom = new SqlCommand("insert into donor ([email], [password], [name]) values(@email,@pass,@name)", signupCon))
                    {
                        signupCom.Parameters.AddWithValue("@email", textBox3.Text);
                        signupCom.Parameters.AddWithValue("@pass", textBox4.Text);
                        signupCom.Parameters.AddWithValue("@name", textBox1.Text);
                        signupCom.ExecuteNonQuery();
                        //MessageBox.Show("Registered Successfully", "Successful", MessageBoxButtons.OK);
                        successreg f1 = new successreg();
                        f1.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
