using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class dbcon
    {
        public SqlConnection DbConnection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UL4JOR7;Initial Catalog=OfcDB;Integrated Security=True");
            return conn;
        }

        public bool query_iud(String query)
        {
            bool check = false;
            try
            {
                SqlConnection conn = DbConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (SqlException ex)
            {
                String exc = ex.Message;
                check = false;
            }
            return check;
        }


        public DataTable search(String query)
        {
            //string[] data = new string[3];
            DataTable dt = new DataTable();

            try
            {

                SqlConnection conn = DbConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                conn.Open();
                da.Fill(dt);



                //SqlCommand cd = new SqlCommand(query, conn);
                //SqlDataReader reader = cd.ExecuteReader();
                //while (reader.Read())
                //{
                //    data[0] = reader["name"].ToString();
                //    data[1] = reader["cell"].ToString();
                //    data[2] = reader["address"].ToString();
                //}

            }
            catch (SqlException ex)
            {
                String exc = ex.Message;
            }
            return dt;
        }

        public int login(string query)
        {
            int a = 0;
            try
            {
                SqlConnection conn = DbConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sd = cmd.ExecuteReader();
                DataTable dt = sd.GetSchemaTable();
                if (sd.HasRows)
                {
                    if (sd.Read())
                    {
                        return a = Convert.ToInt32(sd["access_level"].ToString());
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    string aaa = dt.Rows[0]["accessLavel"].ToString();
                }

            }
            catch (Exception)
            {

                a = 0;
            }
            return a;
        }


    }
}
