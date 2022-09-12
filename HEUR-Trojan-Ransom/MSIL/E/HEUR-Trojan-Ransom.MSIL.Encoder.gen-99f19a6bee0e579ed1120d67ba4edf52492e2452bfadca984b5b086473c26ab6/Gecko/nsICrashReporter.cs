using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4b74c39a-cf69-4a8a-8e63-169d81ad1ecf")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICrashReporter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnabled([MarshalAs(UnmanagedType.U1)] bool enabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURL GetServerURLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetServerURLAttribute([MarshalAs(UnmanagedType.Interface)] nsIURL aServerURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetMinidumpPathAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMinidumpPathAttribute([MarshalAs(UnmanagedType.Interface)] nsIFile aMinidumpPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AnnotateCrashReport([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendAppNotesToCrashReport([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterAppMemory(ulong ptr, ulong size);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteMinidumpForException(IntPtr aExceptionInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendObjCExceptionInfoToAppNotes(IntPtr aException);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSubmitReportsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSubmitReportsAttribute([MarshalAs(UnmanagedType.U1)] bool aSubmitReports);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateCrashEventsDir();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SaveMemoryReport();
}
