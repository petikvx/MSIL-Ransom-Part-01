using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("16d5b0ed-e756-4f1b-a8ce-9132e869acd8")]
public interface nsIGSettingsCollection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBoolean([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.U1)] bool value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInt([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, int value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBoolean([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetInt([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetStringList([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);
}
