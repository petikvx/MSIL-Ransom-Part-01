using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace VjMQkoKRLykc;

internal interface Interface0
{
	int imethod_0(string string_0, int int_0, int int_1, int int_2, out IStream istream_0);

	int imethod_1(string string_0, int int_0, int int_1, int int_2, out IStream istream_0);

	int imethod_2(string string_0, int int_0, int int_1, int int_2, out Interface0 interface0_0);

	int imethod_3(string string_0, Interface0 interface0_0, int int_0, IntPtr intptr_0, int int_1, out Interface0 interface0_1);

	void imethod_4(int int_0, Guid[] guid_0, IntPtr intptr_0, Interface0 interface0_0);

	void imethod_5(string string_0, Interface0 interface0_0, string string_1, int int_0);

	void imethod_6(int int_0);

	void imethod_7();

	void imethod_8(string string_0);

	void imethod_9(string string_0, string string_1);

	void imethod_10(string string_0, FILETIME filetime_0, FILETIME filetime_1, FILETIME filetime_2);

	void imethod_11(ref Guid guid_0);

	void imethod_12(int int_0, int int_1);

	void imethod_13(out STATSTG statstg_0, int int_0);
}
