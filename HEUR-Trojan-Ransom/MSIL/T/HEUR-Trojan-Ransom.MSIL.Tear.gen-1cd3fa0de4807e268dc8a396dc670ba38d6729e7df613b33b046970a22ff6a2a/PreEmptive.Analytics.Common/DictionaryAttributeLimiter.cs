using System.Collections.Generic;

namespace PreEmptive.Analytics.Common;

public class DictionaryAttributeLimiter : Dictionary<string, Dictionary<string, int>>, IAttributeLimiter
{
	public DictionaryAttributeLimiter()
	{
	}

	public DictionaryAttributeLimiter(IDictionary<string, Dictionary<string, int>> clone)
	{
		foreach (string key in clone.Keys)
		{
			Add(key, new Dictionary<string, int>());
			foreach (string key2 in clone[key].Keys)
			{
				base[key].Add(key2, clone[key][key2]);
			}
		}
	}

	public int? MaxSize(string tagname, string attribute)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				num = 1;
				num2 = num;
				continue;
			default:
			{
				if (1 == 0)
				{
				}
				if (!ContainsKey(tagname))
				{
					break;
				}
				num = -5595;
				int num3 = num;
				num = -5595;
				switch (num3 == num)
				{
				default:
					if (0 == 0)
					{
					}
					num = 3;
					num2 = num;
					continue;
				case false:
				case true:
					break;
				}
				goto IL_0090;
			}
			case 1:
				if (!base[tagname].ContainsKey(attribute))
				{
					break;
				}
				goto IL_0090;
			case 0:
				{
					return base[tagname][attribute];
				}
				IL_0090:
				num = 0;
				num2 = num;
				continue;
			}
			break;
		}
		return null;
	}

	public void Set(string string_0, string attribute, int limit)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				Add(string_0, new Dictionary<string, int>());
				num = 0;
				num2 = num;
				break;
			default:
				if (!ContainsKey(string_0))
				{
					num = 4;
					num2 = num;
					break;
				}
				goto case 0;
			case 0:
				if (1 == 0)
				{
				}
				num = 1;
				num2 = num;
				break;
			case 1:
				if (!base[string_0].ContainsKey(attribute))
				{
					num = 2;
					num2 = num;
					break;
				}
				base[string_0][attribute] = limit;
				return;
			case 2:
			{
				num = -14242;
				int num3 = num;
				num = -14242;
				switch (num3 == num)
				{
				default:
					if (false)
					{
					}
					break;
				case false:
				case true:
					break;
				}
				base[string_0].Add(attribute, limit);
				return;
			}
			}
		}
	}

	public DictionaryAttributeLimiter Clone()
	{
		int num = 7750;
		int num2 = num;
		num = 7750;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return new DictionaryAttributeLimiter(this);
		}
	}
}
