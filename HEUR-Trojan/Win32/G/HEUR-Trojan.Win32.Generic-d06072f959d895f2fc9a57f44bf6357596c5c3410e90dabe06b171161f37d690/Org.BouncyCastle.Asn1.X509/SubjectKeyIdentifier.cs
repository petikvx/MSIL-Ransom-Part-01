using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class SubjectKeyIdentifier : Asn1Encodable
{
	private readonly byte[] keyIdentifier;

	public static SubjectKeyIdentifier GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1OctetString.GetInstance(obj, explicitly));
	}

	public static SubjectKeyIdentifier GetInstance(object obj)
	{
		if (obj is SubjectKeyIdentifier)
		{
			return (SubjectKeyIdentifier)obj;
		}
		if (obj is SubjectPublicKeyInfo)
		{
			return new SubjectKeyIdentifier((SubjectPublicKeyInfo)obj);
		}
		if (obj is X509Extension)
		{
			return GetInstance(X509Extension.ConvertValueToObject((X509Extension)obj));
		}
		if (obj == null)
		{
			return null;
		}
		return new SubjectKeyIdentifier(Asn1OctetString.GetInstance(obj));
	}

	public static SubjectKeyIdentifier FromExtensions(X509Extensions extensions)
	{
		return GetInstance(X509Extensions.GetExtensionParsedValue(extensions, X509Extensions.SubjectKeyIdentifier));
	}

	public SubjectKeyIdentifier(byte[] keyID)
	{
		if (keyID == null)
		{
			throw new ArgumentNullException("keyID");
		}
		keyIdentifier = Arrays.Clone(keyID);
	}

	public SubjectKeyIdentifier(Asn1OctetString keyID)
		: this(keyID.GetOctets())
	{
	}

	public SubjectKeyIdentifier(SubjectPublicKeyInfo spki)
	{
		keyIdentifier = GetDigest(spki);
	}

	public byte[] GetKeyIdentifier()
	{
		return Arrays.Clone(keyIdentifier);
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerOctetString(GetKeyIdentifier());
	}

	public static SubjectKeyIdentifier CreateSha1KeyIdentifier(SubjectPublicKeyInfo keyInfo)
	{
		return new SubjectKeyIdentifier(keyInfo);
	}

	public static SubjectKeyIdentifier CreateTruncatedSha1KeyIdentifier(SubjectPublicKeyInfo keyInfo)
	{
		byte[] digest = GetDigest(keyInfo);
		byte[] array = new byte[8];
		Array.Copy(digest, digest.Length - 8, array, 0, array.Length);
		array[0] &= 15;
		array[0] |= 64;
		return new SubjectKeyIdentifier(array);
	}

	private static byte[] GetDigest(SubjectPublicKeyInfo spki)
	{
		Sha1Digest sha1Digest = new Sha1Digest();
		byte[] array = new byte[((IDigest)sha1Digest).GetDigestSize()];
		byte[] bytes = spki.PublicKeyData.GetBytes();
		((IDigest)sha1Digest).BlockUpdate(bytes, 0, bytes.Length);
		((IDigest)sha1Digest).DoFinal(array, 0);
		return array;
	}
}
