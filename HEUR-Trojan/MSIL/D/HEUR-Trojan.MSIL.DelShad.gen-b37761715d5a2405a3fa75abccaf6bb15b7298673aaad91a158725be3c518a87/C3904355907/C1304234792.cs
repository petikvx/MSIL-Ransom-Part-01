#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public static class C1304234792
{
	private static bool? m_C3554254475;

	private static bool? m_C3904355907;

	[SpecialName]
	public static bool C3554254475()
	{
		if (C1304234792.m_C3554254475.HasValue)
		{
			return C1304234792.m_C3554254475.Value;
		}
		bool flag = false;
		try
		{
			Random random = C2746444292.C112844655();
			byte[] array = new byte[137];
			random.NextBytes(array);
			byte[] array2 = new byte[41];
			random.NextBytes(array2);
			byte[] array3 = ProtectedData.Protect(array, array2, (DataProtectionScope)0);
			if (array3 != null && !global::C3554254475.C2137352139.C3554254475(array3, array))
			{
				byte[] array4 = ProtectedData.Unprotect(array3, array2, (DataProtectionScope)0);
				if (array4 != null && global::C3554254475.C2137352139.C3554254475(array4, array))
				{
					flag = true;
				}
			}
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		Debug.Assert(flag);
		C1304234792.m_C3554254475 = flag;
		return flag;
	}

	public static byte[] C3554254475(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2238339752());
		}
		return C3554254475(byte_0, 0, byte_0.Length);
	}

	public static byte[] C3554254475(byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2238339752());
		}
		byte[] array = new byte[byte_0.Length];
		Array.Copy(byte_0, array, byte_0.Length);
		byte[] array2;
		using (SHA256Managed sHA256Managed = new SHA256Managed())
		{
			array2 = sHA256Managed.ComputeHash(byte_0, int_0, int_1);
		}
		Debug.Assert(global::C3554254475.C2137352139.C3554254475(byte_0, array));
		Debug.Assert(array2 != null && array2.Length == 32);
		byte[] byte_ = new byte[32];
		Debug.Assert(!global::C3554254475.C2137352139.C3554254475(array2, byte_));
		return array2;
	}

	internal static byte[] C3554254475(string string_0)
	{
		byte[] result = null;
		using (FileStream inputStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			using SHA256Managed sHA256Managed = new SHA256Managed();
			result = sHA256Managed.ComputeHash(inputStream);
		}
		return result;
	}

	public static byte[] C3554254475(byte[] byte_0, int int_0, int int_1, int int_2)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cb());
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cC());
		}
		if (int_2 == 0)
		{
			return global::C3554254475.C2137352139.C3554254475;
		}
		byte[] array;
		if (int_2 <= 32)
		{
			array = C3554254475(byte_0, int_0, int_1);
		}
		else
		{
			using SHA512Managed sHA512Managed = new SHA512Managed();
			array = sHA512Managed.ComputeHash(byte_0, int_0, int_1);
		}
		if (int_2 == array.Length)
		{
			return array;
		}
		byte[] array2 = new byte[int_2];
		if (int_2 < array.Length)
		{
			Array.Copy(array, array2, int_2);
		}
		else
		{
			int num = 0;
			ulong num2 = 0uL;
			while (num < int_2)
			{
				Debug.Assert(array.Length == 64);
				using HMACSHA256 hMACSHA = new HMACSHA256(array);
				byte[] buffer = global::C3554254475.C2137352139.C3554254475(num2);
				byte[] array3 = hMACSHA.ComputeHash(buffer);
				int num3 = Math.Min(int_2 - num, array3.Length);
				Debug.Assert(num3 > 0);
				Array.Copy(array3, 0, array2, num, num3);
				num += num3;
				num2++;
				global::C3554254475.C2137352139.C3904355907(array3);
			}
			Debug.Assert(num == int_2);
		}
		byte[] byte_ = new byte[array.Length];
		Debug.Assert(!global::C3554254475.C2137352139.C3554254475(array, byte_));
		global::C3554254475.C2137352139.C3904355907(array);
		return array2;
	}

	internal static SymmetricAlgorithm C3904355907()
	{
		if (C1304234792.m_C3904355907.HasValue)
		{
			return C1304234792.m_C3904355907.Value ? C1255198513() : new RijndaelManaged();
		}
		SymmetricAlgorithm symmetricAlgorithm = C1255198513();
		C1304234792.m_C3904355907 = symmetricAlgorithm != null;
		return symmetricAlgorithm ?? new RijndaelManaged();
	}

	private static SymmetricAlgorithm C1255198513()
	{
		try
		{
			if (!global::C3554254475.C1812594589.C1908338681())
			{
				return null;
			}
			string typeName = Assembly.CreateQualifiedName(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cc(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cD());
			Type type = Type.GetType(typeName);
			if (type == null)
			{
				return null;
			}
			return Activator.CreateInstance(type) as SymmetricAlgorithm;
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		return null;
	}

	public static byte[] C3554254475(byte[] byte_0, byte[] byte_1, DataProtectionScope dataProtectionScope_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return C3554254475(byte_0, bool_0: true, byte_1, dataProtectionScope_0);
	}

	public static byte[] C3904355907(byte[] byte_0, byte[] byte_1, DataProtectionScope dataProtectionScope_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return C3554254475(byte_0, bool_0: false, byte_1, dataProtectionScope_0);
	}

	private static byte[] C3554254475(byte[] byte_0, bool bool_0, byte[] byte_1, DataProtectionScope dataProtectionScope_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C878818188());
		}
		if (byte_1 != null && byte_1.Length == 0)
		{
			byte_1 = null;
		}
		if (C3554254475())
		{
			if (bool_0)
			{
				return ProtectedData.Protect(byte_0, byte_1, dataProtectionScope_0);
			}
			return ProtectedData.Unprotect(byte_0, byte_1, dataProtectionScope_0);
		}
		Debug.Assert(condition: false);
		byte[] array = new byte[byte_0.Length];
		Array.Copy(byte_0, array, byte_0.Length);
		return array;
	}
}
