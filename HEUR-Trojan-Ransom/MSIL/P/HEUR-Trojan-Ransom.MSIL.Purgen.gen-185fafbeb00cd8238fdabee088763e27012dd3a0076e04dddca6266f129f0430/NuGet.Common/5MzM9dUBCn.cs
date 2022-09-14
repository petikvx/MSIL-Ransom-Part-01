using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace NuGet.Common;

public static class _5MzM9dUBCn
{
	[Serializable]
	[CompilerGenerated]
	private sealed class ViDcoSV4Dn
	{
		public static readonly ViDcoSV4Dn BvRnKVno9h = new ViDcoSV4Dn();

		internal bool RfQUPZ1KWS()
		{
			return _6KLHalAzeH();
		}
	}

	private const string acghlGx9GU = "2.16.840.1.101.3.4.2.1";

	private const string Jf0YiZUmpy = "2.16.840.1.101.3.4.2.2";

	private const string _9dnsUbTtA0 = "2.16.840.1.101.3.4.2.3";

	private const string OUTnHcPsdA = "1.2.840.113549.1.1.11";

	private const string VNLYn2BtMT = "1.2.840.113549.1.1.12";

	private const string Qqbo8Vw2ky = "1.2.840.113549.1.1.13";

	private static Lazy<bool> Hoy8rAliQR = new Lazy<bool>(() => _6KLHalAzeH());

	public static string uKVpKozwSx(this HashAlgorithm RuveMq3eYI, Stream a0dn0W9rjL)
	{
		return RuveMq3eYI.LUghAEboPo(a0dn0W9rjL, XjLgzDe9yS: false);
	}

	public static string LUghAEboPo(this HashAlgorithm ovHxZ6d51E, Stream aP7wHM2B7p, bool XjLgzDe9yS)
	{
		if (ovHxZ6d51E == null)
		{
			throw new ArgumentNullException("hashAlgorithm");
		}
		if (aP7wHM2B7p == null)
		{
			throw new ArgumentNullException("data");
		}
		string text = null;
		try
		{
			return Convert.ToBase64String(ovHxZ6d51E.ComputeHash(aP7wHM2B7p));
		}
		finally
		{
			if (!XjLgzDe9yS)
			{
				aP7wHM2B7p.Dispose();
			}
		}
	}

	public static byte[] CcBRtKXAn4(this hDHGbEDW2G py7hftshbU, byte[] WtdemQq796)
	{
		using HashAlgorithm hashAlgorithm = py7hftshbU.Guj75rEJ27();
		return hashAlgorithm.ComputeHash(WtdemQq796);
	}

	public static byte[] Cix3P4iLy9(this HashAlgorithm _0hJh0gwVBd, Stream gf7UtXX93j)
	{
		return _0hJh0gwVBd.qDfTOp5i0i(gf7UtXX93j, jhuZA0F0sV: false);
	}

	public static byte[] qDfTOp5i0i(this HashAlgorithm x44SLenEco, Stream Y1tqzPDFtb, bool jhuZA0F0sV)
	{
		if (x44SLenEco == null)
		{
			throw new ArgumentNullException("hashAlgorithm");
		}
		if (Y1tqzPDFtb == null)
		{
			throw new ArgumentNullException("data");
		}
		byte[] array = null;
		try
		{
			return x44SLenEco.ComputeHash(Y1tqzPDFtb);
		}
		finally
		{
			if (!jhuZA0F0sV)
			{
				Y1tqzPDFtb.Dispose();
			}
		}
	}

	public static HashAlgorithm BwtImIeHTz(string mM4K6Wh4e6)
	{
		if (mM4K6Wh4e6 == null)
		{
			throw new ArgumentNullException("hashAlgorithmName");
		}
		Enum.TryParse<hDHGbEDW2G>(mM4K6Wh4e6, ignoreCase: true, out var result);
		return DyVKIBmZbz(result);
	}

	public static hDHGbEDW2G fr1BQDh8Sa(string NGEQySnKeS)
	{
		if (NGEQySnKeS == null)
		{
			throw new ArgumentNullException("hashAlgorithm");
		}
		if (Enum.TryParse<hDHGbEDW2G>(NGEQySnKeS, ignoreCase: true, out var result))
		{
			return result;
		}
		return hDHGbEDW2G.Unknown;
	}

