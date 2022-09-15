namespace Org.BouncyCastle.Asn1.X509.SigI;

public sealed class SigIObjectIdentifiers
{
	public static readonly DerObjectIdentifier IdSigI = new DerObjectIdentifier("1.3.36.8");

	public static readonly DerObjectIdentifier IdSigIKP = new DerObjectIdentifier(IdSigI?.ToString() + ".2");

	public static readonly DerObjectIdentifier IdSigICP = new DerObjectIdentifier(IdSigI?.ToString() + ".1");

	public static readonly DerObjectIdentifier IdSigION = new DerObjectIdentifier(IdSigI?.ToString() + ".4");

	public static readonly DerObjectIdentifier IdSigIKPDirectoryService = new DerObjectIdentifier(IdSigIKP?.ToString() + ".1");

	public static readonly DerObjectIdentifier IdSigIONPersonalData = new DerObjectIdentifier(IdSigION?.ToString() + ".1");

	public static readonly DerObjectIdentifier IdSigICPSigConform = new DerObjectIdentifier(IdSigICP?.ToString() + ".1");

	private SigIObjectIdentifiers()
	{
	}
}
