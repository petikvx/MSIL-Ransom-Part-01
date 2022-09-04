using System;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class15
{
	public static string string_0;

	public static byte[] smethod_0(byte[] byte_0, string string_1)
	{
		if (UsageCounts.smethod_0(string_1, "{", 705, 730))
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
			rSACryptoServiceProvider.FromXmlString(string_1);
			HeaderControl.smethod_0(rijndaelManaged, 630, 578);
			WaitSendingReportControl.smethod_0(rijndaelManaged, 978, 923);
			byte[] array = new byte[48];
			Class31.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_0(rijndaelManaged, 148, 150), 0, array, 0, 32, 746, 731);
			Class31.smethod_0(rijndaelManaged.IV, 0, array, 32, 16, 528, 545);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = PoweredBy.smethod_0(rSACryptoServiceProvider, array, bool_0: false, 177, 185);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				StackFrameHelper.smethod_0(memoryStream, array2, 0, array2.Length, 453, 425);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Class31.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_0(rijndaelManaged, 499, 497), 0, array3, 0, 16, 160, 145);
					Class31.smethod_0(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_0(rijndaelManaged, 969, 971), 16, array4, 0, 16, 722, 739);
					byte[] array5 = PoweredBy.smethod_0(rSACryptoServiceProvider, array3, bool_0: false, 472, 464);
					byte[] array6 = PoweredBy.smethod_0(rSACryptoServiceProvider, array4, bool_0: false, 192, 200);
					byte[] array7 = PoweredBy.smethod_0(rSACryptoServiceProvider, rijndaelManaged.IV, bool_0: false, 774, 782);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					StackFrameHelper.smethod_0(memoryStream, array5, 0, array5.Length, 94, 50);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
				}
				catch (CryptographicException)
				{
					string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
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

	[SecuritySafeCritical]
	static Class15()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				ProjectData.EndApp();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(MemoryStream memoryStream_0, long long_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				memoryStream_0.Position = long_0;
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_3(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 21:
				return Assembly.Load(byte_0);
			}
		}
	}
}
