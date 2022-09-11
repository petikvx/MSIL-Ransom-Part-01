using System;
using System.Security.Cryptography;
using System.Text;

namespace oEqFtKwIikP;

public static class RBpOuRDExgT
{
	private static bool tlmADmMZgGp = false;

	private static readonly string yoADuosbdmGyC = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+cjd4THFLNklKRE81ZWJOOWl3RWVYVW5pcUdtemw1eHIxaHRsYitnWk9EMmp2U3FRcE8wNnpiYkhaWUphek40V05rKzZ3MC82bExkbW9BOUV1VkJuTHRPRWtaTG9NM3hkd21vVE52KzBmY0tOcEk0TE04UTJPaTcxb2xBM3F4dGdUSjVvMVJYMWtmRHVBUUgyMmEwckM2K3FTekVmY3ZGVE00QWhXLzArbVRiNmwxVDd1S2xmajhnVVJ3QWcxLzJkVTl5RjJJR3psdmlML2o3YlIreCtkY2JqeEdDOWZ6ZFNCSmdQMDBMLzBmTFdPRVREMjRVc2Q2K3RERWZpbEdJSUpORWpwUDVjYWEycUNCVXZMbkhwdlZnZkpONjVoZkJGb0tMdjlOV1dvdVpUM1BtMGJzNzYzbzRXQVZJZnpwMVdHczFKVDR6MVc2dDllanFFVmFyRnQ1UXJ0YnZXNENxOHdCVmZESDc2c3hoWVJPOFN2SmlGY2YxWnNuakR6TW0wUEZDaFNSL2hIWHRHQzNPM203b3dPU3pVdzU5QjMzVmFsc3N2WFJXV3M3YUpDSkhRRzlEampKMU1BM2I3QXdUanM0OENCVlJta2RDM2s0c0lxSVFEc1VxeEdSQ2g2ZVU5UENhdWVTdnRYR3ZUUDhjazZPZHcxR3d4UjViQnlQWVU0SWcwZVZWMkhoaXVIOVcwbjR2R1ZCMWN4RkE5WWtpY1EzVXZncGk1L2dHOGx3NFM1YzVoUnBMOW5NN013VTFmVzV2bEFHcTJFNEJVL3QxSXFCUVJBZTc1ZXN6MkRlK3ppMFBKMkdrM0gwdVZpYmFzNnVSa0dmVlF6Skl1bnlwZkRPYjJlS1haWkt5NEdkRUZWZis0MndqaTFVSm5PS0VJWGZQVUNTc3hkYUU9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string WOJXStxiSqaqtS(string jWGJzFIbzNWHmpp)
	{
		int tJTCwknkfjcO = 0;
		string HdVKBKBeCOrA = "";
		osJgxwyqrKM(yoADuosbdmGyC, out tJTCwknkfjcO, out HdVKBKBeCOrA);
		byte[] inArray = gJUkQVZhQJbH(Encoding.UTF8.GetBytes(jWGJzFIbzNWHmpp), tJTCwknkfjcO, HdVKBKBeCOrA);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] gJUkQVZhQJbH(byte[] SeskIzbtWXah, int PzDrIUIcQGS, string SCXEISRqBsCFoqP)
	{
		if (SeskIzbtWXah != null && SeskIzbtWXah.Length != 0)
		{
			int num = EYofNycFUlYfdw(PzDrIUIcQGS);
			if (SeskIzbtWXah.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!xHGsKDZPidwE(PzDrIUIcQGS))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(SCXEISRqBsCFoqP))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(PzDrIUIcQGS);
			rSACryptoServiceProvider.FromXmlString(SCXEISRqBsCFoqP);
			return rSACryptoServiceProvider.Encrypt(SeskIzbtWXah, tlmADmMZgGp);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int EYofNycFUlYfdw(int YyUCjriSQNIpPr)
	{
		if (tlmADmMZgGp)
		{
			return (YyUCjriSQNIpPr - 384) / 8 + 7;
		}
		return (YyUCjriSQNIpPr - 384) / 8 + 37;
	}

	private static bool xHGsKDZPidwE(int FPbupERZHRRtepKOD)
	{
		if (FPbupERZHRRtepKOD >= 384 && FPbupERZHRRtepKOD <= 16384)
		{
			return FPbupERZHRRtepKOD % 8 == 0;
		}
		return false;
	}

	private static void osJgxwyqrKM(string SGSfQkNgTrl, out int tJTCwknkfjcO, out string HdVKBKBeCOrA)
	{
		tJTCwknkfjcO = 0;
		HdVKBKBeCOrA = "";
		if (SGSfQkNgTrl == null || SGSfQkNgTrl.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(SGSfQkNgTrl);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				tJTCwknkfjcO = int.Parse(array[0]);
				HdVKBKBeCOrA = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
