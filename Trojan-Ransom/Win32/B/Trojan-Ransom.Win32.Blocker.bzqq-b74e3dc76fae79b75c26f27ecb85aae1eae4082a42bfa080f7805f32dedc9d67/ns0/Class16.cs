using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class16
{
	public static string string_0;

	public static byte[] smethod_0(byte[] byte_0, string string_1)
	{
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream cryptoStream = default(CryptoStream);
		int num = default(int);
		byte[] array = default(byte[]);
		int num2 = default(int);
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		Exception ex4 = default(Exception);
		int num7 = default(int);
		try
		{
			if (AppNameFinder.smethod_2(string_1, "{", 545, 614))
			{
				string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
				return null;
			}
			rijndaelManaged = null;
			rSACryptoServiceProvider = null;
			memoryStream = null;
			cryptoStream = null;
			try
			{
				num = 4;
				rijndaelManaged = new RijndaelManaged();
				rSACryptoServiceProvider = new RSACryptoServiceProvider();
				Class23.smethod_0(rSACryptoServiceProvider, string_1, 914, 967);
				num = 6;
				Class5.smethod_3(rijndaelManaged, 179, 139);
				AutoHeightLabel.smethod_1(rijndaelManaged, 625, 527);
				num = 1;
				array = new byte[48];
				AppPathFinder.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 863, 892), 0, array, 0, 32, 749, 758);
				num = 8;
				AppPathFinder.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 746, 718), 0, array, 32, 16, 179, 168);
				num = 3;
				memoryStream = new MemoryStream();
				try
				{
					num2 = 6;
					array2 = ReportSender1.smethod_4(rSACryptoServiceProvider, array, bool_0: false, 478, 455);
					FatalExceptionEventArgs.smethod_1(memoryStream, 1, 413, 424);
					num2 = 1;
					FatalExceptionEventArgs.smethod_1(memoryStream, SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2(array2.Length / 8, 927, 1012), 342, 355);
					num2 = 0;
					ReportSender1.smethod_1(memoryStream, array2, 0, array2.Length, 583, 569);
				}
				catch (CryptographicException)
				{
					try
					{
						num3 = 10;
						array3 = new byte[16];
						array4 = new byte[16];
						AppPathFinder.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 564, 535), 0, array3, 0, 16, 706, 729);
						num3 = 1;
						AppPathFinder.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 41, 10), 16, array4, 0, 16, 534, 525);
						num3 = 6;
						array5 = ReportSender1.smethod_4(rSACryptoServiceProvider, array3, bool_0: false, 653, 660);
						array6 = ReportSender1.smethod_4(rSACryptoServiceProvider, array4, bool_0: false, 155, 130);
						num3 = 5;
						array7 = ReportSender1.smethod_4(rSACryptoServiceProvider, SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(rijndaelManaged, 133, 161), bool_0: false, 677, 700);
						num3 = 8;
						FatalExceptionEventArgs.smethod_1(memoryStream, 2, 444, 393);
						FatalExceptionEventArgs.smethod_1(memoryStream, SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2(array5.Length / 8, 254, 149), 667, 686);
						num3 = 7;
						ReportSender1.smethod_1(memoryStream, array5, 0, array5.Length, 67, 61);
						num3 = 9;
						memoryStream.Write(array6, 0, array6.Length);
						memoryStream.Write(array7, 0, array7.Length);
					}
					catch (CryptographicException)
					{
						string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
						array8 = null;
						goto end_IL_0031;
					}
					num4 = 0;
				}
				num5 = 4;
				cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				num5 = 5;
				cryptoStream.FlushFinalBlock();
				array8 = memoryStream.ToArray();
				end_IL_0031:;
			}
			catch (Exception ex3)
			{
				ex4 = ex3;
				string_0 = "ERR 2004: " + ex4.Message;
				array8 = null;
			}
			finally
			{
				num6 = 11;
				if (rijndaelManaged != null)
				{
					num6 = 3;
					rijndaelManaged.Clear();
				}
				else
				{
					num6 = 4;
				}
				if (rSACryptoServiceProvider != null)
				{
					num6 = 10;
					rSACryptoServiceProvider.Clear();
				}
				else
				{
					num6 = 5;
				}
				if (memoryStream != null)
				{
					num6 = 0;
					memoryStream.Close();
				}
				else
				{
					num6 = 9;
				}
				if (cryptoStream != null)
				{
					num6 = 12;
					cryptoStream.Close();
				}
				else
				{
					num6 = 1;
				}
			}
			num7 = 2;
			return array8;
		}
		catch (Exception caughtException)
		{
			int num8 = default(int);
			StackFrameHelper.CreateExceptionN(caughtException, new object[23]
			{
				rijndaelManaged, rSACryptoServiceProvider, memoryStream, cryptoStream, array, array2, array3, array4, array5, array6,
				array7, ex4, array8, num8, num, num2, num3, num4, num5, num6,
				num7, byte_0, string_1
			});
			throw;
		}
	}

	public Class16()
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

	static Class16()
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

	internal static void smethod_1(Control control_0, Font font_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 47:
					control_0.set_Font(font_0);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, font_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Form form_0, Icon icon_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 64:
					form_0.set_Icon(icon_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, form_0, icon_0, int_0, int_1);
			throw;
		}
	}
}
