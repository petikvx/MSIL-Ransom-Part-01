using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("325e56a7-3762-4312-aec7-f1fcf84b4145")]
public interface nsIHandlerInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIHandlerApp GetPreferredApplicationHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPreferredApplicationHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsIHandlerApp aPreferredApplicationHandler);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMutableArray GetPossibleApplicationHandlersAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasDefaultHandlerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LaunchWithURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPreferredActionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPreferredActionAttribute(IntPtr aPreferredAction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAlwaysAskBeforeHandlingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAlwaysAskBeforeHandlingAttribute([MarshalAs(UnmanagedType.U1)] bool aAlwaysAskBeforeHandling);
}
