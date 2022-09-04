using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;
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
		UsageCounts usageCounts = default(UsageCounts);
		ulong[] staticFeatureCounts = default(ulong[]);
		Dictionary<string, ulong> dynamicFeatureCounts = default(Dictionary<string, ulong>);
		MemoryStream memoryStream = default(MemoryStream);
		XmlWriter xmlWriter = default(XmlWriter);
		Class34 @class = default(Class34);
		DateTime dateTime_ = default(DateTime);
		Guid guid_ = default(Guid);
		WindowsIdentity current = default(WindowsIdentity);
		SecurityIdentifier user = default(SecurityIdentifier);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		Guid guid = default(Guid);
		string text = default(string);
		Class34 class2 = default(Class34);
		Class34 class3 = default(Class34);
		int i = default(int);
		Class34 class4 = default(Class34);
		Dictionary<string, ulong>.Enumerator enumerator = default(Dictionary<string, ulong>.Enumerator);
		KeyValuePair<string, ulong> current2 = default(KeyValuePair<string, ulong>);
		ulong value = default(ulong);
		try
		{
			usageCounts = usageCounts_0;
			UsageCounts usageCounts2 = (usageCounts_0 = null);
			if (byte_1 != null || usageCounts == null || usageCounts.IsEmpty)
			{
				return;
			}
			staticFeatureCounts = usageCounts.StaticFeatureCounts;
			dynamicFeatureCounts = usageCounts.DynamicFeatureCounts;
			memoryStream = new MemoryStream();
			xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			xmlWriter.WriteStartDocument();
			@class = new Class34(xmlWriter, "UsageReport");
			try
			{
				xmlWriter.WriteAttributeString("AssemblyID", "{8188F18B-DD19-48CB-888D-E596F7B0AB27}".ToUpper());
				XmlWriter xmlWriter2 = xmlWriter;
				dateTime_ = SimpleZip.Class6.smethod_0(477, 463);
				xmlWriter2.WriteAttributeString("DateTime", Class14.smethod_0(ref dateTime_, "s", 352, 356));
				XmlWriter xmlWriter3 = xmlWriter;
				guid_ = Guid.NewGuid();
				xmlWriter3.WriteAttributeString("ReportID", SendingReportFeedbackEventArgs.smethod_0(ref guid_, "B", 974, 1010));
				current = WindowsIdentity.GetCurrent();
				user = current.User;
				mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				try
				{
					guid = new Guid(mD5CryptoServiceProvider.ComputeHash(SimpleZip.Stream0.smethod_0(Encoding.Unicode, SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_0(user, 694, 752), 74, 51)));
					text = guid.ToString();
				}
				finally
				{
					((IDisposable)mD5CryptoServiceProvider)?.Dispose();
				}
				xmlWriter.WriteAttributeString("UserID", text);
				class2 = new Class34(xmlWriter, "AssemblyIDs");
				try
				{
					xmlWriter.WriteAttributeString("Count", "-1");
				}
				finally
				{
					((IDisposable)class2)?.Dispose();
				}
				class3 = new Class34(xmlWriter, "Features");
				try
				{
					for (i = 0; i < staticFeatureCounts.Length; i++)
					{
						if (staticFeatureCounts[i] > 0L)
						{
							Class32.smethod_0(xmlWriter, "Feature", 405, 430);
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
				class4 = new Class34(xmlWriter, "DynamicFeatures");
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
								Class32.smethod_0(xmlWriter, "Feature", 190, 133);
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
			ReportSender1.smethod_0(memoryStream, 307, 292);
			byte[] array = (byte_1 = SimpleZip.Class6.smethod_1(memoryStream, 899, 960));
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[21]
			{
				usageCounts, staticFeatureCounts, dynamicFeatureCounts, memoryStream, xmlWriter, current, user, text, mD5CryptoServiceProvider, i,
				current2, @class, dateTime_, guid_, guid, class2, class3, class4, enumerator, value,
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
			method_0(byte_1, Class30.class30_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	[SecuritySafeCritical]
	static UsageReportSender()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static int smethod_4(ref Rectangle rectangle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 108:
				return rectangle_0.Left;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_5(Control control_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 94:
				control_0.set_Visible(bool_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_6(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return object.ReferenceEquals(object_0, object_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_7(FieldInfo fieldInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return fieldInfo_0.IsLiteral;
			}
		}
	}
}
