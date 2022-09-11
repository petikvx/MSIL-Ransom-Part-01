using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class ZMseRpqIbtGDsKWQ
{
	private static bool jQgooilHURWaWHX;

	private static readonly string FfXSrTItXwhd;

	[NonSerialized]
	internal static GetString getString_0;

	public static string UEhYhvKzXiJ(string string_0)
	{
		int fECwjDXhsS = 0;
		string dZLXsiQWboOBshC = getString_0(107389130);
		ckfYuIzukWMf(FfXSrTItXwhd, out fECwjDXhsS, out dZLXsiQWboOBshC);
		byte[] inArray = TdGliuLyuFzI(Encoding.UTF8.GetBytes(string_0), fECwjDXhsS, dZLXsiQWboOBshC);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] TdGliuLyuFzI(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException(getString_0(107411698), getString_0(107411709));
		}
		int num = GcqXxAxHmmbvo(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException(string.Format(getString_0(107411668), num), getString_0(107411709));
		}
		if (!ioeyOeLWrDvkZCl(int_0))
		{
			throw new ArgumentException(getString_0(107411631), getString_0(107412114));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException(getString_0(107412133), getString_0(107412072));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, jQgooilHURWaWHX);
	}

	private static int GcqXxAxHmmbvo(int int_0)
	{
		if (jQgooilHURWaWHX)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool ioeyOeLWrDvkZCl(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void ckfYuIzukWMf(string ETzPPxWbDxAaIH, out int fECwjDXhsS, out string dZLXsiQWboOBshC)
	{
		fECwjDXhsS = 0;
		dZLXsiQWboOBshC = getString_0(107389130);
		if (ETzPPxWbDxAaIH == null || ETzPPxWbDxAaIH.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ETzPPxWbDxAaIH);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107412087)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				fECwjDXhsS = int.Parse(array[0]);
				dZLXsiQWboOBshC = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static ZMseRpqIbtGDsKWQ()
	{
		Strings.CreateGetStringDelegate(typeof(ZMseRpqIbtGDsKWQ));
		jQgooilHURWaWHX = false;
		FfXSrTItXwhd = getString_0(107412050);
	}
}
