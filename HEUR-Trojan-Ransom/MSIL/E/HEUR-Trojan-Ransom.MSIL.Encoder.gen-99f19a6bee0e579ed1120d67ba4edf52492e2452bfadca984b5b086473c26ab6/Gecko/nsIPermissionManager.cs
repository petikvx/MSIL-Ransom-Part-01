using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a15cd7ef-f7a0-43d2-be86-8bf488dc760b")]
public interface nsIPermissionManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Add([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type, uint permission, uint expireType, long expireTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddFromPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string typed, uint permission, uint expireType, long expireTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Remove([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFromPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePermission([MarshalAs(UnmanagedType.Interface)] nsIPermission perm);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAllSince(long since);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint TestPermission([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint TestPermissionFromPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint TestPermissionFromWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint TestExactPermission([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint TestExactPermissionFromPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint TestExactPermanentPermission([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPermission GetPermissionObject([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type, [MarshalAs(UnmanagedType.U1)] bool exactHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddrefAppId(uint appId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReleaseAppId(uint appId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetEnumeratorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePermissionsWithAttributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase patternAsJSON);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateExpireTime([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStr)] string type, [MarshalAs(UnmanagedType.U1)] bool exactHost, ulong sessionExpireTime, ulong persistentExpireTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RefreshPermission();
}
