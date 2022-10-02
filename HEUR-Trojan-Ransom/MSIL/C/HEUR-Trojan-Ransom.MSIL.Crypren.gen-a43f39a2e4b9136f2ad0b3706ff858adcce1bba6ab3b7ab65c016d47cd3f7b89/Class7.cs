using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal sealed class Class7
{
	[ComImport]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("DC1C5A9C-E88A-4DDE-A5A1-60F82A20AEF7")]
	internal class Class8
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Class8();
	}

	[ComImport]
	[Guid("42F85136-DB7E-439C-85F1-E4075D135FC8")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface Interface0
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		uint imethod_0([Optional][In] IntPtr intptr_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_1([In] uint uint_0, [In][MarshalAs(UnmanagedType.LPArray)] IntPtr intptr_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_2([In] uint uint_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_3(ref uint uint_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_4([In][MarshalAs(UnmanagedType.Interface)] IntPtr intptr_0, ref uint uint_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_5([In] uint uint_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_6([In] uint uint_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_7(ref uint uint_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8([In][MarshalAs(UnmanagedType.Interface)] Interface1 interface1_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_9([In][MarshalAs(UnmanagedType.Interface)] Interface1 interface1_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_10([MarshalAs(UnmanagedType.Interface)] ref Interface1 interface1_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_11([MarshalAs(UnmanagedType.Interface)] ref Interface1 interface1_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_12([In][MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_13([MarshalAs(UnmanagedType.LPWStr)] ref string string_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_14([In][MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_15([In][MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_16([In][MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_17([MarshalAs(UnmanagedType.Interface)] ref Interface1 interface1_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_18([In][MarshalAs(UnmanagedType.Interface)] Interface1 interface1_0, uint uint_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_19([In][MarshalAs(UnmanagedType.LPWStr)] string string_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_20([MarshalAs(UnmanagedType.Error)] uint uint_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_21([In] ref Guid guid_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_22();

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_23([MarshalAs(UnmanagedType.Interface)] IntPtr intptr_0);
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
	internal interface Interface1
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_0([In] IntPtr intptr_0, [In] ref Guid guid_0, [In] ref Guid guid_1, [MarshalAs(UnmanagedType.Interface)] out IntPtr intptr_1);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_1([MarshalAs(UnmanagedType.Interface)] ref Interface1 interface1_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_2([In] uint uint_0, ref IntPtr intptr_0);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_3([In] uint uint_0, ref uint uint_1);

		[MethodImpl(MethodImplOptions.InternalCall)]
		uint imethod_4([In][MarshalAs(UnmanagedType.Interface)] Interface1 interface1_0, [In] uint uint_0, ref int int_0);
	}

	public const uint uint_0 = 32u;

	public const uint uint_1 = 64u;

	public const uint uint_2 = 256u;

	public const uint uint_3 = 65536u;

	public const uint uint_4 = 33554432u;

	public const uint uint_5 = 0u;

	public const uint uint_6 = 2147844096u;

	private Class7()
	{
	}

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int SHCreateItemFromParsingName([MarshalAs(UnmanagedType.LPWStr)] string string_0, IntPtr intptr_0, ref Guid guid_0, [MarshalAs(UnmanagedType.Interface)] ref Interface1 interface1_0);
}
