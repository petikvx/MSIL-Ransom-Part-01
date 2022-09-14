using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[ClassInterface(0)]
[Guid("C7C3F5B2-88A3-11D0-ABCB-00A0C90FFFC0")]
public sealed class DrivesClass : IEnumerable, IDriveCollection, Drives
{
	[DispId(0)]
	public virtual extern Drive this[[In][MarshalAs(UnmanagedType.Struct)] object Key]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1)]
	public virtual extern int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern DrivesClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(65)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();
}
