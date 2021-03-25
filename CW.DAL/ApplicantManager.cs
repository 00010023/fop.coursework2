using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data;

namespace CW.DAL
{
    public class ApplicantManager : DbManager
    {
        public void Create(Applicant a)
        {
            var connection = Connection;
            try
            {
                var sql = $"INSERT INTO ap_applicant_10023 (ap_name_10023,ap_score_10023,ap_tests_taken_10023) VALUES ('{a.ap_name_10023}','{a.ap_score_10023}','{a.ap_tests_taken_10023}')";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void Update(Applicant a)
        {
            var connection = Connection;
            try
            {
                var sql = $"UPDATE ap_applicant_10023 SET ap_name_10023='{a.ap_name_10023}', ap_score_10023='{a.ap_score_10023}', ap_tests_taken_10023='{a.ap_tests_taken_10023}' WHERE ap_id_10023='{a.ap_id_10023}')";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM ap_applicant_10023 WHERE ap_id_10023={id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public List<Applicant> GetAll()
        {
            var connection = Connection;
            var result = new List<Applicant>();
            try
            {
                var sql = "SELECT ap_id_10023, ap_name_10023, ap_score_10023, ap_tests_taken_10023 FROM ap_applicant_10023";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public Applicant GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"SELECT ap_id_10023, ap_name_10023, ap_score_10023, ap_tests_taken_10023 FROM ap_applicant_10023 WHERE ap_id_10023={id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var a = GetFromReader(reader);
                    return a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return null;
        }

        private Applicant GetFromReader(SqlCeDataReader reader)
        {
            var a = new Applicant
            {
                ap_id_10023 = Convert.ToInt32(reader.GetValue(0)),
                ap_name_10023 = reader.GetValue(1).ToString(),
                ap_score_10023 = Convert.ToInt32(reader.GetValue(2)),
                ap_tests_taken_10023 = reader.GetValue(3).ToString()
            };

            return a;
        }
    }
}
