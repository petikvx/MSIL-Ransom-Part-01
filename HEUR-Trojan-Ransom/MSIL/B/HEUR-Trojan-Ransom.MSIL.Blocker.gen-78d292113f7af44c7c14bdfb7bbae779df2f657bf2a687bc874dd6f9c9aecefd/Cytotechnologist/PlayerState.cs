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
			int num = 1462524501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35A963D0u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -21491822) ^ 0x247A833A;
					continue;
				case 1u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -1437342375) ^ 0x1F7237BE;
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

	public PlayerState()
	{
		while (true)
		{
			int num = 1762559508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F894438u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -783135200) ^ 0x621D4240;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
