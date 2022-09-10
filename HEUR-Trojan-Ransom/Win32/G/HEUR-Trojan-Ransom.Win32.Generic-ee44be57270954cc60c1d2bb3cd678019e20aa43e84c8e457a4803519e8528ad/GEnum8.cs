using System;

[Flags]
public enum GEnum8 : ushort
{
	NoError = 0,
	FormatError = 1,
	ServerFailure = 2,
	NameError = 3,
	NotImplemented = 4,
	Refused = 5,
	YXDomain = 6,
	YXRRSet = 7,
	NXRRSet = 8,
	NotAuth = 9,
	NotZone = 0xA,
	BADVERS_BADSIG = 0x10,
	BADKEY = 0x11,
	BADTIME = 0x12,
	BADMODE = 0x13,
	BADNAME = 0x14,
	BADALG = 0x15
}
