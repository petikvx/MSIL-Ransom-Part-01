using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2b04860f-4017-40f6-8a57-784a1e35077a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFInferDataSource : nsIRDFDataSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	new string GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIRDFResource GetSource([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetSources([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIRDFNode GetTarget([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetTargets([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Assert([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Unassert([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Change([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aOldTarget, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNewTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Move([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aOldSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aNewSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool HasAssertion([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIRDFObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIRDFObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator ArcLabelsIn([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator ArcLabelsOut([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetAllResources();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsCommandEnabled([MarshalAs(UnmanagedType.Interface)] nsISupportsArray aSources, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aCommand, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aArguments);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DoCommand([MarshalAs(UnmanagedType.Interface)] nsISupportsArray aSources, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aCommand, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aArguments);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator GetAllCmds([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool HasArcIn([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aArc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool HasArcOut([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aArc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BeginUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void EndUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFDataSource GetBaseDataSourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBaseDataSourceAttribute([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aBaseDataSource);
}
