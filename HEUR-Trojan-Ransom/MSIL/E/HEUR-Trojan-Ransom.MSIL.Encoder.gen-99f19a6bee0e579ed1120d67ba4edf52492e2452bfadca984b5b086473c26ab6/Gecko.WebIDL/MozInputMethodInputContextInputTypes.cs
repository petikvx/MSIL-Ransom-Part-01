using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MozInputMethodInputContextInputTypes
{
	[Description("text")]
	text,
	[Description("search")]
	search,
	[Description("textarea")]
	textarea,
	[Description("number")]
	number,
	[Description("tel")]
	tel,
	[Description("url")]
	url,
	[Description("email")]
	email,
	[Description("password")]
	password,
	[Description("datetime")]
	datetime,
	[Description("date")]
	date,
	[Description("month")]
	month,
	[Description("week")]
	week,
	[Description("time")]
	time,
	[Description("datetime-local")]
	datetimelocal,
	[Description("color")]
	color,
	[Description("select-one")]
	selectone,
	[Description("select-multiple")]
	selectmultiple
}
