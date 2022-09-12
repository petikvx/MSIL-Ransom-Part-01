using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using MetroFramework.Drawing;
using MetroFramework.Native;

namespace MetroFramework.Controls;

[ToolboxItem(false)]
[Designer("MetroFramework.Design.MetroTabPageDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
public class MetroTabPage : MetroTabPageBase
{
	private MetroScrollBar verticalScrollbar = new MetroScrollBar(MetroScrollOrientation.Vertical);

	private MetroScrollBar horizontalScrollbar = new MetroScrollBar(MetroScrollOrientation.Horizontal);

	private bool showHorizontalScrollbar;

	private bool showVerticalScrollbar;

	private bool useCustomBackground;

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool HorizontalScrollbar
	{
		get
		{
			return showHorizontalScrollbar;
		}
		set
		{
			showHorizontalScrollbar = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(10)]
	public int HorizontalScrollbarSize
	{
		get
		{
			return horizontalScrollbar.ScrollbarSize;
		}
		set
		{
			horizontalScrollbar.ScrollbarSize = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(false)]
	public bool HorizontalScrollbarBarColor
	{
		get
		{
			return horizontalScrollbar.UseBarColor;
		}
		set
		{
			horizontalScrollbar.UseBarColor = value;
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool HorizontalScrollbarHighlightOnWheel
	{
		get
		{
			return horizontalScrollbar.HighlightOnWheel;
		}
		set
		{
			horizontalScrollbar.HighlightOnWheel = value;
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool VerticalScrollbar
	{
		get
		{
			return showVerticalScrollbar;
		}
		set
		{
			showVerticalScrollbar = value;
		}
	}

	[DefaultValue(10)]
	[Category("Metro Appearance")]
	public int VerticalScrollbarSize
	{
		get
		{
			return verticalScrollbar.ScrollbarSize;
		}
		set
		{
			verticalScrollbar.ScrollbarSize = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(false)]
	public bool VerticalScrollbarBarColor
	{
		get
		{
			return verticalScrollbar.UseBarColor;
		}
		set
		{
			verticalScrollbar.UseBarColor = value;
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool VerticalScrollbarHighlightOnWheel
	{
		get
		{
			return verticalScrollbar.HighlightOnWheel;
		}
		set
		{
			verticalScrollbar.HighlightOnWheel = value;
		}
	}

	[Category("Metro Appearance")]
	public bool AutoScroll
	{
		get
		{
			return ((ScrollableControl)this).get_AutoScroll();
		}
		set
		{
			if (value)
			{
				showHorizontalScrollbar = true;
				showVerticalScrollbar = true;
			}
			((ScrollableControl)this).set_AutoScroll(value);
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(false)]
	public bool CustomBackground
	{
		get
		{
			return useCustomBackground;
		}
		set
		{
			useCustomBackground = value;
		}
	}

	public MetroTabPage()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)141314, true);
		((Control)this).get_Controls().Add((Control)(object)verticalScrollbar);
		((Control)this).get_Controls().Add((Control)(object)horizontalScrollbar);
		verticalScrollbar.UseBarColor = true;
		horizontalScrollbar.UseBarColor = true;
		verticalScrollbar.Scroll += new ScrollEventHandler(VerticalScrollbarScroll);
		horizontalScrollbar.Scroll += new ScrollEventHandler(HorizontalScrollbarScroll);
	}

	private void HorizontalScrollbarScroll(object sender, ScrollEventArgs e)
	{
		((ScrollableControl)this).set_AutoScrollPosition(new Point(e.get_NewValue(), verticalScrollbar.Value));
		UpdateScrollBarPositions();
	}

	private void VerticalScrollbarScroll(object sender, ScrollEventArgs e)
	{
		((ScrollableControl)this).set_AutoScrollPosition(new Point(horizontalScrollbar.Value, e.get_NewValue()));
		UpdateScrollBarPositions();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		Color color = MetroPaint.BackColor.Form(base.Theme);
		if (useCustomBackground)
		{
			color = ((Control)this).get_BackColor();
		}
		e.get_Graphics().Clear(color);
		if (((Component)(object)this).DesignMode)
		{
			((Control)horizontalScrollbar).set_Visible(false);
			((Control)verticalScrollbar).set_Visible(false);
			return;
		}
		UpdateScrollBarPositions();
		if (HorizontalScrollbar)
		{
			((Control)horizontalScrollbar).set_Visible(((ScrollProperties)((ScrollableControl)this).get_HorizontalScroll()).get_Visible());
		}
		if (((ScrollProperties)((ScrollableControl)this).get_HorizontalScroll()).get_Visible())
		{
			horizontalScrollbar.Minimum = ((ScrollProperties)((ScrollableControl)this).get_HorizontalScroll()).get_Minimum();
			horizontalScrollbar.Maximum = ((ScrollProperties)((ScrollableControl)this).get_HorizontalScroll()).get_Maximum();
			horizontalScrollbar.SmallChange = ((ScrollProperties)((ScrollableControl)this).get_HorizontalScroll()).get_SmallChange();
			horizontalScrollbar.LargeChange = ((ScrollProperties)((ScrollableControl)this).get_HorizontalScroll()).get_LargeChange();
		}
		if (VerticalScrollbar)
		{
			((Control)verticalScrollbar).set_Visible(((ScrollProperties)((ScrollableControl)this).get_VerticalScroll()).get_Visible());
		}
		if (((ScrollProperties)((ScrollableControl)this).get_VerticalScroll()).get_Visible())
		{
			verticalScrollbar.Minimum = ((ScrollProperties)((ScrollableControl)this).get_VerticalScroll()).get_Minimum();
			verticalScrollbar.Maximum = ((ScrollProperties)((ScrollableControl)this).get_VerticalScroll()).get_Maximum();
			verticalScrollbar.SmallChange = ((ScrollProperties)((ScrollableControl)this).get_VerticalScroll()).get_SmallChange();
			verticalScrollbar.LargeChange = ((ScrollProperties)((ScrollableControl)this).get_VerticalScroll()).get_LargeChange();
		}
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		((ScrollableControl)this).OnMouseWheel(e);
		verticalScrollbar.Value = ((ScrollProperties)((ScrollableControl)this).get_VerticalScroll()).get_Value();
		horizontalScrollbar.Value = ((ScrollProperties)((ScrollableControl)this).get_HorizontalScroll()).get_Value();
	}

	[SecuritySafeCritical]
	protected override void WndProc(ref Message m)
	{
		((ScrollableControl)this).WndProc(ref m);
		if (!((Component)(object)this).DesignMode)
		{
			WinApi.ShowScrollBar(((Control)this).get_Handle(), 3, 0);
		}
	}

	private void UpdateScrollBarPositions()
	{
		if (((Component)(object)this).DesignMode)
		{
			return;
		}
		if (!AutoScroll)
		{
			((Control)verticalScrollbar).set_Visible(false);
			((Control)horizontalScrollbar).set_Visible(false);
			return;
		}
		if (VerticalScrollbar)
		{
			if (((ScrollProperties)((ScrollableControl)this).get_VerticalScroll()).get_Visible())
			{
				((Control)verticalScrollbar).set_Location(new Point(((Control)this).get_ClientRectangle().Width - ((Control)verticalScrollbar).get_Width(), ((Control)this).get_ClientRectangle().Y));
				((Control)verticalScrollbar).set_Height(((Control)this).get_ClientRectangle().Height);
			}
		}
		else
		{
			((Control)verticalScrollbar).set_Visible(false);
		}
		if (HorizontalScrollbar)
		{
			if (((ScrollProperties)((ScrollableControl)this).get_HorizontalScroll()).get_Visible())
			{
				((Control)horizontalScrollbar).set_Location(new Point(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Height - ((Control)horizontalScrollbar).get_Height()));
				((Control)horizontalScrollbar).set_Width(((Control)this).get_ClientRectangle().Width);
			}
		}
		else
		{
			((Control)horizontalScrollbar).set_Visible(false);
		}
	}
}
