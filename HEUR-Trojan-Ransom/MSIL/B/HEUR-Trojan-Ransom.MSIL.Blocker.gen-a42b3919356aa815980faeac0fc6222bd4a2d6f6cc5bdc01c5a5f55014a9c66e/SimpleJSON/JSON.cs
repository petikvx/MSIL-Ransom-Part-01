namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1083382176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC9654A7u) % 4u)
				{
				case 3u:
					result = JSONNode.Parse(aJSON);
					num = (int)((num2 * 587986043) ^ 0x334F4E7);
					continue;
				case 1u:
					num = ((int)num2 * -1587436106) ^ 0x77390AC3;
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
