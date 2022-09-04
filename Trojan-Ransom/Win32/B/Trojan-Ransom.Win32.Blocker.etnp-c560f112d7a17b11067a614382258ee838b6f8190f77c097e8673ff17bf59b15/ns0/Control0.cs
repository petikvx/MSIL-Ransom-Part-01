using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control0 : Control
{
	private readonly Label label_0 = new Label();

	private Image image_0;

	private bool bool_0;

	private readonly Timer timer_0 = new Timer();

	private bool bool_1 = true;

	private string string_0 = string.Empty;

	private float float_0 = 1f;

	private float float_1 = 1f;

	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Refresh();
		}
	}

	public Control0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		timer_0.set_Interval(250);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_TabStop(false);
	}

	public Control0(string CO_)
		: this()
	{
		((Control)this).set_Text(Class5.smethod_0(79261) + CO_);
	}

	public void method_0()
	{
		while (true)
		{
			timer_0.set_Enabled(false);
			image_0 = null;
			while (7u != 0)
			{
				if (0 == 0)
				{
					bool_0 = false;
					string_0 = string.Empty;
					if (0 == 0)
					{
						((Control)this).Refresh();
						((Control)this).set_Height(16);
						return;
					}
					continue;
				}
				return;
			}
		}
	}

	public void method_1()
	{
		timer_0.set_Enabled(true);
		image_0 = (Image)(object)Class28.smethod_0(Class5.smethod_0(81859));
		bool_0 = true;
		((Control)this).Refresh();
	}

	public void method_2()
	{
		method_3(string.Empty);
	}

	public void method_3(string CO_)
	{
		if (0 == 0)
		{
			if (-1 == 0)
			{
				goto IL_0019;
			}
			string_0 = CO_;
		}
		timer_0.set_Enabled(false);
		goto IL_0019;
		IL_0019:
		image_0 = (Image)(object)Class28.smethod_0((CO_.Length > 0) ? Class5.smethod_0(81877) : Class5.smethod_0(81872));
		bool_1 = true;
		bool_0 = true;
		if (CO_.Length > 0)
		{
			((Control)this).set_Height(100);
		}
		((Control)this).Refresh();
	}

	protected override void OnResize(EventArgs e)
	{
		while (true)
		{
			((Control)label_0).SetBounds(Convert.ToInt32(22f * float_0), Convert.ToInt32(float_1), ((Control)this).get_Width() - Convert.ToInt32(22f * float_0), ((Control)this).get_Height() - Convert.ToInt32(float_1));
			while (0 == 0)
			{
				((Control)this).OnResize(e);
				if (5u != 0)
				{
					return;
				}
			}
		}
	}

	protected override void ScaleCore(float x, float y)
	{
		if (4 == 0)
		{
			return;
		}
		float_0 = x;
		if (6 == 0)
		{
			return;
		}
		float_1 = y;
		do
		{
			if (0 == 0)
			{
				((Control)this).ScaleCore(x, y);
			}
		}
		while (false);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		while (true)
		{
			((Control)this).OnPaint(e);
			bool designMode = ((Component)this).DesignMode;
			if (4u != 0)
			{
				if (2 == 0)
				{
					goto IL_001a;
				}
				if (designMode)
				{
					image_0 = (Image)(object)Class28.smethod_0(Class5.smethod_0(81859));
					bool_0 = true;
				}
				if (image_0 == null)
				{
					goto IL_006b;
				}
				if (false)
				{
					return;
				}
				designMode = bool_1;
			}
			if (designMode)
			{
				goto IL_0025;
			}
			goto IL_006b;
			IL_006b:
			if (false)
			{
				continue;
			}
			designMode = bool_0;
			goto IL_001a;
			IL_0025:
			e.get_Graphics().DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
			goto IL_006b;
			IL_001a:
			if (!designMode)
			{
				break;
			}
			if (6u != 0)
			{
				((Control)label_0).set_Text((string_0.Length > 0) ? (((Control)this).get_Text() + Class5.smethod_0(81886) + string_0 + Class5.smethod_0(81891)) : ((Control)this).get_Text());
				return;
			}
			goto IL_0025;
		}
		((Control)label_0).set_Text(string.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			if (disposing)
			{
				goto IL_0003;
			}
			goto IL_002a;
			IL_002a:
			((Control)this).Dispose(disposing);
			if (8u != 0)
			{
				break;
			}
			goto IL_001c;
			IL_001c:
			if (false)
			{
				goto IL_0003;
			}
			((Component)(object)timer_0).Dispose();
			goto IL_002a;
			IL_0003:
			if (image_0 != null)
			{
				if ((2 == 0) ? true : false)
				{
					continue;
				}
				image_0.Dispose();
			}
			goto IL_001c;
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool_1 = !bool_1;
		((Control)this).Refresh();
	}
}
