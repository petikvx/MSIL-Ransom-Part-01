using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2eb3195e-3eea-4083-bb1d-d2d70fa35ccb")]
public interface nsIObjectLoadingContent
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetActualTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aActualType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDisplayedTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetContentTypeForMIMEType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMimeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBaseURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPluginInstanceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HasNewFrame(IntPtr aFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPrintFrame();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PluginDestroyed();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PluginCrashed([MarshalAs(UnmanagedType.Interface)] nsIPluginTag pluginTag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase pluginDumpID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase browserDumpID, [MarshalAs(UnmanagedType.U1)] bool submittedCrashReport);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PlayPlugin();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reload([MarshalAs(UnmanagedType.U1)] bool aClearActivation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetActivatedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopPluginInstance();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SyncStartPluginInstance();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncStartPluginInstance();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitializeFromChannel([MarshalAs(UnmanagedType.Interface)] nsIRequest request);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetSrcURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPluginFallbackTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasRunningPluginAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRunIDAttribute();
}
