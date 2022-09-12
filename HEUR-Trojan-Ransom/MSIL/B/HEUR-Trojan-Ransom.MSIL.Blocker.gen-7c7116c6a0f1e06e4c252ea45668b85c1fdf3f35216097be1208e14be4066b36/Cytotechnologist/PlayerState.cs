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
			int num = -1525177096;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA5F5C59u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1056623995) ^ 0x432ADA14;
					continue;
				case 1u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = (int)(num2 * 1626505798) ^ -331611572;
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
