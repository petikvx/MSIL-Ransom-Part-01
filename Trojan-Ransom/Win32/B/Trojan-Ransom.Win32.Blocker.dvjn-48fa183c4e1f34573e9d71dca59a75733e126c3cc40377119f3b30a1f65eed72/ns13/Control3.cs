using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns10;

namespace ns13;

[DesignerCategory("Code")]
internal class Control3 : Control
{
	internal int int_0;

	private readonly Bitmap bitmap_0;

	private readonly Bitmap bitmap_1;

	internal readonly Timer timer_0;

	private float float_0;

	private float float_1;

	void Control.OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			Class12.smethod_70(((Control)this).get_Visible(), this);
		}
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		float_0 = dx;
		float_1 = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.Dispose(bool disposing)
	{
		int num = 3;
		if (EdSWDaRXRd5WhpPo7Tq())
		{
			goto IL_000d;
		}
		goto IL_0042;
		IL_0042:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				if (disposing)
				{
					break;
				}
				goto IL_0073;
			default:
				num = 1;
				if (WHql3ZRuSfMY2ZtHbx0())
				{
					continue;
				}
				goto case 0;
			case 2:
			case 5:
				goto IL_0068;
			case 1:
				goto IL_0073;
			case 6:
				return;
			}
			break;
		}
		goto IL_000d;
		IL_0073:
		((Control)this).Dispose(disposing);
		return;
		IL_0068:
		((Component)(object)timer_0).Dispose();
		goto IL_0073;
		IL_000d:
		if (bitmap_0 == null)
		{
			goto IL_0068;
		}
		((Image)bitmap_0).Dispose();
		num = 5;
		if (WHql3ZRuSfMY2ZtHbx0())
		{
			goto IL_0042;
		}
		goto IL_0073;
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		while (true)
		{
			((Control)this).OnPaint(e);
			if (!WHql3ZRuSfMY2ZtHbx0())
			{
				return;
			}
			switch (0)
			{
			case 2:
				continue;
			case 0:
			case 1:
				if (bitmap_1 == null)
				{
					break;
				}
				goto case 5;
			case 5:
				e.get_Graphics().DrawImage((Image)(object)bitmap_1, new Rectangle(0, 0, Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
				break;
			case 6:
				return;
			}
			break;
		}
		if (bitmap_0 != null && int_0 > 0)
		{
			e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
			e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int_0 += 11;
			while (true)
			{
				if (int_0 > 198)
				{
					int_0 = 0;
				}
				while (true)
				{
					((Control)this).Refresh();
					if (!EdSWDaRXRd5WhpPo7Tq())
					{
						switch (5)
						{
						case 4:
							goto end_IL_0003;
						case 0:
						case 3:
							goto end_IL_003d;
						case 5:
							return;
						}
						continue;
					}
					return;
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_003d:
				break;
			}
		}
	}

	public Control3()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		while (true)
		{
			int_0 = 99;
			if (WHql3ZRuSfMY2ZtHbx0())
			{
				switch (5)
				{
				case 0:
					break;
				case 5:
					bitmap_0 = Class12.smethod_91(Class32.smethod_0(6716));
					bitmap_1 = Class12.smethod_91(Class32.smethod_0(6725));
					timer_0 = new Timer();
					goto case 1;
				case 1:
					float_0 = 1f;
					goto IL_007f;
				default:
					goto IL_007f;
				case 2:
				case 4:
					goto end_IL_0001;
				case 7:
					return;
				}
				continue;
			}
			goto IL_007f;
			IL_007f:
			float_1 = 1f;
			((Control)this)._002Ector();
			timer_0.set_Interval(85);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			break;
			continue;
			end_IL_0001:
			break;
		}
		((Control)this).set_Size(new Size(250, 42));
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}

	internal static bool WHql3ZRuSfMY2ZtHbx0()
	{
		return true;
	}

	internal static bool EdSWDaRXRd5WhpPo7Tq()
	{
		return false;
	}
}
