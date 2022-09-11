using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.CoreAudioApi;

public sealed class AudioEndpointVolumeStepInformation
{
	private readonly uint step;

	private readonly uint stepCount;

	public uint Step => step;

	public uint StepCount => stepCount;

	internal AudioEndpointVolumeStepInformation(IAudioEndpointVolume parent)
	{
		Marshal.ThrowExceptionForHR(parent.GetVolumeStepInfo(out step, out stepCount));
	}
}
