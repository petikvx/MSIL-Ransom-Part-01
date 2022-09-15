using System;
using System.Collections;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Smime;

public class SmimeCapabilities : Asn1Encodable
{
	public static readonly DerObjectIdentifier PreferSignedData = PkcsObjectIdentifiers.PreferSignedData;

	public static readonly DerObjectIdentifier CannotDecryptAny = PkcsObjectIdentifiers.CannotDecryptAny;

	public static readonly DerObjectIdentifier SmimeCapabilitesVersions = PkcsObjectIdentifiers.SmimeCapabilitiesVersions;

	public static readonly DerObjectIdentifier Aes256Cbc = NistObjectIdentifiers.IdAes256Cbc;

	public static readonly DerObjectIdentifier Aes192Cbc = NistObjectIdentifiers.IdAes192Cbc;

	public static readonly DerObjectIdentifier Aes128Cbc = NistObjectIdentifiers.IdAes128Cbc;

	public static readonly DerObjectIdentifier IdeaCbc = new DerObjectIdentifier("1.3.6.1.4.1.188.7.1.1.2");

	public static readonly DerObjectIdentifier Cast5Cbc = new DerObjectIdentifier("1.2.840.113533.7.66.10");

	public static readonly DerObjectIdentifier DesCbc = new DerObjectIdentifier("1.3.14.3.2.7");

	public static readonly DerObjectIdentifier DesEde3Cbc = PkcsObjectIdentifiers.DesEde3Cbc;

	public static readonly DerObjectIdentifier RC2Cbc = PkcsObjectIdentifiers.RC2Cbc;

	private Asn1Sequence capabilities;

	public static SmimeCapabilities GetInstance(object obj)
	{
		if (obj != null && !(obj is SmimeCapabilities))
		{
			if (obj is Asn1Sequence)
			{
				return new SmimeCapabilities((Asn1Sequence)obj);
			}
			if (obj is AttributeX509)
			{
				return new SmimeCapabilities((Asn1Sequence)((AttributeX509)obj).AttrValues[0]);
			}
			throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
		}
		return (SmimeCapabilities)obj;
	}

	public SmimeCapabilities(Asn1Sequence seq)
	{
		capabilities = seq;
	}

	[Obsolete("Use 'GetCapabilitiesForOid' instead")]
	public ArrayList GetCapabilities(DerObjectIdentifier capability)
	{
		ArrayList arrayList = new ArrayList();
		DoGetCapabilitiesForOid(capability, arrayList);
		return arrayList;
	}

	public IList GetCapabilitiesForOid(DerObjectIdentifier capability)
	{
		IList list = Platform.CreateArrayList();
		DoGetCapabilitiesForOid(capability, list);
		return list;
	}

	private void DoGetCapabilitiesForOid(DerObjectIdentifier capability, IList list)
	{
		if (capability == null)
		{
			foreach (object capability2 in capabilities)
			{
				SmimeCapability instance = SmimeCapability.GetInstance(capability2);
				list.Add(instance);
			}
			return;
		}
		foreach (object capability3 in capabilities)
		{
			SmimeCapability instance2 = SmimeCapability.GetInstance(capability3);
			if (capability.Equals(instance2.CapabilityID))
			{
				list.Add(instance2);
			}
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		return capabilities;
	}
}
