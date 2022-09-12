using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace cmxGDwJsHiH;

public static class yvxyNajvQXKErrZ
{
	private static bool RlfKvAJMpbgn;

	private static readonly string rbbFsLMyitqHT;

	[NonSerialized]
	internal static GetString getString_0;

	public static string nFXfHJeIPfF(string string_0)
	{
		int FNvkGXwaKGjD = 0;
		string sACyNtAzPCmdk = getString_0(107394811);
		EyEBwMfvzrBg(rbbFsLMyitqHT, out FNvkGXwaKGjD, out sACyNtAzPCmdk);
		byte[] inArray = wmvxUjcXzX(Encoding.UTF8.GetBytes(string_0), FNvkGXwaKGjD, sACyNtAzPCmdk);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] wmvxUjcXzX(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = MaslnEpMPVwQiJUQ(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107409200), num), getString_0(107409177));
			}
			if (!eYVPjDSqnMlC(int_0))
			{
				throw new ArgumentException(getString_0(107409163), getString_0(107409134));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107409089), getString_0(107409092));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, RlfKvAJMpbgn);
		}
		throw new ArgumentException(getString_0(107409230), getString_0(107409177));
	}

	private static int MaslnEpMPVwQiJUQ(int int_0)
	{
		if (RlfKvAJMpbgn)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool eYVPjDSqnMlC(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void EyEBwMfvzrBg(string yaQylrBHDRMk, out int FNvkGXwaKGjD, out string sACyNtAzPCmdk)
	{
		FNvkGXwaKGjD = 0;
		sACyNtAzPCmdk = getString_0(107394811);
		if (yaQylrBHDRMk == null || yaQylrBHDRMk.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(yaQylrBHDRMk);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107409043)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				FNvkGXwaKGjD = int.Parse(array[0]);
				sACyNtAzPCmdk = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static yvxyNajvQXKErrZ()
	{
		Strings.CreateGetStringDelegate(typeof(yvxyNajvQXKErrZ));
		RlfKvAJMpbgn = false;
		rbbFsLMyitqHT = getString_0(107409070);
	}
}
