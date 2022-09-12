using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;
using ns2;
using ns4;
using ns7;
using ns8;

namespace ns5;

internal sealed class Class49 : Class48
{
	private Class42 class42_0;

	private byte[] byte_0;

	[NonSerialized]
	internal static GetString getString_1;

	public Class49(Class42 class42_1)
	{
		class42_0 = class42_1;
	}

	private unsafe void method_5()
	{
		void* ptr = stackalloc byte[12];
		Class42 @class = class42_0;
		class42_0 = null;
		if (byte_0 != null || @class == null || @class.method_2())
		{
			return;
		}
		ulong[] array = @class.method_1();
		Dictionary<string, ulong> dictionary = @class.method_0();
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter.WriteStartDocument();
		using (new Class54(xmlWriter, getString_1(107384622)))
		{
			xmlWriter.WriteAttributeString(getString_1(107390152), getString_1(107390167).ToUpper());
			xmlWriter.WriteAttributeString(getString_1(107390114), DateTime.Now.ToString(getString_1(107395566)));
			xmlWriter.WriteAttributeString(getString_1(107389548), Guid.NewGuid().ToString(getString_1(107395483)));
			string s = Class11.smethod_0();
			string value;
			using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
			{
				value = new Guid(mD5CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(s))).ToString();
			}
			xmlWriter.WriteAttributeString(getString_1(107390101), value);
			using (new Class54(xmlWriter, getString_1(107389059)))
			{
				xmlWriter.WriteAttributeString(getString_1(107389036), getString_1(107384637));
			}
			using (new Class54(xmlWriter, getString_1(107384632)))
			{
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < array.Length)
				{
					if (array[*(int*)((byte*)ptr + 8)] > 0L)
					{
						xmlWriter.WriteStartElement(getString_1(107384587));
						xmlWriter.WriteAttributeString(getString_1(107384606), ((int*)((byte*)ptr + 8))->ToString());
						xmlWriter.WriteAttributeString(getString_1(107389036), array[*(int*)((byte*)ptr + 8)].ToString());
						xmlWriter.WriteEndElement();
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			using (new Class54(xmlWriter, getString_1(107384601)))
			{
				foreach (KeyValuePair<string, ulong> item in dictionary)
				{
					if (item.Value > 0L)
					{
						xmlWriter.WriteStartElement(getString_1(107384587));
						xmlWriter.WriteAttributeString(getString_1(107390312), item.Key);
						string localName = getString_1(107389036);
						*(ulong*)ptr = item.Value;
						xmlWriter.WriteAttributeString(localName, ((ulong*)ptr)->ToString());
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
		if (class42_0 == null)
		{
			class42_0 = Class43.smethod_8();
		}
		method_5();
		method_0(byte_0, Class52.class52_0);
	}

	static Class49()
	{
		Strings.CreateGetStringDelegate(typeof(Class49));
	}
}
