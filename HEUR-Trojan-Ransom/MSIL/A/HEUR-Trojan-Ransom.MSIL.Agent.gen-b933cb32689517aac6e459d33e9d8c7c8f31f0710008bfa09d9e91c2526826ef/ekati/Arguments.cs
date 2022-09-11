using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace ekati;

public class Arguments
{
	private StringDictionary Parameters;

	public string this[string Param] => Parameters[Param];

	public Arguments(string[] Args)
	{
		Parameters = new StringDictionary();
		Regex regex = new Regex("^-{1,2}|^/|=|:", RegexOptions.IgnoreCase | RegexOptions.Compiled);
		Regex regex2 = new Regex("^['\"]?(.*?)['\"]?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
		string text = null;
		foreach (string input in Args)
		{
			string[] array = regex.Split(input, 3);
			switch (array.Length)
			{
			case 1:
				if (text != null)
				{
					if (!Parameters.ContainsKey(text))
					{
						array[0] = regex2.Replace(array[0], "$1");
						Parameters.Add(text, array[0]);
					}
					text = null;
				}
				break;
			case 2:
				if (text != null && !Parameters.ContainsKey(text))
				{
					Parameters.Add(text, "true");
				}
				text = array[1];
				break;
			case 3:
				if (text != null && !Parameters.ContainsKey(text))
				{
					Parameters.Add(text, "true");
				}
				text = array[1];
				if (!Parameters.ContainsKey(text))
				{
					array[2] = regex2.Replace(array[2], "$1");
					Parameters.Add(text, array[2]);
				}
				text = null;
				break;
			}
		}
		if (text != null && !Parameters.ContainsKey(text))
		{
			Parameters.Add(text, "true");
		}
	}
}
