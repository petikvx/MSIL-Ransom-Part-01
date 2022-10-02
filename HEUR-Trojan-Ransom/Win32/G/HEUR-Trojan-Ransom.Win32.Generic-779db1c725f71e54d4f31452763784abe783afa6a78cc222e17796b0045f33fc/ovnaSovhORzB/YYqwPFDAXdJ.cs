using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ovnaSovhORzB;

public static class YYqwPFDAXdJ
{
	private static bool vTovzrjmPVf;

	private static readonly string oBImWHaTEarm;

	[NonSerialized]
	internal static GetString getString_0;

	public static string cKyevcNdVhPKbErXE(string string_0)
	{
		int UNnLUvdiDv = 0;
		string pxTKnxxooZzIyQH = getString_0(107368543);
		qXfGUoUsnD(oBImWHaTEarm, out UNnLUvdiDv, out pxTKnxxooZzIyQH);
		byte[] inArray = weaBVVfUTBajx(Encoding.UTF8.GetBytes(string_0), UNnLUvdiDv, pxTKnxxooZzIyQH);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] weaBVVfUTBajx(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = cjjAnzruaff(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107476246), num), getString_0(107476287));
			}
			if (!LCjWCYbZOTtWB(int_0))
			{
				throw new ArgumentException(getString_0(107476209), getString_0(107476180));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107476167), getString_0(107476138));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, vTovzrjmPVf);
		}
		throw new ArgumentException(getString_0(107476276), getString_0(107476287));
	}

	private static int cjjAnzruaff(int int_0)
	{
		if (vTovzrjmPVf)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool LCjWCYbZOTtWB(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void qXfGUoUsnD(string yLgGAubKZCNz, out int UNnLUvdiDv, out string pxTKnxxooZzIyQH)
	{
		UNnLUvdiDv = 0;
		pxTKnxxooZzIyQH = getString_0(107368543);
		if (yLgGAubKZCNz == null || yLgGAubKZCNz.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(yLgGAubKZCNz);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107476153)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				UNnLUvdiDv = int.Parse(array[0]);
				pxTKnxxooZzIyQH = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static YYqwPFDAXdJ()
	{
		Strings.CreateGetStringDelegate(typeof(YYqwPFDAXdJ));
		vTovzrjmPVf = false;
		oBImWHaTEarm = getString_0(107476628);
	}
}
