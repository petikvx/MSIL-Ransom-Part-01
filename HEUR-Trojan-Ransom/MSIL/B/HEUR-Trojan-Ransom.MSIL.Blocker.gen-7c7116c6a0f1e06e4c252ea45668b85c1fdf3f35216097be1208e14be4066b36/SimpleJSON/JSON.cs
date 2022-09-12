namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = JSONNode.Parse(aJSON);
		while (true)
		{
			int num = -999287866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF7547CDu) % 3u)
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
				num = ((int)num2 * -810540369) ^ 0x5CF280BE;
			}
		}
	}
}
