namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = JSONNode.Parse(aJSON);
		while (true)
		{
			int num = 2018670147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50458C3u) % 3u)
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
				num = (int)((num2 * 252262006) ^ 0x3644B2B);
			}
		}
	}
}
