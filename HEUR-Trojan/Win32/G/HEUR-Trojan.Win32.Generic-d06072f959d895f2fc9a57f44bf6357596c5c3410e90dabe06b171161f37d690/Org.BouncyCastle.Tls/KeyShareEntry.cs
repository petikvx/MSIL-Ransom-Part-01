using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class KeyShareEntry
{
	private readonly int m_namedGroup;

	private readonly byte[] m_keyExchange;

	public int NamedGroup => m_namedGroup;

	public byte[] KeyExchange => m_keyExchange;

	private static bool CheckKeyExchangeLength(int length)
	{
		if (0 < length)
		{
			return length < 65536;
		}
		return false;
	}

	public KeyShareEntry(int namedGroup, byte[] keyExchange)
	{
		if (!TlsUtilities.IsValidUint16(namedGroup))
		{
			throw new ArgumentException("should be a uint16", "namedGroup");
		}
		if (keyExchange == null)
		{
			throw new ArgumentNullException("keyExchange");
		}
		if (!CheckKeyExchangeLength(keyExchange.Length))
		{
			throw new ArgumentException("must have length from 1 to (2^16 - 1)", "keyExchange");
		}
		m_namedGroup = namedGroup;
		m_keyExchange = keyExchange;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint16(NamedGroup, output);
		TlsUtilities.WriteOpaque16(KeyExchange, output);
	}

	public static KeyShareEntry Parse(Stream input)
	{
		int namedGroup = TlsUtilities.ReadUint16(input);
		byte[] keyExchange = TlsUtilities.ReadOpaque16(input, 1);
		return new KeyShareEntry(namedGroup, keyExchange);
	}
}
