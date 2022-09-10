using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace PMpBbYpvEb;

public static class VObDkPNSIzESE
{
	private static bool kMkuFenFmUW;

	private static readonly string vkIdOMxYDQuiM;

	[NonSerialized]
	internal static GetString getString_0;

	public static string NjZzWfIsqa(string string_0)
	{
		int mjgrtVkPhKnyU = 0;
		string ebJKhixfhwZxP = getString_0(107389548);
		cyNEDdNYJzRWE(vkIdOMxYDQuiM, out mjgrtVkPhKnyU, out ebJKhixfhwZxP);
		byte[] inArray = zDjAkBkPEnSsjjz(Encoding.UTF8.GetBytes(string_0), mjgrtVkPhKnyU, ebJKhixfhwZxP);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] zDjAkBkPEnSsjjz(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException(getString_0(107412116), getString_0(107412127));
		}
		int num = tUAkOmvHzpI(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException(string.Format(getString_0(107412086), num), getString_0(107412127));
		}
		if (!YoQonaaSbpQNKi(int_0))
		{
			throw new ArgumentException(getString_0(107412049), getString_0(107412020));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException(getString_0(107412007), getString_0(107411978));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, kMkuFenFmUW);
	}

	private static int tUAkOmvHzpI(int int_0)
	{
		if (kMkuFenFmUW)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool YoQonaaSbpQNKi(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void cyNEDdNYJzRWE(string XNNSPweQnyo, out int mjgrtVkPhKnyU, out string ebJKhixfhwZxP)
	{
		mjgrtVkPhKnyU = 0;
		ebJKhixfhwZxP = getString_0(107389548);
		if (XNNSPweQnyo == null || XNNSPweQnyo.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(XNNSPweQnyo);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107411993)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				mjgrtVkPhKnyU = int.Parse(array[0]);
				ebJKhixfhwZxP = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static VObDkPNSIzESE()
	{
		Strings.CreateGetStringDelegate(typeof(VObDkPNSIzESE));
		kMkuFenFmUW = false;
		vkIdOMxYDQuiM = getString_0(107411956);
	}
}
