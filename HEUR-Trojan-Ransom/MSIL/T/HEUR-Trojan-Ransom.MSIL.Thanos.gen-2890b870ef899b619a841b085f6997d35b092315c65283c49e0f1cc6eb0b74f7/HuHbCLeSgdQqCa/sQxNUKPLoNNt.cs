using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

public static class sQxNUKPLoNNt
{
	private static bool RIsWeENkypGlv;

	private static readonly string hpKKawJnepejR;

	[NonSerialized]
	internal static GetString getString_0;

	public static string CRaOncPudd(string string_0)
	{
		int TQhaQCQFJyVrjY = 0;
		string VGJYXdYWlp = getString_0(107395214);
		TUnrnJWBmdip(hpKKawJnepejR, out TQhaQCQFJyVrjY, out VGJYXdYWlp);
		byte[] inArray = VbjcoHkmMLaSSG(Encoding.UTF8.GetBytes(string_0), TQhaQCQFJyVrjY, VGJYXdYWlp);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] VbjcoHkmMLaSSG(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = wCgTWGsOpWLL(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107411955), num), getString_0(107411932));
			}
			if (!VJDePnbRQfHnw(int_0))
			{
				throw new ArgumentException(getString_0(107411918), getString_0(107411889));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107411844), getString_0(107411303));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, RIsWeENkypGlv);
		}
		throw new ArgumentException(getString_0(107411985), getString_0(107411932));
	}

	private static int wCgTWGsOpWLL(int int_0)
	{
		if (RIsWeENkypGlv)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool VJDePnbRQfHnw(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void TUnrnJWBmdip(string ejVirBMOsFnB, out int TQhaQCQFJyVrjY, out string VGJYXdYWlp)
	{
		TQhaQCQFJyVrjY = 0;
		VGJYXdYWlp = getString_0(107395214);
		if (ejVirBMOsFnB == null || ejVirBMOsFnB.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ejVirBMOsFnB);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107411318)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				TQhaQCQFJyVrjY = int.Parse(array[0]);
				VGJYXdYWlp = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static sQxNUKPLoNNt()
	{
		Strings.CreateGetStringDelegate(typeof(sQxNUKPLoNNt));
		RIsWeENkypGlv = false;
		hpKKawJnepejR = getString_0(107411313);
	}
}
