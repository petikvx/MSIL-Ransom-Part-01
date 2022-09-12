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
			int num = 1361100861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30E3196Bu) % 3u)
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
				result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
				num = ((int)num2 * -76609138) ^ -473514349;
			}
		}
	}

	public PlayerState()
	{
		while (true)
		{
			int num = -1740649780;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x804D3286u) % 3u)
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
				num = (int)(num2 * 1159146761) ^ -1626482917;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
