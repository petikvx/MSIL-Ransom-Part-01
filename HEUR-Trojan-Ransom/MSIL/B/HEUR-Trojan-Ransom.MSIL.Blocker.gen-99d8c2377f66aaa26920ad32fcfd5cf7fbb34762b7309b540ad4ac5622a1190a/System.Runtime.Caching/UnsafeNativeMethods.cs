using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Runtime.Caching;

[SecurityCritical]
[SuppressUnmanagedCodeSecurity]
internal static class UnsafeNativeMethods
{
	private const string KERNEL32 = "KERNEL32.DLL";

	private const string ADVAPI32 = "ADVAPI32.DLL";

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Unicode)]
	internal static extern int GetModuleFileName(IntPtr module, StringBuilder filename, int size);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Unicode)]
	internal static extern int GlobalMemoryStatusEx(ref MEMORYSTATUSEX memoryStatusEx);

	[DllImport("ADVAPI32.DLL")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern int RegCloseKey(IntPtr hKey);
}
