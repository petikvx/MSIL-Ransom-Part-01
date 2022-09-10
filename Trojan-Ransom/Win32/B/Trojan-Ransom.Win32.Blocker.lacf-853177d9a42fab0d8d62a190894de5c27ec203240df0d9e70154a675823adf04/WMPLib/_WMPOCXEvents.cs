using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib;

[ComImport]
[Guid("6BF52A51-394A-11D3-B153-00C04F79FAA6")]
[InterfaceType(2)]
[TypeIdentifier]
[CompilerGenerated]
public interface _WMPOCXEvents
{
	void _VtblGap1_1();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(5101)]
	void PlayStateChange([In] int NewState);
}
