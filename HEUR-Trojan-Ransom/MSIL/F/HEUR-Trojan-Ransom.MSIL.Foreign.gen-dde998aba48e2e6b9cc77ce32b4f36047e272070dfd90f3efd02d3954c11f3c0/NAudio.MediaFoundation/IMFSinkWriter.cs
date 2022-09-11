using System;
using System.Runtime.InteropServices;

namespace NAudio.MediaFoundation;

[ComImport]
[Guid("3137f1cd-fe5e-4805-a5d8-fb477448cb3d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFSinkWriter
{
	void AddStream([In][MarshalAs(UnmanagedType.Interface)] IMFMediaType pTargetMediaType, out int pdwStreamIndex);

	void SetInputMediaType([In] int dwStreamIndex, [In][MarshalAs(UnmanagedType.Interface)] IMFMediaType pInputMediaType, [In][MarshalAs(UnmanagedType.Interface)] IMFAttributes pEncodingParameters);

	void BeginWriting();

	void WriteSample([In] int dwStreamIndex, [In][MarshalAs(UnmanagedType.Interface)] IMFSample pSample);

	void SendStreamTick([In] int dwStreamIndex, [In] long llTimestamp);

	void PlaceMarker([In] int dwStreamIndex, [In] IntPtr pvContext);

	void NotifyEndOfSegment([In] int dwStreamIndex);

	void Flush([In] int dwStreamIndex);

	void DoFinalize();

	void GetServiceForStream([In] int dwStreamIndex, [In] ref Guid guidService, [In] ref Guid riid, out IntPtr ppvObject);

	void GetStatistics([In] int dwStreamIndex, [In][Out] MF_SINK_WRITER_STATISTICS pStats);
}
