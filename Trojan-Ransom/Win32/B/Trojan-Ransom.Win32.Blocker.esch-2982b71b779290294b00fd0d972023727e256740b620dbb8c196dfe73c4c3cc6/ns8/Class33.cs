using ns1;
using ns10;
using ns2;
using ns4;

namespace ns8;

internal sealed class Class33 : Class32
{
	protected override void vmethod_2(EventArgs2 e)
	{
		e.ReportException = true;
	}

	protected override void vmethod_0(EventArgs1 e)
	{
		for (int i = 0; i < 3; i++)
		{
			if (e.method_6())
			{
				break;
			}
		}
		e.TryToContinue = true;
	}

	protected override void vmethod_1(EventArgs0 e)
	{
		throw e.FatalException;
	}

	public static bool smethod_4()
	{
		Class32.smethod_0(new Class33());
		return true;
	}
}
