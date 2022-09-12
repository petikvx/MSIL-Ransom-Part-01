using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCSdpType
{
	[Description("offer")]
	offer,
	[Description("pranswer")]
	pranswer,
	[Description("answer")]
	answer,
	[Description("rollback")]
	rollback
}
