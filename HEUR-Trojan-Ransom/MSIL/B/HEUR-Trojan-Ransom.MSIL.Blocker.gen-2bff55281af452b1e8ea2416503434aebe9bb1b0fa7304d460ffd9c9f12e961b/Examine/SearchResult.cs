using System.Collections.Generic;
using System.Linq;

namespace Examine;

public class SearchResult
{
	public int Id { get; set; }

	public float Score { get; set; }

	public IDictionary<string, string> Fields { get; protected set; }

	internal IDictionary<string, List<string>> MultiValueFields { get; private set; }

	public KeyValuePair<string, string> this[int resultIndex] => Fields.ElementAt(resultIndex);

	public string this[string key] => Fields[key];

	public SearchResult()
	{
		Fields = new Dictionary<string, string>();
		MultiValueFields = new Dictionary<string, List<string>>();
	}

	public IEnumerable<string> GetValues(string key)
	{
		if (!MultiValueFields.ContainsKey(key))
		{
			if (!Fields.ContainsKey(key))
			{
				return Enumerable.Empty<string>();
			}
			return new string[1] { Fields[key] };
		}
		return MultiValueFields[key];
	}

	public override bool Equals(object obj)
	{
		if (obj != null && !(GetType() != obj.GetType()))
		{
			SearchResult searchResult = (SearchResult)obj;
			return Id.Equals(searchResult.Id);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Id.GetHashCode();
	}
}
