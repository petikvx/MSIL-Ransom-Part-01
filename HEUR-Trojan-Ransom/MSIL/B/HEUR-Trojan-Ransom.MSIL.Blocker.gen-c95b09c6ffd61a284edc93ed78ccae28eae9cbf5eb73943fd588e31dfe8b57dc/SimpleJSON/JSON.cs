namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = JSONNode.Parse(aJSON);
		while (true)
		{
			int num = -2000296584;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x816BE63Fu) % 3u)
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
				num = (int)((num2 * 1669467019) ^ 0x6E1FDD47);
			}
		}
	}
}
