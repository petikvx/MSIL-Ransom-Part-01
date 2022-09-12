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
			int num = -1769077247;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6E9C172u) % 3u)
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
				num = ((int)num2 * -677012398) ^ -1994072153;
			}
		}
	}

	public PlayerState()
	{
		while (true)
		{
			int num = 1316736185;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18CD2803u) % 3u)
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
				num = ((int)num2 * -108980616) ^ -2064646207;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
