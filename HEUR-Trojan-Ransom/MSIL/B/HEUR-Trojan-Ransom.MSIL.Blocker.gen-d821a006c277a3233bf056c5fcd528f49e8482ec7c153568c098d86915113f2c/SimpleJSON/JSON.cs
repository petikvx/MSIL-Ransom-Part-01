namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 264408613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BE8184Bu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2098626023) ^ -430130999;
					continue;
				case 2u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -2040231314) ^ 0x4298EE00;
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
