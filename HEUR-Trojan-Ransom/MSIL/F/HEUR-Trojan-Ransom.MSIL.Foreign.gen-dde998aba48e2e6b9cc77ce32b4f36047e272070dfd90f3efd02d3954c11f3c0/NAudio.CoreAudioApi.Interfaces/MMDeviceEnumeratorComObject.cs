using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NAudio.CoreAudioApi.Interfaces;

[ComImport]
[Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
internal sealed class MMDeviceEnumeratorComObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern MMDeviceEnumeratorComObject();
}
