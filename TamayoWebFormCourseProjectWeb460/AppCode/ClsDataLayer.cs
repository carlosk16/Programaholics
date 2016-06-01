using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TamayoWebFormCourseProjectWeb460.Models;

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

        public static UserAccount FindCustomer(string userName)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("Username", userName);

            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString()))
            {
                return con.Query<UserAccount>("select * from UserAccount where UserName = @Username", p).SingleOrDefault();
            }           
        }

        //Method that Updates Customer information in the database
        public static int UpdateAccount(int id, string city, string state, string favProgLanguage, string leastFavProgLanguage, string dateLastProgCompleted)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("ID", id);
            p.Add("City", city);
            p.Add("State", state);
            p.Add("FavProgrammingLanguage", favProgLanguage);
            p.Add("LeastFavProgrammingLanguage", leastFavProgLanguage);
            p.Add("DateLastCompleted", dateLastProgCompleted);

            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString()))
            {
                return con.Execute(@"update UserAccount 
                        set 
                        City = @City, 
                        State = @State, 
                        FavLanguage = @FavProgrammingLanguage,
                        LeastFavLanguage = @LeastFavProgrammingLanguage,
                        DateOfLastProgramCompleted = @DateLastCompleted
                        where ID = @ID", p);
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