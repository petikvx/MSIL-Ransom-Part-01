using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("706867af-0400-4faa-beb1-0dae87308784")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPersistentProperties : nsIProperties
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr Get([MarshalAs(UnmanagedType.LPStr)] string prop, ref Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Set([MarshalAs(UnmanagedType.LPStr)] string prop, [MarshalAs(UnmanagedType.Interface)] nsISupports value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Has([MarshalAs(UnmanagedType.LPStr)] string prop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Undefine([MarshalAs(UnmanagedType.LPStr)] string prop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetKeys(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref string[] keys);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Load([MarshalAs(UnmanagedType.Interface)] nsIInputStream input);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Save([MarshalAs(UnmanagedType.Interface)] nsIOutputStream output, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase header);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator Enumerate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStringProperty([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStringProperty([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
