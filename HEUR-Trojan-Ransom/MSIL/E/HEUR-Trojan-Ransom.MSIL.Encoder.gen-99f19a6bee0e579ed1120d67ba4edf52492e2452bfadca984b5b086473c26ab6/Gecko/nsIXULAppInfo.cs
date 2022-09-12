using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1518e7d2-022a-4dae-b02e-bbe7ffcf2145")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXULAppInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVendorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aVendor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAppBuildID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlatformVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPlatformVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPlatformBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPlatformBuildID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUANameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aUAName);
}
