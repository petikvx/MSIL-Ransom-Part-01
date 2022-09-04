using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace ___codefort;

internal static class Class22
{
	private static readonly Dictionary<int, string> dictionary_0 = new Dictionary<int, string>(252);

	private static BinaryReader binaryReader_0;

	private static byte[] byte_0;

	private static short short_0;

	private static int int_0;

	private static byte[] byte_1;

	internal static string smethod_0(int int_1)
	{
		lock (dictionary_0)
		{
			byte[] array;
			int num5;
			string value;
			while (true)
			{
				if (!dictionary_0.TryGetValue(int_1, out value))
				{
					if (binaryReader_0 == null)
					{
						Assembly executingAssembly = Assembly.GetExecutingAssembly();
						Assembly callingAssembly = Assembly.GetCallingAssembly();
						int_0 = 1610370;
						Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("\u200a\u2009\u2000\u200a\u200a\u2006\u2009\u2006\u2009\u200b\u2006");
						int num = 1;
						StackTrace stackTrace = new StackTrace(1, fNeedFileInfo: false);
						int_0 ^= 6471;
						num = 0;
						StackFrame frame = stackTrace.GetFrame(0);
						MethodBase methodBase = frame?.GetMethod();
						int_0 ^= num + 128;
						Type type = methodBase?.DeclaringType;
						if (frame == null)
						{
							int_0 ^= 219315;
						}
						bool flag = (object)type == typeof(RuntimeMethodHandle);
						int_0 ^= 160;
						if (!flag && (flag = (object)type == null))
						{
							int_0 ^= 219283;
						}
						if (flag == (stackTrace != null))
						{
							int_0 ^= 32;
						}
						int_0 ^= 0x1966 | (num + 1);
						binaryReader_0 = new BinaryReader(manifestResourceStream);
						short num2 = (short)(binaryReader_0.ReadInt16() ^ 0x2AC2);
						if (num2 == 0)
						{
							short_0 = (short)(binaryReader_0.ReadInt16() ^ 0x58B2);
						}
						else
						{
							byte_0 = binaryReader_0.ReadBytes(num2);
						}
						callingAssembly = executingAssembly;
						AssemblyName assemblyName;
						try
						{
							assemblyName = callingAssembly.GetName();
						}
						catch
						{
							assemblyName = new AssemblyName(callingAssembly.FullName);
						}
						byte_1 = assemblyName.GetPublicKeyToken();
						if (byte_1 != null && byte_1.Length == 0)
						{
							byte_1 = null;
						}
						int_0 = (int_0 & 0xFFFFF72) ^ 0x1A84;
					}
					int num3 = int_1 ^ 0x2BFC86C5;
					binaryReader_0.BaseStream.Position = num3;
					if (byte_0 == null)
					{
						short num4 = ((short_0 != -1) ? short_0 : ((short)(binaryReader_0.ReadInt16() ^ 0x400B ^ num3)));
						array = ((num4 != 0) ? binaryReader_0.ReadBytes(num4) : null);
					}
					else
					{
						array = byte_0;
					}
					num5 = binaryReader_0.ReadInt32() ^ num3 ^ 0x7D722A87;
					if (num5 != -2)
					{
						break;
					}
					byte[] array2 = binaryReader_0.ReadBytes(4);
					int_1 = 2104633991;
					int_1 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -2104633991;
					continue;
				}
				return value;
			}
			bool flag2 = (num5 & int.MinValue) != 0;
			bool flag3 = (num5 & 0x40000000) != 0;
			num5 &= 0x3FFFFFFF;
			byte[] array3 = Class24.smethod_0(array, binaryReader_0.ReadBytes(num5));
			if (byte_1 != null != (int_0 != 1607814))
			{
				for (int i = 0; i < num5; i++)
				{
					byte b = byte_1[i & 7];
					b = (byte)((b << 3) | (b >> 5));
					array3[i] = (byte)(array3[i] ^ b);
				}
			}
			int num6 = int_0 - 12;
			byte[] array4;
			int num7;
			if (!flag3)
			{
				array4 = array3;
				num7 = num5;
			}
			else
			{
				num7 = array3[2] | (array3[0] << 16) | (array3[3] << 8) | (array3[1] << 24);
				array4 = new byte[num7];
				smethod_1(array3, 4, array4);
			}
			if (flag2 && num6 == 1607802)
			{
				char[] array5 = new char[num7];
				for (int j = 0; j < num7; j++)
				{
					array5[j] = (char)array4[j];
				}
				value = new string(array5);
			}
			else
			{
				value = Encoding.Unicode.GetString(array4, 0, array4.Length);
			}
			num6 += 127 + (num6 & 3) << 5;
			if (num6 != 1611930)
			{
				value = ((int_1 + num5) ^ 0xE4A78 ^ (num6 & 0x50D)).ToString("X");
			}
			value = string.Intern(value);
			dictionary_0.Add(int_1, value);
			if (dictionary_0.Count == 252)
			{
				binaryReader_0.Close();
				binaryReader_0 = null;
				byte_0 = (byte_1 = null);
			}
			return value;
		}
	}

	private static int smethod_1(byte[] byte_2, int int_1, byte[] byte_3)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = byte_3.Length;
		while (true)
		{
			if (num < num4)
			{
				if ((num3 <<= 1) == 256)
				{
					num3 = 1;
					num2 = byte_2[int_1++];
				}
				if ((num2 & num3) != 0)
				{
					int num5 = (byte_2[int_1] >> 2) + 3;
					int num6 = ((byte_2[int_1] << 8) | byte_2[int_1 + 1]) & 0x3FF;
					int_1 += 2;
					int num7 = num - num6;
					if (num7 < 0)
					{
						break;
					}
					while (--num5 >= 0 && num < num4)
					{
						byte_3[num++] = byte_3[num7++];
					}
				}
				else
				{
					byte_3[num++] = byte_2[int_1++];
				}
				continue;
			}
			return 0;
		}
		return -1;
	}
}
