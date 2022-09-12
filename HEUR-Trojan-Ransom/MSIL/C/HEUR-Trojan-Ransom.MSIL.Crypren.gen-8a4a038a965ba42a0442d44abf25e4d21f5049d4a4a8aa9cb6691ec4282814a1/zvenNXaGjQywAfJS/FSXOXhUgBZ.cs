using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace zvenNXaGjQywAfJS;

public static class FSXOXhUgBZ
{
	private static bool IUHwkPrLOrmth;

	private static readonly string ISSkHYMRPVWLV;

	[NonSerialized]
	internal static GetString getString_0;

	public static string xjZeAJzrGxgor(string string_0)
	{
		int EtjdzlVJCNEP = 0;
		string nZtRZYouFrpnnfE = getString_0(107395131);
		sCkmduavkhKMK(ISSkHYMRPVWLV, out EtjdzlVJCNEP, out nZtRZYouFrpnnfE);
		byte[] inArray = nUcXGLzTQMktI(Encoding.UTF8.GetBytes(string_0), EtjdzlVJCNEP, nZtRZYouFrpnnfE);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] nUcXGLzTQMktI(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = hNtCRePFBKfh(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107409520), num), getString_0(107409497));
			}
			if (!XfZUGGSfnOOT(int_0))
			{
				throw new ArgumentException(getString_0(107409483), getString_0(107409454));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107409409), getString_0(107409412));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, IUHwkPrLOrmth);
		}
		throw new ArgumentException(getString_0(107409550), getString_0(107409497));
	}

	private static int hNtCRePFBKfh(int int_0)
	{
		if (IUHwkPrLOrmth)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool XfZUGGSfnOOT(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void sCkmduavkhKMK(string IQzbzomqVzfFD, out int EtjdzlVJCNEP, out string nZtRZYouFrpnnfE)
	{
		EtjdzlVJCNEP = 0;
		nZtRZYouFrpnnfE = getString_0(107395131);
		if (IQzbzomqVzfFD == null || IQzbzomqVzfFD.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(IQzbzomqVzfFD);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107409363)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				EtjdzlVJCNEP = int.Parse(array[0]);
				nZtRZYouFrpnnfE = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static FSXOXhUgBZ()
	{
		Strings.CreateGetStringDelegate(typeof(FSXOXhUgBZ));
		IUHwkPrLOrmth = false;
		ISSkHYMRPVWLV = getString_0(107409390);
	}
}
