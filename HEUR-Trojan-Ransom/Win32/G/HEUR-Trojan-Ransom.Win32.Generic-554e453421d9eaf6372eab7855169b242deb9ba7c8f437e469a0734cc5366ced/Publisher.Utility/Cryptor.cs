using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Publisher.Utility;

public class Cryptor
{
	private static string prm_key = "qFHOogTyxI+U+0mWctzFngMWGgWUj5BB8bT2UlmnG5k=";

	private static string prm_iv = "v9WVEt44bKrmHGpayCh40DodYqxlcDTF9lGIduUh0Zw=";

	public static string decrypt(string prm_text_to_decrypt)
	{
		string result = default(string);
		CryptoStream object_ = default(CryptoStream);
		MemoryStream stream = default(MemoryStream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array = default(byte[]);
		string object_2 = default(string);
		RijndaelManaged object_3 = default(RijndaelManaged);
		byte[] object_4 = default(byte[]);
		byte[] object_5 = default(byte[]);
		byte[] array2 = default(byte[]);
		while (true)
		{
			oVWLTFNnxWOoKYpM9Bt(prm_text_to_decrypt, " ", "+");
			pxd6kUN9qgyBU7sbucL();
			if (!hxjg4vNQquJ5fGiThAu())
			{
				if (hxjg4vNQquJ5fGiThAu())
				{
					switch (6)
					{
					case 8:
						break;
					case 1:
					case 4:
						goto IL_0072;
					case 7:
						goto IL_0074;
					case 10:
						goto IL_009e;
					case 3:
						goto IL_00a9;
					case 5:
						goto IL_00b4;
					case 12:
						goto IL_00be;
					default:
						goto IL_00c6;
					case 2:
						goto IL_00d1;
					case 13:
						goto IL_00da;
					case 9:
						goto IL_00e6;
					case 6:
					case 11:
						goto end_IL_0001;
					case 14:
						return result;
					}
				}
				continue;
			}
			goto IL_0072;
			IL_00da:
			object_ = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			goto IL_00e6;
			IL_00e6:
			vEq0i6N0t53s2PTBP8B(object_, array, 0, array.Length);
			break;
			IL_0072:
			object_2 = prm_text_to_decrypt;
			goto IL_0074;
			IL_0074:
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			D5cN6iNK9EZcKF4PUuh(rijndaelManaged, PaddingMode.Zeros);
			WUqnWiN7SCJB6YU46a1(rijndaelManaged, CipherMode.CBC);
			BJk4aJNEtrTD2x23c38(rijndaelManaged, 256);
			rijndaelManaged.BlockSize = 256;
			object_3 = rijndaelManaged;
			goto IL_009e;
			IL_009e:
			object_4 = (byte[])xiDBqWNqHOLyyiitplA(prm_key);
			goto IL_00a9;
			IL_00a9:
			object_5 = (byte[])xiDBqWNqHOLyyiitplA(prm_iv);
			goto IL_00b4;
			IL_00b4:
			transform = (ICryptoTransform)cubh28NoAaBEeTwTJDh(object_3, object_4, object_5);
			goto IL_00be;
			IL_00be:
			array2 = (byte[])xiDBqWNqHOLyyiitplA(object_2);
			goto IL_00c6;
			IL_00c6:
			array = new byte[array2.Length];
			goto IL_00d1;
			IL_00d1:
			stream = new MemoryStream(array2);
			goto IL_00da;
			continue;
			end_IL_0001:
			break;
		}
		return (string)QC2esbNlN8Y7Xtuw3XB(AyvkZBNh6dDQNbjh8qw(), array);
	}

	public Cryptor()
	{
		Glu56bNmfpnm8wQr84v(this);
	}

	internal static object oVWLTFNnxWOoKYpM9Bt(object object_0, object object_1, object object_2)
	{
		return ((string)object_0).Replace((string)object_1, (string?)object_2);
	}

	internal static void D5cN6iNK9EZcKF4PUuh(object object_0, PaddingMode paddingMode_0)
	{
		((SymmetricAlgorithm)object_0).Padding = paddingMode_0;
	}

	internal static void WUqnWiN7SCJB6YU46a1(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static void BJk4aJNEtrTD2x23c38(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).KeySize = int_0;
	}

	internal static object xiDBqWNqHOLyyiitplA(object object_0)
	{
		return Convert.FromBase64String((string)object_0);
	}

	internal static object cubh28NoAaBEeTwTJDh(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static int vEq0i6N0t53s2PTBP8B(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static object AyvkZBNh6dDQNbjh8qw()
	{
		return Encoding.ASCII;
	}

	internal static object QC2esbNlN8Y7Xtuw3XB(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static bool hxjg4vNQquJ5fGiThAu()
	{
		return true;
	}

	internal static bool pxd6kUN9qgyBU7sbucL()
	{
		return false;
	}

	internal static void Glu56bNmfpnm8wQr84v(object object_0)
	{
		object_0._002Ector();
	}
}
