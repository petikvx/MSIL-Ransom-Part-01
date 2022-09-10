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
		while (true)
		{
			base._002Ector();
			while (true)
			{
				IL_0035:
				object_0 = o;
				type_0 = t;
				while (true)
				{
					bool_0 = firstLevel;
					if (!OmEJqEZH5T4XmDHgDoE())
					{
						break;
					}
					switch (5)
					{
					case 1:
					case 3:
						goto IL_0035;
					case 4:
						goto end_IL_0003;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				break;
			}
		}
	}

	internal static bool OmEJqEZH5T4XmDHgDoE()
	{
		return true;
	}

	internal static bool d3hc7FZgUMFgrnBUAue()
	{
		return false;
	}
}
