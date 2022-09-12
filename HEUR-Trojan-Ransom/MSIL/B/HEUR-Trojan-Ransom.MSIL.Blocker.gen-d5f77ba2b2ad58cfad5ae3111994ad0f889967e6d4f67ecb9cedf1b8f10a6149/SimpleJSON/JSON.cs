namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1484334670;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDCE50AE0u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1715096529) ^ 0x47BE7DF0;
					continue;
				case 2u:
					result = JSONNode.Parse(aJSON);
					num = (int)(num2 * 19820418) ^ -2033583393;
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
