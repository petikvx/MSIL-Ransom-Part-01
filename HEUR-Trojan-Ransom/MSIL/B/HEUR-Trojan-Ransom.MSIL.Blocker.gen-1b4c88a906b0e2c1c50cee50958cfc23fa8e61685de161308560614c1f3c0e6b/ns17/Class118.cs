using ns18;
using ns9;

namespace ns17;

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
		return Class7.smethod_693(string_0);
	}
}
