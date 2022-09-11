using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NAudio.MediaFoundation;

[ComImport]
[Guid("48e2ed0f-98c2-4a37-bed5-166312ddd83f")]
public sealed class MFReadWriteClassFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern MFReadWriteClassFactory();
}
