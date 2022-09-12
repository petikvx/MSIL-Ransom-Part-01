using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("094be624-f0bf-400f-89e2-6a84baab9474")]
public interface nsIEditor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISelection GetSelectionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FinalizeSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc, IntPtr aRoot, [MarshalAs(UnmanagedType.Interface)] nsISelectionController aSelCon, uint aFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase initialValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAttributeOrEquivalent([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceAttrName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceAttrValue, [MarshalAs(UnmanagedType.U1)] bool aSuppressTransaction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAttributeOrEquivalent([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceAttrName, [MarshalAs(UnmanagedType.U1)] bool aSuppressTransaction);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PostCreate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PreDestroy([MarshalAs(UnmanagedType.U1)] bool aDestroyingFrames);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFlagsAttribute(uint aFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetContentsMIMETypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentsMIMETypeAttribute([MarshalAs(UnmanagedType.LPStr)] string aContentsMIMEType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsDocumentEditableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsSelectionEditableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetRootElementAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISelectionController GetSelectionControllerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSelection(short action, short stripWrappers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDocumentIsEmptyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDocumentModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDocumentCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aDocumentCharacterSet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocumentCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aDocumentCharacterSet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetModificationCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetModificationCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IncrementModificationCount(int aModCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransactionManager GetTransactionManagerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTransactionManagerAttribute([MarshalAs(UnmanagedType.Interface)] nsITransactionManager aTransactionManager);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoTransaction([MarshalAs(UnmanagedType.Interface)] nsITransaction txn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableUndo([MarshalAs(UnmanagedType.U1)] bool enable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNumberOfUndoItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNumberOfRedoItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Undo(uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CanUndo([MarshalAs(UnmanagedType.U1)] ref bool isEnabled, [MarshalAs(UnmanagedType.U1)] ref bool canUndo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Redo(uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CanRedo([MarshalAs(UnmanagedType.U1)] ref bool isEnabled, [MarshalAs(UnmanagedType.U1)] ref bool canRedo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginPlaceHolderTransaction([MarshalAs(UnmanagedType.Interface)] nsIAtom name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndPlaceHolderTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ShouldTxnSetSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShouldTxnSetSelection([MarshalAs(UnmanagedType.U1)] bool should);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInlineSpellChecker GetInlineSpellChecker([MarshalAs(UnmanagedType.U1)] bool autoCreate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SyncRealTimeSpell();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSpellcheckUserOverride([MarshalAs(UnmanagedType.U1)] bool enable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cut();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanCut();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Copy();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanCopy();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanDelete();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Paste(int aSelectionType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PasteTransferable([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanPaste(int aSelectionType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool CanPasteTransferable([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginningOfDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndOfDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase attributestr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase attvalue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAttributeValue([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase attributestr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase resultValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloneAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAttribute, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aDestNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aSourceNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloneAttributes([MarshalAs(UnmanagedType.Interface)] nsIDOMNode destNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode sourceNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode CreateNode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase tag, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent, int position);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent, int aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SplitNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode existingRightNode, int offset, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMNode newLeftNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void JoinNodes([MarshalAs(UnmanagedType.Interface)] nsIDOMNode leftNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode rightNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode child);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool OutputsMozDirty();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkNodeDirty([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SwitchTextDirection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OutputToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase formatType, uint flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OutputToStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase formatType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase charsetOverride, uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEditorObserver([MarshalAs(UnmanagedType.Interface)] nsIEditorObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveEditorObserver([MarshalAs(UnmanagedType.Interface)] nsIEditorObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEditActionListener([MarshalAs(UnmanagedType.Interface)] nsIEditActionListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveEditActionListener([MarshalAs(UnmanagedType.Interface)] nsIEditActionListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddDocumentStateListener(IntPtr listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDocumentStateListener(IntPtr listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpContentTree();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DebugDumpContent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DebugUnitTests(ref int outNumTests, ref int outNumTestsFailed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsModifiableNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSuppressDispatchingInputEventAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSuppressDispatchingInputEventAttribute([MarshalAs(UnmanagedType.U1)] bool aSuppressDispatchingInputEvent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInEditActionAttribute();
}
