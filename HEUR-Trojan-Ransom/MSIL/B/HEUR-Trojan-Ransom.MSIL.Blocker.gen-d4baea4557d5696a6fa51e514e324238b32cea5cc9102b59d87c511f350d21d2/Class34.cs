internal abstract class Class34
{
	public struct Struct0
	{
		public uint uint_0;

		public void method_0()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void method_1()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public void method_2()
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

		public void method_3()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public bool method_4()
		{
			return uint_0 < 7;
		}

		public void method_5()
		{
			uint_0 = 0u;
		}
	}

	public static uint smethod_0(uint uint_0)
	{
		uint_0 -= 2;
		if (uint_0 < 4)
		{
			return uint_0;
		}
		return 3u;
	}
}
