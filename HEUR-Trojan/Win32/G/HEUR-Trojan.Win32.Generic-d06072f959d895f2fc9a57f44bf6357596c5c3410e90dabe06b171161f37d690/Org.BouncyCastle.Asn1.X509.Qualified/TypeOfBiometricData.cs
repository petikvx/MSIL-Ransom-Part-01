using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified;

public class TypeOfBiometricData : Asn1Encodable, IAsn1Choice
{
	public const int Picture = 0;

	public const int HandwrittenSignature = 1;

	internal Asn1Encodable obj;

	public bool IsPredefined => obj is DerInteger;

	public int PredefinedBiometricType => ((DerInteger)obj).IntValueExact;

	public DerObjectIdentifier BiometricDataOid => (DerObjectIdentifier)obj;

	public static TypeOfBiometricData GetInstance(object obj)
	{
		if (obj != null && !(obj is TypeOfBiometricData))
		{
			if (obj is DerInteger)
			{
				return new TypeOfBiometricData(DerInteger.GetInstance(obj).IntValueExact);
			}
			if (obj is DerObjectIdentifier)
			{
				return new TypeOfBiometricData(DerObjectIdentifier.GetInstance(obj));
			}
			throw new ArgumentException("unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
		}
		return (TypeOfBiometricData)obj;
	}

	public TypeOfBiometricData(int predefinedBiometricType)
	{
		if (predefinedBiometricType != 0 && predefinedBiometricType != 1)
		{
			throw new ArgumentException("unknow PredefinedBiometricType : " + predefinedBiometricType);
		}
		obj = new DerInteger(predefinedBiometricType);
	}

	public TypeOfBiometricData(DerObjectIdentifier biometricDataOid)
	{
		obj = biometricDataOid;
	}

	public override Asn1Object ToAsn1Object()
	{
		return obj.ToAsn1Object();
	}
}
