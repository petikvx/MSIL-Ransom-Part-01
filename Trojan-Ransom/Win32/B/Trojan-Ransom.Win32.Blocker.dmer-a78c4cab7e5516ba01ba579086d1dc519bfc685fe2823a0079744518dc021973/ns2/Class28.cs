using ns4;
using ns6;

namespace ns2;

internal sealed class Class28 : Class27
{
	protected override void vmethod_2(EventArgs2 eventArgs2_0)
	{
		eventArgs2_0.method_2(bool_3: true);
	}

	protected override void vmethod_0(EventArgs1 eventArgs1_0)
	{
		for (int i = 0; i < 3; i++)
		{
			if (eventArgs1_0.method_4())
			{
				break;
			}
		}
		eventArgs1_0.method_3(bool_4: true);
	}

	protected override void vmethod_1(EventArgs0 eventArgs0_0)
	{
		throw eventArgs0_0.method_0();
	}

	public static bool smethod_3()
	{
		Class27.smethod_0(new Class28());
		return true;
	}
}
