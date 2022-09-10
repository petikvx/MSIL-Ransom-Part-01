using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NVCameraViewer;

[DesignerGenerated]
public class frmKeySet : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("lblKeyPress")]
	private Label _lblKeyPress;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	public bool AltPress;

	public bool CtrlPress;

	public bool ShiftPress;

	public int KeyCode;

	public bool IsClearSetting;

	public bool IsCancel;

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Label lblKeyPress
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblKeyPress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblKeyPress = value;
		}
	}

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

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	public frmKeySet()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Control)this).add_KeyDown(new KeyEventHandler(frmKeySet_KeyDown));
		((Control)this).add_KeyUp(new KeyEventHandler(frmKeySet_KeyUp));
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		IsClearSetting = false;
		IsCancel = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		Panel1 = new Panel();
		Button2 = new Button();
		lblKeyPress = new Label();
		Label1 = new Label();
		Button1 = new Button();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		Panel1.set_BorderStyle((BorderStyle)1);
		((Control)Panel1).get_Controls().Add((Control)(object)Button2);
		((Control)Panel1).get_Controls().Add((Control)(object)lblKeyPress);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).set_Dock((DockStyle)5);
		Panel panel = Panel1;
		Point location = new Point(0, 0);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		Size size = new Size(399, 155);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(0);
		Button button = Button2;
		location = new Point(137, 112);
		((Control)button).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button2 = Button2;
		size = new Size(120, 30);
		((Control)button2).set_Size(size);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("清除按鍵設定");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		lblKeyPress.set_AutoSize(true);
		Label obj = lblKeyPress;
		location = new Point(149, 72);
		((Control)obj).set_Location(location);
		((Control)lblKeyPress).set_Name("lblKeyPress");
		Label obj2 = lblKeyPress;
		size = new Size(0, 12);
		((Control)obj2).set_Size(size);
		((Control)lblKeyPress).set_TabIndex(2);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(37, 45);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(334, 12);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("請直接按下鍵盤按鍵設定快速鍵, 或點選 [取消] 按鈕放棄設定...");
		Button button3 = Button1;
		location = new Point(271, 112);
		((Control)button3).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button4 = Button1;
		size = new Size(115, 30);
		((Control)button4).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("取消");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 12f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(399, 155);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_KeyPreview(true);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmKeySet");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmKeySet");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmKeySet_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I4, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		switch (e.get_KeyCode() - 16)
		{
		default:
			if (IsAllowKey(e.get_KeyCode()))
			{
				KeyCode = (int)e.get_KeyCode();
				((Form)this).Close();
			}
			break;
		case 0:
			ShiftPress = true;
			break;
		case 1:
			CtrlPress = true;
			break;
		case 2:
			AltPress = true;
			break;
		}
		ShowKeyPress();
	}

	private void frmKeySet_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I4, but got Unknown
		switch (e.get_KeyCode() - 16)
		{
		case 0:
			ShiftPress = false;
			break;
		case 1:
			CtrlPress = false;
			break;
		case 2:
			AltPress = false;
			break;
		}
		ShowKeyPress();
	}

	private bool IsAllowKey(Keys KeyCode)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		bool result = false;
		if ((int)KeyCode >= 65 && (int)KeyCode <= 122)
		{
			result = true;
		}
		else
		{
			switch (KeyCode - 48)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
				result = true;
				break;
			}
		}
		return result;
	}

	private void ShowKeyPress()
	{
		string text = string.Empty;
		if (AltPress)
		{
			text = "Alt";
		}
		if (CtrlPress)
		{
			if (Operators.CompareString(text, string.Empty, false) != 0)
			{
				text += " + ";
			}
			text += "Ctrl";
		}
		if (ShiftPress)
		{
			if (Operators.CompareString(text, string.Empty, false) != 0)
			{
				text += " + ";
			}
			text += "Shift";
		}
		lblKeyPress.set_Text(text);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		IsClearSetting = true;
		((Form)this).Close();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		IsCancel = true;
		((Form)this).Close();
	}
}
