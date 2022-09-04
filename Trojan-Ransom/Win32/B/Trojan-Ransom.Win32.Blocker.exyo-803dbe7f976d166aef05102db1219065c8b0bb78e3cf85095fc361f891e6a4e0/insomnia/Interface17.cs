using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[DefaultMember("Item")]
[Guid("3F8C8E9E-9A7A-4DC8-BC41-FF31FA374956")]
[TypeLibType(4288)]
public interface Interface17 : IEnumerable
{
	[DispId(1610745809)]
	int Property31
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610745809)]
		get;
	}

	[DispId(0)]
	Interface22 Property30
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[TypeLibFunc(65)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	IEnumerator Method1();
}
