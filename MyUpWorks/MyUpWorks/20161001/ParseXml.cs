using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


public class ParseXml
{
    /// <summary>
    /// True if Avaliable="true"
    /// False if Avaliable="false"
    /// null if Avaliable's value is Unknown
    /// </summary>
    /// <param name="xmlStr">The xml string need to parse</param>
    /// <returns></returns>
    public static bool? Parse(string xmlStr)
    {
        if (string.IsNullOrWhiteSpace(xmlStr))
        {
            return null;
        }

        xmlStr = xmlStr.Trim();
        try
        {
            XElement xe = XElement.Parse(xmlStr);
            XNamespace nameSpace = "http://api.namecheap.com/xml.response";
            string result = xe.Element(nameSpace+"CommandResponse").Element(nameSpace+"DomainCheckResult").Attribute("Available").Value;
            if (string.Compare(result, "false", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                return false;
            }
            else if (string.Compare(result, "true", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                return true;
            }
            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}

