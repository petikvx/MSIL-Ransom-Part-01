using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using ns2;
using ns3;
using ns8;
using ns9;

namespace ns7;

internal sealed class Class48 : Class47
{
	private Class55 class55_0;

	private byte[] byte_0;

	public Class48(Class55 class55_1)
	{
		try
		{
			class55_0 = class55_1;
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, this, class55_1);
			throw;
		}
	}

	private void method_5()
	{
		ulong[] array = default(ulong[]);
		Dictionary<string, ulong> dictionary = default(Dictionary<string, ulong>);
		MemoryStream memoryStream = default(MemoryStream);
		XmlWriter xmlWriter = default(XmlWriter);
		Class53 @class = default(Class53);
		DateTime now = default(DateTime);
		Guid guid = default(Guid);
		WindowsIdentity current = default(WindowsIdentity);
		SecurityIdentifier user = default(SecurityIdentifier);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		Guid guid2 = default(Guid);
		string text = default(string);
		Class53 class2 = default(Class53);
		Class53 class3 = default(Class53);
		int i = default(int);
		Class53 class4 = default(Class53);
		Dictionary<string, ulong>.Enumerator enumerator = default(Dictionary<string, ulong>.Enumerator);
		KeyValuePair<string, ulong> current2 = default(KeyValuePair<string, ulong>);
		ulong value = default(ulong);
		try
		{
			if (byte_0 != null || class55_0.method_2())
			{
				return;
			}
			array = class55_0.method_1();
			dictionary = class55_0.method_0();
			memoryStream = new MemoryStream();
			xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			xmlWriter.WriteStartDocument();
			@class = new Class53(xmlWriter, Class15.smethod_0(955567));
			try
			{
				xmlWriter.WriteAttributeString(Class15.smethod_0(950487), Class15.smethod_0(949967).ToUpper());
				XmlWriter xmlWriter2 = xmlWriter;
				string localName = Class15.smethod_0(950504);
				now = DateTime.Now;
				xmlWriter2.WriteAttributeString(localName, now.ToString(Class15.smethod_0(950517)));
				XmlWriter xmlWriter3 = xmlWriter;
				string localName2 = Class15.smethod_0(950531);
				guid = Guid.NewGuid();
				xmlWriter3.WriteAttributeString(localName2, guid.ToString(Class15.smethod_0(950382)));
				current = WindowsIdentity.GetCurrent();
				user = current.User;
				mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				try
				{
					guid2 = new Guid(mD5CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(user.ToString())));
					text = guid2.ToString();
				}
				finally
				{
					((IDisposable)mD5CryptoServiceProvider)?.Dispose();
				}
				xmlWriter.WriteAttributeString(Class15.smethod_0(950522), text);
				class2 = new Class53(xmlWriter, Class15.smethod_0(951036));
				try
				{
					xmlWriter.WriteAttributeString(Class15.smethod_0(951027), Class15.smethod_0(955584));
				}
				finally
				{
					((IDisposable)class2)?.Dispose();
				}
				class3 = new Class53(xmlWriter, Class15.smethod_0(955589));
				try
				{
					for (i = 0; i < array.Length; i++)
					{
						if (array[i] > 0L)
						{
							xmlWriter.WriteStartElement(Class15.smethod_0(955602));
							xmlWriter.WriteAttributeString(Class15.smethod_0(955615), i.ToString());
							xmlWriter.WriteAttributeString(Class15.smethod_0(951027), array[i].ToString());
							xmlWriter.WriteEndElement();
						}
					}
				}
				finally
				{
					((IDisposable)class3)?.Dispose();
				}
				class4 = new Class53(xmlWriter, Class15.smethod_0(955620));
				try
				{
					enumerator = dictionary.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							if (current2.Value > 0L)
							{
								xmlWriter.WriteStartElement(Class15.smethod_0(955602));
								xmlWriter.WriteAttributeString(Class15.smethod_0(950312), current2.Key);
								XmlWriter xmlWriter4 = xmlWriter;
								string localName3 = Class15.smethod_0(951027);
								value = current2.Value;
								xmlWriter4.WriteAttributeString(localName3, value.ToString());
								xmlWriter.WriteEndElement();
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				finally
				{
					((IDisposable)class4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)@class)?.Dispose();
			}
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			memoryStream.Flush();
			byte_0 = memoryStream.ToArray();
			class55_0 = null;
		}
		catch (Exception exception_)
		{
			Class38.smethod_11(exception_, new object[20]
			{
				array, dictionary, memoryStream, xmlWriter, current, user, text, mD5CryptoServiceProvider, i, current2,
				@class, now, guid, guid2, class2, class3, class4, enumerator, value, this
			});
			throw;
		}
	}

	public void method_6()
	{
		try
		{
			if (class55_0 == null)
			{
				class55_0 = Class56.smethod_8();
			}
			method_5();
			method_0(byte_0, Class51.class51_0);
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}
}
