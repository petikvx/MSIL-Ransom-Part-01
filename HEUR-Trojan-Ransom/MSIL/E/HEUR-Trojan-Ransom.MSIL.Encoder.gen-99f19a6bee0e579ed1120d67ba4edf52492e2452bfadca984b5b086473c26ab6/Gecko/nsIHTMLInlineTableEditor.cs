using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("eda2e65c-a758-451f-9b05-77cb8de74ed2")]
public interface nsIHTMLInlineTableEditor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInlineTableEditingEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInlineTableEditingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aInlineTableEditingEnabled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ShowInlineTableEditingUI([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aCell);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HideInlineTableEditingUI();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoInlineTableEditingAction([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aUIAnonymousElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RefreshInlineTableEditingUI();
}
