using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public sealed class UsageReportSender : ReportSender1
{
	private UsageCounts m_UsageCounts;

	private byte[] m_ReportData;

	public UsageReportSender(UsageCounts usageCounts)
	{
		try
		{
			m_UsageCounts = usageCounts;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, usageCounts);
			throw;
		}
	}

	private void GenerateReportData()
	{
		UsageCounts usageCounts = default(UsageCounts);
		ulong[] staticFeatureCounts = default(ulong[]);
		Dictionary<string, ulong> dynamicFeatureCounts = default(Dictionary<string, ulong>);
		MemoryStream memoryStream = default(MemoryStream);
		XmlWriter xmlWriter = default(XmlWriter);
		XmlElementSpanner1 xmlElementSpanner = default(XmlElementSpanner1);
		DateTime now = default(DateTime);
		Guid guid = default(Guid);
		WindowsIdentity current = default(WindowsIdentity);
		SecurityIdentifier user = default(SecurityIdentifier);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		Guid guid2 = default(Guid);
		string text = default(string);
		XmlElementSpanner1 xmlElementSpanner2 = default(XmlElementSpanner1);
		XmlElementSpanner1 xmlElementSpanner3 = default(XmlElementSpanner1);
		int i = default(int);
		XmlElementSpanner1 xmlElementSpanner4 = default(XmlElementSpanner1);
		Dictionary<string, ulong>.Enumerator enumerator = default(Dictionary<string, ulong>.Enumerator);
		KeyValuePair<string, ulong> current2 = default(KeyValuePair<string, ulong>);
		ulong value = default(ulong);
		try
		{
			usageCounts = m_UsageCounts;
			m_UsageCounts = null;
			if (m_ReportData != null || usageCounts == null || usageCounts.IsEmpty)
			{
				return;
			}
			staticFeatureCounts = usageCounts.StaticFeatureCounts;
			dynamicFeatureCounts = usageCounts.DynamicFeatureCounts;
			memoryStream = new MemoryStream();
			xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			xmlWriter.WriteStartDocument();
			xmlElementSpanner = new XmlElementSpanner1(xmlWriter, "UsageReport");
			try
			{
				xmlWriter.WriteAttributeString("AssemblyID", "{033897BF-7A25-4E84-A557-884D8EA9E0D8}".ToUpper());
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
				xmlElementSpanner2 = new XmlElementSpanner1(xmlWriter, "AssemblyIDs");
				try
				{
					xmlWriter.WriteAttributeString("Count", "-1");
				}
				finally
				{
					((IDisposable)xmlElementSpanner2)?.Dispose();
				}
				xmlElementSpanner3 = new XmlElementSpanner1(xmlWriter, "Features");
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
					((IDisposable)xmlElementSpanner3)?.Dispose();
				}
				xmlElementSpanner4 = new XmlElementSpanner1(xmlWriter, "DynamicFeatures");
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
					((IDisposable)xmlElementSpanner4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)xmlElementSpanner)?.Dispose();
			}
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			memoryStream.Flush();
			m_ReportData = memoryStream.ToArray();
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[21]
			{
				usageCounts, staticFeatureCounts, dynamicFeatureCounts, memoryStream, xmlWriter, current, user, text, mD5CryptoServiceProvider, i,
				current2, xmlElementSpanner, now, guid, guid2, xmlElementSpanner2, xmlElementSpanner3, xmlElementSpanner4, enumerator, value,
				this
			});
			throw;
		}
	}

	public void SendReport()
	{
		try
		{
			if (m_UsageCounts == null)
			{
				m_UsageCounts = UsageCountStore.GetAllUsageCountsAndReset();
			}
			GenerateReportData();
			SendReport(m_ReportData, NotificationEmailSettings.NullEmailSettings);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}
}
