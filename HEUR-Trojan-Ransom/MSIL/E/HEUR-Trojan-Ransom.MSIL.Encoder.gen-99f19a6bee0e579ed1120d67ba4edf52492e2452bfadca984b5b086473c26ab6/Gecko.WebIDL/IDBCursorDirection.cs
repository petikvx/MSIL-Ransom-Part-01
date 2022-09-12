using System.ComponentModel;

namespace Gecko.WebIDL;

public enum IDBCursorDirection
{
	[Description("next")]
	next,
	[Description("nextunique")]
	nextunique,
	[Description("prev")]
	prev,
	[Description("prevunique")]
	prevunique
}
