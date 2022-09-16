using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class vWsKVhBCwQW
{
	private static bool dLzWfExjActGOI;

	private static readonly string MGSzdCcWnDtg;

	[NonSerialized]
	internal static GetString getString_0;

	public static string nPhDaoiHjN(string string_0)
	{
		int LtblznktKwTcs = 0;
		string IKbWQojItHANxzs = getString_0(107389285);
		xdZgMTELTS(MGSzdCcWnDtg, out LtblznktKwTcs, out IKbWQojItHANxzs);
		byte[] inArray = HFspEnxafgPYjr(Encoding.UTF8.GetBytes(string_0), LtblznktKwTcs, IKbWQojItHANxzs);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] HFspEnxafgPYjr(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException(getString_0(107401591), getString_0(107401538));
		}
		int num = DyefJDJTtwLPG(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException(string.Format(getString_0(107401561), num), getString_0(107401538));
		}
		if (!soQWPvhmstIIy(int_0))
		{
			throw new ArgumentException(getString_0(107401524), getString_0(107401495));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException(getString_0(107401450), getString_0(107401421));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, dLzWfExjActGOI);
	}

	private static int DyefJDJTtwLPG(int int_0)
	{
		if (dLzWfExjActGOI)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool soQWPvhmstIIy(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void xdZgMTELTS(string SUzskysaBKNPkT, out int LtblznktKwTcs, out string IKbWQojItHANxzs)
	{
		LtblznktKwTcs = 0;
		IKbWQojItHANxzs = getString_0(107389285);
		if (SUzskysaBKNPkT == null || SUzskysaBKNPkT.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(SUzskysaBKNPkT);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107401436)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				LtblznktKwTcs = int.Parse(array[0]);
				IKbWQojItHANxzs = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static vWsKVhBCwQW()
	{
		Strings.CreateGetStringDelegate(typeof(vWsKVhBCwQW));
		dLzWfExjActGOI = false;
		MGSzdCcWnDtg = getString_0(107401431);
	}
}
