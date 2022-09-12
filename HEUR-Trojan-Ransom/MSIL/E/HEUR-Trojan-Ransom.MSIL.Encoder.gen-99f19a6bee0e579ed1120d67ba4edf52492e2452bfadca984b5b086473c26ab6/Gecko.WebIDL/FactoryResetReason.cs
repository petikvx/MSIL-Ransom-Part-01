using System.ComponentModel;

namespace Gecko.WebIDL;

public enum FactoryResetReason
{
	[Description("normal")]
	normal,
	[Description("wipe")]
	wipe,
	[Description("root")]
	root
}
