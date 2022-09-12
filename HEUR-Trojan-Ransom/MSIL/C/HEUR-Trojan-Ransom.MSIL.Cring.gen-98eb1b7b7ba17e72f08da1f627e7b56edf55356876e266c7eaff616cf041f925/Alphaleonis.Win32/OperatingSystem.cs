using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

namespace Alphaleonis.Win32;

public static class OperatingSystem
{
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Os")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Os")]
	public enum EnumOsName
	{
		Earlier = -1,
		Windows2000 = 0,
		WindowsXP = 1,
		WindowsServer2003 = 2,
		WindowsVista = 3,
		WindowsServer2008 = 4,
		Windows7 = 5,
		WindowsServer2008R2 = 6,
		Windows8 = 7,
		WindowsServer2012 = 8,
		Windows81 = 9,
		WindowsServer2012R2 = 10,
		Windows10 = 11,
		WindowsServer2016 = 12,
		Later = 65535
	}

	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Pa")]
	[SuppressMessage("Microsoft.Design", "CA1028:EnumStorageShouldBeInt32")]
	public enum EnumProcessorArchitecture
	{
		X86 = 0,
		[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ia")]
		[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ia")]
		IA64 = 6,
		X64 = 9,
		Unknown = 65535
	}

	private static class NativeMethods
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct RTL_OSVERSIONINFOEXW
		{
			public int dwOSVersionInfoSize;

			public readonly int dwMajorVersion;

			public readonly int dwMinorVersion;

			public readonly int dwBuildNumber;

			public readonly int dwPlatformId;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public readonly string szCSDVersion;

			public readonly ushort wServicePackMajor;

			public readonly ushort wServicePackMinor;

			public readonly ushort wSuiteMask;

			public readonly byte wProductType;

			public readonly byte wReserved;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct SYSTEM_INFO
		{
			public readonly EnumProcessorArchitecture wProcessorArchitecture;

			private readonly ushort wReserved;

			public readonly uint dwPageSize;

			public readonly IntPtr lpMinimumApplicationAddress;

			public readonly IntPtr lpMaximumApplicationAddress;

			public readonly IntPtr dwActiveProcessorMask;

			public readonly uint dwNumberOfProcessors;

			public readonly uint dwProcessorType;

			public readonly uint dwAllocationGranularity;

			public readonly ushort wProcessorLevel;

			public readonly ushort wProcessorRevision;
		}

		internal const short VER_NT_WORKSTATION = 1;

		internal const short VER_NT_DOMAIN_CONTROLLER = 2;

		internal const short VER_NT_SERVER = 3;

		[DllImport("ntdll.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool RtlGetVersion([MarshalAs(UnmanagedType.Struct)] ref RTL_OSVERSIONINFOEXW lpVersionInformation);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
		[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
		[SuppressUnmanagedCodeSecurity]
		internal static extern void GetNativeSystemInfo([MarshalAs(UnmanagedType.Struct)] ref SYSTEM_INFO lpSystemInfo);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		[SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
		[SuppressUnmanagedCodeSecurity]
		[SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool IsWow64Process([In] IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] out bool lpSystemInfo);
	}

	private static bool _isServer;

	private static bool? _isWow64Process;

	private static Version _osVersion;

	private static EnumOsName _enumOsName = EnumOsName.Later;

	private static EnumProcessorArchitecture _processorArchitecture;

	private static Version _servicePackVersion;

	public static bool IsServer
	{
		get
		{
			if (null == _servicePackVersion)
			{
				UpdateData();
			}
			return _isServer;
		}
	}

	public static bool IsWow64Process
	{
		get
		{
			if (!_isWow64Process.HasValue)
			{
				if (!NativeMethods.IsWow64Process(Process.GetCurrentProcess().Handle, out var lpSystemInfo))
				{
					Marshal.ThrowExceptionForHR(Marshal.GetLastWin32Error());
				}
				_isWow64Process = lpSystemInfo;
			}
			return _isWow64Process.Value;
		}
	}

	public static Version OSVersion
	{
		get
		{
			if (null == _osVersion)
			{
				UpdateData();
			}
			return _osVersion;
		}
	}

	public static EnumOsName VersionName
	{
		get
		{
			if (null == _servicePackVersion)
			{
				UpdateData();
			}
			return _enumOsName;
		}
	}

	public static EnumProcessorArchitecture ProcessorArchitecture
	{
		get
		{
			if (null == _servicePackVersion)
			{
				UpdateData();
			}
			return _processorArchitecture;
		}
	}

	public static Version ServicePackVersion
	{
		get
		{
			if (null == _servicePackVersion)
			{
				UpdateData();
			}
			return _servicePackVersion;
		}
	}

	public static bool IsAtLeast(EnumOsName version)
	{
		return VersionName >= version;
	}

	public static bool IsAtLeast(EnumOsName version, int servicePackVersion)
	{
		if (IsAtLeast(version))
		{
			return ServicePackVersion.Major >= servicePackVersion;
		}
		return false;
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "RtlGetVersion")]
	private static void UpdateData()
	{
		NativeMethods.RTL_OSVERSIONINFOEXW lpVersionInformation = default(NativeMethods.RTL_OSVERSIONINFOEXW);
		lpVersionInformation.dwOSVersionInfoSize = Marshal.SizeOf((object)lpVersionInformation);
		NativeMethods.SYSTEM_INFO lpSystemInfo = default(NativeMethods.SYSTEM_INFO);
		NativeMethods.GetNativeSystemInfo(ref lpSystemInfo);
		bool num = !NativeMethods.RtlGetVersion(ref lpVersionInformation);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			throw new Win32Exception(lastWin32Error, "Function RtlGetVersion() failed to retrieve the operating system information.");
		}
		_osVersion = new Version(lpVersionInformation.dwMajorVersion, lpVersionInformation.dwMinorVersion, lpVersionInformation.dwBuildNumber);
		_processorArchitecture = lpSystemInfo.wProcessorArchitecture;
		_servicePackVersion = new Version(lpVersionInformation.wServicePackMajor, lpVersionInformation.wServicePackMinor);
		_isServer = lpVersionInformation.wProductType == 2 || lpVersionInformation.wProductType == 3;
		if (lpVersionInformation.dwMajorVersion > 10)
		{
			_enumOsName = EnumOsName.Later;
			return;
		}
		switch (lpVersionInformation.dwMajorVersion)
		{
		case 10:
			_enumOsName = ((lpVersionInformation.wProductType == 1) ? EnumOsName.Windows10 : EnumOsName.WindowsServer2016);
			break;
		default:
			_enumOsName = EnumOsName.Earlier;
			break;
		case 6:
			switch (lpVersionInformation.dwMinorVersion)
			{
			default:
				_enumOsName = EnumOsName.Later;
				break;
			case 0:
				_enumOsName = ((lpVersionInformation.wProductType == 1) ? EnumOsName.WindowsVista : EnumOsName.WindowsServer2008);
				break;
			case 1:
				_enumOsName = ((lpVersionInformation.wProductType == 1) ? EnumOsName.Windows7 : EnumOsName.WindowsServer2008R2);
				break;
			case 2:
				_enumOsName = ((lpVersionInformation.wProductType == 1) ? EnumOsName.Windows8 : EnumOsName.WindowsServer2012);
				break;
			case 3:
				_enumOsName = ((lpVersionInformation.wProductType == 1) ? EnumOsName.Windows81 : EnumOsName.WindowsServer2012R2);
				break;
			}
			break;
		case 5:
			switch (lpVersionInformation.dwMinorVersion)
			{
			default:
				_enumOsName = EnumOsName.Later;
				break;
			case 0:
				_enumOsName = EnumOsName.Windows2000;
				break;
			case 1:
				_enumOsName = EnumOsName.WindowsXP;
				break;
			case 2:
				_enumOsName = ((lpVersionInformation.wProductType == 1 && _processorArchitecture == EnumProcessorArchitecture.X64) ? EnumOsName.WindowsXP : ((lpVersionInformation.wProductType != 1) ? EnumOsName.WindowsServer2003 : EnumOsName.Later));
				break;
			}
			break;
		}
	}
}
