using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("D4CDAAB1-8EEC-47A8-B420-AD7CB333056A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAnnotationService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemAnnotation(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPageAnnotationString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemAnnotationString(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPageAnnotationInt32([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, int aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemAnnotationInt32(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, int aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPageAnnotationInt64([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, long aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemAnnotationInt64(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, long aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPageAnnotationDouble([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, double aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetItemAnnotationDouble(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, double aValue, int aFlags, ushort aExpiration);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetPageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetItemAnnotation(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPageAnnotationString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetItemAnnotationString(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPageAnnotationInt32([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetItemAnnotationInt32(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPageAnnotationInt64([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetItemAnnotationInt64(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetPageAnnotationDouble([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetItemAnnotationDouble(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPageAnnotationInfo([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, ref int aFlags, ref ushort aExpiration, ref ushort aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetItemAnnotationInfo(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, ref int aFlags, ref ushort aExpiration, ref ushort aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetPageAnnotationType([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetItemAnnotationType(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPagesWithAnnotation([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, ref uint resultCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsIURI[] results);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetItemsWithAnnotation([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, ref uint resultCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref int[] results);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIAnnotatedResult GetAnnotationsWithName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, ref uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPageAnnotationNames([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsIVariant[] result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetItemAnnotationNames(long aItemId, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsIVariant[] result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PageHasAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ItemHasAnnotation(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveItemAnnotation(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePageAnnotations([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveItemAnnotations(long aItemId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyPageAnnotations([MarshalAs(UnmanagedType.Interface)] nsIURI aSourceURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aDestURI, [MarshalAs(UnmanagedType.U1)] bool aOverwriteDest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CopyItemAnnotations(long aSourceItemId, long aDestItemId, [MarshalAs(UnmanagedType.U1)] bool aOverwriteDest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIAnnotationObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIAnnotationObserver aObserver);
}
