namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 81751971;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x388EA81Eu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1937213731) ^ -582235201;
					continue;
				case 1u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -1983331410) ^ 0x5DAD3A7B;
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
