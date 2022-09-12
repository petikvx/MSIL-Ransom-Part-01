using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SpeechRecognitionErrorCode
{
	[Description("no-speech")]
	nospeech,
	[Description("aborted")]
	aborted,
	[Description("audio-capture")]
	audiocapture,
	[Description("network")]
	network,
	[Description("not-allowed")]
	notallowed,
	[Description("service-not-allowed")]
	servicenotallowed,
	[Description("bad-grammar")]
	badgrammar,
	[Description("language-not-supported")]
	languagenotsupported
}
