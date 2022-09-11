using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace DevDefined.OAuth.Framework;

internal class l3rCSUWA2r6b7
{
	private static readonly Regex hMzblx4ASu4zQB;

	private static readonly Assembly Fxj37Y069nr98i1;

	private static int TIZQ8M0Bl2rz;

	private static readonly Dictionary<Guid, Match> dictionary_0;

	private static readonly Dictionary<Guid, Assembly> sX2GQq0X4Y5201bHh1;

	public static string wMDctdziDW9;

	public static string omdKeZd3m2XLD;

	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static string giC14tqBCfgWReCmxn;

	public static string bgufPvXwi1n4N7f2iN5;

	public static string NBC55Xdk48819McSVc;

	public static string Gh7iJyl2ZLL3910tAE;

	public static string j1sN1k3v4a4xGf0zPQ;

	static l3rCSUWA2r6b7()
	{
		hMzblx4ASu4zQB = new Regex(M4Uz5gB5doDNPQvC6i("61736d7a3a2f2f283f3c677569643e5b302d39612d66412d465d7b33327d292f283f3c73697a653e5b302d395d2b29282f283f3c666c6167733e5b612d7a412d5a302d395d2a29293f"), RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
		Fxj37Y069nr98i1 = typeof(l3rCSUWA2r6b7).Assembly;
		dictionary_0 = new Dictionary<Guid, Match>();
		sX2GQq0X4Y5201bHh1 = new Dictionary<Guid, Assembly>();
	}

	public static void GK5WO6XAkv4IL3osDu()
	{
		smethod_4(out Gh7iJyl2ZLL3910tAE);
		U5yQJ5pW793(out j1sN1k3v4a4xGf0zPQ);
		if (Interlocked.CompareExchange(ref TIZQ8M0Bl2rz, 1, 0) != 0)
		{
			return;
		}
		string[] manifestResourceNames = Fxj37Y069nr98i1.GetManifestResourceNames();
		foreach (string input in manifestResourceNames)
		{
			Match match = hMzblx4ASu4zQB.Match(input);
			if (match.Success)
			{
				Guid key = new Guid(match.Groups["guid"].Value);
				if (!dictionary_0.ContainsKey(key))
				{
					dictionary_0[key] = match;
				}
			}
		}
		B5R81OrsWVjocq();
	}

	public static Match tYlD5be3eK(string EzP8mG1A2v)
	{
		return hMzblx4ASu4zQB.Match(EzP8mG1A2v);
	}

	public static bool Lt5hjj2wJNL6od4(Guid guid_0)
	{
		return !dictionary_0.ContainsKey(guid_0);
	}

	public static string[] H1d2TOn2IX15BSbw2()
	{
		return Fxj37Y069nr98i1.GetManifestResourceNames();
	}

	public static void B5R81OrsWVjocq()
	{
		kOsKtm9ZB9m4PBaYXYL().AssemblyResolve += nkETvjMH8Sf1uPk5fl;
	}

	public static AppDomain kOsKtm9ZB9m4PBaYXYL()
	{
		return AppDomain.CurrentDomain;
	}

	public static Guid Saj9ykA21T3UK(string string_3)
	{
		return new Guid(string_3);
	}

	private static Assembly nkETvjMH8Sf1uPk5fl(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = "a" + 3;
		string text2 = 63.ToString();
		string text3 = 83.ToString();
		string text4 = 87.ToString();
		string text5 = M4Uz5gB5doDNPQvC6i(smethod_1($"{text}{text2}{text3}{text4}"));
		string text6 = text5 + resolveEventArgs_0.Name;
		string string_ = text6;
		Assembly assembly = smethod_0(string_);
		object obj = null;
		if (assembly == obj)
		{
			string_ = resolveEventArgs_0.Name;
			assembly = smethod_0(string_);
			if (assembly == obj)
			{
				assembly = smethod_0(text6);
			}
		}
		return assembly;
	}

	public static Assembly smethod_0(string string_3)
	{
		return vDPWuS8Pp3PaH(string_3);
	}

	public static string smethod_1(string string_3)
	{
		char[] array = string_3.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string M4Uz5gB5doDNPQvC6i(string mjf0hmQoddjyhd3)
	{
		byte[] array = new byte[mjf0hmQoddjyhd3.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Convert.ToByte(mjf0hmQoddjyhd3.Substring(i * 2, 2), 16);
		}
		return Encoding.ASCII.GetString(array);
	}

	public static string UR860VZW165t5H9(int SWYSHeNnP181)
	{
		string result = "";
		switch (SWYSHeNnP181)
		{
		case -5924:
			result = M4Uz5gB5doDNPQvC6i(67.ToString());
			break;
		case -7590:
			result = M4Uz5gB5doDNPQvC6i(69.ToString());
			break;
		case 846:
			result = M4Uz5gB5doDNPQvC6i(66.ToString());
			break;
		case 46:
			result = M4Uz5gB5doDNPQvC6i(6 + "c");
			break;
		case -94:
			result = M4Uz5gB5doDNPQvC6i(73.ToString());
			break;
		case 305144:
			result = M4Uz5gB5doDNPQvC6i(65.ToString());
			break;
		case 258644:
			result = M4Uz5gB5doDNPQvC6i(75.ToString());
			break;
		case 484651651:
			result = M4Uz5gB5doDNPQvC6i(64.ToString());
			break;
		case 98236984:
			result = M4Uz5gB5doDNPQvC6i(7 + "a");
			break;
		case 22222226:
			result = M4Uz5gB5doDNPQvC6i(61.ToString());
			break;
		}
		return result;
	}

	private static void Z5JWqAV8Mm1us9Kq7t5(out string string_3)
	{
		string_3 = UR860VZW165t5H9(846);
	}

	private static void v6PhNsgK78(out string Fc6sIdwatk5Lx)
	{
		Fc6sIdwatk5Lx = UR860VZW165t5H9(-5924);
	}

	private static void Rn4Nev07K5aDx1L8K(out string LEkcY80tL2RZZU1x6)
	{
		LEkcY80tL2RZZU1x6 = UR860VZW165t5H9(46);
	}

	private static void m73m8h2bse(out string string_3)
	{
		string_3 = UR860VZW165t5H9(98236984);
	}

	private static void pma4GwMx8G(out string JWqWEqD6zl)
	{
		JWqWEqD6zl = UR860VZW165t5H9(-94);
	}

	private static void JNrPPlICB2I5d2OAS(out string X1BmGfCp9q33S4)
	{
		X1BmGfCp9q33S4 = UR860VZW165t5H9(-7590);
	}

	private static void smethod_2(out string Tt6hmmAl1iHJnbI)
	{
		Tt6hmmAl1iHJnbI = UR860VZW165t5H9(305144);
	}

	private static void smethod_3(out string Oiu3kkgpAOg0x)
	{
		Oiu3kkgpAOg0x = UR860VZW165t5H9(22222226);
	}

	private static void smethod_4(out string a49yt07smy)
	{
		a49yt07smy = UR860VZW165t5H9(258644);
	}

	private static void U5yQJ5pW793(out string oNNd5Rf1mIux38ME8h)
	{
		oNNd5Rf1mIux38ME8h = UR860VZW165t5H9(484651651);
	}

	private static Assembly vDPWuS8Pp3PaH(string HuLFWcAh7a)
	{
		try
		{
			if (!dictionary_0.TryGetValue(vHRXpv4EaZp7T6V(HuLFWcAh7a), out var value))
			{
				return null;
			}
			if (sX2GQq0X4Y5201bHh1.TryGetValue(vHRXpv4EaZp7T6V(HuLFWcAh7a), out var value2))
			{
				return value2;
			}
			HuLFWcAh7a = value.Groups[0].Value;
			Z5JWqAV8Mm1us9Kq7t5(out wMDctdziDW9);
			v6PhNsgK78(out omdKeZd3m2XLD);
			Rn4Nev07K5aDx1L8K(out string_0);
			m73m8h2bse(out string_1);
			pma4GwMx8G(out string_2);
			JNrPPlICB2I5d2OAS(out giC14tqBCfgWReCmxn);
			smethod_2(out bgufPvXwi1n4N7f2iN5);
			smethod_3(out NBC55Xdk48819McSVc);
			mfXoFPKIRKd6s2K59yV(value).Contains(string_1);
			byte[] byte_ = bbJQrEiLc24p29FhMK8(HuLFWcAh7a, LaxLtKX0lHt(value));
			Assembly assembly = NTqVDX93oF7rS(byte_);
			lock (sX2GQq0X4Y5201bHh1)
			{
				if (sX2GQq0X4Y5201bHh1.TryGetValue(vHRXpv4EaZp7T6V(HuLFWcAh7a), out var value3))
				{
					return value3;
				}
				if (assembly != null)
				{
					sX2GQq0X4Y5201bHh1[vHRXpv4EaZp7T6V(HuLFWcAh7a)] = assembly;
				}
			}
			return assembly;
		}
		catch
		{
			return null;
		}
	}

	public static int LaxLtKX0lHt(Match match_0)
	{
		return int.Parse(match_0.Groups[string_2 + giC14tqBCfgWReCmxn + string_1 + bgufPvXwi1n4N7f2iN5].Value);
	}

	public static string mfXoFPKIRKd6s2K59yV(Match mBE7r9DE8TC7sMLvy)
	{
		return GrzhgKbF07Q8xv8G(mBE7r9DE8TC7sMLvy, wMDctdziDW9 + string_0 + NBC55Xdk48819McSVc + omdKeZd3m2XLD + string_2);
	}

	public static Assembly NTqVDX93oF7rS(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	public static string GrzhgKbF07Q8xv8G(Match bfed09U85HIklEQ3q, string xIkLW1J5NU1JVm92)
	{
		return bfed09U85HIklEQ3q.Groups[xIkLW1J5NU1JVm92].Value;
	}

	public static byte[] bbJQrEiLc24p29FhMK8(string ztn44wahVW5LsHP2, int int_0)
	{
		byte[] array = new byte[int_0];
		using Stream stream = Fxj37Y069nr98i1.GetManifestResourceStream(ztn44wahVW5LsHP2);
		if (stream != null)
		{
			using (Stream stream2 = new DeflateStream(stream, CompressionMode.Decompress))
			{
				stream2.Read(array, 0, int_0);
				return array;
			}
		}
		return null;
	}

	private static Guid vHRXpv4EaZp7T6V(string NAUE4Fz8Ppoc)
	{
		byte[] b = tiah2zpEAdJ9(VuO3k797e1Gm(NAUE4Fz8Ppoc));
		return new Guid(b);
	}

	private static byte[] VuO3k797e1Gm(string alEB4t8AJax7FP)
	{
		return Encoding.UTF8.GetBytes(alEB4t8AJax7FP.ToLowerInvariant());
	}

	private static byte[] tiah2zpEAdJ9(byte[] wIjo15Fo3oU5DPmt05)
	{
		rQO519tkVGe7VtM(wIjo15Fo3oU5DPmt05, out wIjo15Fo3oU5DPmt05);
		return wIjo15Fo3oU5DPmt05;
	}

	private static void rQO519tkVGe7VtM(byte[] a1jGkkez4pl, out byte[] JdvjheRfIMRPi)
	{
		JdvjheRfIMRPi = MD5.Create().ComputeHash(a1jGkkez4pl);
	}
}
