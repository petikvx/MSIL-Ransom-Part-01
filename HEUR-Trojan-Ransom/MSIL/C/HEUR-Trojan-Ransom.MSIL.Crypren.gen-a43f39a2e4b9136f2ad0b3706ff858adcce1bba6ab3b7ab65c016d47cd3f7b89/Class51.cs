using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

[Obfuscation(Feature = "dead code", Exclude = true, StripAfterObfuscation = false)]
internal class Class51
{
	private static byte[] byte_0;

	private static byte[] byte_1;

	static Class51()
	{
		byte_0 = new byte[4];
		while (true)
		{
			int num = Class57.smethod_1(78);
			while (true)
			{
				switch (num)
				{
				case 5:
				{
					byte[] array2 = byte_0;
					byte_1[0] = 82;
					array2[0] = 82;
					num = 3;
					goto IL_0021;
				}
				case 3:
					goto IL_0021;
				case 4:
					byte_1 = new byte[4];
					num = 5;
					goto case 5;
				case 2:
				{
					byte[] array = byte_0;
					byte_1[2] = 65;
					array[2] = 65;
					num = 1;
					goto case 1;
				}
				case 1:
					byte_0[3] = 49;
					num = 0;
					goto case 0;
				case 0:
					byte_1[3] = 50;
					num = 6;
					return;
				case 6:
					return;
				}
				break;
				IL_0021:
				byte[] array3 = byte_0;
				byte_1[1] = 83;
				array3[1] = 83;
				num = Class57.smethod_1(83);
			}
		}
	}

