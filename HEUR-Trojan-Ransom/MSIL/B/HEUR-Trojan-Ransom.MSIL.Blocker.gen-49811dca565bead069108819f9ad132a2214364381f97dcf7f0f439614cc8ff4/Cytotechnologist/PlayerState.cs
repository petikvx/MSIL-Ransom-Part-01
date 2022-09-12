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
			int num = -814212829;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAED58269u) % 4u)
				{
				case 2u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -1836361622) ^ 0x369E5880;
					continue;
				case 1u:
					num = (int)((num2 * 812081582) ^ 0x28BEE478);
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

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
