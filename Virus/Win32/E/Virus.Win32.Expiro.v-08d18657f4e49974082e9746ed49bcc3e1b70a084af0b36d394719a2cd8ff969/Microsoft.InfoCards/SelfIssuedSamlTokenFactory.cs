using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SelfIssuedSamlTokenFactory : TokenFactoryBase
{
	private const string SamlAssertionIdPrefix = "SamlSecurityToken-";

	private const string DefaultDigestAlgorithm = "http://www.w3.org/2000/09/xmldsig#sha1";

	public static readonly TimeSpan TokenLifetime = new TimeSpan(1, 0, 0);

	private static readonly SamlSerializer samlSerializer = new SamlSerializer();

	private string m_signatureAlgorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

	private string m_encryptionAlgorithm = SecurityAlgorithmSuite.get_Default().get_DefaultEncryptionAlgorithm();

	private string m_encryptWithAlgorithm;

	private string m_keyWrapAlgorithm;

	protected override TokenDescriptor ProduceToken(InfoCard card, TokenCreationParameter creationParam, TokenFactoryCredential credential, InfoCardPolicy policy, bool discloseOptional)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (!string.IsNullOrEmpty(policy.OptionalRstParams.SignatureAlgorithm))
		{
			m_signatureAlgorithm = policy.OptionalRstParams.SignatureAlgorithm;
		}
		if (!string.IsNullOrEmpty(policy.OptionalRstParams.EncryptionAlgorithm))
		{
			m_encryptionAlgorithm = policy.OptionalRstParams.EncryptionAlgorithm;
		}
		try
		{
			List<InfoCardClaim> claimSet = GetClaimSet(card, policy, discloseOptional);
			List<string> list = new List<string>(claimSet.Count);
			for (int i = 0; i < claimSet.Count; i++)
			{
				list.Add(claimSet[i].Id);
			}
			DisplayToken displayToken;
			XmlElement protectedToken;
			SamlSecurityToken val4;
			using (RSACryptoServiceProvider rSACryptoServiceProvider2 = card.GetPublicCryptography(policy.Recipient.GetIdentifier()))
			{
				SecurityKeyIdentifier issuerKeyIdentifier = new SecurityKeyIdentifier((SecurityKeyIdentifierClause[])(object)new SecurityKeyIdentifierClause[1] { (SecurityKeyIdentifierClause)new RsaKeyIdentifierClause((RSA)rSACryptoServiceProvider2) });
				SecurityKeyIdentifier val3;
				SecurityKey proofCryptoInsideSamlToken;
				if (policy.KeyType == SecurityKeyTypeInternal.SymmetricKey)
				{
					InfoCardTrace.Assert(policy.ImmediateTokenRecipient is X509RecipientIdentity, "Symmetric key type is not allowed when no certifcate is provided for the token recipeint", new object[0]);
					m_keyWrapAlgorithm = SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm();
					InfoCardTrace.Assert("http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p" == m_keyWrapAlgorithm, "What we have chosen", new object[0]);
					if (!string.IsNullOrEmpty(policy.OptionalRstParams.EncryptWith))
					{
						m_encryptWithAlgorithm = policy.OptionalRstParams.EncryptWith;
					}
					else
					{
						m_encryptWithAlgorithm = SecurityAlgorithmSuite.get_Default().get_DefaultEncryptionAlgorithm();
					}
					symmetricAlgorithm = new RijndaelManaged();
					symmetricAlgorithm.KeySize = ((SecurityAlgorithmSuite)(m_encryptWithAlgorithm switch
					{
						"http://www.w3.org/2001/04/xmlenc#tripledes-cbc" => SecurityAlgorithmSuite.get_TripleDes(), 
						"http://www.w3.org/2001/04/xmlenc#aes256-cbc" => SecurityAlgorithmSuite.get_Basic256(), 
						"http://www.w3.org/2001/04/xmlenc#aes192-cbc" => SecurityAlgorithmSuite.get_Basic192(), 
						"http://www.w3.org/2001/04/xmlenc#aes128-cbc" => SecurityAlgorithmSuite.get_Basic128(), 
						_ => throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("UnsupportedEncryptWithAlgorithm", new object[1] { m_encryptWithAlgorithm }))), 
					})).get_DefaultSymmetricKeyLength();
					X509SecurityToken val = new X509SecurityToken(((X509RecipientIdentity)policy.ImmediateTokenRecipient).LeafCertificate, Guid.NewGuid().ToString());
					SecurityKeyIdentifier val2 = new SecurityKeyIdentifier((SecurityKeyIdentifierClause[])(object)new SecurityKeyIdentifierClause[1] { (SecurityKeyIdentifierClause)((SecurityToken)val).CreateKeyIdentifierClause<X509ThumbprintKeyIdentifierClause>() });
					byte[] array = ((SecurityToken)val).get_SecurityKeys()[0].EncryptKey(m_keyWrapAlgorithm, symmetricAlgorithm.Key);
					val3 = new SecurityKeyIdentifier((SecurityKeyIdentifierClause[])(object)new SecurityKeyIdentifierClause[1] { (SecurityKeyIdentifierClause)new EncryptedKeyIdentifierClause(array, m_keyWrapAlgorithm, val2) });
					proofCryptoInsideSamlToken = (SecurityKey)new InMemorySymmetricSecurityKey(symmetricAlgorithm.Key);
					ThrowIfProofKeyOperationsNotSupported(policy, proofCryptoInsideSamlToken);
				}
				else if (SecurityKeyTypeInternal.AsymmetricKey == policy.KeyType)
				{
					if (!string.IsNullOrEmpty(policy.OptionalRstParams.EncryptWith))
					{
						m_encryptWithAlgorithm = policy.OptionalRstParams.EncryptWith;
					}
					else
					{
						m_encryptWithAlgorithm = SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm();
					}
					m_keyWrapAlgorithm = m_encryptWithAlgorithm;
					symmetricAlgorithm = null;
					rSACryptoServiceProvider = rSACryptoServiceProvider2;
					val3 = new SecurityKeyIdentifier((SecurityKeyIdentifierClause[])(object)new SecurityKeyIdentifierClause[1] { (SecurityKeyIdentifierClause)new RsaKeyIdentifierClause((RSA)rSACryptoServiceProvider) });
					proofCryptoInsideSamlToken = val3.CreateKey();
					ThrowIfProofKeyOperationsNotSupported(policy, proofCryptoInsideSamlToken);
				}
				else
				{
					m_keyWrapAlgorithm = SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm();
					InfoCardTrace.Assert("http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p" == m_keyWrapAlgorithm, "What we have chosen", new object[0]);
					InfoCardTrace.Assert(SecurityKeyTypeInternal.NoKey == policy.KeyType, "Bad enum member for SecurityKeyTypeInternal.", new object[0]);
					val3 = null;
					proofCryptoInsideSamlToken = null;
				}
				using SelfIssuedAuthAsymmetricKey issuerSigningKey = new SelfIssuedAuthAsymmetricKey(card.GetPrivateCryptography(policy.Recipient.GetIdentifier()));
				Uri uri = policy.ImmediateTokenRecipient.Address.get_Uri();
				if ((EndpointAddress)null != policy.PolicyAppliesTo)
				{
					uri = policy.PolicyAppliesTo.get_Uri();
				}
				val4 = CreateSamlToken(claimSet, issuerKeyIdentifier, val3, proofCryptoInsideSamlToken, (SecurityKey)(object)issuerSigningKey, uri);
				displayToken = CreateDisplayToken(claimSet);
				if (policy.ImmediateTokenRecipient is X509RecipientIdentity x509RecipientIdentity)
				{
					protectedToken = EncryptionUtility.EncryptSecurityToken((SecurityToken)(object)val4, x509RecipientIdentity.LeafCertificate, m_encryptionAlgorithm, m_keyWrapAlgorithm, policy.ProtocolVersionProfile);
				}
				else
				{
					MemoryStream memoryStream = new MemoryStream();
					XmlDictionaryWriter val5 = XmlDictionaryWriter.CreateDictionaryWriter((XmlWriter)new XmlTextWriter(new StreamWriter(memoryStream)));
					((SecurityTokenSerializer)policy.ProtocolVersionProfile.TokenSerializer).WriteToken((XmlWriter)(object)val5, (SecurityToken)(object)val4);
					((XmlWriter)(object)val5).Flush();
					memoryStream.Seek(0L, SeekOrigin.Begin);
					XmlDocument xmlDocument = new XmlDocument();
					protectedToken = (XmlElement)xmlDocument.ReadNode((XmlReader)(object)Utility.CreateReaderWithQuotas(memoryStream));
					Array.Clear(memoryStream.GetBuffer(), 0, Convert.ToInt32(memoryStream.Length));
					memoryStream.Close();
				}
			}
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			((SecurityTokenSerializer)policy.ProtocolVersionProfile.TokenSerializer).WriteKeyIdentifierClause((XmlWriter)(object)XmlDictionaryWriter.CreateDictionaryWriter((XmlWriter)new XmlTextWriter(stringWriter)), (SecurityKeyIdentifierClause)new SamlAssertionKeyIdentifierClause(((SecurityToken)val4).get_Id()));
			stringWriter.Flush();
			string text = stringWriter.GetStringBuilder().ToString();
			TokenDescriptor result = new TokenDescriptor(((SecurityToken)val4).get_Id(), ((SecurityToken)val4).get_ValidFrom(), ((SecurityToken)val4).get_ValidTo(), protectedToken, displayToken, symmetricAlgorithm, text, text, list);
			symmetricAlgorithm = null;
			val4 = null;
			return result;
		}
		catch (InfoCardBaseException)
		{
			throw;
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(null, ex));
		}
		finally
		{
			if (rSACryptoServiceProvider != null)
			{
				((IDisposable)rSACryptoServiceProvider).Dispose();
				rSACryptoServiceProvider = null;
			}
			if (symmetricAlgorithm != null)
			{
				((IDisposable)symmetricAlgorithm).Dispose();
				symmetricAlgorithm = null;
			}
		}
	}

	private void ThrowIfProofKeyOperationsNotSupported(InfoCardPolicy policy, SecurityKey proofCryptoInsideSamlToken)
	{
		if (!string.IsNullOrEmpty(policy.OptionalRstParams.SignWith) && !proofCryptoInsideSamlToken.IsSupportedAlgorithm(policy.OptionalRstParams.SignWith))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("UnsupportedSignWithAlgorithm", new object[1] { policy.OptionalRstParams.SignWith })));
		}
		if (!proofCryptoInsideSamlToken.IsSupportedAlgorithm(m_encryptWithAlgorithm))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("UnsupportedEncryptWithAlgorithm", new object[1] { m_encryptWithAlgorithm })));
		}
	}

	private SamlSecurityToken CreateSamlToken(List<InfoCardClaim> claims, SecurityKeyIdentifier issuerKeyIdentifier, SecurityKeyIdentifier proofKeyIdentifier, SecurityKey proofCryptoInsideSamlToken, SecurityKey issuerSigningKey, Uri immediateTokenRecipientUri)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		DateTime utcNow = DateTime.UtcNow;
		Collection<Uri> collection = new Collection<Uri>();
		collection.Add(immediateTokenRecipientUri);
		SamlAudienceRestrictionCondition item = new SamlAudienceRestrictionCondition((IEnumerable<Uri>)collection);
		Collection<SamlCondition> collection2 = new Collection<SamlCondition>();
		collection2.Add((SamlCondition)(object)item);
		SamlConditions val = new SamlConditions(utcNow, utcNow.Add(TokenLifetime), (IEnumerable<SamlCondition>)collection2);
		string[] array = new string[1] { (proofKeyIdentifier != null) ? SamlConstants.get_HolderOfKey() : "urn:oasis:names:tc:SAML:1.0:cm:bearer" };
		SamlSubject val2 = new SamlSubject((string)null, (string)null, (string)null, (IEnumerable<string>)array, (string)null, proofKeyIdentifier);
		if (proofCryptoInsideSamlToken != null)
		{
			val2.set_Crypto(proofCryptoInsideSamlToken);
		}
		List<SamlAttribute> list = new List<SamlAttribute>(claims.Count);
		char[] separator = new char[1] { '/' };
		for (int i = 0; i < claims.Count; i++)
		{
			string[] array2 = claims[i].Id.Split(separator);
			InfoCardTrace.ThrowInvalidArgumentConditional(0 == array2.Length, "claimUri");
			string text = array2[^1];
			if (claims[i].Id == InfoCardConstants.Gender)
			{
				InfoCardTrace.Assert(claims[i].Value == "0" || claims[i].Value == "1" || claims[i].Value == "2", "Wrong value type for gender claim, only values '0' (Unspecified), '1' (Male) and '2' (Female) are allowed ", new object[0]);
			}
			if (claims[i].Id == InfoCardConstants.DateOfBirth)
			{
				DateTime dateTime = DateTime.Parse(claims[i].Value, CultureInfo.InvariantCulture).ToUniversalTime();
				InfoCardTrace.Assert(true, "Invalid value for date of birth ", new object[0]);
				list.Add(new SamlAttribute("http://schemas.xmlsoap.org/ws/2005/05/identity/claims", text, (IEnumerable<string>)new string[1] { XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc) }));
			}
			else
			{
				list.Add(new SamlAttribute("http://schemas.xmlsoap.org/ws/2005/05/identity/claims", text, (IEnumerable<string>)new string[1] { claims[i].ToString() }));
			}
		}
		SamlAttributeStatement item2 = new SamlAttributeStatement(val2, (IEnumerable<SamlAttribute>)list);
		List<SamlStatement> list2 = new List<SamlStatement>(1);
		list2.Add((SamlStatement)(object)item2);
		SamlAssertion val3 = new SamlAssertion("SamlSecurityToken-" + Guid.NewGuid(), "http://schemas.xmlsoap.org/ws/2005/05/identity/issuer/self", utcNow, val, (SamlAdvice)null, (IEnumerable<SamlStatement>)list2);
		if (!issuerSigningKey.IsSupportedAlgorithm(m_signatureAlgorithm))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("UnsupportedSignatureAlgorithm", new object[1] { m_signatureAlgorithm })));
		}
		val3.set_SigningCredentials(new SigningCredentials(issuerSigningKey, m_signatureAlgorithm, "http://www.w3.org/2000/09/xmldsig#sha1", issuerKeyIdentifier));
		return new SamlSecurityToken(val3);
	}

	private DisplayToken CreateDisplayToken(List<InfoCardClaim> claims)
	{
		List<DisplayClaim> list = new List<DisplayClaim>();
		for (int i = 0; i < claims.Count; i++)
		{
			List<string> list2 = new List<string>();
			list2.Add(claims[i].Value);
			DisplayClaim item = new DisplayClaim(InfoCardConstants.ClaimDisplayTag(claims[i].Id.ToString()), list2, InfoCardConstants.ClaimsDescription(claims[i].Id.ToString()), claims[i].Id.ToString());
			list.Add(item);
		}
		return new DisplayToken(list);
	}

	private List<InfoCardClaim> GetClaimSet(InfoCard card, InfoCardPolicy policy, bool discloseOptional)
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			List<InfoCardClaim> list = null;
			if (policy.RequiredClaims != null)
			{
				list = new List<InfoCardClaim>(policy.RequiredClaims.Length);
				AddClaimsThatIntersect(policy.RequiredClaims, processingOptionalClaims: false, card.GetClaims(), policy.ImmediateTokenRecipient.GetOrganizationIdentifier(), card.Id, list);
			}
			if (discloseOptional && policy.OptionalClaims != null)
			{
				if (list == null)
				{
					list = new List<InfoCardClaim>(policy.OptionalClaims.Length);
				}
				AddClaimsThatIntersect(policy.OptionalClaims, processingOptionalClaims: true, card.GetClaims(), policy.ImmediateTokenRecipient.GetOrganizationIdentifier(), card.Id, list);
			}
			return list;
		}
		finally
		{
			connection.Close();
		}
	}

	private void AddClaimsThatIntersect(string[] policyClaims, bool processingOptionalClaims, InfoCardClaimCollection claims, string recipientidentifier, Uri cardId, List<InfoCardClaim> intersectedClaims)
	{
		foreach (string text in policyClaims)
		{
			string text2 = text;
			if (text2 == InfoCardConstants.PPIDClaimsUri)
			{
				string value = Utility.CreatePpid(Convert.FromBase64String(recipientidentifier), cardId);
				intersectedClaims.Add(new InfoCardClaim(InfoCardConstants.PPIDClaimsUri, value));
				continue;
			}
			if (!processingOptionalClaims)
			{
				InfoCardTrace.ThrowInvalidArgumentConditional(!claims.ContainsKey(text2) || claims[text2] == null || string.IsNullOrEmpty(claims[text2].Value), "policyClaimUri");
				intersectedClaims.Add(claims[text2]);
				continue;
			}
			InfoCardClaim infoCardClaim = null;
			if (claims.ContainsKey(text2))
			{
				infoCardClaim = claims[text2];
			}
			if (infoCardClaim != null && !string.IsNullOrEmpty(infoCardClaim.Value))
			{
				intersectedClaims.Add(infoCardClaim);
			}
		}
	}
}
