using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// Summary description for DbValueCheck
/// </summary>
public class DbValueCheck
{
	public DbValueCheck()
	{
	
	}

    public string ConvertXMLString(XmlDocument xmlDoc)
    {
        StringWriter sw = new StringWriter();
        XmlTextWriter tx = new XmlTextWriter(sw);
        xmlDoc.WriteTo(tx);
        string strXmlText = sw.ToString();
        return strXmlText;
    }

    public string DoQuotes(string sql)
    {
        if (sql == null)
            return "";
        else
            return sql.Replace("'", "''");
    }

    public string GenerateId()
    {
        long i = 1;
        foreach (byte b in Guid.NewGuid().ToByteArray())
        {
            i *= ((int)b + 1);
        }
        return i.ToString();
    }



    public string GetDate()
    {
        DateTime DateTimeValue = DateTime.Now;

        return DateTimeValue.ToString("yyyy-MM-dd");
    }

    public string IsDateNull(string checkValue)
    {
        if (String.IsNullOrEmpty(checkValue))
        {
            return "";
        }
        else
        {
            DateTime DateTimeValue = Convert.ToDateTime(checkValue);

            return DateTimeValue.ToShortDateString();
        }
            
    }

    public String IsNull(string checkValue)
    {
        if (String.IsNullOrEmpty(checkValue))
            return "";
        else
            return checkValue;
    }

    public int ParseDbInt(string checkValue)
    {
        int d = 0;
        if (!int.TryParse(checkValue, out d))
        {
            return 0;
        }
        return d;
    }

    public decimal ParseDbDecimal(string checkValue)
    {
        decimal d = 0;
        if (!decimal.TryParse(checkValue, out d))
        {
            return 0;
        }
        return d;
    }

   
}