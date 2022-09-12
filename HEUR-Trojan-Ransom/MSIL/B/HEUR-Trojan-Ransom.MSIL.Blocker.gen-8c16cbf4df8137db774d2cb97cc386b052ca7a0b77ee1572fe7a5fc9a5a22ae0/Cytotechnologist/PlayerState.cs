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
			int num = 2062049278;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x570C626Fu) % 4u)
				{
				case 1u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -274875917) ^ -289256552;
					continue;
				case 0u:
					num = (int)(num2 * 1485006456) ^ -1888425879;
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
