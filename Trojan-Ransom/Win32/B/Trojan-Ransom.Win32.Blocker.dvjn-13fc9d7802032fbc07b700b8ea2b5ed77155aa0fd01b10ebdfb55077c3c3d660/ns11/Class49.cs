using System;

namespace ns11;

internal class Class49
{
	internal readonly Type type_0;

	internal readonly object object_0;

	internal readonly bool bool_0;

	public bool FirstLevel => bool_0;

	public Class49(object o, bool firstLevel)
		: this(o, o?.GetType(), firstLevel)
	{
	}

	public Class49(object o, Type t, bool firstLevel)
	{
		int num = 0;
		if (ndpJyQXt5bv5YYSMcbE())
		{
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					if (ndpJyQXt5bv5YYSMcbE())
					{
						continue;
					}
					goto case 0;
				case 0:
					base._002Ector();
					goto case 1;
				case 1:
				case 3:
					object_0 = o;
					break;
				case 2:
				case 4:
					break;
				case 5:
					return;
				}
				break;
			}
		}
		type_0 = t;
		bool_0 = firstLevel;
	}

	internal static bool ndpJyQXt5bv5YYSMcbE()
	{
		return true;
	}

	internal static bool J92SrAX1TWS1qt1hnmU()
	{
		return false;
	}
}
