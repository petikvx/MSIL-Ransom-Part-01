using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework.Drawing;
using MetroFramework.Native;

namespace MetroFramework.Controls;

[ToolboxBitmap(typeof(TabControl))]
[Designer("MetroFramework.Design.MetroTabControlDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
public class MetroTabControl : MetroTabControlBase
{
	private const int TabBottomBorderHeight = 3;

	private SubClass scUpDown;

	private bool bUpDown;

	private bool useStyleColors;

	private MetroTabControlSize metroLabelSize = MetroTabControlSize.Medium;

	private MetroTabControlWeight metroLabelWeight;

	private ContentAlignment textAlign = (ContentAlignment)16;

	private bool isMirrored;

	private bool useCustomBackground;

	[Category("Metro Appearance")]
	[DefaultValue(false)]
	public bool UseStyleColors
	{
		get
		{
			return useStyleColors;
		}
		set
		{
			useStyleColors = value;
		}
	}

	[DefaultValue(MetroTabControlSize.Medium)]
	[Category("Metro Appearance")]
	public MetroTabControlSize FontSize
	{
		get
		{
			return metroLabelSize;
		}
		set
		{
			metroLabelSize = value;
		}
	}

	[DefaultValue(MetroTabControlWeight.Light)]
	[Category("Metro Appearance")]
	public MetroTabControlWeight FontWeight
	{
		get
		{
			return metroLabelWeight;
		}
		set
		{
			metroLabelWeight = value;
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public ContentAlignment TextAlign
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return textAlign;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			textAlign = value;
		}
	}

	[Editor("MetroFramework.Design.MetroTabPageCollectionEditor, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a", typeof(UITypeEditor))]
	public TabPageCollection TabPages => ((TabControl)this).get_TabPages();

	[Category("Metro Appearance")]
	[DefaultValue(false)]
	public bool IsMirrored
	{
		get
		{
			return isMirrored;
		}
		set
		{
			if (isMirrored != value)
			{
				isMirrored = value;
				((Control)this).UpdateStyles();
			}
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
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

	protected override CreateParams CreateParams
	{
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			CreateParams createParams = ((TabControl)this).get_CreateParams();
			if (isMirrored)
			{
				createParams.set_ExStyle(createParams.get_ExStyle() | 0x400000 | 0x100000);
			}
			return createParams;
		}
	}

	public MetroTabControl()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)133122, true);
		((TabControl)this).set_Padding(new Point(6, 8));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		Color color = (useCustomBackground ? ((Control)this).get_BackColor() : MetroPaint.BackColor.Form(base.Theme));
		e.get_Graphics().Clear(color);
		for (int i = 0; i < TabPages.get_Count(); i++)
		{
			if (i != ((TabControl)this).get_SelectedIndex())
			{
				DrawTab(i, e.get_Graphics());
			}
		}
		if (((TabControl)this).get_SelectedIndex() > -1)
		{
			DrawTabBottomBorder(((TabControl)this).get_SelectedIndex(), e.get_Graphics());
			DrawTab(((TabControl)this).get_SelectedIndex(), e.get_Graphics());
			DrawTabSelected(((TabControl)this).get_SelectedIndex(), e.get_Graphics());
		}
	}

	private void DrawTabBottomBorder(int index, Graphics graphics)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Brush val = (Brush)new SolidBrush(MetroPaint.BorderColor.TabControl.Normal(base.Theme));
		try
		{
			Rectangle rectangle = new Rectangle(((Control)this).get_DisplayRectangle().X, GetTabRect(index).Bottom + 2 - 3, ((Control)this).get_DisplayRectangle().Width, 3);
			graphics.FillRectangle(val, rectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void DrawTabSelected(int index, Graphics graphics)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Brush val = (Brush)new SolidBrush(MetroPaint.GetStyleColor(base.Style));
		try
		{
			Rectangle tabRect = GetTabRect(index);
			graphics.FillRectangle(val, new Rectangle
			{
				X = -2 + tabRect.X + ((Control)this).get_DisplayRectangle().X,
				Y = tabRect.Bottom + 2 - 3,
				Width = tabRect.Width + 2,
				Height = 3
			});
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private Size MeasureText(string text)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			Size size = new Size(int.MaxValue, int.MaxValue);
			return TextRenderer.MeasureText((IDeviceContext)(object)val, text, MetroFonts.TabControl(metroLabelSize, metroLabelWeight), size, (TextFormatFlags)(MetroPaint.GetTextFormatFlags(TextAlign) | 0x10000000));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void DrawTab(int index, Graphics graphics)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		Color color = ((((Control)this).get_Parent() != null) ? ((Control)this).get_Parent().get_BackColor() : MetroPaint.BackColor.Form(base.Theme));
		TabPage val = TabPages.get_Item(index);
		Rectangle tabRect = GetTabRect(index);
		Color color2 = (((Control)this).get_Enabled() ? ((!useStyleColors) ? MetroPaint.ForeColor.TabControl.Normal(base.Theme) : MetroPaint.GetStyleColor(base.Style)) : MetroPaint.ForeColor.Label.Disabled(base.Theme));
		if (index == 0)
		{
			tabRect.X = ((Control)this).get_DisplayRectangle().X;
		}
		Rectangle rectangle = tabRect;
		tabRect.Width += 20;
		Brush val2 = (Brush)new SolidBrush(color);
		try
		{
			graphics.FillRectangle(val2, rectangle);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		TextRenderer.DrawText((IDeviceContext)(object)graphics, ((Control)val).get_Text(), MetroFonts.TabControl(metroLabelSize, metroLabelWeight), tabRect, color2, color, MetroPaint.GetTextFormatFlags(TextAlign));
	}

	[SecuritySafeCritical]
	private void DrawUpDown(Graphics graphics)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		Color color = ((((Control)this).get_Parent() != null) ? ((Control)this).get_Parent().get_BackColor() : MetroPaint.BackColor.Form(base.Theme));
		RECT rect = default(RECT);
		WinApi.GetClientRect(((NativeWindow)scUpDown).get_Handle(), ref rect);
		graphics.set_CompositingQuality((CompositingQuality)2);
		graphics.set_SmoothingMode((SmoothingMode)4);
		graphics.Clear(color);
		Brush val = (Brush)new SolidBrush(MetroPaint.BorderColor.TabControl.Normal(base.Theme));
		try
		{
			GraphicsPath val2 = new GraphicsPath((FillMode)1);
			PointF[] array = new PointF[3]
			{
				new PointF(6f, 6f),
				new PointF(16f, 0f),
				new PointF(16f, 12f)
			};
			val2.AddLines(array);
			graphics.FillPath(val, val2);
			val2.Reset();
			PointF[] array2 = new PointF[3]
			{
				new PointF(rect.Width - 15, 0f),
				new PointF(rect.Width - 5, 6f),
				new PointF(rect.Width - 15, 12f)
			};
			val2.AddLines(array2);
			graphics.FillPath(val, val2);
			val2.Dispose();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((Control)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnParentBackColorChanged(EventArgs e)
	{
		((Control)this).OnParentBackColorChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		((TabControl)this).OnResize(e);
		((Control)this).Invalidate();
	}

	[SecuritySafeCritical]
	protected override void WndProc(ref Message m)
	{
		((TabControl)this).WndProc(ref m);
		if (!((Component)(object)this).DesignMode)
		{
			WinApi.ShowScrollBar(((Control)this).get_Handle(), 3, 0);
		}
	}

	private Rectangle GetTabRect(int index)
	{
		if (index < 0)
		{
			return default(Rectangle);
		}
		return ((TabControl)this).GetTabRect(index);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (((TabControl)this).get_SelectedIndex() != -1 && !((Control)TabPages.get_Item(((TabControl)this).get_SelectedIndex())).get_Focused())
		{
			bool flag = false;
			foreach (Control item in (ArrangedElementCollection)((Control)TabPages.get_Item(((TabControl)this).get_SelectedIndex())).get_Controls())
			{
				Control val = item;
				if (val.get_Focused())
				{
					flag = true;
					return;
				}
			}
			if (!flag)
			{
				((Control)TabPages.get_Item(((TabControl)this).get_SelectedIndex())).Select();
				((Control)TabPages.get_Item(((TabControl)this).get_SelectedIndex())).Focus();
			}
		}
		((Control)this).OnMouseWheel(e);
	}

	protected override void OnCreateControl()
	{
		((Control)this).OnCreateControl();
		FindUpDown();
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		((Control)this).OnControlAdded(e);
		FindUpDown();
		UpdateUpDown();
	}

	protected override void OnControlRemoved(ControlEventArgs e)
	{
		((Control)this).OnControlRemoved(e);
		FindUpDown();
		UpdateUpDown();
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
		((TabControl)this).OnSelectedIndexChanged(e);
		UpdateUpDown();
		((Control)this).Invalidate();
	}

	[SecuritySafeCritical]
	private void FindUpDown()
	{
		bool flag = false;
		IntPtr window = WinApi.GetWindow(((Control)this).get_Handle(), 5);
		while (window != IntPtr.Zero)
		{
			char[] array = new char[33];
			int className = WinApi.GetClassName(window, array, 32);
			string text = new string(array, 0, className);
			if (!(text == "msctls_updown32"))
			{
				window = WinApi.GetWindow(window, 2);
				continue;
			}
			flag = true;
			if (!bUpDown)
			{
				scUpDown = new SubClass(window, _SubClass: true);
				scUpDown.SubClassedWndProc += scUpDown_SubClassedWndProc;
				bUpDown = true;
			}
			break;
		}
		if (!flag && bUpDown)
		{
			bUpDown = false;
		}
	}

	[SecuritySafeCritical]
	private void UpdateUpDown()
	{
		if (bUpDown && WinApi.IsWindowVisible(((NativeWindow)scUpDown).get_Handle()))
		{
			RECT rect = default(RECT);
			WinApi.GetClientRect(((NativeWindow)scUpDown).get_Handle(), ref rect);
			WinApi.InvalidateRect(((NativeWindow)scUpDown).get_Handle(), ref rect, bErase: true);
		}
	}

	[SecuritySafeCritical]
	private int scUpDown_SubClassedWndProc(ref Message m)
	{
		int msg = ((Message)(ref m)).get_Msg();
		if (msg == 15)
		{
			IntPtr windowDC = WinApi.GetWindowDC(((NativeWindow)scUpDown).get_Handle());
			Graphics val = Graphics.FromHdc(windowDC);
			DrawUpDown(val);
			val.Dispose();
			WinApi.ReleaseDC(((NativeWindow)scUpDown).get_Handle(), windowDC);
			((Message)(ref m)).set_Result(IntPtr.Zero);
			RECT rect = default(RECT);
			WinApi.GetClientRect(((NativeWindow)scUpDown).get_Handle(), ref rect);
			WinApi.ValidateRect(((NativeWindow)scUpDown).get_Handle(), ref rect);
			return 1;
		}
		return 0;
	}
}
