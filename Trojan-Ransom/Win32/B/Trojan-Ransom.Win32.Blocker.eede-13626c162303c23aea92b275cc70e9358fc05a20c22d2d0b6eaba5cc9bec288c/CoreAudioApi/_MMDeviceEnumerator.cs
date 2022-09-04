using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreAudioApi;

[ComImport]
[Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
internal class _MMDeviceEnumerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern _MMDeviceEnumerator();
}
