using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1c21acef-c7a1-40c6-9d40-a20480ee53a1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMIMEInfo : nsIHandlerInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIHandlerApp GetPreferredApplicationHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPreferredApplicationHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsIHandlerApp aPreferredApplicationHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIMutableArray GetPossibleApplicationHandlersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetHasDefaultHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetDefaultDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void LaunchWithURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetPreferredActionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPreferredActionAttribute(IntPtr aPreferredAction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetAlwaysAskBeforeHandlingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetAlwaysAskBeforeHandlingAttribute([MarshalAs(UnmanagedType.U1)] bool aAlwaysAskBeforeHandling);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUTF8StringEnumerator GetFileExtensions();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFileExtensions([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aExtensions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ExtensionExists([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendExtension([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPrimaryExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPrimaryExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrimaryExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPrimaryExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMIMETypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMIMEType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsIMIMEInfo aMIMEInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetPossibleLocalHandlersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LaunchWithFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
}
