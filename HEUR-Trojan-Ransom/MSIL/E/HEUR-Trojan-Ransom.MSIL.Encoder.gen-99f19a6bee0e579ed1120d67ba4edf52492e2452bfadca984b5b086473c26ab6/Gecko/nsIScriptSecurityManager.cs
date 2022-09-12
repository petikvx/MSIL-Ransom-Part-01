using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b7ae2310-576e-11e5-a837-0800200c9a66")]
public interface nsIScriptSecurityManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void CanCreateWrapper(IntPtr aJSContext, ref Guid aIID, [MarshalAs(UnmanagedType.Interface)] nsISupports aObj, [MarshalAs(UnmanagedType.Interface)] nsIClassInfo aClassInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CanCreateInstance(IntPtr aJSContext, ref Guid aCID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CanGetService(IntPtr aJSContext, ref Guid aCID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckLoadURIFromScript(IntPtr cx, [MarshalAs(UnmanagedType.Interface)] nsIURI uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckLoadURIWithPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIURI uri, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckLoadURIStrWithPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase uri, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ScriptAllowed(IntPtr aGlobal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetSystemPrincipal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetSimpleCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetAppCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri, uint appId, [MarshalAs(UnmanagedType.U1)] bool inMozBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetLoadContextCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsILoadContext loadContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetDocShellCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIDocShell docShell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetNoAppCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal CreateCodebasePrincipal([MarshalAs(UnmanagedType.Interface)] nsIURI uri, ref JsVal originAttributes, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal CreateCodebasePrincipalFromOrigin([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase origin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal CreateNullPrincipal(ref JsVal originAttributes, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal CreateExpandedPrincipal([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] nsIPrincipal[] aPrincipalArray, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckSameOriginURI([MarshalAs(UnmanagedType.Interface)] nsIURI aSourceURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aTargetURI, [MarshalAs(UnmanagedType.U1)] bool reportError);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetChannelResultPrincipal([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetChannelURIPrincipal([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSystemPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetJarPrefix(uint appId, [MarshalAs(UnmanagedType.U1)] bool inMozBrowser, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDomainPolicy ActivateDomainPolicy();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDomainPolicyActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDomainPolicy ActivateDomainPolicyInternal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloneDomainPolicy(IntPtr aClone);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PolicyAllowsScript([MarshalAs(UnmanagedType.Interface)] nsIURI aDomain);
}
