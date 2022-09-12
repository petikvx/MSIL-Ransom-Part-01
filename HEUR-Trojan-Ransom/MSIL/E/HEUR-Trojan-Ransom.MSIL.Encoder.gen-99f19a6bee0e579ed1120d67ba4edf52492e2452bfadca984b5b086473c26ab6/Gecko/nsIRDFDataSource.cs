using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0F78DA58-8321-11d2-8EAC-00805F29F370")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFDataSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetURIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFResource GetSource([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetSources([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFNode GetTarget([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetTargets([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Assert([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Unassert([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Change([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aOldTarget, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNewTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Move([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aOldSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aNewSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasAssertion([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIRDFObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIRDFObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator ArcLabelsIn([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator ArcLabelsOut([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetAllResources();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCommandEnabled([MarshalAs(UnmanagedType.Interface)] nsISupportsArray aSources, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aCommand, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aArguments);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoCommand([MarshalAs(UnmanagedType.Interface)] nsISupportsArray aSources, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aCommand, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray aArguments);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetAllCmds([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasArcIn([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aArc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasArcOut([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aArc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeginUpdateBatch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndUpdateBatch();
}
