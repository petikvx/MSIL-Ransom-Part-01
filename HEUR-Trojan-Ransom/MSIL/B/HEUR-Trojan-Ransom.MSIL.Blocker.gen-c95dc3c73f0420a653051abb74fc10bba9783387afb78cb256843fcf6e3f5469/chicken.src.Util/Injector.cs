using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace chicken.src.Util;

public sealed class Injector
{
	private static readonly IntPtr zbEpwfaRCJoAucGQctISIyrxOKjk = (IntPtr)0;

	private static Injector bIPJejBqfebDVStNQiABBoEKViBw;

	public static Injector GetInstance => bIPJejBqfebDVStNQiABBoEKViBw ?? (bIPJejBqfebDVStNQiABBoEKViBw = new Injector());

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
			if (BInject(num, sDllPath))
			{
				return InjectionResult.Success;
			}
			return InjectionResult.InjectionFailed;
		}
		return InjectionResult.GameProcessNotFound;
	}

	public unsafe bool BInject(uint pToBeInjected, string sDllPath)
	{
		IntPtr intPtr = Win32Api.OpenProcess(1082u, 1, pToBeInjected);
		if (intPtr == zbEpwfaRCJoAucGQctISIyrxOKjk)
		{
			return false;
		}
		IntPtr procAddress = Win32Api.GetProcAddress(Win32Api.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
		if (procAddress == zbEpwfaRCJoAucGQctISIyrxOKjk)
		{
			return false;
		}
		IntPtr intPtr2 = Win32Api.VirtualAllocEx(intPtr, (IntPtr)(void*)null, (IntPtr)sDllPath.Length, 12288u, 64u);
		if (intPtr2 == zbEpwfaRCJoAucGQctISIyrxOKjk)
		{
			return false;
		}
		byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
		if (Win32Api.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) == 0)
		{
			return false;
		}
		if (Win32Api.CreateRemoteThread(intPtr, (IntPtr)(void*)null, zbEpwfaRCJoAucGQctISIyrxOKjk, procAddress, intPtr2, 0u, (IntPtr)(void*)null) == zbEpwfaRCJoAucGQctISIyrxOKjk)
		{
			return false;
		}
		Win32Api.CloseHandle(intPtr);
		return true;
	}
}
