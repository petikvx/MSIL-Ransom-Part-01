using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib;

[ComImport]
[TypeIdentifier]
[Guid("74C09E02-F828-11D2-A74B-00A0C905F36E")]
[CompilerGenerated]
public interface IWMPControls
{
	void _VtblGap1_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(51)]
	void play();
}
