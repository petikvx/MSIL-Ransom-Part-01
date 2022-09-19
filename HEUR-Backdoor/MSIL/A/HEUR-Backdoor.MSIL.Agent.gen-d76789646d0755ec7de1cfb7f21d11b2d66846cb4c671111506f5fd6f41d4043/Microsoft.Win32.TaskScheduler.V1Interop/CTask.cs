using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

[ComImport]
[Guid("148BD520-A2AB-11CE-B11F-00AA00530503")]
[SuppressUnmanagedCodeSecurity]
internal class CTask
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern CTask();
}
