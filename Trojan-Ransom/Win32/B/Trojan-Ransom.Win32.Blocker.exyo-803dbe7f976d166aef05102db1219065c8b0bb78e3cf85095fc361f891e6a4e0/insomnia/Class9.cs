using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[Guid("E2085F28-FEB7-404A-B8E7-E659BDEAAA02")]
[ClassInterface(0)]
[TypeLibType(2)]
public class Class9 : Interface5, Interface10, Interface14, Interface20
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern Class9();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744809)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern Interface21 Method8([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In] uint A_2);

	Interface21 Interface10.Method5([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In] uint A_2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method8
		return this.Method8(A_1, A_2);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744812)]
	public virtual extern int Method7([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In] uint A_2, [In][MarshalAs(UnmanagedType.IUnknown)] object A_3);

	int Interface10.Method4([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In] uint A_2, [In][MarshalAs(UnmanagedType.IUnknown)] object A_3)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method7
		return this.Method7(A_1, A_2, A_3);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744813)]
	public virtual extern void Method6([In] int A_1);

	void Interface10.Method3([In] int A_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method6
		this.Method6(A_1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744814)]
	public virtual extern void Method5([In] int A_1);

	void Interface10.Method2([In] int A_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method5
		this.Method5(A_1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610744811)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern Interface19 Method4([In][MarshalAs(UnmanagedType.BStr)] string A_1);

	Interface19 Interface10.Method1([In][MarshalAs(UnmanagedType.BStr)] string A_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method4
		return this.Method4(A_1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void Method3([In] int A_1);

	void Interface5.Method2([In] int A_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method3
		this.Method3(A_1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void Method2(out int A_1);

	void Interface5.Method1(out int A_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method2
		this.Method2(out A_1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void Method1([In][MarshalAs(UnmanagedType.BStr)] string A_1);
}
