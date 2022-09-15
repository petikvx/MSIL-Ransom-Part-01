using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class SignatureAndHashAlgorithm
{
	public static readonly SignatureAndHashAlgorithm ecdsa_brainpoolP256r1tls13_sha256 = Create(2074);

	public static readonly SignatureAndHashAlgorithm ecdsa_brainpoolP384r1tls13_sha384 = Create(2075);

	public static readonly SignatureAndHashAlgorithm ecdsa_brainpoolP512r1tls13_sha512 = Create(2076);

	public static readonly SignatureAndHashAlgorithm ed25519 = Create(2055);

	public static readonly SignatureAndHashAlgorithm ed448 = Create(2056);

	public static readonly SignatureAndHashAlgorithm gostr34102012_256 = Create(8, 64);

	public static readonly SignatureAndHashAlgorithm gostr34102012_512 = Create(8, 65);

	public static readonly SignatureAndHashAlgorithm rsa_pss_rsae_sha256 = Create(2052);

	public static readonly SignatureAndHashAlgorithm rsa_pss_rsae_sha384 = Create(2053);

	public static readonly SignatureAndHashAlgorithm rsa_pss_rsae_sha512 = Create(2054);

	public static readonly SignatureAndHashAlgorithm rsa_pss_pss_sha256 = Create(2057);

	public static readonly SignatureAndHashAlgorithm rsa_pss_pss_sha384 = Create(2058);

	public static readonly SignatureAndHashAlgorithm rsa_pss_pss_sha512 = Create(2059);

	private readonly short m_hash;

	private readonly short m_signature;

	public short Hash => m_hash;

	public short Signature => m_signature;

	public static SignatureAndHashAlgorithm GetInstance(short hashAlgorithm, short signatureAlgorithm)
	{
		if (hashAlgorithm == 8)
		{
			return GetInstanceIntrinsic(signatureAlgorithm);
		}
		return Create(hashAlgorithm, signatureAlgorithm);
	}

	private static SignatureAndHashAlgorithm GetInstanceIntrinsic(short signatureAlgorithm)
	{
		return signatureAlgorithm switch
		{
			26 => ecdsa_brainpoolP256r1tls13_sha256, 
			27 => ecdsa_brainpoolP384r1tls13_sha384, 
			28 => ecdsa_brainpoolP512r1tls13_sha512, 
			4 => rsa_pss_rsae_sha256, 
			5 => rsa_pss_rsae_sha384, 
			6 => rsa_pss_rsae_sha512, 
			7 => ed25519, 
			8 => ed448, 
			9 => rsa_pss_pss_sha256, 
			10 => rsa_pss_pss_sha384, 
			11 => rsa_pss_pss_sha512, 
			65 => gostr34102012_512, 
			64 => gostr34102012_256, 
			_ => Create(8, signatureAlgorithm), 
		};
	}

	private static SignatureAndHashAlgorithm Create(int signatureScheme)
	{
		short hashAlgorithm = SignatureScheme.GetHashAlgorithm(signatureScheme);
		short signatureAlgorithm = SignatureScheme.GetSignatureAlgorithm(signatureScheme);
		return Create(hashAlgorithm, signatureAlgorithm);
	}

	private static SignatureAndHashAlgorithm Create(short hashAlgorithm, short signatureAlgorithm)
	{
		return new SignatureAndHashAlgorithm(hashAlgorithm, signatureAlgorithm);
	}

	public SignatureAndHashAlgorithm(short hash, short signature)
	{
		if ((hash & 0xFF) != hash)
		{
			throw new ArgumentException("should be a uint8", "hash");
		}
		if ((signature & 0xFF) != signature)
		{
			throw new ArgumentException("should be a uint8", "signature");
		}
		m_hash = hash;
		m_signature = signature;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint8(Hash, output);
		TlsUtilities.WriteUint8(Signature, output);
	}

	public static SignatureAndHashAlgorithm Parse(Stream input)
	{
		short hashAlgorithm = TlsUtilities.ReadUint8(input);
		short signatureAlgorithm = TlsUtilities.ReadUint8(input);
		return GetInstance(hashAlgorithm, signatureAlgorithm);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is SignatureAndHashAlgorithm))
		{
			return false;
		}
		SignatureAndHashAlgorithm signatureAndHashAlgorithm = (SignatureAndHashAlgorithm)obj;
		if (signatureAndHashAlgorithm.Hash == Hash)
		{
			return signatureAndHashAlgorithm.Signature == Signature;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (Hash << 16) | Signature;
	}

	public override string ToString()
	{
		return "{" + HashAlgorithm.GetText(Hash) + "," + SignatureAlgorithm.GetText(Signature) + "}";
	}
}
