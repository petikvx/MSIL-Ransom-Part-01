using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

public static class hTchmIjujxwM
{
	private static bool iYfjDANbempr;

	private static readonly string RvefVSotgRSSkQ;

	[NonSerialized]
	internal static GetString getString_0;

	public static string GMfqOAiITqajuCI(string string_0)
	{
		int yKZKjGllKCsw = 0;
		string tZcGYDNZXPF = getString_0(107394074);
		wxBTldTvXRXbtF(RvefVSotgRSSkQ, out yKZKjGllKCsw, out tZcGYDNZXPF);
		byte[] inArray = MiYDXqdMyfnNDsW(Encoding.UTF8.GetBytes(string_0), yKZKjGllKCsw, tZcGYDNZXPF);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] MiYDXqdMyfnNDsW(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = tUHufPUqoEvP(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107404520), num), getString_0(107404497));
			}
			if (!ArncTqaIFqEDVF(int_0))
			{
				throw new ArgumentException(getString_0(107404995), getString_0(107404966));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404921), getString_0(107404892));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, iYfjDANbempr);
		}
		throw new ArgumentException(getString_0(107404550), getString_0(107404497));
	}

	private static int tUHufPUqoEvP(int int_0)
	{
		if (iYfjDANbempr)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool ArncTqaIFqEDVF(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void wxBTldTvXRXbtF(string jmqMQGIzslZ, out int yKZKjGllKCsw, out string tZcGYDNZXPF)
	{
		yKZKjGllKCsw = 0;
		tZcGYDNZXPF = getString_0(107394074);
		if (jmqMQGIzslZ == null || jmqMQGIzslZ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(jmqMQGIzslZ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107404907)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				yKZKjGllKCsw = int.Parse(array[0]);
				tZcGYDNZXPF = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static hTchmIjujxwM()
	{
		Strings.CreateGetStringDelegate(typeof(hTchmIjujxwM));
		iYfjDANbempr = false;
		RvefVSotgRSSkQ = getString_0(107404902);
	}
}
