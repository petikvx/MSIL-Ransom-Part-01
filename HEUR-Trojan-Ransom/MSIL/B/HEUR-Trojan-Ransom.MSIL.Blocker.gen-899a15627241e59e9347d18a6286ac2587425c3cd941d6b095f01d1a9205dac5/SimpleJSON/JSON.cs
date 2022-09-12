namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1714620443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44BB37C2u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1668628181) ^ 0x63075913);
					continue;
				case 1u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -1638008079) ^ -782133179;
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
