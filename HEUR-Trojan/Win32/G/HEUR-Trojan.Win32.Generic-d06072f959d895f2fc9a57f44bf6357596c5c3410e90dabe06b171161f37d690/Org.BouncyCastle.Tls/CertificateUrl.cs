using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateUrl
{
	internal class ListBuffer16 : MemoryStream
	{
		internal ListBuffer16()
		{
			TlsUtilities.WriteUint16(0, this);
		}

		internal void EncodeTo(Stream output)
		{
			int i = (int)Length - 2;
			TlsUtilities.CheckUint16(i);
			Seek(0L, SeekOrigin.Begin);
			TlsUtilities.WriteUint16(i, this);
			Streams.WriteBufTo(this, output);
			Platform.Dispose(this);
		}
	}

	private readonly short m_type;

	private readonly IList m_urlAndHashList;

	public short Type => m_type;

	public IList UrlAndHashList => m_urlAndHashList;

	public CertificateUrl(short type, IList urlAndHashList)
	{
		if (!CertChainType.IsValid(type))
		{
			throw new ArgumentException("not a valid CertChainType value", "type");
		}
		if (urlAndHashList != null && urlAndHashList.Count >= 1)
		{
			if (type == 1 && urlAndHashList.Count != 1)
			{
				throw new ArgumentException("must contain exactly one entry when type is " + CertChainType.GetText(type), "urlAndHashList");
			}
			m_type = type;
			m_urlAndHashList = urlAndHashList;
			return;
		}
		throw new ArgumentException("must have length > 0", "urlAndHashList");
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(m_type, output);
		ListBuffer16 listBuffer = new ListBuffer16();
		foreach (UrlAndHash urlAndHash in m_urlAndHashList)
		{
			urlAndHash.Encode(listBuffer);
		}
		listBuffer.EncodeTo(output);
	}

	public static CertificateUrl Parse(TlsContext context, Stream input)
	{
		short num = TlsUtilities.ReadUint8(input);
		if (!CertChainType.IsValid(num))
		{
			throw new TlsFatalAlert(50);
		}
		int num2 = TlsUtilities.ReadUint16(input);
		if (num2 < 1)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream memoryStream = new MemoryStream(TlsUtilities.ReadFully(num2, input), writable: false);
		IList list = Platform.CreateArrayList();
		while (memoryStream.Position < memoryStream.Length)
		{
			UrlAndHash value = UrlAndHash.Parse(context, memoryStream);
			list.Add(value);
		}
		if (num == 1 && list.Count != 1)
		{
			throw new TlsFatalAlert(50);
		}
		return new CertificateUrl(num, list);
	}
}
