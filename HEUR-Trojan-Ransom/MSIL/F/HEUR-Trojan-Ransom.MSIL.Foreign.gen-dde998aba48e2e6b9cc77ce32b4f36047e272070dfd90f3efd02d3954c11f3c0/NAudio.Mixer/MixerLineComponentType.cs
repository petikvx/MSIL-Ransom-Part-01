namespace NAudio.Mixer;

public enum MixerLineComponentType
{
	DestinationUndefined = 0,
	DestinationDigital = 1,
	DestinationLine = 2,
	DestinationMonitor = 3,
	DestinationSpeakers = 4,
	DestinationHeadphones = 5,
	DestinationTelephone = 6,
	DestinationWaveIn = 7,
	DestinationVoiceIn = 8,
	SourceUndefined = 4096,
	SourceDigital = 4097,
	SourceLine = 4098,
	SourceMicrophone = 4099,
	SourceSynthesizer = 4100,
	SourceCompactDisc = 4101,
	SourceTelephone = 4102,
	SourcePcSpeaker = 4103,
	SourceWaveOut = 4104,
	SourceAuxiliary = 4105,
	SourceAnalog = 4106
}
