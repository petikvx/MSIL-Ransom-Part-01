using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WebCruiserWVS;

internal class Class2
{
	private static bool bool_0 = false;

	public static string string_0 = "";

	public static int int_0 = 0;

	[SpecialName]
	public static bool smethod_0()
	{
		return bool_0;
	}

	[SpecialName]
	public static void smethod_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	private static string smethod_2(string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(bytes);
		string text = BitConverter.ToString(array).Replace("-", "");
		return text.Substring(8, 16);
	}

	private static uint smethod_3(string string_1)
	{
		try
		{
			string s = smethod_2(string_1);
			ulong num = ulong.Parse(s, NumberStyles.HexNumber);
			return (uint)(num % 1000000uL);
		}
		catch
		{
			return 0u;
		}
	}

	public static bool smethod_4(string string_1, string string_2)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (string_2.IndexOf('-') <= 0)
			{
				return false;
			}
			string[] array = string_2.Split(new char[1] { '-' });
			if (array.Length != 2)
			{
				return false;
			}
			string string_3 = array[0];
			string s = array[1];
			uint num = smethod_3(string_3);
			uint num2 = uint.Parse(s);
			string string_4 = (num2 - num).ToString();
			string text = smethod_2(string_4);
			if (text.Equals("B1B77A53F0264B1D"))
			{
				bool_0 = true;
				string_0 = string_1;
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return false;
		}
	}

	public static bool smethod_5(string string_1, string string_2)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (string_2.Length != 19)
			{
				return false;
			}
			char[] array = string_2.ToCharArray();
			if (array[4] != '-')
			{
				return false;
			}
			if (array[9] != '-')
			{
				return false;
			}
			if (array[14] != '-')
			{
				return false;
			}
			string_2 = string_2.Replace("-", "");
			ulong num = smethod_6(string_2);
			string string_3 = smethod_7(string_1);
			ulong num2 = smethod_6(string_3);
			string string_4 = (num - num2).ToString();
			string text = smethod_7(string_4);
			if (text.Equals("1FEDF23C6CB786AA"))
			{
				bool_0 = true;
				string_0 = string_1;
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return false;
		}
	}

	private static ulong smethod_6(string string_1)
	{
		try
		{
			return ulong.Parse(string_1, NumberStyles.HexNumber);
		}
		catch
		{
			return 0uL;
		}
	}

	private static string smethod_7(string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		SHA512 sHA = new SHA512Managed();
		byte[] array = sHA.ComputeHash(bytes);
		string text = BitConverter.ToString(array).Replace("-", "");
		char[] array2 = text.ToCharArray();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 128; i++)
		{
			if (i % 8 == 0)
			{
				stringBuilder.Append(array2[i].ToString());
			}
		}
		return stringBuilder.ToString();
	}

	public static string smethod_8(string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("WebCruiser1.00ByHttp:Sec4app.com");
		byte[] bytes2 = Encoding.UTF8.GetBytes(string_1);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Key = bytes;
		rijndaelManaged.Mode = CipherMode.ECB;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
		byte[] array = cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length);
		return Convert.ToBase64String(array, 0, array.Length);
	}

	public static string smethod_9(string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("WebCruiser1.00ByHttp:Sec4app.com");
		byte[] array = Convert.FromBase64String(string_1);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Key = bytes;
		rijndaelManaged.Mode = CipherMode.ECB;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] bytes2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes2);
	}
}
