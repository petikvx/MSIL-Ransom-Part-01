using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("C3C28D92-A17F-43DF-976D-4EEAE6F995FC")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISound
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Play([MarshalAs(UnmanagedType.Interface)] nsIURL aURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PlaySystemSound([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase soundAlias);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Beep();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PlayEventSound(uint aEventId);
}
