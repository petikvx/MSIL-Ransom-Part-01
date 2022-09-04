using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using ns2;
using ns4;

namespace ns3;

internal class Class11 : Class10
{
	private Class18 class18_0;

	private byte[] byte_0;

	public Class11(Class18 class18_1)
	{
		class18_0 = class18_1;
	}

	private void method_5()
	{
		if (byte_0 != null || class18_0.method_2())
		{
			return;
		}
		ulong[] array = class18_0.method_1();
		Dictionary<string, ulong> dictionary = class18_0.method_0();
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter.WriteStartDocument();
		using (new Class16(xmlWriter, "UsageReport"))
		{
			xmlWriter.WriteAttributeString("AssemblyID", "{62DD1A9F-A0BA-42F6-BCA0-534D16BC3C89}".ToUpper());
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
			using (new Class16(xmlWriter, "AssemblyIDs"))
			{
				xmlWriter.WriteAttributeString("Count", "-1");
			}
			using (new Class16(xmlWriter, "Features"))
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] > 0L)
					{
						xmlWriter.WriteStartElement("Feature");
						xmlWriter.WriteAttributeString("Id", i.ToString());
						xmlWriter.WriteAttributeString("Count", array[i].ToString());
						xmlWriter.WriteEndElement();
					}
				}
			}
			using (new Class16(xmlWriter, "DynamicFeatures"))
			{
				foreach (KeyValuePair<string, ulong> item in dictionary)
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
		class18_0 = null;
	}

	public void method_6()
	{
		method_5();
		method_0(byte_0, Class14.class14_0);
	}
}
