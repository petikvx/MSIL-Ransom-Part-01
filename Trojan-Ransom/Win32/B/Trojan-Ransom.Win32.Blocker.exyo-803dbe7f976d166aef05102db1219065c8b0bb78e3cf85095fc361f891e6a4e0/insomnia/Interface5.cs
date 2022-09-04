using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[Guid("E3BF6178-694E-459F-A5A6-191EA0FFA1C7")]
[InterfaceType(1)]
[TypeLibType(256)]
public interface Interface5
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method2([In] int A_1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Method1(out int A_1);
}
