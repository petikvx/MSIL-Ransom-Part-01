using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

public static class NBfAhNGgEOukSCU
{
	private static bool bCBqGwIjVRRQFT;

	private static readonly string WSdnvQZwbxlnY;

	[NonSerialized]
	internal static GetString getString_0;

	public static string IWKbJmSvSVmK(string string_0)
	{
		int sqHECHRwQDuBj = 0;
		string iFuDFxvhLGL = getString_0(107389740);
		PddYhPMjFeCK(WSdnvQZwbxlnY, out sqHECHRwQDuBj, out iFuDFxvhLGL);
		byte[] inArray = aAaPUnvcXU(Encoding.UTF8.GetBytes(string_0), sqHECHRwQDuBj, iFuDFxvhLGL);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] aAaPUnvcXU(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = kmUiuQGGaPkt(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107402017), num), getString_0(107402026));
			}
			if (!REffAYabSwHXoQrM(int_0))
			{
				throw new ArgumentException(getString_0(107402012), getString_0(107401983));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107401970), getString_0(107401941));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, bCBqGwIjVRRQFT);
		}
		throw new ArgumentException(getString_0(107402079), getString_0(107402026));
	}

	private static int kmUiuQGGaPkt(int int_0)
	{
		if (bCBqGwIjVRRQFT)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool REffAYabSwHXoQrM(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void PddYhPMjFeCK(string HGZWntYaVNMeOw, out int sqHECHRwQDuBj, out string iFuDFxvhLGL)
	{
		sqHECHRwQDuBj = 0;
		iFuDFxvhLGL = getString_0(107389740);
		if (HGZWntYaVNMeOw == null || HGZWntYaVNMeOw.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(HGZWntYaVNMeOw);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107401892)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				sqHECHRwQDuBj = int.Parse(array[0]);
				iFuDFxvhLGL = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static NBfAhNGgEOukSCU()
	{
		Strings.CreateGetStringDelegate(typeof(NBfAhNGgEOukSCU));
		bCBqGwIjVRRQFT = false;
		WSdnvQZwbxlnY = getString_0(107401919);
	}
}
