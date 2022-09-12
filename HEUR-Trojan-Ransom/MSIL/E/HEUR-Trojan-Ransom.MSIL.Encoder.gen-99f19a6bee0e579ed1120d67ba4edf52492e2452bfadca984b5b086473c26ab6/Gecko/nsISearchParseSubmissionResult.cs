using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0dc93e51-a7bf-4a16-862d-4b3469ff6206")]
public interface nsISearchParseSubmissionResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISearchEngine GetEngineAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTermsAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTerms);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTermsOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTermsLengthAttribute();
}
