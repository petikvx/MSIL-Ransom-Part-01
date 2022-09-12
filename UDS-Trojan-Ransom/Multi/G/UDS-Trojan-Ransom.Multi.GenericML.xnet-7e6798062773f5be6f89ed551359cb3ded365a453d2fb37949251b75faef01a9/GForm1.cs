using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public sealed class GForm1 : Form
{
	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private MenuStrip menuStrip_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem toolStripMenuItem_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem toolStripMenuItem_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem toolStripMenuItem_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem toolStripMenuItem_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem toolStripMenuItem_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LinkLabel linkLabel_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ListBox listBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox pictureBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageList imageList_0;

	private string string_0;

	private string string_1;

	private Random random_0;

	private int int_0;

	private int int_1;

	private char[] char_0;

	public GForm1()
	{
		((Form)this).add_Load((EventHandler)GForm1_Load);
		random_0 = new Random();
		method_0();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class10.smethod_3().method_2());
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected O, but got Unknown
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm1));
		vmethod_1(new MenuStrip());
		vmethod_3(new ToolStripMenuItem());
		vmethod_5(new ToolStripMenuItem());
		vmethod_7(new ToolStripMenuItem());
		vmethod_9(new ToolStripMenuItem());
		vmethod_11(new ToolStripMenuItem());
		vmethod_13(new LinkLabel());
		vmethod_15(new Label());
		vmethod_17(new ListBox());
		vmethod_19(new TextBox());
		vmethod_21(new Button());
		vmethod_23(new Button());
		vmethod_25(new Label());
		vmethod_27(new Label());
		vmethod_29(new PictureBox());
		vmethod_31(new ImageList(icontainer_0));
		((Control)vmethod_0()).SuspendLayout();
		((ISupportInitialize)vmethod_28()).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStrip)vmethod_0()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)vmethod_2(),
			(ToolStripItem)vmethod_10()
		});
		((Control)vmethod_0()).set_Location(new Point(0, 0));
		((Control)vmethod_0()).set_Name(Class7.smethod_0(-1566192425));
		((Control)vmethod_0()).set_Size(new Size(605, 24));
		((Control)vmethod_0()).set_TabIndex(6);
		((Control)vmethod_0()).set_Text(Class7.smethod_0(-1566192425));
		((ToolStripDropDownItem)vmethod_2()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)vmethod_4(),
			(ToolStripItem)vmethod_6(),
			(ToolStripItem)vmethod_8()
		});
		((ToolStripItem)vmethod_2()).set_Name(Class7.smethod_0(-1566192474));
		((ToolStripItem)vmethod_2()).set_Size(new Size(37, 20));
		((ToolStripItem)vmethod_2()).set_Text(Class7.smethod_0(-1566192458));
		((ToolStripItem)vmethod_4()).set_Name(Class7.smethod_0(-1566192509));
		((ToolStripItem)vmethod_4()).set_Size(new Size(143, 22));
		((ToolStripItem)vmethod_4()).set_Text(Class7.smethod_0(-1566192283));
		((ToolStripItem)vmethod_6()).set_Name(Class7.smethod_0(-1566192266));
		((ToolStripItem)vmethod_6()).set_Size(new Size(143, 22));
		((ToolStripItem)vmethod_6()).set_Text(Class7.smethod_0(-1566192296));
		((ToolStripItem)vmethod_6()).set_Visible(false);
		((ToolStripItem)vmethod_8()).set_Name(Class7.smethod_0(-1566192297));
		((ToolStripItem)vmethod_8()).set_Size(new Size(143, 22));
		((ToolStripItem)vmethod_8()).set_Text(Class7.smethod_0(-1566192328));
		((ToolStripItem)vmethod_10()).set_Name(Class7.smethod_0(-1566192375));
		((ToolStripItem)vmethod_10()).set_Size(new Size(52, 20));
		((ToolStripItem)vmethod_10()).set_Text(Class7.smethod_0(-1566192360));
		((Label)vmethod_12()).set_AutoSize(true);
		((Control)vmethod_12()).set_Font(new Font(Class7.smethod_0(-1566192364), 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		vmethod_12().set_LinkColor(Color.Black);
		((Control)vmethod_12()).set_Location(new Point(259, 9));
		((Control)vmethod_12()).set_Name(Class7.smethod_0(-1566192143));
		((Control)vmethod_12()).set_Size(new Size(56, 16));
		((Control)vmethod_12()).set_TabIndex(8);
		((Label)vmethod_12()).set_TabStop(true);
		vmethod_12().set_Text(Class7.smethod_0(-1566192190));
		((Control)vmethod_12()).set_Visible(false);
		vmethod_14().set_AutoSize(true);
		((Control)vmethod_14()).set_BackColor(SystemColors.Control);
		((Control)vmethod_14()).set_Font(new Font(Class7.smethod_0(-1566192364), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_14()).set_Location(new Point(321, 9));
		((Control)vmethod_14()).set_Name(Class7.smethod_0(-1566192173));
		((Control)vmethod_14()).set_Size(new Size(0, 20));
		((Control)vmethod_14()).set_TabIndex(9);
		vmethod_16().set_Font(new Font(Class7.smethod_0(-1566192364), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)vmethod_16()).set_FormattingEnabled(true);
		vmethod_16().set_ItemHeight(16);
		((Control)vmethod_16()).set_Location(new Point(12, 278));
		((Control)vmethod_16()).set_Name(Class7.smethod_0(-1566192220));
		((Control)vmethod_16()).set_Size(new Size(177, 100));
		((Control)vmethod_16()).set_TabIndex(10);
		((Control)vmethod_18()).set_Font(new Font(Class7.smethod_0(-1566192364), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_18()).set_Location(new Point(305, 158));
		((Control)vmethod_18()).set_Name(Class7.smethod_0(-1566192248));
		((Control)vmethod_18()).set_Size(new Size(192, 26));
		((Control)vmethod_18()).set_TabIndex(11);
		((Control)vmethod_20()).set_Font(new Font(Class7.smethod_0(-1566192364), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_20()).set_Location(new Point(305, 190));
		((Control)vmethod_20()).set_Name(Class7.smethod_0(-1566192229));
		((Control)vmethod_20()).set_Size(new Size(97, 26));
		((Control)vmethod_20()).set_TabIndex(12);
		((ButtonBase)vmethod_20()).set_Text(Class7.smethod_0(-1566192019));
		((ButtonBase)vmethod_20()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_22()).set_Font(new Font(Class7.smethod_0(-1566192364), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_22()).set_Location(new Point(408, 190));
		((Control)vmethod_22()).set_Name(Class7.smethod_0(-1566192008));
		((Control)vmethod_22()).set_Size(new Size(97, 26));
		((Control)vmethod_22()).set_TabIndex(13);
		((ButtonBase)vmethod_22()).set_Text(Class7.smethod_0(-1566192049));
		((ButtonBase)vmethod_22()).set_UseVisualStyleBackColor(true);
		vmethod_24().set_AutoSize(true);
		vmethod_24().set_BorderStyle((BorderStyle)2);
		((Control)vmethod_24()).set_Font(new Font(Class7.smethod_0(-1566192364), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_24()).set_Location(new Point(305, 244));
		((Control)vmethod_24()).set_Name(Class7.smethod_0(-1566192036));
		((Control)vmethod_24()).set_Size(new Size(97, 26));
		((Control)vmethod_24()).set_TabIndex(14);
		vmethod_24().set_Text(Class7.smethod_0(-1566192084));
		vmethod_26().set_AutoSize(true);
		((Control)vmethod_26()).set_Font(new Font(Class7.smethod_0(-1566192364), 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_26()).set_Location(new Point(298, 42));
		((Control)vmethod_26()).set_Name(Class7.smethod_0(-1566192080));
		((Control)vmethod_26()).set_Size(new Size(207, 37));
		((Control)vmethod_26()).set_TabIndex(15);
		vmethod_26().set_Text(Class7.smethod_0(-1566192128));
		((Control)vmethod_28()).set_Location(new Point(12, 34));
		((Control)vmethod_28()).set_Name(Class7.smethod_0(-1566192107));
		((Control)vmethod_28()).set_Size(new Size(279, 235));
		vmethod_28().set_TabIndex(16);
		vmethod_28().set_TabStop(false);
		vmethod_30().set_ImageStream((ImageListStreamer)componentResourceManager.GetObject(Class7.smethod_0(-1566191879)));
		vmethod_30().set_TransparentColor(Color.Transparent);
		vmethod_30().get_Images().SetKeyName(0, Class7.smethod_0(-1566191930));
		vmethod_30().get_Images().SetKeyName(1, Class7.smethod_0(-1566191954));
		vmethod_30().get_Images().SetKeyName(2, Class7.smethod_0(-1566191991));
		vmethod_30().get_Images().SetKeyName(3, Class7.smethod_0(-1566191970));
		vmethod_30().get_Images().SetKeyName(4, Class7.smethod_0(-1566191769));
		vmethod_30().get_Images().SetKeyName(5, Class7.smethod_0(-1566191793));
		vmethod_30().get_Images().SetKeyName(6, Class7.smethod_0(-1566191786));
		vmethod_30().get_Images().SetKeyName(7, Class7.smethod_0(-1566191810));
		vmethod_30().get_Images().SetKeyName(8, Class7.smethod_0(-1566191866));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(605, 390));
		((Control)this).get_Controls().Add((Control)(object)vmethod_28());
		((Control)this).get_Controls().Add((Control)(object)vmethod_26());
		((Control)this).get_Controls().Add((Control)(object)vmethod_24());
		((Control)this).get_Controls().Add((Control)(object)vmethod_22());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_18());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name(Class7.smethod_0(-1566191633));
		((Form)this).set_Text(Class7.smethod_0(-1566191633));
		((Control)vmethod_0()).ResumeLayout(false);
		((Control)vmethod_0()).PerformLayout();
		((ISupportInitialize)vmethod_28()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		string string_ = GClass1.smethod_4() + GClass1.smethod_3();
		new Class2(512, bool_0: true, bool_1: false, string_, 3.13333);
	}

	internal virtual MenuStrip vmethod_0()
	{
		return menuStrip_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_1(MenuStrip menuStrip_1)
	{
		menuStrip_0 = menuStrip_1;
	}

	internal virtual ToolStripMenuItem vmethod_2()
	{
		return toolStripMenuItem_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_3(ToolStripMenuItem toolStripMenuItem_5)
	{
		toolStripMenuItem_0 = toolStripMenuItem_5;
	}

	internal virtual ToolStripMenuItem vmethod_4()
	{
		return toolStripMenuItem_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_5(ToolStripMenuItem toolStripMenuItem_5)
	{
		EventHandler eventHandler = method_4;
		ToolStripMenuItem val = toolStripMenuItem_1;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_1 = toolStripMenuItem_5;
		val = toolStripMenuItem_1;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	internal virtual ToolStripMenuItem vmethod_6()
	{
		return toolStripMenuItem_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_7(ToolStripMenuItem toolStripMenuItem_5)
	{
		toolStripMenuItem_2 = toolStripMenuItem_5;
	}

	internal virtual ToolStripMenuItem vmethod_8()
	{
		return toolStripMenuItem_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_9(ToolStripMenuItem toolStripMenuItem_5)
	{
		EventHandler eventHandler = method_5;
		ToolStripMenuItem val = toolStripMenuItem_3;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_3 = toolStripMenuItem_5;
		val = toolStripMenuItem_3;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	internal virtual ToolStripMenuItem vmethod_10()
	{
		return toolStripMenuItem_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_5)
	{
		EventHandler eventHandler = method_1;
		ToolStripMenuItem val = toolStripMenuItem_4;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_4 = toolStripMenuItem_5;
		val = toolStripMenuItem_4;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	internal virtual LinkLabel vmethod_12()
	{
		return linkLabel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_13(LinkLabel linkLabel_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(method_6);
		LinkLabel val2 = linkLabel_0;
		if (val2 != null)
		{
			val2.remove_LinkClicked(val);
		}
		linkLabel_0 = linkLabel_1;
		val2 = linkLabel_0;
		if (val2 != null)
		{
			val2.add_LinkClicked(val);
		}
	}

	internal virtual Label vmethod_14()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_15(Label label_3)
	{
		label_0 = label_3;
	}

	internal virtual ListBox vmethod_16()
	{
		return listBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_17(ListBox listBox_1)
	{
		listBox_0 = listBox_1;
	}

	internal virtual TextBox vmethod_18()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_19(TextBox textBox_1)
	{
		EventHandler eventHandler = method_7;
		TextBox val = textBox_0;
		if (val != null)
		{
			((Control)val).remove_TextChanged(eventHandler);
		}
		textBox_0 = textBox_1;
		val = textBox_0;
		if (val != null)
		{
			((Control)val).add_TextChanged(eventHandler);
		}
	}

	internal virtual Button vmethod_20()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_21(Button button_2)
	{
		EventHandler eventHandler = method_2;
		Button val = button_0;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_0 = button_2;
		val = button_0;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_22()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_23(Button button_2)
	{
		EventHandler eventHandler = method_3;
		Button val = button_1;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_1 = button_2;
		val = button_1;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Label vmethod_24()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_25(Label label_3)
	{
		label_1 = label_3;
	}

	internal virtual Label vmethod_26()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_27(Label label_3)
	{
		label_2 = label_3;
	}

	internal virtual PictureBox vmethod_28()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_29(PictureBox pictureBox_1)
	{
		pictureBox_0 = pictureBox_1;
	}

	internal virtual ImageList vmethod_30()
	{
		return imageList_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_31(ImageList imageList_1)
	{
		imageList_0 = imageList_1;
	}

	private void GForm1_Load(object sender, EventArgs e)
	{
		int_0 = 0;
		int_1 = 7;
		checked
		{
			vmethod_24().set_Text(Class7.smethod_0(-1566191619) + Conversions.ToString(int_1 - int_0));
			char_0 = new char[string_1.Length - 1 + 1];
			int num = string_1.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				char_0[i] = '-';
			}
			vmethod_28().set_Image((Image)null);
			vmethod_28().set_Image(vmethod_30().get_Images().get_Item(int_0));
			vmethod_26().set_Text(string_0);
			vmethod_16().get_Items().Clear();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)Class7.smethod_0(-1566191666), (MsgBoxStyle)64, (object)null);
	}

	private void method_2(object sender, EventArgs e)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (!vmethod_16().get_Items().Contains((object)vmethod_18().get_Text().Trim()) && Operators.CompareString(vmethod_18().get_Text().Trim(), string.Empty, false) != 0)
			{
				if (!string_1.Contains(vmethod_18().get_Text().Trim()))
				{
					int_0++;
					vmethod_16().get_Items().Add((object)vmethod_18().get_Text().Trim());
					vmethod_28().set_Image((Image)null);
					vmethod_28().set_Image(vmethod_30().get_Images().get_Item(int_0));
				}
				vmethod_24().set_Text(Class7.smethod_0(-1566191619) + Conversions.ToString(int_1 - int_0));
				if (int_0 == int_1)
				{
					Interaction.MsgBox((object)(Class7.smethod_0(-1566193646) + string_1 + Class7.smethod_0(-1566193468)), (MsgBoxStyle)0, (object)null);
					((Control)vmethod_20()).set_Enabled(false);
				}
				vmethod_26().set_Text(string_0);
				vmethod_18().set_Text(string.Empty);
			}
			if (Operators.CompareString(string_0, string_1, false) == 0)
			{
				Interaction.MsgBox((object)(Class7.smethod_0(-1566193501) + string_1 + Class7.smethod_0(-1566193527)), (MsgBoxStyle)0, (object)null);
			}
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		GForm1_Load(RuntimeHelpers.GetObjectValue(sender), e);
		vmethod_18().set_Text(string.Empty);
		((Control)vmethod_20()).set_Enabled(true);
	}

	private void method_4(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_5(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_6(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (Operators.CompareString(vmethod_12().get_Text(), Class7.smethod_0(-1566192190), false) == 0)
		{
			((Form)this).Close();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
	}
}
