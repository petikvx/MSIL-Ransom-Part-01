using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class fFCYpdPapHY
{
	private static bool QHqhUxmYNLgFw;

	private static readonly string XLDTHwKdmajt;

	[NonSerialized]
	internal static GetString getString_0;

	public static string lDIEEniZHqoT(string string_0)
	{
		int WYlGRXFYIbEh = 0;
		string AiEqMdgSlKQV = getString_0(107388649);
		kOnYRkaCtXckHL(XLDTHwKdmajt, out WYlGRXFYIbEh, out AiEqMdgSlKQV);
		byte[] inArray = jMTRaWIOgcF(Encoding.UTF8.GetBytes(string_0), WYlGRXFYIbEh, AiEqMdgSlKQV);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] jMTRaWIOgcF(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = KXlswXblWceIf(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107401673), num), getString_0(107401650));
			}
			if (!EEcdWvQEMVIoK(int_0))
			{
				throw new ArgumentException(getString_0(107401636), getString_0(107401607));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107401562), getString_0(107401533));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, QHqhUxmYNLgFw);
		}
		throw new ArgumentException(getString_0(107402215), getString_0(107401650));
	}

	private static int KXlswXblWceIf(int int_0)
	{
		if (QHqhUxmYNLgFw)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool EEcdWvQEMVIoK(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void kOnYRkaCtXckHL(string ZZeuetWutSoL, out int WYlGRXFYIbEh, out string AiEqMdgSlKQV)
	{
		WYlGRXFYIbEh = 0;
		AiEqMdgSlKQV = getString_0(107388649);
		if (ZZeuetWutSoL == null || ZZeuetWutSoL.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ZZeuetWutSoL);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107401548)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				WYlGRXFYIbEh = int.Parse(array[0]);
				AiEqMdgSlKQV = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static fFCYpdPapHY()
	{
		Strings.CreateGetStringDelegate(typeof(fFCYpdPapHY));
		QHqhUxmYNLgFw = false;
		XLDTHwKdmajt = getString_0(107401543);
	}
}
