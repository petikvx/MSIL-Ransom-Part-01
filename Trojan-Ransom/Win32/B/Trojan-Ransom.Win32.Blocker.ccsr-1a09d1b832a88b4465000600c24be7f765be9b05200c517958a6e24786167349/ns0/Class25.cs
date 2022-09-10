using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class25
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
			if (Win32.smethod_9(string_1, "{", 27, 3))
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
				StackFrameHelper.smethod_0(rSACryptoServiceProvider, string_1, 525, 538);
				Class20.smethod_1(rijndaelManaged, 355, 359);
				Win32.smethod_11(rijndaelManaged, 116, 105);
				array = new byte[48];
				DoNotPruneTypeAttribute.smethod_1(Form1.smethod_0(rijndaelManaged, 204, 140), 0, array, 0, 32, 328, 382);
				DoNotPruneTypeAttribute.smethod_1(StackFrameHelper.smethod_1(rijndaelManaged, 968, 916), 0, array, 32, 16, 1016, 974);
				memoryStream = new MemoryStream();
				try
				{
					array2 = Class21.smethod_1(rSACryptoServiceProvider, array, bool_0: false, 169, 230);
					WaitSendingReportControl.smethod_1(memoryStream, 1, 939, 1023);
					WaitSendingReportControl.smethod_1(memoryStream, Convert.ToByte(array2.Length / 8), 137, 221);
					SendingReportFeedbackEventArgs.smethod_2(memoryStream, array2, 0, array2.Length, 247, 222);
				}
				catch (CryptographicException)
				{
					try
					{
						array3 = new byte[16];
						array4 = new byte[16];
						DoNotPruneTypeAttribute.smethod_1(Form1.smethod_0(rijndaelManaged, 998, 934), 0, array3, 0, 16, 228, 210);
						DoNotPruneTypeAttribute.smethod_1(Form1.smethod_0(rijndaelManaged, 271, 335), 16, array4, 0, 16, 472, 494);
						array5 = Class21.smethod_1(rSACryptoServiceProvider, array3, bool_0: false, 204, 131);
						array6 = Class21.smethod_1(rSACryptoServiceProvider, array4, bool_0: false, 731, 660);
						array7 = Class21.smethod_1(rSACryptoServiceProvider, StackFrameHelper.smethod_1(rijndaelManaged, 774, 858), bool_0: false, 330, 261);
						WaitSendingReportControl.smethod_1(memoryStream, 2, 449, 405);
						WaitSendingReportControl.smethod_1(memoryStream, Convert.ToByte(array5.Length / 8), 465, 389);
						SendingReportFeedbackEventArgs.smethod_2(memoryStream, array5, 0, array5.Length, 66, 107);
						SendingReportFeedbackEventArgs.smethod_2(memoryStream, array6, 0, array6.Length, 100, 77);
						SendingReportFeedbackEventArgs.smethod_2(memoryStream, array7, 0, array7.Length, 705, 744);
					}
					catch (CryptographicException)
					{
						string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
						array8 = null;
						return array8;
					}
				}
				cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
				SendingReportFeedbackEventArgs.smethod_2(cryptoStream, byte_0, 0, byte_0.Length, 880, 857);
				cryptoStream.FlushFinalBlock();
				array8 = Class37.smethod_5(memoryStream, 70, 86);
				return array8;
			}
			catch (Exception ex3)
			{
				ex4 = ex3;
				string_0 = "ERR 2004: " + AutoHeightLabel.smethod_1(ex4, 415, 486);
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

	static Class25()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static Font smethod_1(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 67:
				return control_0.get_Font();
			}
		}
	}

	internal static Type smethod_2(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				return type_0.BaseType;
			}
		}
	}

	internal static string smethod_3(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				return type_0.FullName;
			}
		}
	}

	internal static int smethod_4(Array array_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 86:
				return array_0.GetLength(int_0);
			}
		}
	}
}
