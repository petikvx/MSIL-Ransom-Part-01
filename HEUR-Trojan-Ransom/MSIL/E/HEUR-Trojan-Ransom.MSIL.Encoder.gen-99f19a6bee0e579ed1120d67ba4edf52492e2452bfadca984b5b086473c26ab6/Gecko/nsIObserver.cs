using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("DB242E01-E4D9-11d2-9DDE-000064657374")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Observe([MarshalAs(UnmanagedType.Interface)] nsISupports aSubject, [MarshalAs(UnmanagedType.LPStr)] string aTopic, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aData);
}
