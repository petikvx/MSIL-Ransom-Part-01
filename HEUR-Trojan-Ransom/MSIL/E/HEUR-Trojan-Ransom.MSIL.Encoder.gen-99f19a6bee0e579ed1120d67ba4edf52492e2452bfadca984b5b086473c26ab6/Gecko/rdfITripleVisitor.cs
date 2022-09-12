using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("aafea151-c271-4505-9978-a100d292800c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface rdfITripleVisitor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Visit([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aSubject, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aPredicate, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aObject, [MarshalAs(UnmanagedType.U1)] bool aTruthValue);
}
