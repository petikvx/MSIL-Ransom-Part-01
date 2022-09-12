namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1265204346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9C80E8Cu) % 3u)
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
				num = ((int)num2 * -1804605019) ^ 0x7DD8E061;
			}
		}
	}
}
