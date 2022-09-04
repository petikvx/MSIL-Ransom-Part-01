using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Facebook_HACK_ANO;

public class ReactorListBox : Control
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

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
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
		lstbox.set_BackColor(((Control)this).get_BackColor());
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
		Size size = new Size(126, 96);
		((Control)obj).set_Size(size);
		lstbox.set_BorderStyle((BorderStyle)0);
		lstbox.set_DrawMode((DrawMode)2);
		ListBox obj2 = lstbox;
		Point location = new Point(4, 4);
		((Control)obj2).set_Location(location);
		lstbox.set_ForeColor(Color.FromArgb(216, 216, 216));
		lstbox.set_BackColor(Color.FromArgb(38, 38, 38));
		lstbox.get_Items().Clear();
	}

	public ReactorListBox()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		__ENCAddToList(this);
		lstbox = new ListBox();
		__Items = new string[1] { "" };
		NewListBox();
		((Control)this).get_Controls().Add((Control)(object)lstbox);
		Size size = new Size(131, 101);
		((Control)this).set_Size(size);
		((Control)this).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		((Control)this).OnPaint(e);
		graphics.Clear(((Control)this).get_BackColor());
		SolidBrush val = new SolidBrush(Color.FromArgb(37, 37, 37));
		checked
		{
			Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			graphics.FillRectangle((Brush)val, rectangle);
			Pen val2 = new Pen((Brush)new SolidBrush(Color.Black));
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			graphics.DrawRectangle(val2, rectangle);
			Pen val3 = new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70)));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			graphics.DrawRectangle(val3, rectangle);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, ((Control)this).get_Width(), 0);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, ((Control)this).get_Width() - 3, 2);
		}
	}
}
