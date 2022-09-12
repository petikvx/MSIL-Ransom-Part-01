using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CaretChangedReason
{
	[Description("visibilitychange")]
	visibilitychange,
	[Description("updateposition")]
	updateposition,
	[Description("longpressonemptycontent")]
	longpressonemptycontent,
	[Description("taponcaret")]
	taponcaret,
	[Description("presscaret")]
	presscaret,
	[Description("releasecaret")]
	releasecaret
}
