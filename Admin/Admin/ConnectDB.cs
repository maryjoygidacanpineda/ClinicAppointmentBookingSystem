using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
       
        public static DataTable GetData(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static DataTable SearchAppointments(string keyword)
        {
            string query = @"SELECT * FROM appointments 
                     WHERE AppointmentId LIKE @keyword 
                        OR Fullname LIKE @keyword";

            return GetData(query, new MySqlParameter("@keyword", "%" + keyword + "%"));
        }
    
        public static DataTable GetDoctors()
        {
            string query = "SELECT DoctorId, Name FROM doctors";
            return GetData(query);
        }

        public static DataTable GetAppointmentsByName(string Name)
        {
            string query = @"SELECT a.* 
                     FROM appointments a
                     INNER JOIN doctors d ON a.DoctorId = d.DoctorId
                     WHERE d.Name = @Name";
            return GetData(query, new MySqlParameter("@Name", Name));
        }
        public static DataTable GetAppointmentsByDoctorAndStatus(string Name, string status)
        {
            string query = @"SELECT a.* 
                     FROM appointments a
                     INNER JOIN doctors d ON a.DoctorId = d.DoctorId
                     WHERE d.Name = @Name AND a.Status = @status";

            return GetData(query,
                new MySqlParameter("Name", Name),
                new MySqlParameter("@status", status));
        }

        //Add Appointment
        public static void ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void AddAppointment(string fullname, DateTime birthdate, int age, string gender,
                                      string contactinfo, string disease, string allergies, string medication,
                                      string history, DateTime appointmentDate, int doctorId,
                                      string paymentMethod, string status)
        {
            string query = @"INSERT INTO appointments
                        (fullname, birthdate, age, gender, contactinfo, disease,
                         allergies, medication, history,
                         datetime, doctorid,
                         paymentmethod, status)
                        VALUES
                        (@fullname, @birthdate, @age, @gender, @contactinfo, @disease,
                         @allergies, @medication, @history,
                         @datetime, @doctorid,
                         @paymentmethod, @status)";

            ExecuteQuery(query,
                new MySqlParameter("@fullname", fullname),
                new MySqlParameter("@birthdate", birthdate),
                new MySqlParameter("@age", age),
                new MySqlParameter("@gender", gender),
                new MySqlParameter("@contactinfo", contactinfo),
                new MySqlParameter("@disease", disease),
                new MySqlParameter("@allergies", allergies),
                new MySqlParameter("@medication", medication),
                new MySqlParameter("@history", history),
                new MySqlParameter("@datetime", appointmentDate),
                new MySqlParameter("@doctorid", doctorId),
                new MySqlParameter("@paymentmethod", paymentMethod),
                new MySqlParameter("@status", status)
            );
        }
        public static List<string> GetPaymentMethods()
        {
            return new List<string>
        {
            "Cash",
            "Credit Card",
            "Debit Card",
            "Insurance"
        };
        }

        // 🔹 Status Options
        public static List<string> GetStatuses()
        {
            return new List<string>
        {
            "Scheduled",
            "Cancelled",
            "Completed"
        };
        }
        public static void UpdateAppointment(int appointmentId, string status, DateTime date, string disease)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE appointments 
                         SET status = @status, date = @date, disease = @disease
                         WHERE appointmentid = @appointmentid";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@disease", disease);
                cmd.Parameters.AddWithValue("@appointmentid", appointmentId);
                cmd.ExecuteNonQuery();
            }
        }

    }

}
