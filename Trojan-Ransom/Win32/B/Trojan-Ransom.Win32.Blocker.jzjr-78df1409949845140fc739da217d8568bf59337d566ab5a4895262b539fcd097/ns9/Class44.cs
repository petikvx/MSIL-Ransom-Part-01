using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using ns6;
using ns7;
using ns8;

namespace ns9;

internal sealed class Class44 : Class43
{
	private Class52 class52_0;

	private byte[] byte_0;

	public Class44(Class52 usageCounts)
	{
		class52_0 = usageCounts;
	}

	private unsafe void method_5()
	{
		void* ptr = stackalloc byte[12];
		Class52 @class = class52_0;
		class52_0 = null;
		if (byte_0 != null || @class == null || @class.IsEmpty)
		{
			return;
		}
		ulong[] staticFeatureCounts = @class.StaticFeatureCounts;
		Dictionary<string, ulong> dynamicFeatureCounts = @class.DynamicFeatureCounts;
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter.WriteStartDocument();
		using (new Class50(xmlWriter, "UsageReport"))
		{
			xmlWriter.WriteAttributeString("AssemblyID", "{CA3D9371-DEE3-452C-95B3-67B91E478690}".ToUpper());
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
			using (new Class50(xmlWriter, "AssemblyIDs"))
			{
				xmlWriter.WriteAttributeString("Count", "-1");
			}
			using (new Class50(xmlWriter, "Features"))
			{
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < staticFeatureCounts.Length)
				{
					if (staticFeatureCounts[*(int*)((byte*)ptr + 8)] > 0L)
					{
						xmlWriter.WriteStartElement("Feature");
						xmlWriter.WriteAttributeString("Id", ((int*)((byte*)ptr + 8))->ToString());
						xmlWriter.WriteAttributeString("Count", staticFeatureCounts[*(int*)((byte*)ptr + 8)].ToString());
						xmlWriter.WriteEndElement();
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			using (new Class50(xmlWriter, "DynamicFeatures"))
			{
				foreach (KeyValuePair<string, ulong> item in dynamicFeatureCounts)
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

	public void method_6()
	{
		if (class52_0 == null)
		{
			class52_0 = Class53.smethod_9();
		}
		method_5();
		method_1(byte_0, Class47.class47_0);
	}
}
