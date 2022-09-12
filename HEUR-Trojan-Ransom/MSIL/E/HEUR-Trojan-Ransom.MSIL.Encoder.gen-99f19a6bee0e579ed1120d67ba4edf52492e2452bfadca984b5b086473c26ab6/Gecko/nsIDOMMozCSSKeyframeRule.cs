using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a281a8b4-eaa2-49a8-8b97-acc2814a57c9")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMMozCSSKeyframeRule : nsIDOMCSSRule
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCssText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCssTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCssText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMCSSStyleSheet GetParentStyleSheetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMCSSRule GetParentRuleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetCSSRule();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeyTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeyText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetKeyTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeyText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMCSSStyleDeclaration GetStyleAttribute();
}
