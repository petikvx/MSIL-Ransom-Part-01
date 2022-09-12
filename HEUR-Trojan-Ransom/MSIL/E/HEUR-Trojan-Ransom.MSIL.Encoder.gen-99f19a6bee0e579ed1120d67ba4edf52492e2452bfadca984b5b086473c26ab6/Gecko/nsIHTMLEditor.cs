using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("87ee993e-985f-4a43-a974-0d9512da2fb0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHTMLEditor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddDefaultProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDefaultProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAllDefaultProperties();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInlineProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInlineProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue, [MarshalAs(UnmanagedType.U1)] ref bool aFirst, [MarshalAs(UnmanagedType.U1)] ref bool aAny, [MarshalAs(UnmanagedType.U1)] ref bool aAll);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInlinePropertyWithAttrValue([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue, [MarshalAs(UnmanagedType.U1)] ref bool aFirst, [MarshalAs(UnmanagedType.U1)] ref bool aAny, [MarshalAs(UnmanagedType.U1)] ref bool aAll, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAllInlineProperties();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveInlineProperty([MarshalAs(UnmanagedType.Interface)] nsIAtom aProperty, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IncreaseFontSize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DecreaseFontSize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool NodeIsBlock([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertHTML([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInputString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PasteNoFormatting(int aSelectionType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RebuildDocumentFromSource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSourceString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertHTMLWithContext([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInputString, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContextStr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aInfoStr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFlavor, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aSourceDoc, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aDestinationNode, int aDestinationOffset, [MarshalAs(UnmanagedType.U1)] bool aDeleteSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertElementAtSelection([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.U1)] bool aDeleteSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocumentTitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateBaseURL();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCaretAfterElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetParagraphFormat([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aParagraphFormat);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetParagraphState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFontFaceState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFontColorState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBackgroundColorState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHighlightColorState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetListState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.U1)] ref bool aOL, [MarshalAs(UnmanagedType.U1)] ref bool aUL, [MarshalAs(UnmanagedType.U1)] ref bool aDL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetListItemState([MarshalAs(UnmanagedType.U1)] ref bool aMixed, [MarshalAs(UnmanagedType.U1)] ref bool aLI, [MarshalAs(UnmanagedType.U1)] ref bool aDT, [MarshalAs(UnmanagedType.U1)] ref bool aDD);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAlignment([MarshalAs(UnmanagedType.U1)] ref bool aMixed, ref short aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetIndentState([MarshalAs(UnmanagedType.U1)] ref bool aCanIndent, [MarshalAs(UnmanagedType.U1)] ref bool aCanOutdent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MakeOrChangeList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aListType, [MarshalAs(UnmanagedType.U1)] bool entireList, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBulletType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aListType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Indent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIndent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Align([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetElementOrParentByTagName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTagName, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetSelectedElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTagName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHeadContentsAsHTML([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceHeadContentsWithHTML([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSourceToInsert);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement CreateElementWithDefaults([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTagName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertLinkAroundSelection([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aAnchorElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBackgroundColor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aColor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBodyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray GetLinkedObjects();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsCSSEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsCSSEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aIsCSSEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddInsertionListener(IntPtr inFilter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveInsertionListener(IntPtr inFilter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement CreateAnonymousElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTag, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aParentNode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAnonClass, [MarshalAs(UnmanagedType.U1)] bool aIsCreatedHidden);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetSelectionContainer();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckSelectionStateForAnonymousButtons([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAnonymousElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReturnInParagraphCreatesNewParagraphAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReturnInParagraphCreatesNewParagraphAttribute([MarshalAs(UnmanagedType.U1)] bool aReturnInParagraphCreatesNewParagraph);

	[MethodImpl(MethodImplOptions.InternalCall)]
	Element GetActiveEditingHost();
}
