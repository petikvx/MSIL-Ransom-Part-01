using System;
using System.Security.Cryptography;
using System.Text;

namespace nLpTFjJRwUBp;

public static class ddeFRRDtEqs
{
	private static bool AFUYKuvHNOibV = false;

	private static readonly string cAnDFPJxGe = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+c3RWY3Q2V0YyWk0zV3V2ZDFRczNWbWQvbHNhSWpnRys5REhDRDRZcUtqZGJzSlQ0TE1JNHlSOFU5WmczK3JtM1NFWW1LK2dXVDROMkw5djFpejVkV0xtVGJNUHN3SVpNeXl2WTRvUzdJUDlMblA0VWF5ckN1OWVEK1AvTnI1a3RidzhzWU1aWDg2VEFvSUJkSGxmcHdiMWFFcEt0RmhpWjFkRWVZTVBtY1ZIRGlpRFVvY2VwQW1yanp2Wmh5K2pncFVBWG9aTVFWWXlGdlJSWmw4Ui9HL1gvdno5WGk2bFJEMHlnUG1wc0EyZ29uVXlodFN1NGROME15OUhpNUxheEhWeXZPTDBJdGt1blBwL2VDU0gyODFBcUpiODRoYjVTRGxpVG43OWo5RWNsb0J2aVNxQ0M1aDNXc2NMcnRGaCtPWXZMbDY4UHRaMXBEMVFCOVhvYnJrRG1TUUVmVkpBWUlkT3d1Ty8vZ0JtNEM4WGpjTDJnZVZzd2VuMzdhLy9QN01BbVZHb1hUWEJ0TVBVaUVJTFFRTnE0N1JraWNDVVVKOGdsVi9sbnMxSWVnd2RRbHNSa2RBc1E1ZGZrMk9pMTV3WVZBM3dkcWs1UXZ3ckNrSkpLaVhMbmErdExJSnZzOERNVkxJSjh6ZUM5djkzc05sSzlPdEEydnNLOU1ScHgrUWpnU0UxQzhKK3NCZ0NSeDNldVhjVVd0N0NaWG9DcWlPUVlhNml4ZWgzVlNwaWMxekNGWlJkU0VpbzZ0cmpVU3RLYTlUVjhBTmlhbEtaUVA4NlluRzdwUlpxQ0FPMUZOTlNPVld0U0xlVkJXN2NpY1o5amg2eitoVDVvWjFveU85NGdPOWNPTnhYQVQrNk55TmNZZS9PT0xSZE9QSXBYWXhTZk1uSEo2QWs9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string wfmtJmcBJJaY(string tISgcknEpCeAV)
	{
		int iCxuUzdtMMn = 0;
		string BTWoXPzyDZ = "";
		iqGvduHsOAkJJ(cAnDFPJxGe, out iCxuUzdtMMn, out BTWoXPzyDZ);
		byte[] inArray = cejtzTaNehvb(Encoding.UTF8.GetBytes(tISgcknEpCeAV), iCxuUzdtMMn, BTWoXPzyDZ);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] cejtzTaNehvb(byte[] ACyUzyaHZePe, int IIWIHBqzWkUTNy, string RNDtDDjcaXI)
	{
		if (ACyUzyaHZePe != null && ACyUzyaHZePe.Length != 0)
		{
			int num = AezLqUUjJMMcb(IIWIHBqzWkUTNy);
			if (ACyUzyaHZePe.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!IXHkmdnJSTT(IIWIHBqzWkUTNy))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(RNDtDDjcaXI))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(IIWIHBqzWkUTNy);
			rSACryptoServiceProvider.FromXmlString(RNDtDDjcaXI);
			return rSACryptoServiceProvider.Encrypt(ACyUzyaHZePe, AFUYKuvHNOibV);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int AezLqUUjJMMcb(int FsGtIOJXdoLT)
	{
		if (AFUYKuvHNOibV)
		{
			return (FsGtIOJXdoLT - 384) / 8 + 7;
		}
		return (FsGtIOJXdoLT - 384) / 8 + 37;
	}

	private static bool IXHkmdnJSTT(int tohJuxriBQGVL)
	{
		if (tohJuxriBQGVL >= 384 && tohJuxriBQGVL <= 16384)
		{
			return tohJuxriBQGVL % 8 == 0;
		}
		return false;
	}

	private static void iqGvduHsOAkJJ(string iVDiOaOzdgOE, out int iCxuUzdtMMn, out string BTWoXPzyDZ)
	{
		iCxuUzdtMMn = 0;
		BTWoXPzyDZ = "";
		if (iVDiOaOzdgOE == null || iVDiOaOzdgOE.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(iVDiOaOzdgOE);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				iCxuUzdtMMn = int.Parse(array[0]);
				BTWoXPzyDZ = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
