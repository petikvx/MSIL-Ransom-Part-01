namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1371171800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCFDEA69u) % 4u)
				{
				case 1u:
					result = JSONNode.Parse(aJSON);
					num = (int)(num2 * 1451824367) ^ -148653902;
					continue;
				case 0u:
					num = (int)((num2 * 2130320269) ^ 0x772CF0C3);
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
