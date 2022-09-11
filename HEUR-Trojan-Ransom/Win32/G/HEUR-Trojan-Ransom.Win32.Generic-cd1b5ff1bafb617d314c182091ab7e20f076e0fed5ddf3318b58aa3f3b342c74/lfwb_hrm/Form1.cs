using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using lfwb_hrm.Properties;

namespace lfwb_hrm;

public class Form1 : Form
{
	private bool Working;

	private int SleepCounter;

	private bool LastState;

	private Thread T;

	private IContainer components;

	private NotifyIcon notifyIcon1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem serverToolStripMenuItem;

	private ToolStripMenuItem s1ToolStripMenuItem;

	private ToolStripMenuItem s2ToolStripMenuItem;

	private ToolStripMenuItem s3ToolStripMenuItem;

	private ToolStripMenuItem backupToolStripMenuItem;

	private ToolStripMenuItem russianToolStripMenuItem;

	private ToolStripMenuItem settingsToolStripMenuItem;

	private ToolStripMenuItem autorunToolStripMenuItem;

	private ToolStripMenuItem notificationsToolStripMenuItem;

	private ToolStripMenuItem closeToolStripMenuItem;

	private ToolStripMenuItem playToolStripMenuItem;

	private ToolStripMenuItem soundToolStripMenuItem;

	public Form1()
	{
		InitializeComponent();
		Working = true;
		LastState = false;
		SleepCounter = 0;
		T = new Thread(Monitoring)
		{
			IsBackground = true
		};
		T.Start();
		autorunToolStripMenuItem.set_Checked(Settings.Default.autorun);
		soundToolStripMenuItem.set_Checked(Settings.Default.sound);
		notificationsToolStripMenuItem.set_Checked(Settings.Default.notifications);
		if (Settings.Default.ServerId == 1)
		{
			s1ToolStripMenuItem.set_Checked(true);
		}
		else if (Settings.Default.ServerId == 2)
		{
			s2ToolStripMenuItem.set_Checked(true);
		}
		else if (Settings.Default.ServerId == 3)
		{
			s3ToolStripMenuItem.set_Checked(true);
		}
		else if (Settings.Default.ServerId == 4)
		{
			backupToolStripMenuItem.set_Checked(true);
		}
		else if (Settings.Default.ServerId == 5)
		{
			russianToolStripMenuItem.set_Checked(true);
		}
		if (Settings.Default.firstrun)
		{
			Settings.Default.firstrun = false;
			((SettingsBase)Settings.Default).Save();
		}
	}

