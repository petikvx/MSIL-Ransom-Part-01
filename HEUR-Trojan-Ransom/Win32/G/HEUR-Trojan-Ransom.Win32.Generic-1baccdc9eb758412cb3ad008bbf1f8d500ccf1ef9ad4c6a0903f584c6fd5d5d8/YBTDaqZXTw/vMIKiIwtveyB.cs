using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace YBTDaqZXTw;

public static class vMIKiIwtveyB
{
	private static bool EHLGKsuHohf;

	private static readonly string XdkTNmaGqCHba;

	[NonSerialized]
	internal static GetString getString_0;

	public static string GfpVZvWzMIElkKF(string string_0)
	{
		int xNzRzSfjoCEN = 0;
		string fuXlSdFPelIBOd = getString_0(107392403);
		EUpalSEmHhN(XdkTNmaGqCHba, out xNzRzSfjoCEN, out fuXlSdFPelIBOd);
		byte[] inArray = IjQbEOoaTk(Encoding.UTF8.GetBytes(string_0), xNzRzSfjoCEN, fuXlSdFPelIBOd);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] IjQbEOoaTk(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = LZKhJdkMgrKXKI(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107406945), num), getString_0(107406922));
			}
			if (!ePRabcdpKpUY(int_0))
			{
				throw new ArgumentException(getString_0(107406908), getString_0(107406879));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107406834), getString_0(107406805));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, EHLGKsuHohf);
		}
		throw new ArgumentException(getString_0(107406975), getString_0(107406922));
	}

	private static int LZKhJdkMgrKXKI(int int_0)
	{
		if (EHLGKsuHohf)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool ePRabcdpKpUY(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void EUpalSEmHhN(string lJjEmqhiGDkPHAq, out int xNzRzSfjoCEN, out string fuXlSdFPelIBOd)
	{
		xNzRzSfjoCEN = 0;
		fuXlSdFPelIBOd = getString_0(107392403);
		if (lJjEmqhiGDkPHAq == null || lJjEmqhiGDkPHAq.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(lJjEmqhiGDkPHAq);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107406820)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				xNzRzSfjoCEN = int.Parse(array[0]);
				fuXlSdFPelIBOd = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static vMIKiIwtveyB()
	{
		Strings.CreateGetStringDelegate(typeof(vMIKiIwtveyB));
		EHLGKsuHohf = false;
		XdkTNmaGqCHba = getString_0(107406815);
	}
}
