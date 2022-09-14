using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[DefaultMember("Item")]
[Guid("387DAFF4-DA03-44D2-B0D1-80C927C905AC")]
[ClassInterface(0)]
public sealed class WshCollectionClass : IEnumerable, IWshCollection, WshCollection
{
	[DispId(2)]
	public virtual extern int length
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern WshCollectionClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object Item([In][MarshalAs(UnmanagedType.Struct)] ref object Index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	public virtual extern int Count();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();
}
