namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -804164325;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB15EE7Du) % 4u)
				{
				case 2u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -429494657) ^ -1492748722;
					continue;
				case 1u:
					num = ((int)num2 * -401222907) ^ 0x46B89EEC;
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
