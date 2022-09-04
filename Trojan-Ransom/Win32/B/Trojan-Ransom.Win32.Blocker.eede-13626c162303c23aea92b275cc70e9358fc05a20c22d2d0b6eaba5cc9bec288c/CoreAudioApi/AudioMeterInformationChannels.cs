using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioMeterInformationChannels
{
	private IAudioMeterInformation _AudioMeterInformation;

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioMeterInformation.GetMeteringChannelCount(out var pnChannelCount));
			return pnChannelCount;
		}
	}

	public float this[int index]
	{
		get
		{
			float[] array = new float[Count];
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			Marshal.ThrowExceptionForHR(_AudioMeterInformation.GetChannelsPeakValues(array.Length, gCHandle.AddrOfPinnedObject()));
			gCHandle.Free();
			return array[index];
		}
	}

	internal AudioMeterInformationChannels(IAudioMeterInformation parent)
	{
		_AudioMeterInformation = parent;
	}
}
