using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0d79adad-b244-49A5-9997-2a8cad93fc44")]
public interface nsIFilePickerShownCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Done(short aResult);
}
