using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms;

public class OriginatorInfoGenerator
{
	private readonly IList origCerts;

	private readonly IList origCrls;

	public OriginatorInfoGenerator(X509Certificate origCert)
	{
		origCerts = Platform.CreateArrayList(1);
		origCrls = null;
		origCerts.Add(origCert.CertificateStructure);
	}

	public OriginatorInfoGenerator(IX509Store origCerts)
		: this(origCerts, null)
	{
	}

	public OriginatorInfoGenerator(IX509Store origCerts, IX509Store origCrls)
	{
		this.origCerts = CmsUtilities.GetCertificatesFromStore(origCerts);
		this.origCrls = ((origCrls == null) ? null : CmsUtilities.GetCrlsFromStore(origCrls));
	}

	public virtual OriginatorInfo Generate()
	{
		Asn1Set certs = CmsUtilities.CreateDerSetFromList(origCerts);
		Asn1Set crls = ((origCrls == null) ? null : CmsUtilities.CreateDerSetFromList(origCrls));
		return new OriginatorInfo(certs, crls);
	}
}
