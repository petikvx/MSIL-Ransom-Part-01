using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using _FFFD_0300ҟ_D997_DC9A;

namespace _2ëņ_FFFDĂ;

internal class Ś_FFFD丐ԜƟ
{
	public byte[] _0332_DA3B_DD61ӓУ(byte[] _FFFD_0300ՕŎ_0306, byte[] _0655ʭų_FFFD丐, byte[] ζʭڿ_FFFDɢ, byte[] Α_05C3ٷ㹃ا, byte[] מŔ_058Fņ泮)
	{
		IntPtr intPtr = _02E8_FFFDĂߟR(_0655콪ٵ_0609ε._2964ľǎ_FFFD_061C, _0655콪ٵ_0609ε.یzױꓞ_00AB, _0655콪ٵ_0609ε.ƜЦҟלŲ);
		IntPtr 泮蠺_0026_07B4Ł;
		IntPtr hglobal = УKå_02E8Ɖ(intPtr, _FFFD_0300ՕŎ_0306, out 泮蠺_0026_07B4Ł);
		_0655콪ٵ_0609ε.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO ĪӤԌі_FFFD = new _0655콪ٵ_0609ε.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(_0655ʭų_FFFD丐, ζʭڿ_FFFDɢ, מŔ_058Fņ泮);
		checked
		{
			byte[] array2;
			using (ĪӤԌі_FFFD)
			{
				byte[] array = new byte[_߂ջ_00BE鈇ʪ(intPtr) - 1 + 1];
				int ʤ늻盀kœ = 0;
				uint num = _0655콪ٵ_0609ε.ɩ_FFFDթKҚ(泮蠺_0026_07B4Ł, Α_05C3ٷ㹃ا, Α_05C3ٷ㹃ا.Length, ref ĪӤԌі_FFFD, array, array.Length, null, 0, ref ʤ늻盀kœ, 0);
				if (num != 0)
				{
					throw new CryptographicException($"BCrypt.BCryptDecrypt() (get size) failed with status code: {num}");
				}
				array2 = new byte[ʤ늻盀kœ - 1 + 1];
				num = _0655콪ٵ_0609ε.ɩ_FFFDթKҚ(泮蠺_0026_07B4Ł, Α_05C3ٷ㹃ا, Α_05C3ٷ㹃ا.Length, ref ĪӤԌі_FFFD, array, array.Length, array2, array2.Length, ref ʤ늻盀kœ, 0);
				if (num == _0655콪ٵ_0609ε._FFFD_26CA_FFFDհt)
				{
					throw new CryptographicException("BCrypt.BCryptDecrypt(): authentication tag mismatch");
				}
				if (num != 0)
				{
					throw new CryptographicException($"BCrypt.BCryptDecrypt() failed with status code:{num}");
				}
			}
			_0655콪ٵ_0609ε._FFFD_FFFD븤ľՕ(泮蠺_0026_07B4Ł);
			Marshal.FreeHGlobal(hglobal);
			_0655콪ٵ_0609ε.B_06E8ٵҢ_FFFD(intPtr, 0u);
			return array2;
		}
	}

	private int _߂ջ_00BE鈇ʪ(IntPtr _FFFDΑ뜸Αë)
	{
		byte[] array = _FFFDεٵی_0655(_FFFDΑ뜸Αë, _0655콪ٵ_0609ε._07BBϘ_FFFD_FFFDױ);
		return BitConverter.ToInt32(new byte[4]
		{
			array[4],
			array[5],
			array[6],
			array[7]
		}, 0);
	}

