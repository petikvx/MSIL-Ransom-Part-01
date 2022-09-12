namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = JSONNode.Parse(aJSON);
		while (true)
		{
			int num = -1183630690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A0E26DCu) % 3u)
				{
				case 2u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = (int)((num2 * 2011477338) ^ 0x99319F7);
			}
		}
	}
}
