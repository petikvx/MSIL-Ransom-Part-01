using System;
using System.Runtime.InteropServices;

namespace NAudio.MediaFoundation;

[ComImport]
[Guid("E7FE2E12-661C-40DA-92F9-4F002AB67627")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFReadWriteClassFactory
{
	void CreateInstanceFromURL([In][MarshalAs(UnmanagedType.LPStruct)] Guid clsid, [In][MarshalAs(UnmanagedType.LPWStr)] string pwszURL, [In][MarshalAs(UnmanagedType.Interface)] IMFAttributes pAttributes, [In][MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObject);

	void CreateInstanceFromObject([In][MarshalAs(UnmanagedType.LPStruct)] Guid clsid, [In][MarshalAs(UnmanagedType.IUnknown)] object punkObject, [In][MarshalAs(UnmanagedType.Interface)] IMFAttributes pAttributes, [In][MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObject);
}
