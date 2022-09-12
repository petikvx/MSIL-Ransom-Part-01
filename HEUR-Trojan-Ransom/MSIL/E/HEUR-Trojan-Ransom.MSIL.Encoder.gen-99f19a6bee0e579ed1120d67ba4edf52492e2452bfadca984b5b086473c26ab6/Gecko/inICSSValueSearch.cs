using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e0d39e48-1dd1-11b2-81bd-9a0c117f0736")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface inICSSValueSearch : inISearchProcess
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetResultCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetHoldResultsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetHoldResultsAttribute([MarshalAs(UnmanagedType.U1)] bool aHoldResults);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SearchSync();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SearchAsync(inISearchObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SearchStop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool SearchStep();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetStringResultAt(int aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetIntResultAt(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetUIntResultAt(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMDocument GetDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocumentAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetBaseURLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBaseURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aBaseURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReturnRelativeURLsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReturnRelativeURLsAttribute([MarshalAs(UnmanagedType.U1)] bool aReturnRelativeURLs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetNormalizeChromeURLsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNormalizeChromeURLsAttribute([MarshalAs(UnmanagedType.U1)] bool aNormalizeChromeURLs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddPropertyCriteria([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPropName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetTextCriteriaAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextCriteriaAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTextCriteria);
}
