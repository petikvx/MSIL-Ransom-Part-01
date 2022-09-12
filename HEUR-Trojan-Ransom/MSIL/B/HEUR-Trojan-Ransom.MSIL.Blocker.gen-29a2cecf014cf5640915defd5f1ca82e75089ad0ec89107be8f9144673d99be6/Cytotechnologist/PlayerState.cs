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
			int num = 1396410928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x190CC8EAu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
				num = (int)((num2 * 1695108195) ^ 0x1FA68B1A);
			}
		}
	}

	public PlayerState()
	{
		while (true)
		{
			int num = 31700893;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x219AF98Bu) % 3u)
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
				num = ((int)num2 * -2049537843) ^ 0x758A4DDD;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
