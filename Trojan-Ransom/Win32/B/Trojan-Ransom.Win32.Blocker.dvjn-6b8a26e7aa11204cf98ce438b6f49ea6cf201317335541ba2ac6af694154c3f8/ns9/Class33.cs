using System;

namespace ns9;

internal class Class33
{
	internal readonly Type type_0;

	internal readonly object object_0;

	internal readonly bool bool_0;

	public bool FirstLevel => bool_0;

	public Class33(object o, bool firstLevel)
		: this(o, o?.GetType(), firstLevel)
	{
	}

	public Class33(object o, Type t, bool firstLevel)
	{
		while (true)
		{
			base._002Ector();
			if (!lLlSfrKc0efgEjx9Dh5())
			{
				switch (1)
				{
				case 0:
				case 3:
					continue;
				case 1:
					object_0 = o;
					break;
				case 5:
					return;
				}
			}
			break;
		}
		type_0 = t;
		bool_0 = firstLevel;
	}

	internal static bool j5eWWBKu55e63YMNwKJ()
	{
		return true;
	}

	internal static bool lLlSfrKc0efgEjx9Dh5()
	{
		return false;
	}
}
