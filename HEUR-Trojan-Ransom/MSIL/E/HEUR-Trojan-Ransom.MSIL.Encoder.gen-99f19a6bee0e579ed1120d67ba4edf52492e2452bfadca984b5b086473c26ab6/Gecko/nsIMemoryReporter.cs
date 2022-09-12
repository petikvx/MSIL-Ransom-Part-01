using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("92a36db1-46bd-4fe6-988e-47db47236d8b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMemoryReporter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void CollectReports([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporterCallback callback, [MarshalAs(UnmanagedType.Interface)] nsISupports data, [MarshalAs(UnmanagedType.U1)] bool anonymize);
}
