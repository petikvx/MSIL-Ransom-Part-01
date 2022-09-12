using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[ToolboxBitmap(typeof(ComboBox))]
public class MetroComboBox : MetroComboBoxBase
{
	private MetroLinkSize metroLinkSize = MetroLinkSize.Medium;

	private MetroLinkWeight metroLinkWeight = MetroLinkWeight.Regular;

	private bool isHovered;

	private bool isPressed;

	private bool isFocused;

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(false)]
	public DrawMode DrawMode
	{
		get
		{
			return (DrawMode)1;
		}
		set
		{
			((ComboBox)this).set_DrawMode((DrawMode)1);
		}
	}

	[Browsable(false)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public ComboBoxStyle DropDownStyle
	{
		get
		{
			return (ComboBoxStyle)2;
		}
		set
		{
			((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		}
	}

	[DefaultValue(MetroLinkSize.Medium)]
	[Category("Metro Appearance")]
	public MetroLinkSize FontSize
	{
		get
		{
			return metroLinkSize;
		}
		set
		{
			metroLinkSize = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(MetroLinkWeight.Regular)]
	public MetroLinkWeight FontWeight
	{
		get
		{
			return metroLinkWeight;
		}
		set
		{
			metroLinkWeight = value;
		}
	}

	[Browsable(false)]
	public override Color BackColor => MetroPaint.BackColor.Form(base.Theme);

	[Browsable(false)]
	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
		}
	}

	[Browsable(false)]
	public override Color ForeColor
	{
		get
		{
			return ((ComboBox)this).get_ForeColor();
		}
		set
		{
			((ComboBox)this).set_ForeColor(value);
		}
	}

	public MetroComboBox()
	{
		((Control)this).SetStyle((ControlStyles)139282, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		((ComboBox)this).set_ItemHeight(((Control)this).GetPreferredSize(Size.Empty).Height);
		Color color = ((((Control)this).get_Parent() == null) ? MetroPaint.BackColor.Form(base.Theme) : ((Control)this).get_Parent().get_BackColor());
		Color color2;
		Color color3;
		if (isHovered && !isPressed && ((Control)this).get_Enabled())
		{
			color2 = MetroPaint.ForeColor.ComboBox.Hover(base.Theme);
			color3 = MetroPaint.BorderColor.ComboBox.Hover(base.Theme);
		}
		else if (isHovered && isPressed && ((Control)this).get_Enabled())
		{
			color2 = MetroPaint.ForeColor.ComboBox.Press(base.Theme);
			color3 = MetroPaint.BorderColor.ComboBox.Press(base.Theme);
		}
		else if (!((Control)this).get_Enabled())
		{
			color2 = MetroPaint.ForeColor.ComboBox.Disabled(base.Theme);
			color3 = MetroPaint.BorderColor.ComboBox.Disabled(base.Theme);
		}
		else
		{
			color2 = MetroPaint.ForeColor.ComboBox.Normal(base.Theme);
			color3 = MetroPaint.BorderColor.ComboBox.Normal(base.Theme);
		}
		e.get_Graphics().Clear(color);
		Pen val = new Pen(color3);
		try
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			e.get_Graphics().DrawRectangle(val, rectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		SolidBrush val2 = new SolidBrush(color2);
		try
		{
			e.get_Graphics().FillPolygon((Brush)(object)val2, new Point[3]
			{
				new Point(((Control)this).get_Width() - 20, ((Control)this).get_Height() / 2 - 2),
				new Point(((Control)this).get_Width() - 9, ((Control)this).get_Height() / 2 - 2),
				new Point(((Control)this).get_Width() - 15, ((Control)this).get_Height() / 2 + 4)
			});
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		Rectangle rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 20, ((Control)this).get_Height() - 4);
		TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Link(metroLinkSize, metroLinkWeight), rectangle2, color2, color, (TextFormatFlags)4);
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		if (e.get_Index() >= 0)
		{
			Color color;
			Color color2;
			if ((int)e.get_State() != 768 && (int)e.get_State() != 0)
			{
				color = MetroPaint.GetStyleColor(base.Style);
				color2 = MetroPaint.ForeColor.Tile.Normal(base.Theme);
			}
			else
			{
				color = MetroPaint.BackColor.Form(base.Theme);
				color2 = MetroPaint.ForeColor.Link.Normal(base.Theme);
			}
			SolidBrush val = new SolidBrush(color);
			try
			{
				e.get_Graphics().FillRectangle((Brush)(object)val, new Rectangle(e.get_Bounds().Left, e.get_Bounds().Top, e.get_Bounds().Width, e.get_Bounds().Height));
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			Rectangle rectangle = new Rectangle(0, e.get_Bounds().Top, e.get_Bounds().Width, e.get_Bounds().Height);
			TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((ListControl)this).GetItemText(((ComboBox)this).get_Items().get_Item(e.get_Index())), MetroFonts.Link(metroLinkSize, metroLinkWeight), rectangle, color2, color, (TextFormatFlags)4);
		}
		else
		{
			((ComboBox)this).OnDrawItem(e);
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		isFocused = true;
		((Control)this).Invalidate();
		((ComboBox)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		isFocused = false;
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((ComboBox)this).OnLostFocus(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		isFocused = true;
		((Control)this).Invalidate();
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		isFocused = false;
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnLeave(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 32)
		{
			isHovered = true;
			isPressed = true;
			((Control)this).Invalidate();
		}
		((ComboBox)this).OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnKeyUp(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		isHovered = true;
		((Control)this).Invalidate();
		((ComboBox)this).OnMouseEnter(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isPressed = true;
			((Control)this).Invalidate();
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		isHovered = false;
		((Control)this).Invalidate();
		((ComboBox)this).OnMouseLeave(e);
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		((Control)this).GetPreferredSize(proposedSize);
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			string text = ((((Control)this).get_Text().Length > 0) ? ((Control)this).get_Text() : "MeasureText");
			proposedSize = new Size(int.MaxValue, int.MaxValue);
			Size result = TextRenderer.MeasureText((IDeviceContext)(object)val, text, MetroFonts.Link(metroLinkSize, metroLinkWeight), proposedSize, (TextFormatFlags)536870916);
			result.Height += 4;
			return result;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
