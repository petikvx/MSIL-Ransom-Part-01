namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -915047210;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE39C2BBFu) % 3u)
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
				num = ((int)num2 * -870709865) ^ -1150143174;
			}
		}
	}
}
