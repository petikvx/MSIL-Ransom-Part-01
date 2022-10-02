using System;
using System.Security.Cryptography;
using System.Text;

namespace VsYjhNTIRPBh;

public static class gUDFOoTZrDKjIfA
{
	private static bool aFoIanfXwljlW = false;

	private static readonly string urKdgQVXlrW = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+c3RWY3Q2V0YyWk0zV3V2ZDFRczNWbWQvbHNhSWpnRys5REhDRDRZcUtqZGJzSlQ0TE1JNHlSOFU5WmczK3JtM1NFWW1LK2dXVDROMkw5djFpejVkV0xtVGJNUHN3SVpNeXl2WTRvUzdJUDlMblA0VWF5ckN1OWVEK1AvTnI1a3RidzhzWU1aWDg2VEFvSUJkSGxmcHdiMWFFcEt0RmhpWjFkRWVZTVBtY1ZIRGlpRFVvY2VwQW1yanp2Wmh5K2pncFVBWG9aTVFWWXlGdlJSWmw4Ui9HL1gvdno5WGk2bFJEMHlnUG1wc0EyZ29uVXlodFN1NGROME15OUhpNUxheEhWeXZPTDBJdGt1blBwL2VDU0gyODFBcUpiODRoYjVTRGxpVG43OWo5RWNsb0J2aVNxQ0M1aDNXc2NMcnRGaCtPWXZMbDY4UHRaMXBEMVFCOVhvYnJrRG1TUUVmVkpBWUlkT3d1Ty8vZ0JtNEM4WGpjTDJnZVZzd2VuMzdhLy9QN01BbVZHb1hUWEJ0TVBVaUVJTFFRTnE0N1JraWNDVVVKOGdsVi9sbnMxSWVnd2RRbHNSa2RBc1E1ZGZrMk9pMTV3WVZBM3dkcWs1UXZ3ckNrSkpLaVhMbmErdExJSnZzOERNVkxJSjh6ZUM5djkzc05sSzlPdEEydnNLOU1ScHgrUWpnU0UxQzhKK3NCZ0NSeDNldVhjVVd0N0NaWG9DcWlPUVlhNml4ZWgzVlNwaWMxekNGWlJkU0VpbzZ0cmpVU3RLYTlUVjhBTmlhbEtaUVA4NlluRzdwUlpxQ0FPMUZOTlNPVld0U0xlVkJXN2NpY1o5amg2eitoVDVvWjFveU85NGdPOWNPTnhYQVQrNk55TmNZZS9PT0xSZE9QSXBYWXhTZk1uSEo2QWs9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string kqOSSOKTyvumBVs(string rCdjOVcEJZQC)
	{
		int bIkJXKqIoJT = 0;
		string JrEftUxnsplY = "";
		HfoAIKFmPWqs(urKdgQVXlrW, out bIkJXKqIoJT, out JrEftUxnsplY);
		byte[] inArray = JmCwuhwrNBp(Encoding.UTF8.GetBytes(rCdjOVcEJZQC), bIkJXKqIoJT, JrEftUxnsplY);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] JmCwuhwrNBp(byte[] cylRRSxnnbRRPlQXD, int hrRJtBBqgHpj, string OgVOFBsSQniebpzv)
	{
		if (cylRRSxnnbRRPlQXD != null && cylRRSxnnbRRPlQXD.Length != 0)
		{
			int num = iWuEDjtLlxzgG(hrRJtBBqgHpj);
			if (cylRRSxnnbRRPlQXD.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!wRUFJRkYNZh(hrRJtBBqgHpj))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(OgVOFBsSQniebpzv))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(hrRJtBBqgHpj);
			rSACryptoServiceProvider.FromXmlString(OgVOFBsSQniebpzv);
			return rSACryptoServiceProvider.Encrypt(cylRRSxnnbRRPlQXD, aFoIanfXwljlW);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int iWuEDjtLlxzgG(int TEFbMsknacRZ)
	{
		if (aFoIanfXwljlW)
		{
			return (TEFbMsknacRZ - 384) / 8 + 7;
		}
		return (TEFbMsknacRZ - 384) / 8 + 37;
	}

	private static bool wRUFJRkYNZh(int CrzFLUKhOvNapSnLM)
	{
		if (CrzFLUKhOvNapSnLM >= 384 && CrzFLUKhOvNapSnLM <= 16384)
		{
			return CrzFLUKhOvNapSnLM % 8 == 0;
		}
		return false;
	}

	private static void HfoAIKFmPWqs(string rGADsJtbaiwCG, out int bIkJXKqIoJT, out string JrEftUxnsplY)
	{
		bIkJXKqIoJT = 0;
		JrEftUxnsplY = "";
		if (rGADsJtbaiwCG == null || rGADsJtbaiwCG.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(rGADsJtbaiwCG);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				bIkJXKqIoJT = int.Parse(array[0]);
				JrEftUxnsplY = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
