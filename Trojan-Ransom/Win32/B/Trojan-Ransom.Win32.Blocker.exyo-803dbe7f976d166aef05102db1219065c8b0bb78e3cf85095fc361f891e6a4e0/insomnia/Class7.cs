using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[ClassInterface(0)]
[TypeLibType(2)]
[Guid("1D8A9B47-3A28-4CE2-8A4B-BD34E45BCEEB")]
public class Class7 : Interface6, Interface14, Interface18
{
	[DispId(-525)]
	virtual extern int Interface6.Property56
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-525)]
		get;
	}

	[DispId(1610748311)]
	virtual extern int Interface6.Property55
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610748311)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern Class7();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748309)]
	public virtual extern void Method6([In][MarshalAs(UnmanagedType.BStr)] string A_1);

	void Interface6.Method5([In][MarshalAs(UnmanagedType.BStr)] string A_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method6
		this.Method6(A_1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748310)]
	public virtual extern void Method5([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In][MarshalAs(UnmanagedType.IUnknown)] object A_2);

	void Interface6.Method4([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In][MarshalAs(UnmanagedType.IUnknown)] object A_2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method5
		this.Method5(A_1, A_2);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748312)]
	public virtual extern void Method4();

	void Interface6.Method3()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method4
		this.Method4();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748313)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern Interface19 Method3();

	Interface19 Interface6.Method2()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method3
		return this.Method3();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748314)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern Interface19 Method2([In][MarshalAs(UnmanagedType.BStr)] string A_1);

	Interface19 Interface6.Method1([In][MarshalAs(UnmanagedType.BStr)] string A_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Method2
		return this.Method2(A_1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void Method1([In][MarshalAs(UnmanagedType.BStr)] string A_1);
}
