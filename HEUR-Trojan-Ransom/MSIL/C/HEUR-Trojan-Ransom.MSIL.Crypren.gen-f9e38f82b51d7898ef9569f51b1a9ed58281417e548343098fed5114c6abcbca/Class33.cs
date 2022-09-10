using System;

internal class Class33
{
	private int[] int_0;

	private int int_1;

	public int Int32_0 => int_1;

	public int this[int index] => int_0[index];

	public Class33()
	{
		int_0 = new int[16];
	}

	public int method_0(int int_2)
	{
		if (int_1 == int_0.Length)
		{
			int[] destinationArray = new int[int_1 * 2];
			Array.Copy(int_0, 0, destinationArray, 0, int_1);
			int_0 = destinationArray;
		}
		int_0[int_1] = int_2;
		return int_1++;
	}

	public int[] method_1()
	{
		int[] array = new int[int_1];
		Array.Copy(int_0, 0, array, 0, int_1);
		return array;
	}
}
