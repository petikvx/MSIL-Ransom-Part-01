using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0f0f45b0-13a1-44ae-a0ab-c6046ec6d4da")]
public interface nsINavHistoryObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnBeginUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnEndUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnVisit([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, long aVisitID, long aTime, long aSessionID, long aReferringID, uint aTransitionType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, [MarshalAs(UnmanagedType.U1)] bool aHidden);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnTitleChanged([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPageTitle, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnFrecencyChanged([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aNewFrecency, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, [MarshalAs(UnmanagedType.U1)] bool aHidden, long aVisitDate);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnManyFrecenciesChanged();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnDeleteURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, ushort aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnClearHistory();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnPageChanged([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, uint aChangedAttribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNewValue, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnDeleteVisits([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, long aVisitTime, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, ushort aReason, uint aTransitionType);
}
