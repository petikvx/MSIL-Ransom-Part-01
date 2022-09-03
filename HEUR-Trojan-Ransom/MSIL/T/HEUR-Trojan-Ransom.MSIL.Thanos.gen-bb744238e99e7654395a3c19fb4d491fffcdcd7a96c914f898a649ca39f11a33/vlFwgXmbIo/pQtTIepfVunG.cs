using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

public static class pQtTIepfVunG
{
	private static bool HeYbuicYlPu;

	private static readonly string ItpRMhfgYrTMaO;

	[NonSerialized]
	internal static GetString getString_0;

	public static string MmnVKLBAZcnOVX(string string_0)
	{
		int uyYBwLRGcCun = 0;
		string AuhXCwrQYGLtS = getString_0(107391965);
		uFhYuZYoymGT(ItpRMhfgYrTMaO, out uyYBwLRGcCun, out AuhXCwrQYGLtS);
		byte[] inArray = ScbjYyZKbYdTZG(Encoding.UTF8.GetBytes(string_0), uyYBwLRGcCun, AuhXCwrQYGLtS);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] ScbjYyZKbYdTZG(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = HuFyWtFmvXN(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107404504), num), getString_0(107404545));
			}
			if (!iCggBJftupe(int_0))
			{
				throw new ArgumentException(getString_0(107404979), getString_0(107404950));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404969), getString_0(107404940));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, HeYbuicYlPu);
		}
		throw new ArgumentException(getString_0(107404534), getString_0(107404545));
	}

	private static int HuFyWtFmvXN(int int_0)
	{
		if (HeYbuicYlPu)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool iCggBJftupe(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void uFhYuZYoymGT(string nLQKkMUtWZzHF, out int uyYBwLRGcCun, out string AuhXCwrQYGLtS)
	{
		uyYBwLRGcCun = 0;
		AuhXCwrQYGLtS = getString_0(107391965);
		if (nLQKkMUtWZzHF == null || nLQKkMUtWZzHF.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(nLQKkMUtWZzHF);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107404891)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				uyYBwLRGcCun = int.Parse(array[0]);
				AuhXCwrQYGLtS = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static pQtTIepfVunG()
	{
		Strings.CreateGetStringDelegate(typeof(pQtTIepfVunG));
		HeYbuicYlPu = false;
		ItpRMhfgYrTMaO = getString_0(107404886);
	}
}
