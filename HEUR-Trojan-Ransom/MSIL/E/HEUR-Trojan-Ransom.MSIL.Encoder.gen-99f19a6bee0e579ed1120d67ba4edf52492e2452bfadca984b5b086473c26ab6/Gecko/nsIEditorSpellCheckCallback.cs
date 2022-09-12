using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5f0a4bab-8538-4074-89d3-2f0e866a1c0b")]
public interface nsIEditorSpellCheckCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void EditorSpellCheckDone();
}
