using System.Collections.Generic;

namespace ns19;

internal sealed class Class124<T, U>
{
	private readonly int int_0;

	private readonly Queue<T> queue_0;

	private readonly Dictionary<T, U> dictionary_0;

	public U this[T gparam_0]
	{
		get
		{
			if (dictionary_0.TryGetValue(gparam_0, out var value))
			{
				return value;
			}
			return default(U);
		}
		set
		{
			method_1(gparam_0, value);
		}
	}

	public Class124(int int_1, int int_2)
	{
		int_0 = int_2;
		dictionary_0 = new Dictionary<T, U>(int_1);
		if (int_2 > 0)
		{
			queue_0 = new Queue<T>(int_1);
		}
	}

	public void method_0(T gparam_0, U gparam_1)
	{
		method_1(gparam_0, gparam_1);
	}

	private void method_1(T gparam_0, U gparam_1)
	{
		if (!dictionary_0.ContainsKey(gparam_0) && int_0 > 0)
		{
			queue_0.Enqueue(gparam_0);
			if (queue_0.Count > int_0)
			{
				dictionary_0.Remove(queue_0.Dequeue());
			}
		}
		dictionary_0[gparam_0] = gparam_1;
	}
}
