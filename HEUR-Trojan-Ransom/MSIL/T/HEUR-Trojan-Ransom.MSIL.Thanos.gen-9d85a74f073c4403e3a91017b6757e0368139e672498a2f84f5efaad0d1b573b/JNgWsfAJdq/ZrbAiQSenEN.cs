using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace JNgWsfAJdq;

public static class ZrbAiQSenEN
{
	private static bool pZIlYnTIbpOu;

	private static readonly string OZolXYaoAZz;

	[NonSerialized]
	internal static GetString getString_0;

	public static string PvVgiztDRoWbhs(string string_0)
	{
		int oEsGpidLKegOG = 0;
		string nBbGLmycpTS = getString_0(107352265);
		ecEvBGEsCRmCZ(OZolXYaoAZz, out oEsGpidLKegOG, out nBbGLmycpTS);
		byte[] inArray = RAbYlBhmSZIb(Encoding.UTF8.GetBytes(string_0), oEsGpidLKegOG, nBbGLmycpTS);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] RAbYlBhmSZIb(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = BarmqxuGEPup(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107364953), num), getString_0(107364962));
			}
			if (!WcOBakEZDLzFd(int_0))
			{
				throw new ArgumentException(getString_0(107364948), getString_0(107364919));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107364906), getString_0(107364877));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, pZIlYnTIbpOu);
		}
		throw new ArgumentException(getString_0(107365015), getString_0(107364962));
	}

	private static int BarmqxuGEPup(int int_0)
	{
		if (pZIlYnTIbpOu)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool WcOBakEZDLzFd(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void ecEvBGEsCRmCZ(string yyrYOpjgrudNsO, out int oEsGpidLKegOG, out string nBbGLmycpTS)
	{
		oEsGpidLKegOG = 0;
		nBbGLmycpTS = getString_0(107352265);
		if (yyrYOpjgrudNsO == null || yyrYOpjgrudNsO.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(yyrYOpjgrudNsO);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107364828)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				oEsGpidLKegOG = int.Parse(array[0]);
				nBbGLmycpTS = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static ZrbAiQSenEN()
	{
		Strings.CreateGetStringDelegate(typeof(ZrbAiQSenEN));
		pZIlYnTIbpOu = false;
		OZolXYaoAZz = getString_0(107364855);
	}
}
