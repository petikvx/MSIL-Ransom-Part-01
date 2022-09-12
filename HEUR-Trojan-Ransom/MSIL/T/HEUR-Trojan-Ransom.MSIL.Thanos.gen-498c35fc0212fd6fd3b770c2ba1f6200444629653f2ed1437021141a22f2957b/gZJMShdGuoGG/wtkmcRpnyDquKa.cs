using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

public static class wtkmcRpnyDquKa
{
	private static bool hsfyGQsgCkIZ;

	private static readonly string utmMLfsPEKZ;

	[NonSerialized]
	internal static GetString getString_0;

	public static string QNCVDGICcd(string string_0)
	{
		int NioDBqIWAdRxNb = 0;
		string GcLkaCaPjc = getString_0(107394820);
		KZFcrVVIiNdExfN(utmMLfsPEKZ, out NioDBqIWAdRxNb, out GcLkaCaPjc);
		byte[] inArray = acNCQqtafp(Encoding.UTF8.GetBytes(string_0), NioDBqIWAdRxNb, GcLkaCaPjc);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] acNCQqtafp(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = tzvQveMLTXBJw(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107407945), num), getString_0(107407954));
			}
			if (!zWGMHBOSHanuzsO(int_0))
			{
				throw new ArgumentException(getString_0(107407940), getString_0(107407911));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107407898), getString_0(107407869));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, hsfyGQsgCkIZ);
		}
		throw new ArgumentException(getString_0(107408007), getString_0(107407954));
	}

	private static int tzvQveMLTXBJw(int int_0)
	{
		if (hsfyGQsgCkIZ)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool zWGMHBOSHanuzsO(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void KZFcrVVIiNdExfN(string yBpXDvLajgyEcZ, out int NioDBqIWAdRxNb, out string GcLkaCaPjc)
	{
		NioDBqIWAdRxNb = 0;
		GcLkaCaPjc = getString_0(107394820);
		if (yBpXDvLajgyEcZ == null || yBpXDvLajgyEcZ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(yBpXDvLajgyEcZ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107407820)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				NioDBqIWAdRxNb = int.Parse(array[0]);
				GcLkaCaPjc = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static wtkmcRpnyDquKa()
	{
		Strings.CreateGetStringDelegate(typeof(wtkmcRpnyDquKa));
		hsfyGQsgCkIZ = false;
		utmMLfsPEKZ = getString_0(107407847);
	}
}
