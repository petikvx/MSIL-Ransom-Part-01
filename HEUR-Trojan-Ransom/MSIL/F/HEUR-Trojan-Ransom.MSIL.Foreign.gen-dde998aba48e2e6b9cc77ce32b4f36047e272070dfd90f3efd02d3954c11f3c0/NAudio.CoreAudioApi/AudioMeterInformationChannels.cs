using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.CoreAudioApi;

public sealed class AudioMeterInformationChannels
{
	private readonly IAudioMeterInformation audioMeterInformation;

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioMeterInformation.GetMeteringChannelCount(out var pnChannelCount));
			return pnChannelCount;
		}
	}

	public float this[int index]
	{
		get
		{
			float[] array = new float[Count];
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			Marshal.ThrowExceptionForHR(audioMeterInformation.GetChannelsPeakValues(array.Length, gCHandle.AddrOfPinnedObject()));
			gCHandle.Free();
			return array[index];
		}
	}

	internal AudioMeterInformationChannels(IAudioMeterInformation parent)
	{
		audioMeterInformation = parent;
	}
}
