using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace chicken.src.Util;

public sealed class Injector
{
	private static readonly IntPtr cPISPEQjNuGMmIRfpQsfRmoktxseA = (IntPtr)0;

	private static Injector gyRAuAvZjXbnXzvoFDlwnIFNJFGl;

	public static Injector GetInstance
	{
		get
		{
			Injector result = default(Injector);
			while (true)
			{
				int num = 917421532;
				while (true)
				{
					Injector obj;
					switch ((uint)(num ^ 0x45C736DE) % 3u)
					{
					case 1u:
						obj = gyRAuAvZjXbnXzvoFDlwnIFNJFGl ?? (gyRAuAvZjXbnXzvoFDlwnIFNJFGl = new Injector());
						goto IL_0017;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0017:
					result = obj;
					num = 1106798056;
				}
			}
		}
	}

	private Injector()
	{
	}

	public InjectionResult Inject(string sProcName, string sDllPath)
	{
		if (!File.Exists(sDllPath))
		{
			return InjectionResult.DllNotFound;
		}
		uint num = 0u;
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			if (processes[i].ProcessName == sProcName)
			{
				num = (uint)processes[i].Id;
				break;
			}
		}
		if (num != 0)
		{
			if (!BInject(num, sDllPath))
			{
				return InjectionResult.InjectionFailed;
			}
			return InjectionResult.Success;
		}
		return InjectionResult.GameProcessNotFound;
	}

	public unsafe bool BInject(uint pToBeInjected, string sDllPath)
	{
		IntPtr intPtr = Win32Api.OpenProcess(1082u, 1, pToBeInjected);
		if (intPtr == cPISPEQjNuGMmIRfpQsfRmoktxseA)
		{
			return false;
		}
		IntPtr procAddress = Win32Api.GetProcAddress(Win32Api.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
		if (procAddress == cPISPEQjNuGMmIRfpQsfRmoktxseA)
		{
			return false;
		}
		IntPtr intPtr2 = Win32Api.VirtualAllocEx(intPtr, (IntPtr)(void*)null, (IntPtr)sDllPath.Length, 12288u, 64u);
		if (!(intPtr2 == cPISPEQjNuGMmIRfpQsfRmoktxseA))
		{
			byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
			if (Win32Api.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) == 0)
			{
				return false;
			}
			if (!(Win32Api.CreateRemoteThread(intPtr, (IntPtr)(void*)null, cPISPEQjNuGMmIRfpQsfRmoktxseA, procAddress, intPtr2, 0u, (IntPtr)(void*)null) == cPISPEQjNuGMmIRfpQsfRmoktxseA))
			{
				Win32Api.CloseHandle(intPtr);
				return true;
			}
			return false;
		}
		return false;
	}
}
