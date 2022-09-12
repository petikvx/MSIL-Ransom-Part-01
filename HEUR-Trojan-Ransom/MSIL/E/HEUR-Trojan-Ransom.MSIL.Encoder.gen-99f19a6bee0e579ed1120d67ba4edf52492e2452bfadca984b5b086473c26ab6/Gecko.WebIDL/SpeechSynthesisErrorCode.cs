using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SpeechSynthesisErrorCode
{
	[Description("canceled")]
	canceled,
	[Description("interrupted")]
	interrupted,
	[Description("audio-busy")]
	audiobusy,
	[Description("audio-hardware")]
	audiohardware,
	[Description("network")]
	network,
	[Description("synthesis-unavailable")]
	synthesisunavailable,
	[Description("synthesis-failed")]
	synthesisfailed,
	[Description("language-unavailable")]
	languageunavailable,
	[Description("voice-unavailable")]
	voiceunavailable,
	[Description("text-too-long")]
	texttoolong,
	[Description("invalid-argument")]
	invalidargument
}
