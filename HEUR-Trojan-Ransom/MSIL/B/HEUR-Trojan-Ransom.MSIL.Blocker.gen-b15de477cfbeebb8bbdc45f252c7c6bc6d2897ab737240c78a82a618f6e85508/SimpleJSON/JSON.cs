namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1206502756;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EE24B2Du) % 3u)
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
				num = ((int)num2 * -1920505958) ^ -402360502;
			}
		}
	}
}
