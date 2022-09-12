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
			int num = 1309559524;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35964562u) % 3u)
				{
				case 1u:
					goto IL_002e;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_002e:
				num = (int)((num2 * 140001018) ^ 0x3E88E28C);
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
