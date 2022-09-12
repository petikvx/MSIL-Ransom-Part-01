namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1558699494;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85935CB7u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 818018833) ^ -358947194;
					continue;
				case 1u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -1000138782) ^ -723673917;
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
