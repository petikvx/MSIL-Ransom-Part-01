namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1102447911;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE9F8BDF8u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONNode.Parse(aJSON);
				num = ((int)num2 * -1139607302) ^ 0x51F7A047;
			}
		}
	}
}