	public static Stream smethod_0(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(stream_0);
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		int num = binaryReader.ReadUInt16();
		byte[] array = new byte[num];
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		byte[] array3 = default(byte[]);
		int num5 = default(int);
		bool flag3 = default(bool);
		int num6 = default(int);
		byte[] array4 = default(byte[]);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = Class57.smethod_1(80);
			while (true)
			{
				switch (num2)
				{
				case 4:
					goto IL_001d;
				case 1:
					binaryReader.Read(array, 0, num);
					num2 = 4;
					goto IL_001d;
				case 5:
					binaryReader.Read(array2, 0, 4);
					num2 = 0;
					goto case 0;
				case 0:
					num3 = 0;
					num2 = 3;
					goto case 3;
				case 3:
					if (num3 == 0)
					{
						goto IL_0090;
					}
					num2 = 2;
					goto case 2;
				case 6:
					num3++;
					goto IL_0090;
				case 2:
					{
						array[num3] = (byte)(array[num3] ^ array2[num3 % 4]);
						num2 = 6;
						goto case 6;
					}
					IL_0090:
					if (num3 >= num)
					{
						BinaryReader binaryReader2 = new BinaryReader(new MemoryStream(array, writable: false));
						while (true)
						{
							int num4 = Class57.smethod_1(76);
							while (true)
							{
								switch (num4)
								{
								case 10:
									array3 = new byte[num5];
									num4 = 5;
									goto case 5;
								case 5:
									binaryReader2.Read(array3, 0, num5);
									num4 = 4;
									goto case 4;
								case 4:
									flag3 = binaryReader2.ReadBoolean();
									num4 = 8;
									goto case 8;
								case 8:
									num6 = binaryReader2.ReadByte();
									num4 = 3;
									goto case 3;
								case 3:
									array4 = new byte[num6];
									num4 = 7;
									goto case 7;
								case 7:
									rSACryptoServiceProvider = null;
									num4 = 2;
									goto case 2;
								case 2:
									if (flag3)
									{
										goto IL_010b;
									}
									if (0 == 0)
									{
										byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
										if (publicKey == null || publicKey.Length != 160)
										{
											throw new InvalidOperationException();
										}
										Buffer.BlockCopy(publicKey, 12, array4, 0, num6);
										while (true)
										{
											switch (Class57.smethod_1(80))
											{
											default:
												continue;
											case 1:
											{
												array4[5] |= 128;
												int num7 = 0;
												goto case 0;
											}
											case 0:
											{
												rSACryptoServiceProvider = new RSACryptoServiceProvider();
												int num7 = 2;
												break;
											}
											case 2:
												break;
											}
											break;
										}
										rSACryptoServiceProvider.ImportParameters(smethod_3(publicKey));
									}
									goto case 11;
								case 9:
									binaryReader2.ReadString();
									num4 = 6;
									goto case 6;
								case 6:
									flag = binaryReader2.ReadBoolean();
									num4 = 0;
									goto case 0;
								case 0:
									flag2 = binaryReader2.ReadBoolean();
									num4 = 1;
									goto case 1;
								case 1:
									num5 = binaryReader2.ReadInt32();
									num4 = 10;
									goto case 10;
								case 11:
								{
									if (flag || 1 == 0)
									{
										if (flag3 || 1 == 0)
										{
											binaryReader2.Read(array4, 0, num6);
										}
										int num8 = binaryReader2.ReadByte();
										byte[] array5 = new byte[num8];
										binaryReader2.Read(array5, 0, num8);
										dESCryptoServiceProvider.IV = array5;
										dESCryptoServiceProvider.Key = array4;
									}
									MemoryStream memoryStream = new MemoryStream();
									if (flag || 1 == 0)
									{
										CryptoStream cryptoStream = new CryptoStream(binaryReader.BaseStream, dESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read);
										try
										{
											if (flag2 || 1 == 0)
											{
												Class57.smethod_0(cryptoStream, memoryStream);
											}
											else
											{
												smethod_2(cryptoStream, memoryStream);
											}
										}
										finally
										{
											if (cryptoStream != null || 1 == 0)
											{
												((IDisposable)cryptoStream).Dispose();
											}
										}
									}
									else if (flag2 || 1 == 0)
									{
										Class57.smethod_0(binaryReader.BaseStream, memoryStream);
									}
									else
									{
										smethod_2(binaryReader.BaseStream, memoryStream);
									}
									if (rSACryptoServiceProvider != null || 1 == 0)
									{
										memoryStream.Position = 0L;
										if (!smethod_5(rSACryptoServiceProvider, memoryStream, array3) && 0 == 0)
										{
											throw new InvalidOperationException();
										}
									}
									memoryStream.Position = 0L;
									return memoryStream;
								}
								}
								break;
								IL_010b:
								num4 = Class57.smethod_1(85);
							}
						}
					}
					goto case 2;
				}
				break;
				IL_001d:
				array2 = new byte[4];
				num2 = Class57.smethod_1(82);
			}
		}
	}

	private static byte[] smethod_1(byte[] byte_2, int int_0, int int_1)
	{
		if ((byte_2 != null || 1 == 0) && byte_2.Length >= int_0 + int_1)
		{
			byte[] array = new byte[int_1];
			Array.Copy(byte_2, int_0, array, 0, int_1);
			return array;
		}
		return null;
	}

	private static void smethod_2(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		while (true)
		{
			int num = stream_0.Read(array, 0, array.Length);
			if (num > 0)
			{
				stream_1.Write(array, 0, num);
				continue;
			}
			break;
		}
	}

	private static RSAParameters smethod_3(byte[] byte_2)
	{
		bool flag;
		if (((flag = byte_2.Length == 160) || 1 == 0) && !smethod_4(byte_2, byte_0, 20) && 0 == 0)
		{
			return default(RSAParameters);
		}
		if (!flag && 0 == 0 && !smethod_4(byte_2, byte_1, 8) && 0 == 0)
		{
			return default(RSAParameters);
		}
		RSAParameters result = default(RSAParameters);
		int num = ((flag ? true : false) ? 20 : 8);
		int num3 = default(int);
		while (true)
		{
			int num2 = Class57.smethod_1(82);
			while (true)
			{
				switch (num2)
				{
				case 8:
					result.Exponent = smethod_1(byte_2, num, num3);
					num2 = 4;
					goto case 4;
				case 4:
					Array.Reverse((Array)result.Exponent);
					num2 = 3;
					goto case 3;
				case 3:
					num += num3;
					num2 = 6;
					goto IL_009c;
				case 6:
					goto IL_009c;
				case 7:
					num3 = 4;
					num2 = 8;
					goto case 8;
				case 5:
					num += 8;
					num2 = 7;
					goto case 7;
				case 2:
					result.Modulus = smethod_1(byte_2, num, num3);
					num2 = 1;
					goto case 1;
				case 1:
					Array.Reverse((Array)result.Modulus);
					num2 = 0;
					goto case 0;
				case 0:
					if (flag)
					{
						num2 = 9;
					}
					else if (true)
					{
						num += num3;
						while (true)
						{
							int num4 = Class57.smethod_1(88);
							while (true)
							{
								switch (num4)
								{
								case 22:
									num3 = 64;
									num4 = 15;
									goto case 15;
								case 15:
									result.P = smethod_1(byte_2, num, num3);
									num4 = 13;
									goto case 13;
								case 13:
									Array.Reverse((Array)result.P);
									num4 = 5;
									goto case 5;
								case 5:
									num += num3;
									num4 = 3;
									goto case 3;
								case 3:
									num3 = 64;
									num4 = 19;
									goto IL_0167;
								case 19:
									goto IL_0167;
								case 17:
									Array.Reverse((Array)result.Q);
									num4 = 1;
									goto case 1;
								case 1:
									num += num3;
									num4 = 7;
									goto case 7;
								case 7:
									num3 = 64;
									num4 = 14;
									goto case 14;
								case 14:
									result.DP = smethod_1(byte_2, num, num3);
									num4 = 4;
									goto case 4;
								case 4:
									Array.Reverse((Array)result.DP);
									num4 = 12;
									goto case 12;
								case 12:
									num += num3;
									num4 = 9;
									goto case 9;
								case 9:
									num3 = 64;
									num4 = 16;
									goto case 16;
								case 16:
									result.DQ = smethod_1(byte_2, num, num3);
									num4 = 11;
									goto case 11;
								case 11:
									Array.Reverse((Array)result.DQ);
									num4 = 21;
									goto case 21;
								case 21:
									num += num3;
									num4 = 10;
									goto case 10;
								case 10:
									num3 = 64;
									num4 = 8;
									goto case 8;
								case 8:
									result.InverseQ = smethod_1(byte_2, num, num3);
									num4 = 2;
									goto case 2;
								case 2:
									Array.Reverse((Array)result.InverseQ);
									num4 = 6;
									goto case 6;
								case 6:
									num += num3;
									num4 = 0;
									goto case 0;
								case 0:
									num3 = 128;
									num4 = 18;
									goto case 18;
								case 18:
									result.D = smethod_1(byte_2, num, num3);
									num4 = 20;
									goto case 20;
								case 20:
									Array.Reverse((Array)result.D);
									num4 = 23;
									goto case 23;
								case 23:
									return result;
								}
								break;
								IL_0167:
								result.Q = smethod_1(byte_2, num, num3);
								num4 = Class57.smethod_1(91);
							}
						}
					}
					goto case 9;
				case 9:
					return result;
				}
				break;
				IL_009c:
				num3 = 128;
				num2 = Class57.smethod_1(83);
			}
		}
	}

	private static bool smethod_4(byte[] byte_2, byte[] byte_3, int int_0)
	{
		int num = 0;
		while (true)
		{
			switch (Class57.smethod_1(84))
			{
			default:
				continue;
			case 0:
			{
				if (num == 0)
				{
					goto IL_002c;
				}
				int num2 = 1;
				goto case 1;
			}
			case 1:
			{
				if (byte_2[num + int_0] == byte_3[num])
				{
					num++;
					goto IL_002c;
				}
				int num2 = 2;
				break;
			}
			case 2:
				break;
				IL_002c:
				if (num >= byte_3.Length)
				{
					return true;
				}
				goto case 1;
			}
			break;
		}
		return false;
	}

	private static bool smethod_5(RSACryptoServiceProvider rsacryptoServiceProvider_0, Stream stream_0, byte[] byte_2)
	{
		byte[] array = (array = new SHA1CryptoServiceProvider().ComputeHash(stream_0));
		return rsacryptoServiceProvider_0.VerifyHash(array, null, byte_2);
	}
}
