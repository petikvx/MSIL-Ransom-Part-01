using System.ComponentModel;

namespace Gecko.WebIDL;

public enum AnimationPlayState
{
	[Description("idle")]
	idle,
	[Description("pending")]
	pending,
	[Description("running")]
	running,
	[Description("paused")]
	paused,
	[Description("finished")]
	finished
}
