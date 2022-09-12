using Ubiety.Dns.Core.Records;
using Ubiety.Dns.Core.Records.General;
using Ubiety.Dns.Core.Records.Mail;
using Ubiety.Dns.Core.Records.NotUsed;
using Ubiety.Dns.Core.Records.Obsolete;

namespace Ubiety.Dns.Core.Common;

public enum RecordType
{
	[Record(typeof(RecordA))]
	A = 1,
	[Record(typeof(RecordNs))]
	NS = 2,
	[Record(typeof(RecordMd))]
	MD = 3,
	[Record(typeof(RecordMf))]
	MF = 4,
	[Record(typeof(RecordCname))]
	CNAME = 5,
	[Record(typeof(RecordSoa))]
	SOA = 6,
	[Record(typeof(RecordMb))]
	MB = 7,
	[Record(typeof(RecordMg))]
	MG = 8,
	[Record(typeof(RecordMr))]
	MR = 9,
	[Record(typeof(RecordNull))]
	NULL = 10,
	[Record(typeof(RecordWks))]
	WKS = 11,
	[Record(typeof(RecordPtr))]
	PNTR = 12,
	[Record(typeof(RecordHinfo))]
	HINFO = 13,
	[Record(typeof(RecordMinfo))]
	MINFO = 14,
	[Record(typeof(RecordMx))]
	MX = 15,
	[Record(typeof(RecordTxt))]
	TXT = 16,
	[Record(typeof(RecordRp))]
	RP = 17,
	[Record(typeof(RecordAfsdb))]
	AFSDB = 18,
	[Record(typeof(RecordX25))]
	X25 = 19,
	[Record(typeof(RecordIsdn))]
	ISDN = 20,
	[Record(typeof(RecordRt))]
	RT = 21,
	[Record(typeof(RecordNsap))]
	NSAP = 22,
	[Record(typeof(RecordNsapPtr))]
	NSAPPTR = 23,
	[Record(typeof(RecordSig))]
	SIG = 24,
	[Record(typeof(RecordKey))]
	KEY = 25,
	[Record(typeof(RecordPx))]
	PX = 26,
	[Record(typeof(RecordGpos))]
	GPOS = 27,
	[Record(typeof(RecordAaaa))]
	AAAA = 28,
	[Record(typeof(RecordLoc))]
	LOC = 29,
	[Record(typeof(RecordNxt))]
	NXT = 30,
	[Record(typeof(RecordEid))]
	EID = 31,
	[Record(typeof(RecordNimloc))]
	NIMLOC = 32,
	[Record(typeof(RecordSrv))]
	SRV = 33,
	[Record(typeof(RecordAtma))]
	ATMA = 34,
	[Record(typeof(RecordNaptr))]
	NAPTR = 35,
	[Record(typeof(RecordKx))]
	KX = 36,
	[Record(typeof(RecordCert))]
	CERT = 37,
	[Record(typeof(RecordA6))]
	A6 = 38,
	[Record(typeof(RecordDname))]
	DNAME = 39,
	[Record(typeof(RecordSink))]
	SINK = 40,
	[Record(typeof(RecordOpt))]
	OPT = 41,
	[Record(typeof(RecordApl))]
	APL = 42,
	[Record(typeof(RecordDs))]
	DS = 43,
	[Record(typeof(RecordSshfp))]
	SSHFP = 44,
	[Record(typeof(RecordIpsecKey))]
	IPSECKEY = 45,
	[Record(typeof(RecordRrsig))]
	RRSIG = 46,
	[Record(typeof(RecordNsec))]
	NSEC = 47,
	[Record(typeof(RecordDnsKey))]
	DNSKEY = 48,
	[Record(typeof(RecordDhcid))]
	DHCID = 49,
	[Record(typeof(RecordNsec3))]
	NSEC3 = 50,
	[Record(typeof(RecordNsec3Param))]
	NSEC3PARAM = 51,
	[Record(typeof(RecordHip))]
	HIP = 55,
	[Record(typeof(RecordSpf))]
	SPF = 99,
	[Record(typeof(RecordUinfo))]
	UINFO = 100,
	[Record(typeof(RecordUid))]
	UID = 101,
	[Record(typeof(RecordGid))]
	GID = 102,
	[Record(typeof(RecordUnspec))]
	UNSPEC = 103,
	[Record(typeof(RecordTkey))]
	TKEY = 249,
	[Record(typeof(RecordTsig))]
	TSIG = 250,
	[Record(typeof(RecordUnknown))]
	TA = 32768,
	[Record(typeof(RecordUnknown))]
	DLV = 32769
}
