using System;
using System.Security.Cryptography;
using System.Text;

namespace MySql.Data.MySqlClient;

internal class Crypt
{
	private static void XorScramble(byte[] from, int fromIndex, byte[] to, int toIndex, byte[] password, int length)
	{
		if (fromIndex >= 0 && fromIndex < from.Length)
		{
			if (fromIndex + length > from.Length)
			{
				throw new ArgumentException(Resources.FromAndLengthTooBig, "fromIndex");
			}
			if (from == null)
			{
				throw new ArgumentException(Resources.BufferCannotBeNull, "from");
			}
			if (to == null)
			{
				throw new ArgumentException(Resources.BufferCannotBeNull, "to");
			}
			if (toIndex >= 0 && toIndex < to.Length)
			{
				if (toIndex + length > to.Length)
				{
					throw new ArgumentException(Resources.IndexAndLengthTooBig, "toIndex");
				}
				if (password != null && password.Length >= length)
				{
					if (length < 0)
					{
						throw new ArgumentException(Resources.ParameterCannotBeNegative, "length");
					}
					for (int i = 0; i < length; i++)
					{
						to[toIndex++] = (byte)(from[fromIndex++] ^ password[i]);
					}
					return;
				}
				throw new ArgumentException(Resources.PasswordMustHaveLegalChars, "password");
			}
			throw new ArgumentException(Resources.IndexMustBeValid, "toIndex");
		}
		throw new ArgumentException(Resources.IndexMustBeValid, "fromIndex");
	}

	public static byte[] Get411Password(string password, string seed)
	{
		if (password.Length == 0)
		{
			return new byte[1];
		}
		SHA1 sHA = SHA1.Create();
		byte[] array = sHA.ComputeHash(Encoding.Default.GetBytes(password));
		byte[] array2 = sHA.ComputeHash(array);
		byte[] bytes = Encoding.Default.GetBytes(seed);
		byte[] array3 = new byte[bytes.Length + array2.Length];
		Array.Copy(bytes, 0, array3, 0, bytes.Length);
		Array.Copy(array2, 0, array3, bytes.Length, array2.Length);
		byte[] array4 = sHA.ComputeHash(array3);
		byte[] array5 = new byte[array4.Length + 1];
		array5[0] = 20;
		Array.Copy(array4, 0, array5, 1, array4.Length);
		for (int i = 1; i < array5.Length; i++)
		{
			array5[i] = (byte)(array5[i] ^ array[i - 1]);
		}
		return array5;
	}

	private static double rand(ref long seed1, ref long seed2, long max)
	{
		seed1 = seed1 * 3L + seed2;
		seed1 %= max;
		seed2 = (seed1 + seed2 + 33L) % max;
		return (double)seed1 / (double)max;
	}

	public static string EncryptPassword(string password, string seed, bool new_ver)
	{
		long num = 1073741823L;
		if (!new_ver)
		{
			num = 33554431L;
		}
		if (string.IsNullOrEmpty(password))
		{
			return password;
		}
		long[] array = Hash(seed);
		long[] array2 = Hash(password);
		long seed2 = (array[0] ^ array2[0]) % num;
		long seed3 = (array[1] ^ array2[1]) % num;
		if (!new_ver)
		{
			seed3 = seed2 / 2L;
		}
		char[] array3 = new char[seed.Length];
		for (int i = 0; i < seed.Length; i++)
		{
			double num2 = rand(ref seed2, ref seed3, num);
			array3[i] = (char)(Math.Floor(num2 * 31.0) + 64.0);
		}
		if (new_ver)
		{
			char c = (char)Math.Floor(rand(ref seed2, ref seed3, num) * 31.0);
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j] ^= c;
			}
		}
		return new string(array3);
	}

	private static long[] Hash(string P)
	{
		long num = 1345345333L;
		long num2 = 305419889L;
		long num3 = 7L;
		for (int i = 0; i < P.Length; i++)
		{
			if (P[i] != ' ' && P[i] != '\t')
			{
				long num4 = 0xFF & P[i];
				num ^= ((num & 0x3FL) + num3) * num4 + (num << 8);
				num2 += (num2 << 8) ^ num;
				num3 += num4;
			}
		}
		return new long[2]
		{
			num & 0x7FFFFFFFL,
			num2 & 0x7FFFFFFFL
		};
	}
}
