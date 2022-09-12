using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

public sealed class GClass0
{
	public static bool smethod_0()
	{
		return smethod_1(Application.get_ProductName(), Application.get_ExecutablePath());
	}

	public static bool smethod_1(string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class6.string_0, writable: true);
			registryKey.SetValue(string_0, string_1);
		}
		catch (Exception ex)
		{
			string path = Application.get_StartupPath() + Class11.smethod_0(-2094346204);
			try
			{
				StreamWriter streamWriter = new StreamWriter(path);
				try
				{
					string text = DateTime.Now.ToString(Class11.smethod_0(-2094346185)) + Environment.NewLine;
					text = text + ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine + Class11.smethod_0(-2094346145) + Environment.NewLine;
					streamWriter.Write(text);
					streamWriter.Close();
					return false;
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			catch (Exception ex2)
			{
				ex2.GetType();
				return false;
			}
		}
		return true;
	}

	public static bool smethod_2()
	{
		return smethod_4(Application.get_ProductName(), Application.get_ExecutablePath());
	}

	public static bool smethod_3(string string_0)
	{
		return smethod_4(string_0, null);
	}

	public static bool smethod_4(string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class6.string_0, writable: true);
			if (string_1 == null)
			{
				registryKey.DeleteValue(string_0);
			}
			else if (registryKey.GetValue(string_0)!.ToString()!.ToLower() == string_1.ToLower())
			{
				registryKey.DeleteValue(string_0);
			}
			return true;
		}
		catch (Exception)
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class6.string_0, writable: true);
			if (string_1 == null)
			{
				registryKey.DeleteValue(string_0);
			}
			else if (registryKey.GetValue(string_0)!.ToString()!.ToLower() == string_1.ToLower())
			{
				registryKey.DeleteValue(string_0);
			}
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public static bool smethod_5()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string name = executingAssembly.GetName().Name;
		return smethod_6(name, Application.get_ExecutablePath());
	}

	public static bool smethod_6(string string_0, string string_1)
	{
		try
		{
			byte[] array = null;
			array = Convert.FromBase64String(Class11.smethod_0(-2094346143));
			Encoding.ASCII.GetString(array);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Encoding.ASCII.GetString(array), writable: true);
			if (registryKey == null)
			{
				return false;
			}
			object value = registryKey.GetValue(string_0);
			string text = ((value == null) ? null : registryKey.GetValue(string_0)!.ToString());
			if (text == null)
			{
				return false;
			}
			if (!text.ToLower().Equals(string_1.ToLower()))
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			ex.GetType();
		}
		return false;
	}
}
