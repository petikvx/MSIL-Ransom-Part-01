using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4176)]
[Guid("47C922A2-3DD5-11D2-BF8B-00C04FB93661")]
public interface ISearches : IEnumerable
{
	[DispId(1610743808)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743808)]
		get;
	}

	[DispId(1610743809)]
	string Default
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743809)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743810)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ISearch Item([Optional][In][MarshalAs(UnmanagedType.Struct)] object index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	new IEnumerator GetEnumerator();
}
