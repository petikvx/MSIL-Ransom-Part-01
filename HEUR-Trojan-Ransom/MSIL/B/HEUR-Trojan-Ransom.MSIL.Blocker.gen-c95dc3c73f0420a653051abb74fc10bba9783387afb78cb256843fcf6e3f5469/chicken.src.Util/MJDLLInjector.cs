using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace chicken.src.Util;

public class MJDLLInjector
{
	[CompilerGenerated]
	private string nmkOSMnchTcxZJeUhGzamLZueMYaA;

	[CompilerGenerated]
	private int HwALclJnmKEhvJkyEQoZKjdhqbRWA;

	[CompilerGenerated]
	private string GBvQjAwRNSppywGLGKXavNvsCYxN;

	[CompilerGenerated]
	private int uNTDEZiDckTmolevCOespDZaqfAHA;

	public string _dll
	{
		[CompilerGenerated]
		get
		{
			return GBvQjAwRNSppywGLGKXavNvsCYxN;
		}
		[CompilerGenerated]
		set
		{
			GBvQjAwRNSppywGLGKXavNvsCYxN = value;
		}
	}

	public int _pid
	{
		[CompilerGenerated]
		get
		{
			return uNTDEZiDckTmolevCOespDZaqfAHA;
		}
		[CompilerGenerated]
		set
		{
			uNTDEZiDckTmolevCOespDZaqfAHA = value;
		}
	}

	public MJDLLInjector()
	{
		_dll = null;
		_pid = 0;
	}

	public unsafe bool method_0()
	{
		if (string.IsNullOrEmpty(_dll))
		{
			return false;
		}
		if (_pid == 0)
		{
			return false;
		}
		IntPtr intPtr = MJWin32Api.OpenProcess((int)MJWin32Api.MAXIMUM_ALLOWED, bInheritHandle: false, _pid);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		IntPtr procAddress = MJWin32Api.GetProcAddress(MJWin32Api.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
		if (!(procAddress == (IntPtr)0))
		{
			byte[] bytes = Encoding.GetEncoding(949).GetBytes(_dll);
			IntPtr intPtr2 = MJWin32Api.VirtualAllocEx(intPtr, (IntPtr)(void*)null, (IntPtr)bytes.Length + 1, 4096u, 64u);
			if (intPtr2 == (IntPtr)0)
			{
				return false;
			}
			if (MJWin32Api.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)(bytes.Length + 1), 0) == 0)
			{
				return false;
			}
			IntPtr intPtr3 = MJWin32Api.CreateRemoteThread(intPtr, (IntPtr)0, (IntPtr)(void*)null, procAddress, intPtr2, 0u, (IntPtr)0);
			if (!(intPtr3 == (IntPtr)0))
			{
				MJWin32Api.WaitForSingleObject(intPtr3, uint.MaxValue);
				MJWin32Api.CloseHandle(intPtr3);
				MJWin32Api.CloseHandle(intPtr);
				return true;
			}
			return false;
		}
		return false;
	}
}
