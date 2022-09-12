using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("05c420e5-03d0-4c7b-a605-df7ebe5ca326")]
public interface nsICookie2 : nsICookie
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsDomainAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsSecureAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new ulong GetExpiresAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetPolicyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRawHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRawHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSessionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetExpiryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsHttpOnlyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetCreationTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastAccessedAttribute();
}
