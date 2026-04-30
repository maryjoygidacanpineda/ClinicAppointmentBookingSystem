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
    public partial class frmAppointment : Form
    {
        public frmAppointment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidetransition1.Start();
        }
        bool sidebarexpand = false;

        private void sidetransition1_Tick(object sender, EventArgs e)
        {
            int maxWidth = 350;   
            int minWidth = 0;     
            int speed = 60;    

            if (!sidebarexpand) 
            {
                side.Visible = true;
                side.Width += speed;

                if (side.Width >= maxWidth)
                {
                    side.Width = maxWidth;
                    sidebarexpand = true;
                    sidetransition1.Stop();
                }
            }
            else 
            {
                side.Width -= speed;

                if (side.Width <= minWidth)
                {
                    side.Width = minWidth;
                    sidebarexpand = false;
                    side.Visible = false;
                    sidetransition1.Stop();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter AppointmentId or Fullname to search.",
                    "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = ConnectDB.SearchAppointments(keyword);
            dgvAppointments.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No matching records found.",
                    "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {

            cbDoctor.DataSource = ConnectDB.GetDoctors();
            cbDoctor.DisplayMember = "Name";   // doctor name ang makita
            cbDoctor.ValueMember = "Name";
        }

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctor.SelectedValue != null)
            {
                string doctorName = cbDoctor.SelectedValue.ToString();
                dgvAppointments.DataSource = ConnectDB.GetAppointmentsByName(doctorName);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            FilterAppointmentsByStatus("Scheduled");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            FilterAppointmentsByStatus("Completed");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FilterAppointmentsByStatus("Cancelled");
        }
        private void FilterAppointmentsByStatus(string status)
        {
            if (cbDoctor.SelectedValue != null)
            {
                string doctorName = cbDoctor.SelectedValue.ToString();
                dgvAppointments.DataSource = ConnectDB.GetAppointmentsByDoctorAndStatus(doctorName, status);
            }
        }

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];

                // Fullname
                tbFullname.Text = row.Cells["fullname"].Value?.ToString();

                // Disease
                tbDisease.Text = row.Cells["disease"].Value?.ToString();

                // Appointment Date (safe handling)
                if (row.Cells["date"].Value != DBNull.Value)
                {
                    DateTime apptDate = Convert.ToDateTime(row.Cells["date"].Value);

                    if (apptDate >= dtpDate.MinDate && apptDate <= dtpDate.MaxDate)
                        dtpDate.Value = apptDate;
                    else
                        dtpDate.Value = DateTime.Today; // fallback
                }
                else
                {
                    dtpDate.Value = DateTime.Today; // default if null
                }

                // 🔹 Status ComboBox
                cbStatus.Items.Clear();
                cbStatus.Items.Add("Scheduled");
                cbStatus.Items.Add("Completed");
                cbStatus.Items.Add("Cancelled");

                if (row.Cells["status"].Value != DBNull.Value)
                {
                    string statusValue = row.Cells["status"].Value.ToString();
                    if (cbStatus.Items.Contains(statusValue))
                        cbStatus.SelectedItem = statusValue; // auto‑select current status
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvAppointments.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dgvAppointments.CurrentRow.Cells["appointmentid"].Value);

                string newStatus = cbStatus.SelectedItem?.ToString();
                DateTime newDate = dtpDate.Value;
                string newDisease = tbDisease.Text;

                // Update in DB
                ConnectDB.UpdateAppointment(appointmentId, newStatus, newDate, newDisease);

                MessageBox.Show("Appointment updated successfully!", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid
                string doctorName = cbDoctor.SelectedValue.ToString();
                dgvAppointments.DataSource = ConnectDB.GetAppointmentsByName(doctorName);

                // Optional: reselect updated row
                foreach (DataGridViewRow row in dgvAppointments.Rows)
                {
                    if (Convert.ToInt32(row.Cells["appointmentid"].Value) == appointmentId)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmAddAppointment add =new frmAddAppointment();
            add.Show();
            this.Hide();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
