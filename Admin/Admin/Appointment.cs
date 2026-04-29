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

namespace Admin
{
    public partial class frmAppointment : Form
    {
        public frmAppointment()
        {
            InitializeComponent();
            LoadDoctors();

            dgvAppointments.DataSource = ConnectDB.GetAllAppointments();

            dgvAppointments.CellClick += dgvAppointments_CellClick;
            cbDoctor.SelectedIndexChanged += cbDoctor_SelectedIndexChanged;
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
        // Load doctors into ComboBox
        private void LoadDoctors()
        {
            cbDoctor.DataSource = ConnectDB.GetDoctors();
            cbDoctor.DisplayMember = "FullName";
            cbDoctor.ValueMember = "DoctorId";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAppointments.DataSource = ConnectDB.SearchAppointments(tbSearch.Text.Trim());
        }

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];
                tbFullname.Text = row.Cells["FullName"].Value?.ToString();
                tbDisease.Text = row.Cells["Disease"].Value?.ToString();
                cbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
                tbDateandTime.Text = row.Cells["DateTime"].Value?.ToString();
            }
        }


        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctor.SelectedValue != null && cbDoctor.SelectedValue is int)
            {
                int doctorId = (int)cbDoctor.SelectedValue;
                dgvAppointments.DataSource = ConnectDB.GetAppointmentsByDoctor(doctorId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value);
                string newStatus = cbStatus.SelectedItem?.ToString();

                // ✅ Update only the Status
                ConnectDB.UpdateStatus(appointmentId, newStatus);

                MessageBox.Show("Status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView
                if (cbDoctor.SelectedValue != null)
                {
                    int doctorId = Convert.ToInt32(cbDoctor.SelectedValue);
                    dgvAppointments.DataSource = ConnectDB.GetAppointmentsByDoctor(doctorId);
                }
                else
                {
                    dgvAppointments.DataSource = ConnectDB.GetAllAppointments();
                }

                // ✅ Reselect updated row
                foreach (DataGridViewRow row in dgvAppointments.Rows)
                {
                    if (Convert.ToInt32(row.Cells["AppointmentId"].Value) == appointmentId)
                    {
                        row.Selected = true;
                        dgvAppointments.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }
    }
}
