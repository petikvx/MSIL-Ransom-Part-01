using ns12;
using ns4;

namespace ns5;

internal sealed class Class185 : Class184
{
	private int int_1;

	public Class185(string string_1, int int_2)
		: base(string_1, int_2)
	{
		int_1 = -1;
	}

	protected internal override Class188 vmethod_0(bool bool_0)
	{
		int num = 0;
		Class188 @class;
		while (true)
		{
			if (num < base.Servers.Count)
			{
				int_1++;
				if (int_1 == base.Servers.Count)
				{
					int_1 = 0;
				}
				@class = base.Servers[int_1];
				if (@class.IsAvailable && (!bool_0 || @class.IsMaster))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return @class;
	}
}
