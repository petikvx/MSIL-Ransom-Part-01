using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6657e8eb-b646-48e7-993e-cfa6e96415b4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface inIDeepTreeWalker
{
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
	bool GetShowDocumentsAsNodesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowDocumentsAsNodesAttribute([MarshalAs(UnmanagedType.U1)] bool aShowDocumentsAsNodes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRoot, uint aWhatToShow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetRootAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetWhatToShowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNodeFilter GetFilterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetCurrentNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentNodeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aCurrentNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode ParentNode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode FirstChild();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode LastChild();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode PreviousSibling();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode NextSibling();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode PreviousNode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode NextNode();
}
