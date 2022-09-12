using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CSSBoxType
{
	[Description("margin")]
	margin,
	[Description("border")]
	border,
	[Description("padding")]
	padding,
	[Description("content")]
	content
}
