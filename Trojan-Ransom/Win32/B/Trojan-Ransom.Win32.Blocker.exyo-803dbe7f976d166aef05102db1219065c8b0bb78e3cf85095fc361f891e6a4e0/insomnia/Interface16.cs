using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[InterfaceType(1)]
[Guid("31FADCA9-AB73-464B-B67D-5C1D0F83C8B8")]
public interface Interface16
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method2([In][MarshalAs(UnmanagedType.Interface)] Interface22 A_1, [In][MarshalAs(UnmanagedType.LPWStr)] string A_2, [In][MarshalAs(UnmanagedType.Struct)] object A_3);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method1([In][MarshalAs(UnmanagedType.Interface)] Interface22 A_1);
}
