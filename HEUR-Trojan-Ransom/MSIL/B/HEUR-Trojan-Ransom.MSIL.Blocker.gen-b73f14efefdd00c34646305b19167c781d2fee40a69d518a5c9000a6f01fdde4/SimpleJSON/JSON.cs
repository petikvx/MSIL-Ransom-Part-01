namespace SimpleJSON;

public static class JSON
{
	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1733209762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB623D0E5u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONNode.Parse(aJSON);
				num = ((int)num2 * -629312908) ^ 0x672005B7;
			}
		}
	}
}
