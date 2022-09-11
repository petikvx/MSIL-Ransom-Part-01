internal class Class41 : Class39
{
	private string string_1;

	public string String_1
	{
		get
		{
			if (string_1 == null && 0 == 0)
			{
				string_1 = Delegate497.smethod_0(this).Substring(class44_0.string_2.Length, Delegate497.smethod_0(this).Length - class44_0.string_1.Length - class44_0.string_2.Length - Class84.smethod_0(1)).Trim();
				if (string_1.StartsWith(Class86.smethod_0("\uef44", 61289)) || 1 == 0)
				{
					string_1 = class44_0.string_4 + string_1.Substring(Class84.smethod_0(1), string_1.Length - Class84.smethod_0(1));
				}
			}
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	internal Class41(Class44 class44_1)
		: base(class44_1, (Enum9)Class84.smethod_0(0))
	{
	}
}
