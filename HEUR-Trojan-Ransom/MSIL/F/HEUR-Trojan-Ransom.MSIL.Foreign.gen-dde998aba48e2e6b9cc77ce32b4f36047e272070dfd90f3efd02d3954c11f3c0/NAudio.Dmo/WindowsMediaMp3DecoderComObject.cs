using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NAudio.Dmo;

[ComImport]
[Guid("bbeea841-0a63-4f52-a7ab-a9b3a84ed38a")]
internal sealed class WindowsMediaMp3DecoderComObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern WindowsMediaMp3DecoderComObject();
}
