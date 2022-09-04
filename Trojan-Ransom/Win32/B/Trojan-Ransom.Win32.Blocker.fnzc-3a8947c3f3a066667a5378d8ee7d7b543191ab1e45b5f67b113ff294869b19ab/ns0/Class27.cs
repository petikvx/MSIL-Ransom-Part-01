using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class27
{
	public static string string_0;

	public static byte[] smethod_0(byte[] byte_0, string string_1)
	{
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		Exception ex4 = default(Exception);
		try
		{
			if (UsageCounts.smethod_0(string_1, "{", 275, 264))
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
				rijndaelManaged = new RijndaelManaged();
				rSACryptoServiceProvider = new RSACryptoServiceProvider();
				rSACryptoServiceProvider.FromXmlString(string_1);
				HeaderControl.smethod_0(rijndaelManaged, 205, 249);
				WaitSendingReportControl.smethod_0(rijndaelManaged, 559, 614);
				array = new byte[48];
				Class31.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_0(rijndaelManaged, 49, 51), 0, array, 0, 32, 204, 253);
				Class31.smethod_0(rijndaelManaged.IV, 0, array, 32, 16, 512, 561);
				memoryStream = new MemoryStream();
				try
				{
					array2 = PoweredBy.smethod_0(rSACryptoServiceProvider, array, bool_0: false, 570, 562);
					memoryStream.WriteByte(1);
					memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
					StackFrameHelper.smethod_0(memoryStream, array2, 0, array2.Length, 922, 1014);
				}
				catch (CryptographicException)
				{
					try
					{
						array3 = new byte[16];
						array4 = new byte[16];
						Class31.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_0(rijndaelManaged, 620, 622), 0, array3, 0, 16, 583, 630);
						Class31.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_0(rijndaelManaged, 87, 85), 16, array4, 0, 16, 643, 690);
						array5 = PoweredBy.smethod_0(rSACryptoServiceProvider, array3, bool_0: false, 718, 710);
						array6 = PoweredBy.smethod_0(rSACryptoServiceProvider, array4, bool_0: false, 179, 187);
						array7 = PoweredBy.smethod_0(rSACryptoServiceProvider, rijndaelManaged.IV, bool_0: false, 369, 377);
						memoryStream.WriteByte(2);
						memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
						StackFrameHelper.smethod_0(memoryStream, array5, 0, array5.Length, 592, 572);
						StackFrameHelper.smethod_0(memoryStream, array6, 0, array6.Length, 155, 247);
						StackFrameHelper.smethod_0(memoryStream, array7, 0, array7.Length, 700, 720);
					}
					catch (CryptographicException)
					{
						string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
						array8 = null;
						return array8;
					}
				}
				cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
				StackFrameHelper.smethod_0(cryptoStream, byte_0, 0, byte_0.Length, 812, 832);
				ReportSender1.smethod_1(cryptoStream, 647, 731);
				array8 = SimpleZip.Class6.smethod_1(memoryStream, 857, 794);
				return array8;
			}
			catch (Exception ex3)
			{
				ex4 = ex3;
				string_0 = "ERR 2004: " + Class26.smethod_0(ex4, 386, 460);
				array8 = null;
				return array8;
			}
			finally
			{
				rijndaelManaged?.Clear();
				rSACryptoServiceProvider?.Clear();
				memoryStream?.Close();
				cryptoStream?.Close();
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[15]
			{
				rijndaelManaged, rSACryptoServiceProvider, memoryStream, cryptoStream, array, array2, array3, array4, array5, array6,
				array7, ex4, array8, byte_0, string_1
			});
			throw;
		}
	}

	[SecuritySafeCritical]
	static Class27()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_1(Form form_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				form_0.set_ShowInTaskbar(bool_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 102:
				return stream_0.Position;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_3(string string_1, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 62:
				return string_1.Substring(int_0);
			}
		}
	}
}
