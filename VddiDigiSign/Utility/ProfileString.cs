using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProfileString
/// </summary>
public class ProfileString
{
	public string GetAppSetting(string iniValue)
    {
        string tempValue = "";

        try
        {
            tempValue = System.Configuration.ConfigurationManager.AppSettings[iniValue].ToString();
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }

        
        return tempValue;
    }

    public string GetProfileString(string iniValue)
    {
        string tempValue = "";

        try
        {
            tempValue = System.Configuration.ConfigurationManager.ConnectionStrings[iniValue].ToString();
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }

        return tempValue;
    }
}