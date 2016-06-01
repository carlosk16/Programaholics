using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace TamayoWebFormCourseProjectWeb460.AppCode
{
    public class ClsDataLayer
    {
        public ClsDataLayer()
        {

        }
        OleDbConnection dbConnection;
        public ClsDataLayer(string Path)
        {
            dbConnection = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path);
        }

        public ProgramaholicsDataSet FindCustomer(string userName)
        {
            //Creates a connection and query the Customer table for the last name enetered 
            string sqlStmt = "select * from UserAccount where userName like '" + userName + "'";
            OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(sqlStmt, dbConnection);

            //creates dataset object
            ProgramaholicsDataSet myStoreDataSet = new ProgramaholicsDataSet();

            sqlDataAdapter.Fill(myStoreDataSet.UserAccount);

            return myStoreDataSet;//returns customer's information
        }

        //Method that Updates Customer information in the database
        public void UPdateAccount(string city, string state, string favProgLanguage, string leastFavProgLanguage, string dateLastProgCompleted)
        {


            //SQL update statement
            string sqlStmt =
                @"UPDATE UserAccount 
            SET 
            city = @city,
            state = @state,
            favLanguage = @favProgLanguage,
            leastFavLanguage = @leastFavProgLanguage,
            dateOfLastProgramCompleted = @dateLastProgCompleted,
            WHERE UserAccount.userID = @userID";



            //Object created to establish a connection and executes update statement
            OleDbCommand dbCommand = new OleDbCommand(sqlStmt, dbConnection);


            //Adds updated information to the database
            //OleDbParameter param = new OleDbParameter("@first", firstName); //This line of code was incorrect and commented out.

            dbCommand.Parameters.Add(new OleDbParameter("@city", city));
            dbCommand.Parameters.Add(new OleDbParameter("@state", state));
            dbCommand.Parameters.Add(new OleDbParameter("@favLanguage", favProgLanguage));
            dbCommand.Parameters.Add(new OleDbParameter("@leastFavLanguage", leastFavProgLanguage));
            dbCommand.Parameters.Add(new OleDbParameter("@dateOfLastProgramCompleted", dateLastProgCompleted));
            //dbCommand.Parameters.Add(new OleDbParameter("@userId", userID));

            try
            {
                //Opens database connection
                dbConnection.Open();
                //Executes
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                //Ensures the connection always closes
                dbConnection.Close();
            }
        }

        public ProgramaholicsDataSet GetPastApplications()
        {
            //Used to fill in the DataSet and update the data source
            OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter("SELECT * FROM PastApplications;", dbConnection);

            //Fills in the dataset
            ProgramaholicsDataSet myStoreDataSet = new ProgramaholicsDataSet();
            sqlDataAdapter.Fill(myStoreDataSet.PastApplications);

            //Returns the infomation stored in the table Customers
            return myStoreDataSet;
        }
    }
}