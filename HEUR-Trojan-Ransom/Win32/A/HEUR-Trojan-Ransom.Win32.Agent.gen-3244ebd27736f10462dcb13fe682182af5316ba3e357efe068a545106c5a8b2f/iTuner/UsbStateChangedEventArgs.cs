using System;

namespace iTuner;

public class UsbStateChangedEventArgs : EventArgs
{
	public UsbDisk Disk { get; private set; }

	public UsbStateChange State { get; private set; }

	public UsbStateChangedEventArgs(UsbStateChange state, UsbDisk disk)
	{
		State = state;
		Disk = disk;
	}
}
