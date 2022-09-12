using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[TypeLibType(16)]
[Guid("00020404-0000-0000-C000-000000000046")]
[InterfaceType(1)]
public interface IEnumVARIANT
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Next([In] uint celt, [In][MarshalAs(UnmanagedType.Struct)] ref object rgvar, out uint pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] uint celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clone([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")] out IEnumerator ppenum);
}
