using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

internal class DigestInputBuffer : MemoryStream
{
	internal void UpdateDigest(TlsHash hash)
	{
		Streams.WriteBufTo(this, new TlsHashSink(hash));
	}

	internal new void CopyTo(Stream output)
	{
		Streams.WriteBufTo(this, output);
	}
}
