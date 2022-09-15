using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509.Extension;

public class X509ExtensionUtilities
{
	public static Asn1Object FromExtensionValue(Asn1OctetString extensionValue)
	{
		return Asn1Object.FromByteArray(extensionValue.GetOctets());
	}

	public static ICollection GetIssuerAlternativeNames(X509Certificate cert)
	{
		return GetAlternativeName(cert.GetExtensionValue(X509Extensions.IssuerAlternativeName));
	}

	public static ICollection GetSubjectAlternativeNames(X509Certificate cert)
	{
		return GetAlternativeName(cert.GetExtensionValue(X509Extensions.SubjectAlternativeName));
	}

	private static ICollection GetAlternativeName(Asn1OctetString extVal)
	{
		IList list = Platform.CreateArrayList();
		if (extVal != null)
		{
			try
			{
				foreach (Asn1Encodable item in Asn1Sequence.GetInstance(FromExtensionValue(extVal)))
				{
					IList list2 = Platform.CreateArrayList();
					GeneralName instance = GeneralName.GetInstance(item);
					list2.Add(instance.TagNo);
					switch (instance.TagNo)
					{
					case 4:
						list2.Add(X509Name.GetInstance(instance.Name).ToString());
						break;
					case 0:
					case 3:
					case 5:
						list2.Add(instance.Name.ToAsn1Object());
						break;
					case 1:
					case 2:
					case 6:
						list2.Add(((IAsn1String)instance.Name).GetString());
						break;
					case 7:
						list2.Add(Asn1OctetString.GetInstance(instance.Name).GetOctets());
						break;
					case 8:
						list2.Add(DerObjectIdentifier.GetInstance(instance.Name).Id);
						break;
					default:
						throw new IOException("Bad tag number: " + instance.TagNo);
					}
					list.Add(list2);
				}
				return list;
			}
			catch (Exception ex)
			{
				throw new CertificateParsingException(ex.Message);
			}
		}
		return list;
	}
}
