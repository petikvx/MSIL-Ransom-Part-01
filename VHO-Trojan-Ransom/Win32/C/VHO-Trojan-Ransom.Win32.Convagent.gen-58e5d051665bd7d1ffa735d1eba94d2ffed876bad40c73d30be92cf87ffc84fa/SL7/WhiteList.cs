using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SL7;

public class WhiteList : Form
{
	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Label label1;

	private Label label2;

	private TextBox Username_txt;

	private TextBox Password_txt;

	public WhiteList()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)Username_txt).get_Text() == "Ghost")
		{
			if (((Control)Password_txt).get_Text() == "GhostIsBae")
			{
				((Control)new Custom()).Show();
				MessageBox.Show("Welcome GhostWeed!");
				((Control)this).Hide();
			}
			else
			{
				MessageBox.Show("Error: Please Check Username And Password!");
			}
		}
		else
		{
			MessageBox.Show("Error: Please Check Username And Password!");
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
		button1 = new Button();
		button2 = new Button();
		label1 = new Label();
		label2 = new Label();
		Username_txt = new TextBox();
		Password_txt = new TextBox();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(343, 38));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Login");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(1, 38));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("Back");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(SystemColors.AppWorkspace);
		((Control)label1).set_Location(new Point(-2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(55, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Username");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(SystemColors.AppWorkspace);
		((Control)label2).set_Location(new Point(365, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 13));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Password");
		((Control)Username_txt).set_Location(new Point(1, 12));
		((Control)Username_txt).set_Name("Username_txt");
		((Control)Username_txt).set_Size(new Size(100, 20));
		((Control)Username_txt).set_TabIndex(4);
		((Control)Password_txt).set_Location(new Point(318, 12));
		((Control)Password_txt).set_Name("Password_txt");
		((Control)Password_txt).set_Size(new Size(100, 20));
		((Control)Password_txt).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(418, 67));
		((Control)this).get_Controls().Add((Control)(object)Password_txt);
		((Control)this).get_Controls().Add((Control)(object)Username_txt);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("WhiteList");
		((Control)this).set_Text("WhiteList");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
