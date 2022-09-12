using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7C512CB8-582A-4625-B5B6-8639755271B5")]
public interface nsIHttpActivityDistributor : nsIHttpActivityObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ObserveActivity([MarshalAs(UnmanagedType.Interface)] nsISupports aHttpChannel, uint aActivityType, uint aActivitySubtype, long aTimestamp, ulong aExtraSizeData, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aExtraStringData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIHttpActivityObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIHttpActivityObserver aObserver);
}
