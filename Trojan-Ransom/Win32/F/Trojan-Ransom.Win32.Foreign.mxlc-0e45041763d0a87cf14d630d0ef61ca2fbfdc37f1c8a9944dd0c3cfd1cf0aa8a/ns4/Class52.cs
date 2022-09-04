using ns0;
using ns6;
using ns7;

namespace ns4;

internal class Class52 : Class51
{
	protected override void vmethod_2(EventArgs2 eventArgs2_0)
	{
		eventArgs2_0.bool_1 = true;
	}

	protected override void vmethod_0(EventArgs1 eventArgs1_0)
	{
		for (int i = 0; i < 3; i++)
		{
			if (Class42.smethod_122(eventArgs1_0))
			{
				break;
			}
		}
		eventArgs1_0.bool_3 = true;
	}

	protected override void vmethod_1(EventArgs0 eventArgs0_0)
	{
		throw eventArgs0_0.exception_0;
	}
}
