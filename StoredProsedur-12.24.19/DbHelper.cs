using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StoredProsedur_12._24._19
{
    
    static class DbHelper
    {
        private static string connectionString = "Data Source=DESKTOP-8T1KHOD;Initial Catalog=UniversityDb;Integrated Security=True";

        public static DataTable GetAllStudents()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            SqlCommand command = new SqlCommand("GetAllStudents", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public static int GetStudentCountWithAge(int age)
        {
            int count = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            SqlCommand command = new SqlCommand("GetStudentCountWithAge", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("age", age);
            count =Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return count;
        }
    }
}
