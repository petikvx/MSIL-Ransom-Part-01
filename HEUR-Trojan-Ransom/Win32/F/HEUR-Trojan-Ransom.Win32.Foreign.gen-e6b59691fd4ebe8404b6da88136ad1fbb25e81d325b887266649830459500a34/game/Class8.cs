namespace game;

internal class Class8
{
	private readonly Class10[] class10_0;

	public int Int32_0 => class10_0.Length;

	public Class8(Class10[] class10_1)
	{
		class10_0 = class10_1;
	}

	public Class10 method_0(int int_0)
	{
		return (int_0 < class10_0.Length) ? class10_0[int_0] : null;
	}

	public bool method_1(Class10 class10_1)
	{
		Class10[] array = class10_0;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Class10 obj = array[num];
				if (class10_1.Equals(obj))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return true;
	}
}
