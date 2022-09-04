using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class28
{
	public static string string_0;

	public static byte[] smethod_0(byte[] byte_0, string string_1)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream cryptoStream = default(CryptoStream);
		int num2 = default(int);
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		byte[] array9 = default(byte[]);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		Exception ex4 = default(Exception);
		int num8 = default(int);
		object[] array10 = default(object[]);
		int num9 = default(int);
		try
		{
			try
			{
				num = 1;
				if (AppNameFinder.smethod_2(string_1, "{", 494, 425))
				{
					string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
					array = null;
				}
				else
				{
					rijndaelManaged = null;
					rSACryptoServiceProvider = null;
					memoryStream = null;
					cryptoStream = null;
					try
					{
						num2 = 1;
						rijndaelManaged = new RijndaelManaged();
						rSACryptoServiceProvider = new RSACryptoServiceProvider();
						Class23.smethod_0(rSACryptoServiceProvider, string_1, 911, 986);
						num2 = 2;
						Class5.smethod_3(rijndaelManaged, 762, 706);
						AutoHeightLabel.smethod_1(rijndaelManaged, 228, 154);
						num2 = 3;
						array2 = new byte[48];
						AppPathFinder.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 921, 954), 0, array2, 0, 32, 499, 488);
						num2 = 5;
						AppPathFinder.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 589, 617), 0, array2, 32, 16, 99, 120);
						num2 = 4;
						memoryStream = new MemoryStream();
						try
						{
							num3 = 0;
							array3 = ReportSender1.smethod_4(rSACryptoServiceProvider, array2, bool_0: false, 629, 620);
							FatalExceptionEventArgs.smethod_1(memoryStream, 1, 535, 546);
							num3 = 3;
							FatalExceptionEventArgs.smethod_1(memoryStream, SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2(array3.Length / 8, 656, 763), 779, 830);
							num3 = 5;
							ReportSender1.smethod_1(memoryStream, array3, 0, array3.Length, 902, 1016);
						}
						catch (CryptographicException)
						{
							try
							{
								num4 = 11;
								array4 = new byte[16];
								array5 = new byte[16];
								AppPathFinder.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 425, 394), 0, array4, 0, 16, 524, 535);
								num4 = 2;
								AppPathFinder.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 428, 399), 16, array5, 0, 16, 838, 861);
								num4 = 5;
								array6 = ReportSender1.smethod_4(rSACryptoServiceProvider, array4, bool_0: false, 384, 409);
								array7 = ReportSender1.smethod_4(rSACryptoServiceProvider, array5, bool_0: false, 96, 121);
								num4 = 7;
								array8 = ReportSender1.smethod_4(rSACryptoServiceProvider, SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 15, 43), bool_0: false, 472, 449);
								num4 = 0;
								FatalExceptionEventArgs.smethod_1(memoryStream, 2, 520, 573);
								FatalExceptionEventArgs.smethod_1(memoryStream, SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2(array6.Length / 8, 419, 456), 788, 801);
								num4 = 6;
								ReportSender1.smethod_1(memoryStream, array6, 0, array6.Length, 33, 95);
								num4 = 8;
								ReportSender1.smethod_1(memoryStream, array7, 0, array7.Length, 386, 508);
								num4 = 10;
								ReportSender1.smethod_1(memoryStream, array8, 0, array8.Length, 525, 627);
							}
							catch (CryptographicException)
							{
								string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
								array9 = null;
								goto end_IL_0034;
							}
							num5 = 3;
						}
						num6 = 2;
						cryptoStream = new CryptoStream(memoryStream, Class21.smethod_3(rijndaelManaged, 720, 728), CryptoStreamMode.Write);
						ReportSender1.smethod_1(cryptoStream, byte_0, 0, byte_0.Length, 8, 118);
						num6 = 5;
						SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_3(cryptoStream, 631, 587);
						array9 = ConfirmFeatureUsageReportingForm_1.smethod_0(memoryStream, 875, 893);
						end_IL_0034:;
					}
					catch (Exception ex3)
					{
						ex4 = ex3;
						string_0 = "ERR 2004: " + UsageReportSender.smethod_12(ex4, 466, 494);
						array9 = null;
					}
					finally
					{
						num7 = 12;
						if (rijndaelManaged != null)
						{
							num7 = 8;
							rijndaelManaged.Clear();
						}
						else
						{
							num7 = 7;
						}
						if (rSACryptoServiceProvider != null)
						{
							num7 = 9;
							rSACryptoServiceProvider.Clear();
						}
						else
						{
							num7 = 5;
						}
						if (memoryStream != null)
						{
							num7 = 1;
							memoryStream.Close();
						}
						else
						{
							num7 = 4;
						}
						if (cryptoStream != null)
						{
							num7 = 2;
							cryptoStream.Close();
						}
						else
						{
							num7 = 6;
						}
					}
					num8 = 3;
					array = array9;
				}
			}
			catch (Exception caughtException)
			{
				array10 = new object[15]
				{
					rijndaelManaged, rSACryptoServiceProvider, memoryStream, cryptoStream, array2, array3, array4, array5, array6, array7,
					array8, ex4, array9, byte_0, string_1
				};
				StackFrameHelper.CreateExceptionN(caughtException, array10);
				throw;
			}
			num9 = 2;
			return array;
		}
		catch (Exception caughtException2)
		{
			StackFrameHelper.CreateExceptionN(caughtException2, new object[26]
			{
				rijndaelManaged, rSACryptoServiceProvider, memoryStream, cryptoStream, array2, array3, array4, array5, array6, array7,
				array8, ex4, array9, array10, array, num, num2, num3, num4, num5,
				num6, num7, num8, num9, byte_0, string_1
			});
			throw;
		}
	}

	public Class28()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static Class28()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static DialogResult smethod_1(Form form_0, int int_0, int int_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 100:
					return form_0.get_DialogResult();
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, form_0, int_0, int_1);
			throw;
		}
	}

	internal static MethodInfo smethod_2(Type type_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					return type_0.GetMethod(string_1);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, type_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static byte[] smethod_3(Encoding encoding_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					return encoding_0.GetBytes(string_1);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, encoding_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(XmlWriter xmlWriter_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 9:
					xmlWriter_0.WriteStartElement(string_1);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, xmlWriter_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_5(Version version_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 51:
					return version_0.Minor;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, version_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_6(byte[] byte_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					return Convert.ToBase64String(byte_0);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, byte_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_7(object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 96:
					Monitor.Enter(object_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, object_0, int_0, int_1);
			throw;
		}
	}

	internal static PlatformID smethod_8(OperatingSystem operatingSystem_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 75:
					return operatingSystem_0.Platform;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, operatingSystem_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_9(Type type_0, object object_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 5:
					return Enum.Format(type_0, object_0, string_1);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, type_0, object_0, string_1, int_0, int_1);
			throw;
		}
	}
}
