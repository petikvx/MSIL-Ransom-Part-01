using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public class UsageReportSender : ReportSender1
{
	internal UsageCounts usageCounts_0;

	internal byte[] byte_1;

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
		ulong[] staticFeatureCounts = default(ulong[]);
		Dictionary<string, ulong> dynamicFeatureCounts = default(Dictionary<string, ulong>);
		MemoryStream memoryStream = default(MemoryStream);
		XmlWriter xmlWriter = default(XmlWriter);
		Class32 @class = default(Class32);
		DateTime dateTime = default(DateTime);
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
			if (byte_1 != null || usageCounts_0.IsEmpty)
			{
				return;
			}
			staticFeatureCounts = usageCounts_0.StaticFeatureCounts;
			dynamicFeatureCounts = usageCounts_0.DynamicFeatureCounts;
			memoryStream = new MemoryStream();
			xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			DoNotObfuscateAttribute.smethod_0(xmlWriter, 468, 414);
			@class = new Class32(xmlWriter, "UsageReport");
			try
			{
				xmlWriter.WriteAttributeString("AssemblyID", "{E8999F69-FF1B-4846-9283-897940EB0660}".ToUpper());
				XmlWriter xmlWriter2 = xmlWriter;
				dateTime = HeaderControl.smethod_2(120, 34);
				xmlWriter2.WriteAttributeString("DateTime", dateTime.ToString("s"));
				XmlWriter xmlWriter3 = xmlWriter;
				guid = Guid.NewGuid();
				xmlWriter3.WriteAttributeString("ReportID", guid.ToString("B"));
				current = WindowsIdentity.GetCurrent();
				user = current.User;
				mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				try
				{
					guid2 = new Guid(mD5CryptoServiceProvider.ComputeHash(Win32.smethod_12(Encoding.Unicode, WaitSendingReportControl.smethod_4(user, 211, 152), 437, 475)));
					text = guid2.ToString();
				}
				finally
				{
					((IDisposable)mD5CryptoServiceProvider)?.Dispose();
				}
				xmlWriter.WriteAttributeString("UserID", text);
				class2 = new Class32(xmlWriter, "AssemblyIDs");
				try
				{
					xmlWriter.WriteAttributeString("Count", "-1");
				}
				finally
				{
					((IDisposable)class2)?.Dispose();
				}
				class3 = new Class32(xmlWriter, "Features");
				try
				{
					for (i = 0; i < staticFeatureCounts.Length; i++)
					{
						if (staticFeatureCounts[i] > 0L)
						{
							ReportUsageAttribute.smethod_1(xmlWriter, "Feature", 532, 632);
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
				class4 = new Class32(xmlWriter, "DynamicFeatures");
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
								ReportUsageAttribute.smethod_1(xmlWriter, "Feature", 812, 832);
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
			DoNotPruneAttribute.smethod_2(memoryStream, 378, 269);
			byte[] array = (byte_1 = Class37.smethod_5(memoryStream, 246, 230));
			UsageCounts usageCounts = (usageCounts_0 = null);
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[20]
			{
				staticFeatureCounts, dynamicFeatureCounts, memoryStream, xmlWriter, current, user, text, mD5CryptoServiceProvider, i, current2,
				@class, dateTime, guid, guid2, class2, class3, class4, enumerator, value, this
			});
			throw;
		}
	}

	public void SendReport()
	{
		try
		{
			method_1();
			method_0(byte_1, Class28.class28_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static UsageReportSender()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static int smethod_2(ref Rectangle rectangle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 112:
				return rectangle_0.Left;
			}
		}
	}

	internal static string smethod_3(ref ushort ushort_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return ushort_0.ToString(string_1);
			}
		}
	}

	internal static Color smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return SystemColors.Window;
			}
		}
	}

	internal static object[] smethod_5(MemberInfo memberInfo_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				return memberInfo_0.GetCustomAttributes(bool_0);
			}
		}
	}
}
