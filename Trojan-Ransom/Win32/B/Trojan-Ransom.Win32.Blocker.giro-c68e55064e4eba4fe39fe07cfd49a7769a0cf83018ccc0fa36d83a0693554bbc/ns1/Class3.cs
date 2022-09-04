namespace ns1;

internal abstract class Class3
{
	public struct Struct3
	{
		public uint uint_0;

		public void method_0()
		{
			uint_0 = 0u;
		}

		public void method_1()
		{
			if (uint_0 < 4)
			{
				uint_0 = 0u;
			}
			else if (uint_0 < 10)
			{
				uint_0 -= 3u;
			}
			else
			{
				uint_0 -= 6u;
			}
		}

		public void method_2()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void method_3()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public void method_4()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public bool method_5()
		{
			return uint_0 < 7;
		}
	}

	public const uint uint_0 = 4u;

	public const uint uint_1 = 12u;

	public const int int_0 = 6;

	public const int int_1 = 0;

	public const int int_2 = 2;

	public const uint uint_2 = 4u;

	public const uint uint_3 = 2u;

	public const int int_3 = 4;

	public const uint uint_4 = 16u;

	public const uint uint_5 = 15u;

	public const uint uint_6 = 4u;

	public const uint uint_7 = 14u;

	public const uint uint_8 = 10u;

	public const uint uint_9 = 128u;

	public const uint uint_10 = 4u;

	public const uint uint_11 = 8u;

	public const int int_4 = 4;

	public const uint uint_12 = 16u;

	public const int int_5 = 4;

	public const uint uint_13 = 16u;

	public const int int_6 = 3;

	public const int int_7 = 3;

	public const int int_8 = 8;

	public const uint uint_14 = 8u;

	public const uint uint_15 = 8u;

	public const uint uint_16 = 272u;

	public const uint uint_17 = 273u;

	public static uint smethod_0(uint uint_18)
	{
		uint_18 -= 2;
		if (uint_18 < 4)
		{
			return uint_18;
		}
		return 3u;
	}
}
