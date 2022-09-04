using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[DefaultMember("Item")]
[ClassInterface(0)]
[Guid("C0BC4B4A-A406-4EFC-932F-B8546B8100CC")]
[TypeLibType(2)]
public class Class12 : IEnumerable, Interface23, Interface17
{
	[DispId(1610745809)]
	virtual extern int Interface17.Property31
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610745809)]
		get;
	}

	[DispId(0)]
	virtual extern Interface22 Interface17.Property30
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern Class12();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(65)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();

	IEnumerator Interface17.Method1()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}
}
