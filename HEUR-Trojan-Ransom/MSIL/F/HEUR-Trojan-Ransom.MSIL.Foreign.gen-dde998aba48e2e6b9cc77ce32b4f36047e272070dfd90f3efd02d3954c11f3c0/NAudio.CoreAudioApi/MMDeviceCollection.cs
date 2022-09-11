using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.CoreAudioApi;

public sealed class MMDeviceCollection : IEnumerable, IEnumerable<MMDevice>
{
	private IMMDeviceCollection _MMDeviceCollection;

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(_MMDeviceCollection.GetCount(out var numDevices));
			return numDevices;
		}
	}

	public MMDevice this[int index]
	{
		get
		{
			_MMDeviceCollection.Item(index, out var device);
			return new MMDevice(device);
		}
	}

	internal MMDeviceCollection(IMMDeviceCollection parent)
	{
		_MMDeviceCollection = parent;
	}

	public IEnumerator<MMDevice> GetEnumerator()
	{
		for (int index = 0; index < Count; index++)
		{
			yield return this[index];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
