namespace Cytotechnologist;

public class PlayerState
{
	public int Sprint;

	public int Resources;

	public State State;

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1792696419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF7915C7u) % 4u)
				{
				case 2u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -1862837828) ^ 0x6527D48E;
					continue;
				case 1u:
					num = ((int)num2 * -1067984023) ^ 0x7FBEF4D2;
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

	public PlayerState()
	{
		while (true)
		{
			int num = -578876234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC17FE6E1u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 654935608) ^ -1014251756;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
