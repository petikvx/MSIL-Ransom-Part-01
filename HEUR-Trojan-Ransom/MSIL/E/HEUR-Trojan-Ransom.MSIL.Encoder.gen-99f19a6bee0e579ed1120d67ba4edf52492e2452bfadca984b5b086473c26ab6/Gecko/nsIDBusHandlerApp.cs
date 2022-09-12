using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1ffc274b-4cbf-4bb5-a635-05ad2cbb6534")]
public interface nsIDBusHandlerApp : nsIHandlerApp
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
	void GetServiceAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aService);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetServiceAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aService);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetObjectPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aObjectPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetObjectPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aObjectPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDBusInterfaceAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDBusInterface);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDBusInterfaceAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDBusInterface);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMethod);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMethod);
}
