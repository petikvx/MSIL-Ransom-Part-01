internal abstract class Class39
{
	internal Class44 class44_0;

	private string string_0;

	internal int int_0;

	internal int int_1;

	private int int_2;

	internal int int_3;

	internal Enum9 enum9_0;

	public string String_0
	{
		get
		{
			if (string_0 == null && 0 == 0)
			{
				string_0 = class44_0.string_0.Substring(int_0, int_1);
			}
			return Delegate497.smethod_0(this);
		}
		internal set
		{
			string_0 = value;
		}
	}

	public Enum9 Enum9_0 => enum9_0;

	public int Int32_0
	{
		get
		{
			return int_2;
		}
		internal set
		{
			int_2 = value;
		}
	}

	public int Int32_1 => int_3;

	public int Int32_2 => int_0;

	internal Class39(Class44 class44_1, Enum9 enum9_1)
	{
		class44_0 = class44_1;
		Enum9 @enum = default(Enum9);
		while (true)
		{
			int num = Class49.smethod_0(94);
			while (true)
			{
				switch (num ^ Class84.smethod_0(413))
				{
				case -106:
					@enum = enum9_1;
					num = -25;
					continue;
				case -107:
					enum9_0 = enum9_1;
					num = -27;
					continue;
				case -108:
					switch (@enum)
					{
					default:
						num = -28;
						continue;
					case Enum9.const_0:
						Delegate496.smethod_0(class44_0.class46_0, this);
						break;
					case Enum9.const_1:
						Delegate496.smethod_0(class44_0.class46_2, this);
						break;
					}
					goto case -105;
				case -109:
					num = Class49.smethod_0(80);
					continue;
				case -105:
					Delegate496.smethod_0(class44_0.class46_1, this);
					return;
				}
				break;
			}
		}
	}
}
