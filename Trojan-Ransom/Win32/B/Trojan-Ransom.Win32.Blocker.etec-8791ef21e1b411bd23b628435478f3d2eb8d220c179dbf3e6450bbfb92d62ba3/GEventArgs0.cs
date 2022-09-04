using System.Windows.Forms;

public sealed class GEventArgs0 : MouseEventArgs
{
	private bool bool_0;

	public GEventArgs0(MouseButtons mouseButtons_0, int int_0, int int_1, int int_2, int int_3)
		: base(mouseButtons_0, int_0, int_1, int_2, int_3)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)


	internal GEventArgs0(MouseEventArgs mouseEventArgs_0)
		: base(mouseEventArgs_0.get_Button(), mouseEventArgs_0.get_Clicks(), mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y(), mouseEventArgs_0.get_Delta())
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)


	public bool method_0()
	{
		return bool_0;
	}

	public void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}
}
