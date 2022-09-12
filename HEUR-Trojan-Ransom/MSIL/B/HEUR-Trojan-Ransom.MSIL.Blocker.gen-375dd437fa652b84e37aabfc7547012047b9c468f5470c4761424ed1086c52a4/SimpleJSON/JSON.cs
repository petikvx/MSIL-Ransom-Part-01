namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -357840147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DD33B5Fu) % 4u)
				{
				case 2u:
					result = JSONNode.Parse(aJSON);
					num = (int)(num2 * 1418426091) ^ -1641152;
					continue;
				case 1u:
					num = (int)((num2 * 770239291) ^ 0x32D06F28);
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
