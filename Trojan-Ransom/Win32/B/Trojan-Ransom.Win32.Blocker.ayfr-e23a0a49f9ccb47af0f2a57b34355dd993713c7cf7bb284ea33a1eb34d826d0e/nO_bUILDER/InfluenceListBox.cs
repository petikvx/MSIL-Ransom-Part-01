using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceListBox : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("lstbox")]
	private ListBox _lstbox;

	private string[] __Items;

	public virtual ListBox lstbox
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			DrawItemEventHandler val = new DrawItemEventHandler(DrawItem);
			if (_lstbox != null)
			{
				_lstbox.remove_DrawItem(val);
			}
			_lstbox = value;
			if (_lstbox != null)
			{
				_lstbox.add_DrawItem(val);
			}
		}
	}

	public string[] Items
	{
		get
		{
			return __Items;
		}
		set
		{
			__Items = value;
			lstbox.get_Items().Clear();
			((Control)this).Invalidate();
			lstbox.get_Items().AddRange((object[])value);
			((Control)this).Invalidate();
		}
	}

	public string SelectedItem => Conversions.ToString(lstbox.get_SelectedItem());

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		ListBox obj = lstbox;
		Size size = checked(new Size(((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6));
		((Control)obj).set_Size(size);
		((Control)this).Invalidate();
	}

	protected override void OnBackColorChanged(EventArgs e)
	{
		((Control)this).OnBackColorChanged(e);
		lstbox.set_BackColor(Color.FromArgb(43, 43, 43));
		((Control)this).Invalidate();
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		((Control)this).OnForeColorChanged(e);
		lstbox.set_ForeColor(((Control)this).get_ForeColor());
		((Control)this).Invalidate();
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Control)this).OnFontChanged(e);
		lstbox.set_Font(((Control)this).get_Font());
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		((Control)lstbox).Focus();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		ListBox obj = lstbox;
		Size size = checked(new Size(((Control)this).get_Width() - 11, ((Control)this).get_Height() - 11));
		((Control)obj).set_Size(size);
		((Control)this).Invalidate();
	}

	public void DrawItem(object sender, DrawItemEventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		try
		{
			e.DrawBackground();
			e.get_Graphics().DrawString(lstbox.get_Items().get_Item(e.get_Index()).ToString(), e.get_Font(), (Brush)new SolidBrush(lstbox.get_ForeColor()), (RectangleF)e.get_Bounds(), StringFormat.get_GenericDefault());
			e.DrawFocusRectangle();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void AddRange(object[] Items)
	{
		lstbox.get_Items().Remove((object)"");
		lstbox.get_Items().AddRange(Items);
		((Control)this).Invalidate();
	}

	public void AddItem(object Item)
	{
		lstbox.get_Items().Add(RuntimeHelpers.GetObjectValue(Item));
		((Control)this).Invalidate();
	}

	public void NewListBox()
	{
		ListBox obj = lstbox;
		Size size = checked(new Size(((Control)this).get_Width() - 8, ((Control)this).get_Height() - 8));
		((Control)obj).set_Size(size);
		lstbox.set_BorderStyle((BorderStyle)0);
		lstbox.set_DrawMode((DrawMode)2);
		ListBox obj2 = lstbox;
		Point location = new Point(3, 3);
		((Control)obj2).set_Location(location);
		lstbox.set_ForeColor(Color.White);
		lstbox.set_BackColor(Color.FromArgb(43, 43, 43));
		lstbox.get_Items().Clear();
	}

	public InfluenceListBox()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		__ENCAddToList(this);
		lstbox = new ListBox();
		__Items = new string[1] { "" };
		NewListBox();
		((Control)this).get_Controls().Add((Control)(object)lstbox);
		Size size = new Size(128, 108);
		((Control)this).set_Size(size);
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		Draw draw = new Draw();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			ListBox obj = lstbox;
			Size size = new Size(((Control)this).get_Width() - 7, ((Control)this).get_Height() - 7);
			((Control)obj).set_Size(size);
			val2.Clear(((Control)this).get_BackColor());
			Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle2, Color.FromArgb(40, 40, 40), Color.FromArgb(45, 45, 45), 90f);
			rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
			val2.FillPath((Brush)(object)val3, draw.RoundRect(rectangle2, 2));
			rectangle2 = new Rectangle(0, (int)Math.Round((double)((Control)this).get_Height() / 2.0), ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle2, Color.FromArgb(45, 45, 45), Color.FromArgb(40, 40, 40), 90f);
			rectangle2 = new Rectangle(0, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 3.0), ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 + 2.0));
			val2.FillPath((Brush)(object)val4, draw.RoundRect(rectangle2, 2));
			Pen val5 = new Pen(Color.FromArgb(150, 97, 94, 90));
			rectangle2 = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
			val2.DrawPath(val5, draw.RoundRect(rectangle2, 2));
			val2.DrawPath(new Pen(Color.FromArgb(10, 10, 10)), draw.RoundRect(rectangle, 2));
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
