using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
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

        internal static void LockUserAccount(string username)
        {
            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString()))
            {
                con.Execute("UPDATE UserAccount SET Lockout = 1");
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



        public static List<PastApplication> GetPastApplications(int userAccountId)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("UserAccountId", userAccountId);

            //Used to fill in the DataSet and update the data source
            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString()))
            {
                return con.Query<PastApplication>("select * from PastApplications where UserAccountId = @UserAccountId", p).ToList();
            }
        }

        //Method that Deletes Customer information in the database
        public static int DeleteAccount(int userAccountId)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("UserAccountId", userAccountId);
            

            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString()))
            {
                return con.Execute(@"Delete UserAccount where ID = @UserAccountId", p);
            }
        }

        // Function name Authentication which will get check the user_name and passwrod from sql database then return a value true or false
        public static Boolean Authentication(string username, string password)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("UserName", username);
            p.Add("Password", password);

            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString()))
            {
                return con.Query<UserAccount>("Select * from [UserAccount] where UserName = @UserName AND Password = @Password" , p).Any();
            }           
        }
    }

    static class Serialize 
    {
        public static string SerializeObject<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }
    }   

}