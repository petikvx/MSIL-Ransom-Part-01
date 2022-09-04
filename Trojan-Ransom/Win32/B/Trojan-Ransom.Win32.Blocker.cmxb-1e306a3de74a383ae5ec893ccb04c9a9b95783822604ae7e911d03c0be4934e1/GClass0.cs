using System;

public class GClass0
{
	private const string string_0 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	private const string string_1 = "abcdefghijklmnopqrstuvwxyz";

	private const string string_2 = "0123456789";

	private Random random_0;

	public GClass0()
	{
		Class6.smethod_0();
		base._002Ector();
		random_0 = new Random();
	}

	public GClass0(int int_0)
	{
		Class6.smethod_0();
		base._002Ector();
		random_0 = new Random(int_0);
	}

	public virtual string vmethod_0(int int_0)
	{
		return vmethod_1(int_0, bool_0: true, bool_1: true, bool_2: true);
	}

	public virtual string vmethod_1(int int_0, bool bool_0, bool bool_1, bool bool_2)
	{
		char[] array = new char[int_0];
		string text = string.Empty;
		if (bool_0)
		{
			text += "abcdefghijklmnopqrstuvwxyz";
		}
		if (bool_1)
		{
			text += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		}
		if (bool_2)
		{
			text += "0123456789";
		}
		for (int i = 0; i < array.Length; i++)
		{
			int index = random_0.Next(0, text.Length);
			array[i] = text[index];
		}
		return new string(array);
	}
}
