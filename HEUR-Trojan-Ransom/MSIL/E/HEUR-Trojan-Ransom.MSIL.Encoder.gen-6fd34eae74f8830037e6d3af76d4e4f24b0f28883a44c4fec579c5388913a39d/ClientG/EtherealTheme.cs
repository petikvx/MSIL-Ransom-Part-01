using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

public class EtherealTheme : ContainerControl
{
	public enum TitlePostion
	{
		Left,
		Center
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private bool Movable;

	private Point MousePoint;

	private object MoveHeight;

	private TitlePostion _TitleTextPostion;

	private bool _ShowIcon
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public virtual bool ShowIcon
	{
		get
		{
			return _ShowIcon;
		}
		set
		{
			if (value != _ShowIcon)
			{
				((Control)this).FindForm().set_ShowIcon(value);
				_ShowIcon = value;
				((Control)this).Invalidate();
				_ShowIcon = value;
			}
		}
	}

	public virtual TitlePostion TitleTextPostion
	{
		get
		{
			return _TitleTextPostion;
		}
		set
		{
			_TitleTextPostion = value;
		}
	}

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

	public EtherealTheme()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		__ENCAddToList(this);
		Movable = false;
		ref Point mousePoint = ref MousePoint;
		mousePoint = new Point(0, 0);
		MoveHeight = 50;
		_TitleTextPostion = TitlePostion.Left;
		_ShowIcon = false;
		((Control)this).SetStyle((ControlStyles)139282, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Dock((DockStyle)0);
		((Control)this).set_BackColor(Color.White);
		((Control)this).set_Font(new Font("Proxima Nova", 14f, (FontStyle)1));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Graphics val3 = val2;
		val3.set_TextRenderingHint((TextRenderingHint)5);
		SolidBrush br = HelperMethods.SolidBrushHTMlColor("00001a");
		Rectangle rect = new Rectangle(0, 0, ((Control)this).get_Width(), 50);
		HelperMethods.FillRect(val2, (Brush)(object)br, rect);
		Graphics obj = val3;
		Pen obj2 = HelperMethods.PenHTMlColor("00001a", 2f);
		rect = checked(new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2));
		obj.DrawRectangle(obj2, rect);
		if (((Control)this).FindForm().get_ShowIcon())
		{
			Icon icon = ((Control)this).FindForm().get_Icon();
			rect = new Rectangle(5, 13, 20, 20);
			val2.DrawIcon(icon, rect);
			switch (TitleTextPostion)
			{
			case TitlePostion.Left:
				val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), 27f, 10f);
				break;
			case TitlePostion.Center:
			{
				string text = ((Control)this).get_Text();
				Font font = ((Control)this).get_Font();
				Brush white = Brushes.get_White();
				rect = new Rectangle(0, 0, ((Control)this).get_Width(), 50);
				HelperMethods.CentreString(val2, text, font, white, rect);
				break;
			}
			}
		}
		else
		{
			switch (TitleTextPostion)
			{
			case TitlePostion.Left:
				val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), 5f, 10f);
				break;
			case TitlePostion.Center:
			{
				string text2 = ((Control)this).get_Text();
				Font font2 = ((Control)this).get_Font();
				Brush white2 = Brushes.get_White();
				rect = new Rectangle(0, 0, ((Control)this).get_Width(), 50);
				HelperMethods.CentreString(val2, text2, font2, white2, rect);
				break;
			}
			}
		}
		val3 = null;
		((Control)this).OnPaint(e);
		NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
		{
			RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
			0,
			0
		}, (string[])null, (Type[])null, (bool[])null, true);
		val2.Dispose();
		((Image)val).Dispose();
	}

	protected override void CreateHandle()
	{
		((Control)this).CreateHandle();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		bool num = (int)e.get_Button() == 1048576;
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), Conversions.ToInteger(MoveHeight));
		Rectangle rectangle2 = rectangle;
		if (num & rectangle2.Contains(e.get_Location()))
		{
			Movable = true;
			MousePoint = e.get_Location();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		Movable = false;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (Movable)
		{
			((Control)this).get_Parent().set_Location(Control.get_MousePosition() - (Size)MousePoint);
		}
	}

	protected override void OnCreateControl()
	{
		((ContainerControl)this).OnCreateControl();
		((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
		((ContainerControl)this).get_ParentForm().set_AllowTransparency(false);
		((ContainerControl)this).get_ParentForm().set_TransparencyKey(Color.Fuchsia);
		((Control)((ContainerControl)this).get_ParentForm()).FindForm().set_StartPosition((FormStartPosition)1);
		((Control)this).set_Dock((DockStyle)5);
		((Control)this).Invalidate();
	}
}
