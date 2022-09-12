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
			int num = 2075552594;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x728CC932u) % 3u)
				{
				case 1u:
					goto IL_002e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_002e:
				num = ((int)num2 * -1519913233) ^ 0x232DE7E4;
			}
		}
	}

	public PlayerState()
	{
		while (true)
		{
			int num = -1127648807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B865F3Du) % 3u)
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
				num = (int)((num2 * 45175565) ^ 0x1DFEE763);
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
