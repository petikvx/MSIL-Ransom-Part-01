namespace Org.BouncyCastle.Asn1.Eac;

public abstract class EacObjectIdentifiers
{
	public static readonly DerObjectIdentifier bsi_de = new DerObjectIdentifier("0.4.0.127.0.7");

	public static readonly DerObjectIdentifier id_PK = new DerObjectIdentifier(bsi_de?.ToString() + ".2.2.1");

	public static readonly DerObjectIdentifier id_PK_DH = new DerObjectIdentifier(id_PK?.ToString() + ".1");

	public static readonly DerObjectIdentifier id_PK_ECDH = new DerObjectIdentifier(id_PK?.ToString() + ".2");

	public static readonly DerObjectIdentifier id_CA = new DerObjectIdentifier(bsi_de?.ToString() + ".2.2.3");

	public static readonly DerObjectIdentifier id_CA_DH = new DerObjectIdentifier(id_CA?.ToString() + ".1");

	public static readonly DerObjectIdentifier id_CA_DH_3DES_CBC_CBC = new DerObjectIdentifier(id_CA_DH?.ToString() + ".1");

	public static readonly DerObjectIdentifier id_CA_ECDH = new DerObjectIdentifier(id_CA?.ToString() + ".2");

	public static readonly DerObjectIdentifier id_CA_ECDH_3DES_CBC_CBC = new DerObjectIdentifier(id_CA_ECDH?.ToString() + ".1");

	public static readonly DerObjectIdentifier id_TA = new DerObjectIdentifier(bsi_de?.ToString() + ".2.2.2");

	public static readonly DerObjectIdentifier id_TA_RSA = new DerObjectIdentifier(id_TA?.ToString() + ".1");

	public static readonly DerObjectIdentifier id_TA_RSA_v1_5_SHA_1 = new DerObjectIdentifier(id_TA_RSA?.ToString() + ".1");

	public static readonly DerObjectIdentifier id_TA_RSA_v1_5_SHA_256 = new DerObjectIdentifier(id_TA_RSA?.ToString() + ".2");

	public static readonly DerObjectIdentifier id_TA_RSA_PSS_SHA_1 = new DerObjectIdentifier(id_TA_RSA?.ToString() + ".3");

	public static readonly DerObjectIdentifier id_TA_RSA_PSS_SHA_256 = new DerObjectIdentifier(id_TA_RSA?.ToString() + ".4");

	public static readonly DerObjectIdentifier id_TA_ECDSA = new DerObjectIdentifier(id_TA?.ToString() + ".2");

	public static readonly DerObjectIdentifier id_TA_ECDSA_SHA_1 = new DerObjectIdentifier(id_TA_ECDSA?.ToString() + ".1");

	public static readonly DerObjectIdentifier id_TA_ECDSA_SHA_224 = new DerObjectIdentifier(id_TA_ECDSA?.ToString() + ".2");

	public static readonly DerObjectIdentifier id_TA_ECDSA_SHA_256 = new DerObjectIdentifier(id_TA_ECDSA?.ToString() + ".3");

	public static readonly DerObjectIdentifier id_TA_ECDSA_SHA_384 = new DerObjectIdentifier(id_TA_ECDSA?.ToString() + ".4");

	public static readonly DerObjectIdentifier id_TA_ECDSA_SHA_512 = new DerObjectIdentifier(id_TA_ECDSA?.ToString() + ".5");
}
