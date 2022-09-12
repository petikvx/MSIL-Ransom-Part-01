using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("b0132cc0-3786-4557-9874-910d7def5f93")]
public interface nsICollation
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Initialize([MarshalAs(UnmanagedType.Interface)] nsILocale locale);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int CompareString(int strength, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase string1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase string2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AllocateRawSortKey(int strength, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase stringIn, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ref byte[] key, ref uint outLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int CompareRawSortKey([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] key1, uint len1, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] key2, uint len2);
}
