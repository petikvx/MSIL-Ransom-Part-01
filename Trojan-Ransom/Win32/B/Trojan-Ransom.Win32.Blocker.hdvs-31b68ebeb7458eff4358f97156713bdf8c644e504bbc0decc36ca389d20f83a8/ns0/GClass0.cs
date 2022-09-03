using System;

namespace ns0;

public class GClass0
{
	private const string string_0 = "abcdefghijklmnopqrstuvwxyz";

	private const string string_1 = "0123456789";

	private const string string_2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	private Random random_0;

	public GClass0()
	{
		random_0 = new Random();
	}

	public GClass0(int int_0)
	{
		random_0 = new Random(int_0);
	}

	public virtual string NextString(int int_0)
	{
		return NextString(int_0, bool_0: true, bool_1: true, bool_2: true);
	}

	public virtual string NextString(int int_0, bool bool_0, bool bool_1, bool bool_2)
	{
		char[] array = new char[int_0];
		string text = string.Empty;
		if (bool_0)
		{
			text += GClass2.smethod_0("{Żɻͳѳճٳݻ\u087bॻ\u0a7b\u0b63\u0c63\u0d63\u0e63\u0f7bၻᅻቻ፳ᑳᕳᙳ\u177b\u187b\u197b");
		}
		if (bool_1)
		{
			text += GClass2.smethod_0("[śɛ\u0353ѓՓ\u0653ݛ\u085bज़ਜ਼\u0b43\u0c43\u0d43ใཛၛᅛቛፓᑓᕓᙓ\u175bᡛᥛ");
		}
		if (bool_2)
		{
			text += GClass2.smethod_0(":ĸȺ\u0334в\u0530ز\u0734࠺स");
		}
		for (int i = 0; i < array.Length; i++)
		{
			int index = random_0.Next(0, text.Length);
			array[i] = text[index];
		}
		return new string(array);
	}
}
