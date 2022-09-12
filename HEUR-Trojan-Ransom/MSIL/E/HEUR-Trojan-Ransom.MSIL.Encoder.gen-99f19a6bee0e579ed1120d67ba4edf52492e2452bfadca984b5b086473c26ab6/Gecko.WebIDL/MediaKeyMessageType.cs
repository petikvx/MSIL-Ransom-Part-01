using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MediaKeyMessageType
{
	[Description("license-request")]
	licenserequest,
	[Description("license-renewal")]
	licenserenewal,
	[Description("license-release")]
	licenserelease,
	[Description("individualization-request")]
	individualizationrequest
}
