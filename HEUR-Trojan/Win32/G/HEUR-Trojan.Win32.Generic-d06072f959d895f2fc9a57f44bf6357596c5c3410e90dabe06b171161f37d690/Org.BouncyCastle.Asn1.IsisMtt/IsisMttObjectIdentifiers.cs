namespace Org.BouncyCastle.Asn1.IsisMtt;

public abstract class IsisMttObjectIdentifiers
{
	public static readonly DerObjectIdentifier IdIsisMtt = new DerObjectIdentifier("1.3.36.8");

	public static readonly DerObjectIdentifier IdIsisMttCP = new DerObjectIdentifier(IdIsisMtt?.ToString() + ".1");

	public static readonly DerObjectIdentifier IdIsisMttCPAccredited = new DerObjectIdentifier(IdIsisMttCP?.ToString() + ".1");

	public static readonly DerObjectIdentifier IdIsisMttAT = new DerObjectIdentifier(IdIsisMtt?.ToString() + ".3");

	public static readonly DerObjectIdentifier IdIsisMttATDateOfCertGen = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".1");

	public static readonly DerObjectIdentifier IdIsisMttATProcuration = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".2");

	public static readonly DerObjectIdentifier IdIsisMttATAdmission = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".3");

	public static readonly DerObjectIdentifier IdIsisMttATMonetaryLimit = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".4");

	public static readonly DerObjectIdentifier IdIsisMttATDeclarationOfMajority = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".5");

	public static readonly DerObjectIdentifier IdIsisMttATIccsn = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".6");

	public static readonly DerObjectIdentifier IdIsisMttATPKReference = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".7");

	public static readonly DerObjectIdentifier IdIsisMttATRestriction = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".8");

	public static readonly DerObjectIdentifier IdIsisMttATRetrieveIfAllowed = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".9");

	public static readonly DerObjectIdentifier IdIsisMttATRequestedCertificate = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".10");

	public static readonly DerObjectIdentifier IdIsisMttATNamingAuthorities = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".11");

	public static readonly DerObjectIdentifier IdIsisMttATCertInDirSince = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".12");

	public static readonly DerObjectIdentifier IdIsisMttATCertHash = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".13");

	public static readonly DerObjectIdentifier IdIsisMttATNameAtBirth = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".14");

	public static readonly DerObjectIdentifier IdIsisMttATAdditionalInformation = new DerObjectIdentifier(IdIsisMttAT?.ToString() + ".15");

	public static readonly DerObjectIdentifier IdIsisMttATLiabilityLimitationFlag = new DerObjectIdentifier("0.2.262.1.10.12.0");
}
