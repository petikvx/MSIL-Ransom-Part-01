using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MySql.Data.MySqlClient.Authentication;

public class MySqlPemReader
{
	public static RSACryptoServiceProvider ConvertPemToRSAProvider(byte[] rawPublicKey)
	{
		return DecodeX509Key(DecodeOpenSslKey(rawPublicKey));
	}

	private static RSACryptoServiceProvider DecodeX509Key(byte[] key)
	{
		if (key == null)
		{
			return null;
		}
		byte[] array = new byte[15]
		{
			48, 13, 6, 9, 42, 134, 72, 134, 247, 13,
			1, 1, 1, 5, 0
		};
		using MemoryStream input = new MemoryStream(key);
		using BinaryReader binaryReader = new BinaryReader(input);
		try
		{
			switch (binaryReader.ReadUInt16())
			{
			default:
				return null;
			case 33328:
				binaryReader.ReadInt16();
				break;
			case 33072:
				binaryReader.ReadByte();
				break;
			}
			byte[] array2 = binaryReader.ReadBytes(15);
			bool flag = true;
			if (array2.Length == array.Length)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array2[i] != array[i])
					{
						flag = false;
					}
				}
			}
			if (!flag)
			{
				return null;
			}
			ushort num = binaryReader.ReadUInt16();
			if (num == 33027)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num != 33283)
				{
					return null;
				}
				binaryReader.ReadInt16();
			}
			if (binaryReader.ReadByte() != 0)
			{
				return null;
			}
			num = binaryReader.ReadUInt16();
			if (num == 33072)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num != 33328)
				{
					return null;
				}
				binaryReader.ReadInt16();
			}
			num = binaryReader.ReadUInt16();
			byte b = 0;
			byte b2 = 0;
			if (num == 33026)
			{
				b = binaryReader.ReadByte();
			}
			else
			{
				if (num != 33282)
				{
					return null;
				}
				b2 = binaryReader.ReadByte();
				b = binaryReader.ReadByte();
			}
			int num2 = BitConverter.ToInt32(new byte[4] { b, b2, 0, 0 }, 0);
			byte num3 = binaryReader.ReadByte();
			binaryReader.BaseStream.Seek(-1L, SeekOrigin.Current);
			if (num3 == 0)
			{
				binaryReader.ReadByte();
				num2--;
			}
			byte[] modulus = binaryReader.ReadBytes(num2);
			if (binaryReader.ReadByte() != 2)
			{
				return null;
			}
			byte[] exponent = binaryReader.ReadBytes(binaryReader.ReadByte());
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			RSAParameters parameters = new RSAParameters
			{
				Modulus = modulus,
				Exponent = exponent
			};
			rSACryptoServiceProvider.ImportParameters(parameters);
			return rSACryptoServiceProvider;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static byte[] DecodeOpenSslKey(byte[] rawPublicKey)
	{
		if (rawPublicKey == null)
		{
			return null;
		}
		rawPublicKey = rawPublicKey.Where((byte b) => b != 13).ToArray();
		rawPublicKey = rawPublicKey.Where((byte b) => b != 10).ToArray();
		rawPublicKey = TrimByteArray(rawPublicKey);
		byte[] array = new byte[26]
		{
			45, 45, 45, 45, 45, 66, 69, 71, 73, 78,
			32, 80, 85, 66, 76, 73, 67, 32, 75, 69,
			89, 45, 45, 45, 45, 45
		};
		byte[] array2 = new byte[24]
		{
			45, 45, 45, 45, 45, 69, 78, 68, 32, 80,
			85, 66, 76, 73, 67, 32, 75, 69, 89, 45,
			45, 45, 45, 45
		};
		if (StartsWith(rawPublicKey, array) && EndsWith(rawPublicKey, array2))
		{
			byte[] array3 = new byte[rawPublicKey.Length - array.Length - array2.Length];
			Array.Copy(rawPublicKey, array.Length, array3, 0, array3.Length);
			try
			{
				return Convert.FromBase64String(Encoding.Default.GetString(array3));
			}
			catch (FormatException)
			{
				return null;
			}
		}
		return null;
	}

	private static byte[] TrimByteArray(byte[] array)
	{
		List<byte> list = new List<byte>();
		bool flag = false;
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			if (!flag)
			{
				if (b == 32)
				{
					continue;
				}
				flag = true;
			}
			list.Add(b);
		}
		array = list.ToArray();
		list = new List<byte>();
		for (int num = array.Length - 1; num >= 0; num--)
		{
			if (!flag)
			{
				if (array[num] == 32)
				{
					continue;
				}
				flag = true;
			}
			list.Add(array[num]);
		}
		return list.ToArray().Reverse().ToArray();
	}

	private static bool StartsWith(byte[] array, byte[] containedArray)
	{
		for (int i = 0; i < array.Length && i != containedArray.Length; i++)
		{
			if (array[i] != containedArray[i])
			{
				return false;
			}
		}
		return true;
	}

	private static bool EndsWith(byte[] array, byte[] containedArray)
	{
		int num = array.Length - 1;
		int num2 = 0;
		while (num >= 0 && num2 != containedArray.Length)
		{
			if (array[num] == containedArray[containedArray.Length - num2 - 1])
			{
				num--;
				num2++;
				continue;
			}
			return false;
		}
		return true;
	}
}
