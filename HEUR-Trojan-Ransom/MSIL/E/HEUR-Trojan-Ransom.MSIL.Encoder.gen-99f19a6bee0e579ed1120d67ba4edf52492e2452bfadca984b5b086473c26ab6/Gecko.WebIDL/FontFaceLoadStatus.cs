using System.ComponentModel;

namespace Gecko.WebIDL;

public enum FontFaceLoadStatus
{
	[Description("unloaded")]
	unloaded,
	[Description("loading")]
	loading,
	[Description("loaded")]
	loaded,
	[Description("error")]
	error
}
