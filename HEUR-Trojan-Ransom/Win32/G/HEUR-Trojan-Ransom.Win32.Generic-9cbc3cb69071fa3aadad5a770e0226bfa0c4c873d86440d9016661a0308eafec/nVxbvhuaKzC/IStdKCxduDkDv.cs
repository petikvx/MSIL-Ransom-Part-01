using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public static class IStdKCxduDkDv
{
	private static bool TMutgxHICcgW;

	private static readonly string BnuxWErzUCfnEIqmIn;

	[NonSerialized]
	internal static GetString getString_0;

	public static string lLnKSAYKNyeo(string string_0)
	{
		int aciboUGdnD = 0;
		string DRBFgrgjvMjF = getString_0(107389323);
		MdaVoOKUeT(BnuxWErzUCfnEIqmIn, out aciboUGdnD, out DRBFgrgjvMjF);
		byte[] inArray = QFkaPxCgbSSu(Encoding.UTF8.GetBytes(string_0), aciboUGdnD, DRBFgrgjvMjF);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] QFkaPxCgbSSu(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException(getString_0(107410340), getString_0(107410351));
		}
		int num = BBNFBhJyNwbQDqev(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException(string.Format(getString_0(107410310), num), getString_0(107410351));
		}
		if (!qoAqadRgFN(int_0))
		{
			throw new ArgumentException(getString_0(107410273), getString_0(107410244));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException(getString_0(107410263), getString_0(107410234));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, TMutgxHICcgW);
	}

	private static int BBNFBhJyNwbQDqev(int int_0)
	{
		if (TMutgxHICcgW)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool qoAqadRgFN(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void MdaVoOKUeT(string HjlIXycIuWJTLUXKu, out int aciboUGdnD, out string DRBFgrgjvMjF)
	{
		aciboUGdnD = 0;
		DRBFgrgjvMjF = getString_0(107389323);
		if (HjlIXycIuWJTLUXKu == null || HjlIXycIuWJTLUXKu.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(HjlIXycIuWJTLUXKu);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107410185)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				aciboUGdnD = int.Parse(array[0]);
				DRBFgrgjvMjF = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static IStdKCxduDkDv()
	{
		Strings.CreateGetStringDelegate(typeof(IStdKCxduDkDv));
		TMutgxHICcgW = false;
		BnuxWErzUCfnEIqmIn = getString_0(107410180);
	}
}
