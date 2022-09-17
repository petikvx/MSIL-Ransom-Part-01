using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bmDbQpaZORfnY;

public static class uibsyoaCixjw
{
	private static bool SvzZlTJXHyJn;

	private static readonly string MNcfYzRktFW;

	[NonSerialized]
	internal static GetString getString_0;

	public static string DOQQVROAHbcwo(string string_0)
	{
		int gqPLKmxKrKOMY = 0;
		string TzeWmfhraEIx = getString_0(107391625);
		xkqiKzlNNmrwY(MNcfYzRktFW, out gqPLKmxKrKOMY, out TzeWmfhraEIx);
		byte[] inArray = rrKnRMmqNyNZF(Encoding.UTF8.GetBytes(string_0), gqPLKmxKrKOMY, TzeWmfhraEIx);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] rrKnRMmqNyNZF(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = ugqJPtAWbnrCz(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107404149), num), getString_0(107404158));
			}
			if (!xArqhKJCdCoRpqm(int_0))
			{
				throw new ArgumentException(getString_0(107404112), getString_0(107404083));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404038), getString_0(107404009));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, SvzZlTJXHyJn);
		}
		throw new ArgumentException(getString_0(107404179), getString_0(107404158));
	}

	private static int ugqJPtAWbnrCz(int int_0)
	{
		if (SvzZlTJXHyJn)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool xArqhKJCdCoRpqm(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void xkqiKzlNNmrwY(string mTFhytNJbdR, out int gqPLKmxKrKOMY, out string TzeWmfhraEIx)
	{
		gqPLKmxKrKOMY = 0;
		TzeWmfhraEIx = getString_0(107391625);
		if (mTFhytNJbdR == null || mTFhytNJbdR.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(mTFhytNJbdR);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107404024)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				gqPLKmxKrKOMY = int.Parse(array[0]);
				TzeWmfhraEIx = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static uibsyoaCixjw()
	{
		Strings.CreateGetStringDelegate(typeof(uibsyoaCixjw));
		SvzZlTJXHyJn = false;
		MNcfYzRktFW = getString_0(107404019);
	}
}
