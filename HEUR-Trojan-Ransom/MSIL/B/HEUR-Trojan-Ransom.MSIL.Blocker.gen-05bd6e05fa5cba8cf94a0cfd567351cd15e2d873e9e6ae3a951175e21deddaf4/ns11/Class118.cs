using ns10;
using ns5;

namespace ns11;

internal class Class118 : Class115
{
	public Class118(bool bool_3, bool bool_4)
	{
		base.ProcessDictionaryKeys = bool_3;
		base.OverrideSpecifiedNames = bool_4;
	}

	public Class118(bool bool_3, bool bool_4, bool bool_5)
		: this(bool_3, bool_4)
	{
		base.ProcessExtensionDataNames = bool_5;
	}

	public Class118()
	{
	}

	protected override string vmethod_3(string string_0)
	{
		return Class4.smethod_35(string_0);
	}
}
