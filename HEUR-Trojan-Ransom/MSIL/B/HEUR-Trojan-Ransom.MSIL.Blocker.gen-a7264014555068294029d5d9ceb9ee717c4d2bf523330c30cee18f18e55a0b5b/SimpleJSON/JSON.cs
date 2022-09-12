namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -451607921;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF964A1AEu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONNode.Parse(aJSON);
				num = (int)(num2 * 964109574) ^ -1169257000;
			}
		}
	}
}
