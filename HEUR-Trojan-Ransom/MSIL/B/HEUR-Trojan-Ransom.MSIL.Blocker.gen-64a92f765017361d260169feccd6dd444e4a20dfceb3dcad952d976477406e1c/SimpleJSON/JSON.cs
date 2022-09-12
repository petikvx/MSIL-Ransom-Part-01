namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -158662860;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9942E73Eu) % 4u)
				{
				case 2u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -840501640) ^ -700933657;
					continue;
				case 1u:
					num = (int)(num2 * 1482017350) ^ -652922949;
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
