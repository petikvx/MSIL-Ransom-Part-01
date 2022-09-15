using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class PskIdentity
{
	private readonly byte[] m_identity;

	private readonly long m_obfuscatedTicketAge;

	public byte[] Identity => m_identity;

	public long ObfuscatedTicketAge => m_obfuscatedTicketAge;

	public PskIdentity(byte[] identity, long obfuscatedTicketAge)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		if (identity.Length >= 1 && TlsUtilities.IsValidUint16(identity.Length))
		{
			if (!TlsUtilities.IsValidUint32(obfuscatedTicketAge))
			{
				throw new ArgumentException("should be a uint32", "obfuscatedTicketAge");
			}
			m_identity = identity;
			m_obfuscatedTicketAge = obfuscatedTicketAge;
			return;
		}
		throw new ArgumentException("should have length from 1 to 65535", "identity");
	}

	public int GetEncodedLength()
	{
		return 6 + m_identity.Length;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteOpaque16(Identity, output);
		TlsUtilities.WriteUint32(ObfuscatedTicketAge, output);
	}

	public static PskIdentity Parse(Stream input)
	{
		byte[] identity = TlsUtilities.ReadOpaque16(input, 1);
		long obfuscatedTicketAge = TlsUtilities.ReadUint32(input);
		return new PskIdentity(identity, obfuscatedTicketAge);
	}
}
