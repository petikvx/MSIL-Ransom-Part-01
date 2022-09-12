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
			int num = 937697049;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C1B1240u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = PlayerState.smethod_0("sprint: {0}, resources: {1}, state: {2}", (object)Sprint, (object)Resources, (object)State);
				num = (int)(num2 * 620010878) ^ -1395178651;
			}
		}
	}

	public PlayerState()
	{
		while (true)
		{
			int num = 562618676;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6688C1CDu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -896593880) ^ -440183153;
			}
		}
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
