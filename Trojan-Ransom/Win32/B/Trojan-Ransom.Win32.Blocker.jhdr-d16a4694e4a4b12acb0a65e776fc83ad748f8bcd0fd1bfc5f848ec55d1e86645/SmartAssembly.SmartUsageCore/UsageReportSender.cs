using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.StringsEncoding;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public class UsageReportSender : ReportSender1
{
	private byte[] byte_0;

	private static bool bool_0;

	internal UsageCounts usageCounts_0;

	public UsageReportSender(UsageCounts usageCounts)
	{
		try
		{
			UsageCounts usageCounts2 = (usageCounts_0 = usageCounts);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, usageCounts);
			throw;
		}
	}

	private void method_1()
	{
		UsageCounts usageCounts = default(UsageCounts);
		ulong[] staticFeatureCounts = default(ulong[]);
		Dictionary<string, ulong> dynamicFeatureCounts = default(Dictionary<string, ulong>);
		MemoryStream memoryStream = default(MemoryStream);
		XmlWriter xmlWriter = default(XmlWriter);
		Class32 @class = default(Class32);
		DateTime now = default(DateTime);
		Guid guid = default(Guid);
		WindowsIdentity current = default(WindowsIdentity);
		SecurityIdentifier user = default(SecurityIdentifier);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		Guid guid2 = default(Guid);
		string text = default(string);
		Class32 class2 = default(Class32);
		Class32 class3 = default(Class32);
		int i = default(int);
		Class32 class4 = default(Class32);
		Dictionary<string, ulong>.Enumerator enumerator = default(Dictionary<string, ulong>.Enumerator);
		KeyValuePair<string, ulong> current2 = default(KeyValuePair<string, ulong>);
		ulong value = default(ulong);
		try
		{
			usageCounts = usageCounts_0;
			UsageCounts usageCounts2 = (usageCounts_0 = null);
			if (byte_0 != null || usageCounts == null || usageCounts.IsEmpty)
			{
				return;
			}
			staticFeatureCounts = usageCounts.StaticFeatureCounts;
			dynamicFeatureCounts = usageCounts.DynamicFeatureCounts;
			memoryStream = new MemoryStream();
			xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			xmlWriter.WriteStartDocument();
			@class = new Class32(xmlWriter, Strings.Get(4930));
			try
			{
				xmlWriter.WriteAttributeString(Strings.Get(2006), Strings.Get(1486).ToUpper());
				XmlWriter xmlWriter2 = xmlWriter;
				string localName = Strings.Get(2023);
				now = DateTime.Now;
				xmlWriter2.WriteAttributeString(localName, now.ToString(Strings.Get(2036)));
				XmlWriter xmlWriter3 = xmlWriter;
				string localName2 = Strings.Get(2050);
				guid = Guid.NewGuid();
				xmlWriter3.WriteAttributeString(localName2, guid.ToString(Strings.Get(1901)));
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
				xmlWriter.WriteAttributeString(Strings.Get(2041), text);
				class2 = new Class32(xmlWriter, Strings.Get(2555));
				try
				{
					xmlWriter.WriteAttributeString(Strings.Get(2546), Strings.Get(4947));
				}
				finally
				{
					((IDisposable)class2)?.Dispose();
				}
				class3 = new Class32(xmlWriter, Strings.Get(4952));
				try
				{
					for (i = 0; i < staticFeatureCounts.Length; i++)
					{
						if (staticFeatureCounts[i] > 0L)
						{
							xmlWriter.WriteStartElement(Strings.Get(4965));
							xmlWriter.WriteAttributeString(Strings.Get(4978), i.ToString());
							xmlWriter.WriteAttributeString(Strings.Get(2546), staticFeatureCounts[i].ToString());
							xmlWriter.WriteEndElement();
						}
					}
				}
				finally
				{
					((IDisposable)class3)?.Dispose();
				}
				class4 = new Class32(xmlWriter, Strings.Get(4983));
				try
				{
					enumerator = dynamicFeatureCounts.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							if (current2.Value > 0L)
							{
								xmlWriter.WriteStartElement(Strings.Get(4965));
								xmlWriter.WriteAttributeString(Strings.Get(1831), current2.Key);
								XmlWriter xmlWriter4 = xmlWriter;
								string localName3 = Strings.Get(2546);
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
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[21]
			{
				usageCounts, staticFeatureCounts, dynamicFeatureCounts, memoryStream, xmlWriter, current, user, text, mD5CryptoServiceProvider, i,
				current2, @class, now, guid, guid2, class2, class3, class4, enumerator, value,
				this
			});
			throw;
		}
	}

	public void SendReport()
	{
		try
		{
			if (usageCounts_0 == null)
			{
				UsageCounts usageCounts = (usageCounts_0 = UsageCountStore.GetAllUsageCountsAndReset());
			}
			method_1();
			method_0(byte_0, Class28.class28_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}
}
