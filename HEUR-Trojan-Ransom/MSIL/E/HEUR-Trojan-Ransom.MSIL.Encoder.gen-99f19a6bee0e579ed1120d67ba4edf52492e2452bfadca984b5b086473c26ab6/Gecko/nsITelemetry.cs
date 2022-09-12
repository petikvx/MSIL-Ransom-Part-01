using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("273d2dd0-6c63-475a-b864-cb65160a1909")]
public interface nsITelemetry
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetHistogramSnapshotsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal SnapshotSubsessionHistograms([MarshalAs(UnmanagedType.U1)] bool clear, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLastShutdownDurationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFailedProfileLockCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetSlowSQLAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetDebugSlowSQLAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetWebrtcStatsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMaximalNumberOfConcurrentThreadsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetChromeHangsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetThreadHangStatsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetLateWritesAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisteredHistograms(uint dataset, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref string[] histograms);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal NewHistogram([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase expiration, uint histogram_type, uint min, uint max, uint bucket_count, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal HistogramFrom([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase existing_name, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetHistogramById([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase id, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetKeyedHistogramSnapshotsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal NewKeyedHistogram([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase expiration, uint histogram_type, uint min, uint max, uint bucket_count, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisteredKeyedHistograms(uint dataset, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref string[] histograms);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetKeyedHistogramById([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase id, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanRecordBaseAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCanRecordBaseAttribute([MarshalAs(UnmanagedType.U1)] bool aCanRecordBase);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanRecordExtendedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCanRecordExtendedAttribute([MarshalAs(UnmanagedType.U1)] bool aCanRecordExtended);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsOfficialTelemetryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterAddonHistogram([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase addon_id, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase name, uint histogram_type, uint min, uint max, uint bucket_count, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetAddonHistogram([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase addon_id, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase name, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterAddonHistograms([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase addon_id);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHistogramRecordingEnabled([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase id, [MarshalAs(UnmanagedType.U1)] bool enabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetAddonHistogramSnapshotsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncFetchTelemetryData([MarshalAs(UnmanagedType.Interface)] nsIFetchTelemetryDataCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetFileIOReportsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double MsSinceProcessStart();
}
