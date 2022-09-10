using System;
using System.IO;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class EncryptionUtility
{
	private EncryptionUtility()
	{
	}

	public static XmlElement EncryptSecurityToken(SecurityToken tokenToBeEncrypted, X509Certificate2 cert, string encryptingAlgorithm, string asymmetricKeyWrapAlgorithm, ProtocolProfile profile)
	{
		MemoryStream memoryStream = new MemoryStream();
		XmlDictionaryWriter val = XmlDictionaryWriter.CreateDictionaryWriter((XmlWriter)new XmlTextWriter(new StreamWriter(memoryStream)));
		((SecurityTokenSerializer)profile.TokenSerializer).WriteToken((XmlWriter)(object)val, tokenToBeEncrypted);
		((XmlWriter)(object)val).Flush();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return EncryptToken(memoryStream, cert, encryptingAlgorithm, asymmetricKeyWrapAlgorithm, profile);
	}

	public static XmlElement EncryptSecurityToken(XmlElement elem, X509Certificate2 cert, string encryptingAlgorithm, string asymmetricKeyWrapAlgorithm, ProtocolProfile profile)
	{
		MemoryStream memoryStream = new MemoryStream();
		XmlDictionaryWriter val = XmlDictionaryWriter.CreateDictionaryWriter((XmlWriter)new XmlTextWriter(new StreamWriter(memoryStream)));
		elem.WriteTo((XmlWriter)(object)val);
		((XmlWriter)(object)val).Flush();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return EncryptToken(memoryStream, cert, encryptingAlgorithm, asymmetricKeyWrapAlgorithm, profile);
	}

	private static XmlElement EncryptToken(MemoryStream streamToBeEncrypted, X509Certificate2 cert, string encryptingAlgorithm, string asymmetricKeyWrapAlgorithm, ProtocolProfile profile)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		InfoCardTrace.ThrowInvalidArgumentConditional(string.IsNullOrEmpty(encryptingAlgorithm), "encryptingAlgorithm");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == cert, "cert");
		SecurityToken val = (SecurityToken)new X509SecurityToken(cert, "id");
		SecurityAlgorithmSuite @default = SecurityAlgorithmSuite.get_Default();
		@default = (SecurityAlgorithmSuite)(encryptingAlgorithm switch
		{
			"http://www.w3.org/2001/04/xmlenc#tripledes-cbc" => SecurityAlgorithmSuite.get_TripleDes(), 
			"http://www.w3.org/2001/04/xmlenc#aes256-cbc" => SecurityAlgorithmSuite.get_Basic256(), 
			"http://www.w3.org/2001/04/xmlenc#aes192-cbc" => SecurityAlgorithmSuite.get_Basic192(), 
			"http://www.w3.org/2001/04/xmlenc#aes128-cbc" => SecurityAlgorithmSuite.get_Basic128(), 
			_ => throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("UnsupportedEncryptionAlgorithm", new object[1] { encryptingAlgorithm }))), 
		});
		SecurityKeyIdentifier val2 = new SecurityKeyIdentifier((SecurityKeyIdentifierClause[])(object)new SecurityKeyIdentifierClause[1] { (SecurityKeyIdentifierClause)val.CreateKeyIdentifierClause<X509ThumbprintKeyIdentifierClause>() });
		int num = @default.get_DefaultEncryptionKeyDerivationLength() / 8;
		byte[] array = new byte[num];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		WrappedKeySecurityToken val3 = new WrappedKeySecurityToken(string.Empty, array, asymmetricKeyWrapAlgorithm, val, val2);
		SecurityKeyIdentifier keyIdentifier = new SecurityKeyIdentifier((SecurityKeyIdentifierClause[])(object)new SecurityKeyIdentifierClause[1] { (SecurityKeyIdentifierClause)new EncryptedKeyIdentifierClause(val3.GetWrappedKey(), val3.get_WrappingAlgorithm(), val3.get_WrappingTokenReference()) });
		SymmetricSecurityKey val4 = (SymmetricSecurityKey)((SecurityToken)val3).get_SecurityKeys()[0];
		SymmetricAlgorithm symmetricAlgorithm = val4.GetSymmetricAlgorithm(encryptingAlgorithm);
		EncryptedData encryptedData = new EncryptedData();
		encryptedData.TokenSerializer = (SecurityTokenSerializer)(object)profile.TokenSerializer;
		encryptedData.KeyIdentifier = keyIdentifier;
		encryptedData.EncryptionMethod = encryptingAlgorithm;
		encryptedData.Type = "http://www.w3.org/2001/04/xmlenc#Element";
		encryptedData.SetUpEncryption(symmetricAlgorithm, streamToBeEncrypted.GetBuffer(), 0, Convert.ToInt32(streamToBeEncrypted.Length));
		MemoryStream memoryStream = new MemoryStream();
		XmlDictionaryWriter val5 = XmlDictionaryWriter.CreateDictionaryWriter((XmlWriter)new XmlTextWriter(new StreamWriter(memoryStream)));
		encryptedData.WriteTo((XmlWriter)(object)val5);
		((XmlWriter)(object)val5).Flush();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		XmlDocument xmlDocument = new XmlDocument();
		XmlElement result = (XmlElement)xmlDocument.ReadNode((XmlReader)(object)Utility.CreateReaderWithQuotas(memoryStream));
		Array.Clear(streamToBeEncrypted.GetBuffer(), 0, Convert.ToInt32(streamToBeEncrypted.Length));
		Array.Clear(memoryStream.GetBuffer(), 0, Convert.ToInt32(memoryStream.Length));
		streamToBeEncrypted.Close();
		memoryStream.Close();
		return result;
	}
}
