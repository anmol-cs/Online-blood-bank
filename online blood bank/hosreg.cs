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
    public partial class hosreg : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\online blood bank\online blood bank\hospitalregistration.mdf';Integrated Security=True;Connect Timeout=30";
        public hosreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home f1 = new home();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "")
            {
                MessageBox.Show("Please enter email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox14.Focus();
                return;
            }
            if (textBox14.Text == "")
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox14.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please enter name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return;
            }
            try
            {
                using (SqlConnection signupCon = new SqlConnection(cs))
                {
                    signupCon.Open();
                    using (SqlCommand signupCom = new SqlCommand("insert into reg ([email], [password], [name]) values(@email,@pass,@name)", signupCon))
                    {
                        signupCom.Parameters.AddWithValue("@email", textBox13.Text);
                        signupCom.Parameters.AddWithValue("@pass", textBox14.Text);
                        signupCom.Parameters.AddWithValue("@name", textBox4.Text);
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
            this.Close();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
