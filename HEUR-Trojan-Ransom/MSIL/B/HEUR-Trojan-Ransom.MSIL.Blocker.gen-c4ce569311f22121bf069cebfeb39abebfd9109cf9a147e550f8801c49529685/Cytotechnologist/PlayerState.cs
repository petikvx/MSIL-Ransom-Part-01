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
			int num = -896045462;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88CF2E21u) % 4u)
				{
				case 3u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -2109731432) ^ -1541398636;
					continue;
				case 1u:
					num = (int)((num2 * 326957587) ^ 0x78EBE738);
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
			int num = 205172356;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x815F172u) % 3u)
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
				num = (int)(num2 * 750870360) ^ -1519806032;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
