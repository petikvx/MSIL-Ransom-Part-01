using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("412880C8-6C36-48d8-BF8F-84F91F892503")]
public interface nsIHttpActivityObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ObserveActivity([MarshalAs(UnmanagedType.Interface)] nsISupports aHttpChannel, uint aActivityType, uint aActivitySubtype, long aTimestamp, ulong aExtraSizeData, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aExtraStringData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsActiveAttribute();
}