	private IntPtr _02E8_FFFDĂߟR(string _FFFD_FFFD_061C_FFFDŎ, string _060C_FFFD_FFFDϒҟ, string 늻_0655ޤ_FFFD_FFFD)
	{
		IntPtr 쐬ë_FFFD盀_FFFD = IntPtr.Zero;
		uint num = _0655콪ٵ_0609ε.䇹_0655Aҟ_06E8(out 쐬ë_FFFD盀_FFFD, _FFFD_FFFD_061C_FFFDŎ, _060C_FFFD_FFFDϒҟ, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptOpenAlgorithmProvider() failed with status code:{num}");
		}
		byte[] bytes = Encoding.Unicode.GetBytes(늻_0655ޤ_FFFD_FFFD);
		num = _0655콪ٵ_0609ε.ջʪ_05B5_FFFDŔ(쐬ë_FFFD盀_FFFD, _0655콪ٵ_0609ε._FFFD꼺Ӻ퓜_FFFD, bytes, bytes.Length, 0);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptSetAlgorithmProperty(BCrypt.BCRYPT_CHAINING_MODE, BCrypt.BCRYPT_CHAIN_MODE_GCM) failed with status code:{num}");
		}
		return 쐬ë_FFFD盀_FFFD;
	}

	private IntPtr УKå_02E8Ɖ(IntPtr _FFFDľ䇹_D9A6_DEEA, byte[] z_FFFD_FFFD_0327У, out IntPtr 泮蠺_0026_07B4Ł)
	{
		byte[] value = _FFFDεٵی_0655(_FFFDľ䇹_D9A6_DEEA, _0655콪ٵ_0609ε.ʤ_0314_0026_07BBŲ);
		int num = BitConverter.ToInt32(value, 0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		byte[] array = ʓ_0609Ɯ_05C3ŧ(_0655콪ٵ_0609ε._FFFDŚʤޤΑ, BitConverter.GetBytes(1), BitConverter.GetBytes(z_FFFD_FFFD_0327У.Length), z_FFFD_FFFD_0327У);
		uint num2 = _0655콪ٵ_0609ε.Īاœҏ_FFFD(_FFFDľ䇹_D9A6_DEEA, IntPtr.Zero, _0655콪ٵ_0609ε._2ӤߟӚœ, out 泮蠺_0026_07B4Ł, intPtr, num, array, array.Length, 0u);
		if (num2 != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptImportKey() failed with status code:{num2}");
		}
		return intPtr;
	}

	private byte[] _FFFDεٵی_0655(IntPtr _FFFD_02E8_FFFDȨ_FFFD, string _FFFDҢ_FFFD_02F3ş)
	{
		int _߂ٵ_FFFD_0609_FFFD = 0;
		uint num = _0655콪ٵ_0609ε.ɛU_FFFDO_05C1(_FFFD_02E8_FFFDȨ_FFFD, _FFFDҢ_FFFD_02F3ş, null, 0, ref _߂ٵ_FFFD_0609_FFFD, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptGetProperty() (get size) failed with status code:{num}");
		}
		byte[] array = new byte[checked(_߂ٵ_FFFD_0609_FFFD - 1 + 1)];
		num = _0655콪ٵ_0609ε.ɛU_FFFDO_05C1(_FFFD_02E8_FFFDȨ_FFFD, _FFFDҢ_FFFD_02F3ş, array, array.Length, ref _߂ٵ_FFFD_0609_FFFD, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptGetProperty() failed with status code:{num}");
		}
		return array;
	}

	public byte[] ʓ_0609Ɯ_05C3ŧ(params byte[][] 㠰_07FB_FFFD_07A8䇹)
	{
		int num = 0;
		checked
		{
			foreach (byte[] array in 㠰_07FB_FFFD_07A8䇹)
			{
				if (array != null)
				{
					num += array.Length;
				}
			}
			byte[] array2 = new byte[num - 1 + 1 - 1 + 1];
			int num2 = 0;
			foreach (byte[] array3 in 㠰_07FB_FFFD_07A8䇹)
			{
				if (array3 != null)
				{
					Buffer.BlockCopy(array3, 0, array2, num2, array3.Length);
					num2 += array3.Length;
				}
			}
			return array2;
		}
	}
}
