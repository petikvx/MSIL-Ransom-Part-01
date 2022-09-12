using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8684966b-1877-4f0f-8155-be4490b96bf7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICookie
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDomainAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSecureAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetExpiresAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPolicyAttribute();
}
