using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ec3dc3d5-41d1-4d08-ace5-7e944de6614d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface inIDOMUtils
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAllStyleSheets([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDoc, ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsISupports[] aSheets);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray GetCSSStyleRules([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRuleLine([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSRule aRule);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRuleColumn([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSRule aRule);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetRelativeRuleLine([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSRule aRule);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetCSSLexer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSelectorCount([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSelectorText([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule, uint aSelectorIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSpecificity([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule, uint aSelectorIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SelectorMatchesElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule, uint aSelectorIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsInheritedProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPropertyName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCSSPropertyNames(uint aFlags, ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref IntPtr[] aProps);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCSSValuesForProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty, ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref IntPtr[] aValues);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal ColorNameToRGB([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aColorName, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RgbToColorName(IntPtr aR, IntPtr aG, IntPtr aB, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal ColorToRGBA([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aColorString, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsValidCSSColor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aColorString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CssPropertyIsValid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPropertyName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPropertyValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubpropertiesForCSSProperty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty, ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref IntPtr[] aValues);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CssPropertyIsShorthand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CssPropertySupportsType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aProperty, uint type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsIgnorableWhitespace([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aDataNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetParentForNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.U1)] bool aShowingAnonymousContent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNodeList GetChildrenForNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.U1)] bool aShowingAnonymousContent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetBindingURLs([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetContentState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, ulong aState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMFontFaceList GetUsedFontFaces([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aRange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCSSPseudoElementNames(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aNames);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddPseudoClassLock([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudoClass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePseudoClassLock([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudoClass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasPseudoClassLock([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPseudoClass);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearPseudoClassLocks([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ParseStyleSheet([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleSheet aSheet, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInput);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollElementIntoView([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
}
