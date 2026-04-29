using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Admin
{
    public class ConnectDB
    {
        private static readonly string connectionString =
     "server=localhost;port=3306;user=root;password=;database=clinic_db;Allow Zero Datetime=True;Convert Zero Datetime=True;";


        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static MySqlConnection OpenConnection()
        {
            MySqlConnection conn = GetConnection();
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection Error!\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
        public static DataTable GetAllAppointments()
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT * FROM appointments";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetAppointmentsByDoctor(int doctorId)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT * FROM appointments WHERE DoctorId=@doctorId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable SearchAppointments(string keyword)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT * FROM appointments WHERE AppointmentId LIKE @keyword OR FullName LIKE @keyword";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetDoctors()
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT DoctorId, Name FROM doctors";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void UpdateStatus(int appointmentId, string status)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "UPDATE appointments SET Status=@status WHERE AppointmentId=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", appointmentId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
