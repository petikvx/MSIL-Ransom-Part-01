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
public class frmMessage : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("grMessage")]
	private UltraGroupBox _grMessage;

	[AccessedThroughProperty("lblText")]
	private Label _lblText;

	[AccessedThroughProperty("btnCancel")]
	private UltraButton _btnCancel;

	[AccessedThroughProperty("btnOk")]
	private UltraButton _btnOk;

	private string _MsgCaption;

	private string _MsgText;

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual UltraGroupBox grMessage
	{
		[DebuggerNonUserCode]
		get
		{
			return _grMessage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_grMessage = value;
		}
	}

	internal virtual Label lblText
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblText;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblText = value;
		}
	}

	internal virtual UltraButton btnCancel
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnCancel != null)
			{
				((Control)_btnCancel).remove_Click((EventHandler)btnCancel_Click);
			}
			_btnCancel = value;
			if (_btnCancel != null)
			{
				((Control)_btnCancel).add_Click((EventHandler)btnCancel_Click);
			}
		}
	}

	internal virtual UltraButton btnOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnOk != null)
			{
				((Control)_btnOk).remove_Click((EventHandler)btnOk_Click);
			}
			_btnOk = value;
			if (_btnOk != null)
			{
				((Control)_btnOk).add_Click((EventHandler)btnOk_Click);
			}
		}
	}

	public string MsgCaption
	{
		get
		{
			return _MsgCaption;
		}
		set
		{
			_MsgCaption = value;
		}
	}

	public string MsgText
	{
		get
		{
			return _MsgText;
		}
		set
		{
			_MsgText = value;
		}
	}

	[DebuggerNonUserCode]
	public frmMessage()
	{
		((Form)this).add_Load((EventHandler)frmMessage_Load);
		__ENCList.Add(new WeakReference(this));
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		Appearance val = new Appearance();
		Appearance val2 = new Appearance();
		Appearance val3 = new Appearance();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		grMessage = new UltraGroupBox();
		btnCancel = new UltraButton();
		btnOk = new UltraButton();
		lblText = new Label();
		((ISupportInitialize)grMessage).BeginInit();
		((Control)grMessage).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Label1).set_BackColor(Color.FromArgb(192, 64, 0));
		((Control)Label1).set_Dock((DockStyle)4);
		Label label = Label1;
		Point location = new Point(488, 0);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(2, 208);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Label1");
		((Control)Label2).set_BackColor(Color.FromArgb(192, 64, 0));
		((Control)Label2).set_Dock((DockStyle)1);
		Label label3 = Label2;
		location = new Point(0, 0);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(488, 2);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Label2");
		((Control)Label3).set_BackColor(Color.FromArgb(192, 64, 0));
		((Control)Label3).set_Dock((DockStyle)3);
		Label label5 = Label3;
		location = new Point(0, 2);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(2, 206);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("Label3");
		((Control)Label4).set_BackColor(Color.FromArgb(192, 64, 0));
		((Control)Label4).set_Dock((DockStyle)2);
		Label label7 = Label4;
		location = new Point(2, 206);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(486, 2);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Label4");
		grMessage.set_CaptionAlignment((GroupBoxCaptionAlignment)1);
		((Control)grMessage).get_Controls().Add((Control)(object)btnCancel);
		((Control)grMessage).get_Controls().Add((Control)(object)btnOk);
		((Control)grMessage).get_Controls().Add((Control)(object)lblText);
		((Control)grMessage).set_Dock((DockStyle)5);
		val.set_BorderColor(Color.FromArgb(192, 64, 0));
		val.get_FontData().set_BoldAsString("True");
		val.get_FontData().set_SizeInPoints(10f);
		grMessage.set_HeaderAppearance((AppearanceBase)(object)val);
		grMessage.set_HeaderBorderStyle((UIElementBorderStyle)12);
		grMessage.set_HeaderPosition((GroupBoxHeaderPosition)3);
		UltraGroupBox obj = grMessage;
		location = new Point(2, 2);
		((Control)obj).set_Location(location);
		((Control)grMessage).set_Name("grMessage");
		UltraGroupBox obj2 = grMessage;
		size = new Size(486, 204);
		((Control)obj2).set_Size(size);
		((Control)grMessage).set_TabIndex(7);
		grMessage.set_Text("CNBC Money 2010");
		grMessage.set_ViewStyle((GroupBoxViewStyle)3);
		val2.set_BorderColor(Color.Black);
		val2.set_BorderColor2(Color.Black);
		((ControlBase)btnCancel).set_Appearance((AppearanceBase)(object)val2);
		((UltraButtonBase)btnCancel).set_ButtonStyle((UIElementButtonStyle)17);
		((UltraButtonBase)btnCancel).set_DialogResult((DialogResult)2);
		((Control)btnCancel).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj3 = btnCancel;
		location = new Point(255, 140);
		((Control)obj3).set_Location(location);
		((Control)btnCancel).set_Name("btnCancel");
		UltraButton obj4 = btnCancel;
		size = new Size(142, 23);
		((Control)obj4).set_Size(size);
		((Control)btnCancel).set_TabIndex(14);
		((ControlBase)btnCancel).set_Text("CANCEL");
		val3.set_BorderColor(Color.Black);
		val3.set_BorderColor2(Color.Black);
		((ControlBase)btnOk).set_Appearance((AppearanceBase)(object)val3);
		((UltraButtonBase)btnOk).set_ButtonStyle((UIElementButtonStyle)17);
		((Control)btnOk).set_Font(new Font("Verdana", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		UltraButton obj5 = btnOk;
		location = new Point(88, 140);
		((Control)obj5).set_Location(location);
		((Control)btnOk).set_Name("btnOk");
		UltraButton obj6 = btnOk;
		size = new Size(142, 23);
		((Control)obj6).set_Size(size);
		((Control)btnOk).set_TabIndex(13);
		((ControlBase)btnOk).set_Text("OK");
		((Control)lblText).set_BackColor(Color.Transparent);
		((Control)lblText).set_Dock((DockStyle)1);
		((Control)lblText).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj7 = lblText;
		location = new Point(3, 29);
		((Control)obj7).set_Location(location);
		((Control)lblText).set_Name("lblText");
		Label obj8 = lblText;
		size = new Size(480, 87);
		((Control)obj8).set_Size(size);
		((Control)lblText).set_TabIndex(0);
		lblText.set_TextAlign((ContentAlignment)32);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnOk);
		SizeF autoScaleDimensions = new SizeF(7f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.AliceBlue);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancel);
		size = new Size(490, 208);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)grMessage);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmMessage");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmMessage");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)grMessage).EndInit();
		((Control)grMessage).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmMessage_Load(object sender, EventArgs e)
	{
		grMessage.set_Text(MsgCaption);
		lblText.set_Text(MsgText);
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
