using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class DigitallySigned
{
	private readonly SignatureAndHashAlgorithm algorithm;

	private readonly byte[] signature;

	public SignatureAndHashAlgorithm Algorithm => algorithm;

	public byte[] Signature => signature;

	public DigitallySigned(SignatureAndHashAlgorithm algorithm, byte[] signature)
	{
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		this.algorithm = algorithm;
		this.signature = signature;
	}

	public void Encode(Stream output)
	{
		if (algorithm != null)
		{
			algorithm.Encode(output);
		}
		TlsUtilities.WriteOpaque16(signature, output);
	}

	public static DigitallySigned Parse(TlsContext context, Stream input)
	{
		SignatureAndHashAlgorithm signatureAndHashAlgorithm = null;
		if (TlsUtilities.IsTlsV12(context))
		{
			signatureAndHashAlgorithm = SignatureAndHashAlgorithm.Parse(input);
			if (signatureAndHashAlgorithm.Signature == 0)
			{
				throw new TlsFatalAlert(47);
			}
		}
		byte[] array = TlsUtilities.ReadOpaque16(input);
		return new DigitallySigned(signatureAndHashAlgorithm, array);
	}
}
