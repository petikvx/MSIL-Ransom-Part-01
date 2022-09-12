using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("fea3e276-6ba5-4ceb-a581-807d1f43f6d0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICacheEntryMetaDataVisitor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);
}
