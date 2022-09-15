using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class ProtocolName
{
	public static readonly ProtocolName Http_1_1 = AsUtf8Encoding("http/1.1");

	public static readonly ProtocolName Spdy_1 = AsUtf8Encoding("spdy/1");

	public static readonly ProtocolName Spdy_2 = AsUtf8Encoding("spdy/2");

	public static readonly ProtocolName Spdy_3 = AsUtf8Encoding("spdy/3");

	public static readonly ProtocolName Stun_Turn = AsUtf8Encoding("stun.turn");

	public static readonly ProtocolName Stun_Nat_Discovery = AsUtf8Encoding("stun.nat-discovery");

	public static readonly ProtocolName Http_2_Tls = AsUtf8Encoding("h2");

	public static readonly ProtocolName Http_2_Tcp = AsUtf8Encoding("h2c");

	public static readonly ProtocolName WebRtc = AsUtf8Encoding("webrtc");

	public static readonly ProtocolName WebRtc_Confidential = AsUtf8Encoding("c-webrtc");

	public static readonly ProtocolName Ftp = AsUtf8Encoding("ftp");

	public static readonly ProtocolName Imap = AsUtf8Encoding("imap");

	public static readonly ProtocolName Pop3 = AsUtf8Encoding("pop3");

	public static readonly ProtocolName ManageSieve = AsUtf8Encoding("managesieve");

	public static readonly ProtocolName Coap = AsUtf8Encoding("coap");

	public static readonly ProtocolName Xmpp_Client = AsUtf8Encoding("xmpp-client");

	public static readonly ProtocolName Xmpp_Server = AsUtf8Encoding("xmpp-server");

	private readonly byte[] m_bytes;

	public static ProtocolName AsRawBytes(byte[] bytes)
	{
		return new ProtocolName(Arrays.Clone(bytes));
	}

	public static ProtocolName AsUtf8Encoding(string name)
	{
		return new ProtocolName(Strings.ToUtf8ByteArray(name));
	}

	private ProtocolName(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (bytes.Length < 1 || bytes.Length > 255)
		{
			throw new ArgumentException("must have length from 1 to 255", "bytes");
		}
		m_bytes = bytes;
	}

	public byte[] GetBytes()
	{
		return Arrays.Clone(m_bytes);
	}

	public string GetUtf8Decoding()
	{
		return Strings.FromUtf8ByteArray(m_bytes);
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteOpaque8(m_bytes, output);
	}

	public static ProtocolName Parse(Stream input)
	{
		return new ProtocolName(TlsUtilities.ReadOpaque8(input, 1));
	}

	public override bool Equals(object obj)
	{
		if (obj is ProtocolName)
		{
			return Arrays.AreEqual(m_bytes, ((ProtocolName)obj).m_bytes);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Arrays.GetHashCode(m_bytes);
	}
}
