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
			int num = -162324991;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD88D1D0u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 216159348) ^ 0x1C159388);
					continue;
				case 1u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = (int)(num2 * 2044617585) ^ -1700215814;
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
			int num = 2058717737;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x762B0C65u) % 3u)
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
				num = ((int)num2 * -1027608641) ^ 0x4038D987;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
