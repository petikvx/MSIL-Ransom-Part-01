using System.Windows.Forms;

internal class Class19
{
	private MouseButtons mouseButtons_0;

	public Class19()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		mouseButtons_0 = (MouseButtons)0;
	}

	public void method_0(MouseButtons element)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		mouseButtons_0 = (MouseButtons)(mouseButtons_0 | element);
	}

	public void method_1(MouseButtons element)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		mouseButtons_0 = (MouseButtons)(mouseButtons_0 & ~element);
	}

	public bool method_2(MouseButtons element)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		return (mouseButtons_0 & element) > 0;
	}
}