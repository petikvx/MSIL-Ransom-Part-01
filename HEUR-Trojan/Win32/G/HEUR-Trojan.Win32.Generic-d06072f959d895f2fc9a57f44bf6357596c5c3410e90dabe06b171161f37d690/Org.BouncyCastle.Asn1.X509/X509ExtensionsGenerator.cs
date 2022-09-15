using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class X509ExtensionsGenerator
{
	private IDictionary extensions = Platform.CreateHashtable();

	private IList extOrdering = Platform.CreateArrayList();

	private static readonly IDictionary dupsAllowed;

	public bool IsEmpty => extOrdering.Count < 1;

	static X509ExtensionsGenerator()
	{
		dupsAllowed = Platform.CreateHashtable();
		dupsAllowed.Add(X509Extensions.SubjectAlternativeName, true);
		dupsAllowed.Add(X509Extensions.IssuerAlternativeName, true);
		dupsAllowed.Add(X509Extensions.SubjectDirectoryAttributes, true);
		dupsAllowed.Add(X509Extensions.CertificateIssuer, true);
	}

	public void Reset()
	{
		extensions = Platform.CreateHashtable();
		extOrdering = Platform.CreateArrayList();
	}

	public void AddExtension(DerObjectIdentifier oid, bool critical, Asn1Encodable extValue)
	{
		byte[] derEncoded;
		try
		{
			derEncoded = extValue.GetDerEncoded();
		}
		catch (Exception ex)
		{
			throw new ArgumentException("error encoding value: " + ex);
		}
		AddExtension(oid, critical, derEncoded);
	}

	public void AddExtension(DerObjectIdentifier oid, bool critical, byte[] extValue)
	{
		if (extensions.Contains(oid))
		{
			if (!dupsAllowed.Contains(oid))
			{
				throw new ArgumentException("extension " + oid?.ToString() + " already added");
			}
			X509Extension x509Extension = (X509Extension)extensions[oid];
			Asn1EncodableVector asn1EncodableVector = Asn1EncodableVector.FromEnumerable(Asn1Sequence.GetInstance(Asn1OctetString.GetInstance(x509Extension.Value).GetOctets()));
			foreach (Asn1Encodable item in Asn1Sequence.GetInstance(extValue))
			{
				asn1EncodableVector.Add(item);
			}
			extensions[oid] = new X509Extension(x509Extension.IsCritical, new DerOctetString(new DerSequence(asn1EncodableVector).GetEncoded()));
		}
		else
		{
			extOrdering.Add(oid);
			extensions.Add(oid, new X509Extension(critical, new DerOctetString(extValue)));
		}
	}

	public void AddExtensions(X509Extensions extensions)
	{
		foreach (DerObjectIdentifier extensionOid in extensions.ExtensionOids)
		{
			X509Extension extension = extensions.GetExtension(extensionOid);
			AddExtension(extensionOid, extension.critical, extension.Value.GetOctets());
		}
	}

	public X509Extensions Generate()
	{
		return new X509Extensions(extOrdering, extensions);
	}

	internal void AddExtension(DerObjectIdentifier oid, X509Extension x509Extension)
	{
		if (extensions.Contains(oid))
		{
			throw new ArgumentException("extension " + oid?.ToString() + " already added");
		}
		extOrdering.Add(oid);
		extensions.Add(oid, x509Extension);
	}
}
