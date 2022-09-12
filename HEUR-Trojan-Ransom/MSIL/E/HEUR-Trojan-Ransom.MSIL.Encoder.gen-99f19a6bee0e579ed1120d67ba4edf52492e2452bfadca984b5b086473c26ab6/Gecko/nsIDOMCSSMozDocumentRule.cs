using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2d0cef9d-c1b2-4c6c-9003-fa83040626d1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMCSSMozDocumentRule : nsIDOMCSSConditionRule, nsIDOMCSSGroupingRule, nsIDOMCSSRule
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
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMCSSRuleList GetCssRulesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint InsertRule([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase rule, uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DeleteRule(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetConditionTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aConditionText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetConditionTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aConditionText);
}
