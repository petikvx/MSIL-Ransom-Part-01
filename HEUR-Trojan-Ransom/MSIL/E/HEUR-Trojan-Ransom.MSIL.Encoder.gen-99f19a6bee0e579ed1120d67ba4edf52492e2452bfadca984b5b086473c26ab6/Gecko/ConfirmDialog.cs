using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gecko;

internal class ConfirmDialog : Form
{
	private MessageBoxIcon MBIcon;

	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Button button3;

	private CheckBox checkBox;

	private Label label;

	private Label label1;

	private Label label2;

	private Panel panel1;

	private PictureBox pictureBox;

	public bool CheckBoxChecked => checkBox.get_Checked();

	public ConfirmDialog()
	{
		InitializeComponent();
	}

	public ConfirmDialog(string message, string title, string button1Text, string button2Text, string button3Text, string checkBoxText)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		((Control)this).set_Font(SystemFonts.get_MessageBoxFont());
		((Control)this).set_Text(title);
		List<string> list = new List<string>();
		if (button1Text != null)
		{
			list.Add(button1Text);
		}
		if (button2Text != null)
		{
			list.Add(button2Text);
		}
		if (button3Text != null)
		{
			list.Add(button3Text);
		}
		int count = list.Count;
		while (list.Count < 3)
		{
			list.Insert(0, null);
		}
		if (count > 1)
		{
			MBIcon = (MessageBoxIcon)32;
		}
		else
		{
			int right = ((Control)label).get_Right();
			((Control)pictureBox).set_Visible(false);
			((Control)label).set_Left(((Control)pictureBox).get_Left());
			((Control)label).set_Width(right - ((Control)label).get_Left());
		}
		Button[] array = (Button[])(object)new Button[3] { button1, button2, button3 };
		int num = 1;
		for (int i = 0; i < 3; i++)
		{
			if (list[i] != null)
			{
				((Control)array[i]).set_Text(list[i]);
				array[i].set_DialogResult((DialogResult)(num++));
			}
			else
			{
				((Control)array[i]).set_Visible(false);
			}
		}
		if (checkBoxText != null)
		{
			((Control)checkBox).set_Text(checkBoxText);
		}
		else
		{
			((Control)panel1).set_Height(((Control)label1).get_Top() - 1);
			((Control)checkBox).set_Visible(false);
		}
		((Control)label).set_Text(message);
		((Control)label).set_Size(((Control)label).GetPreferredSize(new Size(((Control)label).get_Width(), ((Control)label).get_Height())));
		int num2 = Math.Max(((Control)label).get_Bottom(), ((int)MBIcon != 0) ? ((Control)pictureBox).get_Bottom() : ((Control)label).get_Bottom());
		int height = num2 + ((Control)label).get_Top() + ((Control)panel1).get_Height();
		int num3 = ((list[0] != null) ? (((Control)button1).get_Width() + 4) : 0) + ((list[1] != null) ? (((Control)button2).get_Width() + 4) : 0) + ((list[2] != null) ? (((Control)button3).get_Width() + 4) : 0);
		int width = Math.Max(num3 + 16, ((Control)label).get_Right() + 8);
		((Form)this).set_ClientSize(new Size(width, height));
	}

	private void pictureBox_Paint(object sender, PaintEventArgs e)
	{
		e.get_Graphics().DrawIcon(SystemIcons.get_Question(), 0, 0);
	}

	protected override void WndProc(ref Message m)
	{
		((Form)this).WndProc(ref m);
		if (((Message)(ref m)).get_Msg() == 132 && ((Message)(ref m)).get_Result() != (IntPtr)1)
		{
			((Message)(ref m)).set_Result((IntPtr)2);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		checkBox = new CheckBox();
		pictureBox = new PictureBox();
		label = new Label();
		panel1 = new Panel();
		label2 = new Label();
		label1 = new Label();
		((ISupportInitialize)pictureBox).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button1).set_Anchor((AnchorStyles)9);
		button1.set_DialogResult((DialogResult)4);
		((Control)button1).set_Location(new Point(159, 8));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Anchor((AnchorStyles)9);
		button2.set_DialogResult((DialogResult)2);
		((Control)button2).set_Location(new Point(239, 8));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(1);
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Anchor((AnchorStyles)9);
		button3.set_DialogResult((DialogResult)1);
		((Control)button3).set_Location(new Point(319, 8));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(2);
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)checkBox).set_Anchor((AnchorStyles)15);
		checkBox.set_CheckAlign((ContentAlignment)1);
		((Control)checkBox).set_Location(new Point(8, 46));
		((Control)checkBox).set_Name("checkBox");
		((Control)checkBox).set_Size(new Size(385, 16));
		((Control)checkBox).set_TabIndex(3);
		((ButtonBase)checkBox).set_TextAlign((ContentAlignment)1);
		((ButtonBase)checkBox).set_UseVisualStyleBackColor(true);
		((Control)pictureBox).set_Location(new Point(12, 12));
		((Control)pictureBox).set_Name("pictureBox");
		((Control)pictureBox).set_Size(new Size(32, 32));
		pictureBox.set_TabIndex(4);
		pictureBox.set_TabStop(false);
		((Control)pictureBox).add_Paint(new PaintEventHandler(pictureBox_Paint));
		((Control)label).set_Location(new Point(52, 12));
		((Control)label).set_Name("label");
		((Control)label).set_Size(new Size(338, 63));
		((Control)label).set_TabIndex(5);
		((Control)label).set_Text("label");
		((Control)panel1).set_BackColor(SystemColors.Control);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)checkBox);
		((Control)panel1).get_Controls().Add((Control)(object)button3);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).set_Dock((DockStyle)2);
		((Control)panel1).set_Location(new Point(0, 92));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(401, 70));
		((Control)panel1).set_TabIndex(6);
		((Control)label2).set_BackColor(SystemColors.ControlLightLight);
		((Control)label2).set_Location(new Point(0, 39));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(2000, 1));
		((Control)label2).set_TabIndex(5);
		((Control)label1).set_BackColor(SystemColors.ControlDark);
		((Control)label1).set_Location(new Point(0, 38));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(2000, 1));
		((Control)label1).set_TabIndex(4);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(401, 162));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label);
		((Control)this).get_Controls().Add((Control)(object)pictureBox);
		((Form)this).set_FormBorderStyle((FormBorderStyle)4);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ConfirmDialog");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("ConfirmDialog");
		((ISupportInitialize)pictureBox).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
