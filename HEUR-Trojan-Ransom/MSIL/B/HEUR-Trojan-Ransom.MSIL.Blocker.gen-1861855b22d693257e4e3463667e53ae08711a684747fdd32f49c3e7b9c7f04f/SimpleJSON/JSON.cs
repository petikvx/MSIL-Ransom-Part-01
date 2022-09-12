namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 964046363;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E36A92Eu) % 3u)
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
				num = ((int)num2 * -1229002939) ^ 0x4F74AFB7;
			}
		}
	}
}
