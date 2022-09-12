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
			int num = -658285785;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A0408A1u) % 4u)
				{
				case 2u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -1392179229) ^ -395179122;
					continue;
				case 1u:
					num = (int)(num2 * 1933184818) ^ -1933816364;
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
			int num = 1323112950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CA20589u) % 3u)
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
				num = ((int)num2 * -1797246583) ^ 0x4FDDFED8;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
