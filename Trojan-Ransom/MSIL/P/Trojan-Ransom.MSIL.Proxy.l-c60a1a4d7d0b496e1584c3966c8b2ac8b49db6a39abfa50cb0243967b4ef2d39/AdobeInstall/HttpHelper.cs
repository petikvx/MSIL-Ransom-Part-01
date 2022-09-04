using System;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;

namespace AdobeInstall;

public class HttpHelper
{
	public static string DownloadText(string uri)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.Proxy = null;
			return webClient.DownloadString(uri);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool DownloadFile(string url, string aFile)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.Proxy = null;
			webClient.DownloadFile(url, aFile);
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
}
