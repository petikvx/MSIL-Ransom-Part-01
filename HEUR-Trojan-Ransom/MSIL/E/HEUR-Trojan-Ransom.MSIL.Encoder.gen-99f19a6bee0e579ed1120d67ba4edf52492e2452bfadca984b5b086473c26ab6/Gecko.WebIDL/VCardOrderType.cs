using System.ComponentModel;

namespace Gecko.WebIDL;

public enum VCardOrderType
{
	[Description("indexed")]
	indexed,
	[Description("alphabetical")]
	alphabetical,
	[Description("phonetical")]
	phonetical
}
