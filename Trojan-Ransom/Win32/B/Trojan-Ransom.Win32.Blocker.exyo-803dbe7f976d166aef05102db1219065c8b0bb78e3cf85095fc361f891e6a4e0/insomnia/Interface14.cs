using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[Guid("0405AF4F-8B5C-447C-80F2-B75984A31F3C")]
[InterfaceType(1)]
[TypeLibType(256)]
public interface Interface14
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method1([In][MarshalAs(UnmanagedType.BStr)] string A_1);
}
