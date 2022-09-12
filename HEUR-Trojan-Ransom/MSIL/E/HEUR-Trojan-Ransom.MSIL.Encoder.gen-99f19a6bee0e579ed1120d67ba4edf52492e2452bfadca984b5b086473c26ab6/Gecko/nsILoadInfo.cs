using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ddc65bf9-2f60-41ab-b22a-4f1ae9efcd36")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsILoadInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetLoadingPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal BinaryLoadingPrincipal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetTriggeringPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal BinaryTriggeringPrincipal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetLoadingDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr BinaryLoadingNode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetSecurityFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSecurityModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInThirdPartyContextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetCookiePolicyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetForceInheritPrincipalAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLoadingSandboxedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAboutBlankInheritsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAllowChromeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDontFollowRedirectsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetExternalContentPolicyTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr InternalContentPolicyType();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUpgradeInsecureRequestsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetInnerWindowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetOuterWindowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetParentOuterWindowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOriginAttributesAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOriginAttributesAttribute(JsVal aOriginAttributes, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr BinaryGetOriginAttributes();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BinarySetOriginAttributes(IntPtr aOriginAttrs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEnforceSecurityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnforceSecurityAttribute([MarshalAs(UnmanagedType.U1)] bool aEnforceSecurity);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInitialSecurityCheckDoneAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInitialSecurityCheckDoneAttribute([MarshalAs(UnmanagedType.U1)] bool aInitialSecurityCheckDone);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendRedirectedPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.U1)] bool isInternalRedirect);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetRedirectChainIncludingInternalRedirectsAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr BinaryRedirectChainIncludingInternalRedirects();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetRedirectChainAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr BinaryRedirectChain();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCorsPreflightInfo(IntPtr unsafeHeaders, [MarshalAs(UnmanagedType.U1)] bool forcePreflight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr CorsUnsafeHeaders();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetForcePreflightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsPreflightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTaintingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MaybeIncreaseTainting(uint aTainting);
}
