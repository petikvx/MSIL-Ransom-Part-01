using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using ns1;
using ns5;
using ns7;

namespace ns3;

internal class Class33 : Class32
{
	internal Class40 class40_0;

	internal byte[] byte_0;

	public Class33(Class40 class40_1)
	{
		class40_0 = class40_1;
	}

	internal unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		Class40 @class = class40_0;
		class40_0 = null;
		if (byte_0 != null || @class == null || Class24.smethod_178(@class))
		{
			return;
		}
		ulong[] array = Class24.smethod_80(@class);
		Dictionary<string, ulong> dictionary = Class24.smethod_126(@class);
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter.WriteStartDocument();
		using (new Class38(xmlWriter, "UsageReport"))
		{
			xmlWriter.WriteAttributeString("AssemblyID", "{FDC54A6F-5294-4961-88B8-331D8BE2D74A}".ToUpper());
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
			using (new Class38(xmlWriter, "AssemblyIDs"))
			{
				xmlWriter.WriteAttributeString("Count", "-1");
			}
			using (new Class38(xmlWriter, "Features"))
			{
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < array.Length)
				{
					if (array[*(int*)((byte*)ptr + 8)] > 0L)
					{
						xmlWriter.WriteStartElement("Feature");
						xmlWriter.WriteAttributeString("Id", ((int*)((byte*)ptr + 8))->ToString());
						xmlWriter.WriteAttributeString("Count", array[*(int*)((byte*)ptr + 8)].ToString());
						xmlWriter.WriteEndElement();
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			using (new Class38(xmlWriter, "DynamicFeatures"))
			{
				foreach (KeyValuePair<string, ulong> item in dictionary)
				{
					if (item.Value > 0L)
					{
						xmlWriter.WriteStartElement("Feature");
						xmlWriter.WriteAttributeString("Name", item.Key);
						*(ulong*)ptr = item.Value;
						xmlWriter.WriteAttributeString("Count", ((ulong*)ptr)->ToString());
						xmlWriter.WriteEndElement();
					}
				}
			}
		}
		xmlWriter.WriteEndDocument();
		xmlWriter.Flush();
		memoryStream.Flush();
		byte_0 = memoryStream.ToArray();
	}
}
