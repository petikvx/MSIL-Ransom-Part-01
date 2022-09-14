using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("C7C3F5B6-88A3-11D0-ABCB-00A0C90FFFC0")]
[ClassInterface(0)]
public sealed class FilesClass : IEnumerable, IFileCollection, Files
{
	[DispId(0)]
	public virtual extern File this[[In][MarshalAs(UnmanagedType.Struct)] object Key]
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
	internal extern FilesClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[TypeLibFunc(65)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();
}
