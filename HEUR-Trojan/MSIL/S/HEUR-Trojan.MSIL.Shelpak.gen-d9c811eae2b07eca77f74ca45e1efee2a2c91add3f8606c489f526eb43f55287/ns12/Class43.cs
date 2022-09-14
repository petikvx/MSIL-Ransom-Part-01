using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns12;

internal class Class43
{
	public byte[] method_0(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		IntPtr intptr_ = method_2(GClass14.string_5, GClass14.string_6, GClass14.string_1);
		IntPtr intptr_2;
		IntPtr hglobal = method_3(intptr_, byte_0, out intptr_2);
		GClass14.GStruct7 gstruct7_ = new GClass14.GStruct7(byte_1, byte_2, byte_4);
		byte[] array2;
		using (gstruct7_)
		{
			byte[] array = new byte[method_1(intptr_)];
			int int_ = 0;
			uint num = GClass14.BCryptDecrypt(intptr_2, byte_3, byte_3.Length, ref gstruct7_, array, array.Length, null, 0, ref int_, 0);
			if (num != 0)
			{
				throw new CryptographicException($"BCrypt.BCryptDecrypt() (get size) failed with status code: {num}");
			}
			array2 = new byte[int_];
			num = GClass14.BCryptDecrypt(intptr_2, byte_3, byte_3.Length, ref gstruct7_, array, array.Length, array2, array2.Length, ref int_, 0);
			if (num == GClass14.uint_3)
			{
				throw new CryptographicException("BCrypt.BCryptDecrypt(): authentication tag mismatch");
			}
			if (num != 0)
			{
				throw new CryptographicException($"BCrypt.BCryptDecrypt() failed with status code:{num}");
			}
		}
		GClass14.BCryptDestroyKey(intptr_2);
		Marshal.FreeHGlobal(hglobal);
		GClass14.BCryptCloseAlgorithmProvider(intptr_, 0u);
		return array2;
	}

	private int method_1(IntPtr intptr_0)
	{
		byte[] array = method_4(intptr_0, GClass14.string_2);
		return BitConverter.ToInt32(new byte[4]
		{
			array[4],
			array[5],
			array[6],
			array[7]
		}, 0);
	}

	private IntPtr method_2(string string_0, string string_1, string string_2)
	{
		IntPtr intptr_ = IntPtr.Zero;
		uint num = GClass14.BCryptOpenAlgorithmProvider(out intptr_, string_0, string_1, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptOpenAlgorithmProvider() failed with status code:{num}");
		}
		byte[] bytes = Encoding.Unicode.GetBytes(string_2);
		num = GClass14.BCryptSetProperty(intptr_, GClass14.string_3, bytes, bytes.Length, 0);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptSetAlgorithmProperty(BCrypt.BCRYPT_CHAINING_MODE, BCrypt.BCRYPT_CHAIN_MODE_GCM) failed with status code:{num}");
		}
		return intptr_;
	}

	private IntPtr method_3(IntPtr intptr_0, byte[] byte_0, out IntPtr intptr_1)
	{
		int num = BitConverter.ToInt32(method_4(intptr_0, GClass14.string_0), 0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		byte[] array = method_5(GClass14.byte_0, BitConverter.GetBytes(1), BitConverter.GetBytes(byte_0.Length), byte_0);
		uint num2 = GClass14.BCryptImportKey(intptr_0, IntPtr.Zero, GClass14.string_4, out intptr_1, intPtr, num, array, array.Length, 0u);
		if (num2 != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptImportKey() failed with status code:{num2}");
		}
		return intPtr;
	}

	private byte[] method_4(IntPtr intptr_0, string string_0)
	{
		int int_ = 0;
		uint num = GClass14.BCryptGetProperty(intptr_0, string_0, null, 0, ref int_, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptGetProperty() (get size) failed with status code:{num}");
		}
		byte[] array = new byte[int_];
		num = GClass14.BCryptGetProperty(intptr_0, string_0, array, array.Length, ref int_, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptGetProperty() failed with status code:{num}");
		}
		return array;
	}

	public byte[] method_5(params byte[][] byte_0)
	{
		int num = 0;
		byte[][] array = byte_0;
		foreach (byte[] array2 in array)
		{
			if (array2 != null)
			{
				num += array2.Length;
			}
		}
		byte[] array3 = new byte[num - 1 + 1];
		int num2 = 0;
		array = byte_0;
		foreach (byte[] array4 in array)
		{
			if (array4 != null)
			{
				Buffer.BlockCopy(array4, 0, array3, num2, array4.Length);
				num2 += array4.Length;
			}
		}
		return array3;
	}
}
