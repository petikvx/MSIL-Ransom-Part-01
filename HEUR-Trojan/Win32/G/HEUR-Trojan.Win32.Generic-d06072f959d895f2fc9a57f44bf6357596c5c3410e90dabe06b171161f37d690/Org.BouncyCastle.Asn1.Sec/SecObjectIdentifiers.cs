using Org.BouncyCastle.Asn1.X9;

namespace Org.BouncyCastle.Asn1.Sec;

public abstract class SecObjectIdentifiers
{
	public static readonly DerObjectIdentifier EllipticCurve = new DerObjectIdentifier("1.3.132.0");

	public static readonly DerObjectIdentifier SecT163k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".1");

	public static readonly DerObjectIdentifier SecT163r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".2");

	public static readonly DerObjectIdentifier SecT239k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".3");

	public static readonly DerObjectIdentifier SecT113r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".4");

	public static readonly DerObjectIdentifier SecT113r2 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".5");

	public static readonly DerObjectIdentifier SecP112r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".6");

	public static readonly DerObjectIdentifier SecP112r2 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".7");

	public static readonly DerObjectIdentifier SecP160r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".8");

	public static readonly DerObjectIdentifier SecP160k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".9");

	public static readonly DerObjectIdentifier SecP256k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".10");

	public static readonly DerObjectIdentifier SecT163r2 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".15");

	public static readonly DerObjectIdentifier SecT283k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".16");

	public static readonly DerObjectIdentifier SecT283r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".17");

	public static readonly DerObjectIdentifier SecT131r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".22");

	public static readonly DerObjectIdentifier SecT131r2 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".23");

	public static readonly DerObjectIdentifier SecT193r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".24");

	public static readonly DerObjectIdentifier SecT193r2 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".25");

	public static readonly DerObjectIdentifier SecT233k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".26");

	public static readonly DerObjectIdentifier SecT233r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".27");

	public static readonly DerObjectIdentifier SecP128r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".28");

	public static readonly DerObjectIdentifier SecP128r2 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".29");

	public static readonly DerObjectIdentifier SecP160r2 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".30");

	public static readonly DerObjectIdentifier SecP192k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".31");

	public static readonly DerObjectIdentifier SecP224k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".32");

	public static readonly DerObjectIdentifier SecP224r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".33");

	public static readonly DerObjectIdentifier SecP384r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".34");

	public static readonly DerObjectIdentifier SecP521r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".35");

	public static readonly DerObjectIdentifier SecT409k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".36");

	public static readonly DerObjectIdentifier SecT409r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".37");

	public static readonly DerObjectIdentifier SecT571k1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".38");

	public static readonly DerObjectIdentifier SecT571r1 = new DerObjectIdentifier(EllipticCurve?.ToString() + ".39");

	public static readonly DerObjectIdentifier SecP192r1 = X9ObjectIdentifiers.Prime192v1;

	public static readonly DerObjectIdentifier SecP256r1 = X9ObjectIdentifiers.Prime256v1;
}
