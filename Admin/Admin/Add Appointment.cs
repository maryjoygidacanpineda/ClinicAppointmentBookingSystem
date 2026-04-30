using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmAddAppointment : Form
    {
        public frmAddAppointment()
        {
            InitializeComponent();
        }
       
        // 🔹 Auto Age Calculation
        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            tbAge.Text = CalculateAge(dtpBirthdate.Value).ToString();
        }

        private int CalculateAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            if (birthdate.Date > today.AddYears(-age)) age--;

            return age;
        }
        private void LoadGenderOptions()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
        }
        private void ClearFields()
        {
            tbFullname.Clear();
            tbAge.Clear();
            tbContact.Clear();
            tbDisease.Clear();

            tbAllergies.Clear();
            tbMedication.Clear();
            tbHistory.Clear();

            cmbGender.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            cmbPayment.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB.AddAppointment(
                    tbFullname.Text,
                    dtpBirthdate.Value,
                    Convert.ToInt32(tbAge.Text),
                    cmbGender.Text,
                    tbContact.Text,
                    tbDisease.Text,
                    tbAllergies.Text,
                    tbMedication.Text,
                    tbHistory.Text,
                    dtpDate.Value,
                    Convert.ToInt32(cmbDoctor.SelectedValue),
                    cmbPayment.Text,
                    cmbStatus.Text
                );

                MessageBox.Show("Appointment Added Successfully!");
                ClearFields();

                frmAppointment appointment = new frmAppointment();
                appointment.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
            cmbDoctor.DataSource = ConnectDB.GetDoctors();
            cmbDoctor.DisplayMember = "Name";
            cmbDoctor.ValueMember = "doctorid";
            LoadPaymentOptions();
            LoadStatusOptions();

            LoadGenderOptions();
            dtpBirthdate.ValueChanged += dtpBirthdate_ValueChanged;
            tbAge.Text = CalculateAge(dtpBirthdate.Value).ToString();
        }
        private void LoadPaymentOptions()
        {
            cmbPayment.Items.Clear();
            foreach (var method in ConnectDB.GetPaymentMethods())
            {
                cmbPayment.Items.Add(method);
            }
        }

        private void LoadStatusOptions()
        {
            cmbStatus.Items.Clear();
            foreach (var status in ConnectDB.GetStatuses())
            {
                cmbStatus.Items.Add(status);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frmAppointment appointment = new frmAppointment();
            appointment.Show();
            this.Hide();
        }
    }
}
