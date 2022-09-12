using System.Security.Cryptography;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet.Abstractions;

internal static class CryptoAbstraction
{
	private static readonly RandomNumberGenerator Randomizer = CreateRandomNumberGenerator();

	public static byte[] GenerateRandom(int length)
	{
		byte[] array = new byte[length];
		GenerateRandom(array);
		return array;
	}

	public static void GenerateRandom(byte[] data)
	{
		Randomizer.GetBytes(data);
	}

	public static RandomNumberGenerator CreateRandomNumberGenerator()
	{
		return RandomNumberGenerator.Create();
	}

	public static MD5 CreateMD5()
	{
		return MD5.Create();
	}

	public static SHA1 CreateSHA1()
	{
		return SHA1.Create();
	}

	public static SHA256 CreateSHA256()
	{
		return SHA256.Create();
	}

	public static SHA384 CreateSHA384()
	{
		return SHA384.Create();
	}

	public static SHA512 CreateSHA512()
	{
		return SHA512.Create();
	}

	public static RIPEMD160 CreateRIPEMD160()
	{
		return RIPEMD160.Create();
	}

	public static System.Security.Cryptography.HMACMD5 CreateHMACMD5(byte[] key)
	{
		return new System.Security.Cryptography.HMACMD5(key);
	}

	public static Renci.SshNet.Security.Cryptography.HMACMD5 CreateHMACMD5(byte[] key, int hashSize)
	{
		return new Renci.SshNet.Security.Cryptography.HMACMD5(key, hashSize);
	}

	public static System.Security.Cryptography.HMACSHA1 CreateHMACSHA1(byte[] key)
	{
		return new System.Security.Cryptography.HMACSHA1(key);
	}

	public static Renci.SshNet.Security.Cryptography.HMACSHA1 CreateHMACSHA1(byte[] key, int hashSize)
	{
		return new Renci.SshNet.Security.Cryptography.HMACSHA1(key, hashSize);
	}

	public static System.Security.Cryptography.HMACSHA256 CreateHMACSHA256(byte[] key)
	{
		return new System.Security.Cryptography.HMACSHA256(key);
	}

	public static Renci.SshNet.Security.Cryptography.HMACSHA256 CreateHMACSHA256(byte[] key, int hashSize)
	{
		return new Renci.SshNet.Security.Cryptography.HMACSHA256(key, hashSize);
	}

	public static System.Security.Cryptography.HMACSHA384 CreateHMACSHA384(byte[] key)
	{
		return new System.Security.Cryptography.HMACSHA384(key);
	}

	public static Renci.SshNet.Security.Cryptography.HMACSHA384 CreateHMACSHA384(byte[] key, int hashSize)
	{
		return new Renci.SshNet.Security.Cryptography.HMACSHA384(key, hashSize);
	}

	public static System.Security.Cryptography.HMACSHA512 CreateHMACSHA512(byte[] key)
	{
		return new System.Security.Cryptography.HMACSHA512(key);
	}

	public static Renci.SshNet.Security.Cryptography.HMACSHA512 CreateHMACSHA512(byte[] key, int hashSize)
	{
		return new Renci.SshNet.Security.Cryptography.HMACSHA512(key, hashSize);
	}

	public static HMACRIPEMD160 CreateHMACRIPEMD160(byte[] key)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new HMACRIPEMD160(key);
	}
}
