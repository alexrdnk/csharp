using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Accounting.Classes
{
    internal class HomeAccClass
    {

        //Getter Setter Properties
        //Acts s Data Carrier in Our Application

        public int AccountID { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting Data from DataBase
        public DataTable Select()
        {
            //Step 1: Database Connection
            SqlConnection sqlConnection = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM tbl_account";
                //Creating and using sql and sqlConnection
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                sqlConnection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {

                sqlConnection.Close();
            }
            return dt;
        }

        //Inserting data from database
        public bool Insert(HomeAccClass cls)
        {
            //Creating a default type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database
            SqlConnection sqlConnection = new SqlConnection(myconnstrng);
            try
            {
                //Step 2: Create a SQL Query to insert Data
                string sql = "INSERT INTO tbl_account (Name, Balance) Values (@Name, @Balance)";
                //Creating SQL Command using sql and sqlConnection
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                //Create Parametres to add data
                cmd.Parameters.AddWithValue("@Name", cls.Name);
                cmd.Parameters.AddWithValue("@Balance", cls.Balance);
                //Connection Open Here
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the query runs successfully then the value of rows will be greater than zero else its value will be o
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            { sqlConnection.Close(); }
            return isSuccess;
        }

        //Method to update data in database from our application
        public bool Update(HomeAccClass cls)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;

            SqlConnection sqlConnection = new SqlConnection(myconnstrng);

            try
            {

                //SQL to update data in our Database
                string sql = "UPDATE tbl_account SET Name = @Name, Balance = @Balance WHERE AccountID = @AccountID";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);

                //Create Parametres to add data
                cmd.Parameters.AddWithValue("@Name", cls.Name);
                cmd.Parameters.AddWithValue("@Balance", cls.Balance);
                cmd.Parameters.AddWithValue("@AccountID", cls.AccountID);
                //Connection Open
                sqlConnection.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query runs successfully then the value of rows will be greater than the zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally { sqlConnection.Close(); }
            return isSuccess;
        }

        //Method to Delete Data from DataBase
        public bool Delete(HomeAccClass cls)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;
            //Create SQL Connection
            SqlConnection sqlConnection = new SqlConnection(myconnstrng);
            try
            {
                //SQL to Delete Data
                string sql = "DELETE FROM tbl_account WHERE AccountID = @AccountID";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@AccountID", cls.AccountID);
                //Open Connection
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the query run successfully then the value of rows is greater than zero else its value is 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally { sqlConnection.Close(); }
            return isSuccess;
        }
    }
}
