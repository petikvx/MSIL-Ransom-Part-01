using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3ad9875f-d0e4-4ac2-87e3-f127f6c02ce1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICycleCollectorLogSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Open(ref IntPtr aGCLog, ref IntPtr aCCLog);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseGCLog();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseCCLog();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFilenameIdentifierAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFilenameIdentifier);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFilenameIdentifierAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFilenameIdentifier);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetProcessIdentifierAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProcessIdentifierAttribute(int aProcessIdentifier);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetGcLogAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetCcLogAttribute();
}
