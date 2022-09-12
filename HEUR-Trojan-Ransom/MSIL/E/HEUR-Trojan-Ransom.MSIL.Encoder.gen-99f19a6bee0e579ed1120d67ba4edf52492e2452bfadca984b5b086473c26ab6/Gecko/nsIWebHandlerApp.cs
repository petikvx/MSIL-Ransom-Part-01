using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7521a093-c498-45ce-b462-df7ba0d882f6")]
public interface nsIWebHandlerApp : nsIHandlerApp
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetDetailedDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDetailedDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDetailedDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDetailedDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIHandlerApp aHandlerApp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void LaunchWithURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUriTemplateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUriTemplate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUriTemplateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUriTemplate);
}
