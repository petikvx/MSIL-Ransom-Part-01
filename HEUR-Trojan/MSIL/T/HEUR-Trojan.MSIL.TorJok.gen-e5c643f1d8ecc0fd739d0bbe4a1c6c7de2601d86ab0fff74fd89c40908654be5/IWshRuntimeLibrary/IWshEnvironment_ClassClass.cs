using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("F935DC2A-1CF0-11D0-ADB9-00C04FD58A0B")]
[TypeLibType(16)]
[ClassInterface(0)]
public sealed class IWshEnvironment_ClassClass : IEnumerable, IWshEnvironment, IWshEnvironment_Class
{
	[DispId(0)]
	public virtual extern string this[[In][MarshalAs(UnmanagedType.BStr)] string Name]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	public virtual extern int length
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern IWshEnvironment_ClassClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	public virtual extern int Count();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1001)]
	public virtual extern void Remove([In][MarshalAs(UnmanagedType.BStr)] string Name);
}
