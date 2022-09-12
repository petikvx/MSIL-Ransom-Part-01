using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RecordingState
{
	[Description("inactive")]
	inactive,
	[Description("recording")]
	recording,
	[Description("paused")]
	paused
}
