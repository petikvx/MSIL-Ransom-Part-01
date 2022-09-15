using System.ComponentModel;

namespace Gecko.WebIDL;

public enum WellKnownURIPrefix
{
	[Description("http://www.")]
	httpwww,
	[Description("https://www.")]
	httpswww,
	[Description("http://")]
	http,
	[Description("https://")]
	https,
	[Description("tel:")]
	tel,
	[Description("mailto:")]
	mailto,
	[Description("ftp://anonymous:anonymous@")]
	ftpanonymousanonymous,
	[Description("ftp://ftp.")]
	ftpftp,
	[Description("ftps://")]
	ftps,
	[Description("sftp://")]
	sftp,
	[Description("smb://")]
	smb,
	[Description("nfs://")]
	nfs,
	[Description("ftp://")]
	ftp,
	[Description("dav://")]
	dav,
	[Description("news:")]
	news,
	[Description("telnet://")]
	telnet,
	[Description("imap:")]
	imap,
	[Description("rtsp://")]
	rtsp,
	[Description("urn:")]
	urn,
	[Description("pop:")]
	pop,
	[Description("sip:")]
	sip,
	[Description("sips:")]
	sips,
	[Description("tftp:")]
	tftp,
	[Description("btspp://")]
	btspp,
	[Description("btl2cap://")]
	btl2cap,
	[Description("btgoep://")]
	btgoep,
	[Description("tcpobex://")]
	tcpobex,
	[Description("irdaobex://")]
	irdaobex,
	[Description("file://")]
	file,
	[Description("urn:epc:id:")]
	urnepcid,
	[Description("urn:epc:tag:")]
	urnepctag,
	[Description("urn:epc:pat:")]
	urnepcpat,
	[Description("urn:epc:raw:")]
	urnepcraw,
	[Description("urn:epc:")]
	urnepc,
	[Description("urn:nfc:")]
	urnnfc
}