using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ead3f75c-0e0e-4fbb-901c-1e5392ef5b2a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProfiler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanProfile();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartProfiler(uint aEntries, double aInterval, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] string[] aFeatures, uint aFeatureCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] string[] aThreadNameFilters, uint aFilterCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopProfiler();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsPaused();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PauseSampling();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResumeSampling();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddMarker([MarshalAs(UnmanagedType.LPStr)] string aMarker);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetProfile(double aSinceTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetProfileData(double aSinceTime, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetProfileDataAsync(double aSinceTime, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsActive();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFeatures(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref string[] aFeatures);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProfilerStartParams GetStartParamsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetProfileGathererAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBufferInfo(ref uint aCurrentPosition, ref uint aTotalSize, ref uint aGeneration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetElapsedTime();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSharedLibraryInformation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpProfileToFile([MarshalAs(UnmanagedType.LPStr)] string aFilename);
}
