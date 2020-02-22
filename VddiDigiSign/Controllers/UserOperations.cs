using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace VddiDigiSign.Controllers
{
    class UserOperations
    {

        public DataTable listStaff()
        {

            string strConnString = ConfigurationManager.ConnectionStrings["Olgarsconnection"].ConnectionString;

            Encrypt newCrypt = new Encrypt();
            DataTable staffDataTable = new DataTable();
            staffDataTable.Columns.Add("UserId", System.Type.GetType("System.Int32"));
            staffDataTable.Columns.Add("IndexNumber", System.Type.GetType("System.Int32"));
            staffDataTable.Columns.Add("UserTypeId", System.Type.GetType("System.String"));
            staffDataTable.Columns.Add("FirstName", System.Type.GetType("System.String"));
            staffDataTable.Columns.Add("LastName", System.Type.GetType("System.String"));
            staffDataTable.Columns.Add("EmailAddress", System.Type.GetType("System.String"));
            staffDataTable.Columns.Add("UserPassword", System.Type.GetType("System.String"));



            SqlConnection connct = new SqlConnection(strConnString);
            connct.Open();

            string strQuery = "select UserId,FirstName,LastName,Emailaddress,UserPassword,UserTypeId  from [User] where UserTypeId in (0,1,2,3) and DeleteStatus = 0";
            SqlCommand cmd = connct.CreateCommand();
            cmd.CommandText = strQuery;
            SqlDataReader getStaffdata = cmd.ExecuteReader();
            int IndexNum = 0;
            while (getStaffdata.Read())
            {
                IndexNum++;
                DataRow staffDataRecord = staffDataTable.NewRow();
                staffDataRecord["UserId"] = (Int32)getStaffdata["UserId"];
                staffDataRecord["IndexNumber"] = IndexNum;
                Int32 CurrentUserTypeId = (Int32)getStaffdata["UserTypeId"];
                if (CurrentUserTypeId == 0) { staffDataRecord["UserTypeId"] = "None Selected"; }
                if (CurrentUserTypeId == 1) { staffDataRecord["UserTypeId"] = "Administrator"; }
                if (CurrentUserTypeId == 2) { staffDataRecord["UserTypeId"] = "Application Team"; }
                if (CurrentUserTypeId == 3) { staffDataRecord["UserTypeId"] = "Dealer Manager"; }
                staffDataRecord["FirstName"] = (string)getStaffdata["FirstName"];
                staffDataRecord["LastName"] = (string)getStaffdata["LastName"];
                staffDataRecord["EmailAddress"] = (string)getStaffdata["EmailAddress"];
                staffDataRecord["UserPassword"] = (string)getStaffdata["UserPassword"];    // newCrypt.DecryptString((string)getStaffdata["UserPassword"]);
                staffDataTable.Rows.Add(staffDataRecord);
            }
            getStaffdata.Close();
            connct.Close();

            return staffDataTable;
        }


        public int checkUserType(string Email)
        {
            int checkedUser = 0;

            var db = new PetaPoco.Database("Olgarsconnection");

            checkedUser = db.ExecuteScalar<int>("SELECT [UserTypeId] FROM [User] WHERE EmailAddress=@0", Email);

            return checkedUser;
        }


        public int checkUserCreds(string Email, string Password)
        {
            int checkedUser = 0;

            Encrypt newCrypt = new Encrypt();

            string encPassword = newCrypt.EncryptString(Password);

            var db = new PetaPoco.Database("Olgarsconnection");

            try
            {
                checkedUser = db.ExecuteScalar<int>("SELECT Count(*) FROM [User] WHERE EmailAddress=@0 AND UserPassword=@1 AND SysStatus=0 and DeleteStatus=0", Email, encPassword);
            }
            catch (Exception ex)
            {
                string apiResponse = "";
                string sqlError = "";
                string exMessage = ex.Message.ToString();
                sqlError = db.LastSQL;

                apiResponse = exMessage;
                checkedUser = 0;
            }

            return checkedUser;
        }


        public int checkUser(string Email)
        {
            int checkedUser = 0;


            var db = new PetaPoco.Database("Olgarsconnection");

            checkedUser = db.ExecuteScalar<int>("SELECT Count(*) FROM [User] WHERE EmailAddress=@0", Email);

            return checkedUser;
        }

        public int addUser(Models.User currentUser)
        {
            int userId = -1;

            Encrypt newCrypt = new Encrypt();

            string encPassword = newCrypt.EncryptString(currentUser.UserPassword);

            currentUser.UserPassword = encPassword;

            //string test = "d72MUJuYNiBa38oAvGjdfw==";
            //string newval = newCrypt.DecryptString(test);


            var db = new PetaPoco.Database("Olgarsconnection");
            db.Insert("User", "UserId", true, currentUser);
            userId = currentUser.UserId;

            return userId;
        }

        public void updateUser(Models.User currentUser)
        {
            var db = new PetaPoco.Database("Olgarsconnection");
            db.Update("User", "UserId", currentUser);
        }

        public IEnumerable<Models.User> getUsers(int userType)
        {
            IEnumerable<Models.User> userList;
            var db = new PetaPoco.Database("Olgarsconnection");
            var sql = PetaPoco.Sql.Builder.Select("*").From("User").Where("UserTypeId = @UserTypeId", new { UserTypeId = userType });
            userList = db.Query<Models.User>(sql);
            return userList;
        }

        public Models.CurrentUser loadDetails(string emailAddress)
        {
            var db = new PetaPoco.Database("Olgarsconnection");

            Models.CurrentUser currentUserDetail = new Models.CurrentUser();
            currentUserDetail = db.SingleOrDefault<Models.CurrentUser>("select UserId,UserTypeId,FirstName,LastName,UserPassword,UserTitle,ProfilePic,AuthenticationType from [User] where EmailAddress =  @0 and SysStatus = 0 ", emailAddress);
            return currentUserDetail;
        }

        public Models.CurrentUser getDetailsWithId(string UserId)
        {
            var db = new PetaPoco.Database("Olgarsconnection");

            Models.CurrentUser currentUserDetail = new Models.CurrentUser();
            currentUserDetail = db.SingleOrDefault<Models.CurrentUser>("select UserId,UserTypeId,FirstName,LastName,EmailAddress,UserPassword,UserTitle,ProfilePic,AuthenticationType from [User] where UserId =  @0 and SysStatus = 0 ", UserId);
            return currentUserDetail;
        }

        public Models.CurrentUser getDetailsWithEmail(string UserEmail)
        {
            var db = new PetaPoco.Database("Olgarsconnection");

            Models.CurrentUser currentUserDetail = new Models.CurrentUser();
            currentUserDetail = db.SingleOrDefault<Models.CurrentUser>("select UserId,UserTypeId,FirstName,LastName,EmailAddress,UserPassword,UserTitle,ProfilePic,AuthenticationType from [User] where EmailAddress =  @0 and SysStatus = 0 ", UserEmail);
            return currentUserDetail;
        }


    }
}
