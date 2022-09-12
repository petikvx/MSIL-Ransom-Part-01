using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XinFrams_Locker;

public class Form5 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	public Form5()
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(13, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(57, 15));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("RULES:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(13, 41));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(233, 15));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("DO NOT Shutdown Your Computer");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(13, 65));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(310, 15));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("DO NOT TaskManeger Run On Your Computer");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(13, 89));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(291, 15));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("DO NOT Safe Mode Reboot Your Computer");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(13, 114));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(190, 15));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text("DO NOT Virus File Deleteng");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label6).set_ForeColor(Color.White);
		((Control)label6).set_Location(new Point(13, 138));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(252, 15));
		((Control)label6).set_TabIndex(5);
		((Control)label6).set_Text("DO NOT CMD Run On Your Computer");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("UD デジタル 教科書体 NK-B", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label7).set_ForeColor(Color.Red);
		((Control)label7).set_Location(new Point(13, 178));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(374, 15));
		((Control)label7).set_TabIndex(6);
		((Control)label7).set_Text("If You Violate The Rules SYSYTEM32 Was Encrypting!!");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(0, 0, 192));
		((Form)this).set_ClientSize(new Size(398, 207));
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form5");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Show Rules");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
