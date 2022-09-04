using System;
using System.IO;
using System.Security.Cryptography;
using ProwxkN4F4ab5Fc8FL;

namespace tJiWbUMC1XqMMh0Wv58;

internal sealed class s4bZe5Mjb4TvmHLmmZc
{
	public static string Shj7sh5Sk7;

	public static byte[] UvJ7gP0X6g(byte[] byte_0, string string_0)
	{
		if (!xjpOw84RhLPDHnkX6a5())
		{
			switch (1)
			{
			case 1:
				break;
			case 5:
				goto IL_0050;
			case 2:
			case 6:
				goto IL_005f;
			case 7:
				goto IL_0061;
			default:
				goto IL_0063;
			case 3:
				goto IL_0065;
			case 8:
				goto IL_0067;
			}
		}
		if (string_0.StartsWith(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(678696)))
		{
			goto IL_0050;
		}
		RijndaelManaged rijndaelManaged = null;
		goto IL_0061;
		IL_0065:
		CryptoStream cryptoStream = null;
		goto IL_0067;
		IL_0063:
		MemoryStream memoryStream = null;
		goto IL_0065;
		IL_0067:
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(string_0);
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
					byte[] array5 = default(byte[]);
					byte[] array6 = default(byte[]);
					byte[] array7 = default(byte[]);
					while (true)
					{
						IL_0150:
						byte[] array4 = new byte[16];
						int num = 10;
						if (!xjpOw84RhLPDHnkX6a5())
						{
						}
						while (true)
						{
							switch (num)
							{
							case 1:
							case 10:
								Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
								num = 2;
								if (a90JkB4k1ym0KPCk9OC())
								{
									continue;
								}
								goto case 7;
							case 0:
							case 5:
								break;
							case 2:
								Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
								goto case 3;
							case 3:
								array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
								array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
								goto case 6;
							case 6:
								array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
								goto default;
							default:
								memoryStream.WriteByte(2);
								goto case 9;
							case 9:
								memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
								goto case 8;
							case 8:
								memoryStream.Write(array5, 0, array5.Length);
								goto case 7;
							case 7:
								memoryStream.Write(array6, 0, array6.Length);
								goto case 11;
							case 11:
								memoryStream.Write(array7, 0, array7.Length);
								goto end_IL_0119;
							}
							goto IL_0150;
							continue;
							end_IL_0119:
							break;
						}
						break;
					}
				}
				catch (CryptographicException)
				{
					Shj7sh5Sk7 = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(678794);
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			Shj7sh5Sk7 = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(679000) + ex3.Message;
			return null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
		IL_0061:
		rSACryptoServiceProvider = null;
		goto IL_0063;
		IL_0050:
		Shj7sh5Sk7 = DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(678701);
		goto IL_005f;
		IL_005f:
		return null;
	}

	internal static bool a90JkB4k1ym0KPCk9OC()
	{
		return true;
	}

	internal static bool xjpOw84RhLPDHnkX6a5()
	{
		return false;
	}
}
