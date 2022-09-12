namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -912495924;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB506B46Du) % 4u)
				{
				case 1u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -745313453) ^ 0x7AFD3016;
					continue;
				case 0u:
					num = ((int)num2 * -1118837297) ^ 0x28A3F21E;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
