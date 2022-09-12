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
			int num = -1399218816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97C047D5u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1367310799) ^ 0x3F88C53F);
					continue;
				case 1u:
					result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
					num = ((int)num2 * -868142528) ^ 0x3555C33F;
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
