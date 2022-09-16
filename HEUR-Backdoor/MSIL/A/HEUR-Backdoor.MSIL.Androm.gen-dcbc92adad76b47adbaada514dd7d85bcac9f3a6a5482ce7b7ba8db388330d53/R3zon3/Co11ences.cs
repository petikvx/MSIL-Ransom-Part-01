using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Chol2tes;
using ns2;

namespace R3zon3;

public class Co11ences
{
	private const string Pre4chment = "SHA512";

	private const string Wom5 = "SHA256";

	private readonly string Euph1ria;

	public Co11ences()
		: this(null)
	{
	}

	public Co11ences(string hashAlgorithm)
	{
		if (string.IsNullOrEmpty(hashAlgorithm))
		{
			hashAlgorithm = "SHA512";
		}
		else if (!hashAlgorithm.Equals("SHA512", StringComparison.OrdinalIgnoreCase) && !hashAlgorithm.Equals("SHA256", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.UnsupportedHashAlgorithm, hashAlgorithm), "hashAlgorithm");
		}
		Euph1ria = hashAlgorithm;
	}

	public byte[] Suitabi0ities(Stream stream_0)
	{
		using HashAlgorithm hashAlgorithm = B4l4ncer.Remo3nted(Euph1ria);
		return hashAlgorithm.ComputeHash(stream_0);
	}

	public byte[] Undef4ced(byte[] Flaneu6)
	{
		using HashAlgorithm hashAlgorithm = B4l4ncer.Remo3nted(Euph1ria);
		return hashAlgorithm.ComputeHash(Flaneu6);
	}

	public bool G0l0bi0s(byte[] Hig0balls, byte[] H0ph0z0rdnesses)
	{
		return Undef4ced(Hig0balls).SequenceEqual(H0ph0z0rdnesses);
	}
}
