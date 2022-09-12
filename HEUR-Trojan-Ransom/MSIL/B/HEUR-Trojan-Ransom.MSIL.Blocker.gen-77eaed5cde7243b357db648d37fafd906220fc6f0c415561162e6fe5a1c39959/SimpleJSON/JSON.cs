namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2061212790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8E9E582u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONNode.Parse(aJSON);
				num = (int)((num2 * 791228144) ^ 0x70498F6D);
			}
		}
	}
}
