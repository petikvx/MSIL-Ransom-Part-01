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
			int num = -658996800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0B08E43u) % 4u)
				{
				case 3u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -718472151) ^ -779815000;
					continue;
				case 0u:
					num = (int)((num2 * 1111938487) ^ 0x5E4E3F0A);
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

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
