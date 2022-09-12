using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("29383d00-d8c4-4ddd-9f8b-c2feb0f2fcfa")]
public interface mozIStorageStatementCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleResult(mozIStorageResultSet aResultSet);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleError(mozIStorageError aError);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleCompletion(ushort aReason);
}
