using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f3ee57a6-890c-4ce0-a584-8a84bba0292e")]
public interface nsIEditorObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void EditAction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BeforeEditAction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CancelEditAction();
}
