using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public class UsageReportSender : ReportSender1
{
	private UsageCounts m_UsageCounts;

	private byte[] m_ReportData;

	public UsageReportSender(UsageCounts usageCounts)
	{
		m_UsageCounts = usageCounts;
	}

	private void GenerateReportData()
	{
		UsageCounts usageCounts = m_UsageCounts;
		m_UsageCounts = null;
		if (m_ReportData != null || usageCounts == null || usageCounts.IsEmpty)
		{
			return;
		}
		ulong[] staticFeatureCounts = usageCounts.StaticFeatureCounts;
		Dictionary<string, ulong> dynamicFeatureCounts = usageCounts.DynamicFeatureCounts;
		MemoryStream memoryStream = new MemoryStream();
		XmlWriter xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlWriter.WriteStartDocument();
		using (new XmlElementSpanner1(xmlWriter, "UsageReport"))
		{
			xmlWriter.WriteAttributeString("AssemblyID", "{A8DEB29C-67F1-417A-B4A7-8685485B59D2}".ToUpper());
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
			using (new XmlElementSpanner1(xmlWriter, "AssemblyIDs"))
			{
				xmlWriter.WriteAttributeString("Count", "-1");
			}
			using (new XmlElementSpanner1(xmlWriter, "Features"))
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
			using (new XmlElementSpanner1(xmlWriter, "DynamicFeatures"))
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
		m_ReportData = memoryStream.ToArray();
	}

	public void SendReport()
	{
		if (m_UsageCounts == null)
		{
			m_UsageCounts = UsageCountStore.GetAllUsageCountsAndReset();
		}
		GenerateReportData();
		SendReport(m_ReportData, NotificationEmailSettings.NullEmailSettings);
	}
}
