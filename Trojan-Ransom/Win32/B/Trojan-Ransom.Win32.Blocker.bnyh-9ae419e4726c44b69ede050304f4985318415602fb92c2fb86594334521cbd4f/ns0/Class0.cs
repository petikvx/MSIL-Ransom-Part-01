namespace ns0;

internal static class Class0
{
	public struct Struct0
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

	protected Class0()
	{
		Exception1.smethod_6();
	}

	public static uint smethod_0(uint uint_0)
	{
		uint_0 -= 2;
		if (uint_0 < 4)
		{
			uint result = uint_0;
			GClass2.smethod_8();
			return result;
		}
		return 3u;
	}
}
