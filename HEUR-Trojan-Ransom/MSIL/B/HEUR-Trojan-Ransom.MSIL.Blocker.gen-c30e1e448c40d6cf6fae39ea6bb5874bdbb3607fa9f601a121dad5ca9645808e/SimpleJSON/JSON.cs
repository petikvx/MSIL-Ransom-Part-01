namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1289784602;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20FF5370u) % 4u)
				{
				case 2u:
					result = JSONNode.Parse(aJSON);
					num = (int)(num2 * 313006533) ^ -1989750297;
					continue;
				case 1u:
					num = ((int)num2 * -204477048) ^ 0x12E6A248;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
