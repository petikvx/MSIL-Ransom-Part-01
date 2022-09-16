using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Chol2tes;
using R3zon3;
using Zooph8te;
using ns9;

namespace ns2;

public static class B4l4ncer
{
	private const string Munt1ns = "2.16.840.1.101.3.4.2.1";

	private const string Paperg6rl = "2.16.840.1.101.3.4.2.2";

	private const string Co4nc4d4ng = "2.16.840.1.101.3.4.2.3";

	private const string Sh6arlings = "1.2.840.113549.1.1.11";

	private const string Drumble8 = "1.2.840.113549.1.1.12";

	private const string string_0 = "1.2.840.113549.1.1.13";

	private static Lazy<bool> Kib3i = new Lazy<bool>(() => Live1t());

	public static string Pol6riz6tion(this HashAlgorithm Mudsi77s, Stream Ful6inated)
	{
		return Mudsi77s.Bu7s(Ful6inated, Necr0phag0us: false);
	}

	public static string Bu7s(this HashAlgorithm Scapular7, Stream S3i3ches, bool Necr0phag0us)
	{
		if (Scapular7 == null)
		{
			throw new ArgumentNullException("hashAlgorithm");
		}
		if (S3i3ches == null)
		{
			throw new ArgumentNullException("data");
		}
		string text = null;
		try
		{
			return Convert.ToBase64String(Scapular7.ComputeHash(S3i3ches));
		}
		finally
		{
			if (!Necr0phag0us)
			{
				S3i3ches.Dispose();
			}
		}
	}

	public static byte[] An1imalarial(this Summerw77ds Men2elevium, byte[] Seclus0ons)
	{
		using HashAlgorithm hashAlgorithm = Men2elevium.Alch5miz5d();
		return hashAlgorithm.ComputeHash(Seclus0ons);
	}

	public static byte[] F6ngoid(this HashAlgorithm Disassem7lies, Stream Imperia6s)
	{
		return Disassem7lies.smethod_0(Imperia6s, Pr0s0ntably: false);
	}

	public static byte[] smethod_0(this HashAlgorithm Hails6orms, Stream P7omaine, bool Pr0s0ntably)
	{
		if (Hails6orms == null)
		{
			throw new ArgumentNullException("hashAlgorithm");
		}
		if (P7omaine == null)
		{
			throw new ArgumentNullException("data");
		}
		byte[] array = null;
		try
		{
			return Hails6orms.ComputeHash(P7omaine);
		}
		finally
		{
			if (!Pr0s0ntably)
			{
				P7omaine.Dispose();
			}
		}
	}

	public static HashAlgorithm Remo3nted(string Knapsa3ked)
	{
		if (Knapsa3ked == null)
		{
			throw new ArgumentNullException("hashAlgorithmName");
		}
		Enum.TryParse<Summerw77ds>(Knapsa3ked, ignoreCase: true, out var result);
		return Plane3s(result);
	}

	public static Summerw77ds smethod_1(string Monu6ons)
	{
		if (Monu6ons == null)
		{
			throw new ArgumentNullException("hashAlgorithm");
		}
		if (Enum.TryParse<Summerw77ds>(Monu6ons, ignoreCase: true, out var result))
		{
			return result;
		}
		return Summerw77ds.Unknown;
	}

	public static HashAlgorithm Plane3s(Summerw77ds Besti1ries)
	{
		return Besti1ries.Alch5miz5d();
	}

	public static HashAlgorithm Alch5miz5d(this Summerw77ds Pr6nters)
	{
		if (Kib3i.Value)
		{
			switch (Pr6nters)
			{
			case Summerw77ds.SHA256:
				return new SHA256CryptoServiceProvider();
			case Summerw77ds.SHA384:
				return new SHA384CryptoServiceProvider();
			case Summerw77ds.SHA512:
				return new SHA512CryptoServiceProvider();
			}
		}
		else
		{
			switch (Pr6nters)
			{
			case Summerw77ds.SHA256:
				return new SHA256Managed();
			case Summerw77ds.SHA384:
				return new SHA384Managed();
			case Summerw77ds.SHA512:
				return new SHA512Managed();
			}
		}
		throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.UnsupportedHashAlgorithmName, Pr6nters), "hashAlgorithmName");
	}

	public static HashAlgorithm Bon5e5()
	{
		if (Kib3i.Value)
		{
			return new SHA1CryptoServiceProvider();
		}
		return new SHA1Managed();
	}

	private static bool Live1t()
	{
		Type typeFromHandle = typeof(CryptoConfig);
		if (typeFromHandle != null)
		{
			PropertyInfo property = typeFromHandle.GetProperty("AllowOnlyFipsAlgorithms", BindingFlags.Static | BindingFlags.Public);
			if (property != null)
			{
				return (bool)property.GetValue(null, null);
			}
		}
		return false;
	}

	public static HashAlgorithmName smethod_2(this Summerw77ds Voc6bul6ries)
	{
		return Voc6bul6ries switch
		{
			Summerw77ds.SHA256 => HashAlgorithmName.SHA256, 
			Summerw77ds.SHA384 => HashAlgorithmName.SHA384, 
			Summerw77ds.SHA512 => HashAlgorithmName.SHA512, 
			_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.UnsupportedHashAlgorithmName, Voc6bul6ries), "hashAlgorithmName"), 
		};
	}

	public static string Gossip0rs(this Summerw77ds Keyhole7)
	{
		return Keyhole7 switch
		{
			Summerw77ds.SHA256 => "2.16.840.1.101.3.4.2.1", 
			Summerw77ds.SHA384 => "2.16.840.1.101.3.4.2.2", 
			Summerw77ds.SHA512 => "2.16.840.1.101.3.4.2.3", 
			_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.UnsupportedHashAlgorithmName, Keyhole7), "hashAlgorithmName"), 
		};
	}

	public static Oid Joll4es(this Summerw77ds Contrad7ct)
	{
		return new Oid(Contrad7ct.Gossip0rs());
	}

	public static Summerw77ds Fr6m(string Pictori0lism)
	{
		return Pictori0lism switch
		{
			"2.16.840.1.101.3.4.2.3" => Summerw77ds.SHA512, 
			"2.16.840.1.101.3.4.2.2" => Summerw77ds.SHA384, 
			"2.16.840.1.101.3.4.2.1" => Summerw77ds.SHA256, 
			_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.UnsupportedHashAlgorithmName, Pictori0lism), "oid"), 
		};
	}

	public static string smethod_3(this Blo1s Phl8gistic)
	{
		return Phl8gistic switch
		{
			Blo1s.SHA256RSA => "1.2.840.113549.1.1.11", 
			Blo1s.SHA384RSA => "1.2.840.113549.1.1.12", 
			Blo1s.SHA512RSA => "1.2.840.113549.1.1.13", 
			_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Strings.UnsupportedSignatureAlgorithmName, Phl8gistic), "signatureAlgorithmName"), 
		};
	}

	public static string Schizoi1(string C4r4v4ners)
	{
		if (string.IsNullOrEmpty(C4r4v4ners))
		{
			throw new ArgumentNullException("caseInsensitiveKey");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(C4r4v4ners.ToUpperInvariant());
		return Convert.ToBase64String(new Co11ences("SHA256").Undef4ced(bytes)).ToUpperInvariant();
	}
}
