using System.ComponentModel;

namespace Gecko.WebIDL;

public enum BrowserFindCaseSensitivity
{
	[Description("case-sensitive")]
	casesensitive,
	[Description("case-insensitive")]
	caseinsensitive
}
