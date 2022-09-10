using System;
using System.IO;
using System.Security.Cryptography;

namespace Vindows.Engine.Utilities;

public static class AES
{
	internal static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		int num = 0;
		switch (0)
		{
		default:
		{
			num = -22919;
			int num2 = num;
			num = -22919;
			switch (num2 == num)
			{
			default:
			{
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				byte[] salt = new byte[8] { 5, 3, 3, 7, 8, 0, 0, 8 };
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					try
					{
						rijndaelManaged.KeySize = 256;
						rijndaelManaged.BlockSize = 128;
						Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
						rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
						rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
						rijndaelManaged.Mode = CipherMode.CBC;
						CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
						try
						{
							cryptoStream.Write(byte_0, 0, byte_0.Length);
							cryptoStream.Close();
						}
						finally
						{
							num = 2;
							int num3 = num;
							while (true)
							{
								switch (num3)
								{
								default:
									if (cryptoStream != null)
									{
										num = 0;
										num3 = num;
										continue;
									}
									break;
								case 0:
									((IDisposable)cryptoStream).Dispose();
									num = 1;
									num3 = num;
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						return memoryStream.ToArray();
					}
					finally
					{
						num = 2;
						int num3 = num;
						while (true)
						{
							switch (num3)
							{
							default:
								if (rijndaelManaged != null)
								{
									num = 0;
									num3 = num;
									continue;
								}
								break;
							case 0:
								((IDisposable)rijndaelManaged).Dispose();
								num = 1;
								num3 = num;
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					num = 2;
					int num3 = num;
					while (true)
					{
						switch (num3)
						{
						default:
							if (memoryStream != null)
							{
								num = 0;
								num3 = num;
								continue;
							}
							break;
						case 0:
							((IDisposable)memoryStream).Dispose();
							num = 1;
							num3 = num;
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
			case false:
			case true:
			{
				byte[] result = default(byte[]);
				return result;
			}
			}
		}
		}
	}
}
