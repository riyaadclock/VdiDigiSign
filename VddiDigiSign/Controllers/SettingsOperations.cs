using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace VddiDigiSign.Controllers
{
    public class SettingsOperations
    {
        public string getValue(string settingName)
        {
            string sysValue = "";
            string sysEnv = "";

            var db = new PetaPoco.Database("Olgarsconnection");
            sysEnv = ConfigurationManager.ConnectionStrings["SysEnvironment"].ConnectionString;

            sysValue = db.ExecuteScalar<string>("SELECT SysValue FROM [SysSettings] WHERE SysName=@0 AND SysEnvironment=@1 ", settingName, sysEnv);
            //sysValue = db.ExecuteScalar<string>("SELECT Max(SysValue) FROM [SysSettings] WHERE SysName=@0 ", settingName);

            return sysValue;
        }
    }
}