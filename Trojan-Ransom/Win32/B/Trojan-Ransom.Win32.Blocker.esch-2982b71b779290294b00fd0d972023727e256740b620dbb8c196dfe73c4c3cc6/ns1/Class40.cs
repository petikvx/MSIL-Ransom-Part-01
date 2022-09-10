using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using ns3;
using ns6;
using ns8;

namespace ns1;

internal sealed class Class40 : Class39
{
	private Class48 class48_0;

	private byte[] byte_0;

	public Class40(Class48 usageCounts)
	{
		class48_0 = usageCounts;
	}

	private void method_5()
	{
		if (byte_0 != null || class48_0.IsEmpty)
		{
			return;
		}
		ulong[] staticFeatureCounts = class48_0.StaticFeatureCounts;
		Dictionary<string, ulong> dynamicFeatureCounts = class48_0.DynamicFeatureCounts;
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter.WriteStartDocument();
		using (new Class46(xmlWriter, "UsageReport"))
		{
			xmlWriter.WriteAttributeString("AssemblyID", "{F0C71864-193B-4207-B969-A15E8EDFFBBB}".ToUpper());
			xmlWriter.WriteAttributeString("DateTime", DateTime.Now.ToString("s"));
			xmlWriter.WriteAttributeString("ReportID", Guid.NewGuid().ToString("B"));
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			SecurityIdentifier user = current.User;
			string value;
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				value = new Guid(mD5CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(user.ToString()))).ToString();
			}
			xmlWriter.WriteAttributeString("UserID", value);
			using (new Class46(xmlWriter, "AssemblyIDs"))
			{
				xmlWriter.WriteAttributeString("Count", "-1");
			}
			using (new Class46(xmlWriter, "Features"))
			{
				for (int i = 0; i < staticFeatureCounts.Length; i++)
				{
					if (staticFeatureCounts[i] > 0L)
					{
						xmlWriter.WriteStartElement("Feature");
						xmlWriter.WriteAttributeString("Id", i.ToString());
						xmlWriter.WriteAttributeString("Count", staticFeatureCounts[i].ToString());
						xmlWriter.WriteEndElement();
					}
				}
			}
			using (new Class46(xmlWriter, "DynamicFeatures"))
			{
				foreach (KeyValuePair<string, ulong> item in dynamicFeatureCounts)
				{
					if (item.Value > 0L)
					{
						xmlWriter.WriteStartElement("Feature");
						xmlWriter.WriteAttributeString("Name", item.Key);
						xmlWriter.WriteAttributeString("Count", item.Value.ToString());
						xmlWriter.WriteEndElement();
					}
				}
			}
		}
		xmlWriter.WriteEndDocument();
		xmlWriter.Flush();
		memoryStream.Flush();
		byte_0 = memoryStream.ToArray();
		class48_0 = null;
	}

	public void method_6()
	{
		method_5();
		method_1(byte_0, Class43.class43_0);
	}
}
