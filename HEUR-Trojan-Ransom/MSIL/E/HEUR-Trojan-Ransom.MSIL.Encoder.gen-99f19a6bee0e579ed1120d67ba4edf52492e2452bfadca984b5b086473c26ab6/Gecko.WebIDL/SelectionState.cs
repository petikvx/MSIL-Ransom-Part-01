using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SelectionState
{
	[Description("drag")]
	drag,
	[Description("mousedown")]
	mousedown,
	[Description("mouseup")]
	mouseup,
	[Description("keypress")]
	keypress,
	[Description("selectall")]
	selectall,
	[Description("collapsetostart")]
	collapsetostart,
	[Description("collapsetoend")]
	collapsetoend,
	[Description("blur")]
	blur,
	[Description("updateposition")]
	updateposition,
	[Description("taponcaret")]
	taponcaret
}
