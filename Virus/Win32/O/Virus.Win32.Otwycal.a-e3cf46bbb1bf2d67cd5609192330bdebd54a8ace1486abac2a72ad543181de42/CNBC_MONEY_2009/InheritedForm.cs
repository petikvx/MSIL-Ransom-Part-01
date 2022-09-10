using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[DesignerGenerated]
public class InheritedForm : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("lblLeft")]
	private Label _lblLeft;

	[AccessedThroughProperty("lblRight")]
	private Label _lblRight;

	[AccessedThroughProperty("lblBottom")]
	private Label _lblBottom;

	[AccessedThroughProperty("lblTop")]
	private Label _lblTop;

	[AccessedThroughProperty("grForm")]
	private UltraGroupBox _grForm;

	[AccessedThroughProperty("CloseButton")]
	private UltraButton _CloseButton;

	private string _Caption;

	internal virtual Label lblLeft
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLeft;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLeft = value;
		}
	}

	internal virtual Label lblRight
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblRight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblRight = value;
		}
	}

	internal virtual Label lblBottom
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBottom;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBottom = value;
		}
	}

	internal virtual Label lblTop
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTop = value;
		}
	}

	public virtual UltraGroupBox grForm
	{
		[DebuggerNonUserCode]
		get
		{
			return _grForm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grForm = value;
		}
	}

	public virtual UltraButton CloseButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _CloseButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CloseButton != null)
			{
				((Control)_CloseButton).remove_Click((EventHandler)CloseButton_Click);
			}
			_CloseButton = value;
			if (_CloseButton != null)
			{
				((Control)_CloseButton).add_Click((EventHandler)CloseButton_Click);
			}
		}
	}

	public string Caption
	{
		get
		{
			return _Caption;
		}
		set
		{
			_Caption = value;
		}
	}

	public InheritedForm()
	{
		((Form)this).add_Load((EventHandler)InheritedForm_Load);
		__ENCList.Add(new WeakReference(this));
		_Caption = "UltraGroupBox1";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(InheritedForm));
		lblLeft = new Label();
		lblRight = new Label();
		lblBottom = new Label();
		lblTop = new Label();
		grForm = new UltraGroupBox();
		CloseButton = new UltraButton();
		((ISupportInitialize)grForm).BeginInit();
		((Control)grForm).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)lblLeft).set_BackColor(Color.SteelBlue);
		((Control)lblLeft).set_Dock((DockStyle)3);
		Label obj = lblLeft;
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)lblLeft).set_Name("lblLeft");
		Label obj2 = lblLeft;
		Size size = new Size(2, 404);
		((Control)obj2).set_Size(size);
		((Control)lblLeft).set_TabIndex(0);
		((Control)lblRight).set_BackColor(Color.SteelBlue);
		((Control)lblRight).set_Dock((DockStyle)4);
		Label obj3 = lblRight;
		location = new Point(499, 0);
		((Control)obj3).set_Location(location);
		((Control)lblRight).set_Name("lblRight");
		Label obj4 = lblRight;
		size = new Size(2, 404);
		((Control)obj4).set_Size(size);
		((Control)lblRight).set_TabIndex(1);
		((Control)lblBottom).set_BackColor(Color.SteelBlue);
		((Control)lblBottom).set_Dock((DockStyle)2);
		Label obj5 = lblBottom;
		location = new Point(2, 402);
		((Control)obj5).set_Location(location);
		((Control)lblBottom).set_Name("lblBottom");
		Label obj6 = lblBottom;
		size = new Size(497, 2);
		((Control)obj6).set_Size(size);
		((Control)lblBottom).set_TabIndex(2);
		((Control)lblTop).set_BackColor(Color.SteelBlue);
		((Control)lblTop).set_Dock((DockStyle)1);
		Label obj7 = lblTop;
		location = new Point(2, 0);
		((Control)obj7).set_Location(location);
		((Control)lblTop).set_Name("lblTop");
		Label obj8 = lblTop;
		size = new Size(497, 2);
		((Control)obj8).set_Size(size);
		((Control)lblTop).set_TabIndex(3);
		grForm.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)grForm).get_Controls().Add((Control)(object)CloseButton);
		((Control)grForm).set_Dock((DockStyle)5);
		val.get_FontData().set_BoldAsString("True");
		val.get_FontData().set_SizeInPoints(10f);
		grForm.set_HeaderAppearance((AppearanceBase)(object)val);
		grForm.set_HeaderBorderStyle((UIElementBorderStyle)12);
		grForm.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox obj9 = grForm;
		location = new Point(0, 0);
		((Control)obj9).set_Location(location);
		((Control)grForm).set_Name("grForm");
		UltraGroupBox obj10 = grForm;
		size = new Size(501, 404);
		((Control)obj10).set_Size(size);
		((Control)grForm).set_TabIndex(4);
		grForm.set_Text("UltraGroupBox1");
		grForm.set_ViewStyle((GroupBoxViewStyle)3);
		val2.set_BorderColor(Color.Black);
		val2.set_BorderColor2(Color.Black);
		((ControlBase)CloseButton).set_Appearance((AppearanceBase)(object)val2);
		((UltraButtonBase)CloseButton).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)CloseButton).set_DialogResult((DialogResult)2);
		((Control)CloseButton).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton closeButton = CloseButton;
		location = new Point(461, 2);
		((Control)closeButton).set_Location(location);
		((Control)CloseButton).set_Name("CloseButton");
		UltraButton closeButton2 = CloseButton;
		size = new Size(38, 21);
		((Control)closeButton2).set_Size(size);
		((Control)CloseButton).set_TabIndex(14);
		((ControlBase)CloseButton).set_Text("X");
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.AliceBlue);
		((Form)this).set_CancelButton((IButtonControl)(object)CloseButton);
		size = new Size(501, 404);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)lblTop);
		((Control)this).get_Controls().Add((Control)(object)lblBottom);
		((Control)this).get_Controls().Add((Control)(object)lblRight);
		((Control)this).get_Controls().Add((Control)(object)lblLeft);
		((Control)this).get_Controls().Add((Control)(object)grForm);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("InheritedForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((ISupportInitialize)grForm).EndInit();
		((Control)grForm).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void InheritedForm_Load(object sender, EventArgs e)
	{
		Point point = checked(new Point((int)Math.Round((double)((Control)this).get_Width() / 2.0), (int)Math.Round((double)((Control)this).get_Height() / 2.0)));
		Cursor.set_Position(((Control)this).PointToScreen(point));
	}

	private void CloseButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
