using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

[Obfuscation(Feature = "dead code", Exclude = true, StripAfterObfuscation = false)]
internal class Class49
{
	private static byte[] byte_0;

	private static byte[] byte_1;

	static Class49()
	{
		byte_0 = new byte[4];
		while (true)
		{
			int num = Class55.smethod_1(67);
			while (true)
			{
				switch (num)
				{
				case 2:
					goto IL_000d;
				case 5:
				{
					byte[] array = byte_0;
					byte_1[0] = 82;
					array[0] = 82;
					num = 4;
					goto case 4;
				}
				case 4:
				{
					byte[] array2 = byte_0;
					byte_1[1] = 83;
					array2[1] = 83;
					num = 1;
					goto case 1;
				}
				case 1:
				{
					byte[] array3 = byte_0;
					byte_1[2] = 65;
					array3[2] = 65;
					num = 3;
					goto case 3;
				}
				case 3:
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
				IL_000d:
				byte_1 = new byte[4];
				num = Class55.smethod_1(70);
			}
		}
	}

	public static Stream smethod_0(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(stream_0);
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte[] array5 = default(byte[]);
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		int num2 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		bool flag3 = default(bool);
		int num6 = default(int);
		byte[] array3 = default(byte[]);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		while (true)
		{
			int num = Class55.smethod_1(72);
			while (true)
			{
				switch (num)
				{
				case 7:
					goto IL_0009;
				case 5:
					array = new byte[num3];
					num = 0;
					goto case 0;
				case 0:
					binaryReader.Read(array, 0, num3);
					num = 2;
					goto case 2;
				case 2:
					array5 = new byte[4];
					num = 7;
					goto IL_0009;
				case 4:
					dESCryptoServiceProvider = new DESCryptoServiceProvider();
					num = 1;
					goto case 1;
				case 1:
					num3 = binaryReader.ReadUInt16();
					num = 5;
					goto case 5;
				case 6:
					num2 = 0;
					num = 3;
					goto case 3;
				case 3:
					if (num2 == 0)
					{
						goto IL_00a7;
					}
					num = 8;
					goto case 8;
				case 9:
					num2++;
					goto IL_00a7;
				case 8:
					{
						array[num2] = (byte)(array[num2] ^ array5[num2 % 4]);
						num = 9;
						goto case 9;
					}
					IL_00a7:
					if (num2 >= num3)
					{
						BinaryReader binaryReader2 = new BinaryReader(new MemoryStream(array, writable: false));
						while (true)
						{
							int num4 = Class55.smethod_1(66);
							while (true)
							{
								switch (num4)
								{
								case 6:
									goto IL_00d3;
								case 10:
									flag = binaryReader2.ReadBoolean();
									num4 = 3;
									goto case 3;
								case 3:
									flag2 = binaryReader2.ReadBoolean();
									num4 = 9;
									goto case 9;
								case 9:
									num5 = binaryReader2.ReadInt32();
									num4 = 4;
									goto case 4;
								case 4:
									array2 = new byte[num5];
									num4 = 5;
									goto case 5;
								case 5:
									binaryReader2.Read(array2, 0, num5);
									num4 = 8;
									goto case 8;
								case 8:
									flag3 = binaryReader2.ReadBoolean();
									num4 = 7;
									goto case 7;
								case 7:
									num6 = binaryReader2.ReadByte();
									num4 = 2;
									goto case 2;
								case 2:
									array3 = new byte[num6];
									num4 = 0;
									goto case 0;
								case 0:
									rSACryptoServiceProvider = null;
									num4 = 1;
									goto case 1;
								case 1:
									if (flag3)
									{
										num4 = 11;
									}
									else if (0 == 0)
									{
										byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
										if (publicKey == null || publicKey.Length != 160)
										{
											throw new InvalidOperationException();
										}
										Buffer.BlockCopy(publicKey, 12, array3, 0, num6);
										while (true)
										{
											switch (Class55.smethod_1(65))
											{
											default:
												continue;
											case 1:
											{
												array3[5] |= 128;
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
								case 11:
								{
									if (flag || 1 == 0)
									{
										if (flag3 || 1 == 0)
										{
											binaryReader2.Read(array3, 0, num6);
										}
										int num8 = binaryReader2.ReadByte();
										byte[] array4 = new byte[num8];
										binaryReader2.Read(array4, 0, num8);
										dESCryptoServiceProvider.IV = array4;
										dESCryptoServiceProvider.Key = array3;
									}
									MemoryStream memoryStream = new MemoryStream();
									if (flag || 1 == 0)
									{
										CryptoStream cryptoStream = new CryptoStream(binaryReader.BaseStream, dESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read);
										try
										{
											if (flag2 || 1 == 0)
											{
												Class55.smethod_0(cryptoStream, memoryStream);
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
										Class55.smethod_0(binaryReader.BaseStream, memoryStream);
									}
									else
									{
										smethod_2(binaryReader.BaseStream, memoryStream);
									}
									if (rSACryptoServiceProvider != null || 1 == 0)
									{
										memoryStream.Position = 0L;
										if (!smethod_5(rSACryptoServiceProvider, memoryStream, array2) && 0 == 0)
										{
											throw new InvalidOperationException();
										}
									}
									memoryStream.Position = 0L;
									return memoryStream;
								}
								}
								break;
								IL_00d3:
								binaryReader2.ReadString();
								num4 = Class55.smethod_1(61);
							}
						}
					}
					goto case 8;
				}
				break;
				IL_0009:
				binaryReader.Read(array5, 0, 4);
				num = Class55.smethod_1(66);
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
			int num2 = Class55.smethod_1(78);
			while (true)
			{
				switch (num2)
				{
				case 7:
					num += 8;
					num2 = 3;
					goto case 3;
				case 3:
					num3 = 4;
					num2 = 0;
					goto IL_0081;
				case 0:
					goto IL_0081;
				case 4:
					Array.Reverse((Array)result.Exponent);
					num2 = 5;
					goto case 5;
				case 5:
					num += num3;
					num2 = 1;
					goto case 1;
				case 1:
					num3 = 128;
					num2 = 8;
					goto case 8;
				case 8:
					result.Modulus = smethod_1(byte_2, num, num3);
					num2 = 2;
					goto case 2;
				case 2:
					Array.Reverse((Array)result.Modulus);
					num2 = 6;
					goto case 6;
				case 6:
					if (flag)
					{
						num2 = 9;
					}
					else if (true)
					{
						num += num3;
						while (true)
						{
							int num4 = Class55.smethod_1(64);
							while (true)
							{
								switch (num4)
								{
								case 22:
									num3 = 64;
									num4 = 21;
									goto case 21;
								case 21:
									result.P = smethod_1(byte_2, num, num3);
									num4 = 5;
									goto IL_0144;
								case 5:
									goto IL_0144;
								case 4:
									num += num3;
									num4 = 1;
									goto case 1;
								case 1:
									num3 = 64;
									num4 = 17;
									goto case 17;
								case 17:
									result.Q = smethod_1(byte_2, num, num3);
									num4 = 8;
									goto case 8;
								case 8:
									Array.Reverse((Array)result.Q);
									num4 = 11;
									goto case 11;
								case 11:
									num += num3;
									num4 = 0;
									goto case 0;
								case 0:
									num3 = 64;
									num4 = 3;
									goto case 3;
								case 3:
									result.DP = smethod_1(byte_2, num, num3);
									num4 = 19;
									goto case 19;
								case 19:
									Array.Reverse((Array)result.DP);
									num4 = 18;
									goto case 18;
								case 18:
									num += num3;
									num4 = 14;
									goto case 14;
								case 14:
									num3 = 64;
									num4 = 16;
									goto case 16;
								case 16:
									result.DQ = smethod_1(byte_2, num, num3);
									num4 = 7;
									goto case 7;
								case 7:
									Array.Reverse((Array)result.DQ);
									num4 = 9;
									goto case 9;
								case 9:
									num += num3;
									num4 = 6;
									goto case 6;
								case 6:
									num3 = 64;
									num4 = 20;
									goto case 20;
								case 20:
									result.InverseQ = smethod_1(byte_2, num, num3);
									num4 = 15;
									goto case 15;
								case 15:
									Array.Reverse((Array)result.InverseQ);
									num4 = 12;
									goto case 12;
								case 12:
									num += num3;
									num4 = 2;
									goto case 2;
								case 2:
									num3 = 128;
									num4 = 13;
									goto case 13;
								case 13:
									result.D = smethod_1(byte_2, num, num3);
									num4 = 10;
									goto case 10;
								case 10:
									Array.Reverse((Array)result.D);
									num4 = 23;
									goto case 23;
								case 23:
									return result;
								}
								break;
								IL_0144:
								Array.Reverse((Array)result.P);
								num4 = Class55.smethod_1(72);
							}
						}
					}
					goto case 9;
				case 9:
					return result;
				}
				break;
				IL_0081:
				result.Exponent = smethod_1(byte_2, num, num3);
				num2 = Class55.smethod_1(72);
			}
		}
	}

	private static bool smethod_4(byte[] byte_2, byte[] byte_3, int int_0)
	{
		int num = 0;
		while (true)
		{
			switch (Class55.smethod_1(65))
			{
			default:
				continue;
			case 1:
			{
				if (num == 0)
				{
					goto IL_0028;
				}
				int num2 = 0;
				goto case 0;
			}
			case 0:
			{
				if (byte_2[num + int_0] == byte_3[num])
				{
					num++;
					goto IL_0028;
				}
				int num2 = 2;
				break;
			}
			case 2:
				break;
				IL_0028:
				if (num >= byte_3.Length)
				{
					return true;
				}
				goto case 0;
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
