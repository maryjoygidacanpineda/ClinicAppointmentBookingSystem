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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Admin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tglShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblInvalidUsername.Visible = false;
            lblInvalidPassword.Visible = false;

            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter both Username and Password.",
                     "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = ConnectDB.OpenConnection())
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM users WHERE Username=@username AND Password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // ✅ Use .Text, not the control itself
                        cmd.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", tbPassword.Text.Trim());

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmAppointment appointment = new frmAppointment();
                            appointment.Show();
                            this.Hide();
                        }
                        else
                        {
                            tbPassword.Clear();
                            tbUsername.Clear();
                            lblInvalidUsername.Visible = true;
                            lblInvalidPassword.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
