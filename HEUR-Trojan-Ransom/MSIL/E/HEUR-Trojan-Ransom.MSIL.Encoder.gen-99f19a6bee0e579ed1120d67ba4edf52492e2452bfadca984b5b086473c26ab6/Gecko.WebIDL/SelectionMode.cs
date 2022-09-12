using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SelectionMode
{
	[Description("select")]
	select,
	[Description("start")]
	start,
	[Description("end")]
	end,
	[Description("preserve")]
	preserve
}
