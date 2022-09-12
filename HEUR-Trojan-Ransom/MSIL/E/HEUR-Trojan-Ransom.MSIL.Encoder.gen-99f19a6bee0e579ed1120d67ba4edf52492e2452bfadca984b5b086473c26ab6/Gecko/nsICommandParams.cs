using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("b1fdf3c4-74e3-4f7d-a14d-2b76bcf53482")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICommandParams
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetValueType([MarshalAs(UnmanagedType.LPStr)] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBooleanValue([MarshalAs(UnmanagedType.LPStr)] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLongValue([MarshalAs(UnmanagedType.LPStr)] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetDoubleValue([MarshalAs(UnmanagedType.LPStr)] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStringValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetCStringValue([MarshalAs(UnmanagedType.LPStr)] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetISupportsValue([MarshalAs(UnmanagedType.LPStr)] string name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBooleanValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.U1)] bool value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLongValue([MarshalAs(UnmanagedType.LPStr)] string name, int value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDoubleValue([MarshalAs(UnmanagedType.LPStr)] string name, double value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStringValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCStringValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetISupportsValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.Interface)] nsISupports value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveValue([MarshalAs(UnmanagedType.LPStr)] string name);
}
