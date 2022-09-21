using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

public static class qQVKYmLneEhR
{
	private static bool wNRisQQzbiVvK;

	private static readonly string zRtYaLoNJIpp;

	[NonSerialized]
	internal static GetString getString_0;

	public static string HpWrTpHQoP(string string_0)
	{
		int nNHZxAxSwxUV = 0;
		string FwZIcfGgXDDKa = getString_0(107393549);
		aAvhgXlQPhKW(zRtYaLoNJIpp, out nNHZxAxSwxUV, out FwZIcfGgXDDKa);
		byte[] inArray = dwuXDFwjifFuS(Encoding.UTF8.GetBytes(string_0), nNHZxAxSwxUV, FwZIcfGgXDDKa);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] dwuXDFwjifFuS(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = NVAnOcfVSmwUjzFM(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107406042), num), getString_0(107406083));
			}
			if (!eVoTVCYrnaWyOZQv(int_0))
			{
				throw new ArgumentException(getString_0(107406517), getString_0(107406488));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107406507), getString_0(107406446));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, wNRisQQzbiVvK);
		}
		throw new ArgumentException(getString_0(107406072), getString_0(107406083));
	}

	private static int NVAnOcfVSmwUjzFM(int int_0)
	{
		if (wNRisQQzbiVvK)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool eVoTVCYrnaWyOZQv(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void aAvhgXlQPhKW(string LYgCCxuyljpoob, out int nNHZxAxSwxUV, out string FwZIcfGgXDDKa)
	{
		nNHZxAxSwxUV = 0;
		FwZIcfGgXDDKa = getString_0(107393549);
		if (LYgCCxuyljpoob == null || LYgCCxuyljpoob.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(LYgCCxuyljpoob);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107406429)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				nNHZxAxSwxUV = int.Parse(array[0]);
				FwZIcfGgXDDKa = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static qQVKYmLneEhR()
	{
		Strings.CreateGetStringDelegate(typeof(qQVKYmLneEhR));
		wNRisQQzbiVvK = false;
		zRtYaLoNJIpp = getString_0(107406424);
	}
}
