using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

[DefaultEvent("CheckedChanged")]
public class GControl5 : GControl2
{
	public delegate void GDelegate0(object sender);

	private bool bool_6;

	private int int_2;

	private GDelegate0 gdelegate0_0;

	public bool Boolean_3
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_6;
		}
		set
		{
			bool_6 = value;
			int num = 0;
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						gdelegate0_0(this);
						num = 3;
						break;
					}
					return;
				case 1:
					flag = gdelegate0_0 == null;
					num = 2;
					break;
				case 0:
					((Control)this).Invalidate();
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public event GDelegate0 Event_0
	{
		add
		{
			GDelegate0 gDelegate = gdelegate0_0;
			bool flag = default(bool);
			GDelegate0 value2 = default(GDelegate0);
			do
			{
				GDelegate0 gDelegate2 = gDelegate;
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 2:
						flag = (object)gDelegate != gDelegate2;
						num = 3;
						continue;
					case 1:
						gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
						num = 2;
						continue;
					case 0:
						value2 = (GDelegate0)Delegate.Combine(gDelegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while (flag);
		}
		remove
		{
			GDelegate0 gDelegate = gdelegate0_0;
			bool flag = default(bool);
			GDelegate0 value2 = default(GDelegate0);
			do
			{
				GDelegate0 gDelegate2 = gDelegate;
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 2:
						flag = (object)gDelegate != gDelegate2;
						num = 3;
						continue;
					case 1:
						gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
						num = 2;
						continue;
					case 0:
						value2 = (GDelegate0)Delegate.Remove(gDelegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while (flag);
		}
	}

	public GControl5()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		((Control)this).set_Size(new Size(16, 50));
	}

	protected override void vmethod_0()
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		int num = 0;
		int num2 = default(int);
		SizeF sizeF = default(SizeF);
		while (true)
		{
			switch (num)
			{
			case 3:
				((Control)this).set_Width(20 + num2);
				num = 4;
				break;
			case 2:
				num2 = (int)sizeF.Width;
				num = 3;
				break;
			case 1:
				sizeF = ((Control)this).CreateGraphics().MeasureString(((Control)this).get_Text(), ((Control)this).get_Font());
				num = 2;
				break;
			case 0:
				num2 = 0;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				((Control)this).Invalidate();
				num = 2;
				break;
			case 0:
				int_2 = e.get_X();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!flag)
				{
					bool_6 = false;
					num = 2;
					break;
				}
				bool_6 = true;
				return;
			case 0:
				flag = !bool_6;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_1()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(60, 60, 60));
		int num = 0;
		bool flag = default(bool);
		HatchBrush val3 = default(HatchBrush);
		ColorBlend val2 = default(ColorBlend);
		HatchBrush val = default(HatchBrush);
		while (true)
		{
			switch (num)
			{
			case 29:
				graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), 17f, 1f);
				num = 30;
				break;
			case 28:
				graphics_0.DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, 13, 13);
				num = 29;
				break;
			case 25:
			case 27:
				graphics_0.DrawRectangle(Pens.get_Black(), 0, 0, 15, 15);
				num = 28;
				break;
			case 26:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(30, Color.Black)), new Rectangle(3, 3, 10, 10));
					num = 27;
					break;
				}
				goto case 25;
			case 24:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(30, Color.Gray)), new Rectangle(3, 3, 10, 10));
					num = 25;
				}
				else
				{
					flag = genum0_0 != GEnum0.const_2;
					num = 26;
				}
				break;
			case 20:
			case 23:
				flag = !((genum0_0 == GEnum0.const_1) & (int_2 < 15));
				num = 24;
				break;
			case 22:
				graphics_0.FillRectangle((Brush)(object)val3, 3, 3, 10, 10);
				num = 23;
				break;
			case 21:
				val3 = new HatchBrush((HatchStyle)18, Color.FromArgb(20, Color.White), Color.FromArgb(0, Color.Gray));
				num = 22;
				break;
			case 19:
				graphics_0.FillRectangle((Brush)(object)val3, 3, 3, 10, 10);
				num = 20;
				break;
			case 18:
				val3 = new HatchBrush((HatchStyle)18, Color.FromArgb(60, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 19;
				break;
			case 17:
				val3 = null;
				num = 18;
				break;
			case 16:
				method_50(val2, new Rectangle(3, 3, 10, 4));
				num = 17;
				break;
			case 15:
			{
				ref Color reference4 = ref val2.get_Colors()[1];
				reference4 = Color.FromArgb(100, 100, 100);
				num = 16;
				break;
			}
			case 14:
			{
				ref Color reference3 = ref val2.get_Colors()[0];
				reference3 = Color.FromArgb(70, 70, 70);
				num = 15;
				break;
			}
			case 13:
				method_50(val2, new Rectangle(3, 3, 10, 10));
				num = 14;
				break;
			case 12:
				val2.get_Positions()[1] = 1f;
				num = 13;
				break;
			case 11:
				val2.get_Positions()[0] = 0f;
				num = 12;
				break;
			case 10:
			{
				ref Color reference2 = ref val2.get_Colors()[1];
				reference2 = Color.FromArgb(80, 80, 80);
				num = 11;
				break;
			}
			case 9:
			{
				ref Color reference = ref val2.get_Colors()[0];
				reference = Color.FromArgb(60, 60, 60);
				num = 10;
				break;
			}
			case 8:
				if (!flag)
				{
					val2 = new ColorBlend(2);
					num = 9;
				}
				else
				{
					val3 = null;
					num = 21;
				}
				break;
			case 7:
				flag = !bool_6;
				num = 8;
				break;
			case 6:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(10, 10, 10)), 3, 3, 10, 10);
				num = 7;
				break;
			case 5:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 6;
				break;
			case 4:
				graphics_0.FillRectangle((Brush)(object)val, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 5;
				break;
			case 3:
				val = new HatchBrush((HatchStyle)18, Color.DimGray);
				num = 4;
				break;
			case 2:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
				num = 3;
				break;
			case 1:
				val = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 2;
				break;
			case 0:
				val = null;
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
