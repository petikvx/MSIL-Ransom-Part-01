using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ebce86bd-1568-4a34-a808-9ccf9cde8087")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface rdfIDataSource
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitAllSubjects(rdfITripleVisitor aVisitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitAllTriples(rdfITripleVisitor aVisitor);
}
