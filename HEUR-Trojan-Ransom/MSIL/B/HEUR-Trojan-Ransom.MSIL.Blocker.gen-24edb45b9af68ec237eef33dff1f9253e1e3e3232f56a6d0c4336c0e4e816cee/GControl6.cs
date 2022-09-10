using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

[DefaultEvent("CheckedChanged")]
public class GControl6 : GControl2
{
	public delegate void GDelegate1(object sender);

	private int int_2;

	private bool bool_6;

	private GDelegate1 gdelegate1_0;

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
				case 3:
					((Control)this).Invalidate();
					num = 4;
					break;
				case 2:
					if (!flag)
					{
						gdelegate1_0(this);
						num = 3;
						break;
					}
					goto case 3;
				case 1:
					flag = gdelegate1_0 == null;
					num = 2;
					break;
				case 0:
					method_68();
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public event GDelegate1 Event_0
	{
		add
		{
			GDelegate1 gDelegate = gdelegate1_0;
			bool flag = default(bool);
			GDelegate1 value2 = default(GDelegate1);
			do
			{
				GDelegate1 gDelegate2 = gDelegate;
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
						gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
						num = 2;
						continue;
					case 0:
						value2 = (GDelegate1)Delegate.Combine(gDelegate2, value);
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
			GDelegate1 gDelegate = gdelegate1_0;
			bool flag = default(bool);
			GDelegate1 value2 = default(GDelegate1);
			do
			{
				GDelegate1 gDelegate2 = gDelegate;
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
						gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
						num = 2;
						continue;
					case 0:
						value2 = (GDelegate1)Delegate.Remove(gDelegate2, value);
						num = 1;
						continue;
					}
					break;
				}
			}
			while (flag);
		}
	}

	public GControl6()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		((Control)this).set_Size(new Size(50, 14));
	}

	protected override void vmethod_2()
	{
		method_68();
	}

	private void method_68()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		bool flag;
		if (!(flag = ((Control)this).get_IsHandleCreated() && bool_6))
		{
			return;
		}
		IEnumerator enumerator = ((ArrangedElementCollection)((Control)this).get_Parent().get_Controls()).GetEnumerator();
		try
		{
			Control val = default(Control);
			while (true)
			{
				flag = enumerator.MoveNext();
				int num = 3;
				while (true)
				{
					switch (num)
					{
					case 1:
						if (!flag)
						{
							((GControl6)(object)val).Boolean_3 = false;
							num = 2;
							continue;
						}
						break;
					case 0:
						flag = object.ReferenceEquals(val, this) || !(val is GControl6);
						num = 1;
						continue;
					default:
						if (flag)
						{
							val = (Control)enumerator.Current;
							num = 0;
							continue;
						}
						return;
					case 2:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!flag)
					{
						disposable.Dispose();
						num2 = 2;
						continue;
					}
					break;
				case 0:
					flag = disposable == null;
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		bool flag = bool_6;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				base.OnMouseDown(e);
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					Boolean_3 = true;
					num = 1;
					break;
				}
				goto case 1;
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

	protected override void vmethod_1()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(60, 60, 60));
		int num = 0;
		bool flag = default(bool);
		HatchBrush val2 = default(HatchBrush);
		HatchBrush val = default(HatchBrush);
		while (true)
		{
			switch (num)
			{
			case 20:
				graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), 16f, 0f);
				num = 21;
				break;
			case 19:
				if (!flag)
				{
					graphics_0.FillEllipse((Brush)new SolidBrush(Color.FromArgb(20, Color.White)), 2, 2, 11, 11);
					num = 20;
					break;
				}
				goto case 20;
			case 14:
			case 18:
				flag = !((genum0_0 == GEnum0.const_1) & (int_2 < 13));
				num = 19;
				break;
			case 17:
				graphics_0.FillRectangle((Brush)(object)val2, 3, 3, 7, 7);
				num = 18;
				break;
			case 16:
				val2 = new HatchBrush((HatchStyle)18, Color.FromArgb(60, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 17;
				break;
			case 15:
				val2 = null;
				num = 16;
				break;
			case 13:
				graphics_0.FillEllipse((Brush)(object)val2, 2, 2, 10, 10);
				num = 14;
				break;
			case 12:
				val2 = new HatchBrush((HatchStyle)18, Color.FromArgb(20, Color.White), Color.FromArgb(0, Color.Gray));
				num = 13;
				break;
			case 11:
				if (!flag)
				{
					val2 = null;
					num = 12;
				}
				else
				{
					graphics_0.FillEllipse((Brush)new SolidBrush(Color.FromArgb(80, 80, 80)), 3, 3, 7, 7);
					num = 15;
				}
				break;
			case 10:
				flag = bool_6;
				num = 11;
				break;
			case 9:
				graphics_0.DrawEllipse(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, 11, 11);
				num = 10;
				break;
			case 8:
				graphics_0.DrawEllipse(Pens.get_Black(), 0, 0, 13, 13);
				num = 9;
				break;
			case 7:
				graphics_0.FillEllipse((Brush)new SolidBrush(Color.Black), 2, 2, 11, 11);
				num = 8;
				break;
			case 6:
				graphics_0.set_SmoothingMode((SmoothingMode)4);
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
