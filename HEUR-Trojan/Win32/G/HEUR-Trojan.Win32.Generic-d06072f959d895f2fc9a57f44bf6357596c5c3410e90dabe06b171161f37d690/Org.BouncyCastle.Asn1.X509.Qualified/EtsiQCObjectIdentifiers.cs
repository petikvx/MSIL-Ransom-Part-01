namespace Org.BouncyCastle.Asn1.X509.Qualified;

public abstract class EtsiQCObjectIdentifiers
{
	public static readonly DerObjectIdentifier IdEtsiQcs = new DerObjectIdentifier("0.4.0.1862.1");

	public static readonly DerObjectIdentifier IdEtsiQcsQcCompliance = new DerObjectIdentifier(IdEtsiQcs?.ToString() + ".1");

	public static readonly DerObjectIdentifier IdEtsiQcsLimitValue = new DerObjectIdentifier(IdEtsiQcs?.ToString() + ".2");

	public static readonly DerObjectIdentifier IdEtsiQcsRetentionPeriod = new DerObjectIdentifier(IdEtsiQcs?.ToString() + ".3");

	public static readonly DerObjectIdentifier IdEtsiQcsQcSscd = new DerObjectIdentifier(IdEtsiQcs?.ToString() + ".4");
}
