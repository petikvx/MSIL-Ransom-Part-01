using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace NuGet.Common;

public class pCqIn8xXFE
{
	private const string nbovdBrNIc = "SHA512";

	private const string EW90IiuRdc = "SHA256";

	private readonly string Zzox6YQZHL;

	public pCqIn8xXFE()
		: this(null)
	{
	}

	public pCqIn8xXFE(string hashAlgorithm)
	{
		if (string.IsNullOrEmpty(hashAlgorithm))
		{
			hashAlgorithm = "SHA512";
		}
		else if (!hashAlgorithm.Equals("SHA512", StringComparison.OrdinalIgnoreCase) && !hashAlgorithm.Equals("SHA256", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy.jWYsOnD99K, hashAlgorithm), "hashAlgorithm");
		}
		Zzox6YQZHL = hashAlgorithm;
	}

	public byte[] Fzcxl7FsyS(Stream lfUflnrDuY)
	{
		using HashAlgorithm hashAlgorithm = _5MzM9dUBCn.BwtImIeHTz(Zzox6YQZHL);
		return hashAlgorithm.ComputeHash(lfUflnrDuY);
	}

	public byte[] _2ju2HM0dh1(byte[] fjfrIzbeai)
	{
		using HashAlgorithm hashAlgorithm = _5MzM9dUBCn.BwtImIeHTz(Zzox6YQZHL);
		return hashAlgorithm.ComputeHash(fjfrIzbeai);
	}

	public bool FKmrfvhmX6(byte[] moqYFVxkzR, byte[] _8J6ogCIzz9)
	{
		return _2ju2HM0dh1(moqYFVxkzR).SequenceEqual(_8J6ogCIzz9);
	}
}
