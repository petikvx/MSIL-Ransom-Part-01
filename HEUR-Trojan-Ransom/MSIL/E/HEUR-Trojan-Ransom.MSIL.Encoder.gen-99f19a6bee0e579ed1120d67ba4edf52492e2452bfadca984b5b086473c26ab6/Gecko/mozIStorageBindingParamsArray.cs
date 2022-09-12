using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("67eea5c3-4881-41ff-b0fe-09f2356aeadb")]
public interface mozIStorageBindingParamsArray
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageBindingParams NewBindingParams();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddParams(mozIStorageBindingParams aParameters);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLengthAttribute();
}
