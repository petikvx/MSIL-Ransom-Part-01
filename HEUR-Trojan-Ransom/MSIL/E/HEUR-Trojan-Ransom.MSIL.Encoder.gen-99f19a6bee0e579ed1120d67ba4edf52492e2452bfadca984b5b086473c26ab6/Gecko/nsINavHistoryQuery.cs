using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("dc87ae79-22f1-4dcf-975b-852b01d210cb")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINavHistoryQuery
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetBeginTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBeginTimeAttribute(long aBeginTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetBeginTimeReferenceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBeginTimeReferenceAttribute(uint aBeginTimeReference);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasBeginTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetAbsoluteBeginTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetEndTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEndTimeAttribute(long aEndTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEndTimeReferenceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEndTimeReferenceAttribute(uint aEndTimeReference);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasEndTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetAbsoluteEndTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSearchTermsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchTerms);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSearchTermsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSearchTerms);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasSearchTermsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMinVisitsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMinVisitsAttribute(int aMinVisits);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMaxVisitsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxVisitsAttribute(int aMaxVisits);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTransitions([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] transitions, uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTransitions(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref uint[] transitions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTransitionCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetOnlyBookmarkedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnlyBookmarkedAttribute([MarshalAs(UnmanagedType.U1)] bool aOnlyBookmarked);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDomainIsHostAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDomainIsHostAttribute([MarshalAs(UnmanagedType.U1)] bool aDomainIsHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDomainAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDomainAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasDomainAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetUriIsPrefixAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUriIsPrefixAttribute([MarshalAs(UnmanagedType.U1)] bool aUriIsPrefix);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aUri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAnnotationIsNotAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAnnotationIsNotAttribute([MarshalAs(UnmanagedType.U1)] bool aAnnotationIsNot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAnnotationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAnnotation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAnnotationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAnnotation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetHasAnnotationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetTagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTagsAttribute([MarshalAs(UnmanagedType.Interface)] nsIVariant aTags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetTagsAreNotAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTagsAreNotAttribute([MarshalAs(UnmanagedType.U1)] bool aTagsAreNot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFolders(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref int[] folders);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFolderCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFolders([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] folders, uint folderCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINavHistoryQuery Clone();
}
