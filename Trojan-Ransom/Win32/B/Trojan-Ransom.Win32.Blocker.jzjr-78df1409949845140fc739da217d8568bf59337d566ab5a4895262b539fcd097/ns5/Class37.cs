using ns2;
using ns3;

namespace ns5;

internal sealed class Class37 : Class36
{
	protected override void vmethod_2(EventArgs2 eventArgs2_0)
	{
		eventArgs2_0.ReportException = true;
	}

	protected override void vmethod_0(EventArgs1 eventArgs1_0)
	{
		for (int i = 0; i < 3; i++)
		{
			if (eventArgs1_0.method_6())
			{
				break;
			}
		}
		eventArgs1_0.TryToContinue = true;
	}

	protected override void vmethod_1(EventArgs0 eventArgs0_0)
	{
		throw eventArgs0_0.FatalException;
	}

	public static bool smethod_4()
	{
		Class36.smethod_0(new Class37());
		return true;
	}
}
