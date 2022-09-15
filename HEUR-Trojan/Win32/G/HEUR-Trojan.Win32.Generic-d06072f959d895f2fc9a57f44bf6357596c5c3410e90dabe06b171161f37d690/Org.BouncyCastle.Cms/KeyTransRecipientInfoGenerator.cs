using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms;

public class KeyTransRecipientInfoGenerator : RecipientInfoGenerator
{
	private static readonly CmsEnvelopedHelper Helper = CmsEnvelopedHelper.Instance;

	private Asn1OctetString subjectKeyIdentifier;

	private IKeyWrapper keyWrapper;

	private SubjectPublicKeyInfo info;

	private IssuerAndSerialNumber issuerAndSerialNumber;

	private SecureRandom random;

	protected virtual AlgorithmIdentifier AlgorithmDetails
	{
		get
		{
			if (keyWrapper != null)
			{
				return (AlgorithmIdentifier)keyWrapper.AlgorithmDetails;
			}
			return info.AlgorithmID;
		}
	}

	public KeyTransRecipientInfoGenerator(X509Certificate recipCert, IKeyWrapper keyWrapper)
		: this(new IssuerAndSerialNumber(recipCert.IssuerDN, new DerInteger(recipCert.SerialNumber)), keyWrapper)
	{
	}

	public KeyTransRecipientInfoGenerator(IssuerAndSerialNumber issuerAndSerial, IKeyWrapper keyWrapper)
	{
		issuerAndSerialNumber = issuerAndSerial;
		this.keyWrapper = keyWrapper;
	}

	public KeyTransRecipientInfoGenerator(byte[] subjectKeyID, IKeyWrapper keyWrapper)
	{
		subjectKeyIdentifier = new DerOctetString(subjectKeyIdentifier);
		this.keyWrapper = keyWrapper;
	}

	public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
	{
		AlgorithmIdentifier algorithmDetails = AlgorithmDetails;
		this.random = random;
		byte[] str = GenerateWrappedKey(contentEncryptionKey);
		RecipientIdentifier rid = ((issuerAndSerialNumber == null) ? new RecipientIdentifier(subjectKeyIdentifier) : new RecipientIdentifier(issuerAndSerialNumber));
		return new RecipientInfo(new KeyTransRecipientInfo(rid, algorithmDetails, new DerOctetString(str)));
	}

	protected virtual byte[] GenerateWrappedKey(KeyParameter contentEncryptionKey)
	{
		return keyWrapper.Wrap(contentEncryptionKey.GetKey()).Collect();
	}
}
