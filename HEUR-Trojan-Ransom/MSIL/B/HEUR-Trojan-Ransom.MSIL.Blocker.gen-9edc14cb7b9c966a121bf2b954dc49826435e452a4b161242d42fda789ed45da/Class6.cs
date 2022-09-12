using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

internal class Class6
{
	static Class6()
	{
	}

	public static Stream smethod_0(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(stream_0);
		int num = default(int);
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		MemoryStream memoryStream2 = default(MemoryStream);
		while (true)
		{
			switch (Class12.smethod_1(73))
			{
			case 6:
			{
				num = binaryReader.ReadUInt16();
				int num2 = 4;
				goto case 4;
			}
			case 4:
			{
				array = new byte[num];
				int num2 = 5;
				goto case 5;
			}
			case 5:
			{
				binaryReader.Read(array, 0, num);
				int num2 = 2;
				goto case 2;
			}
			case 2:
			{
				num3 = binaryReader.ReadByte();
				int num2 = 8;
				goto case 8;
			}
			case 8:
			{
				array2 = new byte[num3];
				int num2 = 0;
				goto case 0;
			}
			case 0:
			{
				binaryReader.Read(array2, 0, array2.Length);
				int num2 = 1;
				goto case 1;
			}
			case 1:
			{
				num4 = 0;
				int num2 = 3;
				goto case 3;
			}
			case 3:
			{
				if (num4 == 0)
				{
					goto IL_009d;
				}
				int num2 = 7;
				goto case 7;
			}
			case 9:
				num4++;
				goto IL_009d;
			case 7:
				{
					array[num4] = (byte)(array[num4] ^ array2[num4 % num3]);
					int num2 = 9;
					goto case 9;
				}
				IL_009d:
				if (num4 >= num)
				{
					byte b = 0;
					SymmetricAlgorithm symmetricAlgorithm = null;
					BinaryReader binaryReader2 = new BinaryReader(new MemoryStream(array, writable: false));
					try
					{
						binaryReader2.ReadString();
						b = binaryReader2.ReadByte();
						byte byte_ = binaryReader2.ReadByte();
						byte b2 = binaryReader2.ReadByte();
						int num5 = binaryReader2.ReadByte();
						byte[] array3 = new byte[num5];
						binaryReader2.Read(array3, 0, num5);
						if (b2 < 64)
						{
							binaryReader2.Read(array3, 0, num5);
						}
						else
						{
							byte[]? publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
							if (publicKey == null && 0 == 0)
							{
								throw new InvalidOperationException();
							}
							Buffer.BlockCopy(publicKey, b2 + 12, array3, 0, num5);
						}
						symmetricAlgorithm = smethod_1(byte_);
						while (true)
						{
							int num6;
							switch (Class12.smethod_1(72))
							{
							default:
								continue;
							case 0:
								symmetricAlgorithm.IV = array2;
								num6 = 1;
								break;
							case 1:
								break;
							case 2:
								goto end_IL_0156;
							}
							symmetricAlgorithm.Key = array3;
							num6 = 2;
							break;
							continue;
							end_IL_0156:
							break;
						}
					}
					finally
					{
						if (binaryReader2 != null || 1 == 0)
						{
							((IDisposable)binaryReader2).Dispose();
						}
					}
					MemoryStream memoryStream = new MemoryStream();
					if ((b & 2u) != 0 || 1 == 0)
					{
						CryptoStream cryptoStream = new CryptoStream(binaryReader.BaseStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
						try
						{
							smethod_2(cryptoStream, memoryStream);
						}
						finally
						{
							if (cryptoStream != null || 1 == 0)
							{
								((IDisposable)cryptoStream).Dispose();
							}
						}
						if (((uint)b & (true ? 1u : 0u)) != 0 || 1 == 0)
						{
							memoryStream.Position = 0L;
							while (true)
							{
								int num7 = Class12.smethod_1(82);
								while (true)
								{
									switch (num7)
									{
									case 2:
										Class12.smethod_0(memoryStream, memoryStream2);
										num7 = 0;
										goto case 0;
									case 0:
										memoryStream = memoryStream2;
										num7 = Class12.smethod_1(70);
										continue;
									case 1:
										memoryStream2 = new MemoryStream();
										num7 = 2;
										goto case 2;
									case 3:
										goto end_IL_0244;
									}
									break;
								}
								continue;
								end_IL_0244:
								break;
							}
						}
					}
					else if (b == 1)
					{
						Class12.smethod_0(binaryReader.BaseStream, memoryStream);
					}
					else
					{
						smethod_2(binaryReader.BaseStream, memoryStream);
					}
					memoryStream.Position = 0L;
					return memoryStream;
				}
				goto case 7;
			}
		}
	}

	public static SymmetricAlgorithm smethod_1(byte byte_0)
	{
		string text = null;
		switch (byte_0)
		{
		case 1:
			text = "DES";
			goto default;
		case 2:
			text = "Aes";
			goto default;
		case 3:
			text = "TripleDES";
			goto default;
		case 4:
			text = "Rijndael";
			goto default;
		case 5:
			text = "RC2";
			goto default;
		default:
		{
			string text2 = "System.Security.Cryptography." + text;
			object type = Type.GetType(text2, throwOnError: false);
			if (type == null && 0 == 0)
			{
				type = Type.GetType(text2 + ", System.Security.Cryptography.Algorithms", throwOnError: false);
			}
			if (type == null && 0 == 0)
			{
				throw new InvalidOperationException($"Could not load type {text2}");
			}
			return (SymmetricAlgorithm)((Type)type).InvokeMember("Create", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
		}
		case 6:
			return new Class5();
		}
	}

	public static void smethod_2(Stream stream_0, Stream stream_1)
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
}
