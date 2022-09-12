using ns10;
using ns5;

namespace ns4;

internal class Class119 : Class115
{
	public Class119(bool bool_3, bool bool_4)
	{
		base.ProcessDictionaryKeys = bool_3;
		base.OverrideSpecifiedNames = bool_4;
	}

	public Class119(bool bool_3, bool bool_4, bool bool_5)
		: this(bool_3, bool_4)
	{
		base.ProcessExtensionDataNames = bool_5;
	}

	public Class119()
	{
	}

	protected override string vmethod_3(string string_0)
	{
		return Class4.smethod_623(string_0);
	}
}
