using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CompositionClauseSelectionType
{
	[Description("raw-input")]
	rawinput,
	[Description("selected-raw-text")]
	selectedrawtext,
	[Description("converted-text")]
	convertedtext,
	[Description("selected-converted-text")]
	selectedconvertedtext
}
