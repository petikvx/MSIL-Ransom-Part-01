using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MozInputMethodInputContextTypes
{
	[Description("input")]
	input,
	[Description("textarea")]
	textarea,
	[Description("contenteditable")]
	contenteditable,
	[Description("select")]
	select
}
