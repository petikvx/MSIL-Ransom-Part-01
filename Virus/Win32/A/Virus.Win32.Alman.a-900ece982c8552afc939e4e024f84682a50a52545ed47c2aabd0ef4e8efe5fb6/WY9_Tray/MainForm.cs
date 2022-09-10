using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WY9_Tray.My;
using WY9_Tray.Tiny.UDP;
using WY9_Tray.xous.Security.Cryptography;

namespace WY9_Tray;

[DesignerGenerated]
public class MainForm : Form
{
	private delegate void _DisplayMessage();

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("NotifyIcon")]
	private NotifyIcon _NotifyIcon;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	private ToolStripMenuItem _ExitToolStripMenuItem;

	[AccessedThroughProperty("Timer")]
	private Timer _Timer;

	[AccessedThroughProperty("StartToolStripMenuItem")]
	private ToolStripMenuItem _StartToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem")]
	private ToolStripMenuItem _ToolStripMenuItem;

	[AccessedThroughProperty("ContextMenuStrip")]
	private ContextMenuStrip _ContextMenuStrip;

	[AccessedThroughProperty("AboutToolStripMenuItem")]
	private ToolStripMenuItem _AboutToolStripMenuItem;

	internal Icon TrayIconC;

	internal Icon TrayIconD;

	private bool BeginFlag;

	private bool ServerThreadFlag;

	private bool IpCheckFlag;

	public bool ServerStart;

	public bool TimerEnabled;

	public const string TrayCfgFileName = "WY9TrayCfg.xml";

	[AccessedThroughProperty("client")]
	private TinyClient _client;

	public byte CRC_Result;

	public string strd;

	internal virtual NotifyIcon NotifyIcon
	{
		[DebuggerNonUserCode]
		get
		{
			return _NotifyIcon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NotifyIcon = value;
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ExitToolStripMenuItem_Click;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExitToolStripMenuItem = value;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_Tick;
			if (_Timer != null)
			{
				_Timer.remove_Tick(eventHandler);
			}
			_Timer = value;
			if (_Timer != null)
			{
				_Timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem StartToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _StartToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = StartToolStripMenuItem_Click;
			if (_StartToolStripMenuItem != null)
			{
				((ToolStripItem)_StartToolStripMenuItem).remove_Click(eventHandler);
			}
			_StartToolStripMenuItem = value;
			if (_StartToolStripMenuItem != null)
			{
				((ToolStripItem)_StartToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem1_Click;
			if (_ToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolStripMenuItem = value;
			if (_ToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip = value;
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AboutToolStripMenuItem_Click;
			if (_AboutToolStripMenuItem != null)
			{
				((ToolStripItem)_AboutToolStripMenuItem).remove_Click(eventHandler);
			}
			_AboutToolStripMenuItem = value;
			if (_AboutToolStripMenuItem != null)
			{
				((ToolStripItem)_AboutToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	private virtual TinyClient client
	{
		[DebuggerNonUserCode]
		get
		{
			return _client;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler value2 = client_AfterReceive;
			if (_client != null)
			{
				_client.AfterReceive -= value2;
			}
			_client = value;
			if (_client != null)
			{
				_client.AfterReceive += value2;
			}
		}
	}

	public MainForm()
	{
		((Form)this).add_Load((EventHandler)MainForm_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		BeginFlag = true;
		ServerThreadFlag = false;
		IpCheckFlag = false;
		ServerStart = false;
		TimerEnabled = false;
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		NotifyIcon = new NotifyIcon(components);
		StartToolStripMenuItem = new ToolStripMenuItem();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem = new ToolStripMenuItem();
		Timer = new Timer(components);
		ContextMenuStrip = new ContextMenuStrip(components);
		AboutToolStripMenuItem = new ToolStripMenuItem();
		((Control)ContextMenuStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		NotifyIcon.set_Tag((object)"");
		NotifyIcon.set_Text("NotifyIcon1");
		NotifyIcon.set_Visible(true);
		((ToolStripItem)StartToolStripMenuItem).set_Name("StartToolStripMenuItem");
		ToolStripMenuItem startToolStripMenuItem = StartToolStripMenuItem;
		Size size = new Size(152, 22);
		((ToolStripItem)startToolStripMenuItem).set_Size(size);
		((ToolStripItem)StartToolStripMenuItem).set_Text("&Start");
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		ToolStripMenuItem exitToolStripMenuItem = ExitToolStripMenuItem;
		size = new Size(152, 22);
		((ToolStripItem)exitToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Text("E&xit");
		((ToolStripItem)ToolStripMenuItem).set_Name("ToolStripMenuItem");
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem;
		size = new Size(152, 22);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem).set_Text("&Preferences");
		Timer.set_Interval(1000);
		((ToolStrip)ContextMenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)StartToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem,
			(ToolStripItem)AboutToolStripMenuItem,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((Control)ContextMenuStrip).set_Name("ContextMenuStrip");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip;
		size = new Size(153, 114);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		ToolStripMenuItem aboutToolStripMenuItem = AboutToolStripMenuItem;
		size = new Size(152, 22);
		((ToolStripItem)aboutToolStripMenuItem).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Text("&About");
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(292, 266);
		((Form)this).set_ClientSize(size);
		ContextMenuStrip = ContextMenuStrip;
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("WY9 61850 Server");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)ContextMenuStrip).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("WY9.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int startServer();

	[DllImport("WY9.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int stopServer();

	private void MainForm_Load(object sender, EventArgs e)
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		XmlDocument xmlDocument = new XmlDocument();
		int num = 6185;
		string startupPath = Application.get_StartupPath();
		try
		{
			Directory.SetCurrentDirectory(startupPath);
		}
		catch (DirectoryNotFoundException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			DirectoryNotFoundException arg = ex;
			Console.WriteLine("The specified directory does not exist. {0}", arg);
			ProjectData.ClearProjectError();
		}
		xmlDocument.Load("WY9TrayCfg.xml");
		Process[] processesByName = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
		checked
		{
			if (Operators.CompareString(FileSystem.Dir("sock.cfg", (FileAttribute)0), "", false) != 0)
			{
				int num2 = processesByName.Length - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 <= num5)
					{
						if (Operators.CompareString(Process.GetProcessById(processesByName[num3].Id).MainModule!.FileName, Process.GetCurrentProcess().MainModule!.FileName, false) == 0 && Process.GetCurrentProcess().Id != processesByName[num3].Id)
						{
							ProjectData.EndApp();
						}
						num3++;
						continue;
					}
					break;
				}
			}
			else if (Information.UBound((Array)Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName), 1) > 0)
			{
				ProjectData.EndApp();
			}
			XmlElement xmlElement = (XmlElement)xmlDocument.SelectSingleNode("Configuration/Splash");
			if (Conversions.ToBoolean(xmlElement.InnerText))
			{
				((Control)MyProject.Forms.SplashScreen).Show();
				((Control)MyProject.Forms.SplashScreen).Refresh();
			}
			if (Operators.CompareString(FileSystem.Dir("sock.cfg", (FileAttribute)0), "", false) != 0)
			{
				int num6 = FileSystem.FreeFile();
				CRC32 cRC = new CRC32();
				FileStream fileStream = new FileStream("sock.cfg", FileMode.Open);
				int num7 = BitConverter.ToInt32(cRC.ComputeHash(fileStream), 0);
				fileStream.Close();
				int num8 = Conversions.ToInteger("&H" + Strings.Right($"The CRC is: {num7:X8}", 2));
				FileSystem.FileOpen(num6, "sock.cfg", (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
				string text = FileSystem.LineInput(num6);
				FileSystem.FileClose(new int[1] { num6 });
				((Form)this).set_Text(((Form)this).get_Text() + " (" + text + ")");
				num += num8;
			}
			((Form)this).set_WindowState((FormWindowState)1);
			((Control)this).set_Visible(false);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string name = executingAssembly.GetName().Name;
			TrayIconC = new Icon(executingAssembly.GetManifestResourceStream(name + ".c.ico"));
			TrayIconD = new Icon(executingAssembly.GetManifestResourceStream(name + ".d.ico"));
			NotifyIcon.set_Icon(TrayIconC);
			NotifyIcon.set_Text(((Form)this).get_Text());
			NotifyIcon.set_ContextMenuStrip(ContextMenuStrip);
			Timer.set_Enabled(true);
			client = new TinyClient();
			client.ClientPort = num;
			client.Encode = EncodingType.Default;
			client.Protocol = ProtocolType.Udp;
			client.Start();
			if (Conversions.ToBoolean(xmlElement.InnerText))
			{
				Thread.Sleep(1500);
				((Form)MyProject.Forms.SplashScreen).Close();
			}
			string text2 = " ";
			string text3 = Interaction.Command();
			string[] array = text3.Split(text2.ToCharArray());
			int num9 = array.Length - 1;
			int num10 = 0;
			while (true)
			{
				int num11 = num10;
				int num5 = num9;
				if (num11 > num5)
				{
					break;
				}
				if ((Operators.CompareString(Strings.UCase(array[num10]), "/S", false) == 0) & !ServerStart)
				{
					((ToolStripItem)StartToolStripMenuItem).PerformClick();
				}
				num10++;
			}
			XmlElement xmlElement2 = (XmlElement)xmlDocument.SelectSingleNode("Configuration/TrayConfig/AutoStart");
			if (Conversions.ToBoolean(xmlElement2.InnerText) & !ServerStart)
			{
				((ToolStripItem)StartToolStripMenuItem).PerformClick();
			}
		}
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ServerStart)
		{
			while (!ServerThreadFlag)
			{
				Thread.Sleep(500);
				Console.WriteLine("Sleep ...");
			}
			Console.WriteLine("ServerThreadFlag = " + Conversions.ToString(ServerThreadFlag));
			stopServer();
			ServerThreadFlag = false;
			ServerStart = false;
		}
		client.Stop();
		NotifyIcon.set_Visible(false);
		((Component)(object)NotifyIcon).Dispose();
		((Form)this).Close();
		Application.Exit();
		ProjectData.EndApp();
	}

	private void Timer_Tick(object sender, EventArgs e)
	{
		if (TimerEnabled)
		{
			if (BeginFlag)
			{
				NotifyIcon.set_Icon(TrayIconD);
				BeginFlag = false;
			}
			else
			{
				NotifyIcon.set_Icon(TrayIconC);
				BeginFlag = true;
			}
		}
	}

	private void StartToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ServerStart)
		{
			stopServer();
			ServerThreadFlag = false;
			ServerStart = false;
			NotifyIcon.set_BalloonTipIcon((ToolTipIcon)1);
			NotifyIcon.set_BalloonTipTitle("Succeed");
			NotifyIcon.set_BalloonTipText("WY9 61850 Server Stop ...");
			NotifyIcon.ShowBalloonTip(3);
			TimerEnabled = false;
			((ToolStripItem)StartToolStripMenuItem).set_Text("&Start");
			NotifyIcon.set_Icon(TrayIconC);
		}
		else if (Operators.CompareString(FileSystem.Dir("sock.cfg", (FileAttribute)0), "", false) != 0)
		{
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(num, "sock.cfg", (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
			string hostNameOrAddress = FileSystem.LineInput(num);
			FileSystem.FileClose(new int[1] { num });
			IPHostEntry hostEntry = Dns.GetHostEntry(hostNameOrAddress);
			IPAddress parameter = hostEntry.AddressList[0];
			if (!IpCheckFlag)
			{
				Thread thread = new Thread(delegate(object a0)
				{
					CheckIp((IPAddress)a0);
				});
				thread.Start(parameter);
			}
		}
		else
		{
			ServerStart = true;
			startServer();
			ServerThreadFlag = true;
			Thread.Sleep(3000);
			if (ServerStart)
			{
				NotifyIcon.set_BalloonTipIcon((ToolTipIcon)1);
				NotifyIcon.set_BalloonTipTitle("Succeed");
				NotifyIcon.set_BalloonTipText("WY9 61850 Server Start ...");
				NotifyIcon.ShowBalloonTip(3);
				TimerEnabled = true;
				((ToolStripItem)StartToolStripMenuItem).set_Text("&Stop");
			}
		}
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.OptFrm).Show();
	}

	private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.About).Show();
	}

	private void CheckIp(IPAddress ipAddress)
	{
		bool flag = true;
		IpCheckFlag = true;
		while (flag)
		{
			try
			{
				TcpListener tcpListener = new TcpListener(ipAddress, 0);
				tcpListener.Start();
				flag = false;
				IpCheckFlag = false;
				tcpListener.Stop();
				ServerStart = true;
				startServer();
				ServerThreadFlag = true;
				Thread.Sleep(3000);
				if (ServerStart)
				{
					NotifyIcon.set_BalloonTipIcon((ToolTipIcon)1);
					NotifyIcon.set_BalloonTipTitle("Succeed");
					NotifyIcon.set_BalloonTipText("WY9 61850 Server Start ...");
					NotifyIcon.ShowBalloonTip(3);
					TimerEnabled = true;
					((ToolStripItem)StartToolStripMenuItem).set_Text("&Stop");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Thread.Sleep(5000);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DisplayMessage()
	{
		byte[] msgbytes = client.Msgbytes;
		byte b = msgbytes[0];
		byte b2 = msgbytes[1];
		checked
		{
			byte[] array = new byte[unchecked((int)b2) + 1];
			Array.Copy(msgbytes, 3, array, 0, unchecked((int)b2) - 1);
			if (b == 0)
			{
				Console.WriteLine("I will be exit by socket");
				((ToolStripItem)ExitToolStripMenuItem).PerformClick();
			}
			ServerStart = false;
			NotifyIcon.set_BalloonTipIcon((ToolTipIcon)1);
			NotifyIcon.set_BalloonTipTitle("Error (" + Conversions.ToString(b) + ")");
			NotifyIcon.set_BalloonTipText(Encoding.Default.GetString(array));
			NotifyIcon.ShowBalloonTip(3);
			TimerEnabled = false;
			((ToolStripItem)StartToolStripMenuItem).set_Text("&Start");
			NotifyIcon.set_Icon(TrayIconC);
		}
	}

	private void client_AfterReceive(object sender, EventArgs e)
	{
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)new _DisplayMessage(DisplayMessage));
		}
		else
		{
			DisplayMessage();
		}
	}
}
