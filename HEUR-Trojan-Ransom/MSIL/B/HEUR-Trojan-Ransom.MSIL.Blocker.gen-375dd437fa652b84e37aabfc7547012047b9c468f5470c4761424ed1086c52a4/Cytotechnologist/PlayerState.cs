namespace Cytotechnologist;

public class PlayerState
{
	public int Sprint;

	public int Resources;

	public State State;

	public override string ToString()
	{
		string result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
		while (true)
		{
			int num = 977397046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1754E006u) % 3u)
				{
				case 2u:
					goto IL_002e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_002e:
				num = ((int)num2 * -1961530393) ^ -776001156;
			}
		}
	}

	public PlayerState()
	{
		while (true)
		{
			int num = -816589396;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8F6E97Fu) % 3u)
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
				num = (int)(num2 * 1877594596) ^ -2103297443;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
