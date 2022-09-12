using ns10;
using ns5;

namespace ns0;

internal class Class116 : Class115
{
	public Class116(bool bool_3, bool bool_4)
	{
		base.ProcessDictionaryKeys = bool_3;
		base.OverrideSpecifiedNames = bool_4;
	}

	public Class116(bool bool_3, bool bool_4, bool bool_5)
		: this(bool_3, bool_4)
	{
		base.ProcessExtensionDataNames = bool_5;
	}

	public Class116()
	{
	}

	protected override string vmethod_3(string string_0)
	{
		return Class4.smethod_672(string_0);
	}
}
