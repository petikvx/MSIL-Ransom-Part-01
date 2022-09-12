namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 229227145;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7A835552u) % 4u)
				{
				case 3u:
					result = JSONNode.Parse(aJSON);
					num = (int)(num2 * 255862320) ^ -703847317;
					continue;
				case 1u:
					num = (int)(num2 * 1219716858) ^ -1619148506;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
