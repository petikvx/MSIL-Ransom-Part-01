using System.ComponentModel;

namespace Gecko.WebIDL;

public enum IDBRequestReadyState
{
	[Description("pending")]
	pending,
	[Description("done")]
	done
}
