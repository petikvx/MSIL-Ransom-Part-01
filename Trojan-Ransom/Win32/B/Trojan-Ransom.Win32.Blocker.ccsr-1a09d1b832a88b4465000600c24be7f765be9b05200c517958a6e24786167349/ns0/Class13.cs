using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class13
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2164)]
	private struct Struct15
	{
	}

	public static string string_0;

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public static byte[] smethod_0(byte[] byte_1, string string_2)
	{
		if (Win32.smethod_9(string_2, "{", 680, 688))
		{
			string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			StackFrameHelper.smethod_0(rSACryptoServiceProvider, string_2, 856, 847);
			Class20.smethod_1(rijndaelManaged, 1021, 1017);
			Win32.smethod_11(rijndaelManaged, 551, 570);
			byte[] array_ = new byte[48];
			DoNotPruneTypeAttribute.smethod_1(Form1.smethod_0(rijndaelManaged, 1001, 937), 0, array_, 0, 32, 436, 386);
			DoNotPruneTypeAttribute.smethod_1(StackFrameHelper.smethod_1(rijndaelManaged, 162, 254), 0, array_, 32, 16, 119, 65);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array = Class21.smethod_1(rSACryptoServiceProvider, array_, bool_0: false, 885, 826);
				WaitSendingReportControl.smethod_1(memoryStream, 1, 882, 806);
				WaitSendingReportControl.smethod_1(memoryStream, Convert.ToByte(array.Length / 8), 990, 906);
				SendingReportFeedbackEventArgs.smethod_2(memoryStream, array, 0, array.Length, 776, 801);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array_2 = new byte[16];
					byte[] array_3 = new byte[16];
					DoNotPruneTypeAttribute.smethod_1(Form1.smethod_0(rijndaelManaged, 413, 477), 0, array_2, 0, 16, 774, 816);
					DoNotPruneTypeAttribute.smethod_1(Form1.smethod_0(rijndaelManaged, 927, 991), 16, array_3, 0, 16, 516, 562);
					byte[] array2 = Class21.smethod_1(rSACryptoServiceProvider, array_2, bool_0: false, 822, 889);
					byte[] array3 = Class21.smethod_1(rSACryptoServiceProvider, array_3, bool_0: false, 555, 612);
					byte[] array4 = Class21.smethod_1(rSACryptoServiceProvider, StackFrameHelper.smethod_1(rijndaelManaged, 132, 216), bool_0: false, 146, 221);
					WaitSendingReportControl.smethod_1(memoryStream, 2, 706, 662);
					WaitSendingReportControl.smethod_1(memoryStream, Convert.ToByte(array2.Length / 8), 238, 186);
					SendingReportFeedbackEventArgs.smethod_2(memoryStream, array2, 0, array2.Length, 785, 824);
					memoryStream.Write(array3, 0, array3.Length);
					memoryStream.Write(array4, 0, array4.Length);
				}
				catch (CryptographicException)
				{
					string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_1, 0, byte_1.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			string_0 = "ERR 2004: " + ex3.Message;
			return null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
	}

	static Class13()
	{
		DESCryptoIndirector.smethod_0();
		char_1 = new char[1082];
		char[] array = new char[8];
		array[2] = '⒟';
		array[6] = 'N';
		array[7] = '␛';
		array[4] = 'ⳮ';
		array[3] = '⮓';
		array[1] = '㲍';
		array[0] = '㺫';
		array[5] = 'ᓂ';
		string_1 = new string[47];
		char_0 = array;
	}

	internal static int smethod_1(Version version_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 13:
				return version_0.Major;
			}
		}
	}
}
