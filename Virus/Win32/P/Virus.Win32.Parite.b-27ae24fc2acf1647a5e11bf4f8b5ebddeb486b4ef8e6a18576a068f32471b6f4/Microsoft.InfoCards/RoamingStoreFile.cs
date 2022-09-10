using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class RoamingStoreFile
{
	private List<InfoCard> m_infocards;

	public IList<InfoCard> Cards => m_infocards;

	public RoamingStoreFile()
	{
		m_infocards = new List<InfoCard>();
	}

	public void Clear()
	{
		foreach (InfoCard infocard in m_infocards)
		{
			infocard.ClearSensitiveData();
		}
		m_infocards.Clear();
	}

	public void WriteTo(string password, XmlWriter writer)
	{
		byte[] array = null;
		byte[] salt = null;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.OmitXmlDeclaration = true;
			xmlWriterSettings.CloseOutput = false;
			xmlWriterSettings.Encoding = Encoding.UTF8;
			using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings))
			{
				xmlWriter.WriteStartElement("RoamingStore", "http://schemas.xmlsoap.org/ws/2005/05/identity");
				foreach (InfoCard infocard in m_infocards)
				{
					infocard.WriteXml(xmlWriter);
				}
				xmlWriter.WriteEndElement();
				xmlWriter.Flush();
			}
			memoryStream.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			array = new byte[RoamingStoreFileUtility.CalculateEncryptedSize(Convert.ToInt32(memoryStream.Length))];
			using MemoryStream memoryStream2 = new MemoryStream(array);
			RoamingStoreFileUtility.Encrypt(memoryStream, memoryStream2, password, out salt);
			memoryStream2.Flush();
		}
		writer.WriteStartElement("EncryptedStore", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteStartElement("StoreSalt", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteBase64(salt, 0, salt.Length);
		writer.WriteEndElement();
		writer.WriteStartElement("EncryptedData", "http://www.w3.org/2001/04/xmlenc#");
		writer.WriteStartElement("CipherData", "http://www.w3.org/2001/04/xmlenc#");
		writer.WriteStartElement("CipherValue", "http://www.w3.org/2001/04/xmlenc#");
		writer.WriteBase64(array, 0, array.Length);
		writer.WriteEndElement();
		writer.WriteEndElement();
		writer.WriteEndElement();
		writer.WriteEndElement();
	}

	public void ReadFrom(string password, XmlReader reader)
	{
		if (!reader.IsStartElement("EncryptedStore", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
		}
		if (!reader.ReadToDescendant("StoreSalt", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
		}
		byte[] array = new byte[RoamingStoreFileUtility.SaltLength];
		reader.ReadElementContentAsBase64(array, 0, array.Length);
		if (reader.ReadElementContentAsBase64(new byte[1], 0, 1) != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
		}
		if (!reader.IsStartElement("EncryptedData", "http://www.w3.org/2001/04/xmlenc#"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
		}
		if (!reader.ReadToDescendant("CipherData", "http://www.w3.org/2001/04/xmlenc#"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
		}
		if (!reader.ReadToDescendant("CipherValue", "http://www.w3.org/2001/04/xmlenc#"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
		}
		using (MemoryStream memoryStream = new MemoryStream(4096))
		{
			byte[] array2 = new byte[1024];
			int num = 0;
			while ((num = reader.ReadElementContentAsBase64(array2, 0, array2.Length)) > 0)
			{
				memoryStream.Write(array2, 0, num);
			}
			memoryStream.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			using MemoryStream memoryStream2 = new MemoryStream(RoamingStoreFileUtility.CalculateDecryptedSize(Convert.ToInt32(memoryStream.Length)));
			RoamingStoreFileUtility.Decrypt(memoryStream, memoryStream2, password, array);
			memoryStream2.Flush();
			memoryStream2.Seek(0L, SeekOrigin.Begin);
			using XmlReader xmlReader = InfoCardSchemas.CreateReader((Stream)memoryStream2, reader.Settings);
			xmlReader.Read();
			if (!xmlReader.IsStartElement("RoamingStore", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
			}
			if (xmlReader.ReadToDescendant("RoamingInformationCard", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
			{
				do
				{
					InfoCard infoCard = new InfoCard();
					infoCard.ReadXml(xmlReader);
					m_infocards.Add(infoCard);
					xmlReader.ReadEndElement();
				}
				while (xmlReader.IsStartElement("RoamingInformationCard", "http://schemas.xmlsoap.org/ws/2005/05/identity"));
			}
			xmlReader.ReadEndElement();
		}
		reader.ReadEndElement();
		if (reader.IsStartElement("EncryptionProperties", "http://www.w3.org/2001/04/xmlenc#"))
		{
			reader.Skip();
		}
		reader.ReadEndElement();
		reader.ReadEndElement();
	}
}
