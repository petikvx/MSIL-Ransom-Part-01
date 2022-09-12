using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ServiceWorkerState
{
	[Description("installing")]
	installing,
	[Description("installed")]
	installed,
	[Description("activating")]
	activating,
	[Description("activated")]
	activated,
	[Description("redundant")]
	redundant
}
