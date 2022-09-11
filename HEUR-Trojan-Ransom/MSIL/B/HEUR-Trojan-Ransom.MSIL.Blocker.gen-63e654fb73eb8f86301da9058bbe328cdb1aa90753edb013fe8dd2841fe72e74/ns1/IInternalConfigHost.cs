using System;
using System.IO;
using System.Security;

namespace ns1;

public interface IInternalConfigHost
{
	bool SupportsChangeNotifications { get; }

	bool SupportsRefresh { get; }

	bool SupportsPath { get; }

	bool SupportsLocation { get; }

	bool IsRemote { get; }

	void imethod_0(IInternalConfigRoot iinternalConfigRoot_0, params object[] object_0);

	void imethod_1(ref string string_0, out string string_1, out string string_2, IInternalConfigRoot iinternalConfigRoot_0, params object[] object_0);

	bool imethod_2(string string_0);

	bool imethod_3(IInternalConfigRecord iinternalConfigRecord_0);

	void imethod_4(IInternalConfigRecord iinternalConfigRecord_0);

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

	bool imethod_20(string string_0, ConfigurationAllowDefinition configurationAllowDefinition_0, ConfigurationAllowExeDefinition configurationAllowExeDefinition_0);

	void imethod_21(string string_0, ConfigurationAllowDefinition configurationAllowDefinition_0, ConfigurationAllowExeDefinition configurationAllowExeDefinition_0, IConfigErrorInfo iconfigErrorInfo_0);

	bool imethod_22(string string_0);

	bool imethod_23(IInternalConfigRecord iinternalConfigRecord_0);

	void imethod_24(IInternalConfigRecord iinternalConfigRecord_0, out PermissionSet permissionSet_0, out bool bool_0);

	IDisposable imethod_25();

	bool imethod_26(string string_0, string string_1);

	bool imethod_27(string string_0, string string_1);

	object imethod_28(string string_0);

	object imethod_29(string string_0, string string_1);

	Type imethod_30(string string_0, bool bool_0);

	string imethod_31(Type type_0);
}
