using ns13;
using ns8;

namespace ns3;

internal sealed class Class52 : Class50
{
	public bool HasData => bool_0;

	public ulong RecordsAffected => ulong_0;

	public ulong AutoIncrementValue => ulong_1;

	internal Class52(Class79 class79_1)
		: base(class79_1)
	{
	}

	public bool method_9()
	{
		if (!bool_1)
		{
			return false;
		}
		bool_0 = base.Protocol.vmethod_2(this);
		method_1();
		bool_2 = !bool_0;
		int_0 = -1;
		list_2.Clear();
		return bool_0;
	}
}
