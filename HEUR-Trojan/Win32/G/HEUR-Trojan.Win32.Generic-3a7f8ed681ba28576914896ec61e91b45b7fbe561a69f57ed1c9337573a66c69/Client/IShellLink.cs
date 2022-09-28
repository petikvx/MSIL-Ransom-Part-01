using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Client;

[ComImport]
[Guid("000214F9-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IShellLink
{
	void imethod_0([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, out IntPtr intptr_0, int int_1);

	void imethod_1(out IntPtr intptr_0);

	void imethod_2(IntPtr intptr_0);

	void imethod_3([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	void imethod_5([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	void imethod_7([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	void imethod_9(out short short_0);

	void imethod_10(short short_0);

	void imethod_11(out int int_0);

	void imethod_12(int int_0);

	void imethod_13([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, out int int_1);

	void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

	void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

	void imethod_16(IntPtr intptr_0, int int_0);

	void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
}
