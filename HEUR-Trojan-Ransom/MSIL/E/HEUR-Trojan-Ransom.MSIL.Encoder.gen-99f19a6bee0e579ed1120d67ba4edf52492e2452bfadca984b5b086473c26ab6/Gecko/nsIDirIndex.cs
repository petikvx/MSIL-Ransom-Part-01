using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("23bbabd0-1dd2-11b2-86b7-aad68ae7d7e0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDirIndex
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTypeAttribute(uint aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetContentTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStr)] string aContentType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetLocationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLocationAttribute([MarshalAs(UnmanagedType.LPStr)] string aLocation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDescriptionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSizeAttribute(long aSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLastModifiedAttribute(long aLastModified);
}
