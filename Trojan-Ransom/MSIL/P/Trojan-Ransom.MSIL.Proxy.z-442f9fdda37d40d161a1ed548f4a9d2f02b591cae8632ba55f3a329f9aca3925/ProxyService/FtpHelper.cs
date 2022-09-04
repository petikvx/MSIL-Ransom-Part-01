using System;
using System.IO;
using System.Net;

namespace ProxyService;

public class FtpHelper
{
	public static string GetXml(string uri, string user, string pass, bool noproxy)
	{
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(uri);
			ftpWebRequest.Method = "RETR";
			if (noproxy)
			{
				ftpWebRequest.Proxy = null;
			}
			FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
			Stream responseStream = ftpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			ftpWebResponse.Close();
			return result;
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string GetXml(string uri, string user, string pass)
	{
		string xml = GetXml(uri, user, pass, noproxy: false);
		if (xml == "")
		{
			return GetXml(uri, user, pass, noproxy: true);
		}
		return "";
	}
}
