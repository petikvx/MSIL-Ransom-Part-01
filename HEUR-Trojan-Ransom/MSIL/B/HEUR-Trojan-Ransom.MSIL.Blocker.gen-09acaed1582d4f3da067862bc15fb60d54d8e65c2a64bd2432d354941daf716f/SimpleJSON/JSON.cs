namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = JSONNode.Parse(aJSON);
		while (true)
		{
			int num = -1507786391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5970569u) % 3u)
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
				num = ((int)num2 * -388496952) ^ -1414223587;
			}
		}
	}
}
