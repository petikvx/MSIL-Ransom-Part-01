using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CellBroadcastGsmGeographicalScope
{
	[Description("cell-immediate")]
	cellimmediate,
	[Description("plmn")]
	plmn,
	[Description("location-area")]
	locationarea,
	[Description("cell")]
	cell
}
