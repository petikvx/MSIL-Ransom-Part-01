using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NAudio.Dmo;

[ComImport]
[Guid("f447b69e-1884-4a7e-8055-346f74d6edb3")]
internal sealed class ResamplerMediaComObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern ResamplerMediaComObject();
}
