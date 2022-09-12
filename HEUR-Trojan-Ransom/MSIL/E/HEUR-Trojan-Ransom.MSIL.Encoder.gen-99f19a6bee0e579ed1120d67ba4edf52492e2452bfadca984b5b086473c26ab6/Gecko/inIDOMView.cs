using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("FBB67442-27A3-483C-8EB2-29C3EED7514C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface inIDOMView
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetRootNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRootNodeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRootNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowAnonymousContentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowAnonymousContentAttribute([MarshalAs(UnmanagedType.U1)] bool aShowAnonymousContent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowSubDocumentsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowSubDocumentsAttribute([MarshalAs(UnmanagedType.U1)] bool aShowSubDocuments);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowWhitespaceNodesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowWhitespaceNodesAttribute([MarshalAs(UnmanagedType.U1)] bool aShowWhitespaceNodes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowAccessibleNodesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowAccessibleNodesAttribute([MarshalAs(UnmanagedType.U1)] bool aShowAccessibleNodes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetWhatToShowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWhatToShowAttribute(uint aWhatToShow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetNodeFromRowIndex(int rowIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowIndexFromNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Rebuild();
}
