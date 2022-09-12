namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = JSONNode.Parse(aJSON);
		while (true)
		{
			int num = -301744634;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE985E0Fu) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1715614756) ^ 0x18315B2C;
			}
		}
	}
}
