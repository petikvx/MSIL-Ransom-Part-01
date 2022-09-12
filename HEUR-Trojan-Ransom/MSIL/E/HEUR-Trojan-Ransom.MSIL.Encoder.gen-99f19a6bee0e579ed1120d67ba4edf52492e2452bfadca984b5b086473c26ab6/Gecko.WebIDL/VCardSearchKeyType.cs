using System.ComponentModel;

namespace Gecko.WebIDL;

public enum VCardSearchKeyType
{
	[Description("name")]
	name,
	[Description("number")]
	number,
	[Description("sound")]
	sound
}
