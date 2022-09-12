using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b74fb158-1265-4102-91eb-edd0136b49f8")]
public interface nsIPlaintextEditor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTextLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMaxTextLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMaxTextLengthAttribute(int aMaxTextLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetWrapWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWrapWidthAttribute(int aWrapWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWrapColumn(int aWrapColumn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNewlineHandlingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNewlineHandlingAttribute(int aNewlineHandling);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertText([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aStringToInsert);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertLineBreak();
}
