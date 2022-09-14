using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[DefaultMember("Item")]
[Guid("F935DC27-1CF0-11D0-ADB9-00C04FD58A0B")]
[TypeLibType(4160)]
public interface IWshCollection : IEnumerable
{
	[DispId(2)]
	int length
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Item([In][MarshalAs(UnmanagedType.Struct)] ref object Index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	int Count();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	new IEnumerator GetEnumerator();
}
