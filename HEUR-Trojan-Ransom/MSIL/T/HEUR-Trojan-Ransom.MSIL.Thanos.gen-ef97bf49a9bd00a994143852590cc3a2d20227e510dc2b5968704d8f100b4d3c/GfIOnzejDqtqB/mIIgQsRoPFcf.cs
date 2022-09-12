using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

public static class mIIgQsRoPFcf
{
	private static bool mbdalaEcSBpYzRh;

	private static readonly string JmUwwPaCrHyD;

	[NonSerialized]
	internal static GetString getString_0;

	public static string lAQgyDpGyMnN(string string_0)
	{
		int WzqIYCBtcQsMmD = 0;
		string AiOKtSbpGZZ = getString_0(107392224);
		vDzldBIQry(JmUwwPaCrHyD, out WzqIYCBtcQsMmD, out AiOKtSbpGZZ);
		byte[] inArray = fQcbAMQThQGF(Encoding.UTF8.GetBytes(string_0), WzqIYCBtcQsMmD, AiOKtSbpGZZ);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] fQcbAMQThQGF(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = ZwHlqrFzMmEvNC(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107406337), num), getString_0(107406378));
			}
			if (!cRvmaNxNjkZM(int_0))
			{
				throw new ArgumentException(getString_0(107406300), getString_0(107406271));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107406290), getString_0(107406229));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, mbdalaEcSBpYzRh);
		}
		throw new ArgumentException(getString_0(107406367), getString_0(107406378));
	}

	private static int ZwHlqrFzMmEvNC(int int_0)
	{
		if (mbdalaEcSBpYzRh)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool cRvmaNxNjkZM(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void vDzldBIQry(string EaEBZqDLyGJEoRbD, out int WzqIYCBtcQsMmD, out string AiOKtSbpGZZ)
	{
		WzqIYCBtcQsMmD = 0;
		AiOKtSbpGZZ = getString_0(107392224);
		if (EaEBZqDLyGJEoRbD == null || EaEBZqDLyGJEoRbD.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(EaEBZqDLyGJEoRbD);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107406244)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				WzqIYCBtcQsMmD = int.Parse(array[0]);
				AiOKtSbpGZZ = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static mIIgQsRoPFcf()
	{
		Strings.CreateGetStringDelegate(typeof(mIIgQsRoPFcf));
		mbdalaEcSBpYzRh = false;
		JmUwwPaCrHyD = getString_0(107405695);
	}
}
