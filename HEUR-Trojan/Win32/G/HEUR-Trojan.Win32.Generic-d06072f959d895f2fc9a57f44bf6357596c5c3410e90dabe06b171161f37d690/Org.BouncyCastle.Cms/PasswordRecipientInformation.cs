using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms;

public class PasswordRecipientInformation : RecipientInformation
{
	private readonly PasswordRecipientInfo info;

	public virtual AlgorithmIdentifier KeyDerivationAlgorithm => info.KeyDerivationAlgorithm;

	internal PasswordRecipientInformation(PasswordRecipientInfo info, CmsSecureReadable secureReadable)
		: base(info.KeyEncryptionAlgorithm, secureReadable)
	{
		this.info = info;
		rid = new RecipientID();
	}

	public override CmsTypedStream GetContentStream(ICipherParameters key)
	{
		try
		{
			Asn1Sequence obj = (Asn1Sequence)AlgorithmIdentifier.GetInstance(info.KeyEncryptionAlgorithm).Parameters;
			byte[] octets = info.EncryptedKey.GetOctets();
			string id = DerObjectIdentifier.GetInstance(obj[0]).Id;
			IWrapper wrapper = WrapperUtilities.GetWrapper(CmsEnvelopedHelper.Instance.GetRfc3211WrapperName(id));
			byte[] octets2 = Asn1OctetString.GetInstance(obj[1]).GetOctets();
			ICipherParameters encoded = ((CmsPbeKey)key).GetEncoded(id);
			encoded = new ParametersWithIV(encoded, octets2);
			wrapper.Init(forWrapping: false, encoded);
			KeyParameter sKey = ParameterUtilities.CreateKeyParameter(GetContentAlgorithmName(), wrapper.Unwrap(octets, 0, octets.Length));
			return GetContentFromSessionKey(sKey);
		}
		catch (SecurityUtilityException e)
		{
			throw new CmsException("couldn't create cipher.", e);
		}
		catch (InvalidKeyException e2)
		{
			throw new CmsException("key invalid in message.", e2);
		}
	}
}
