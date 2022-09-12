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
			int num = 1010808150;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D97C371u) % 4u)
				{
				case 3u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = (int)((num2 * 1693937219) ^ 0x7334D7A0);
					continue;
				case 0u:
					num = ((int)num2 * -388018899) ^ 0x78A5B530;
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
