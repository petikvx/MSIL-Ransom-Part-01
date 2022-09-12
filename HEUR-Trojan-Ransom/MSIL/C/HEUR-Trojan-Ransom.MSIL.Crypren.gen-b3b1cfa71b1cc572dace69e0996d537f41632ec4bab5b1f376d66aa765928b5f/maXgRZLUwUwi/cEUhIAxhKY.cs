using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace maXgRZLUwUwi;

public static class cEUhIAxhKY
{
	private static bool AqasxFAvlZoh;

	private static readonly string JteDpQZEtJBILjDSF;

	[NonSerialized]
	internal static GetString getString_0;

	public static string KMmlqOtzJnQsiYY(string string_0)
	{
		int uVPYAZMEArFRV = 0;
		string BzhpMsxgWeVagBg = getString_0(107392897);
		TjfJvvMDqpyRW(JteDpQZEtJBILjDSF, out uVPYAZMEArFRV, out BzhpMsxgWeVagBg);
		byte[] inArray = uMaZNgFVpBOpA(Encoding.UTF8.GetBytes(string_0), uVPYAZMEArFRV, BzhpMsxgWeVagBg);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] uMaZNgFVpBOpA(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = teapFUkjQSnrY(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107407766), num), getString_0(107407775));
			}
			if (!lcOTsCQRkH(int_0))
			{
				throw new ArgumentException(getString_0(107407249), getString_0(107407188));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107407207), getString_0(107407178));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, AqasxFAvlZoh);
		}
		throw new ArgumentException(getString_0(107407796), getString_0(107407775));
	}

	private static int teapFUkjQSnrY(int int_0)
	{
		if (AqasxFAvlZoh)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool lcOTsCQRkH(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void TjfJvvMDqpyRW(string uPMmNkqfPQcwW, out int uVPYAZMEArFRV, out string BzhpMsxgWeVagBg)
	{
		uVPYAZMEArFRV = 0;
		BzhpMsxgWeVagBg = getString_0(107392897);
		if (uPMmNkqfPQcwW == null || uPMmNkqfPQcwW.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(uPMmNkqfPQcwW);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107407129)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				uVPYAZMEArFRV = int.Parse(array[0]);
				BzhpMsxgWeVagBg = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static cEUhIAxhKY()
	{
		Strings.CreateGetStringDelegate(typeof(cEUhIAxhKY));
		AqasxFAvlZoh = false;
		JteDpQZEtJBILjDSF = getString_0(107407124);
	}
}
