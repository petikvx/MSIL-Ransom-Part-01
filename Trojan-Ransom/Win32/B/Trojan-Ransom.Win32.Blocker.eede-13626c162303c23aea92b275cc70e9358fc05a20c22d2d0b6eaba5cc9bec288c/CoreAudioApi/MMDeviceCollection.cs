using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class MMDeviceCollection
{
	private IMMDeviceCollection _MMDeviceCollection;

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(_MMDeviceCollection.GetCount(out var pcDevices));
			return (int)pcDevices;
		}
	}

	public MMDevice this[int index]
	{
		get
		{
			_MMDeviceCollection.Item((uint)index, out var Device);
			return new MMDevice(Device);
		}
	}

	internal MMDeviceCollection(IMMDeviceCollection parent)
	{
		_MMDeviceCollection = parent;
	}
}
