using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioEndpointVolumeStepInformation
{
	private uint _Step;

	private uint _StepCount;

	public uint Step => _Step;

	public uint StepCount => _StepCount;

	internal AudioEndpointVolumeStepInformation(IAudioEndpointVolume parent)
	{
		Marshal.ThrowExceptionForHR(parent.GetVolumeStepInfo(out _Step, out _StepCount));
	}
}
