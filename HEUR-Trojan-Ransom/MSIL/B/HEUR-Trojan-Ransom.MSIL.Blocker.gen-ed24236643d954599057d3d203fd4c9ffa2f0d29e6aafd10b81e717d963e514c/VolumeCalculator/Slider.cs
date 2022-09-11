using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VolumeCalculator;

public class Slider : Form
{
	private IContainer icontainer_0 = null;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Button button1;

	private CheckBox checkBox1;

	private CheckBox checkBox2;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox12;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private RadioButton radioButton1;

	public Slider()
	{
		InitializeComponent();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Slider));
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		button1 = new Button();
		checkBox1 = new CheckBox();
		checkBox2 = new CheckBox();
		checkBox3 = new CheckBox();
		checkBox4 = new CheckBox();
		checkBox5 = new CheckBox();
		checkBox6 = new CheckBox();
		checkBox7 = new CheckBox();
		checkBox8 = new CheckBox();
		checkBox9 = new CheckBox();
		checkBox10 = new CheckBox();
		checkBox11 = new CheckBox();
		checkBox12 = new CheckBox();
		checkBox13 = new CheckBox();
		checkBox14 = new CheckBox();
		checkBox15 = new CheckBox();
		checkBox16 = new CheckBox();
		radioButton1 = new RadioButton();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(100, 50));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox2).set_Location(new Point(106, 12));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(473, 289));
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)button1).set_Location(new Point(525, 403));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(263, 35));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(409, 384));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(98, 21));
		((Control)checkBox1).set_TabIndex(3);
		((Control)checkBox1).set_Text("checkBox1");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)checkBox2).set_AutoSize(true);
		((Control)checkBox2).set_Location(new Point(409, 411));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(98, 21));
		((Control)checkBox2).set_TabIndex(3);
		((Control)checkBox2).set_Text("checkBox1");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		((Control)checkBox3).set_AutoSize(true);
		((Control)checkBox3).set_Location(new Point(305, 384));
		((Control)checkBox3).set_Name("checkBox3");
		((Control)checkBox3).set_Size(new Size(98, 21));
		((Control)checkBox3).set_TabIndex(3);
		((Control)checkBox3).set_Text("checkBox1");
		((ButtonBase)checkBox3).set_UseVisualStyleBackColor(true);
		((Control)checkBox4).set_AutoSize(true);
		((Control)checkBox4).set_Location(new Point(305, 411));
		((Control)checkBox4).set_Name("checkBox4");
		((Control)checkBox4).set_Size(new Size(98, 21));
		((Control)checkBox4).set_TabIndex(3);
		((Control)checkBox4).set_Text("checkBox1");
		((ButtonBase)checkBox4).set_UseVisualStyleBackColor(true);
		((Control)checkBox5).set_AutoSize(true);
		((Control)checkBox5).set_Location(new Point(196, 384));
		((Control)checkBox5).set_Name("checkBox5");
		((Control)checkBox5).set_Size(new Size(98, 21));
		((Control)checkBox5).set_TabIndex(3);
		((Control)checkBox5).set_Text("checkBox1".Replace('x', GClass5.smethod_0().ToLower().ToCharArray()[0]));
		((ButtonBase)checkBox5).set_UseVisualStyleBackColor(true);
		((Control)checkBox6).set_AutoSize(true);
		((Control)checkBox6).set_Location(new Point(196, 411));
		((Control)checkBox6).set_Name("checkBox6");
		((Control)checkBox6).set_Size(new Size(98, 21));
		((Control)checkBox6).set_TabIndex(3);
		((Control)checkBox6).set_Text("checkBox1");
		((ButtonBase)checkBox6).set_UseVisualStyleBackColor(true);
		((Control)checkBox7).set_AutoSize(true);
		((Control)checkBox7).set_Location(new Point(92, 384));
		((Control)checkBox7).set_Name("checkBox7");
		((Control)checkBox7).set_Size(new Size(98, 21));
		((Control)checkBox7).set_TabIndex(3);
		((Control)checkBox7).set_Text("checkBox1");
		Environment.Exit(0);
		((ButtonBase)checkBox7).set_UseVisualStyleBackColor(true);
		((Control)checkBox8).set_AutoSize(true);
		((Control)checkBox8).set_Location(new Point(92, 411));
		((Control)checkBox8).set_Name("checkBox8");
		((Control)checkBox8).set_Size(new Size(98, 21));
		((Control)checkBox8).set_TabIndex(3);
		((Control)checkBox8).set_Text("checkBox1");
		((ButtonBase)checkBox8).set_UseVisualStyleBackColor(true);
		((Control)checkBox9).set_AutoSize(true);
		((Control)checkBox9).set_Location(new Point(409, 330));
		((Control)checkBox9).set_Name("checkBox9");
		((Control)checkBox9).set_Size(new Size(98, 21));
		((Control)checkBox9).set_TabIndex(3);
		((Control)checkBox9).set_Text("checkBox1");
		((ButtonBase)checkBox9).set_UseVisualStyleBackColor(true);
		((Control)checkBox10).set_AutoSize(true);
		((Control)checkBox10).set_Location(new Point(409, 357));
		((Control)checkBox10).set_Name("checkBox10");
		((Control)checkBox10).set_Size(new Size(98, 21));
		((Control)checkBox10).set_TabIndex(3);
		((Control)checkBox10).set_Text("checkBox1");
		((ButtonBase)checkBox10).set_UseVisualStyleBackColor(true);
		((Control)checkBox11).set_AutoSize(true);
		((Control)checkBox11).set_Location(new Point(196, 330));
		((Control)checkBox11).set_Name("checkBox11");
		((Control)checkBox11).set_Size(new Size(98, 21));
		((Control)checkBox11).set_TabIndex(3);
		((Control)checkBox11).set_Text("checkBox1");
		((ButtonBase)checkBox11).set_UseVisualStyleBackColor(true);
		((Control)checkBox12).set_AutoSize(true);
		((Control)checkBox12).set_Location(new Point(305, 330));
		((Control)checkBox12).set_Name("checkBox12");
		((Control)checkBox12).set_Size(new Size(98, 21));
		((Control)checkBox12).set_TabIndex(3);
		((Control)checkBox12).set_Text("checkBox1");
		((ButtonBase)checkBox12).set_UseVisualStyleBackColor(true);
		((Control)checkBox13).set_AutoSize(true);
		((Control)checkBox13).set_Location(new Point(196, 357));
		((Control)checkBox13).set_Name("checkBox13");
		((Control)checkBox13).set_Size(new Size(98, 21));
		((Control)checkBox13).set_TabIndex(3);
		((Control)checkBox13).set_Text("checkBox1");
		((ButtonBase)checkBox13).set_UseVisualStyleBackColor(true);
		((Control)checkBox14).set_AutoSize(true);
		((Control)checkBox14).set_Location(new Point(305, 357));
		((Control)checkBox14).set_Name("checkBox14");
		((Control)checkBox14).set_Size(new Size(98, 21));
		((Control)checkBox14).set_TabIndex(3);
		((Control)checkBox14).set_Text("checkBox1");
		((ButtonBase)checkBox14).set_UseVisualStyleBackColor(true);
		((Control)checkBox15).set_AutoSize(true);
		((Control)checkBox15).set_Location(new Point(92, 330));
		((Control)checkBox15).set_Name("checkBox15");
		((Control)checkBox15).set_Size(new Size(98, 21));
		((Control)checkBox15).set_TabIndex(3);
		((Control)checkBox15).set_Text("checkBox1");
		((ButtonBase)checkBox15).set_UseVisualStyleBackColor(true);
		((Control)checkBox16).set_AutoSize(true);
		((Control)checkBox16).set_Location(new Point(92, 357));
		((Control)checkBox16).set_Name("checkBox16");
		((Control)checkBox16).set_Size(new Size(98, 21));
		((Control)checkBox16).set_TabIndex(3);
		((Control)checkBox16).set_Text("checkBox1");
		((ButtonBase)checkBox16).set_UseVisualStyleBackColor(true);
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Location(new Point(617, 357));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(110, 21));
		((Control)radioButton1).set_TabIndex(4);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("radioButton1");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)radioButton1);
		((Control)this).get_Controls().Add((Control)(object)checkBox16);
		((Control)this).get_Controls().Add((Control)(object)checkBox8);
		((Control)this).get_Controls().Add((Control)(object)checkBox15);
		((Control)this).get_Controls().Add((Control)(object)checkBox7);
		((Control)this).get_Controls().Add((Control)(object)checkBox14);
		((Control)this).get_Controls().Add((Control)(object)checkBox4);
		((Control)this).get_Controls().Add((Control)(object)checkBox13);
		((Control)this).get_Controls().Add((Control)(object)checkBox6);
		((Control)this).get_Controls().Add((Control)(object)checkBox12);
		((Control)this).get_Controls().Add((Control)(object)checkBox3);
		((Control)this).get_Controls().Add((Control)(object)checkBox11);
		((Control)this).get_Controls().Add((Control)(object)checkBox5);
		((Control)this).get_Controls().Add((Control)(object)checkBox10);
		((Control)this).get_Controls().Add((Control)(object)checkBox9);
		((Control)this).get_Controls().Add((Control)(object)checkBox2);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Slider");
		((Control)this).set_Text("Slider");
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