	public static HashAlgorithm DyVKIBmZbz(hDHGbEDW2G xLlxWhf0Kj)
	{
		return xLlxWhf0Kj.Guj75rEJ27();
	}

	public static HashAlgorithm Guj75rEJ27(this hDHGbEDW2G YS3EpfLV18)
	{
		if (Hoy8rAliQR.Value)
		{
			switch (YS3EpfLV18)
			{
			case hDHGbEDW2G.SHA256:
				return new SHA256CryptoServiceProvider();
			case hDHGbEDW2G.SHA384:
				return new SHA384CryptoServiceProvider();
			case hDHGbEDW2G.SHA512:
				return new SHA512CryptoServiceProvider();
			}
		}
		else
		{
			switch (YS3EpfLV18)
			{
			case hDHGbEDW2G.SHA256:
				return new SHA256Managed();
			case hDHGbEDW2G.SHA384:
				return new SHA384Managed();
			case hDHGbEDW2G.SHA512:
				return new SHA512Managed();
			}
		}
		throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy.umkh2aU13H, YS3EpfLV18), "hashAlgorithmName");
	}

	public static HashAlgorithm YKCSepGe7b()
	{
		if (Hoy8rAliQR.Value)
		{
			return new SHA1CryptoServiceProvider();
		}
		return new SHA1Managed();
	}

	private static bool _6KLHalAzeH()
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

	public static HashAlgorithmName hhv9gZpaZu(this hDHGbEDW2G EuKVhMeDRL)
	{
		return EuKVhMeDRL switch
		{
			hDHGbEDW2G.SHA256 => HashAlgorithmName.SHA256, 
			hDHGbEDW2G.SHA384 => HashAlgorithmName.SHA384, 
			hDHGbEDW2G.SHA512 => HashAlgorithmName.SHA512, 
			_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy.umkh2aU13H, EuKVhMeDRL), "hashAlgorithmName"), 
		};
	}

	public static string Rjj8L4fVpa(this hDHGbEDW2G djaOYY0tIZ)
	{
		return djaOYY0tIZ switch
		{
			hDHGbEDW2G.SHA256 => "2.16.840.1.101.3.4.2.1", 
			hDHGbEDW2G.SHA384 => "2.16.840.1.101.3.4.2.2", 
			hDHGbEDW2G.SHA512 => "2.16.840.1.101.3.4.2.3", 
			_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy.umkh2aU13H, djaOYY0tIZ), "hashAlgorithmName"), 
		};
	}

	public static Oid JYfis3uqNm(this hDHGbEDW2G oI93gu8MWO)
	{
		return new Oid(oI93gu8MWO.Rjj8L4fVpa());
	}

	public static hDHGbEDW2G yLlmEXu8se(string v9zFu4uqfB)
	{
		return v9zFu4uqfB switch
		{
			"2.16.840.1.101.3.4.2.1" => hDHGbEDW2G.SHA256, 
			"2.16.840.1.101.3.4.2.2" => hDHGbEDW2G.SHA384, 
			"2.16.840.1.101.3.4.2.3" => hDHGbEDW2G.SHA512, 
			_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy.umkh2aU13H, v9zFu4uqfB), "oid"), 
		};
	}

	public static string P1bP66eUwj(this _2ED6sMWHGI _05M9UxjMBj)
	{
		return _05M9UxjMBj switch
		{
			_2ED6sMWHGI.SHA256RSA => "1.2.840.113549.1.1.11", 
			_2ED6sMWHGI.SHA384RSA => "1.2.840.113549.1.1.12", 
			_2ED6sMWHGI.SHA512RSA => "1.2.840.113549.1.1.13", 
			_ => throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy._51CSeDD3or, _05M9UxjMBj), "signatureAlgorithmName"), 
		};
	}

	public static string K9FVDUNGe1(string Og83DrdbHk)
	{
		if (string.IsNullOrEmpty(Og83DrdbHk))
		{
			throw new ArgumentNullException("caseInsensitiveKey");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(Og83DrdbHk.ToUpperInvariant());
		return Convert.ToBase64String(new pCqIn8xXFE("SHA256")._2ju2HM0dh1(bytes)).ToUpperInvariant();
	}
}
