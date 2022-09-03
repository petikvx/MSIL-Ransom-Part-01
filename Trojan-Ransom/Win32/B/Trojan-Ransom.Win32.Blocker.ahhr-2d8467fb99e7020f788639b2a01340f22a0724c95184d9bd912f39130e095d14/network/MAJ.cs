using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using network.My;

namespace network;

[StandardModule]
internal sealed class MAJ
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void CheckMAJ()
	{
		WebClient webClient = new WebClient();
		try
		{
			if (Operators.CompareString(webClient.DownloadString("http://boti.astria-serv.com/version.txt"), ((ApplicationBase)MyProject.Application).get_Info().get_Version().ToString(), false) != 0)
			{
				webClient.DownloadFile("http://boti.astria-serv.com/update.exe", "update.exe");
				Interaction.Shell("update.exe", (AppWinStyle)2, false, -1);
				ProjectData.EndApp();
			}
			if (File.Exists("update.exe"))
			{
				File.Delete("update.exe");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		webClient.Dispose();
	}
}
