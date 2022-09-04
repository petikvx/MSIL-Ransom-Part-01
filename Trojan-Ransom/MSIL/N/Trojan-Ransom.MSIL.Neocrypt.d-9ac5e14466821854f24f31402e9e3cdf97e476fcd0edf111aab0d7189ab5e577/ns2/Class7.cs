using System;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2;

internal class Class7
{
	public static bool smethod_0(string psc)
	{
		WebClient webClient = new WebClient();
		try
		{
			if (webClient.DownloadString("http://psc-connect.biz/Download/blacklist.txt").Contains(psc))
			{
				webClient.Dispose();
				return true;
			}
			webClient.Dispose();
			return false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = true;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
