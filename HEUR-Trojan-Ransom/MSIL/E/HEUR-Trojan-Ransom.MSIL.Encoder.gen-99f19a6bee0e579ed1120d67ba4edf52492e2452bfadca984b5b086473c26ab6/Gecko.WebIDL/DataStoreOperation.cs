using System.ComponentModel;

namespace Gecko.WebIDL;

public enum DataStoreOperation
{
	[Description("add")]
	add,
	[Description("update")]
	update,
	[Description("remove")]
	remove,
	[Description("clear")]
	clear,
	[Description("done")]
	done
}
