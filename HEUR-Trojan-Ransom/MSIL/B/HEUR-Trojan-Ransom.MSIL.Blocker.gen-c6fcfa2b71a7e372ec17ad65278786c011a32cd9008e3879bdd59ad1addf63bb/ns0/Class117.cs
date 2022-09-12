using ns13;
using ns15;

namespace ns0;

internal class Class117 : Class114
{
	public Class117(bool bool_3, bool bool_4)
	{
		base.ProcessDictionaryKeys = bool_3;
		base.OverrideSpecifiedNames = bool_4;
	}

	public Class117(bool bool_3, bool bool_4, bool bool_5)
		: this(bool_3, bool_4)
	{
		base.ProcessExtensionDataNames = bool_5;
	}

	public Class117()
	{
	}

	protected override string vmethod_3(string string_0)
	{
		return Class131.smethod_238(string_0);
	}
}
