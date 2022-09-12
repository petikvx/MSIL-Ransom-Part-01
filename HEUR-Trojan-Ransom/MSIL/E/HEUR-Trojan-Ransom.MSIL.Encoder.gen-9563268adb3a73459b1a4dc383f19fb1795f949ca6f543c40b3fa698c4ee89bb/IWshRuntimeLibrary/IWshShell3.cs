using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
public interface IWshShell3 : IWshShell2
{
	void _VtblGap1_4();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1002)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object CreateShortcut([In][MarshalAs(UnmanagedType.BStr)] string PathLink);
}
