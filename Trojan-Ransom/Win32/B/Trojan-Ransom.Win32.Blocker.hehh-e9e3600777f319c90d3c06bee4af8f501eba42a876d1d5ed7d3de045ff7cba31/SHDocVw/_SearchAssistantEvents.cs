using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("1611FDDA-445B-11D2-85DE-00C04FA35C89")]
[InterfaceType(2)]
[TypeLibType(4112)]
public interface _SearchAssistantEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(1)]
	void OnNextMenuSelect([In] int idItem);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(2)]
	void OnNewSearch();
}
