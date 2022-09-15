using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509.Store;

public sealed class X509StoreFactory
{
	private X509StoreFactory()
	{
	}

	public static IX509Store Create(string type, IX509StoreParameters parameters)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		string[] array = Platform.ToUpperInvariant(type).Split(new char[1] { '/' });
		if (array.Length < 2)
		{
			throw new ArgumentException("type");
		}
		if (array[1] != "COLLECTION")
		{
			throw new NoSuchStoreException("X.509 store type '" + type + "' not available.");
		}
		ICollection collection = ((X509CollectionStoreParameters)parameters).GetCollection();
		switch (array[0])
		{
		default:
			throw new NoSuchStoreException("X.509 store type '" + type + "' not available.");
		case "CRL":
			checkCorrectType(collection, typeof(X509Crl));
			break;
		case "CERTIFICATEPAIR":
			checkCorrectType(collection, typeof(X509CertificatePair));
			break;
		case "CERTIFICATE":
			checkCorrectType(collection, typeof(X509Certificate));
			break;
		case "ATTRIBUTECERTIFICATE":
			checkCorrectType(collection, typeof(IX509AttributeCertificate));
			break;
		}
		return new X509CollectionStore(collection);
	}

	private static void checkCorrectType(ICollection coll, Type t)
	{
		foreach (object item in coll)
		{
			if (!t.IsInstanceOfType(item))
			{
				throw new InvalidCastException("Can't cast object to type: " + t.FullName);
			}
		}
	}
}
