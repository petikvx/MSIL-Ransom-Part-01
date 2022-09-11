using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.CoreAudioApi;

public sealed class AudioMeterInformation
{
	private readonly IAudioMeterInformation audioMeterInformation;

	private readonly EEndpointHardwareSupport hardwareSupport;

	private readonly AudioMeterInformationChannels channels;

	public AudioMeterInformationChannels PeakValues => channels;

	public EEndpointHardwareSupport HardwareSupport => hardwareSupport;

	public float MasterPeakValue
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioMeterInformation.GetPeakValue(out var pfPeak));
			return pfPeak;
		}
	}

	internal AudioMeterInformation(IAudioMeterInformation realInterface)
	{
		audioMeterInformation = realInterface;
		Marshal.ThrowExceptionForHR(audioMeterInformation.QueryHardwareSupport(out var pdwHardwareSupportMask));
		hardwareSupport = (EEndpointHardwareSupport)pdwHardwareSupportMask;
		channels = new AudioMeterInformationChannels(audioMeterInformation);
	}
}
