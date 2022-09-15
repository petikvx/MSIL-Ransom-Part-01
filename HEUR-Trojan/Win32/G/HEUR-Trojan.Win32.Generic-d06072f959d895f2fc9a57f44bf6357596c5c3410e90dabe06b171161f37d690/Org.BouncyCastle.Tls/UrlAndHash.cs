using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class UrlAndHash
{
	private readonly string m_url;

	private readonly byte[] m_sha1Hash;

	public string Url => m_url;

	public byte[] Sha1Hash => m_sha1Hash;

	public UrlAndHash(string url, byte[] sha1Hash)
	{
		if (!TlsUtilities.IsNullOrEmpty(url) && url.Length < 65536)
		{
			if (sha1Hash != null && sha1Hash.Length != 20)
			{
				throw new ArgumentException("must have length == 20, if present", "sha1Hash");
			}
			m_url = url;
			m_sha1Hash = sha1Hash;
			return;
		}
		throw new ArgumentException("must have length from 1 to (2^16 - 1)", "url");
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteOpaque16(Strings.ToByteArray(m_url), output);
		if (m_sha1Hash == null)
		{
			TlsUtilities.WriteUint8(0, output);
			return;
		}
		TlsUtilities.WriteUint8(1, output);
		output.Write(m_sha1Hash, 0, m_sha1Hash.Length);
	}

	public static UrlAndHash Parse(TlsContext context, Stream input)
	{
		string url = Strings.FromByteArray(TlsUtilities.ReadOpaque16(input, 1));
		byte[] sha1Hash = null;
		switch (TlsUtilities.ReadUint8(input))
		{
		default:
			throw new TlsFatalAlert(47);
		case 1:
			sha1Hash = TlsUtilities.ReadFully(20, input);
			break;
		case 0:
			if (TlsUtilities.IsTlsV12(context))
			{
				throw new TlsFatalAlert(47);
			}
			break;
		}
		return new UrlAndHash(url, sha1Hash);
	}
}
