using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0b7d12c9-4cd3-47db-99c6-0b5ff910446c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLAppletElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAlignAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAltAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAltAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAlt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetArchiveAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArchive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetArchiveAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArchive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCodeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCodeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCodeBaseAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCodeBase);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCodeBaseAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCodeBase);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHeightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHspaceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHspaceAttribute(int aHspace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetObjectAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aObject);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetObjectAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aObject);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetVspaceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVspaceAttribute(int aVspace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWidthAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWidthAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aWidth);
}
