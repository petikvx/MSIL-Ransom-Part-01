using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsStreamVerifier : TlsStreamVerifier
{
	private readonly SignerSink m_output;

	private readonly byte[] m_signature;

	internal BcTlsStreamVerifier(ISigner verifier, byte[] signature)
	{
		m_output = new SignerSink(verifier);
		m_signature = signature;
	}

	public Stream GetOutputStream()
	{
		return m_output;
	}

	public bool IsVerified()
	{
		return m_output.Signer.VerifySignature(m_signature);
	}
}
