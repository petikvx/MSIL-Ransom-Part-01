using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("20d31479-38de-49f4-9300-566d6e834c66")]
public interface nsIBrowserHistory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePage([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePages([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsIURI[] aURIs, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePagesFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, [MarshalAs(UnmanagedType.U1)] bool aEntireDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePagesByTimeframe(long aBeginTime, long aEndTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveVisitsByTimeframe(long aBeginTime, long aEndTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAllPages();
}
