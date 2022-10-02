using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public static class PCJtGUZSSSjG
{
	private static bool evtBTwRVSlWd;

	private static readonly string pIKzJPPOeQ;

	[NonSerialized]
	internal static GetString getString_0;

	public static string qptqJEFjBlKiOZ(string string_0)
	{
		int DrtdfLbDlpy = 0;
		string hhIlJfPCglddf = getString_0(107368963);
		MbAAqFNYhOw(pIKzJPPOeQ, out DrtdfLbDlpy, out hhIlJfPCglddf);
		byte[] inArray = fWSRidLxoVST(Encoding.UTF8.GetBytes(string_0), DrtdfLbDlpy, hhIlJfPCglddf);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] fWSRidLxoVST(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = WgTAZmnopcaq(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107477205), num), getString_0(107477214));
			}
			if (!IVAFngqWQo(int_0))
			{
				throw new ArgumentException(getString_0(107477168), getString_0(107477651));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107477670), getString_0(107477641));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, evtBTwRVSlWd);
		}
		throw new ArgumentException(getString_0(107477235), getString_0(107477214));
	}

	private static int WgTAZmnopcaq(int int_0)
	{
		if (evtBTwRVSlWd)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool IVAFngqWQo(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void MbAAqFNYhOw(string wgNZfjnleMUutMQ, out int DrtdfLbDlpy, out string hhIlJfPCglddf)
	{
		DrtdfLbDlpy = 0;
		hhIlJfPCglddf = getString_0(107368963);
		if (wgNZfjnleMUutMQ == null || wgNZfjnleMUutMQ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(wgNZfjnleMUutMQ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107477592)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				DrtdfLbDlpy = int.Parse(array[0]);
				hhIlJfPCglddf = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static PCJtGUZSSSjG()
	{
		Strings.CreateGetStringDelegate(typeof(PCJtGUZSSSjG));
		evtBTwRVSlWd = false;
		pIKzJPPOeQ = getString_0(107477587);
	}
}
