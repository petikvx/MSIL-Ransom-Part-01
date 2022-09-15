using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateRequest
{
	private readonly byte[] m_certificateRequestContext;

	private readonly short[] m_certificateTypes;

	private readonly IList m_supportedSignatureAlgorithms;

	private readonly IList m_supportedSignatureAlgorithmsCert;

	private readonly IList m_certificateAuthorities;

	public short[] CertificateTypes => m_certificateTypes;

	public IList SupportedSignatureAlgorithms => m_supportedSignatureAlgorithms;

	public IList SupportedSignatureAlgorithmsCert => m_supportedSignatureAlgorithmsCert;

	public IList CertificateAuthorities => m_certificateAuthorities;

	private static IList CheckSupportedSignatureAlgorithms(IList supportedSignatureAlgorithms, short alertDescription)
	{
		if (supportedSignatureAlgorithms == null)
		{
			throw new TlsFatalAlert(alertDescription, "'signature_algorithms' is required");
		}
		return supportedSignatureAlgorithms;
	}

	public CertificateRequest(short[] certificateTypes, IList supportedSignatureAlgorithms, IList certificateAuthorities)
		: this(null, certificateTypes, supportedSignatureAlgorithms, null, certificateAuthorities)
	{
	}

	public CertificateRequest(byte[] certificateRequestContext, IList supportedSignatureAlgorithms, IList supportedSignatureAlgorithmsCert, IList certificateAuthorities)
		: this(certificateRequestContext, null, CheckSupportedSignatureAlgorithms(supportedSignatureAlgorithms, 80), supportedSignatureAlgorithmsCert, certificateAuthorities)
	{
	}

	private CertificateRequest(byte[] certificateRequestContext, short[] certificateTypes, IList supportedSignatureAlgorithms, IList supportedSignatureAlgorithmsCert, IList certificateAuthorities)
	{
		if (certificateRequestContext != null && !TlsUtilities.IsValidUint8(certificateRequestContext.Length))
		{
			throw new ArgumentException("cannot be longer than 255", "certificateRequestContext");
		}
		if (certificateTypes != null && (certificateTypes.Length < 1 || !TlsUtilities.IsValidUint8(certificateTypes.Length)))
		{
			throw new ArgumentException("should have length from 1 to 255", "certificateTypes");
		}
		m_certificateRequestContext = TlsUtilities.Clone(certificateRequestContext);
		m_certificateTypes = certificateTypes;
		m_supportedSignatureAlgorithms = supportedSignatureAlgorithms;
		m_supportedSignatureAlgorithmsCert = supportedSignatureAlgorithmsCert;
		m_certificateAuthorities = certificateAuthorities;
	}

	public byte[] GetCertificateRequestContext()
	{
		return TlsUtilities.Clone(m_certificateRequestContext);
	}

	public bool HasCertificateRequestContext(byte[] certificateRequestContext)
	{
		return Arrays.AreEqual(m_certificateRequestContext, certificateRequestContext);
	}

	public void Encode(TlsContext context, Stream output)
	{
		ProtocolVersion serverVersion = context.ServerVersion;
		bool flag = TlsUtilities.IsTlsV12(serverVersion);
		bool flag2;
		if ((flag2 = TlsUtilities.IsTlsV13(serverVersion)) == (m_certificateRequestContext != null) && flag2 == (m_certificateTypes == null) && flag == (m_supportedSignatureAlgorithms != null) && (flag2 || m_supportedSignatureAlgorithmsCert == null))
		{
			if (flag2)
			{
				TlsUtilities.WriteOpaque8(m_certificateRequestContext, output);
				IDictionary extensions = Platform.CreateHashtable();
				TlsExtensionsUtilities.AddSignatureAlgorithmsExtension(extensions, m_supportedSignatureAlgorithms);
				if (m_supportedSignatureAlgorithmsCert != null)
				{
					TlsExtensionsUtilities.AddSignatureAlgorithmsCertExtension(extensions, m_supportedSignatureAlgorithmsCert);
				}
				if (m_certificateAuthorities != null)
				{
					TlsExtensionsUtilities.AddCertificateAuthoritiesExtension(extensions, m_certificateAuthorities);
				}
				TlsUtilities.WriteOpaque16(TlsProtocol.WriteExtensionsData(extensions), output);
				return;
			}
			TlsUtilities.WriteUint8ArrayWithUint8Length(m_certificateTypes, output);
			if (flag)
			{
				TlsUtilities.EncodeSupportedSignatureAlgorithms(m_supportedSignatureAlgorithms, output);
			}
			if (m_certificateAuthorities != null && m_certificateAuthorities.Count >= 1)
			{
				IList list = Platform.CreateArrayList(m_certificateAuthorities.Count);
				int num = 0;
				foreach (X509Name certificateAuthority in m_certificateAuthorities)
				{
					byte[] encoded = certificateAuthority.GetEncoded("DER");
					list.Add(encoded);
					num += encoded.Length + 2;
				}
				TlsUtilities.CheckUint16(num);
				TlsUtilities.WriteUint16(num, output);
				{
					foreach (byte[] item in list)
					{
						TlsUtilities.WriteOpaque16(item, output);
					}
					return;
				}
			}
			TlsUtilities.WriteUint16(0, output);
			return;
		}
		throw new InvalidOperationException();
	}

	public static CertificateRequest Parse(TlsContext context, Stream input)
	{
		ProtocolVersion serverVersion = context.ServerVersion;
		if (TlsUtilities.IsTlsV13(serverVersion))
		{
			byte[] certificateRequestContext = TlsUtilities.ReadOpaque8(input);
			byte[] extBytes = TlsUtilities.ReadOpaque16(input);
			IDictionary extensions = TlsProtocol.ReadExtensionsData13(13, extBytes);
			IList supportedSignatureAlgorithms = CheckSupportedSignatureAlgorithms(TlsExtensionsUtilities.GetSignatureAlgorithmsExtension(extensions), 109);
			IList signatureAlgorithmsCertExtension = TlsExtensionsUtilities.GetSignatureAlgorithmsCertExtension(extensions);
			IList certificateAuthoritiesExtension = TlsExtensionsUtilities.GetCertificateAuthoritiesExtension(extensions);
			return new CertificateRequest(certificateRequestContext, supportedSignatureAlgorithms, signatureAlgorithmsCertExtension, certificateAuthoritiesExtension);
		}
		bool num = TlsUtilities.IsTlsV12(serverVersion);
		short[] certificateTypes = TlsUtilities.ReadUint8ArrayWithUint8Length(input, 1);
		IList supportedSignatureAlgorithms2 = null;
		if (num)
		{
			supportedSignatureAlgorithms2 = TlsUtilities.ParseSupportedSignatureAlgorithms(input);
		}
		IList list = null;
		byte[] array = TlsUtilities.ReadOpaque16(input);
		if (array.Length != 0)
		{
			list = Platform.CreateArrayList();
			MemoryStream memoryStream = new MemoryStream(array, writable: false);
			do
			{
				Asn1Object obj = TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque16(memoryStream, 1));
				list.Add(X509Name.GetInstance(obj));
			}
			while (memoryStream.Position < memoryStream.Length);
		}
		return new CertificateRequest(certificateTypes, supportedSignatureAlgorithms2, list);
	}
}
