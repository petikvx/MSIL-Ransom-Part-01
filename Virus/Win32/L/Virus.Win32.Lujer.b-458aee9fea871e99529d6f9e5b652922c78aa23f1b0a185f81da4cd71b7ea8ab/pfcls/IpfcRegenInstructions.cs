using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E671023B-3A5D-3130-9A62-FC52902AE343")]
[CompilerGenerated]
public interface IpfcRegenInstructions
{
	[DispId(1610678274)]
	bool ForceRegen
	{
		get; [param: In]
		set;
	}

	void _VtblGap1_2();
}
