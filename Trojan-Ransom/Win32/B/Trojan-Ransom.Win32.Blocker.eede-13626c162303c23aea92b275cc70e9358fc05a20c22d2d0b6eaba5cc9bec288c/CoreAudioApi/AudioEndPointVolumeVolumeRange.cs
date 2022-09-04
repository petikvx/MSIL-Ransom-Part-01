using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioEndPointVolumeVolumeRange
{
	private float _VolumeMindB;

	private float _VolumeMaxdB;

	private float _VolumeIncrementdB;

	public float MindB => _VolumeMindB;

	public float MaxdB => _VolumeMaxdB;

	public float IncrementdB => _VolumeIncrementdB;

	internal AudioEndPointVolumeVolumeRange(IAudioEndpointVolume parent)
	{
		Marshal.ThrowExceptionForHR(parent.GetVolumeRange(out _VolumeMindB, out _VolumeMaxdB, out _VolumeIncrementdB));
	}
}
