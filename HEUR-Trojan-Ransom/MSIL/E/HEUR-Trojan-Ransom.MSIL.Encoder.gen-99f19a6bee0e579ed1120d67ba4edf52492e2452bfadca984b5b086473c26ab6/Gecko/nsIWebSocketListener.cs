using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d74c96b2-65b3-4e39-9e39-c577de5d7a73")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebSocketListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStart([MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStop([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnMessageAvailable([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMsg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnBinaryMessageAvailable([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMsg);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnAcknowledge([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, uint aSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnServerClose([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, ushort aCode, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aReason);
}
