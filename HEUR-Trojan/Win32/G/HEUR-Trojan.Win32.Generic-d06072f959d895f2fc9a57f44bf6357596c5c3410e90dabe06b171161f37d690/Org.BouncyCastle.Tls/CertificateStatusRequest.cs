using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateStatusRequest
{
	private short m_statusType;

	private object m_request;

	public short StatusType => m_statusType;

	public object Request => m_request;

	public OcspStatusRequest OcspStatusRequest
	{
		get
		{
			if (!IsCorrectType(1, m_request))
			{
				throw new InvalidOperationException("'request' is not an OCSPStatusRequest");
			}
			return (OcspStatusRequest)m_request;
		}
	}

	public CertificateStatusRequest(short statusType, object request)
	{
		if (!IsCorrectType(statusType, request))
		{
			throw new ArgumentException("not an instance of the correct type", "request");
		}
		m_statusType = statusType;
		m_request = request;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(m_statusType, output);
		if (m_statusType != 1)
		{
			throw new TlsFatalAlert(80);
		}
		((OcspStatusRequest)m_request).Encode(output);
	}

	public static CertificateStatusRequest Parse(Stream input)
	{
		short num = TlsUtilities.ReadUint8(input);
		if (num != 1)
		{
			throw new TlsFatalAlert(50);
		}
		object request = OcspStatusRequest.Parse(input);
		return new CertificateStatusRequest(num, request);
	}

	private static bool IsCorrectType(short statusType, object request)
	{
		if (statusType != 1)
		{
			throw new ArgumentException("unsupported CertificateStatusType", "statusType");
		}
		return request is OcspStatusRequest;
	}
}
