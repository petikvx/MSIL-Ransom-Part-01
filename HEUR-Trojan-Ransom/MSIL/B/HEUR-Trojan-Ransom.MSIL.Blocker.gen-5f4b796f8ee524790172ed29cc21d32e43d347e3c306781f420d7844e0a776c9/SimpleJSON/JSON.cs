namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1909831210;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4992E3Du) % 4u)
				{
				case 3u:
					result = JSONNode.Parse(aJSON);
					num = ((int)num2 * -949163806) ^ 0x4657E9F2;
					continue;
				case 1u:
					num = (int)(num2 * 946057726) ^ -1230350951;
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
