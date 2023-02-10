using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Network_Checkv2.My;

namespace Network_Checkv2;

[DesignerGenerated]
public class Form1 : Form
{
	private string strHostName;

	private string strPing_Address;

	private bool bolFailFlag;

	private bool bolOnceOnly;

	private int intInternet_count;

	private string[] ipS;

	private string webpath;

	public double dblFails;

	public int intLogging_Count;

	public int intFail_Count;

	private bool bolFlagged;

	private bool bolStart;

	private int intTimeOffset;

	private string strOldIPAddress;

	private string strAlternative;

	private int intSwopCount;

	private int intWeeks;

	private int intDays;

	private int intHours;

	private int intMins;

	private int intSecs;

	private int intInternetFails;

	private DateTime dtStartTime;

	private DateInterval dtNowTime;

	private IContainer components;

	internal virtual Timer Timer4
	{
		[CompilerGenerated]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			Timer timer = _Timer4;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			timer = _Timer4;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer timCheckDNS
	{
		[CompilerGenerated]
		get
		{
			return _timCheckDNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = timCheckDNS_Tick;
			Timer val = _timCheckDNS;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_timCheckDNS = value;
			val = _timCheckDNS;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("lblLogging_Text")]
	internal virtual Label lblLogging_Text
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLogging")]
	internal virtual Label lblLogging
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnFinished
	{
		[CompilerGenerated]
		get
		{
			return _btnFinished;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = btnFinished_Click;
			Button val = _btnFinished;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnFinished = value;
			val = _btnFinished;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblActualTime")]
	internal virtual Label lblActualTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRunTime")]
	internal virtual Label lblRunTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCStatus")]
	internal virtual Label lblCStatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAddress")]
	internal virtual Label lblAddress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPingComputer")]
	internal virtual Label lblPingComputer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblName")]
	internal virtual Label lblName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblInternetAddress")]
	internal virtual Label lblInternetAddress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRStatus")]
	internal virtual Label lblRStatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDHCP")]
	internal virtual Label lblDHCP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPingRouter")]
	internal virtual Label lblPingRouter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label lblInternetFails
	{
		[CompilerGenerated]
		get
		{
			return _lblInternetFails;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			EventHandler eventHandler = lblInternetFails_MouseHover;
			EventHandler eventHandler2 = lblInternetFails_MouseLeave;
			MouseEventHandler val = new MouseEventHandler(lblInternetFails_MouseClick);
			Label val2 = _lblInternetFails;
			if (val2 != null)
			{
				((Control)val2).remove_MouseHover(eventHandler);
				((Control)val2).remove_MouseLeave(eventHandler2);
				((Control)val2).remove_MouseClick(val);
			}
			_lblInternetFails = value;
			val2 = _lblInternetFails;
			if (val2 != null)
			{
				((Control)val2).add_MouseHover(eventHandler);
				((Control)val2).add_MouseLeave(eventHandler2);
				((Control)val2).add_MouseClick(val);
			}
		}
	}

	[field: AccessedThroughProperty("lblNetworkURL")]
	internal virtual Label lblNetworkURL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label7_Click;
			EventHandler eventHandler2 = Label7_MouseHover;
			EventHandler eventHandler3 = Label7_MouseLeave;
			Label label = _Label7;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
				((Control)label).remove_MouseHover(eventHandler2);
				((Control)label).remove_MouseLeave(eventHandler3);
			}
			_Label7 = value;
			label = _Label7;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
				((Control)label).add_MouseHover(eventHandler2);
				((Control)label).add_MouseLeave(eventHandler3);
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPol")]
	internal virtual Label lblPol
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDStatus")]
	internal virtual Label lblDStatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPingTalkTalkDNS")]
	internal virtual Label lblPingTalkTalkDNS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer3
	{
		[CompilerGenerated]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			Timer timer = _Timer3;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			timer = _Timer3;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Timer5")]
	internal virtual Timer Timer5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Timer6")]
	internal virtual Timer Timer6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer timFlashTalkTalkDNS
	{
		[CompilerGenerated]
		get
		{
			return _timFlashTalkTalkDNS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = timFlashTalkTalkDNS_Tick;
			Timer val = _timFlashTalkTalkDNS;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_timFlashTalkTalkDNS = value;
			val = _timFlashTalkTalkDNS;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem FileToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = FileToolStripMenuItem_Click;
			ToolStripMenuItem fileToolStripMenuItem = _FileToolStripMenuItem;
			if (fileToolStripMenuItem != null)
			{
				((ToolStripItem)fileToolStripMenuItem).remove_Click(eventHandler);
			}
			_FileToolStripMenuItem = value;
			fileToolStripMenuItem = _FileToolStripMenuItem;
			if (fileToolStripMenuItem != null)
			{
				((ToolStripItem)fileToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem toolSettings
	{
		[CompilerGenerated]
		get
		{
			return _toolSettings;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = toolSettings_Click;
			ToolStripMenuItem val = _toolSettings;
			if (val != null)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			_toolSettings = value;
			val = _toolSettings;
			if (val != null)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolStripMenuItem1 = value;
			toolStripMenuItem = _ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AboutToolStripMenuItem_Click;
			ToolStripMenuItem aboutToolStripMenuItem = _AboutToolStripMenuItem;
			if (aboutToolStripMenuItem != null)
			{
				((ToolStripItem)aboutToolStripMenuItem).remove_Click(eventHandler);
			}
			_AboutToolStripMenuItem = value;
			aboutToolStripMenuItem = _AboutToolStripMenuItem;
			if (aboutToolStripMenuItem != null)
			{
				((ToolStripItem)aboutToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ExitToolStripMenuItem_Click;
			ToolStripMenuItem exitToolStripMenuItem = _ExitToolStripMenuItem;
			if (exitToolStripMenuItem != null)
			{
				((ToolStripItem)exitToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExitToolStripMenuItem = value;
			exitToolStripMenuItem = _ExitToolStripMenuItem;
			if (exitToolStripMenuItem != null)
			{
				((ToolStripItem)exitToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem LogToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _LogToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = LogToolStripMenuItem_Click;
			ToolStripMenuItem logToolStripMenuItem = _LogToolStripMenuItem;
			if (logToolStripMenuItem != null)
			{
				((ToolStripItem)logToolStripMenuItem).remove_Click(eventHandler);
			}
			_LogToolStripMenuItem = value;
			logToolStripMenuItem = _LogToolStripMenuItem;
			if (logToolStripMenuItem != null)
			{
				((ToolStripItem)logToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem OpenLogfileToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OpenLogfileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = OpenLogfileToolStripMenuItem_Click;
			ToolStripMenuItem openLogfileToolStripMenuItem = _OpenLogfileToolStripMenuItem;
			if (openLogfileToolStripMenuItem != null)
			{
				((ToolStripItem)openLogfileToolStripMenuItem).remove_Click(eventHandler);
			}
			_OpenLogfileToolStripMenuItem = value;
			openLogfileToolStripMenuItem = _OpenLogfileToolStripMenuItem;
			if (openLogfileToolStripMenuItem != null)
			{
				((ToolStripItem)openLogfileToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DeleteLogfileToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DeleteLogfileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = DeleteLogfileToolStripMenuItem_Click;
			ToolStripMenuItem deleteLogfileToolStripMenuItem = _DeleteLogfileToolStripMenuItem;
			if (deleteLogfileToolStripMenuItem != null)
			{
				((ToolStripItem)deleteLogfileToolStripMenuItem).remove_Click(eventHandler);
			}
			_DeleteLogfileToolStripMenuItem = value;
			deleteLogfileToolStripMenuItem = _DeleteLogfileToolStripMenuItem;
			if (deleteLogfileToolStripMenuItem != null)
			{
				((ToolStripItem)deleteLogfileToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DebugInfoToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DebugInfoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = DebugInfoToolStripMenuItem_Click;
			ToolStripMenuItem debugInfoToolStripMenuItem = _DebugInfoToolStripMenuItem;
			if (debugInfoToolStripMenuItem != null)
			{
				((ToolStripItem)debugInfoToolStripMenuItem).remove_Click(eventHandler);
			}
			_DebugInfoToolStripMenuItem = value;
			debugInfoToolStripMenuItem = _DebugInfoToolStripMenuItem;
			if (debugInfoToolStripMenuItem != null)
			{
				((ToolStripItem)debugInfoToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer timOneSec
	{
		[CompilerGenerated]
		get
		{
			return _timOneSec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = timOneSec_Tick;
			Timer val = _timOneSec;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_timOneSec = value;
			val = _timOneSec;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer timPol
	{
		[CompilerGenerated]
		get
		{
			return _timPol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = timPol_Tick;
			Timer val = _timPol;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_timPol = value;
			val = _timPol;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer timLogging_Indicator
	{
		[CompilerGenerated]
		get
		{
			return _timLogging_Indicator;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = timLogging_Indicator_Tick;
			Timer val = _timLogging_Indicator;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_timLogging_Indicator = value;
			val = _timLogging_Indicator;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem LoggingOnToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _LoggingOnToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = LoggingOnToolStripMenuItem_Click;
			ToolStripMenuItem loggingOnToolStripMenuItem = _LoggingOnToolStripMenuItem;
			if (loggingOnToolStripMenuItem != null)
			{
				((ToolStripItem)loggingOnToolStripMenuItem).remove_Click(eventHandler);
			}
			_LoggingOnToolStripMenuItem = value;
			loggingOnToolStripMenuItem = _LoggingOnToolStripMenuItem;
			if (loggingOnToolStripMenuItem != null)
			{
				((ToolStripItem)loggingOnToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblRouter")]
	internal virtual Label lblRouter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVPNActive")]
	internal virtual Label lblVPNActive
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer timFlashVPN
	{
		[CompilerGenerated]
		get
		{
			return _timFlashVPN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = timFlashVPN_Tick;
			Timer val = _timFlashVPN;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_timFlashVPN = value;
			val = _timFlashVPN;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		strHostName = Dns.GetHostName();
		webpath = "http://whatismyipaddress.com/ip-lookup";
		dblFails = 0.0;
		intLogging_Count = 0;
		intFail_Count = 0;
		bolFlagged = false;
		bolStart = true;
		intTimeOffset = 0;
		strOldIPAddress = "";
		strAlternative = "www.google.co.uk";
		intSwopCount = 0;
		intInternetFails = 0;
		InitializeComponent();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Application.Exit();
		ModBase.Write_ToFile("Network Check Application Terminated via Form\r\n");
		ProjectData.EndApp();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			intWeeks = 0;
			intDays = 0;
			intHours = 0;
			intMins = 0;
			intSecs = 0;
			dtStartTime = DateAndTime.get_Now();
			Logging_Select(MySettingsProperty.Settings.logEventsEnabled);
			string text;
			if (MySettingsProperty.Settings.logEventsEnabled)
			{
				LoggingOnToolStripMenuItem.set_Checked(true);
				text = " Logging is On";
			}
			else
			{
				LoggingOnToolStripMenuItem.set_Checked(false);
				text = " Logging is Off";
			}
			string text2 = ModBase.FindRunningVersion();
			ModBase.Write_ToFile("Network Check Application Start " + Conversions.ToString(DateAndTime.get_Now()) + "   Version: " + text2 + text);
			lblInternetAddress.set_Text(getExternalIP(webpath));
			if (Operators.CompareString(lblInternetAddress.get_Text(), MySettingsProperty.Settings.oldIPAddress, false) != 0)
			{
				MySettingsProperty.Settings.oldIPAddress = lblInternetAddress.get_Text();
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				strOldIPAddress = lblInternetAddress.get_Text();
				ModBase.Write_ToFile("IP Changed since app last run. Old IP was: " + MySettingsProperty.Settings.oldIPAddress + "  New IP is: " + lblInternetAddress.get_Text());
			}
			else
			{
				ModBase.Write_ToFile("IPV4 Address: " + lblInternetAddress.get_Text());
			}
			LoggingOnToolStripMenuItem.set_Checked(false);
			((Form)this).set_Text(text2);
			ModBase.intTimeout = MySettingsProperty.Settings.pingTimeout;
			lblDHCP.set_Text(DisplayDhcpServerAddresses());
			strPing_Address = lblDHCP.get_Text();
			ModBase.intRed = 255;
			ModBase.intGreen = 255;
			ModBase.intBlue = 255;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)("Error " + Information.Err().get_Description()), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public string getExternalIP(string webPath)
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			string text = "";
			string text2 = "";
			string text3 = "";
			WebClient webClient = new WebClient();
			WebClient webClient2 = new WebClient();
			WebClient webClient3 = new WebClient();
			text = Encoding.ASCII.GetString(webClient.DownloadData("https://tools.feron.it/php/ip.php"));
			text = Strings.Mid(text, 4, text.Length);
			text2 = Encoding.ASCII.GetString(webClient.DownloadData("https://tools.feron.it/php/ip.php"));
			text2 = Strings.Mid(text, 4, text.Length);
			text3 = Encoding.ASCII.GetString(webClient.DownloadData("https://tools.feron.it/php/ip.php"));
			text3 = Strings.Mid(text, 4, text.Length);
			return text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result = "0.0.0.0";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string DisplayDhcpServerAddresses()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
			IPAddressCollection dnsAddresses = iPProperties.DnsAddresses;
			if (dnsAddresses.Count <= 0)
			{
				continue;
			}
			using IEnumerator<IPAddress> enumerator = dnsAddresses.GetEnumerator();
			if (enumerator.MoveNext())
			{
				IPAddress current = enumerator.Current;
				return current.ToString();
			}
		}
		return "";
	}

	private string GetIPv4Address()
	{
		string result = string.Empty;
		IPHostEntry hostEntry = Dns.GetHostEntry(strHostName);
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
			{
				result = iPAddress.ToString();
			}
		}
		return result;
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (((Control)lblPingRouter).get_BackColor() == Color.Red)
		{
			((Control)lblPingRouter).set_BackColor(Color.WhiteSmoke);
		}
		else
		{
			((Control)lblPingRouter).set_BackColor(Color.Red);
		}
	}

	public bool CheckIP_Address_IsValid(string strAdd)
	{
		Ping ping = new Ping();
		PingReply pingReply = ping.Send(strAdd, ModBase.intTimeout);
		if (pingReply.Status == IPStatus.Success)
		{
			strPing_Address = strAdd;
			return true;
		}
		return false;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Timer1.set_Interval(2000);
			if (CheckIP_Address_IsValid(lblDHCP.get_Text()))
			{
				Timer2.set_Enabled(false);
				((Control)lblPingRouter).set_BackColor(Color.LightGreen);
				lblRStatus.set_Text("Router Healthy");
				return;
			}
			Timer2.set_Enabled(true);
			lblRStatus.set_Text("Router Error");
			if (LoggingOnToolStripMenuItem.get_Checked())
			{
				ModBase.Write_ToFile("Router Error Ping Failed");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (Information.Err().get_Number() == 5)
			{
				Timer2.set_Enabled(true);
				lblRStatus.set_Text("Router Error");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		try
		{
			Timer1.set_Interval(2000);
			if (CheckIP_Address_IsValid(lblAddress.get_Text()))
			{
				Timer4.set_Enabled(false);
				((Control)lblPingComputer).set_BackColor(Color.LightGreen);
				lblCStatus.set_Text("Computer Healthy");
				return;
			}
			Timer4.set_Enabled(true);
			lblCStatus.set_Text("Computer Error");
			if (LogToolStripMenuItem.get_Checked())
			{
				ModBase.Write_ToFile("Computer Ping failed, looks like a Network card failure?");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		if (((Control)lblPingComputer).get_BackColor() == Color.Red)
		{
			((Control)lblPingComputer).set_BackColor(Color.WhiteSmoke);
		}
		else
		{
			((Control)lblPingComputer).set_BackColor(Color.Red);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void btnFinished_Click(object sender, EventArgs e)
	{
		ModBase.Write_ToFile("Network Check Application Terminated via Exit button\r\n");
		ProjectData.EndApp();
	}

	private void timCheckDNS_Tick(object sender, EventArgs e)
	{
		((Control)lblPol).set_BackColor(Color.Lime);
		timPol.set_Enabled(true);
		lblNetworkURL.set_Text(MySettingsProperty.Settings.pingURL);
		if (Operators.CompareString(lblDStatus.get_Text(), "DNS Error", false) == 0)
		{
			((Control)lblPol).set_BackColor(Color.Red);
			dblFails += 1.0;
			Label7.set_Text(" Failed " + Conversions.ToString(dblFails));
			timPol.set_Enabled(false);
		}
		checked
		{
			try
			{
				timCheckDNS.set_Interval(1000);
				if (CheckIP_Address_IsValid(MySettingsProperty.Settings.pingURL))
				{
					timFlashTalkTalkDNS.set_Enabled(false);
					((Control)lblPingTalkTalkDNS).set_BackColor(Color.LightGreen);
					lblDStatus.set_Text("DNS Working");
					timPol.set_Enabled(true);
					intSwopCount = 0;
					if ((intFail_Count >= 10) & bolFlagged)
					{
						ModBase.Write_ToFile("Internet back up, IP Address is " + getExternalIP(webpath));
					}
					intFail_Count = 0;
					bolFlagged = false;
					return;
				}
				timFlashTalkTalkDNS.set_Enabled(true);
				lblDStatus.set_Text("DNS Error");
				if (LogToolStripMenuItem.get_Checked())
				{
				}
				if (LoggingOnToolStripMenuItem.get_Checked())
				{
					string pingURL = MySettingsProperty.Settings.pingURL;
					string pingAlternativeURL = MySettingsProperty.Settings.pingAlternativeURL;
					MySettingsProperty.Settings.pingURL = pingAlternativeURL;
					MySettingsProperty.Settings.pingAlternativeURL = pingURL;
					((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
					intSwopCount++;
					if (intSwopCount < 6)
					{
						ModBase.Write_ToFile("DNS failed, trying alternative address: " + pingURL);
					}
					else if (intSwopCount == 6)
					{
						ModBase.Write_ToFile("Multiple fails encountered..... " + pingURL);
					}
				}
				intFail_Count++;
				if ((intFail_Count == 10) & !bolFlagged)
				{
					intTimeOffset = 10;
					ModBase.Write_ToFile("Internet down 10 seconds ago");
					intFail_Count = -1;
					bolFlagged = true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Information.Err().get_Number() == 5)
				{
					timFlashTalkTalkDNS.set_Enabled(true);
					lblDStatus.set_Text("DNS Error");
					if (LogToolStripMenuItem.get_Checked())
					{
						ModBase.Write_ToFile("Failed to resolve DNS");
					}
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.About).Show();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ModBase.Write_ToFile("Network Check Application Terminated");
		ProjectData.EndApp();
	}

	private void timFlashTalkTalkDNS_Tick(object sender, EventArgs e)
	{
		if (((Control)lblPingTalkTalkDNS).get_BackColor() == Color.Red)
		{
			((Control)lblPingTalkTalkDNS).set_BackColor(Color.WhiteSmoke);
		}
		else
		{
			((Control)lblPingTalkTalkDNS).set_BackColor(Color.Red);
		}
	}

	private void timOneSec_Tick(object sender, EventArgs e)
	{
		timOneSec.set_Interval(1000);
		checked
		{
			try
			{
				Update_Running_Time();
				lblAddress.set_Text(GetIPv4Address());
				lblName.set_Text(strHostName);
				lblDHCP.set_Text(DisplayDhcpServerAddresses());
				strPing_Address = lblDHCP.get_Text();
				string externalIP = getExternalIP(webpath);
				Label12.set_Text(GetIPAddress());
				string text = ((externalIP.Length <= 15) ? "IPv4" : "IPv6 ");
				if (Operators.CompareString(Label12.get_Text(), lblInternetAddress.get_Text(), false) != 0)
				{
					ModBase.VPN_Running = ModBase.Is_ProcessRunning("NordVPN");
					((Control)lblVPNActive).set_Visible(true);
					Label6.set_Text("VPN is Active, Address is: -");
				}
				else
				{
					Label6.set_Text("Router Address is " + text);
					((Control)lblVPNActive).set_Visible(false);
				}
				lblInternetAddress.set_Text(externalIP);
				if (Operators.CompareString(lblInternetAddress.get_Text(), MySettingsProperty.Settings.oldIPAddress, false) != 0)
				{
					ModBase.Write_ToFile("Public IP Address changed, was: " + strOldIPAddress + "  now: " + lblInternetAddress.get_Text());
					intInternetFails++;
					MySettingsProperty.Settings.oldIPAddress = lblInternetAddress.get_Text();
					((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
					strOldIPAddress = lblInternetAddress.get_Text();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private string GetIPAddress()
	{
		string ddns_URL = MySettingsProperty.Settings.ddns_URL;
		return Dns.GetHostEntry(ddns_URL).AddressList[0].ToString();
	}

	private void Update_Running_Time()
	{
		checked
		{
			intSecs++;
			if (intSecs == 60)
			{
				intSecs = 0;
				intMins++;
				if (intMins == 60)
				{
					intMins = 0;
					intHours++;
					if (intHours == 24)
					{
						intHours = 0;
						intDays++;
						if (intDays == 7)
						{
							intDays = 0;
							intWeeks++;
						}
					}
				}
			}
			lblActualTime.set_Text(Strings.Format((object)intWeeks, "00") + "  " + Strings.Format((object)intDays, "00") + "        " + Strings.Format((object)intHours, "00") + ":" + Strings.Format((object)intMins, "00") + ":" + Strings.Format((object)intSecs, "00"));
		}
	}

	private void timPol_Tick(object sender, EventArgs e)
	{
		((Control)lblPol).set_BackColor(Color.LightSeaGreen);
		timPol.set_Enabled(false);
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (dblFails > 0.0)
		{
			ModBase.Write_ToFile("Stats were: " + Conversions.ToString(dblFails) + ", reset to 0");
			dblFails = 0.0;
			Label7.set_Text("Failed 0");
		}
	}

	private void OpenLogfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Open_LogFile();
	}

	public void Logging_Select(bool state)
	{
		if (MySettingsProperty.Settings.logEventsEnabled)
		{
			if (!bolStart)
			{
				ModBase.Write_ToFile("Logged Events turned on");
			}
			intLogging_Count = 0;
			lblLogging.set_Text("*");
			((Control)lblLogging).set_Visible(true);
			((Control)lblLogging_Text).set_Visible(true);
			timLogging_Indicator.set_Enabled(true);
			MySettingsProperty.Settings.logEventsEnabled = true;
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
		else if (!MySettingsProperty.Settings.logEventsEnabled)
		{
			if (!bolStart)
			{
				ModBase.Write_ToFile("Logged Events turned off");
			}
			((Control)lblLogging).set_Visible(false);
			((Control)lblLogging_Text).set_Visible(false);
			timLogging_Indicator.set_Enabled(false);
		}
		bolStart = false;
	}

	private void DeleteLogfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		string path = "C:\\Logs\\RouterLog\\Info.log";
		if (File.Exists(path))
		{
			string text = Conversions.ToString((int)Interaction.MsgBox((object)"Are you sure you want to delete the file?", (MsgBoxStyle)3, (object)null));
			if (Conversions.ToDouble(text) == 6.0)
			{
				File.Delete(path);
				ModBase.Write_ToFile("Log File Deleted");
				MessageBox.Show("File Deleted");
			}
		}
	}

	private void lblFailed_Click(object sender, EventArgs e)
	{
		Open_LogFile();
	}

	private void LogToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void FileToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void timLogging_Indicator_Tick(object sender, EventArgs e)
	{
		checked
		{
			intLogging_Count++;
			if (intLogging_Count >= 10)
			{
				intLogging_Count = 0;
				lblLogging.set_Text("");
			}
			lblLogging.set_Text(lblLogging.get_Text() + "*");
		}
	}

	private void toolSettings_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Form)MyProject.Forms.frmSettings).ShowDialog();
	}

	private void DebugInfoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.frmDebug).Show();
	}

	private void Label7_Click(object sender, EventArgs e)
	{
		Open_LogFile();
	}

	private void Open_LogFile()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		string text = "C:\\Logs\\RouterLog\\Info.log";
		if (File.Exists(text))
		{
			Process.Start(text);
		}
		else
		{
			Interaction.MsgBox((object)"File Does Not Exist", (MsgBoxStyle)0, (object)null);
		}
	}

	private void Label7_MouseHover(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		Font val = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1);
		Font font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)4);
		((Control)Label7).set_Cursor(Cursors.get_Hand());
		((Control)(Label)sender).set_ForeColor(Color.Blue);
		((Control)(Label)sender).set_Font(font);
	}

	private void LoggingOnToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (LoggingOnToolStripMenuItem.get_Checked())
		{
			MySettingsProperty.Settings.logEventsEnabled = false;
			MySettingsProperty.Settings.logEventsEnabled = false;
			LoggingOnToolStripMenuItem.set_Checked(false);
			ModBase.Write_ToFile("Logging turned Off");
		}
		else if (!LoggingOnToolStripMenuItem.get_Checked())
		{
			MySettingsProperty.Settings.logEventsEnabled = true;
			MySettingsProperty.Settings.logEventsEnabled = true;
			LoggingOnToolStripMenuItem.set_Checked(true);
			ModBase.Write_ToFile("Logging turned On");
		}
		((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
	}

	private void timFlashVPN_Tick(object sender, EventArgs e)
	{
		if (ModBase.intGreen >= 255)
		{
			ModBase.intGreen = 255;
			ModBase.VPNDirection = true;
		}
		if (ModBase.intGreen <= 170)
		{
			ModBase.intGreen = 170;
			ModBase.VPNDirection = false;
		}
		((Control)lblVPNActive).set_BackColor(Color.FromArgb(0, ModBase.intGreen, 0));
		((Control)lblVPNActive).Refresh();
		checked
		{
			if ((ModBase.intGreen <= 255) & !ModBase.VPNDirection)
			{
				ModBase.intGreen += 10;
			}
			else
			{
				ModBase.VPNDirection = true;
			}
			if ((ModBase.intGreen >= 170) & ModBase.VPNDirection)
			{
				ModBase.intGreen -= 10;
			}
			else
			{
				ModBase.VPNDirection = false;
			}
		}
	}

	private void Label7_MouseLeave(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		Font font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0);
		((Control)Label7).set_Cursor(Cursors.get_Default());
		((Control)(Label)sender).set_ForeColor(Color.Black);
		((Control)(Label)sender).set_Font(font);
	}

	private void lblInternetFails_MouseHover(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		Font font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)4);
		((Control)lblInternetFails).set_Cursor(Cursors.get_Hand());
		((Control)(Label)sender).set_ForeColor(Color.Blue);
		((Control)(Label)sender).set_Font(font);
	}

	private void lblInternetFails_MouseLeave(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		Font font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0);
		((Control)lblInternetFails).set_Cursor(Cursors.get_Default());
		((Control)(Label)sender).set_ForeColor(Color.Black);
		((Control)(Label)sender).set_Font(font);
	}

	private void lblInternetFails_MouseClick(object sender, MouseEventArgs e)
	{
		Open_LogFile();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_1469: Unknown result type (might be due to invalid IL or missing references)
		//IL_1473: Expected O, but got Unknown
		//IL_1d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d41: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer4 = new Timer(components);
		timCheckDNS = new Timer(components);
		lblLogging_Text = new Label();
		lblLogging = new Label();
		btnFinished = new Button();
		GroupBox1 = new GroupBox();
		Label11 = new Label();
		lblActualTime = new Label();
		lblRunTime = new Label();
		lblCStatus = new Label();
		lblAddress = new Label();
		lblPingComputer = new Label();
		Label5 = new Label();
		Label2 = new Label();
		lblName = new Label();
		Label1 = new Label();
		GroupBox4 = new GroupBox();
		GroupBox2 = new GroupBox();
		lblVPNActive = new Label();
		Label12 = new Label();
		lblRouter = new Label();
		lblInternetAddress = new Label();
		Label6 = new Label();
		lblRStatus = new Label();
		lblDHCP = new Label();
		Label3 = new Label();
		lblPingRouter = new Label();
		Label4 = new Label();
		GroupBox3 = new GroupBox();
		lblInternetFails = new Label();
		lblNetworkURL = new Label();
		Label10 = new Label();
		Label7 = new Label();
		Label9 = new Label();
		lblPol = new Label();
		lblDStatus = new Label();
		lblPingTalkTalkDNS = new Label();
		Label8 = new Label();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Timer5 = new Timer(components);
		Timer6 = new Timer(components);
		timFlashTalkTalkDNS = new Timer(components);
		MenuStrip1 = new MenuStrip();
		FileToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		toolSettings = new ToolStripMenuItem();
		ToolStripMenuItem1 = new ToolStripMenuItem();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		LogToolStripMenuItem = new ToolStripMenuItem();
		OpenLogfileToolStripMenuItem = new ToolStripMenuItem();
		DeleteLogfileToolStripMenuItem = new ToolStripMenuItem();
		DebugInfoToolStripMenuItem = new ToolStripMenuItem();
		LoggingOnToolStripMenuItem = new ToolStripMenuItem();
		timOneSec = new Timer(components);
		timPol = new Timer(components);
		timLogging_Indicator = new Timer(components);
		timFlashVPN = new Timer(components);
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		Timer4.set_Interval(500);
		timCheckDNS.set_Enabled(true);
		lblLogging_Text.set_AutoSize(true);
		((Control)lblLogging_Text).set_BackColor(Color.FromArgb(255, 255, 128));
		((Control)lblLogging_Text).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)lblLogging_Text).set_ForeColor(Color.Blue);
		((Control)lblLogging_Text).set_Location(new Point(28, 532));
		((Control)lblLogging_Text).set_Name("lblLogging_Text");
		((Control)lblLogging_Text).set_Size(new Size(57, 16));
		((Control)lblLogging_Text).set_TabIndex(23);
		lblLogging_Text.set_Text("Logging");
		((Control)lblLogging_Text).set_Visible(false);
		lblLogging.set_AutoSize(true);
		((Control)lblLogging).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)lblLogging).set_ForeColor(Color.Blue);
		((Control)lblLogging).set_Location(new Point(91, 537));
		((Control)lblLogging).set_Name("lblLogging");
		((Control)lblLogging).set_Size(new Size(11, 16));
		((Control)lblLogging).set_TabIndex(22);
		lblLogging.set_Text(" ");
		((Control)lblLogging).set_Visible(false);
		btnFinished.set_DialogResult((DialogResult)2);
		((Control)btnFinished).set_Location(new Point(200, 532));
		((Control)btnFinished).set_Name("btnFinished");
		((Control)btnFinished).set_Size(new Size(75, 23));
		((Control)btnFinished).set_TabIndex(21);
		((ButtonBase)btnFinished).set_Text("&Exit");
		((ButtonBase)btnFinished).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblActualTime);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblRunTime);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblCStatus);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblAddress);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblPingComputer);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)lblName);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox4);
		((Control)GroupBox1).set_Location(new Point(31, 27));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(244, 172));
		((Control)GroupBox1).set_TabIndex(18);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Computer Information");
		Label11.set_AutoSize(true);
		((Control)Label11).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)Label11).set_ForeColor(Color.Blue);
		((Control)Label11).set_Location(new Point(95, 119));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(106, 13));
		((Control)Label11).set_TabIndex(16);
		Label11.set_Text("ww dd        hh:mm:ss");
		lblActualTime.set_AutoSize(true);
		((Control)lblActualTime).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)lblActualTime).set_ForeColor(Color.Blue);
		((Control)lblActualTime).set_Location(new Point(95, 134));
		((Control)lblActualTime).set_Name("lblActualTime");
		((Control)lblActualTime).set_Size(new Size(13, 13));
		((Control)lblActualTime).set_TabIndex(15);
		lblActualTime.set_Text("0");
		lblRunTime.set_AutoSize(true);
		((Control)lblRunTime).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)lblRunTime).set_ForeColor(SystemColors.ControlText);
		((Control)lblRunTime).set_Location(new Point(20, 134));
		((Control)lblRunTime).set_Name("lblRunTime");
		((Control)lblRunTime).set_Size(new Size(46, 13));
		((Control)lblRunTime).set_TabIndex(14);
		lblRunTime.set_Text("Runtime");
		lblCStatus.set_AutoSize(true);
		((Control)lblCStatus).set_BackColor(Color.Yellow);
		((Control)lblCStatus).set_ForeColor(Color.Blue);
		((Control)lblCStatus).set_Location(new Point(147, 88));
		((Control)lblCStatus).set_Name("lblCStatus");
		((Control)lblCStatus).set_Size(new Size(35, 13));
		((Control)lblCStatus).set_TabIndex(13);
		lblCStatus.set_Text("Down");
		lblAddress.set_AutoSize(true);
		((Control)lblAddress).set_BackColor(Color.Yellow);
		((Control)lblAddress).set_ForeColor(Color.Blue);
		((Control)lblAddress).set_Location(new Point(147, 66));
		((Control)lblAddress).set_Name("lblAddress");
		((Control)lblAddress).set_Size(new Size(0, 13));
		((Control)lblAddress).set_TabIndex(7);
		lblPingComputer.set_AutoSize(true);
		((Control)lblPingComputer).set_BackColor(Color.Red);
		lblPingComputer.set_BorderStyle((BorderStyle)1);
		((Control)lblPingComputer).set_Location(new Point(98, 84));
		((Control)lblPingComputer).set_MinimumSize(new Size(18, 18));
		((Control)lblPingComputer).set_Name("lblPingComputer");
		((Control)lblPingComputer).set_Size(new Size(18, 18));
		((Control)lblPingComputer).set_TabIndex(12);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(20, 88));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(58, 13));
		((Control)Label5).set_TabIndex(11);
		Label5.set_Text("Computer:-");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(20, 62));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(99, 13));
		((Control)Label2).set_TabIndex(6);
		Label2.set_Text("Computer Address:-");
		lblName.set_AutoSize(true);
		((Control)lblName).set_BackColor(Color.Yellow);
		((Control)lblName).set_ForeColor(Color.Blue);
		((Control)lblName).set_Location(new Point(147, 38));
		((Control)lblName).set_Name("lblName");
		((Control)lblName).set_Size(new Size(0, 13));
		((Control)lblName).set_TabIndex(5);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(20, 34));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(89, 13));
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Computer Name:-");
		((Control)GroupBox4).set_BackColor(Color.FromArgb(255, 255, 192));
		((Control)GroupBox4).set_Location(new Point(11, 109));
		((Control)GroupBox4).set_Name("GroupBox4");
		((Control)GroupBox4).set_Size(new Size(220, 49));
		((Control)GroupBox4).set_TabIndex(17);
		GroupBox4.set_TabStop(false);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lblVPNActive);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lblRouter);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lblInternetAddress);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lblRStatus);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lblDHCP);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lblPingRouter);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).set_Location(new Point(31, 207));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(244, 170));
		((Control)GroupBox2).set_TabIndex(19);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Router Information");
		lblVPNActive.set_AutoSize(true);
		((Control)lblVPNActive).set_BackColor(Color.Yellow);
		lblVPNActive.set_BorderStyle((BorderStyle)1);
		((Control)lblVPNActive).set_Location(new Point(150, 90));
		((Control)lblVPNActive).set_MaximumSize(new Size(40, 18));
		((Control)lblVPNActive).set_MinimumSize(new Size(40, 18));
		((Control)lblVPNActive).set_Name("lblVPNActive");
		((Control)lblVPNActive).set_Size(new Size(40, 18));
		((Control)lblVPNActive).set_TabIndex(26);
		Label12.set_AutoSize(true);
		((Control)Label12).set_BackColor(Color.Yellow);
		Label12.set_BorderStyle((BorderStyle)1);
		((Control)Label12).set_Location(new Point(95, 143));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(47, 15));
		((Control)Label12).set_TabIndex(25);
		Label12.set_Text("Label12");
		lblRouter.set_AutoSize(true);
		((Control)lblRouter).set_Location(new Point(9, 143));
		((Control)lblRouter).set_Name("lblRouter");
		((Control)lblRouter).set_Size(new Size(76, 13));
		((Control)lblRouter).set_TabIndex(24);
		lblRouter.set_Text("Real Address:-");
		lblInternetAddress.set_AutoSize(true);
		((Control)lblInternetAddress).set_BackColor(Color.Yellow);
		lblInternetAddress.set_BorderStyle((BorderStyle)1);
		((Control)lblInternetAddress).set_ForeColor(Color.FromArgb(0, 0, 192));
		((Control)lblInternetAddress).set_Location(new Point(11, 116));
		((Control)lblInternetAddress).set_Name("lblInternetAddress");
		((Control)lblInternetAddress).set_Size(new Size(222, 15));
		((Control)lblInternetAddress).set_TabIndex(23);
		lblInternetAddress.set_Text("0000:0000:0000:0000:0000:0000:0000:0000");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Location(new Point(9, 95));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(93, 13));
		((Control)Label6).set_TabIndex(22);
		Label6.set_Text("Router Address is ");
		lblRStatus.set_AutoSize(true);
		((Control)lblRStatus).set_BackColor(Color.Yellow);
		((Control)lblRStatus).set_ForeColor(Color.Blue);
		((Control)lblRStatus).set_Location(new Point(148, 59));
		((Control)lblRStatus).set_Name("lblRStatus");
		((Control)lblRStatus).set_Size(new Size(52, 13));
		((Control)lblRStatus).set_TabIndex(10);
		lblRStatus.set_Text("Checking");
		lblDHCP.set_AutoSize(true);
		((Control)lblDHCP).set_BackColor(Color.Yellow);
		((Control)lblDHCP).set_ForeColor(Color.Blue);
		((Control)lblDHCP).set_Location(new Point(147, 28));
		((Control)lblDHCP).set_Name("lblDHCP");
		((Control)lblDHCP).set_Size(new Size(0, 13));
		((Control)lblDHCP).set_TabIndex(7);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(20, 28));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(111, 13));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("DNS Server Address:-");
		lblPingRouter.set_AutoSize(true);
		((Control)lblPingRouter).set_BackColor(Color.Red);
		lblPingRouter.set_BorderStyle((BorderStyle)1);
		((Control)lblPingRouter).set_Location(new Point(114, 56));
		((Control)lblPingRouter).set_MinimumSize(new Size(18, 18));
		((Control)lblPingRouter).set_Name("lblPingRouter");
		((Control)lblPingRouter).set_Size(new Size(18, 18));
		((Control)lblPingRouter).set_TabIndex(9);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(20, 58));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(85, 13));
		((Control)Label4).set_TabIndex(8);
		Label4.set_Text("DNS via Router:");
		((Control)GroupBox3).get_Controls().Add((Control)(object)lblInternetFails);
		((Control)GroupBox3).get_Controls().Add((Control)(object)lblNetworkURL);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox3).get_Controls().Add((Control)(object)lblPol);
		((Control)GroupBox3).get_Controls().Add((Control)(object)lblDStatus);
		((Control)GroupBox3).get_Controls().Add((Control)(object)lblPingTalkTalkDNS);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox3).set_Location(new Point(31, 382));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(244, 141));
		((Control)GroupBox3).set_TabIndex(20);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Internet");
		lblInternetFails.set_AutoSize(true);
		((Control)lblInternetFails).set_Location(new Point(8, 114));
		((Control)lblInternetFails).set_Name("lblInternetFails");
		((Control)lblInternetFails).set_Size(new Size(121, 13));
		((Control)lblInternetFails).set_TabIndex(28);
		lblInternetFails.set_Text("IP Address Change(s): 0");
		lblNetworkURL.set_AutoSize(true);
		((Control)lblNetworkURL).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)4, (GraphicsUnit)3, (byte)0));
		((Control)lblNetworkURL).set_ForeColor(Color.Blue);
		((Control)lblNetworkURL).set_Location(new Point(95, 86));
		((Control)lblNetworkURL).set_Name("lblNetworkURL");
		((Control)lblNetworkURL).set_Size(new Size(0, 13));
		((Control)lblNetworkURL).set_TabIndex(27);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Location(new Point(8, 86));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(75, 13));
		((Control)Label10).set_TabIndex(26);
		Label10.set_Text("Network URL:");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Location(new Point(147, 24));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(44, 13));
		((Control)Label7).set_TabIndex(24);
		Label7.set_Text("Failed 0");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Location(new Point(8, 24));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(47, 13));
		((Control)Label9).set_TabIndex(23);
		Label9.set_Text("Running");
		lblPol.set_AutoSize(true);
		((Control)lblPol).set_BackColor(Color.Yellow);
		lblPol.set_BorderStyle((BorderStyle)1);
		((Control)lblPol).set_Location(new Point(98, 24));
		((Control)lblPol).set_MaximumSize(new Size(18, 18));
		((Control)lblPol).set_MinimumSize(new Size(18, 18));
		((Control)lblPol).set_Name("lblPol");
		((Control)lblPol).set_Size(new Size(18, 18));
		((Control)lblPol).set_TabIndex(22);
		lblDStatus.set_AutoSize(true);
		((Control)lblDStatus).set_BackColor(Color.Yellow);
		((Control)lblDStatus).set_ForeColor(Color.Blue);
		((Control)lblDStatus).set_Location(new Point(147, 54));
		((Control)lblDStatus).set_Name("lblDStatus");
		((Control)lblDStatus).set_Size(new Size(35, 13));
		((Control)lblDStatus).set_TabIndex(19);
		lblDStatus.set_Text("Down");
		lblPingTalkTalkDNS.set_AutoSize(true);
		((Control)lblPingTalkTalkDNS).set_BackColor(Color.Red);
		lblPingTalkTalkDNS.set_BorderStyle((BorderStyle)1);
		((Control)lblPingTalkTalkDNS).set_Location(new Point(98, 50));
		((Control)lblPingTalkTalkDNS).set_MinimumSize(new Size(18, 18));
		((Control)lblPingTalkTalkDNS).set_Name("lblPingTalkTalkDNS");
		((Control)lblPingTalkTalkDNS).set_Size(new Size(18, 18));
		((Control)lblPingTalkTalkDNS).set_TabIndex(18);
		Label8.set_AutoSize(true);
		((Control)Label8).set_Location(new Point(8, 52));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(83, 13));
		((Control)Label8).set_TabIndex(17);
		Label8.set_Text("DNS Resolution");
		Timer1.set_Enabled(true);
		Timer1.set_Interval(10);
		Timer2.set_Interval(1000);
		Timer3.set_Enabled(true);
		Timer3.set_Interval(500);
		Timer5.set_Enabled(true);
		Timer5.set_Interval(30);
		Timer6.set_Enabled(true);
		timFlashTalkTalkDNS.set_Interval(500);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)LogToolStripMenuItem
		});
		((Control)MenuStrip1).set_Location(new Point(0, 0));
		((Control)MenuStrip1).set_Name("MenuStrip1");
		((Control)MenuStrip1).set_Size(new Size(310, 24));
		((Control)MenuStrip1).set_TabIndex(24);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)toolSettings,
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)AboutToolStripMenuItem,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		((ToolStripItem)FileToolStripMenuItem).set_Size(new Size(37, 20));
		((ToolStripItem)FileToolStripMenuItem).set_Text("&File");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		((ToolStripItem)ToolStripSeparator1).set_Size(new Size(127, 6));
		((ToolStripItem)toolSettings).set_Name("toolSettings");
		((ToolStripItem)toolSettings).set_Size(new Size(130, 22));
		((ToolStripItem)toolSettings).set_Text("&Settings");
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		((ToolStripItem)ToolStripMenuItem1).set_Size(new Size(130, 22));
		((ToolStripItem)ToolStripMenuItem1).set_Text("&Reset Stats");
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		((ToolStripItem)AboutToolStripMenuItem).set_Size(new Size(130, 22));
		((ToolStripItem)AboutToolStripMenuItem).set_Text("&About");
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		((ToolStripItem)ExitToolStripMenuItem).set_Size(new Size(130, 22));
		((ToolStripItem)ExitToolStripMenuItem).set_Text("&Exit");
		((ToolStripDropDownItem)LogToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)OpenLogfileToolStripMenuItem,
			(ToolStripItem)DeleteLogfileToolStripMenuItem,
			(ToolStripItem)DebugInfoToolStripMenuItem,
			(ToolStripItem)LoggingOnToolStripMenuItem
		});
		((ToolStripItem)LogToolStripMenuItem).set_Name("LogToolStripMenuItem");
		((ToolStripItem)LogToolStripMenuItem).set_Size(new Size(39, 20));
		((ToolStripItem)LogToolStripMenuItem).set_Text("&Log");
		((ToolStripItem)OpenLogfileToolStripMenuItem).set_Name("OpenLogfileToolStripMenuItem");
		((ToolStripItem)OpenLogfileToolStripMenuItem).set_Size(new Size(146, 22));
		((ToolStripItem)OpenLogfileToolStripMenuItem).set_Text("&Open Logfile");
		((ToolStripItem)DeleteLogfileToolStripMenuItem).set_Name("DeleteLogfileToolStripMenuItem");
		((ToolStripItem)DeleteLogfileToolStripMenuItem).set_Size(new Size(146, 22));
		((ToolStripItem)DeleteLogfileToolStripMenuItem).set_Text("&Delete Logfile");
		((ToolStripItem)DebugInfoToolStripMenuItem).set_Name("DebugInfoToolStripMenuItem");
		((ToolStripItem)DebugInfoToolStripMenuItem).set_Size(new Size(146, 22));
		((ToolStripItem)DebugInfoToolStripMenuItem).set_Text("&Debug Info");
		LoggingOnToolStripMenuItem.set_Checked(true);
		LoggingOnToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)LoggingOnToolStripMenuItem).set_Name("LoggingOnToolStripMenuItem");
		((ToolStripItem)LoggingOnToolStripMenuItem).set_Size(new Size(146, 22));
		((ToolStripItem)LoggingOnToolStripMenuItem).set_Text("Logging On");
		timOneSec.set_Enabled(true);
		timOneSec.set_Interval(5);
		timPol.set_Interval(200);
		timLogging_Indicator.set_Interval(500);
		timFlashVPN.set_Enabled(true);
		timFlashVPN.set_Interval(150);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(310, 570));
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Control)this).get_Controls().Add((Control)(object)lblLogging_Text);
		((Control)this).get_Controls().Add((Control)(object)lblLogging);
		((Control)this).get_Controls().Add((Control)(object)btnFinished);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximumSize(new Size(326, 609));
		((Form)this).set_MinimumSize(new Size(326, 609));
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
