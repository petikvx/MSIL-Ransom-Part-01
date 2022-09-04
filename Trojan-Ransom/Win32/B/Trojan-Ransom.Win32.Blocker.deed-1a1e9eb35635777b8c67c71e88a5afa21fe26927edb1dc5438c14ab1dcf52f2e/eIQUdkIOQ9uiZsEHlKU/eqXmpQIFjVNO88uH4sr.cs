using System;
using System.IO;
using System.Security.Cryptography;
using eC98jAqdnPLlDITmK6;
using etKNQTu9kgqwCqmIAv;

namespace eIQUdkIOQ9uiZsEHlKU;

internal class eqXmpQIFjVNO88uH4sr
{
	public static string ecs0D1Zdd;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk e9jslfSvk;

	public static byte[] eulODlten(byte[] byte_0, string string_0)
	{
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		if (eDZVcK5njkRVeGtIt9K(string_0, e9jslfSvk(22222)))
		{
			ecs0D1Zdd = e9jslfSvk(22227);
			eI75ox5NjhbitT5HV5h();
			if (!ek73On5rqASKgBXYtiY())
			{
				return null;
			}
		}
		else
		{
			rijndaelManaged = null;
			rSACryptoServiceProvider = null;
		}
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			ecVAaN5P30k3aTxkY6x(rSACryptoServiceProvider, string_0);
			eJgeGy5mc3CCiXf0Zqg(rijndaelManaged);
			ePrYTQ5xOyZs9mP77B8(rijndaelManaged);
			byte[] object_ = new byte[48];
			eAwMnQC7uM5fqhoSMB7(ewqK1q5zLlyGCLjslAo(rijndaelManaged), 0, object_, 0, 32);
			eAwMnQC7uM5fqhoSMB7(equdAPC9DeIiRCIDw10(rijndaelManaged), 0, object_, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array = (byte[])eiwI8wCkFLGaZKBJyN8(rSACryptoServiceProvider, object_, bool_0: false);
				eXDhQhCQkS9YLa1AC7V(memoryStream, 1);
				eXDhQhCQkS9YLa1AC7V(memoryStream, euQpv1CLSxjPLyXOh2f(array.Length / 8));
				eolMllCJ6c0M58kgwo4(memoryStream, array, 0, array.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] object_2 = new byte[16];
					_ = 0;
					byte[] object_3 = default(byte[]);
					byte[] array2 = default(byte[]);
					if (eI75ox5NjhbitT5HV5h())
					{
						object_3 = new byte[16];
						eAwMnQC7uM5fqhoSMB7(ewqK1q5zLlyGCLjslAo(rijndaelManaged), 0, object_2, 0, 16);
						eAwMnQC7uM5fqhoSMB7(ewqK1q5zLlyGCLjslAo(rijndaelManaged), 16, object_3, 0, 16);
						array2 = (byte[])eiwI8wCkFLGaZKBJyN8(rSACryptoServiceProvider, object_2, bool_0: false);
					}
					else if (!eI75ox5NjhbitT5HV5h())
					{
						goto IL_016b;
					}
					byte[] array3 = (byte[])eiwI8wCkFLGaZKBJyN8(rSACryptoServiceProvider, object_3, bool_0: false);
					byte[] array4 = (byte[])eiwI8wCkFLGaZKBJyN8(rSACryptoServiceProvider, equdAPC9DeIiRCIDw10(rijndaelManaged), bool_0: false);
					eXDhQhCQkS9YLa1AC7V(memoryStream, 2);
					eXDhQhCQkS9YLa1AC7V(memoryStream, euQpv1CLSxjPLyXOh2f(array2.Length / 8));
					eolMllCJ6c0M58kgwo4(memoryStream, array2, 0, array2.Length);
					eolMllCJ6c0M58kgwo4(memoryStream, array3, 0, array3.Length);
					goto IL_016b;
					IL_016b:
					eolMllCJ6c0M58kgwo4(memoryStream, array4, 0, array4.Length);
				}
				catch (CryptographicException)
				{
					ecs0D1Zdd = e9jslfSvk(22320);
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)esde12CjXVd768wxixh(rijndaelManaged), CryptoStreamMode.Write);
			eolMllCJ6c0M58kgwo4(cryptoStream, byte_0, 0, byte_0.Length);
			e8lVZtC5gJowIBH2V3S(cryptoStream);
			return (byte[])ei7x4xCCYcNZfZ0VymT(memoryStream);
		}
		catch (Exception object_4)
		{
			ecs0D1Zdd = (string)eNb9XfCgUe3KFG4PqJB(e9jslfSvk(22526), eAHZVQCZQFEIECbWRDl(object_4));
			return null;
		}
		finally
		{
			if (rijndaelManaged != null)
			{
				eTwKD6C2XZyHpGAJHSp(rijndaelManaged);
			}
			if (rSACryptoServiceProvider != null)
			{
				eVgT6CCipbd6WSyVQqY(rSACryptoServiceProvider);
			}
			if (memoryStream != null)
			{
				eDI1tRCExxYL44Wmrai(memoryStream);
			}
			if (cryptoStream != null)
			{
				eDI1tRCExxYL44Wmrai(cryptoStream);
			}
		}
	}

	static eqXmpQIFjVNO88uH4sr()
	{
		eO48M1CfnkFZB57Sbjr(eAE63pCYkmBVnVJ2APC(typeof(eqXmpQIFjVNO88uH4sr).TypeHandle));
	}

	internal static bool eDZVcK5njkRVeGtIt9K(object object_0, object object_1)
	{
		return ((string)object_0).StartsWith((string)object_1);
	}

	internal static void ecVAaN5P30k3aTxkY6x(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void eJgeGy5mc3CCiXf0Zqg(object object_0)
	{
		((SymmetricAlgorithm)object_0).GenerateKey();
	}

	internal static void ePrYTQ5xOyZs9mP77B8(object object_0)
	{
		((SymmetricAlgorithm)object_0).GenerateIV();
	}

	internal static object ewqK1q5zLlyGCLjslAo(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).Key;
	}

	internal static void eAwMnQC7uM5fqhoSMB7(object object_0, int int_0, object object_1, int int_1, int int_2)
	{
		Buffer.BlockCopy((Array)object_0, int_0, (Array)object_1, int_1, int_2);
	}

	internal static object equdAPC9DeIiRCIDw10(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).IV;
	}

	internal static object eiwI8wCkFLGaZKBJyN8(object object_0, object object_1, bool bool_0)
	{
		return ((RSACryptoServiceProvider)object_0).Encrypt((byte[])object_1, bool_0);
	}

	internal static void eXDhQhCQkS9YLa1AC7V(object object_0, byte byte_0)
	{
		((Stream)object_0).WriteByte(byte_0);
	}

	internal static byte euQpv1CLSxjPLyXOh2f(int int_0)
	{
		return Convert.ToByte(int_0);
	}

	internal static void eolMllCJ6c0M58kgwo4(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static object esde12CjXVd768wxixh(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).CreateEncryptor();
	}

	internal static void e8lVZtC5gJowIBH2V3S(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object ei7x4xCCYcNZfZ0VymT(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static object eAHZVQCZQFEIECbWRDl(object object_0)
	{
		return ((Exception)object_0).Message;
	}

	internal static object eNb9XfCgUe3KFG4PqJB(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void eTwKD6C2XZyHpGAJHSp(object object_0)
	{
		((SymmetricAlgorithm)object_0).Clear();
	}

	internal static void eVgT6CCipbd6WSyVQqY(object object_0)
	{
		((AsymmetricAlgorithm)object_0).Clear();
	}

	internal static void eDI1tRCExxYL44Wmrai(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static bool eI75ox5NjhbitT5HV5h()
	{
		return true;
	}

	internal static bool ek73On5rqASKgBXYtiY()
	{
		return false;
	}

	internal static Type eAE63pCYkmBVnVJ2APC(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void eO48M1CfnkFZB57Sbjr(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
