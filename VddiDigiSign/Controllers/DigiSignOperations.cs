namespace VddiDigiSign.Controllers
{
    public class DigiSignOperations
    {
        //LoggingOperations logOps = new LoggingOperations();

        public Models.DigiSignature loadSignature(string residentId)
        {
            var db = new PetaPoco.Database("Olgarsconnection");

            Models.DigiSignature ApplicationSignatureDetail = new Models.DigiSignature();
            ApplicationSignatureDetail = db.SingleOrDefault<Models.DigiSignature>("select * from DigiSignature where ResidentId = @0", residentId);
            return ApplicationSignatureDetail;
        }

        public int checkSignature(string residentId)
        {
            int checkLead;
            //Just checked for the Filter
            var db = new PetaPoco.Database("Olgarsconnection");

            checkLead = db.ExecuteScalar<int>("SELECT Count(*) FROM DigiSignature where ResidentId=@0", residentId);

            return checkLead;
            }

         public int getSignatureId(string residentId)
        {
            int latestSignatureId = 0;

            string leadCheck = "";

            leadCheck = "SELECT Max(DigiSignatureId) FROM [DigiSignature] WHERE [ResidentId]=@0";

            var db = new PetaPoco.Database("Olgarsconnection");
            latestSignatureId = db.ExecuteScalar<int>(leadCheck, residentId);
            return latestSignatureId;
        }

        public string getCustomerName(string residentId)
        {
            string latestSignatureId = "Not Found";

            string leadCheck = "";

            leadCheck = "SELECT Max(FirstName) + ' ' + Max(LastName) FROM [ApplicationLeads] WHERE [ResidentId]=@0";

            var db = new PetaPoco.Database("Olgarsconnection");
            latestSignatureId = db.ExecuteScalar<string>(leadCheck, residentId);
            return latestSignatureId;
        }


        public int addSignature(Models.DigiSignature currentSignatureObject)
        {

            int currentObjectId = -1;
            var db = new PetaPoco.Database("Olgarsconnection");
            db.Insert("DigiSignature", "DigiSignatureId", true, currentSignatureObject);
            currentObjectId = currentSignatureObject.DigiSignatureId;
            return currentObjectId;

        }

        public int DeleteSignature(string residentId)
        {
            int sigDeleteId = 0;

            var db = new PetaPoco.Database("Olgarsconnection");

            sigDeleteId = db.Execute("delete from DigiSignature where ResidentId =  @0 ", residentId);

            return sigDeleteId;

        }

        public void updateDigiSignature(Models.DigiSignature currentUserSignature)
        {

            var db = new PetaPoco.Database("Olgarsconnection");
            db.Update("DigiSignature", "DigiSignatureId", currentUserSignature, new string[] { "ResidentInitial", "ResidentSignature", "SalesInitial", "SalesSignature", "WitnessInitial", "WitnessSignature", "WitnessName" });

        }



    }
}
