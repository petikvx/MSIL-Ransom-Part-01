namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1152022146;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE32EA4CDu) % 4u)
				{
				case 3u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -1867720030) ^ -895126889;
					continue;
				case 0u:
					num = ((int)num2 * -1445000024) ^ 0x40762E28;
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
