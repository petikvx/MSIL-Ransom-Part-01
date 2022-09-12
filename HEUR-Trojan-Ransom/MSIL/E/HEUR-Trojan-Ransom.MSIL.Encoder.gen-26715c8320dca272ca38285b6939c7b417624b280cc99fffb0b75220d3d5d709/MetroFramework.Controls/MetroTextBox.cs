using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[Designer("MetroFramework.Design.MetroTextBoxDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
public class MetroTextBox : MetroControlBase
{
	private class PromptedTextBox : TextBox
	{
		private const int OCM_COMMAND = 8465;

		private const int WM_PAINT = 15;

		private bool drawPrompt;

		private string promptText = "";

		[Browsable(true)]
		[DefaultValue("")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public string PromptText
		{
			get
			{
				return promptText;
			}
			set
			{
				promptText = value.Trim();
				((Control)this).Invalidate();
			}
		}

		private void DrawTextPrompt()
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				DrawTextPrompt(val);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}

		private void DrawTextPrompt(Graphics g)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected I4, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			TextFormatFlags val = (TextFormatFlags)268468224;
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			HorizontalAlignment textAlign = ((TextBox)this).get_TextAlign();
			switch ((int)textAlign)
			{
			case 0:
				clientRectangle.Offset(1, 1);
				break;
			case 1:
				val = (TextFormatFlags)(val | 2);
				clientRectangle.Offset(0, 1);
				break;
			case 2:
				val = (TextFormatFlags)(val | 1);
				clientRectangle.Offset(0, 1);
				break;
			}
			TextRenderer.DrawText((IDeviceContext)(object)g, promptText, ((Control)this).get_Font(), clientRectangle, SystemColors.GrayText, ((Control)this).get_BackColor(), val);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			((Control)this).OnPaint(e);
			if (drawPrompt)
			{
				DrawTextPrompt(e.get_Graphics());
			}
		}

		protected override void OnTextAlignChanged(EventArgs e)
		{
			((TextBox)this).OnTextAlignChanged(e);
			((Control)this).Invalidate();
		}

		protected override void OnTextChanged(EventArgs e)
		{
			((TextBoxBase)this).OnTextChanged(e);
			drawPrompt = ((Control)this).get_Text().Length == 0;
		}

		protected override void WndProc(ref Message m)
		{
			((TextBox)this).WndProc(ref m);
			if ((((Message)(ref m)).get_Msg() == 15 || ((Message)(ref m)).get_Msg() == 8465) && drawPrompt && !((Control)this).GetStyle((ControlStyles)2))
			{
				DrawTextPrompt();
			}
		}
	}

	private PromptedTextBox baseTextBox;

	private bool useStyleColors;

	private MetroTextBoxSize metroTextBoxSize;

	private MetroTextBoxWeight metroTextBoxWeight = MetroTextBoxWeight.Regular;

	private bool useCustomBackground;

	private bool useCustomForeColor;

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool UseStyleColors
	{
		get
		{
			return useStyleColors;
		}
		set
		{
			useStyleColors = value;
			UpdateBaseTextBox();
		}
	}

	[DefaultValue(MetroTextBoxSize.Small)]
	[Category("Metro Appearance")]
	public MetroTextBoxSize FontSize
	{
		get
		{
			return metroTextBoxSize;
		}
		set
		{
			metroTextBoxSize = value;
			UpdateBaseTextBox();
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(MetroTextBoxWeight.Regular)]
	public MetroTextBoxWeight FontWeight
	{
		get
		{
			return metroTextBoxWeight;
		}
		set
		{
			metroTextBoxWeight = value;
			UpdateBaseTextBox();
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

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool CustomForeColor
	{
		get
		{
			return useCustomForeColor;
		}
		set
		{
			useCustomForeColor = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Always)]
	[Category("Metro Appearance")]
	[Browsable(true)]
	[DefaultValue("")]
	public string PromptText
	{
		get
		{
			return baseTextBox.PromptText;
		}
		set
		{
			baseTextBox.PromptText = value;
		}
	}

	public override ContextMenu ContextMenu
	{
		get
		{
			return ((Control)baseTextBox).get_ContextMenu();
		}
		set
		{
			((Control)this).set_ContextMenu(value);
			((Control)baseTextBox).set_ContextMenu(value);
		}
	}

	public override ContextMenuStrip ContextMenuStrip
	{
		get
		{
			return ((Control)baseTextBox).get_ContextMenuStrip();
		}
		set
		{
			((Control)this).set_ContextMenuStrip(value);
			((Control)baseTextBox).set_ContextMenuStrip(value);
		}
	}

	[DefaultValue(false)]
	public bool Multiline
	{
		get
		{
			return ((TextBoxBase)baseTextBox).get_Multiline();
		}
		set
		{
			((TextBoxBase)baseTextBox).set_Multiline(value);
		}
	}

	public override string Text
	{
		get
		{
			return ((Control)baseTextBox).get_Text();
		}
		set
		{
			((Control)baseTextBox).set_Text(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public string SelectedText
	{
		get
		{
			return ((TextBoxBase)baseTextBox).get_SelectedText();
		}
		set
		{
			((Control)baseTextBox).set_Text(value);
		}
	}

	[DefaultValue(false)]
	public bool ReadOnly
	{
		get
		{
			return ((TextBoxBase)baseTextBox).get_ReadOnly();
		}
		set
		{
			((TextBoxBase)baseTextBox).set_ReadOnly(value);
		}
	}

	[DefaultValue('\0')]
	public char PasswordChar
	{
		get
		{
			return ((TextBox)baseTextBox).get_PasswordChar();
		}
		set
		{
			((TextBox)baseTextBox).set_PasswordChar(value);
		}
	}

	[DefaultValue(false)]
	public bool UseSystemPasswordChar
	{
		get
		{
			return ((TextBox)baseTextBox).get_UseSystemPasswordChar();
		}
		set
		{
			((TextBox)baseTextBox).set_UseSystemPasswordChar(value);
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public HorizontalAlignment TextAlign
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((TextBox)baseTextBox).get_TextAlign();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((TextBox)baseTextBox).set_TextAlign(value);
		}
	}

	[DefaultValue(true)]
	public bool TabStop
	{
		get
		{
			return ((Control)baseTextBox).get_TabStop();
		}
		set
		{
			((Control)baseTextBox).set_TabStop(value);
		}
	}

	[DefaultValue(32767)]
	public int MaxLength
	{
		get
		{
			return ((TextBoxBase)baseTextBox).get_MaxLength();
		}
		set
		{
			((TextBoxBase)baseTextBox).set_MaxLength(value);
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public ScrollBars ScrollBars
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((TextBox)baseTextBox).get_ScrollBars();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((TextBox)baseTextBox).set_ScrollBars(value);
		}
	}

	public event EventHandler AcceptsTabChanged;

	public MetroTextBox()
	{
		((Control)this).SetStyle((ControlStyles)196608, true);
		((Control)this).set_TabStop(false);
		CreateBaseTextBox();
		UpdateBaseTextBox();
		AddEventHandler();
	}

	private void BaseTextBoxAcceptsTabChanged(object sender, EventArgs e)
	{
		if (this.AcceptsTabChanged != null)
		{
			this.AcceptsTabChanged(this, e);
		}
	}

	private void BaseTextBoxSizeChanged(object sender, EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
	}

	private void BaseTextBoxCursorChanged(object sender, EventArgs e)
	{
		((Control)this).OnCursorChanged(e);
	}

	private void BaseTextBoxContextMenuStripChanged(object sender, EventArgs e)
	{
		((Control)this).OnContextMenuStripChanged(e);
	}

	private void BaseTextBoxContextMenuChanged(object sender, EventArgs e)
	{
		((Control)this).OnContextMenuChanged(e);
	}

	private void BaseTextBoxClientSizeChanged(object sender, EventArgs e)
	{
		((Control)this).OnClientSizeChanged(e);
	}

	private void BaseTextBoxClick(object sender, EventArgs e)
	{
		((Control)this).OnClick(e);
	}

	private void BaseTextBoxChangeUiCues(object sender, UICuesEventArgs e)
	{
		((Control)this).OnChangeUICues(e);
	}

	private void BaseTextBoxCausesValidationChanged(object sender, EventArgs e)
	{
		((Control)this).OnCausesValidationChanged(e);
	}

	private void BaseTextBoxKeyUp(object sender, KeyEventArgs e)
	{
		((Control)this).OnKeyUp(e);
	}

	private void BaseTextBoxKeyPress(object sender, KeyPressEventArgs e)
	{
		((Control)this).OnKeyPress(e);
	}

	private void BaseTextBoxKeyDown(object sender, KeyEventArgs e)
	{
		((Control)this).OnKeyDown(e);
	}

	private void BaseTextBoxTextChanged(object sender, EventArgs e)
	{
		((Control)this).OnTextChanged(e);
	}

	public void Select(int start, int length)
	{
		((TextBoxBase)baseTextBox).Select(start, length);
	}

	public void SelectAll()
	{
		((TextBoxBase)baseTextBox).SelectAll();
	}

	public void Clear()
	{
		((TextBoxBase)baseTextBox).Clear();
	}

	public void AppendText(string text)
	{
		((TextBoxBase)baseTextBox).AppendText(text);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		if (useCustomBackground)
		{
			e.get_Graphics().Clear(((Control)this).get_BackColor());
			((Control)baseTextBox).set_BackColor(((Control)this).get_BackColor());
		}
		else
		{
			e.get_Graphics().Clear(MetroPaint.BackColor.Button.Normal(base.Theme));
			((Control)baseTextBox).set_BackColor(MetroPaint.BackColor.Button.Normal(base.Theme));
		}
		if (useCustomForeColor)
		{
			((Control)baseTextBox).set_ForeColor(((Control)this).get_ForeColor());
		}
		else
		{
			((Control)baseTextBox).set_ForeColor(MetroPaint.ForeColor.Button.Normal(base.Theme));
		}
		Color color = MetroPaint.BorderColor.Button.Normal(base.Theme);
		if (useStyleColors)
		{
			color = MetroPaint.GetStyleColor(base.Style);
		}
		Pen val = new Pen(color);
		try
		{
			e.get_Graphics().DrawRectangle(val, new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public override void Refresh()
	{
		((Control)this).Refresh();
		UpdateBaseTextBox();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		UpdateBaseTextBox();
	}

	private void CreateBaseTextBox()
	{
		if (baseTextBox == null)
		{
			baseTextBox = new PromptedTextBox();
			((TextBoxBase)baseTextBox).set_BorderStyle((BorderStyle)0);
			((Control)baseTextBox).set_Font(MetroFonts.TextBox(metroTextBoxSize, metroTextBoxWeight));
			((Control)baseTextBox).set_Location(new Point(3, 3));
			((Control)baseTextBox).set_Size(new Size(((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6));
			((Control)this).set_Size(new Size(((Control)baseTextBox).get_Width() + 6, ((Control)baseTextBox).get_Height() + 6));
			((Control)baseTextBox).set_TabStop(true);
			((Control)this).get_Controls().Add((Control)(object)baseTextBox);
		}
	}

	private void AddEventHandler()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		((TextBoxBase)baseTextBox).add_AcceptsTabChanged((EventHandler)BaseTextBoxAcceptsTabChanged);
		((Control)baseTextBox).add_CausesValidationChanged((EventHandler)BaseTextBoxCausesValidationChanged);
		((Control)baseTextBox).add_ChangeUICues(new UICuesEventHandler(BaseTextBoxChangeUiCues));
		((TextBoxBase)baseTextBox).add_Click((EventHandler)BaseTextBoxClick);
		((Control)baseTextBox).add_ClientSizeChanged((EventHandler)BaseTextBoxClientSizeChanged);
		((Control)baseTextBox).add_ContextMenuChanged((EventHandler)BaseTextBoxContextMenuChanged);
		((Control)baseTextBox).add_ContextMenuStripChanged((EventHandler)BaseTextBoxContextMenuStripChanged);
		((Control)baseTextBox).add_CursorChanged((EventHandler)BaseTextBoxCursorChanged);
		((Control)baseTextBox).add_KeyDown(new KeyEventHandler(BaseTextBoxKeyDown));
		((Control)baseTextBox).add_KeyPress(new KeyPressEventHandler(BaseTextBoxKeyPress));
		((Control)baseTextBox).add_KeyUp(new KeyEventHandler(BaseTextBoxKeyUp));
		((Control)baseTextBox).add_SizeChanged((EventHandler)BaseTextBoxSizeChanged);
		((Control)baseTextBox).add_TextChanged((EventHandler)BaseTextBoxTextChanged);
	}

	private void UpdateBaseTextBox()
	{
		if (baseTextBox != null)
		{
			((Control)baseTextBox).set_Font(MetroFonts.TextBox(metroTextBoxSize, metroTextBoxWeight));
			((Control)baseTextBox).set_Location(new Point(3, 3));
			((Control)baseTextBox).set_Size(new Size(((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6));
		}
	}
}
