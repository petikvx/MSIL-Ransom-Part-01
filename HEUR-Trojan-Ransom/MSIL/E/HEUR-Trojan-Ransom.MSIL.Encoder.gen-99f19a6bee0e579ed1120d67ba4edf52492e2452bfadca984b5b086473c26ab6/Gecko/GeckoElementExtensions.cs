using System;

namespace Gecko;

public static class GeckoElementExtensions
{
	public static string GetData(this GeckoHtmlElement node, string dataAttributeName)
	{
		if (string.IsNullOrEmpty(dataAttributeName))
		{
			throw new ArgumentException("attributeName");
		}
		return node.GetAttribute("data-" + dataAttributeName);
	}

	public static T FindFirstChildInTree<T>(this GeckoNode element, Predicate<T> predicate) where T : GeckoNode
	{
		int num = 0;
		T val2;
		while (true)
		{
			if (num < element.ChildNodes.Length)
			{
				GeckoNode geckoNode = element.ChildNodes[num];
				if (geckoNode is T val)
				{
					if (predicate(val))
					{
						return val;
					}
					if (val.HasChildNodes)
					{
						val2 = val.FindFirstChildInTree(predicate);
						if (val2 != null)
						{
							break;
						}
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return val2;
	}
}
