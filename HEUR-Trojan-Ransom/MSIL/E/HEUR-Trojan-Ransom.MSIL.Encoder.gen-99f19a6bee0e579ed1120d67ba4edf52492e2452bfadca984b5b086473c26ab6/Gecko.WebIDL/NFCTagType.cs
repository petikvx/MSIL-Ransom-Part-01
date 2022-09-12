using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NFCTagType
{
	[Description("Type1")]
	Type1,
	[Description("Type2")]
	Type2,
	[Description("Type3")]
	Type3,
	[Description("Type4")]
	Type4,
	[Description("MIFARE-Classic")]
	MIFAREClassic
}
