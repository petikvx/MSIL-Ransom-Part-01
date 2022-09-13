using System.Text.RegularExpressions;

internal sealed class Class51
{
	public string string_0;

	public Class51(string data)
	{
		string_0 = data;
	}

	public string method_0(string string_1)
	{
		string empty = string.Empty;
		Match match = new Regex("\"" + string_1 + "\":\"([^\"]+)\"").Match(string_0);
		if (!match.Success)
		{
			return empty;
		}
		return Regex.Split(match.Value, "\"")[3];
	}

	public void method_1(string[] string_1)
	{
		foreach (string oldValue in string_1)
		{
			string_0 = string_0.Replace(oldValue, "");
		}
	}

	public string[] method_2(string string_1 = "},")
	{
		return Regex.Split(string_0, string_1);
	}
}
