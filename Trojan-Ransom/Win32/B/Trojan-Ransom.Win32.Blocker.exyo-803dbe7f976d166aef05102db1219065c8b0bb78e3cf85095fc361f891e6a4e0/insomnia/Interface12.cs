using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[Guid("415A984A-88B3-49F3-92AF-0508BEDF0D6C")]
[InterfaceType(1)]
public interface Interface12
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method3([In] int A_1, [In][MarshalAs(UnmanagedType.Interface)] Interface19 A_2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method2([In] int A_1, [In][MarshalAs(UnmanagedType.BStr)] string A_2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method1([In] int A_1);
}
