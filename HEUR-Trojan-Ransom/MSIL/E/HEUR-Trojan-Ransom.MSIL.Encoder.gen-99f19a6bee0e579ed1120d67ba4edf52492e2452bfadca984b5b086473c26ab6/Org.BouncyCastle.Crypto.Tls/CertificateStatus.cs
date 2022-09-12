using System;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Org.BouncyCastle.Crypto.Tls;

public class CertificateStatus
{
	protected readonly byte mStatusType;

	protected readonly object mResponse;

	public virtual byte StatusType => mStatusType;

	public virtual object Response => mResponse;

	public CertificateStatus(byte statusType, object response)
	{
		if (!IsCorrectType(statusType, response))
		{
			throw new ArgumentException("not an instance of the correct type", "response");
		}
		mStatusType = statusType;
		mResponse = response;
	}

	public virtual OcspResponse GetOcspResponse()
	{
		if (!IsCorrectType(1, mResponse))
		{
			throw new InvalidOperationException("'response' is not an OcspResponse");
		}
		return (OcspResponse)mResponse;
	}

	public virtual void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(mStatusType, output);
		byte b = mStatusType;
		if (b != 1)
		{
			throw new TlsFatalAlert(80);
		}
		byte[] encoded = ((OcspResponse)mResponse).GetEncoded("DER");
		TlsUtilities.WriteOpaque24(encoded, output);
	}

	public static CertificateStatus Parse(Stream input)
	{
		byte b = TlsUtilities.ReadUint8(input);
		byte b2 = b;
		if (b2 != 1)
		{
			throw new TlsFatalAlert(50);
		}
		byte[] encoding = TlsUtilities.ReadOpaque24(input);
		object instance = OcspResponse.GetInstance(TlsUtilities.ReadDerObject(encoding));
		return new CertificateStatus(b, instance);
	}

	protected static bool IsCorrectType(byte statusType, object response)
	{
		byte b = statusType;
		if (b != 1)
		{
			throw new ArgumentException("unsupported value", "statusType");
		}
		return response is OcspResponse;
	}
}
