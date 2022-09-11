namespace game;

internal class Class7
{
	public readonly int int_0;

	public readonly int int_1;

	public Class7(int int_2, int int_3)
	{
		int_0 = int_2;
		int_1 = int_3;
	}

	public bool method_0(Class9 class9_0)
	{
		return class9_0.int_0 >= 0 && class9_0.int_0 < int_0 && class9_0.int_1 >= 0 && class9_0.int_1 < int_1;
	}
}
