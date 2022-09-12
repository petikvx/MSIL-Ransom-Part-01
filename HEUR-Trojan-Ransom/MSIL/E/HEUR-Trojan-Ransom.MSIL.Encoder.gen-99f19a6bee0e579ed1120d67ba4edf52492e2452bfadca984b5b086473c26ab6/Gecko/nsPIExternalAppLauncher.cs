using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6613e2e7-feab-4e3a-bb1f-b03200d544ec")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsPIExternalAppLauncher
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteTemporaryFileOnExit([MarshalAs(UnmanagedType.Interface)] nsIFile aTemporaryFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteTemporaryPrivateFileWhenPossible([MarshalAs(UnmanagedType.Interface)] nsIFile aTemporaryFile);
}
