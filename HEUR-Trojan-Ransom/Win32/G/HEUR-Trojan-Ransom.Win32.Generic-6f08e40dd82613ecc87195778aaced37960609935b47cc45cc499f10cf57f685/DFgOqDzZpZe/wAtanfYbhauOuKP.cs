using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

public static class wAtanfYbhauOuKP
{
	private static bool NAgCxYNdaoX;

	private static readonly string ZdyNkUelPjJ;

	[NonSerialized]
	internal static GetString getString_0;

	public static string MvqOeoNjtEKI(string string_0)
	{
		int ueMXgZhdYADlUSm = 0;
		string yfHUCSVRTLSPbx = getString_0(107389632);
		tkHRaYxuQwSVlR(ZdyNkUelPjJ, out ueMXgZhdYADlUSm, out yfHUCSVRTLSPbx);
		byte[] inArray = kxleQcLjYpMSa(Encoding.UTF8.GetBytes(string_0), ueMXgZhdYADlUSm, yfHUCSVRTLSPbx);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] kxleQcLjYpMSa(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = QxtBMQBSQPw(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107402333), num), getString_0(107402342));
			}
			if (!HwlckArSUUIrLN(int_0))
			{
				throw new ArgumentException(getString_0(107402328), getString_0(107402299));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107402286), getString_0(107402257));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, NAgCxYNdaoX);
		}
		throw new ArgumentException(getString_0(107402395), getString_0(107402342));
	}

	private static int QxtBMQBSQPw(int int_0)
	{
		if (NAgCxYNdaoX)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool HwlckArSUUIrLN(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void tkHRaYxuQwSVlR(string mdoosyXybXPfsok, out int ueMXgZhdYADlUSm, out string yfHUCSVRTLSPbx)
	{
		ueMXgZhdYADlUSm = 0;
		yfHUCSVRTLSPbx = getString_0(107389632);
		if (mdoosyXybXPfsok == null || mdoosyXybXPfsok.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(mdoosyXybXPfsok);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107402208)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				ueMXgZhdYADlUSm = int.Parse(array[0]);
				yfHUCSVRTLSPbx = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static wAtanfYbhauOuKP()
	{
		Strings.CreateGetStringDelegate(typeof(wAtanfYbhauOuKP));
		NAgCxYNdaoX = false;
		ZdyNkUelPjJ = getString_0(107402235);
	}
}
