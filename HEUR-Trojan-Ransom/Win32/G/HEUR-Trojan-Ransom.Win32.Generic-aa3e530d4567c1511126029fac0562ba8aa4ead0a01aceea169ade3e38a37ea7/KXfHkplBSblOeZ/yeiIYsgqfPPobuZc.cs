using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KXfHkplBSblOeZ;

public static class yeiIYsgqfPPobuZc
{
	private static bool WexzzqXxNNsuhX;

	private static readonly string MYoyvfbkWlWZK;

	[NonSerialized]
	internal static GetString getString_0;

	public static string cWgNetVEfgEv(string string_0)
	{
		int SIRBkrNPVDHC = 0;
		string CIReOkhWTX = getString_0(107393321);
		mLHzWKTUgg(MYoyvfbkWlWZK, out SIRBkrNPVDHC, out CIReOkhWTX);
		byte[] inArray = WTUuEDCAxnBhUqO(Encoding.UTF8.GetBytes(string_0), SIRBkrNPVDHC, CIReOkhWTX);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] WTUuEDCAxnBhUqO(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = fKRdMRYzABf(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107405472), num), getString_0(107405513));
			}
			if (!xmLOpvyZACbaWa(int_0))
			{
				throw new ArgumentException(getString_0(107405435), getString_0(107405406));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107405425), getString_0(107405396));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, WexzzqXxNNsuhX);
		}
		throw new ArgumentException(getString_0(107405502), getString_0(107405513));
	}

	private static int fKRdMRYzABf(int int_0)
	{
		if (WexzzqXxNNsuhX)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool xmLOpvyZACbaWa(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void mLHzWKTUgg(string PPVLbHBytldGY, out int SIRBkrNPVDHC, out string CIReOkhWTX)
	{
		SIRBkrNPVDHC = 0;
		CIReOkhWTX = getString_0(107393321);
		if (PPVLbHBytldGY == null || PPVLbHBytldGY.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(PPVLbHBytldGY);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107405347)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				SIRBkrNPVDHC = int.Parse(array[0]);
				CIReOkhWTX = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static yeiIYsgqfPPobuZc()
	{
		Strings.CreateGetStringDelegate(typeof(yeiIYsgqfPPobuZc));
		WexzzqXxNNsuhX = false;
		MYoyvfbkWlWZK = getString_0(107405342);
	}
}
