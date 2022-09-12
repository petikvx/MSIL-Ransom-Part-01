namespace Ubiety.Dns.Core.Common;

public enum ResponseCode
{
	NoError,
	FormErr,
	ServFail,
	NXDomain,
	NotImp,
	Refused,
	YXDomain,
	YXRRSet,
	NXRRSet,
	NotAuth,
	NotZone,
	RESERVED11,
	RESERVED12,
	RESERVED13,
	RESERVED14,
	RESERVED15,
	BADVERSSIG,
	BADKEY,
	BADTIME,
	BADMODE,
	BADNAME,
	BADALG,
	BADTRUNC
}
