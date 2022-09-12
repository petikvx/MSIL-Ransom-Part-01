using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("D36B6329-52AE-4f45-80F4-B2536AE5F8B2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILocalHandlerApp : nsIHandlerApp
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
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetExecutableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExecutableAttribute([MarshalAs(UnmanagedType.Interface)] nsIFile aExecutable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetParameterCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearParameters();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendParameter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase param);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetParameter(uint parameterIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ParameterExists([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase param);
}
