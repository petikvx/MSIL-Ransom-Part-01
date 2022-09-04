using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;

public class GClass7 : GClass6
{
	private GClass8 gclass8_0;

	private byte[] byte_0;

	public GClass7(GClass8 gclass8_1)
	{
		gclass8_0 = gclass8_1;
	}

	private void method_5()
	{
		GClass8 gClass = gclass8_0;
		gclass8_0 = null;
		if (byte_0 != null || gClass == null || gClass.IsEmpty)
		{
			return;
		}
		ulong[] staticFeatureCounts = gClass.StaticFeatureCounts;
		Dictionary<string, ulong> dynamicFeatureCounts = gClass.DynamicFeatureCounts;
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter.WriteStartDocument();
		using (new Class25(xmlWriter, GClass4.smethod_0(2034)))
		{
			xmlWriter.WriteAttributeString(GClass4.smethod_0(2051), GClass4.smethod_0(965).ToUpper());
			xmlWriter.WriteAttributeString(GClass4.smethod_0(2068), DateTime.Now.ToString(GClass4.smethod_0(2081)));
			xmlWriter.WriteAttributeString(GClass4.smethod_0(2086), Guid.NewGuid().ToString(GClass4.smethod_0(2099)));
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			SecurityIdentifier user = current.User;
			string value;
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				value = new Guid(mD5CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(user.ToString()))).ToString();
			}
			xmlWriter.WriteAttributeString(GClass4.smethod_0(2104), value);
			using (new Class25(xmlWriter, GClass4.smethod_0(2113)))
			{
				xmlWriter.WriteAttributeString(GClass4.smethod_0(2130), GClass4.smethod_0(2139));
			}
			using (new Class25(xmlWriter, GClass4.smethod_0(2144)))
			{
				for (int i = 0; i < staticFeatureCounts.Length; i++)
				{
					if (staticFeatureCounts[i] > 0L)
					{
						xmlWriter.WriteStartElement(GClass4.smethod_0(2157));
						xmlWriter.WriteAttributeString(GClass4.smethod_0(2170), i.ToString());
						xmlWriter.WriteAttributeString(GClass4.smethod_0(2130), staticFeatureCounts[i].ToString());
						xmlWriter.WriteEndElement();
					}
				}
			}
			using (new Class25(xmlWriter, GClass4.smethod_0(2175)))
			{
				foreach (KeyValuePair<string, ulong> item in dynamicFeatureCounts)
				{
					if (item.Value > 0L)
					{
						xmlWriter.WriteStartElement(GClass4.smethod_0(2157));
						xmlWriter.WriteAttributeString(GClass4.smethod_0(2196), item.Key);
						xmlWriter.WriteAttributeString(GClass4.smethod_0(2130), item.Value.ToString());
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
		if (gclass8_0 == null)
		{
			gclass8_0 = GClass9.smethod_8();
		}
		method_5();
		method_1(byte_0, Class21.class21_0);
	}
}
