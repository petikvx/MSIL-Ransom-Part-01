using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioMeterInformation
{
	private IAudioMeterInformation _AudioMeterInformation;

	private EEndpointHardwareSupport _HardwareSupport;

	private AudioMeterInformationChannels _Channels;

	public AudioMeterInformationChannels PeakValues => _Channels;

	public EEndpointHardwareSupport HardwareSupport => _HardwareSupport;

	public float MasterPeakValue
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioMeterInformation.GetPeakValue(out var pfPeak));
			return pfPeak;
		}
	}

	internal AudioMeterInformation(IAudioMeterInformation realInterface)
	{
		_AudioMeterInformation = realInterface;
		Marshal.ThrowExceptionForHR(_AudioMeterInformation.QueryHardwareSupport(out var pdwHardwareSupportMask));
		_HardwareSupport = (EEndpointHardwareSupport)pdwHardwareSupportMask;
		_Channels = new AudioMeterInformationChannels(_AudioMeterInformation);
	}
}
