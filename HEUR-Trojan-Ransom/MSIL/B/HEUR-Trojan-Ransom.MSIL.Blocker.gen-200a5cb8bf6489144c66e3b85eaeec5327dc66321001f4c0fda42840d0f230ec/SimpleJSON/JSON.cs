namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1473221146;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E492DDAu) % 3u)
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
				num = (int)(num2 * 2032420030) ^ -716005332;
			}
		}
	}
}
