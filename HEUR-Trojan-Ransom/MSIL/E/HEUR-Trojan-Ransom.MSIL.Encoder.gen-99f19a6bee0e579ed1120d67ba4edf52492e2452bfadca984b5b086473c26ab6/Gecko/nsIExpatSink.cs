using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("01f681af-0f22-4725-a914-0d396114daf0")]
public interface nsIExpatSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleStartElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] aAtts, uint aAttsCount, uint aLineNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEndElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleComment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aCommentText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleCDataSection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aData, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleDoctypeDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSubset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSystemId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPublicId, [MarshalAs(UnmanagedType.Interface)] nsISupports aCatalogData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleCharacterData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aData, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleProcessingInstruction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTarget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleXMLDeclaration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aEncoding, int aStandalone);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ReportError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aErrorText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aSourceText, [MarshalAs(UnmanagedType.Interface)] nsIScriptError aError);
}
