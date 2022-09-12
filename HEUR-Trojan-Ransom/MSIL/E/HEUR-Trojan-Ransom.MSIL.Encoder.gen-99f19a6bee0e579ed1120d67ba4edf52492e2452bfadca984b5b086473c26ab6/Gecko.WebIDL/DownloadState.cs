using System.ComponentModel;

namespace Gecko.WebIDL;

public enum DownloadState
{
	[Description("downloading")]
	downloading,
	[Description("stopped")]
	stopped,
	[Description("succeeded")]
	succeeded,
	[Description("finalized")]
	finalized
}
