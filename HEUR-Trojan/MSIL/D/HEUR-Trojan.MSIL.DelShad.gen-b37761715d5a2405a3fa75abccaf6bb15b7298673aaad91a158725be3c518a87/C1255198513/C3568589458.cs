#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;
using C3904355907;

namespace C1255198513;

public sealed class C3568589458 : global::C3904355907.C2852464175
{
	private new static readonly global::C3554254475.C3865851505 m_C3554254475 = new global::C3554254475.C3865851505(new byte[16]
	{
		201, 217, 243, 154, 98, 138, 68, 96, 191, 116,
		13, 8, 193, 138, 79, 234
	});

	public new static readonly string C3554254475 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KE();

	public new static readonly string C3904355907 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ke();

	private new const ulong m_C3554254475 = 3001uL;

	[SpecialName]
	public override global::C3554254475.C3865851505 C3554254475()
	{
		return C3568589458.m_C3554254475;
	}

	[SpecialName]
	public override string C3904355907()
	{
		return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KB();
	}

	public override C1304234792 C1255198513()
	{
		C1304234792 c = base.C1255198513();
		c.C3904355907(C3568589458.C3554254475, global::C3554254475.C3904355907.C3904355907);
		return c;
	}

	public override void C3554254475(C1304234792 c1304234792_0)
	{
		if (c1304234792_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		Debug.Assert(C3568589458.m_C3554254475.Equals(c1304234792_0.C3554254475()));
		byte[] byte_ = global::C3904355907.C2746444292.C3554254475().C3554254475(32u);
		c1304234792_0.C3554254475(C3568589458.C3904355907, byte_);
	}

	public override byte[] C3554254475(byte[] byte_0, C1304234792 c1304234792_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kb());
		}
		if (c1304234792_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JC());
		}
		Type type = c1304234792_0.C3904355907(C3568589458.C3554254475);
		if (type == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KC());
		}
		if (type != typeof(ulong))
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KC());
		}
		ulong ulong_ = c1304234792_0.C3554254475(C3568589458.C3554254475, 0uL);
		byte[] array = c1304234792_0.C1908338681(C3568589458.C3904355907);
		if (array == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kc());
		}
		if (byte_0.Length != 32)
		{
			Debug.Assert(condition: false);
			byte_0 = global::C3904355907.C1304234792.C3554254475(byte_0);
		}
		if (array.Length != 32)
		{
			Debug.Assert(condition: false);
			array = global::C3904355907.C1304234792.C3554254475(array);
		}
		return C3554254475(byte_0, array, ulong_);
	}

	private static byte[] C3554254475(byte[] byte_0, byte[] byte_1, ulong ulong_0)
	{
		Debug.Assert(byte_0 != null && byte_0.Length == 32);
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KD());
		}
		if (byte_0.Length != 32)
		{
			throw new ArgumentException();
		}
		Debug.Assert(byte_1 != null && byte_1.Length == 32);
		if (byte_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kd());
		}
		if (byte_1.Length != 32)
		{
			throw new ArgumentException();
		}
		byte[] array = new byte[32];
		Array.Copy(byte_0, array, array.Length);
		try
		{
			if (global::C3554254475.C1812594589.C3554254475(array, byte_1, ulong_0))
			{
				return global::C3904355907.C1304234792.C3554254475(array);
			}
			if (C1255198513(array, byte_1, ulong_0))
			{
				return global::C3904355907.C1304234792.C3554254475(array);
			}
			if (C3904355907(array, byte_1, ulong_0))
			{
				return global::C3904355907.C1304234792.C3554254475(array);
			}
		}
		finally
		{
			global::C3554254475.C2137352139.C3904355907(array);
		}
		return null;
	}

	internal static bool C3904355907(byte[] byte_0, byte[] byte_1, ulong ulong_0)
	{
		byte[] rgbIV = new byte[16];
		using (SymmetricAlgorithm symmetricAlgorithm = global::C3904355907.C1304234792.C3904355907())
		{
			if (symmetricAlgorithm.BlockSize != 128)
			{
				Debug.Assert(condition: false);
				symmetricAlgorithm.BlockSize = 128;
			}
			symmetricAlgorithm.KeySize = 256;
			symmetricAlgorithm.Mode = CipherMode.ECB;
			using ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateEncryptor(byte_1, rgbIV);
			if (cryptoTransform == null || cryptoTransform.InputBlockSize != 16 || cryptoTransform.OutputBlockSize != 16)
			{
				Debug.Assert(condition: false);
				return false;
			}
			for (ulong num = 0uL; num < ulong_0; num++)
			{
				cryptoTransform.TransformBlock(byte_0, 0, 16, byte_0, 0);
				cryptoTransform.TransformBlock(byte_0, 16, 16, byte_0, 16);
			}
		}
		return true;
	}

	public override C1304234792 C3554254475(uint uint_0)
	{
		C1304234792 c = C1255198513();
		if (global::C3554254475.C1812594589.C3554254475(uint_0, out var ulong_))
		{
			c.C3904355907(C3568589458.C3554254475, ulong_);
			return c;
		}
		if (C3554254475(uint_0, out ulong_))
		{
			c.C3904355907(C3568589458.C3554254475, ulong_);
			return c;
		}
		byte[] array = new byte[32];
		byte[] array2 = new byte[32];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)i;
			array2[i] = (byte)i;
		}
		byte[] rgbIV = new byte[16];
		using (SymmetricAlgorithm symmetricAlgorithm = global::C3904355907.C1304234792.C3904355907())
		{
			if (symmetricAlgorithm.BlockSize != 128)
			{
				Debug.Assert(condition: false);
				symmetricAlgorithm.BlockSize = 128;
			}
			symmetricAlgorithm.KeySize = 256;
			symmetricAlgorithm.Mode = CipherMode.ECB;
			using ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateEncryptor(array, rgbIV);
			if (cryptoTransform == null || cryptoTransform.InputBlockSize != 16 || cryptoTransform.OutputBlockSize != 16)
			{
				Debug.Assert(condition: false);
				c.C3904355907(C3568589458.C3554254475, global::C3554254475.C3904355907.C3904355907);
				return c;
			}
			ulong_ = 0uL;
			int tickCount = Environment.TickCount;
			uint num2;
			do
			{
				for (ulong num = 0uL; num < 3001L; num++)
				{
					cryptoTransform.TransformBlock(array2, 0, 16, array2, 0);
					cryptoTransform.TransformBlock(array2, 16, 16, array2, 16);
				}
				ulong_ += 3001L;
				if (ulong_ >= 3001L)
				{
					num2 = (uint)(Environment.TickCount - tickCount);
					continue;
				}
				ulong_ = ulong.MaxValue;
				break;
			}
			while (num2 <= uint_0);
			c.C3904355907(C3568589458.C3554254475, ulong_);
		}
		return c;
	}

	private static bool C1255198513(byte[] byte_0, byte[] byte_1, ulong ulong_0)
	{
		byte[] array = null;
		try
		{
			if (C1908338681())
			{
				array = new byte[32];
				Array.Copy(byte_0, array, 32);
				if (C1908338681(array, byte_1, ulong_0))
				{
					Array.Copy(array, byte_0, 32);
					return true;
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			if (array != null)
			{
				global::C3554254475.C2137352139.C3904355907(array);
			}
		}
		return false;
	}

	private static bool C3554254475(uint uint_0, out ulong ulong_0)
	{
		ulong_0 = 0uL;
		try
		{
			if (C1908338681())
			{
				return C3904355907(uint_0, ref ulong_0);
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	private static bool C1908338681()
	{
		if (!global::C3554254475.C1812594589.C1908338681())
		{
			return false;
		}
		global::C3554254475.C543223747.gcry_check_version(IntPtr.Zero);
		return true;
	}

	private static bool C3554254475(ref IntPtr intptr_0, IntPtr intptr_1)
	{
		global::C3554254475.C543223747.gcry_cipher_open(ref intptr_0, 9, 1, 0u);
		if (intptr_0 == IntPtr.Zero)
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (global::C3554254475.C543223747.gcry_cipher_setkey(intptr_2: new IntPtr(32), intptr_0: intptr_0, intptr_1: intptr_1) != 0)
		{
			Debug.Assert(condition: false);
			return false;
		}
		return true;
	}

	private static bool C3554254475(byte[] byte_0, byte[] byte_1, ref IntPtr intptr_0, ref IntPtr intptr_1, ref IntPtr intptr_2)
	{
		intptr_1 = Marshal.AllocCoTaskMem(32);
		intptr_2 = Marshal.AllocCoTaskMem(32);
		Marshal.Copy(byte_0, 0, intptr_1, 32);
		Marshal.Copy(byte_1, 0, intptr_2, 32);
		return C3554254475(ref intptr_0, intptr_2);
	}

	private static void C3554254475(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		global::C3554254475.C543223747.gcry_cipher_close(intptr_0);
		Marshal.WriteInt64(intptr_1, 0L);
		Marshal.WriteInt64(intptr_1, 8, 0L);
		Marshal.WriteInt64(intptr_1, 16, 0L);
		Marshal.WriteInt64(intptr_1, 24, 0L);
		Marshal.FreeCoTaskMem(intptr_1);
		Marshal.FreeCoTaskMem(intptr_2);
	}

	private static bool C1908338681(byte[] byte_0, byte[] byte_1, ulong ulong_0)
	{
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		IntPtr intptr_3 = IntPtr.Zero;
		if (!C3554254475(byte_0, byte_1, ref intptr_, ref intptr_2, ref intptr_3))
		{
			return false;
		}
		try
		{
			IntPtr intptr_4 = new IntPtr(32);
			ulong num = 0uL;
			while (true)
			{
				if (num < ulong_0)
				{
					if (global::C3554254475.C543223747.gcry_cipher_encrypt(intptr_, intptr_2, intptr_4, IntPtr.Zero, IntPtr.Zero) != 0)
					{
						break;
					}
					num++;
					continue;
				}
				Marshal.Copy(intptr_2, byte_0, 0, 32);
				return true;
			}
			Debug.Assert(condition: false);
			return false;
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		finally
		{
			C3554254475(intptr_, intptr_2, intptr_3);
		}
		return false;
	}

	private static bool C3904355907(uint uint_0, ref ulong ulong_0)
	{
		byte[] byte_ = new byte[32];
		byte[] byte_2 = new byte[32];
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		IntPtr intptr_3 = IntPtr.Zero;
		if (!C3554254475(byte_, byte_2, ref intptr_, ref intptr_2, ref intptr_3))
		{
			return false;
		}
		uint num = uint_0;
		ulong num2 = 1uL;
		if (num <= int.MaxValue)
		{
			num *= 2;
			num2 = 2uL;
		}
		try
		{
			ulong num3 = 0uL;
			IntPtr intptr_4 = new IntPtr(32);
			int tickCount = Environment.TickCount;
			uint num5;
			do
			{
				for (ulong num4 = 0uL; num4 < 3001L; num4++)
				{
					if (global::C3554254475.C543223747.gcry_cipher_encrypt(intptr_, intptr_2, intptr_4, IntPtr.Zero, IntPtr.Zero) != 0)
					{
						Debug.Assert(condition: false);
						return false;
					}
				}
				num3 += 3001L;
				if (num3 >= 3001L)
				{
					num5 = (uint)(Environment.TickCount - tickCount);
					continue;
				}
				num3 = ulong.MaxValue;
				break;
			}
			while (num5 <= num);
			ulong_0 = num3 / num2;
			return true;
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		finally
		{
			C3554254475(intptr_, intptr_2, intptr_3);
		}
		return false;
	}
}
