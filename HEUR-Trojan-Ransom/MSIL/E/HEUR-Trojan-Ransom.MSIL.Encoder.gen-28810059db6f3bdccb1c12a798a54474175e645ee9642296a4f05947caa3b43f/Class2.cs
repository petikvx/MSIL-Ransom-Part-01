internal abstract class Class2
{
	public struct Struct2
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

	public const uint uint_0 = 12u;

	public const int int_0 = 6;

	private const int int_1 = 2;

	public const uint uint_1 = 4u;

	public const uint uint_2 = 2u;

	public const int int_2 = 4;

	public const uint uint_3 = 4u;

	public const uint uint_4 = 14u;

	public const uint uint_5 = 128u;

	public const int int_3 = 4;

	public const uint uint_6 = 16u;

	public const int int_4 = 3;

	public const int int_5 = 3;

	public const int int_6 = 8;

	public const uint uint_7 = 8u;

	public const uint uint_8 = 8u;

	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2;
		if (uint_9 < 4)
		{
			return uint_9;
		}
		return 3u;
	}
}
