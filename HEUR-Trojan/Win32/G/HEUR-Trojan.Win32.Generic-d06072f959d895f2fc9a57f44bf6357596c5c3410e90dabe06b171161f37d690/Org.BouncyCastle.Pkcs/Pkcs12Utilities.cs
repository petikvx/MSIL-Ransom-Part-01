using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Pkcs;

public class Pkcs12Utilities
{
	public static byte[] ConvertToDefiniteLength(byte[] berPkcs12File)
	{
		return new Pfx(Asn1Sequence.GetInstance(Asn1Object.FromByteArray(berPkcs12File))).GetEncoded("DER");
	}

	public static byte[] ConvertToDefiniteLength(byte[] berPkcs12File, char[] passwd)
	{
		Pfx pfx = new Pfx(Asn1Sequence.GetInstance(Asn1Object.FromByteArray(berPkcs12File)));
		ContentInfo authSafe = pfx.AuthSafe;
		authSafe = new ContentInfo(content: new DerOctetString(Asn1Object.FromByteArray(Asn1OctetString.GetInstance(authSafe.Content).GetOctets()).GetEncoded("DER")), contentType: authSafe.ContentType);
		MacData macData = pfx.MacData;
		try
		{
			int intValue = macData.IterationCount.IntValue;
			byte[] octets = Asn1OctetString.GetInstance(authSafe.Content).GetOctets();
			byte[] digest = Pkcs12Store.CalculatePbeMac(macData.Mac.AlgorithmID.Algorithm, macData.GetSalt(), intValue, passwd, wrongPkcs12Zero: false, octets);
			macData = new MacData(new DigestInfo(new AlgorithmIdentifier(macData.Mac.AlgorithmID.Algorithm, DerNull.Instance), digest), macData.GetSalt(), intValue);
		}
		catch (Exception ex)
		{
			throw new IOException("error constructing MAC: " + ex.ToString());
		}
		return new Pfx(authSafe, macData).GetEncoded("DER");
	}
}
