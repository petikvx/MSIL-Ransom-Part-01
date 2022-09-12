using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C257573F-444F-468A-BA27-DE979DC55FE4")]
public interface nsIXULTemplateQueryProcessor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetDatasource([MarshalAs(UnmanagedType.Interface)] nsIArray aDataSources, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRootNode, [MarshalAs(UnmanagedType.U1)] bool aIsTrusted, [MarshalAs(UnmanagedType.Interface)] nsIXULTemplateBuilder aBuilder, [MarshalAs(UnmanagedType.U1)] ref bool aShouldDelayBuilding);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitializeForBuilding([MarshalAs(UnmanagedType.Interface)] nsISupports aDatasource, [MarshalAs(UnmanagedType.Interface)] nsIXULTemplateBuilder aBuilder, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRootNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Done();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports CompileQuery([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateBuilder aBuilder, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aQuery, [MarshalAs(UnmanagedType.Interface)] nsIAtom aRefVariable, [MarshalAs(UnmanagedType.Interface)] nsIAtom aMemberVariable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GenerateResults([MarshalAs(UnmanagedType.Interface)] nsISupports aDatasource, [MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aRef, [MarshalAs(UnmanagedType.Interface)] nsISupports aQuery);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddBinding([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRuleNode, [MarshalAs(UnmanagedType.Interface)] nsIAtom aVar, [MarshalAs(UnmanagedType.Interface)] nsIAtom aRef, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aExpr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULTemplateResult TranslateRef([MarshalAs(UnmanagedType.Interface)] nsISupports aDatasource, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRefString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int CompareResults([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aLeft, [MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aRight, [MarshalAs(UnmanagedType.Interface)] nsIAtom aVar, uint aSortHints);
}
