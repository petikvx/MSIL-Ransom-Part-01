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
			int num = 2060189346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51223791u) % 4u)
				{
				case 3u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -943443814) ^ -1817445554;
					continue;
				case 1u:
					num = (int)((num2 * 649321823) ^ 0x39A6571C);
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

	public PlayerState()
	{
		while (true)
		{
			int num = 1976938014;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x318E7BD4u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1619068120) ^ -1109558702;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
