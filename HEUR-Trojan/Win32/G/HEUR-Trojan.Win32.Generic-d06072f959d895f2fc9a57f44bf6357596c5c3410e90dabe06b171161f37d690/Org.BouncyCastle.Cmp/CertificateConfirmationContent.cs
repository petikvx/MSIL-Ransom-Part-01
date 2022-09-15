using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Cms;

namespace Org.BouncyCastle.Cmp;

public class CertificateConfirmationContent
{
	private readonly DefaultDigestAlgorithmIdentifierFinder digestAlgFinder;

	private readonly CertConfirmContent content;

	public CertificateConfirmationContent(CertConfirmContent content)
	{
		this.content = content;
	}

	public CertificateConfirmationContent(CertConfirmContent content, DefaultDigestAlgorithmIdentifierFinder digestAlgFinder)
	{
		this.content = content;
		this.digestAlgFinder = digestAlgFinder;
	}

	public CertConfirmContent ToAsn1Structure()
	{
		return content;
	}

	public CertificateStatus[] GetStatusMessages()
	{
		CertStatus[] array = content.ToCertStatusArray();
		CertificateStatus[] array2 = new CertificateStatus[array.Length];
		for (int i = 0; i != array2.Length; i++)
		{
			array2[i] = new CertificateStatus(digestAlgFinder, array[i]);
		}
		return array2;
	}
}
