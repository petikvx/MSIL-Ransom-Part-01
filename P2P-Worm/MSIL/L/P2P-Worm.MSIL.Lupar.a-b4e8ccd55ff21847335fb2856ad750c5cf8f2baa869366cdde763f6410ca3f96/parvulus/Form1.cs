using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace parvulus;

public class Form1 : Form
{
	private IContainer components;

	private GroupBox groupBox1;

	private Label label1;

	private Label label2;

	private Label label3;

	public Form1()
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
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		groupBox1 = new GroupBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).set_Location(new Point(24, 12));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(415, 245));
		((Control)groupBox1).set_TabIndex(0);
		groupBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Verdana", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(6, 26));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(399, 23));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Warning: Offensive Material Found!!");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(47, 260));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(371, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Dedicated to Sarah Payne, Kirsty Little, and all the other victims");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(10, 97));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(388, 26));
		((Control)label3).set_TabIndex(1);
		((Control)label3).set_Text("Possible offensive material has been found on your computer. \r\nDue to the nature of the material, the computer will now shutdown.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(470, 281));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Parvulus");
		((Form)this).set_TopMost(true);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
