namespace Cytotechnologist;

public class PlayerState
{
	public int Sprint;

	public int Resources;

	public State State;

	public override string ToString()
	{
		string result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
		while (true)
		{
			int num = 73299363;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31609609u) % 3u)
				{
				case 2u:
					goto IL_002e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_002e:
				num = (int)((num2 * 60634184) ^ 0x6A33CB6B);
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
