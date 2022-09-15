namespace Org.BouncyCastle.Asn1.TeleTrust;

public sealed class TeleTrusTObjectIdentifiers
{
	public static readonly DerObjectIdentifier TeleTrusTAlgorithm = new DerObjectIdentifier("1.3.36.3");

	public static readonly DerObjectIdentifier RipeMD160 = new DerObjectIdentifier(TeleTrusTAlgorithm?.ToString() + ".2.1");

	public static readonly DerObjectIdentifier RipeMD128 = new DerObjectIdentifier(TeleTrusTAlgorithm?.ToString() + ".2.2");

	public static readonly DerObjectIdentifier RipeMD256 = new DerObjectIdentifier(TeleTrusTAlgorithm?.ToString() + ".2.3");

	public static readonly DerObjectIdentifier TeleTrusTRsaSignatureAlgorithm = new DerObjectIdentifier(TeleTrusTAlgorithm?.ToString() + ".3.1");

	public static readonly DerObjectIdentifier RsaSignatureWithRipeMD160 = new DerObjectIdentifier(TeleTrusTRsaSignatureAlgorithm?.ToString() + ".2");

	public static readonly DerObjectIdentifier RsaSignatureWithRipeMD128 = new DerObjectIdentifier(TeleTrusTRsaSignatureAlgorithm?.ToString() + ".3");

	public static readonly DerObjectIdentifier RsaSignatureWithRipeMD256 = new DerObjectIdentifier(TeleTrusTRsaSignatureAlgorithm?.ToString() + ".4");

	public static readonly DerObjectIdentifier ECSign = new DerObjectIdentifier(TeleTrusTAlgorithm?.ToString() + ".3.2");

	public static readonly DerObjectIdentifier ECSignWithSha1 = new DerObjectIdentifier(ECSign?.ToString() + ".1");

	public static readonly DerObjectIdentifier ECSignWithRipeMD160 = new DerObjectIdentifier(ECSign?.ToString() + ".2");

	public static readonly DerObjectIdentifier EccBrainpool = new DerObjectIdentifier(TeleTrusTAlgorithm?.ToString() + ".3.2.8");

	public static readonly DerObjectIdentifier EllipticCurve = new DerObjectIdentifier(EccBrainpool?.ToString() + ".1");

	public static readonly DerObjectIdentifier VersionOne = new DerObjectIdentifier(EllipticCurve?.ToString() + ".1");

	public static readonly DerObjectIdentifier BrainpoolP160R1 = new DerObjectIdentifier(VersionOne?.ToString() + ".1");

	public static readonly DerObjectIdentifier BrainpoolP160T1 = new DerObjectIdentifier(VersionOne?.ToString() + ".2");

	public static readonly DerObjectIdentifier BrainpoolP192R1 = new DerObjectIdentifier(VersionOne?.ToString() + ".3");

	public static readonly DerObjectIdentifier BrainpoolP192T1 = new DerObjectIdentifier(VersionOne?.ToString() + ".4");

	public static readonly DerObjectIdentifier BrainpoolP224R1 = new DerObjectIdentifier(VersionOne?.ToString() + ".5");

	public static readonly DerObjectIdentifier BrainpoolP224T1 = new DerObjectIdentifier(VersionOne?.ToString() + ".6");

	public static readonly DerObjectIdentifier BrainpoolP256R1 = new DerObjectIdentifier(VersionOne?.ToString() + ".7");

	public static readonly DerObjectIdentifier BrainpoolP256T1 = new DerObjectIdentifier(VersionOne?.ToString() + ".8");

	public static readonly DerObjectIdentifier BrainpoolP320R1 = new DerObjectIdentifier(VersionOne?.ToString() + ".9");

	public static readonly DerObjectIdentifier BrainpoolP320T1 = new DerObjectIdentifier(VersionOne?.ToString() + ".10");

	public static readonly DerObjectIdentifier BrainpoolP384R1 = new DerObjectIdentifier(VersionOne?.ToString() + ".11");

	public static readonly DerObjectIdentifier BrainpoolP384T1 = new DerObjectIdentifier(VersionOne?.ToString() + ".12");

	public static readonly DerObjectIdentifier BrainpoolP512R1 = new DerObjectIdentifier(VersionOne?.ToString() + ".13");

	public static readonly DerObjectIdentifier BrainpoolP512T1 = new DerObjectIdentifier(VersionOne?.ToString() + ".14");

	private TeleTrusTObjectIdentifiers()
	{
	}
}
