using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[Guid("B9E84FFD-AD3C-40A4-B835-0882EBCBAAA8")]
[DefaultMember("Item")]
[TypeLibType(2)]
[ClassInterface(0)]
public class Class10 : IEnumerable, Interface21, Interface13
{
	[DispId(1610747309)]
	virtual extern int Interface13.Property36
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747309)]
		get;
	}

	[DispId(0)]
	virtual extern Interface19 Interface13.Property35
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern Class10();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(65)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();

	IEnumerator Interface13.Method1()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}
}
