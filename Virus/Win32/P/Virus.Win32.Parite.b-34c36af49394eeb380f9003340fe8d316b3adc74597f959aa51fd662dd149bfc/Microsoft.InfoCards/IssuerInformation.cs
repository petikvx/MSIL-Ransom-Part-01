using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class IssuerInformation
{
	private List<IssuerInformationEntry> m_informationEntries;

	public IssuerInformation()
	{
		m_informationEntries = new List<IssuerInformationEntry>();
	}

	public void Serialize(Stream stream)
	{
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		binaryWriter.Write(m_informationEntries.Count);
		if (m_informationEntries.Count <= 0)
		{
			return;
		}
		foreach (IssuerInformationEntry informationEntry in m_informationEntries)
		{
			Utility.SerializeString(binaryWriter, informationEntry.Name);
			Utility.SerializeString(binaryWriter, informationEntry.Value);
		}
	}

	public void ReadIssuerInformation(XmlReader reader)
	{
		if (!reader.IsStartElement("IssuerInformation", "http://schemas.xmlsoap.org/ws/2007/01/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("UnexpectedElement")));
		}
		while (reader.Read())
		{
			if ("IssuerInformationEntry" == reader.LocalName && "http://schemas.xmlsoap.org/ws/2007/01/identity" == reader.NamespaceURI)
			{
				ReadIssuerInformationEntry(reader);
			}
			if ("IssuerInformation" == reader.LocalName && "http://schemas.xmlsoap.org/ws/2007/01/identity" == reader.NamespaceURI && XmlNodeType.EndElement == reader.NodeType)
			{
				break;
			}
		}
	}

	public void ReadIssuerInformationEntry(XmlReader reader)
	{
		if (!reader.IsStartElement("IssuerInformationEntry", "http://schemas.xmlsoap.org/ws/2007/01/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("UnexpectedElement")));
		}
		string text = string.Empty;
		string value = string.Empty;
		while (true)
		{
			if (!reader.Read())
			{
				return;
			}
			if ("IssuerInformationEntry" == reader.LocalName && "http://schemas.xmlsoap.org/ws/2007/01/identity" == reader.NamespaceURI && XmlNodeType.EndElement == reader.NodeType)
			{
				break;
			}
			if ("EntryName" == reader.LocalName && "http://schemas.xmlsoap.org/ws/2007/01/identity" == reader.NamespaceURI)
			{
				text = reader.ReadString();
				if (string.IsNullOrEmpty(text))
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException());
				}
			}
			if ("EntryValue" == reader.LocalName && "http://schemas.xmlsoap.org/ws/2007/01/identity" == reader.NamespaceURI)
			{
				value = reader.ReadString();
			}
		}
		m_informationEntries.Add(new IssuerInformationEntry(text, value));
	}
}
