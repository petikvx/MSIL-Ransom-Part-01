namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 2108580937;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14186283u) % 4u)
				{
				case 2u:
					result = JSONNode.Parse(aJSON);
					num = (int)((num2 * 275445732) ^ 0x5194C0C2);
					continue;
				case 1u:
					num = ((int)num2 * -1336099854) ^ -1551877806;
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
