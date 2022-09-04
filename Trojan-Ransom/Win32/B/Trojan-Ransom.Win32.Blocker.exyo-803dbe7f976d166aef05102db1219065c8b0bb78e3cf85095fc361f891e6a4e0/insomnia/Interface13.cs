using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[DefaultMember("Item")]
[Guid("FDBC0C73-BDA3-4C66-AC4F-F2D96FDAD68C")]
[TypeLibType(4288)]
public interface Interface13 : IEnumerable
{
	[DispId(1610747309)]
	int Property36
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747309)]
		get;
	}

	[DispId(0)]
	Interface19 Property35
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(65)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	IEnumerator Method1();
}
