using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("703b53b6-24f6-40c6-9ea9-aeb2dc53d170")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICycleCollectorListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICycleCollectorListener AllTraces();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWantAllTracesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDisableLogAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisableLogAttribute([MarshalAs(UnmanagedType.U1)] bool aDisableLog);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICycleCollectorLogSink GetLogSinkAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLogSinkAttribute([MarshalAs(UnmanagedType.Interface)] nsICycleCollectorLogSink aLogSink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWantAfterProcessingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWantAfterProcessingAttribute([MarshalAs(UnmanagedType.U1)] bool aWantAfterProcessing);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ProcessNext([MarshalAs(UnmanagedType.Interface)] nsICycleCollectorHandler aHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr AsLogger();
}
