using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5df81a93-25e6-4b45-a696-089479e15c7d")]
public interface nsILoginManagerStorage
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal Initialize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal Terminate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddLogin([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLogin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveLogin([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLogin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ModifyLogin([MarshalAs(UnmanagedType.Interface)] nsILoginInfo oldLogin, [MarshalAs(UnmanagedType.Interface)] nsISupports newLoginData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAllLogins();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAllLogins(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsILoginInfo[] logins);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SearchLogins(ref uint count, [MarshalAs(UnmanagedType.Interface)] nsIPropertyBag matchData, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsILoginInfo[] logins);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAllDisabledHosts(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] hostnames);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLoginSavingEnabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLoginSavingEnabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHost, [MarshalAs(UnmanagedType.U1)] bool isEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FindLogins(ref uint count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aActionURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpRealm, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsILoginInfo[] logins);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint CountLogins([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aActionURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpRealm);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUiBusyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsLoggedInAttribute();
}
