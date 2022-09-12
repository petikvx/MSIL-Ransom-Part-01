using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5e3e4f0c-7b77-47ca-a7c5-a3d87f2a9c82")]
public interface nsIExtendedExpatSink : nsIExpatSink
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleStartElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] aAtts, uint aAttsCount, uint aLineNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleEndElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleComment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aCommentText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleCDataSection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aData, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleDoctypeDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSubset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSystemId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPublicId, [MarshalAs(UnmanagedType.Interface)] nsISupports aCatalogData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleCharacterData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aData, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleProcessingInstruction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTarget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleXMLDeclaration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aEncoding, int aStandalone);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool ReportError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aErrorText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aSourceText, [MarshalAs(UnmanagedType.Interface)] nsIScriptError aError);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleStartDTD([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDoctypeName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aSysid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPubid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleStartNamespaceDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrefix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aUri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEndNamespaceDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrefix);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleNotationDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aNotationName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aSysid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPubid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleUnparsedEntityDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aSysid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPubid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aNotationName);
}
