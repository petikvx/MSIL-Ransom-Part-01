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
			int num = 1437601111;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x165A78B1u) % 4u)
				{
				case 2u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = (int)((num2 * 1715681520) ^ 0x6F9CA2C4);
					continue;
				case 1u:
					num = (int)(num2 * 1090857264) ^ -1533705490;
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
