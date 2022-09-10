using System.Collections.Generic;
using System.Security.Cryptography;

namespace Microsoft.InfoCards;

internal sealed class X509ImageLogo : X509Logo
{
	public X509ImageLogo(X509LogoType logoType, string mediaType, Dictionary<Oid, byte[]> hashes, List<string> fileLocations)
		: base(logoType, mediaType, hashes, fileLocations)
	{
	}
}
