using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class Certificate
{
	public sealed class ParseOptions
	{
		private int m_maxChainLength = int.MaxValue;

		public int MaxChainLength => m_maxChainLength;

		public ParseOptions SetMaxChainLength(int maxChainLength)
		{
			m_maxChainLength = maxChainLength;
			return this;
		}
	}

	private static readonly TlsCertificate[] EmptyCerts = new TlsCertificate[0];

	private static readonly CertificateEntry[] EmptyCertEntries = new CertificateEntry[0];

	public static readonly Certificate EmptyChain = new Certificate(EmptyCerts);

	public static readonly Certificate EmptyChainTls13 = new Certificate(TlsUtilities.EmptyBytes, EmptyCertEntries);

	private readonly byte[] m_certificateRequestContext;

	private readonly CertificateEntry[] m_certificateEntryList;

	public short CertificateType => 0;

	public int Length => m_certificateEntryList.Length;

	public bool IsEmpty => m_certificateEntryList.Length == 0;

	private static CertificateEntry[] Convert(TlsCertificate[] certificateList)
	{
		if (TlsUtilities.IsNullOrContainsNull(certificateList))
		{
			throw new ArgumentException("cannot be null or contain any nulls", "certificateList");
		}
		int num = certificateList.Length;
		CertificateEntry[] array = new CertificateEntry[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = new CertificateEntry(certificateList[i], null);
		}
		return array;
	}

	public Certificate(TlsCertificate[] certificateList)
		: this(null, Convert(certificateList))
	{
	}

	public Certificate(byte[] certificateRequestContext, CertificateEntry[] certificateEntryList)
	{
		if (certificateRequestContext != null && !TlsUtilities.IsValidUint8(certificateRequestContext.Length))
		{
			throw new ArgumentException("cannot be longer than 255", "certificateRequestContext");
		}
		if (TlsUtilities.IsNullOrContainsNull(certificateEntryList))
		{
			throw new ArgumentException("cannot be null or contain any nulls", "certificateEntryList");
		}
		m_certificateRequestContext = TlsUtilities.Clone(certificateRequestContext);
		m_certificateEntryList = certificateEntryList;
	}

	public byte[] GetCertificateRequestContext()
	{
		return TlsUtilities.Clone(m_certificateRequestContext);
	}

	public TlsCertificate[] GetCertificateList()
	{
		return CloneCertificateList();
	}

	public TlsCertificate GetCertificateAt(int index)
	{
		return m_certificateEntryList[index].Certificate;
	}

	public CertificateEntry GetCertificateEntryAt(int index)
	{
		return m_certificateEntryList[index];
	}

	public CertificateEntry[] GetCertificateEntryList()
	{
		return CloneCertificateEntryList();
	}

	public void Encode(TlsContext context, Stream messageOutput, Stream endPointHashOutput)
	{
		bool flag = TlsUtilities.IsTlsV13(context);
		if (m_certificateRequestContext != null != flag)
		{
			throw new InvalidOperationException();
		}
		if (flag)
		{
			TlsUtilities.WriteOpaque8(m_certificateRequestContext, messageOutput);
		}
		int num = m_certificateEntryList.Length;
		IList list = Platform.CreateArrayList(num);
		IList list2 = (flag ? Platform.CreateArrayList(num) : null);
		long num2 = 0L;
		for (int i = 0; i < num; i++)
		{
			CertificateEntry certificateEntry = m_certificateEntryList[i];
			TlsCertificate certificate = certificateEntry.Certificate;
			byte[] encoded = certificate.GetEncoded();
			if (i == 0 && endPointHashOutput != null)
			{
				CalculateEndPointHash(context, certificate, encoded, endPointHashOutput);
			}
			list.Add(encoded);
			num2 += encoded.Length;
			num2 += 3L;
			if (flag)
			{
				IDictionary extensions = certificateEntry.Extensions;
				byte[] array = ((extensions == null) ? TlsUtilities.EmptyBytes : TlsProtocol.WriteExtensionsData(extensions));
				list2.Add(array);
				num2 += array.Length;
				num2 += 2L;
			}
		}
		TlsUtilities.CheckUint24(num2);
		TlsUtilities.WriteUint24((int)num2, messageOutput);
		for (int j = 0; j < num; j++)
		{
			TlsUtilities.WriteOpaque24((byte[])list[j], messageOutput);
			if (flag)
			{
				TlsUtilities.WriteOpaque16((byte[])list2[j], messageOutput);
			}
		}
	}

	public static Certificate Parse(ParseOptions options, TlsContext context, Stream messageInput, Stream endPointHashOutput)
	{
		bool flag = TlsUtilities.IsTlsV13(context.SecurityParameters.NegotiatedVersion);
		byte[] array = null;
		if (flag)
		{
			array = TlsUtilities.ReadOpaque8(messageInput);
		}
		int num = TlsUtilities.ReadUint24(messageInput);
		if (num == 0)
		{
			if (flag)
			{
				if (array.Length >= 1)
				{
					return new Certificate(array, EmptyCertEntries);
				}
				return EmptyChainTls13;
			}
			return EmptyChain;
		}
		MemoryStream memoryStream = new MemoryStream(TlsUtilities.ReadFully(num, messageInput), writable: false);
		TlsCrypto crypto = context.Crypto;
		int num2 = System.Math.Max(1, options.MaxChainLength);
		IList list = Platform.CreateArrayList();
		CertificateEntry[] array2;
		while (true)
		{
			if (memoryStream.Position < memoryStream.Length)
			{
				if (list.Count < num2)
				{
					byte[] encoding = TlsUtilities.ReadOpaque24(memoryStream, 1);
					TlsCertificate tlsCertificate = crypto.CreateCertificate(encoding);
					if (list.Count < 1 && endPointHashOutput != null)
					{
						CalculateEndPointHash(context, tlsCertificate, encoding, endPointHashOutput);
					}
					IDictionary extensions = null;
					if (flag)
					{
						byte[] extBytes = TlsUtilities.ReadOpaque16(memoryStream);
						extensions = TlsProtocol.ReadExtensionsData13(11, extBytes);
					}
					list.Add(new CertificateEntry(tlsCertificate, extensions));
					continue;
				}
				throw new TlsFatalAlert(80, "Certificate chain longer than maximum (" + num2 + ")");
			}
			array2 = new CertificateEntry[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array2[i] = (CertificateEntry)list[i];
			}
			break;
		}
		return new Certificate(array, array2);
	}

	private static void CalculateEndPointHash(TlsContext context, TlsCertificate cert, byte[] encoding, Stream output)
	{
		byte[] array = TlsUtilities.CalculateEndPointHash(context, cert, encoding);
		if (array != null && array.Length != 0)
		{
			output.Write(array, 0, array.Length);
		}
	}

	private TlsCertificate[] CloneCertificateList()
	{
		int num = m_certificateEntryList.Length;
		if (num == 0)
		{
			return EmptyCerts;
		}
		TlsCertificate[] array = new TlsCertificate[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = m_certificateEntryList[i].Certificate;
		}
		return array;
	}

	private CertificateEntry[] CloneCertificateEntryList()
	{
		int num = m_certificateEntryList.Length;
		if (num == 0)
		{
			return EmptyCertEntries;
		}
		CertificateEntry[] array = new CertificateEntry[num];
		Array.Copy(m_certificateEntryList, 0, array, 0, num);
		return array;
	}
}
