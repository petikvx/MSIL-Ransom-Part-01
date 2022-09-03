using System;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns2;

internal class Class7
{
	public static bool smethod_0(string string_0)
	{
		WebClient webClient = new WebClient();
		try
		{
			if (webClient.DownloadString(Class1.smethod_2().method_0().string_2 + "Download/blacklist.txt").Contains(string_0))
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
