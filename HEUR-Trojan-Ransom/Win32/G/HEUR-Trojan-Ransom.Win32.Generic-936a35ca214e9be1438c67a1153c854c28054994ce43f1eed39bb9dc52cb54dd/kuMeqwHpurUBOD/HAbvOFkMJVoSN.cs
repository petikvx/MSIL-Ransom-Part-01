using System;
using System.Security.Cryptography;
using System.Text;

namespace kuMeqwHpurUBOD;

public static class HAbvOFkMJVoSN
{
	private static bool URMtKnWIRXzBnExG = false;

	private static readonly string HChZWyoLyPhSN = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+cXRGUFhDc3N4Y3ZNQTRQNTJza2UzMTRsZUtqd3RrTUY0RVg1RU1YdjE1bzJ4K0lUZGNnVTc5bUNVSmVSSFVFdEE5bHkzcXlURWpkU0hzRi9tYkpSQ0dOdU5qWVN2ZlVPSFcxOUlQMTlaVnFpYzd3K3NMcWIzUFdTSTIrcmt1WUNZTHUyaFBCTGNtTTl2ZUFjcjJqejdSRUdxWW05UCsxWEVuK0ZJOFpKWmJvK2RkU1dmLzN6NGJCbDZCc2hVQmIyM2dUUHM5Y3RpWDBMTllBc3dpRE52YWlqdks3b2V3Tk0rSUtCaTZHNUdoaEFDWmFUV2w4UytVUGFHUHhoeCtUVjZxSXJGN1VvZHVhN1NMNEJwS204Rk9OUVFjeFFQd1Q1WTVIUXBCMHZjRnphdVlRVHRyRmZhT2FRbzJ1VHVxQmNLdU5UZzRyYW5ibXMzSm9INGpEQ3BtejErc2JHZGJvTmhZbnZ1L3JGNm1vZEZvdWVkRFRFL2VVSUdaRG55OTdzTDFJcWV3RXZmNEZLYU9KTlZWeDQ3cnUzMXkwRVMzQlFIanFaS2dESGx6MC8xLzVyTUtEeTFXS09RanJ0VU90YUpnc0Nic2l0QUNpVGxDcE5meWszY0pzbmFxckhoQk85WjgyY3pDdmpxQzkzVnRMeG5qU2daYmpTMHNOUVNCV2FwV0tRekZOV3JkaXMvelpqRFJCS2JhUC95amIxMmhyMlRaRGFDd0Vnd291MHRjZXk3RHNJTDZ3SFd6Z1FJRVlJaU9ySDRMSlJlb3ZkUmVueHkrRXh4TmhsWWV2VTE5NkJXZGJMZ0QyU2RFRWcyMG1zTnZnU0wrU2ZzUjNQYytwMlJGM0NLS3E4T0lkQ2FDTFhFRmlhYm9zR1FtSWZuK3E0cytpb295UDkvUXM9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string IOEmPutvAYpeIgr(string string_0)
	{
		int CFNsHziLhJ = 0;
		string PnDRyotjmSC = "";
		NIfZnGdgcpaOhG(HChZWyoLyPhSN, out CFNsHziLhJ, out PnDRyotjmSC);
		byte[] inArray = ltehSGVvYQLIYGVsv(Encoding.UTF8.GetBytes(string_0), CFNsHziLhJ, PnDRyotjmSC);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] ltehSGVvYQLIYGVsv(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = HghdKiIUjZkj(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!fHhumgSRVfyEu(int_0))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, URMtKnWIRXzBnExG);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int HghdKiIUjZkj(int int_0)
	{
		if (URMtKnWIRXzBnExG)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool fHhumgSRVfyEu(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void NIfZnGdgcpaOhG(string KoiLEkyNKepEF, out int CFNsHziLhJ, out string PnDRyotjmSC)
	{
		CFNsHziLhJ = 0;
		PnDRyotjmSC = "";
		if (KoiLEkyNKepEF == null || KoiLEkyNKepEF.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(KoiLEkyNKepEF);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				CFNsHziLhJ = int.Parse(array[0]);
				PnDRyotjmSC = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
