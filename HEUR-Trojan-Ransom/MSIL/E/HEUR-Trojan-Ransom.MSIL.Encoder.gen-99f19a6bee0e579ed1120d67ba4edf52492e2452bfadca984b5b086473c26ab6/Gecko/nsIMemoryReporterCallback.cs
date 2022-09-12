using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("62ef0e1c-dbd6-11e3-aa75-3c970e9f4238")]
public interface nsIMemoryReporterCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Callback([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase process, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase path, int kind, int units, long amount, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase description, [MarshalAs(UnmanagedType.Interface)] nsISupports data);
}
