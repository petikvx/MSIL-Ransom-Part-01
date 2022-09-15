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
		if (mStatusType != 1)
		{
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.WriteOpaque24(((OcspResponse)mResponse).GetEncoded("DER"), output);
	}

	public static CertificateStatus Parse(Stream input)
	{
		byte num = TlsUtilities.ReadUint8(input);
		if (num != 1)
		{
			throw new TlsFatalAlert(50);
		}
		object instance = OcspResponse.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque24(input)));
		return new CertificateStatus(num, instance);
	}

	protected static bool IsCorrectType(byte statusType, object response)
	{
		if (statusType != 1)
		{
			throw new ArgumentException("unsupported CertificateStatusType", "statusType");
		}
		return response is OcspResponse;
	}
}
