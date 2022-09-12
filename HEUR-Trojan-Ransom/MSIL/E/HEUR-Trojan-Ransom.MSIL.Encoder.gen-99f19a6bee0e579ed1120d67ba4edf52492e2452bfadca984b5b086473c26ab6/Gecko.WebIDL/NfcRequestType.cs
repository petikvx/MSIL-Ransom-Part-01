using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NfcRequestType
{
	[Description("changeRFState")]
	changeRFState,
	[Description("readNDEF")]
	readNDEF,
	[Description("writeNDEF")]
	writeNDEF,
	[Description("makeReadOnly")]
	makeReadOnly,
	[Description("format")]
	format,
	[Description("transceive")]
	transceive
}
