using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using EkIJjm7vjs8xMISmTn;

namespace T4AVloLo3GmoMESFejF;

internal sealed class giOUDSLId3cDUJYbAHV
{
	public static string sBIDjQEUYK;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] QjrDlB7EpV(object _0020, object _0020)
	{
		//Discarded unreachable code: IL_0015, IL_018a
		int num = 4;
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		CryptoStream cryptoStream = default(CryptoStream);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array4 = default(byte[]);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array5 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					rSACryptoServiceProvider = null;
					goto case 7;
				default:
					num2 = 7;
					continue;
				case 6:
					sBIDjQEUYK = teuVAA2ghHDQmtOkUp.dYB2ebULO8(45627);
					num = 5;
					break;
				case 2:
					cryptoStream = null;
					num = 8;
					break;
				case 0:
				case 4:
					if (((string)_0020).StartsWith(teuVAA2ghHDQmtOkUp.dYB2ebULO8(45622)))
					{
						num2 = 6;
						if (0 == 0)
						{
							continue;
						}
						goto case 5;
					}
					rijndaelManaged = null;
					num2 = 1;
					continue;
				case 5:
					return null;
				case 7:
					memoryStream = null;
					num = 2;
					break;
				case 8:
					try
					{
						rijndaelManaged = new RijndaelManaged();
						rSACryptoServiceProvider = new RSACryptoServiceProvider();
						rSACryptoServiceProvider.FromXmlString((string)_0020);
						rijndaelManaged.GenerateKey();
						rijndaelManaged.GenerateIV();
						byte[] array = new byte[48];
						Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
						Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
						memoryStream = new MemoryStream();
						try
						{
							byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
							memoryStream.WriteByte(1);
							memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
							memoryStream.Write(array2, 0, array2.Length);
						}
						catch (CryptographicException)
						{
							try
							{
								byte[] array3 = new byte[16];
								int num3 = 8;
								while (true)
								{
									IL_0193:
									int num4 = num3;
									while (true)
									{
										switch (num4)
										{
										case 7:
											memoryStream.Write(array4, 0, array4.Length);
											num3 = 2;
											break;
										case 4:
										case 10:
											array6 = rSACryptoServiceProvider.Encrypt(array7, fOAEP: false);
											goto case 11;
										default:
											num3 = 11;
											break;
										case 9:
											memoryStream.WriteByte(2);
											num3 = 5;
											break;
										case 6:
											Buffer.BlockCopy(rijndaelManaged.Key, 16, array7, 0, 16);
											num4 = 1;
											if (lDjETTgUw7jGuPqvT5B())
											{
												continue;
											}
											goto case 8;
										case 8:
											array7 = new byte[16];
											num4 = 0;
											if (WiskvCghKns0PBab1op())
											{
											}
											continue;
										case 2:
											memoryStream.Write(array6, 0, array6.Length);
											num3 = 12;
											break;
										case 0:
											Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
											num3 = 6;
											break;
										case 5:
											memoryStream.WriteByte(Convert.ToByte(array4.Length / 8));
											num4 = 7;
											if (lDjETTgUw7jGuPqvT5B())
											{
												continue;
											}
											goto case 11;
										case 11:
											array5 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
											num3 = 9;
											break;
										case 1:
										case 3:
											array4 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
											num4 = 10;
											if (0 == 0)
											{
												continue;
											}
											goto case 12;
										case 12:
											memoryStream.Write(array5, 0, array5.Length);
											goto end_IL_0197;
										}
										goto IL_0193;
										continue;
										end_IL_0197:
										break;
									}
									break;
								}
							}
							catch (CryptographicException)
							{
								sBIDjQEUYK = teuVAA2ghHDQmtOkUp.dYB2ebULO8(45720);
								return null;
							}
						}
						cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
						cryptoStream.Write((byte[])_0020, 0, ((Array)_0020).Length);
						cryptoStream.FlushFinalBlock();
						return memoryStream.ToArray();
					}
					catch (Exception ex3)
					{
						sBIDjQEUYK = teuVAA2ghHDQmtOkUp.dYB2ebULO8(45926) + ex3.Message;
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
				break;
			}
		}
	}

	internal static bool lDjETTgUw7jGuPqvT5B()
	{
		return true;
	}

	internal static bool WiskvCghKns0PBab1op()
	{
		return false;
	}
}
