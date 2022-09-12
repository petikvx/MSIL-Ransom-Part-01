using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("38c7f6af-7df9-49c7-b558-2776b24e6cc1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILoginManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetInitializationPromiseAttribute();

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
	void AutoCompleteSearchAsync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchString, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteResult aPreviousResult, [MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLInputElement aElement, [MarshalAs(UnmanagedType.Interface)] nsIFormAutoCompleteObserver aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SearchLogins(ref uint count, [MarshalAs(UnmanagedType.Interface)] nsIPropertyBag matchData, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsILoginInfo[] logins);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUiBusyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsLoggedInAttribute();
}
