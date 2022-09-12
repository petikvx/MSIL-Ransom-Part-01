using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b5e9af48-a7c2-4f88-aae3-58307af4b5a5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMCSSStyleRule : nsIDOMCSSRule
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
	void GetSelectorTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSelectorText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectorTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSelectorText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMCSSStyleDeclaration GetStyleAttribute();
}
