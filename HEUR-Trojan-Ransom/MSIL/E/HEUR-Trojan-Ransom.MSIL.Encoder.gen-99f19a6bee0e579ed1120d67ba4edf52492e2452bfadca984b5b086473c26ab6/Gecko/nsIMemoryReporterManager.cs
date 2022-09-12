using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("61de6dc7-ed11-4104-a577-79941f22f434")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMemoryReporterManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterStrongReporter([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporter reporter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterStrongAsyncReporter([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporter reporter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterWeakReporter([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporter reporter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterWeakAsyncReporter([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporter reporter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterStrongReporter([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporter reporter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterWeakReporter([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporter reporter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BlockRegistrationAndHideExistingReporters();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnblockRegistrationAndRestoreOriginalReporters();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterStrongReporterEvenIfBlocked([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporter aReporter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetReports([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporterCallback handleReport, [MarshalAs(UnmanagedType.Interface)] nsISupports handleReportData, [MarshalAs(UnmanagedType.Interface)] nsIFinishReportingCallback finishReporting, [MarshalAs(UnmanagedType.Interface)] nsISupports finishReportingData, [MarshalAs(UnmanagedType.U1)] bool anonymize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetReportsExtended([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporterCallback handleReport, [MarshalAs(UnmanagedType.Interface)] nsISupports handleReportData, [MarshalAs(UnmanagedType.Interface)] nsIFinishReportingCallback finishReporting, [MarshalAs(UnmanagedType.Interface)] nsISupports finishReportingData, [MarshalAs(UnmanagedType.U1)] bool anonymize, [MarshalAs(UnmanagedType.U1)] bool minimizeMemoryUsage, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase DMDDumpIdent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetReportsForThisProcessExtended([MarshalAs(UnmanagedType.Interface)] nsIMemoryReporterCallback handleReport, [MarshalAs(UnmanagedType.Interface)] nsISupports handleReportData, [MarshalAs(UnmanagedType.U1)] bool anonymize, IntPtr DMDFile, [MarshalAs(UnmanagedType.Interface)] nsIFinishReportingCallback finishReporting, [MarshalAs(UnmanagedType.Interface)] nsISupports finishReportingData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndReport();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetVsizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetVsizeMaxContiguousAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetResidentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetResidentFastAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetResidentPeakAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetResidentUniqueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetHeapAllocatedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetHeapOverheadRatioAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetJSMainRuntimeGCHeapAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetJSMainRuntimeTemporaryPeakAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetJSMainRuntimeCompartmentsSystemAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetJSMainRuntimeCompartmentsUserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetImagesContentUsedUncompressedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetStorageSQLiteAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLowMemoryEventsVirtualAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLowMemoryEventsPhysicalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetGhostWindowsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetPageFaultsHardAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasMozMallocUsableSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDMDEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDMDRunningAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MinimizeMemoryUsage([MarshalAs(UnmanagedType.Interface)] nsIRunnable callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SizeOfTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, ref long jsObjectsSize, ref long jsStringsSize, ref long jsOtherSize, ref long domSize, ref long styleSize, ref long otherSize, ref long totalSize, ref double jsMilliseconds, ref double nonJSMilliseconds);
}
