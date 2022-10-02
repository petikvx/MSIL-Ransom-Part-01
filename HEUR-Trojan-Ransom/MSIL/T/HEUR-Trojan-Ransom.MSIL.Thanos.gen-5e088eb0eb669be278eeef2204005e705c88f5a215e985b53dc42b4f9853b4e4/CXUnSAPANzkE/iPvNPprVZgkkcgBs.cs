using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public static class iPvNPprVZgkkcgBs
{
	private static bool NxikFMZcxcfjo;

	private static readonly string FfIrETTEJBSXrZr;

	[NonSerialized]
	internal static GetString getString_0;

	public static string qDBKGOSTlO(string string_0)
	{
		int lzpeMjFxQBbls = 0;
		string MJFoNLjfOWXmrb = getString_0(107393771);
		RFAVINWbDXP(FfIrETTEJBSXrZr, out lzpeMjFxQBbls, out MJFoNLjfOWXmrb);
		byte[] inArray = RgqPTbZfZmzI(Encoding.UTF8.GetBytes(string_0), lzpeMjFxQBbls, MJFoNLjfOWXmrb);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] RgqPTbZfZmzI(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = hwxDAfXAkzMqH(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107404058), num), getString_0(107404099));
			}
			if (!xezwDSIYZCs(int_0))
			{
				throw new ArgumentException(getString_0(107404021), getString_0(107403992));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404011), getString_0(107404494));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, NxikFMZcxcfjo);
		}
		throw new ArgumentException(getString_0(107404088), getString_0(107404099));
	}

	private static int hwxDAfXAkzMqH(int int_0)
	{
		if (NxikFMZcxcfjo)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool xezwDSIYZCs(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void RFAVINWbDXP(string XwxCxLtECLQ, out int lzpeMjFxQBbls, out string MJFoNLjfOWXmrb)
	{
		lzpeMjFxQBbls = 0;
		MJFoNLjfOWXmrb = getString_0(107393771);
		if (XwxCxLtECLQ == null || XwxCxLtECLQ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(XwxCxLtECLQ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107404445)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				lzpeMjFxQBbls = int.Parse(array[0]);
				MJFoNLjfOWXmrb = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static iPvNPprVZgkkcgBs()
	{
		Strings.CreateGetStringDelegate(typeof(iPvNPprVZgkkcgBs));
		NxikFMZcxcfjo = false;
		FfIrETTEJBSXrZr = getString_0(107404440);
	}
}
