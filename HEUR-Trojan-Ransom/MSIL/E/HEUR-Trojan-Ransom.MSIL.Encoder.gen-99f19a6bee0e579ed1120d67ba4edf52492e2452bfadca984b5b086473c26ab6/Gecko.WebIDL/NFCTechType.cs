using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NFCTechType
{
	[Description("NFC-A")]
	NFCA,
	[Description("NFC-B")]
	NFCB,
	[Description("NFC-F")]
	NFCF,
	[Description("NFC-V")]
	NFCV,
	[Description("ISO-DEP")]
	ISODEP,
	[Description("MIFARE-Classic")]
	MIFAREClassic,
	[Description("MIFARE-Ultralight")]
	MIFAREUltralight,
	[Description("NFC-Barcode")]
	NFCBarcode,
	[Description("Unknown")]
	Unknown
}
