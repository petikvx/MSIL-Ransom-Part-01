using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateStatus
{
	private readonly short m_statusType;

	private readonly object m_response;

	public short StatusType => m_statusType;

	public object Response => m_response;

	public OcspResponse OcspResponse
	{
		get
		{
			if (!IsCorrectType(1, m_response))
			{
				throw new InvalidOperationException("'response' is not an OCSPResponse");
			}
			return (OcspResponse)m_response;
		}
	}

	public IList OcspResponseList
	{
		get
		{
			if (!IsCorrectType(2, m_response))
			{
				throw new InvalidOperationException("'response' is not an OCSPResponseList");
			}
			return (IList)m_response;
		}
	}

	public CertificateStatus(short statusType, object response)
	{
		if (!IsCorrectType(statusType, response))
		{
			throw new ArgumentException("not an instance of the correct type", "response");
		}
		m_statusType = statusType;
		m_response = response;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(m_statusType, output);
		switch (m_statusType)
		{
		default:
			throw new TlsFatalAlert(80);
		case 2:
		{
			IList obj = (IList)m_response;
			IList list = Platform.CreateArrayList(obj.Count);
			long num = 0L;
			foreach (OcspResponse item in obj)
			{
				if (item == null)
				{
					list.Add(TlsUtilities.EmptyBytes);
				}
				else
				{
					byte[] encoded = item.GetEncoded("DER");
					list.Add(encoded);
					num += encoded.Length;
				}
				num += 3L;
			}
			TlsUtilities.CheckUint24(num);
			TlsUtilities.WriteUint24((int)num, output);
			{
				foreach (byte[] item2 in list)
				{
					TlsUtilities.WriteOpaque24(item2, output);
				}
				break;
			}
		}
		case 1:
			TlsUtilities.WriteOpaque24(((OcspResponse)m_response).GetEncoded("DER"), output);
			break;
		}
	}

	public static CertificateStatus Parse(TlsContext context, Stream input)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		Certificate peerCertificate = securityParameters.PeerCertificate;
		if (peerCertificate != null && !peerCertificate.IsEmpty && peerCertificate.CertificateType == 0)
		{
			int length = peerCertificate.Length;
			int statusRequestVersion = securityParameters.StatusRequestVersion;
			short num = TlsUtilities.ReadUint8(input);
			object response;
			switch (num)
			{
			default:
				throw new TlsFatalAlert(50);
			case 2:
			{
				RequireStatusRequestVersion(2, statusRequestVersion);
				MemoryStream memoryStream = new MemoryStream(TlsUtilities.ReadOpaque24(input, 1), writable: false);
				IList list = Platform.CreateArrayList();
				while (memoryStream.Position < memoryStream.Length)
				{
					if (list.Count < length)
					{
						int num2 = TlsUtilities.ReadUint24(memoryStream);
						if (num2 < 1)
						{
							list.Add(null);
							continue;
						}
						OcspResponse instance = OcspResponse.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadFully(num2, memoryStream)));
						list.Add(instance);
						continue;
					}
					throw new TlsFatalAlert(47);
				}
				response = Platform.CreateArrayList(list);
				break;
			}
			case 1:
				RequireStatusRequestVersion(1, statusRequestVersion);
				response = OcspResponse.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque24(input, 1)));
				break;
			}
			return new CertificateStatus(num, response);
		}
		throw new TlsFatalAlert(80);
	}

	private static bool IsCorrectType(short statusType, object response)
	{
		return statusType switch
		{
			2 => IsOcspResponseList(response), 
			1 => response is OcspResponse, 
			_ => throw new ArgumentException("unsupported CertificateStatusType", "statusType"), 
		};
	}

	private static bool IsOcspResponseList(object response)
	{
		if (!(response is IList))
		{
			return false;
		}
		IList list = (IList)response;
		if (list.Count < 1)
		{
			return false;
		}
		foreach (object item in list)
		{
			if (item != null && !(item is OcspResponse))
			{
				return false;
			}
		}
		return true;
	}

	private static void RequireStatusRequestVersion(int minVersion, int statusRequestVersion)
	{
		if (statusRequestVersion < minVersion)
		{
			throw new TlsFatalAlert(50);
		}
	}
}
