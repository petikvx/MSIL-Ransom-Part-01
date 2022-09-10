using System;
using System.IO;
using System.Security;

public interface GInterface3
{
	bool Boolean_0 { get; }

	bool Boolean_1 { get; }

	bool Boolean_2 { get; }

	bool Boolean_3 { get; }

	bool Boolean_4 { get; }

	void imethod_0(GInterface2 ginterface2_0, params object[] object_0);

	void imethod_1(ref string string_0, out string string_1, out string string_2, GInterface2 ginterface2_0, params object[] object_0);

	bool imethod_2(string string_0);

	bool imethod_3(GInterface1 ginterface1_0);

	void imethod_4(GInterface1 ginterface1_0);

	bool imethod_5(string string_0);

	string imethod_6(string string_0);

	string imethod_7(string string_0, string string_1);

	object imethod_8(string string_0);

	Stream imethod_9(string string_0);

	Stream imethod_10(string string_0, bool bool_0);

	Stream imethod_11(string string_0, string string_1, ref object object_0);

	Stream imethod_12(string string_0, string string_1, ref object object_0, bool bool_0);

	void imethod_13(string string_0, bool bool_0, object object_0);

	void imethod_14(string string_0, bool bool_0, object object_0, bool bool_1);

	void imethod_15(string string_0);

	bool imethod_16(string string_0);

	bool imethod_17(string string_0);

	string imethod_18(string string_0, string string_1);

	bool imethod_19(string string_0);

	bool imethod_20(string string_0, GEnum0 genum0_0, GEnum1 genum1_0);

	void imethod_21(string string_0, GEnum0 genum0_0, GEnum1 genum1_0, GInterface0 ginterface0_0);

	bool imethod_22(string string_0);

	bool imethod_23(GInterface1 ginterface1_0);

	void imethod_24(GInterface1 ginterface1_0, out PermissionSet permissionSet_0, out bool bool_0);

	IDisposable imethod_25();

	bool imethod_26(string string_0, string string_1);

	bool imethod_27(string string_0, string string_1);

	object imethod_28(string string_0);

	object imethod_29(string string_0, string string_1);

	Type imethod_30(string string_0, bool bool_0);

	string imethod_31(Type type_0);
}
