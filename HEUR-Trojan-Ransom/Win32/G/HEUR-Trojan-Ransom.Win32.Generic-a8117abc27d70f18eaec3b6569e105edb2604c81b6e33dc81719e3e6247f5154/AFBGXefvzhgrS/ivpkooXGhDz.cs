using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace AFBGXefvzhgrS;

public static class ivpkooXGhDz
{
	private static bool vbQrKeHPAgXyh;

	private static readonly string prRklfrkdFYmht;

	[NonSerialized]
	internal static GetString getString_0;

	public static string rCMsAIZligvZUKh(string string_0)
	{
		int JdUzzWxtgk = 0;
		string LjlfwlbhgNv = getString_0(107393792);
		xsSpahQthHd(prRklfrkdFYmht, out JdUzzWxtgk, out LjlfwlbhgNv);
		byte[] inArray = PHNekehaHHMzE(Encoding.UTF8.GetBytes(string_0), JdUzzWxtgk, LjlfwlbhgNv);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] PHNekehaHHMzE(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = gMPnpYFwYtNy(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107390534), num), getString_0(107390543));
			}
			if (!eWARDlcZDQwbjO(int_0))
			{
				throw new ArgumentException(getString_0(107390465), getString_0(107390468));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107390423), getString_0(107390394));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, vbQrKeHPAgXyh);
		}
		throw new ArgumentException(getString_0(107390052), getString_0(107390543));
	}

	private static int gMPnpYFwYtNy(int int_0)
	{
		if (vbQrKeHPAgXyh)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool eWARDlcZDQwbjO(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void xsSpahQthHd(string aCeyvpSwFX, out int JdUzzWxtgk, out string LjlfwlbhgNv)
	{
		JdUzzWxtgk = 0;
		LjlfwlbhgNv = getString_0(107393792);
		if (aCeyvpSwFX == null || aCeyvpSwFX.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(aCeyvpSwFX);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107390409)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				JdUzzWxtgk = int.Parse(array[0]);
				LjlfwlbhgNv = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static ivpkooXGhDz()
	{
		Strings.CreateGetStringDelegate(typeof(ivpkooXGhDz));
		vbQrKeHPAgXyh = false;
		prRklfrkdFYmht = getString_0(107390404);
	}
}
