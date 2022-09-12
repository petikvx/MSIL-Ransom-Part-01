using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5009acae-6973-48c3-b6d6-52c692cc5d9d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGConfService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBool([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetInt([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetFloat([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetStringList([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBool([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.U1)] bool value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInt([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, int value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFloat([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, float value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppForProtocol([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase scheme, [MarshalAs(UnmanagedType.U1)] ref bool enabled, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HandlerRequiresTerminal([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase scheme);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAppForProtocol([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase scheme, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase command);
}
