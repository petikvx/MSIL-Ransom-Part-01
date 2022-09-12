using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0EC80360-075C-11d4-9FD4-00C04F1B83D8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISecretDecoderRing
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int Encrypt(IntPtr data, int dataLen, ref IntPtr result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int Decrypt(IntPtr data, int dataLen, ref IntPtr result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string EncryptString([MarshalAs(UnmanagedType.LPStr)] string text);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string DecryptString([MarshalAs(UnmanagedType.LPStr)] string crypt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ChangePassword();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Logout();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LogoutAndTeardown();
}
