using System;
using System.IO;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;

namespace AdobeInstall;

public class FtpHelper
{
	public static string DownloadText(string uri)
	{
		string text = DownloadText(uri, noproxy: false);
		if (Operators.CompareString(text, "", false) == 0)
		{
			text = DownloadText(uri, noproxy: true);
		}
		return text;
	}

	public static string DownloadText(string uri, bool noproxy)
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	public static bool DownloadFile(string url, string aFile)
	{
		bool result;
		if (!(result = DownloadFile(url, aFile, noproxy: false)))
		{
			result = DownloadFile(url, aFile, noproxy: true);
		}
		return result;
	}

	public static bool DownloadFile(string url, string aFile, bool noproxy)
	{
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
			ftpWebRequest.KeepAlive = false;
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.Method = "RETR";
			if (noproxy)
			{
				ftpWebRequest.Proxy = null;
			}
			using (FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse())
			{
				using Stream stream = ftpWebResponse.GetResponseStream();
				using (FileStream fileStream = new FileStream(aFile, FileMode.Create))
				{
					byte[] array = new byte[2048];
					int num = 0;
					do
					{
						num = stream.Read(array, 0, array.Length);
						fileStream.Write(array, 0, num);
					}
					while (num != 0);
					stream.Close();
					fileStream.Flush();
					fileStream.Close();
				}
				stream.Close();
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool IsInternet()
	{
		return true;
	}
}
