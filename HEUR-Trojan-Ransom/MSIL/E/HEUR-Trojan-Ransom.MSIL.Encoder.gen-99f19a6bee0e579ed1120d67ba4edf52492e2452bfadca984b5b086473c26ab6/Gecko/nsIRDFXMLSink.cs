using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("EB1A5D31-AB33-11D2-8EC6-00805F29F370")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFXMLSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReadOnlyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReadOnlyAttribute([MarshalAs(UnmanagedType.U1)] bool aReadOnly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginLoad();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Interrupt();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Resume();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndLoad();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddNameSpace(IntPtr aPrefix, IntPtr aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddXMLSinkObserver([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSinkObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveXMLSinkObserver([MarshalAs(UnmanagedType.Interface)] nsIRDFXMLSinkObserver aObserver);
}
