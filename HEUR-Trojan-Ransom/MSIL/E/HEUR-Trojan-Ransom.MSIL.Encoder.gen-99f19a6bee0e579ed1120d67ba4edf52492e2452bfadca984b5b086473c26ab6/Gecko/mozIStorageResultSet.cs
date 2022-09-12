using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("18dd7953-076d-4598-8105-3e32ad26ab24")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIStorageResultSet
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageRow GetNextRow();
}
