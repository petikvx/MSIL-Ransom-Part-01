using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateStatusRequestItemV2
{
	private readonly short m_statusType;

	private readonly object m_request;

	public short StatusType => m_statusType;

	public object Request => m_request;

	public OcspStatusRequest OcspStatusRequest
	{
		get
		{
			if (!(m_request is OcspStatusRequest))
			{
				throw new InvalidOperationException("'request' is not an OcspStatusRequest");
			}
			return (OcspStatusRequest)m_request;
		}
	}

	public CertificateStatusRequestItemV2(short statusType, object request)
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
		MemoryStream memoryStream = new MemoryStream();
		short statusType = m_statusType;
		if ((uint)(statusType - 1) > 1u)
		{
			throw new TlsFatalAlert(80);
		}
		((OcspStatusRequest)m_request).Encode(memoryStream);
		TlsUtilities.WriteOpaque16(memoryStream.ToArray(), output);
	}

	public static CertificateStatusRequestItemV2 Parse(Stream input)
	{
		short num = TlsUtilities.ReadUint8(input);
		MemoryStream memoryStream = new MemoryStream(TlsUtilities.ReadOpaque16(input), writable: false);
		if ((uint)(num - 1) > 1u)
		{
			throw new TlsFatalAlert(50);
		}
		object request = OcspStatusRequest.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		return new CertificateStatusRequestItemV2(num, request);
	}

	private static bool IsCorrectType(short statusType, object request)
	{
		if ((uint)(statusType - 1) > 1u)
		{
			throw new ArgumentException("unsupported CertificateStatusType", "statusType");
		}
		return request is OcspStatusRequest;
	}
}
