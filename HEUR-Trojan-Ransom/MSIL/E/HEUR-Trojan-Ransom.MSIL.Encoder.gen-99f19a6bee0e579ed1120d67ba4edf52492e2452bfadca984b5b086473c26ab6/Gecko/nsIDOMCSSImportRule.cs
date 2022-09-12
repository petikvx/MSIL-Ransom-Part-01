using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d3b2b914-01ef-4663-beda-a6475a26f491")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMCSSImportRule : nsIDOMCSSRule
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
	void GetHrefAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHref);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMMediaList GetMediaAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMCSSStyleSheet GetStyleSheetAttribute();
}
