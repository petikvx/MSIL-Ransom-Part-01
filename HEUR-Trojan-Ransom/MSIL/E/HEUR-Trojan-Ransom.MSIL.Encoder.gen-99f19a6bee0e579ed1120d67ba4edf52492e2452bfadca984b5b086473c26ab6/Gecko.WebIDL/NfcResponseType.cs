using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NfcResponseType
{
	[Description("changeRFStateRsp")]
	changeRFStateRsp,
	[Description("readNDEFRsp")]
	readNDEFRsp,
	[Description("writeNDEFRsp")]
	writeNDEFRsp,
	[Description("makeReadOnlyRsp")]
	makeReadOnlyRsp,
	[Description("formatRsp")]
	formatRsp,
	[Description("transceiveRsp")]
	transceiveRsp
}
