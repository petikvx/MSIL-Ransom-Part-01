namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -810943535;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD753AD9Du) % 3u)
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
				num = (int)((num2 * 793319060) ^ 0x382538B7);
			}
		}
	}
}
