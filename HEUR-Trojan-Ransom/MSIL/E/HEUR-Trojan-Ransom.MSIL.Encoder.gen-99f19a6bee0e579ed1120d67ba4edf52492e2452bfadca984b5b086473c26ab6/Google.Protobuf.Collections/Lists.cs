using System.Collections.Generic;

namespace Google.Protobuf.Collections;

public static class Lists
{
	public static bool Equals<T>(List<T> left, List<T> right)
	{
		if (left == right)
		{
			return true;
		}
		if (left != null && right != null)
		{
			if (left.Count != right.Count)
			{
				return false;
			}
			IEqualityComparer<T> @default = EqualityComparer<T>.Default;
			int num = 0;
			while (true)
			{
				if (num < left.Count)
				{
					if (!@default.Equals(left[num], right[num]))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static int GetHashCode<T>(List<T> list)
	{
		if (list == null)
		{
			return 0;
		}
		int num = 31;
		foreach (T item in list)
		{
			num = num * 29 + item.GetHashCode();
		}
		return num;
	}
}
