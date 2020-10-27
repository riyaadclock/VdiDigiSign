using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for VSLog
/// </summary>
public class VSLog
{
    static ProfileString profile = new ProfileString();

	public VSLog()
	{
    }

    string errorFile = profile.GetAppSetting("ErrorPath");

    public string GetFileName()
    {
        string appRun = "";

        appRun = "VdiScan" + System.DateTime.Today.ToString("yyyyMMdd");

        return appRun;
    }


    public void Log(string logMessage, TextWriter w)
    {
        w.Write("\r\nLog Entry : ");
        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString());
        w.WriteLine("  :");
        w.WriteLine("  :{0}", logMessage);
        w.WriteLine("-------------------------------");
    }

    public void WriteDebug(string recText)
    {
        string currentErorFile = "";

        currentErorFile = errorFile + GetFileName() + ".log";

        if (!File.Exists(currentErorFile))
        {
            using (StreamWriter sw = File.CreateText(currentErorFile))
            {
                Log(recText, sw);
            }
        }
        else
        {
            using (StreamWriter w = File.AppendText(currentErorFile))
            {
                Log(recText, w);
            }
        }
      }
}