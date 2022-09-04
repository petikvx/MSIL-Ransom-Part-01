using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using My;
using SmartAssembly.Attributes;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public class UsageReportSender : ReportSender1
{
	internal UsageCounts usageCounts_0;

	internal byte[] byte_0;

	public UsageReportSender(UsageCounts usageCounts)
	{
		UsageCounts o = default(UsageCounts);
		try
		{
			try
			{
				o = (usageCounts_0 = usageCounts);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, usageCounts);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, o, this, usageCounts);
			throw;
		}
	}

	private void method_1()
	{
		int num = default(int);
		UsageCounts usageCounts = default(UsageCounts);
		UsageCounts usageCounts2 = default(UsageCounts);
		ulong[] staticFeatureCounts = default(ulong[]);
		Dictionary<string, ulong> dynamicFeatureCounts = default(Dictionary<string, ulong>);
		MemoryStream memoryStream = default(MemoryStream);
		XmlWriter xmlWriter = default(XmlWriter);
		Class35 @class = default(Class35);
		int num2 = default(int);
		DateTime dateTime_ = default(DateTime);
		Guid guid_ = default(Guid);
		WindowsIdentity windowsIdentity = default(WindowsIdentity);
		SecurityIdentifier securityIdentifier = default(SecurityIdentifier);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		int num3 = default(int);
		Guid guid = default(Guid);
		string text = default(string);
		int num4 = default(int);
		int num5 = default(int);
		Class35 class2 = default(Class35);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		Class35 class3 = default(Class35);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		Class35 class4 = default(Class35);
		int num13 = default(int);
		Dictionary<string, ulong>.Enumerator enumerator = default(Dictionary<string, ulong>.Enumerator);
		int num14 = default(int);
		KeyValuePair<string, ulong> current = default(KeyValuePair<string, ulong>);
		ulong value = default(ulong);
		int num15 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		int num18 = default(int);
		int num19 = default(int);
		int num20 = default(int);
		byte[] array = default(byte[]);
		object[] array2 = default(object[]);
		int num21 = default(int);
		try
		{
			try
			{
				num = 5;
				usageCounts = usageCounts_0;
				usageCounts2 = (usageCounts_0 = null);
				num = 6;
				if (byte_0 == null)
				{
					num = 4;
					if (usageCounts != null)
					{
						num = 0;
						if (usageCounts.IsEmpty)
						{
							num = 3;
						}
						else
						{
							num = 1;
							staticFeatureCounts = usageCounts.StaticFeatureCounts;
							dynamicFeatureCounts = usageCounts.DynamicFeatureCounts;
							memoryStream = new MemoryStream();
							xmlWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
							num = 7;
							SimpleZip.Stream0.smethod_1(xmlWriter, 496, 428);
							@class = new Class35(xmlWriter, "UsageReport");
							try
							{
								num2 = 7;
								Attribute0.smethod_0(xmlWriter, "AssemblyID", ReportSender1.smethod_2("{7BC8269A-DFA7-4C63-92DF-CECB0FBA593D}", 327, 315), 305, 257);
								num2 = 8;
								XmlWriter xmlWriter_ = xmlWriter;
								dateTime_ = smethod_9(894, 876);
								Attribute0.smethod_0(xmlWriter_, "DateTime", MyComputer.smethod_0(ref dateTime_, "s", 913, 944), 228, 212);
								num2 = 5;
								XmlWriter xmlWriter_2 = xmlWriter;
								guid_ = SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_1(727, 661);
								Attribute0.smethod_0(xmlWriter_2, "ReportID", StackFrameHelper.smethod_3(ref guid_, "B", 193, 210), 880, 832);
								num2 = 2;
								windowsIdentity = Class17.smethod_13(686, 641);
								securityIdentifier = PoweredByAttribute1.smethod_2(windowsIdentity, 351, 381);
								num2 = 1;
								mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
								try
								{
									num3 = 1;
									guid = new Guid(ReportUsageAttribute.smethod_2(mD5CryptoServiceProvider, Class28.smethod_3(Class27.smethod_2(357, 379), smethod_15(securityIdentifier, 335, 305), 860, 810), 153, 206));
									num3 = 4;
									text = guid.ToString();
								}
								finally
								{
									num4 = 6;
									((IDisposable)mD5CryptoServiceProvider)?.Dispose();
								}
								num5 = 4;
								Attribute0.smethod_0(xmlWriter, "UserID", text, 947, 899);
								class2 = new Class35(xmlWriter, "AssemblyIDs");
								try
								{
									num6 = 2;
									Attribute0.smethod_0(xmlWriter, "Count", "-1", 872, 856);
								}
								finally
								{
									num7 = 6;
									((IDisposable)class2)?.Dispose();
								}
								num8 = 4;
								class3 = new Class35(xmlWriter, "Features");
								try
								{
									num9 = 11;
									num10 = 0;
									num9 = 0;
									while (num10 < staticFeatureCounts.Length)
									{
										num9 = 2;
										if (staticFeatureCounts[num10] > 0L)
										{
											num9 = 7;
											Class28.smethod_4(xmlWriter, "Feature", 53, 60);
											Attribute0.smethod_0(xmlWriter, "Id", num10.ToString(), 36, 20);
											num9 = 5;
											Attribute0.smethod_0(xmlWriter, "Count", staticFeatureCounts[num10].ToString(), 478, 494);
											num9 = 1;
											StackFrameHelper.smethod_2(xmlWriter, 989, 927);
										}
										else
										{
											num9 = 6;
										}
										num10++;
										num9 = 0;
									}
									num9 = 10;
								}
								finally
								{
									num11 = 2;
									((IDisposable)class3)?.Dispose();
								}
								num12 = 1;
								class4 = new Class35(xmlWriter, "DynamicFeatures");
								try
								{
									num13 = 0;
									enumerator = dynamicFeatureCounts.GetEnumerator();
									try
									{
										num14 = 5;
										num14 = 8;
										while (enumerator.MoveNext())
										{
											num14 = 7;
											current = enumerator.Current;
											if (current.Value > 0L)
											{
												num14 = 10;
												Class28.smethod_4(xmlWriter, "Feature", 141, 132);
												Attribute0.smethod_0(xmlWriter, "Name", current.Key, 534, 550);
												num14 = 3;
												XmlWriter xmlWriter_3 = xmlWriter;
												value = current.Value;
												Attribute0.smethod_0(xmlWriter_3, "Count", value.ToString(), 818, 770);
												num14 = 6;
												StackFrameHelper.smethod_2(xmlWriter, 811, 873);
											}
											else
											{
												num14 = 8;
											}
										}
										num14 = 1;
									}
									finally
									{
										num15 = 0;
										((IDisposable)enumerator).Dispose();
									}
									num16 = 3;
								}
								finally
								{
									num17 = 1;
									((IDisposable)class4)?.Dispose();
								}
								num18 = 4;
							}
							finally
							{
								num19 = 4;
								((IDisposable)@class)?.Dispose();
							}
							num20 = 3;
							SimpleZip.Stream0.smethod_1(xmlWriter, 639, 546);
							StackFrameHelper.smethod_2(xmlWriter, 1008, 947);
							num20 = 2;
							MyApplication.smethod_0(memoryStream, 154, 169);
							array = (byte_0 = ConfirmFeatureUsageReportingForm_1.smethod_0(memoryStream, 881, 871));
						}
					}
					else
					{
						num = 3;
					}
				}
				else
				{
					num = 3;
				}
			}
			catch (Exception caughtException)
			{
				array2 = new object[21]
				{
					usageCounts, staticFeatureCounts, dynamicFeatureCounts, memoryStream, xmlWriter, windowsIdentity, securityIdentifier, text, mD5CryptoServiceProvider, num10,
					current, @class, dateTime_, guid_, guid, class2, class3, class4, enumerator, value,
					this
				};
				StackFrameHelper.CreateExceptionN(caughtException, array2);
				throw;
			}
			num21 = 3;
		}
		catch (Exception caughtException2)
		{
			StackFrameHelper.CreateExceptionN(caughtException2, new object[44]
			{
				usageCounts, staticFeatureCounts, dynamicFeatureCounts, memoryStream, xmlWriter, windowsIdentity, securityIdentifier, text, mD5CryptoServiceProvider, num10,
				current, @class, dateTime_, guid_, guid, class2, class3, class4, enumerator, value,
				array2, usageCounts2, array, num, num2, num3, num4, num5, num6, num7,
				num8, num9, num11, num12, num13, num14, num15, num16, num17, num18,
				num19, num20, num21, this
			});
			throw;
		}
	}

	public void SendReport()
	{
		int num = default(int);
		UsageCounts o = default(UsageCounts);
		try
		{
			try
			{
				num = 4;
				if (usageCounts_0 == null)
				{
					o = (usageCounts_0 = UsageCountStore.GetAllUsageCountsAndReset());
					num = 3;
				}
				method_1();
				method_0(byte_0, Class31.class31_0);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, o, num, this);
			throw;
		}
	}

	static UsageReportSender()
	{
		try
		{
			DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static void smethod_8(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 80:
					ProjectData.ClearProjectError();
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException4(exception, num, num2, int_0, int_1);
			throw;
		}
	}

	internal static DateTime smethod_9(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					return DateTime.Now;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_10(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 33:
					RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, array_0, runtimeFieldHandle_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_11(Control control_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 116:
					control_0.set_Top(int_0);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static string smethod_12(Exception exception_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 60:
					return exception_0.Message;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, exception_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_13(Control control_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 52:
					control_0.set_Enabled(bool_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_14(Thread thread_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					thread_0.Start();
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, thread_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_15(object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 126:
					return object_0.ToString();
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, object_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_16(Control control_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 93:
					control_0.add_Click(eventHandler_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, eventHandler_0, int_0, int_1);
			throw;
		}
	}

	internal static Size smethod_17(SizeF sizeF_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 74:
					return Size.Ceiling(sizeF_0);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, sizeF_0, int_0, int_1);
			throw;
		}
	}
}
