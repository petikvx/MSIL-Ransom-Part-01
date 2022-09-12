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
			int num = -592714237;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9D53A8F2u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -168783337) ^ 0x1B0E8308;
					continue;
				case 1u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = (int)((num2 * 953971544) ^ 0x2E156B20);
					continue;
				case 3u:
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
