using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath;

internal class ArrayMultipleIndexFilter : PathFilter
{
	internal List<int> Indexes;

	public ArrayMultipleIndexFilter(List<int> indexes)
	{
		Indexes = indexes;
	}

	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, bool errorWhenNoMatch)
	{
		foreach (JToken t in current)
		{
			foreach (int index in Indexes)
			{
				JToken tokenIndex = PathFilter.GetTokenIndex(t, errorWhenNoMatch, index);
				if (tokenIndex != null)
				{
					yield return tokenIndex;
				}
			}
		}
	}
}
