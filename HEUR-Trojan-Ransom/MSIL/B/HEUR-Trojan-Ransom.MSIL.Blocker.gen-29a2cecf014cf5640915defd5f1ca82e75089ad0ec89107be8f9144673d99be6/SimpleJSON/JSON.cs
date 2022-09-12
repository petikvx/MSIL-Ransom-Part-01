namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = JSONNode.Parse(aJSON);
		while (true)
		{
			int num = 683481297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69B1BD75u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = (int)((num2 * 1118963497) ^ 0x73B8F7C5);
			}
		}
	}
}
