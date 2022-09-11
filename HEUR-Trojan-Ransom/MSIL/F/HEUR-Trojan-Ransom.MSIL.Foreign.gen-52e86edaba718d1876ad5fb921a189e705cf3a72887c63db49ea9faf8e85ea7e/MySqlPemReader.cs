using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

public sealed class MySqlPemReader
{
	[NonSerialized]
	internal static GetString getString_0;

	public static RSACryptoServiceProvider smethod_0(byte[] byte_0)
	{
		return smethod_1(smethod_2(byte_0));
	}

	private static RSACryptoServiceProvider smethod_1(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		byte[] array = new byte[15]
		{
			48, 13, 6, 9, 42, 134, 72, 134, 247, 13,
			1, 1, 1, 5, 0
		};
		using MemoryStream input = new MemoryStream(byte_0);
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

	private static byte[] smethod_2(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		byte_0 = byte_0.Where((byte byte_0) => byte_0 != 13).ToArray();
		byte_0 = byte_0.Where((byte byte_0) => byte_0 != 10).ToArray();
		byte_0 = smethod_4(byte_0);
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
		if (smethod_5(byte_0, array) && smethod_6(byte_0, array2))
		{
			byte[] array3 = new byte[byte_0.Length - array.Length - array2.Length];
			Array.Copy(byte_0, array.Length, array3, 0, array3.Length);
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

	private static byte[] smethod_3(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		string @string = Encoding.Default.GetString(byte_0);
		@string = @string.Replace(Environment.NewLine, getString_0(107396727));
		@string = @string.Trim();
		if (@string.StartsWith(getString_0(107394016)) && @string.EndsWith(getString_0(107393979)))
		{
			StringBuilder stringBuilder = new StringBuilder(@string);
			stringBuilder.Replace(getString_0(107394016), getString_0(107396727));
			stringBuilder.Replace(getString_0(107393979), getString_0(107396727));
			string s = stringBuilder.ToString().Trim();
			try
			{
				return Convert.FromBase64String(s);
			}
			catch (FormatException)
			{
				return null;
			}
		}
		return null;
	}

	private static byte[] smethod_4(byte[] byte_0)
	{
		List<byte> list = new List<byte>();
		bool flag = false;
		byte[] array = byte_0;
		foreach (byte b in array)
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
		byte_0 = list.ToArray();
		list = new List<byte>();
		for (int num = byte_0.Length - 1; num >= 0; num--)
		{
			if (!flag)
			{
				if (byte_0[num] == 32)
				{
					continue;
				}
				flag = true;
			}
			list.Add(byte_0[num]);
		}
		return list.ToArray().Reverse().ToArray();
	}

	private static bool smethod_5(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length && i != byte_1.Length; i++)
		{
			if (byte_0[i] != byte_1[i])
			{
				return false;
			}
		}
		return true;
	}

	private static bool smethod_6(byte[] byte_0, byte[] byte_1)
	{
		int num = byte_0.Length - 1;
		int num2 = 0;
		while (num >= 0 && num2 != byte_1.Length)
		{
			if (byte_0[num] == byte_1[byte_1.Length - num2 - 1])
			{
				num--;
				num2++;
				continue;
			}
			return false;
		}
		return true;
	}

	static MySqlPemReader()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlPemReader));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107396905), getString_0(107396900)).Replace(getString_0(107396863), getString_0(107396858)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107396853)))
		{
			throw new SecurityException(getString_0(107396828));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
