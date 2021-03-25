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
    public class TestManager : DbManager
    {
        public void Create(Test t)
        {
            var connection = Connection;
            try
            {
                var sql = $"INSERT INTO ts_test_10023 (ts_name_10023,ts_q1_10023,ts_q1_answer_10023,ts_q2_10023,ts_q2_answer_10023,ts_q3_10023,ts_q3_answer_10023) VALUES ('{t.ts_name_10023}','{t.ts_q1_10023}','{t.ts_q1_answer_10023}','{t.ts_q2_10023}','{t.ts_q2_answer_10023}','{t.ts_q3_10023}','{t.ts_q3_answer_10023}')";
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

        public void Update(Test t)
        {
            var connection = Connection;
            try
            {
                var sql = $"UPDATE ts_test_10023 SET ts_name_10023='{t.ts_name_10023}', ts_q1_10023='{t.ts_q1_10023}', ts_q1_answer_10023='{t.ts_q1_answer_10023}', ts_q2_10023='{t.ts_q2_10023}', ts_q2_answer_10023='{t.ts_q2_answer_10023}', ts_q3_10023='{t.ts_q3_10023}', ts_q3_answer_10023='{t.ts_q3_answer_10023}' WHERE ts_id_10023='{t.ts_id_10023}')";
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
                var sql = $"DELETE FROM ts_test_10023 WHERE ts_id_10023={id}";
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

        public List<Test> GetAll()
        {
            var connection = Connection;
            var result = new List<Test>();
            try
            {
                var sql = "SELECT ts_id_10023, ts_name_10023, ts_q1_10023, ts_q1_answer_10023, ts_q2_10023, ts_q2_answer_10023, ts_q3_10023, ts_q3_answer_10023 FROM ts_test_10023";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var t = new Test
                    {
                        ts_id_10023 = Convert.ToInt32(reader.GetValue(0)),
                        ts_name_10023 = Convert.ToString(reader.GetValue(1)),
                        ts_q1_10023 = Convert.ToString(reader.GetValue(2)),
                        ts_q1_answer_10023 = Convert.ToString(reader.GetValue(3)),
                        ts_q2_10023 = Convert.ToString(reader.GetValue(4)),
                        ts_q2_answer_10023 = Convert.ToString(reader.GetValue(5)),
                        ts_q3_10023 = Convert.ToString(reader.GetValue(6)),
                        ts_q3_answer_10023 = Convert.ToString(reader.GetValue(7))
                    };
                    result.Add(t);
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

        public Test GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"SELECT ts_id_10023, ts_name_10023, ts_q1_10023, ts_q1_answer_10023, ts_q2_10023, ts_q2_answer_10023, t3_q3_10023, t3_q3_answer_10023 FROM ts_test_10023 WHERE ts_id_10023={id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var t = new Test
                    {
                        ts_id_10023 = Convert.ToInt32(reader.GetValue(0)),
                        ts_name_10023 = Convert.ToString(reader.GetValue(1)),
                        ts_q1_10023 = Convert.ToString(reader.GetValue(2)),
                        ts_q1_answer_10023 = Convert.ToString(reader.GetValue(3)),
                        ts_q2_10023 = Convert.ToString(reader.GetValue(4)),
                        ts_q2_answer_10023 = Convert.ToString(reader.GetValue(5)),
                        ts_q3_10023 = Convert.ToString(reader.GetValue(6)),
                        ts_q3_answer_10023 = Convert.ToString(reader.GetValue(7))
                    };
                    return t;
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
    }
}
