using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

public static class OGjKHcgkXGeUw
{
	private static bool ZmAvtNXIyw;

	private static readonly string SovqVvWgivlwfdw;

	[NonSerialized]
	internal static GetString getString_0;

	public static string clInXecpJbJ(string string_0)
	{
		int YmWxltSvEY = 0;
		string maxGblKkMTQw = getString_0(107361753);
		vPUbDlMvGiQMVP(SovqVvWgivlwfdw, out YmWxltSvEY, out maxGblKkMTQw);
		byte[] inArray = FjBySWwROQP(Encoding.UTF8.GetBytes(string_0), YmWxltSvEY, maxGblKkMTQw);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] FjBySWwROQP(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = QuIcWaSPFUzO(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107370349), num), getString_0(107370358));
			}
			if (!SJkdBdCLbq(int_0))
			{
				throw new ArgumentException(getString_0(107370280), getString_0(107370283));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107370238), getString_0(107370209));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, ZmAvtNXIyw);
		}
		throw new ArgumentException(getString_0(107370379), getString_0(107370358));
	}

	private static int QuIcWaSPFUzO(int int_0)
	{
		if (ZmAvtNXIyw)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool SJkdBdCLbq(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void vPUbDlMvGiQMVP(string cWnLSIjTodK, out int YmWxltSvEY, out string maxGblKkMTQw)
	{
		YmWxltSvEY = 0;
		maxGblKkMTQw = getString_0(107361753);
		if (cWnLSIjTodK == null || cWnLSIjTodK.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(cWnLSIjTodK);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107370224)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				YmWxltSvEY = int.Parse(array[0]);
				maxGblKkMTQw = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static OGjKHcgkXGeUw()
	{
		Strings.CreateGetStringDelegate(typeof(OGjKHcgkXGeUw));
		ZmAvtNXIyw = false;
		SovqVvWgivlwfdw = getString_0(107370219);
	}
}
