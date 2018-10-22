using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystemAutomation.Hooks
{
    public class DatabaseHelper

    {

        //database connection string
        //This connects our test framework with the database server for this particular AUT

        //The first part "DESKTOP-TKEH56A\SQLEXPRESS" is the sql server name (The double slashes "\\" after the server name is important. Otherwise VS doesn't recognise the string
        //"CourseManagementSystem.Models.SchoolContext" (the specific database within the server) is also specified in the middle of the string
        //We use a passing argrument in the "ClearTable" method below, to define the particular table within the database.
        //And the expression "[dbo].["table"] below also further helps VS identify the specific table

        

        string connectionString = "Data Source=DESKTOP-TKEH56A\\SQLEXPRESS;Initial Catalog=CourseManagementSystem.Models.SchoolContext; Integrated Security=True;MultipleActiveResultSets=True";

        public void ClearTable(string table)
        {
            string query = "";
            if (table.Equals("Person"))
            {
                query = "Delete from [dbo].[" + table + "] where Discriminator = 'Student'";
            }
            else
            {
                query = "Delete from [dbo].[" + table + "]";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
