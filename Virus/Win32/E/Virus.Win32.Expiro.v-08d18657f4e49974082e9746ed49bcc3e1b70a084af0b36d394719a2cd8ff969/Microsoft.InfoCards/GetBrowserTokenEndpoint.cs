using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;

namespace Microsoft.InfoCards;

internal class GetBrowserTokenEndpoint
{
	private Uri m_address;

	private Uri m_policyAddress;

	private X509Certificate2Collection m_supportingCertsCollection = new X509Certificate2Collection();

	private X509Certificate2 m_leafCert;

	public Uri Address => m_address;

	public Uri PolicyUrl => m_policyAddress;

	public X509Certificate2Collection SupportingCertificates => m_supportingCertsCollection;

	public X509Certificate2 LeafCertificate => m_leafCert;

	public EndpointAddress CreateEndpointAddress()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		if (null != m_address)
		{
			if (LeafCertificate == null)
			{
				return new EndpointAddress(m_address, (AddressHeader[])(object)new AddressHeader[0]);
			}
			return new EndpointAddress(m_address, EndpointIdentity.CreateX509CertificateIdentity(LeafCertificate, SupportingCertificates), (AddressHeader[])(object)new AddressHeader[0]);
		}
		return null;
	}

	public XmlElement CreateEndpointAddressXml()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if (null != m_address)
		{
			EndpointAddress val = null;
			val = ((LeafCertificate == null) ? new EndpointAddress(m_address, (AddressHeader[])(object)new AddressHeader[0]) : new EndpointAddress(m_address, EndpointIdentity.CreateX509CertificateIdentity(LeafCertificate, SupportingCertificates), (AddressHeader[])(object)new AddressHeader[0]));
			if ((EndpointAddress)null != val)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using XmlWriter xmlWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
					val.WriteTo(AddressingVersion.get_WSAddressing10(), xmlWriter);
					xmlWriter.Flush();
					memoryStream.Flush();
					memoryStream.Seek(0L, SeekOrigin.Begin);
					using XmlReader reader = Utility.CreateReaderWithQuotas(memoryStream);
					XmlDocument xmlDocument = new XmlDocument();
					return (XmlElement)xmlDocument.ReadNode(reader);
				}
			}
		}
		return null;
	}

	public void Load(BinaryReader reader, int paramVersion)
	{
		string text = Utility.DeserializeString(reader);
		if (!string.IsNullOrEmpty(text))
		{
			m_address = new Uri(text);
		}
		text = Utility.DeserializeString(reader);
		if (!string.IsNullOrEmpty(text))
		{
			m_policyAddress = new Uri(text);
		}
		int num = 0;
		if (2 == paramVersion)
		{
			num = reader.ReadInt32();
		}
		else if (1 == paramVersion)
		{
			num = 1;
		}
		for (int i = 0; i < num; i++)
		{
			byte[] array = reader.ReadBytes(reader.ReadInt32());
			if (!Utility.ArrayIsNullOrEmpty(array))
			{
				X509Certificate2 x509Certificate = new X509Certificate2(array);
				if (i == 0)
				{
					m_leafCert = x509Certificate;
				}
				else
				{
					m_supportingCertsCollection.Add(x509Certificate);
				}
			}
		}
	}
}
