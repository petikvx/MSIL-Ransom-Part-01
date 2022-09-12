using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TextTrackKind
{
	[Description("subtitles")]
	subtitles,
	[Description("captions")]
	captions,
	[Description("descriptions")]
	descriptions,
	[Description("chapters")]
	chapters,
	[Description("metadata")]
	metadata
}
