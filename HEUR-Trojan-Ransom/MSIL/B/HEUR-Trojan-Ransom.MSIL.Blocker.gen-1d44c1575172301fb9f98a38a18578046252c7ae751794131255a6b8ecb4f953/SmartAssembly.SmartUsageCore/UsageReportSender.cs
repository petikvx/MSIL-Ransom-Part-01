using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public class UsageReportSender : ReportSender1
{
	private byte[] byte_0;

	public UsageReportSender(UsageCounts usageCounts)
	{
		try
		{
			usageCounts_0 = usageCounts;
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
		Class31 @class = default(Class31);
		DateTime now = default(DateTime);
		Guid guid = default(Guid);
		WindowsIdentity current = default(WindowsIdentity);
		SecurityIdentifier user = default(SecurityIdentifier);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		Guid guid2 = default(Guid);
		string text = default(string);
		Class31 class2 = default(Class31);
		Class31 class3 = default(Class31);
		int i = default(int);
		Class31 class4 = default(Class31);
		Dictionary<string, ulong>.Enumerator enumerator = default(Dictionary<string, ulong>.Enumerator);
		KeyValuePair<string, ulong> current2 = default(KeyValuePair<string, ulong>);
		ulong value = default(ulong);
		try
		{
			usageCounts = usageCounts_0;
			usageCounts_0 = null;
			if (byte_0 != null || usageCounts == null || usageCounts.IsEmpty)
			{
				return;
			}
			staticFeatureCounts = usageCounts.StaticFeatureCounts;
			dynamicFeatureCounts = usageCounts.DynamicFeatureCounts;
			memoryStream = new MemoryStream();
			xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			xmlWriter.WriteStartDocument();
			@class = new Class31(xmlWriter, "UsageReport");
			try
			{
				xmlWriter.WriteAttributeString("AssemblyID", "{5073F953-287E-4137-ADF6-D4C5C7821FA6}".ToUpper());
				XmlWriter xmlWriter2 = xmlWriter;
				now = DateTime.Now;
				xmlWriter2.WriteAttributeString("DateTime", now.ToString("s"));
				XmlWriter xmlWriter3 = xmlWriter;
				guid = Guid.NewGuid();
				xmlWriter3.WriteAttributeString("ReportID", guid.ToString("B"));
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
				xmlWriter.WriteAttributeString("UserID", text);
				class2 = new Class31(xmlWriter, "AssemblyIDs");
				try
				{
					xmlWriter.WriteAttributeString("Count", "-1");
				}
				finally
				{
					((IDisposable)class2)?.Dispose();
				}
				class3 = new Class31(xmlWriter, "Features");
				try
				{
					for (i = 0; i < staticFeatureCounts.Length; i++)
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
				finally
				{
					((IDisposable)class3)?.Dispose();
				}
				class4 = new Class31(xmlWriter, "DynamicFeatures");
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
								xmlWriter.WriteStartElement("Feature");
								xmlWriter.WriteAttributeString("Name", current2.Key);
								XmlWriter xmlWriter4 = xmlWriter;
								value = current2.Value;
								xmlWriter4.WriteAttributeString("Count", value.ToString());
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
				usageCounts_0 = UsageCountStore.GetAllUsageCountsAndReset();
			}
			method_1();
			method_0(byte_0, Class27.class27_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}
}
