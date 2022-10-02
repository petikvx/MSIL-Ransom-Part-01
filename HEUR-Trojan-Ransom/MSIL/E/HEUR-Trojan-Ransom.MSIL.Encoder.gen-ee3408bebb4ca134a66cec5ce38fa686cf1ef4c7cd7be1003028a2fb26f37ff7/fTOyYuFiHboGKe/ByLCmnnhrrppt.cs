using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fTOyYuFiHboGKe;

public static class ByLCmnnhrrppt
{
	private static bool zBuSNmvDgJ;

	private static readonly string onauTsSlQoyfYotK;

	[NonSerialized]
	internal static GetString getString_0;

	public static string KwlFsMMThHblH(string string_0)
	{
		int xDvYpNoLdpLlK = 0;
		string lxllpGTrKyz = getString_0(107394032);
		IzJZggebzyKgh(onauTsSlQoyfYotK, out xDvYpNoLdpLlK, out lxllpGTrKyz);
		byte[] inArray = TZhkcBwZdBfBuq(Encoding.UTF8.GetBytes(string_0), xDvYpNoLdpLlK, lxllpGTrKyz);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] TZhkcBwZdBfBuq(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = pfPJiRXJsbmqe(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107406839), num), getString_0(107406880));
			}
			if (!WRjDAqOCqqs(int_0))
			{
				throw new ArgumentException(getString_0(107406802), getString_0(107406261));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107406280), getString_0(107406251));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, zBuSNmvDgJ);
		}
		throw new ArgumentException(getString_0(107406869), getString_0(107406880));
	}

	private static int pfPJiRXJsbmqe(int int_0)
	{
		if (zBuSNmvDgJ)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool WRjDAqOCqqs(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void IzJZggebzyKgh(string kYOnmqWSCCA, out int xDvYpNoLdpLlK, out string lxllpGTrKyz)
	{
		xDvYpNoLdpLlK = 0;
		lxllpGTrKyz = getString_0(107394032);
		if (kYOnmqWSCCA == null || kYOnmqWSCCA.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(kYOnmqWSCCA);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107406202)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				xDvYpNoLdpLlK = int.Parse(array[0]);
				lxllpGTrKyz = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static ByLCmnnhrrppt()
	{
		Strings.CreateGetStringDelegate(typeof(ByLCmnnhrrppt));
		zBuSNmvDgJ = false;
		onauTsSlQoyfYotK = getString_0(107406197);
	}
}
