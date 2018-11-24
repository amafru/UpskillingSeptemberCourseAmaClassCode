using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementAPIAutomation.Hooks
{
    public class DatabaseHelper
    {
        //COPIED FROM COURSE MGT SYSTEM automation project
        //database connection string
        //This connects our test framework with the database server for this particular AUT

        //The first part "DESKTOP-TKEH56A\SQLEXPRESS" is the sql server name (The double slashes "\\" after the server name is important. Otherwise VS doesn't recognise the string
        //"CourseManagementSystem.Models.SchoolContext" (the specific database within the server) is also specified in the middle of the string
        //We use a passing argrument in the "ClearTable" method below, to define the particular table within the database.
        //And the expression "[dbo].["table"] below also further helps VS identify the specific table


        string connectionString = "Data Source=DESKTOP-TKEH56A\\SQLEXPRESS;Initial Catalog=TaskManagementApiContext-20180716192646; Integrated Security=True;MultipleActiveResultSets=True";

        public void ClearTable(string table)
        {
            string query = "Delete from [dbo].[" + table + "]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void PopulateOneRecordProjectTable()
        {
            string query1 = @"INSERT INTO Projects([Name])
                             VALUES('Test Automation')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void PopulateMultipleRecordsToProjectTable()
        {
            string query2 = @"INSERT INTO Projects([Name])
                             VALUES('Test Automation')";

            string query3 = @"INSERT INTO Projects([Name])
                             VALUES('Manual Testing')";

            string query4 = @"INSERT INTO Projects([Name])
                             VALUES('Unit Testing')";

            string query5 = @"INSERT INTO Projects([Name])
                             VALUES('API Testing')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = query2;
                    command.ExecuteNonQuery();

                    command.CommandText = query3;
                    command.ExecuteNonQuery();

                    command.CommandText = query4;
                    command.ExecuteNonQuery();

                    command.CommandText = query5;
                    command.ExecuteNonQuery();
                }
            }
        }

        public int SelectARecordFromProjectTable()
        {
            int result = 0;
            string query = "Select Id from [dbo].[Projects]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    result = (Int32)(command.ExecuteScalar());
                }
            }

            return result;
        }
    }
}