	private void Monitoring()
	{
		while (Working)
		{
			SleepCounter = 0;
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.NoDelay = true;
				tcpClient.ReceiveTimeout = 1000;
				tcpClient.SendTimeout = 1000;
				tcpClient.Connect(Settings.Default.ip, Settings.Default.port);
				Thread.Sleep(500);
				tcpClient.Close();
				Alive();
			}
			catch
			{
				Dead();
			}
			while (SleepCounter < 10)
			{
				Thread.Sleep(550);
				SleepCounter++;
			}
		}
	}

	private void Alive()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (!LastState)
		{
			LastState = true;
			notifyIcon1.set_Icon(Resources.red_heart);
			if (Settings.Default.notifications)
			{
				notifyIcon1.ShowBalloonTip(400, "It's up!", "Yeah!", (ToolTipIcon)1);
			}
			if (Settings.Default.sound)
			{
				new SoundPlayer((Stream)Resources.dark).Play();
			}
		}
	}

	private void Dead()
	{
		if (LastState)
		{
			LastState = false;
			notifyIcon1.set_Icon(Resources.black_heart);
		}
	}

	private void notifyIcon1_DoubleClick(object sender, EventArgs e)
	{
		Working = false;
		((Form)this).Close();
	}

	private void closeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Working = false;
		((Form)this).Close();
	}

	private void playToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Process.Start("byond://" + Settings.Default.ip + ":" + Settings.Default.port);
	}

	private void s1ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		s1ToolStripMenuItem.set_Checked(true);
		s2ToolStripMenuItem.set_Checked(false);
		s3ToolStripMenuItem.set_Checked(false);
		backupToolStripMenuItem.set_Checked(false);
		russianToolStripMenuItem.set_Checked(false);
		Settings.Default.ip = "play.lfwb.ru";
		Settings.Default.port = 1923;
		Settings.Default.ServerId = 1;
		((SettingsBase)Settings.Default).Save();
		SleepCounter = 11;
	}

	private void s2ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		s1ToolStripMenuItem.set_Checked(false);
		s2ToolStripMenuItem.set_Checked(true);
		s3ToolStripMenuItem.set_Checked(false);
		backupToolStripMenuItem.set_Checked(false);
		russianToolStripMenuItem.set_Checked(false);
		Settings.Default.ip = "play.lfwb.ru";
		Settings.Default.port = 2422;
		Settings.Default.ServerId = 2;
		((SettingsBase)Settings.Default).Save();
		SleepCounter = 11;
	}

	private void s3ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		s1ToolStripMenuItem.set_Checked(false);
		s2ToolStripMenuItem.set_Checked(false);
		s3ToolStripMenuItem.set_Checked(true);
		backupToolStripMenuItem.set_Checked(false);
		russianToolStripMenuItem.set_Checked(false);
		Settings.Default.ip = "play.lfwb.ru";
		Settings.Default.port = 1776;
		Settings.Default.ServerId = 3;
		((SettingsBase)Settings.Default).Save();
		SleepCounter = 11;
	}

	private void backupToolStripMenuItem_Click(object sender, EventArgs e)
	{
		s1ToolStripMenuItem.set_Checked(false);
		s2ToolStripMenuItem.set_Checked(false);
		s3ToolStripMenuItem.set_Checked(false);
		backupToolStripMenuItem.set_Checked(true);
		russianToolStripMenuItem.set_Checked(false);
		Settings.Default.ip = "play.lfwb.ru";
		Settings.Default.port = 1945;
		Settings.Default.ServerId = 4;
		((SettingsBase)Settings.Default).Save();
		SleepCounter = 11;
	}

	private void russianToolStripMenuItem_Click(object sender, EventArgs e)
	{
		s1ToolStripMenuItem.set_Checked(false);
		s2ToolStripMenuItem.set_Checked(false);
		s3ToolStripMenuItem.set_Checked(false);
		backupToolStripMenuItem.set_Checked(false);
		russianToolStripMenuItem.set_Checked(true);
		Settings.Default.ip = "play.lfwb.ru";
		Settings.Default.port = 1984;
		Settings.Default.ServerId = 5;
		((SettingsBase)Settings.Default).Save();
		SleepCounter = 11;
	}

	private void autorunToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Settings.Default.autorun = !Settings.Default.autorun;
		autorunToolStripMenuItem.set_Checked(Settings.Default.autorun);
		((SettingsBase)Settings.Default).Save();
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (Settings.Default.autorun)
		{
			string location = Assembly.GetExecutingAssembly().Location;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Lifeweb_Monitoring.exe";
			if (location != text)
			{
				File.Copy(location, text, overwrite: true);
			}
			registryKey.SetValue("LifewebMonitoring", text);
		}
		else
		{
			registryKey.DeleteValue("LifewebMonitoring", throwOnMissingValue: false);
		}
	}

	private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Settings.Default.notifications = !Settings.Default.notifications;
		notificationsToolStripMenuItem.set_Checked(Settings.Default.notifications);
		((SettingsBase)Settings.Default).Save();
	}

	private void soundToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Settings.Default.sound = !Settings.Default.sound;
		soundToolStripMenuItem.set_Checked(Settings.Default.sound);
		((SettingsBase)Settings.Default).Save();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
		{
			((Control)this).Hide();
		});
	}

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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		notifyIcon1 = new NotifyIcon(components);
		contextMenuStrip1 = new ContextMenuStrip(components);
		playToolStripMenuItem = new ToolStripMenuItem();
		serverToolStripMenuItem = new ToolStripMenuItem();
		s1ToolStripMenuItem = new ToolStripMenuItem();
		s2ToolStripMenuItem = new ToolStripMenuItem();
		s3ToolStripMenuItem = new ToolStripMenuItem();
		backupToolStripMenuItem = new ToolStripMenuItem();
		russianToolStripMenuItem = new ToolStripMenuItem();
		settingsToolStripMenuItem = new ToolStripMenuItem();
		autorunToolStripMenuItem = new ToolStripMenuItem();
		notificationsToolStripMenuItem = new ToolStripMenuItem();
		soundToolStripMenuItem = new ToolStripMenuItem();
		closeToolStripMenuItem = new ToolStripMenuItem();
		((Control)contextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		notifyIcon1.set_ContextMenuStrip(contextMenuStrip1);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("Lifeweb Monitor");
		notifyIcon1.set_Visible(true);
		notifyIcon1.add_DoubleClick((EventHandler)notifyIcon1_DoubleClick);
		((ToolStrip)contextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)playToolStripMenuItem,
			(ToolStripItem)serverToolStripMenuItem,
			(ToolStripItem)settingsToolStripMenuItem,
			(ToolStripItem)closeToolStripMenuItem
		});
		((Control)contextMenuStrip1).set_Name("contextMenuStrip1");
		((Control)contextMenuStrip1).set_Size(new Size(117, 92));
		((ToolStripItem)playToolStripMenuItem).set_Name("playToolStripMenuItem");
		((ToolStripItem)playToolStripMenuItem).set_Size(new Size(116, 22));
		((ToolStripItem)playToolStripMenuItem).set_Text("Play");
		((ToolStripItem)playToolStripMenuItem).add_Click((EventHandler)playToolStripMenuItem_Click);
		((ToolStripDropDownItem)serverToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)s1ToolStripMenuItem,
			(ToolStripItem)s2ToolStripMenuItem,
			(ToolStripItem)s3ToolStripMenuItem,
			(ToolStripItem)backupToolStripMenuItem,
			(ToolStripItem)russianToolStripMenuItem
		});
		((ToolStripItem)serverToolStripMenuItem).set_Name("serverToolStripMenuItem");
		((ToolStripItem)serverToolStripMenuItem).set_Size(new Size(116, 22));
		((ToolStripItem)serverToolStripMenuItem).set_Text("Server");
		((ToolStripItem)s1ToolStripMenuItem).set_Name("s1ToolStripMenuItem");
		((ToolStripItem)s1ToolStripMenuItem).set_Size(new Size(114, 22));
		((ToolStripItem)s1ToolStripMenuItem).set_Text("S1");
		((ToolStripItem)s1ToolStripMenuItem).add_Click((EventHandler)s1ToolStripMenuItem_Click);
		((ToolStripItem)s2ToolStripMenuItem).set_Name("s2ToolStripMenuItem");
		((ToolStripItem)s2ToolStripMenuItem).set_Size(new Size(114, 22));
		((ToolStripItem)s2ToolStripMenuItem).set_Text("S2");
		((ToolStripItem)s2ToolStripMenuItem).add_Click((EventHandler)s2ToolStripMenuItem_Click);
		((ToolStripItem)s3ToolStripMenuItem).set_Name("s3ToolStripMenuItem");
		((ToolStripItem)s3ToolStripMenuItem).set_Size(new Size(114, 22));
		((ToolStripItem)s3ToolStripMenuItem).set_Text("S3");
		((ToolStripItem)s3ToolStripMenuItem).add_Click((EventHandler)s3ToolStripMenuItem_Click);
		((ToolStripItem)backupToolStripMenuItem).set_Name("backupToolStripMenuItem");
		((ToolStripItem)backupToolStripMenuItem).set_Size(new Size(114, 22));
		((ToolStripItem)backupToolStripMenuItem).set_Text("Backup");
		((ToolStripItem)backupToolStripMenuItem).add_Click((EventHandler)backupToolStripMenuItem_Click);
		((ToolStripItem)russianToolStripMenuItem).set_Name("russianToolStripMenuItem");
		((ToolStripItem)russianToolStripMenuItem).set_Size(new Size(114, 22));
		((ToolStripItem)russianToolStripMenuItem).set_Text("Russian");
		((ToolStripItem)russianToolStripMenuItem).add_Click((EventHandler)russianToolStripMenuItem_Click);
		((ToolStripDropDownItem)settingsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)autorunToolStripMenuItem,
			(ToolStripItem)notificationsToolStripMenuItem,
			(ToolStripItem)soundToolStripMenuItem
		});
		((ToolStripItem)settingsToolStripMenuItem).set_Name("settingsToolStripMenuItem");
		((ToolStripItem)settingsToolStripMenuItem).set_Size(new Size(116, 22));
		((ToolStripItem)settingsToolStripMenuItem).set_Text("Settings");
		((ToolStripItem)autorunToolStripMenuItem).set_Name("autorunToolStripMenuItem");
		((ToolStripItem)autorunToolStripMenuItem).set_Size(new Size(142, 22));
		((ToolStripItem)autorunToolStripMenuItem).set_Text("Autorun");
		((ToolStripItem)autorunToolStripMenuItem).add_Click((EventHandler)autorunToolStripMenuItem_Click);
		((ToolStripItem)notificationsToolStripMenuItem).set_Name("notificationsToolStripMenuItem");
		((ToolStripItem)notificationsToolStripMenuItem).set_Size(new Size(142, 22));
		((ToolStripItem)notificationsToolStripMenuItem).set_Text("Notifications");
		((ToolStripItem)notificationsToolStripMenuItem).add_Click((EventHandler)notificationsToolStripMenuItem_Click);
		((ToolStripItem)soundToolStripMenuItem).set_Name("soundToolStripMenuItem");
		((ToolStripItem)soundToolStripMenuItem).set_Size(new Size(142, 22));
		((ToolStripItem)soundToolStripMenuItem).set_Text("Sound");
		((ToolStripItem)soundToolStripMenuItem).add_Click((EventHandler)soundToolStripMenuItem_Click);
		((ToolStripItem)closeToolStripMenuItem).set_Name("closeToolStripMenuItem");
		((ToolStripItem)closeToolStripMenuItem).set_Size(new Size(116, 22));
		((ToolStripItem)closeToolStripMenuItem).set_Text("Close");
		((ToolStripItem)closeToolStripMenuItem).add_Click((EventHandler)closeToolStripMenuItem_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(251, 22));
		((Control)this).set_Enabled(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Lifeweb Heartbeat Monitor");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
