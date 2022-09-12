using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RequestCache
{
	[Description("default")]
	@default,
	[Description("no-store")]
	nostore,
	[Description("reload")]
	reload,
	[Description("no-cache")]
	nocache,
	[Description("force-cache")]
	forcecache,
	[Description("only-if-cached")]
	onlyifcached
}
