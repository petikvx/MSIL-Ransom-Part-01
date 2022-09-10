using System.Collections.Generic;
using System.Security.Cryptography;

namespace Microsoft.InfoCards;

internal sealed class X509AudioLogo : X509Logo
{
	public X509AudioLogo(X509LogoType logoType, string mediaType, Dictionary<Oid, byte[]> hashes, List<string> fileLocations)
		: base(logoType, mediaType, hashes, fileLocations)
	{
	}
}
