using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TVScanningState
{
	[Description("cleared")]
	cleared,
	[Description("scanned")]
	scanned,
	[Description("completed")]
	completed,
	[Description("stopped")]
	stopped
}
