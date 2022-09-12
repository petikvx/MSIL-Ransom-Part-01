using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a6cf90c2-15b3-11d2-932e-00805f8add32")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMCSSStyleSheet : nsIDOMStyleSheet
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDisabledAttribute([MarshalAs(UnmanagedType.U1)] bool aDisabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMNode GetOwnerNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMStyleSheet GetParentStyleSheetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetHrefAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHref);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMMediaList GetMediaAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMCSSRule GetOwnerRuleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMCSSRuleList GetCssRulesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint InsertRule([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase rule, uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteRule(uint index);
}
