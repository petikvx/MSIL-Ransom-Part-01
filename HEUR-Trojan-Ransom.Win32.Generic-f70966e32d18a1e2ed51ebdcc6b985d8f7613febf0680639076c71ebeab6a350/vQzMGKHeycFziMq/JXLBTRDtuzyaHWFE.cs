using System;
using System.Security.Cryptography;
using System.Text;

namespace vQzMGKHeycFziMq;

public static class JXLBTRDtuzyaHWFE
{
	private static bool mCbtvftTQSuLET = false;

	private static readonly string hFjCXpelSSJK = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+ckJndXhqdkR1Qm5XWllZVFZBMngxMEVSdVVwNWJidzFZdzhNRjMyM0xoVVNXNmlYNytXOUVqSnFrU3A5akJIYXByeGF6amJPOVZnc1VzYW5Ec2tHZTFyZzRURndBemcxcTRYekFLekxEdlVJb1hUcHlqbUg0b0tBV0wrNEhvSTRwNGlFTjcxQlN2RzMyNFpEbm1IWFFpaEJqeld0SUQrRVdTREZYYzZGb1NyUXVEenNQRVJKZ3BTQkZrWTlCQy9yRmpMVCtiN0tCUVJpVkhUWTVtT2crVjk4SzQybkN2S25LVFAvbE5kcHdQMkpFL3IvcDA1dmlFalJiRjNhUWR0T2NDamFuNVN4WGNyM2JJcDZMQ1FiMlFxYVRlbDhZbHF1bmRnd0hWaEM0d2l1L1ZLRWoxR3pGNktsRVJHSXlXK1ZxVzZMSmZLV045M29od2c2eHZWdnVLYkpvS1NqUllQc2JBSnNJcCswcSt3dElPL2RCMFJrUlFHMHdjOEZkYjdaMm1pUUpTUWpZTFAwdEVlR3lpQ1JHTDBIalRiamVUNTMrckZYUGZBRk9rVFU2L3U1UkZqOTZWckdFNmdUMHZGYTEwbHhxbS9scWhEZEEwc1B2N3BaODJEZVRFVGZFUzdyb2s1Y1lNUUpYaGVaOTBmTWlhZnhyRXZZZWJidDRPV2ZpUk1QWU4yZEtmNUJicW8yOWpnTGd2cVRUZTVjZ1k0ellZZDRIRThTa1plalR0dVV0WXVwVWpYSmo5YmFDR3RWQ0UyNExqNjBVOVZWN0t5aDEyMVpBNUpvRzBUM09NUVhWNEN0QkxnTHdsakI5Z2VKdUEvNDFPVDBiS1JGM04rY0o4Tk4xOTU5Y29RbEExVFhIRXh1MTk2RzNCeTVqU0t3UFZQZkJXRTRGc3M9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

	public static string hHOovCgFovscyM(string cutAEhioPfIK)
	{
		int QhKkpkVErnZSRKk = 0;
		string iiyvElvVVtJKdO = "";
		IbgYhbOMWuQSZfi(hFjCXpelSSJK, out QhKkpkVErnZSRKk, out iiyvElvVVtJKdO);
		byte[] inArray = ogwwOQLoNRv(Encoding.UTF8.GetBytes(cutAEhioPfIK), QhKkpkVErnZSRKk, iiyvElvVVtJKdO);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] ogwwOQLoNRv(byte[] dcDxXTFnznOmj, int PgdSiwraHfIy, string NhaFBLeLzXMaeR)
	{
		if (dcDxXTFnznOmj != null && dcDxXTFnznOmj.Length != 0)
		{
			int num = rLrbbwUEMClo(PgdSiwraHfIy);
			if (dcDxXTFnznOmj.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!IjwdSTbRakFMllE(PgdSiwraHfIy))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(NhaFBLeLzXMaeR))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(PgdSiwraHfIy);
			rSACryptoServiceProvider.FromXmlString(NhaFBLeLzXMaeR);
			return rSACryptoServiceProvider.Encrypt(dcDxXTFnznOmj, mCbtvftTQSuLET);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int rLrbbwUEMClo(int CcWqNWErYzrju)
	{
		if (mCbtvftTQSuLET)
		{
			return (CcWqNWErYzrju - 384) / 8 + 7;
		}
		return (CcWqNWErYzrju - 384) / 8 + 37;
	}

	private static bool IjwdSTbRakFMllE(int SErtzKlMKSYU)
	{
		if (SErtzKlMKSYU >= 384 && SErtzKlMKSYU <= 16384)
		{
			return SErtzKlMKSYU % 8 == 0;
		}
		return false;
	}

	private static void IbgYhbOMWuQSZfi(string LRtgLZoqqM, out int QhKkpkVErnZSRKk, out string iiyvElvVVtJKdO)
	{
		QhKkpkVErnZSRKk = 0;
		iiyvElvVVtJKdO = "";
		if (LRtgLZoqqM == null || LRtgLZoqqM.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(LRtgLZoqqM);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				QhKkpkVErnZSRKk = int.Parse(array[0]);
				iiyvElvVVtJKdO = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
