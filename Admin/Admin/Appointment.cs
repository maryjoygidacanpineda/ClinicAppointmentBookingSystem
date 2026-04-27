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
            LoadStatusCombo();

            // Attach events
            dgvAppointments.CellClick += dgvAppointments_CellClick;
            cbDoctor.SelectedIndexChanged += cbDoctor_SelectedIndexChanged;

            // ✅ Load all appointments by default
            dgvAppointments.DataSource = ConnectDB.GetAllAppointments();
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
        private void LoadStatusCombo()
        {
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Scheduled");
            cbStatus.Items.Add("Completed");
            cbStatus.Items.Add("Cancelled");
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

                object dateValue = row.Cells["DateTime"].Value;
                if (dateValue == DBNull.Value || string.IsNullOrWhiteSpace(dateValue.ToString()))
                {
                    tbDateandTime.Text = ""; // show empty
                }
                else
                {
                    tbDateandTime.Text = Convert.ToDateTime(dateValue).ToString("yyyy-MM-dd HH:mm:ss");
                }


                tbFullname.Text = row.Cells["FullName"].Value.ToString();
                cbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
                tbDisease.Text = row.Cells["Disease"].Value.ToString();
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

                string newDateTime = tbDateandTime.Text;
                string newFullName = tbFullname.Text;
                string newStatus = cbStatus.SelectedItem.ToString();
                string newDisease = tbDisease.Text;

                using (MySqlConnection conn = ConnectDB.OpenConnection())
                {
                    string query = @"UPDATE appointments 
                             SET DateTime=@dateTime, FullName=@fullName, Status=@status, Disease=@disease
                             WHERE AppointmentId=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dateTime", newDateTime);
                    cmd.Parameters.AddWithValue("@fullName", newFullName);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@disease", newDisease);
                    cmd.Parameters.AddWithValue("@id", appointmentId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                // ✅ Re-select the updated row
                foreach (DataGridViewRow row in dgvAppointments.Rows)
                {
                    if (Convert.ToInt32(row.Cells["AppointmentId"].Value) == appointmentId)
                    {
                        row.Selected = true;
                        dgvAppointments.CurrentCell = row.Cells[0]; // move cursor to first cell
                        break;
                    }
                }
            }
        }
    }
}
