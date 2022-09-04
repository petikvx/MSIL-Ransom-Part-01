internal class Class9
{
	public static int int_0;

	private int[] int_1;

	private int int_2;

	private int method_0(int int_3)
	{
		return (int_3 % int_0 + int_0) % int_0;
	}

	public Class9(int int_3)
	{
		Class51.smethod_0();
		base._002Ector();
		int_1 = new int[55];
		int[] array = new int[55];
		array[0] = method_0(int_3);
		array[1] = 1;
		for (int i = 2; i < 55; i++)
		{
			array[i] = method_0(array[i - 2] - array[i - 1]);
		}
		for (int j = 0; j < 55; j++)
		{
			int_1[j] = array[34 * (j + 1) % 55];
		}
		int_2 = 54;
		for (int k = 55; k < 220; k++)
		{
			method_1();
		}
	}

	public int method_1()
	{
		int num = method_0(int_1[(int_2 + 1) % 55] - int_1[(int_2 + 32) % 55]);
		int_2 = (int_2 + 1) % 55;
		int_1[int_2] = num;
		return num;
	}

	static Class9()
	{
		Class51.smethod_0();
		int_0 = 1000000000;
	}
}
