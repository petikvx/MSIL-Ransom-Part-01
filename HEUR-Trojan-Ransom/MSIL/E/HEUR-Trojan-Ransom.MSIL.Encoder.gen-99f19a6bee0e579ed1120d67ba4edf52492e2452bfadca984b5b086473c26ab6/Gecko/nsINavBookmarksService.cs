using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("24533891-afa6-4663-b72d-3143d03f1b04")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINavBookmarksService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetPlacesRootAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetBookmarksMenuFolderAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetTagsFolderAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetUnfiledBookmarksFolderAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetToolbarFolderAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int InsertBookmark(long aParentId, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveItem(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int CreateFolder(long aParentFolder, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, int index, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransaction GetRemoveFolderTransaction(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFolderChildren(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveItem(long aItemId, long aNewParentId, int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int InsertSeparator(long aParentId, int aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIdForItemAt(long aParentId, int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemTitle(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetItemTitle(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemDateAdded(long aItemId, long aDateAdded);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetItemDateAdded(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemLastModified(long aItemId, long aLastModified);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetItemLastModified(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBookmarkURI(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetItemIndex(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemIndex(long aItemId, int aNewIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetItemType(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsBookmarked([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetBookmarkedURIFor([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ChangeBookmarkURI(long aItemId, [MarshalAs(UnmanagedType.Interface)] nsIURI aNewURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFolderIdForItem(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBookmarkIdsForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref int[] bookmarks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetKeywordForBookmark(long aItemId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeyword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeywordForBookmark(long aItemId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetURIForKeyword([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase keyword);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsINavBookmarkObserver observer, [MarshalAs(UnmanagedType.U1)] bool ownsWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsINavBookmarkObserver observer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetObservers(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref nsINavBookmarkObserver[] observers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RunInBatchMode([MarshalAs(UnmanagedType.Interface)] nsINavHistoryBatchCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsISupports aUserData);
}
