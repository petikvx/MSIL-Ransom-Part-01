using System;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class TrustedAuthority
{
	private readonly short m_identifierType;

	private readonly object m_identifier;

	public short IdentifierType => m_identifierType;

	public object Identifier => m_identifier;

	public X509Name X509Name
	{
		get
		{
			CheckCorrectType(2);
			return (X509Name)m_identifier;
		}
	}

	public TrustedAuthority(short identifierType, object identifier)
	{
		if (!IsCorrectType(identifierType, identifier))
		{
			throw new ArgumentException("not an instance of the correct type", "identifier");
		}
		m_identifierType = identifierType;
		m_identifier = identifier;
	}

	public byte[] GetCertSha1Hash()
	{
		return Arrays.Clone((byte[])m_identifier);
	}

	public byte[] GetKeySha1Hash()
	{
		return Arrays.Clone((byte[])m_identifier);
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(m_identifierType, output);
		switch (m_identifierType)
		{
		default:
			throw new TlsFatalAlert(80);
		case 0:
			break;
		case 2:
			TlsUtilities.WriteOpaque16(((X509Name)m_identifier).GetEncoded("DER"), output);
			break;
		case 1:
		case 3:
		{
			byte[] array = (byte[])m_identifier;
			output.Write(array, 0, array.Length);
			break;
		}
		}
	}

	public static TrustedAuthority Parse(Stream input)
	{
		short num = TlsUtilities.ReadUint8(input);
		object identifier;
		switch (num)
		{
		default:
			throw new TlsFatalAlert(50);
		case 0:
			identifier = null;
			break;
		case 2:
			identifier = X509Name.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque16(input, 1)));
			break;
		case 1:
		case 3:
			identifier = TlsUtilities.ReadFully(20, input);
			break;
		}
		return new TrustedAuthority(num, identifier);
	}

	private void CheckCorrectType(short expectedIdentifierType)
	{
		if (m_identifierType != expectedIdentifierType || !IsCorrectType(expectedIdentifierType, m_identifier))
		{
			throw new InvalidOperationException("TrustedAuthority is not of type " + Org.BouncyCastle.Tls.IdentifierType.GetName(expectedIdentifierType));
		}
	}

	private static bool IsCorrectType(short identifierType, object identifier)
	{
		switch (identifierType)
		{
		default:
			throw new ArgumentException("unsupported IdentifierType", "identifierType");
		case 0:
			return identifier == null;
		case 2:
			return identifier is X509Name;
		case 1:
		case 3:
			return IsSha1Hash(identifier);
		}
	}

	private static bool IsSha1Hash(object identifier)
	{
		if (identifier is byte[])
		{
			return ((byte[])identifier).Length == 20;
		}
		return false;
	}
}
