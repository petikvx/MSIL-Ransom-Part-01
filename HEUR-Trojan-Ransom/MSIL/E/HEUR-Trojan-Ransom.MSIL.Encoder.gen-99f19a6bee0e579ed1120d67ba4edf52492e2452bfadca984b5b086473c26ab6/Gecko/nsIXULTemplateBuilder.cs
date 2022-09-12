using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("A583B676-5B02-4F9C-A0C9-CB850CB99818")]
public interface nsIXULTemplateBuilder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMElement GetRootAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetDatasourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDatasourceAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aDatasource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFCompositeDataSource GetDatabaseAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULTemplateResult GetRootResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULTemplateQueryProcessor GetQueryProcessorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Rebuild();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Refresh();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddResult([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aResult, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aQueryNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveResult([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceResult([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aOldResult, [MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aNewResult, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aQueryNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResultBindingChanged([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateResult aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULTemplateResult GetResultForId([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXULTemplateResult GetResultForContent([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasGeneratedContent([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aNode, [MarshalAs(UnmanagedType.Interface)] nsIAtom aTag);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddRuleFilter([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRule, [MarshalAs(UnmanagedType.Interface)] nsIXULTemplateRuleFilter aFilter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(IntPtr aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateContents(IntPtr aElement, [MarshalAs(UnmanagedType.U1)] bool aForceCreation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddListener([MarshalAs(UnmanagedType.Interface)] nsIXULBuilderListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIXULBuilderListener aListener);
}
