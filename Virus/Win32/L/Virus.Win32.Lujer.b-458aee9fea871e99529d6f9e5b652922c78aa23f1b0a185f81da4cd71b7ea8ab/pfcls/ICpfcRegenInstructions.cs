using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("3D355434-96BA-3E15-AB1C-D4431FAB86A4")]
public interface ICpfcRegenInstructions
{
	[DispId(1610743808)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IpfcRegenInstructions Create([In][MarshalAs(UnmanagedType.Struct)] object _AllowFixUI, [In][MarshalAs(UnmanagedType.Struct)] object _ForceRegen, [In][MarshalAs(UnmanagedType.Struct)] object _FromFeat);
}
