using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace iTuner;

public class UsbManager : IDisposable
{
	private class DriverWindow : NativeWindow, IDisposable
	{
		public struct DEV_BROADCAST_VOLUME
		{
			public int dbcv_size;

			public int dbcv_devicetype;

			public int dbcv_reserved;

			public int dbcv_unitmask;

			public short dbcv_flags;
		}

		private const int WM_DEVICECHANGE = 537;

		private const int DBT_DEVICEARRIVAL = 32768;

		private const int DBT_DEVICEQUERYREMOVE = 32769;

		private const int DBT_DEVICEREMOVECOMPLETE = 32772;

		private const int DBT_DEVTYP_VOLUME = 2;

		public event UsbStateChangedEventHandler StateChanged;

		public DriverWindow()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			((NativeWindow)this).CreateHandle(new CreateParams());
		}

		public void Dispose()
		{
			((NativeWindow)this).DestroyHandle();
			GC.SuppressFinalize(this);
		}

		protected override void WndProc(ref Message message)
		{
			((NativeWindow)this).WndProc(ref message);
			if (((Message)(ref message)).get_Msg() != 537 || !(((Message)(ref message)).get_LParam() != IntPtr.Zero))
			{
				return;
			}
			DEV_BROADCAST_VOLUME volume = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(((Message)(ref message)).get_LParam(), typeof(DEV_BROADCAST_VOLUME));
			if (volume.dbcv_devicetype == 2)
			{
				switch (((Message)(ref message)).get_WParam().ToInt32())
				{
				case 32768:
					SignalDeviceChange(UsbStateChange.Added, volume);
					break;
				case 32772:
					SignalDeviceChange(UsbStateChange.Removed, volume);
					break;
				case 32769:
				case 32770:
				case 32771:
					break;
				}
			}
		}

		private void SignalDeviceChange(UsbStateChange state, DEV_BROADCAST_VOLUME volume)
		{
			string name = ToUnitName(volume.dbcv_unitmask);
			if (this.StateChanged != null)
			{
				UsbDisk disk = new UsbDisk(name);
				this.StateChanged(new UsbStateChangedEventArgs(state, disk));
			}
		}

		private string ToUnitName(int mask)
		{
			int i;
			for (i = 0; i < 26; i++)
			{
				if (((uint)mask & (true ? 1u : 0u)) != 0)
				{
					break;
				}
				mask >>= 1;
			}
			if (i < 26)
			{
				return $"{Convert.ToChar(Convert.ToInt32('A') + i)}:";
			}
			return "?:";
		}
	}

	private delegate void GetDiskInformationDelegate(UsbDisk disk);

	private DriverWindow window;

	private UsbStateChangedEventHandler handler;

	private bool isDisposed;

	public event UsbStateChangedEventHandler StateChanged
	{
		add
		{
			if (window == null)
			{
				window = new DriverWindow();
				window.StateChanged += DoStateChanged;
			}
			handler = (UsbStateChangedEventHandler)Delegate.Combine(handler, value);
		}
		remove
		{
			handler = (UsbStateChangedEventHandler)Delegate.Remove(handler, value);
			if (handler == null)
			{
				window.StateChanged -= DoStateChanged;
				window.Dispose();
				window = null;
			}
		}
	}

	public UsbManager()
	{
		window = null;
		handler = null;
		isDisposed = false;
	}

	~UsbManager()
	{
		Dispose();
	}

	public void Dispose()
	{
		if (!isDisposed)
		{
			if (window != null)
			{
				window.StateChanged -= DoStateChanged;
				window.Dispose();
				window = null;
			}
			isDisposed = true;
			GC.SuppressFinalize(this);
		}
	}

	public UsbDiskCollection GetAvailableDisks()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		UsbDiskCollection usbDiskCollection = new UsbDiskCollection();
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("select DeviceID, Model from Win32_DiskDrive where InterfaceType='USB'").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				ManagementObject val2 = WmiExtensions.First(new ManagementObjectSearcher(string.Format("associators of {{Win32_DiskDrive.DeviceID='{0}'}} where AssocClass = Win32_DiskDriveToDiskPartition", ((ManagementBaseObject)val).get_Item("DeviceID"))));
				if (val2 != null)
				{
					ManagementObject val3 = WmiExtensions.First(new ManagementObjectSearcher(string.Format("associators of {{Win32_DiskPartition.DeviceID='{0}'}} where AssocClass = Win32_LogicalDiskToPartition", ((ManagementBaseObject)val2).get_Item("DeviceID"))));
					if (val3 != null)
					{
						ManagementObject val4 = WmiExtensions.First(new ManagementObjectSearcher(string.Format("select FreeSpace, Size, VolumeName from Win32_LogicalDisk where Name='{0}'", ((ManagementBaseObject)val3).get_Item("Name"))));
						UsbDisk usbDisk = new UsbDisk(((ManagementBaseObject)val3).get_Item("Name").ToString());
						usbDisk.Model = ((ManagementBaseObject)val).get_Item("Model").ToString();
						usbDisk.Volume = ((ManagementBaseObject)val4).get_Item("VolumeName").ToString();
						usbDisk.FreeSpace = (ulong)((ManagementBaseObject)val4).get_Item("FreeSpace");
						usbDisk.Size = (ulong)((ManagementBaseObject)val4).get_Item("Size");
						usbDiskCollection.Add(usbDisk);
					}
				}
			}
			return usbDiskCollection;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private void DoStateChanged(UsbStateChangedEventArgs e)
	{
		if (handler != null)
		{
			_ = e.Disk;
			if (e.State == UsbStateChange.Added && e.Disk.Name[0] != '?')
			{
				GetDiskInformationDelegate getDiskInformationDelegate = GetDiskInformation;
				IAsyncResult result = getDiskInformationDelegate.BeginInvoke(e.Disk, null, null);
				getDiskInformationDelegate.EndInvoke(result);
			}
			handler(e);
		}
	}

	private void GetDiskInformation(UsbDisk disk)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		ManagementObject val = WmiExtensions.First(new ManagementObjectSearcher($"associators of {{Win32_LogicalDisk.DeviceID='{disk.Name}'}} where AssocClass = Win32_LogicalDiskToPartition"));
		if (val == null)
		{
			return;
		}
		ManagementObject val2 = WmiExtensions.First(new ManagementObjectSearcher(string.Format("associators of {{Win32_DiskPartition.DeviceID='{0}'}}  where resultClass = Win32_DiskDrive", ((ManagementBaseObject)val).get_Item("DeviceID"))));
		if (val2 != null)
		{
			object obj = ((ManagementBaseObject)val2).get_Item("Model");
			if (obj != null)
			{
				disk.Model = obj.ToString();
			}
		}
		ManagementObject val3 = WmiExtensions.First(new ManagementObjectSearcher($"select FreeSpace, Size, VolumeName from Win32_LogicalDisk where Name='{disk.Name}'"));
		if (val3 != null)
		{
			object obj2 = ((ManagementBaseObject)val3).get_Item("VolumeName");
			if (obj2 != null)
			{
				disk.Volume = obj2.ToString();
			}
			disk.FreeSpace = (ulong)((ManagementBaseObject)val3).get_Item("FreeSpace");
			disk.Size = (ulong)((ManagementBaseObject)val3).get_Item("Size");
		}
	}
}
