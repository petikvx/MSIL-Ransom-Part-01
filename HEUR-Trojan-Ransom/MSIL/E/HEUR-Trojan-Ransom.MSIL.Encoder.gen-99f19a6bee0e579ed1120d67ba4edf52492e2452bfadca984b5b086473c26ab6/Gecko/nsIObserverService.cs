using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("D07F5192-E3D1-11d2-8ACD-00105A1B8860")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIObserverService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver anObserver, [MarshalAs(UnmanagedType.LPStr)] string aTopic, [MarshalAs(UnmanagedType.U1)] bool ownsWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver anObserver, [MarshalAs(UnmanagedType.LPStr)] string aTopic);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyObservers([MarshalAs(UnmanagedType.Interface)] nsISupports aSubject, [MarshalAs(UnmanagedType.LPStr)] string aTopic, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string someData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator EnumerateObservers([MarshalAs(UnmanagedType.LPStr)] string aTopic);
}
