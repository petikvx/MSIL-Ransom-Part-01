using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class EncryptedData
{
	private struct CipherData
	{
		private byte[] m_iv;

		private byte[] m_cipherText;

		public byte[] CipherValue => m_cipherText;

		public void SetCipherValueFragments(byte[] iv, byte[] cipherText)
		{
			m_iv = iv;
			m_cipherText = cipherText;
		}

		public void WriteTo(XmlWriter writer)
		{
			writer.WriteStartElement("enc", "CipherData", "http://www.w3.org/2001/04/xmlenc#");
			writer.WriteStartElement("enc", "CipherValue", "http://www.w3.org/2001/04/xmlenc#");
			if (m_iv != null)
			{
				writer.WriteBase64(m_iv, 0, m_iv.Length);
			}
			writer.WriteBase64(m_cipherText, 0, m_cipherText.Length);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}
	}

	private struct EncryptionMethodElement
	{
		internal string algorithm;

		public void WriteTo(XmlWriter writer)
		{
			writer.WriteStartElement("enc", "EncryptionMethod", "http://www.w3.org/2001/04/xmlenc#");
			writer.WriteAttributeString("Algorithm", null, algorithm);
			writer.WriteEndElement();
		}
	}

	private string m_type;

	private EncryptionMethodElement m_encryptionMethod;

	private CipherData m_cipherData;

	private SecurityKeyIdentifier m_keyIdentifier;

	private SecurityTokenSerializer m_tokenSerializer;

	public string EncryptionMethod
	{
		set
		{
			m_encryptionMethod.algorithm = value;
		}
	}

	public SecurityKeyIdentifier KeyIdentifier
	{
		set
		{
			m_keyIdentifier = value;
		}
	}

	public string Type
	{
		set
		{
			m_type = value;
		}
	}

	public SecurityTokenSerializer TokenSerializer
	{
		set
		{
			m_tokenSerializer = value;
		}
	}

	public EncryptedData()
	{
		m_cipherData = default(CipherData);
		m_encryptionMethod = default(EncryptionMethodElement);
	}

	public void SetUpEncryption(SymmetricAlgorithm algorithm, byte[] buffer, int offset, int length)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(null == algorithm, "algorithm");
		GenerateIVAndEncrypt(algorithm, buffer, offset, length, out var iv, out var cipherText);
		m_cipherData.SetCipherValueFragments(iv, cipherText);
	}

	public void WriteTo(XmlWriter writer)
	{
		writer.WriteStartElement("enc", "EncryptedData", "http://www.w3.org/2001/04/xmlenc#");
		if (!string.IsNullOrEmpty(m_type))
		{
			writer.WriteAttributeString("Type", null, m_type);
		}
		if (!string.IsNullOrEmpty(m_encryptionMethod.algorithm))
		{
			m_encryptionMethod.WriteTo(writer);
		}
		if (m_keyIdentifier != null)
		{
			m_tokenSerializer.WriteKeyIdentifier((XmlWriter)(object)XmlDictionaryWriter.CreateDictionaryWriter(writer), m_keyIdentifier);
		}
		m_cipherData.WriteTo(writer);
		writer.WriteEndElement();
	}

	private void GenerateIVAndEncrypt(SymmetricAlgorithm algorithm, byte[] plainText, int offset, int length, out byte[] iv, out byte[] cipherText)
	{
		RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		int num = algorithm.BlockSize / 8;
		iv = new byte[num];
		randomNumberGenerator.GetBytes(iv);
		algorithm.Padding = PaddingMode.PKCS7;
		algorithm.Mode = CipherMode.CBC;
		using ICryptoTransform cryptoTransform = algorithm.CreateEncryptor(algorithm.Key, iv);
		cipherText = cryptoTransform.TransformFinalBlock(plainText, offset, length);
	}
}
