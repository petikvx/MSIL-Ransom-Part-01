using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class About : Form
{
	private IContainer icontainer_0;

	private Label label1;

	private Label lblVersion;

	private Label label3;

	private Button btnClose;

	private Label label4;

	private Label lblBuild;

	private GClass9 customPanel1;

	private GClass9 customPanel2;

	private GClass9 customPanel3;

	public About()
	{
		InitializeComponent();
		((Control)lblVersion).set_Text("Version: " + GClass3.double_0.ToString("0.0").Replace(",", "."));
		((Control)lblBuild).set_Text("Build: " + GClass3.double_1.ToString().Replace(",", "."));
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		btnClose = new Button();
		customPanel3 = new GClass9();
		label1 = new Label();
		customPanel2 = new GClass9();
		label4 = new Label();
		customPanel1 = new GClass9();
		lblVersion = new Label();
		lblBuild = new Label();
		label3 = new Label();
		((Control)customPanel3).SuspendLayout();
		((Control)customPanel2).SuspendLayout();
		((Control)customPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)btnClose).set_Anchor((AnchorStyles)2);
		((Control)btnClose).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnClose).set_ForeColor(Color.Green);
		((Control)btnClose).set_Location(new Point(94, 207));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(101, 28));
		((Control)btnClose).set_TabIndex(3);
		((Control)btnClose).set_Text("Close");
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(true);
		((Control)btnClose).add_Click((EventHandler)btnClose_Click);
		((Control)customPanel3).set_Anchor((AnchorStyles)13);
		customPanel3.method_1(SystemColors.ControlLightLight);
		customPanel3.method_9(Color.Green);
		customPanel3.method_7((BorderStyle)1);
		((Control)customPanel3).get_Controls().Add((Control)(object)label1);
		customPanel3.method_13(15);
		((Control)customPanel3).set_Location(new Point(5, 6));
		((Control)customPanel3).set_Name("customPanel3");
		((Control)customPanel3).set_Size(new Size(276, 33));
		((Control)customPanel3).set_TabIndex(6);
		((Control)label1).set_Anchor((AnchorStyles)13);
		((Control)label1).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(3, 6));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(270, 19));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("CS-Cropfinder");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)customPanel2).set_Anchor((AnchorStyles)13);
		customPanel2.method_1(SystemColors.ControlLightLight);
		customPanel2.method_9(Color.Green);
		customPanel2.method_7((BorderStyle)1);
		((Control)customPanel2).get_Controls().Add((Control)(object)label4);
		customPanel2.method_13(15);
		((Control)customPanel2).set_Location(new Point(5, 115));
		((Control)customPanel2).set_Name("customPanel2");
		((Control)customPanel2).set_Size(new Size(276, 82));
		((Control)customPanel2).set_TabIndex(7);
		((Control)label4).set_Anchor((AnchorStyles)1);
		((Control)label4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(21, 9));
		((Control)label4).set_Margin(new Padding(8));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Padding(new Padding(4));
		((Control)label4).set_Size(new Size(232, 66));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("Use CS-Cropfinder at own risk. I am not responsible for any misuse or unfortunate episodes concerning the use of this program.");
		((Control)customPanel1).set_Anchor((AnchorStyles)13);
		customPanel1.method_1(SystemColors.ControlLightLight);
		customPanel1.method_9(Color.Green);
		customPanel1.method_7((BorderStyle)1);
		((Control)customPanel1).get_Controls().Add((Control)(object)lblVersion);
		((Control)customPanel1).get_Controls().Add((Control)(object)lblBuild);
		((Control)customPanel1).get_Controls().Add((Control)(object)label3);
		customPanel1.method_13(15);
		((Control)customPanel1).set_Location(new Point(5, 45));
		((Control)customPanel1).set_Name("customPanel1");
		((Control)customPanel1).set_Size(new Size(276, 64));
		((Control)customPanel1).set_TabIndex(6);
		((Control)lblVersion).set_Anchor((AnchorStyles)13);
		((Control)lblVersion).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblVersion).set_Location(new Point(0, 8));
		((Control)lblVersion).set_Name("lblVersion");
		((Control)lblVersion).set_Size(new Size(276, 13));
		((Control)lblVersion).set_TabIndex(1);
		((Control)lblVersion).set_Text("Version 1.0   RC1");
		lblVersion.set_TextAlign((ContentAlignment)32);
		((Control)lblBuild).set_Anchor((AnchorStyles)13);
		((Control)lblBuild).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblBuild).set_Location(new Point(0, 29));
		((Control)lblBuild).set_Name("lblBuild");
		((Control)lblBuild).set_Size(new Size(276, 13));
		((Control)lblBuild).set_TabIndex(5);
		((Control)lblBuild).set_Text("Build 1.033");
		lblBuild.set_TextAlign((ContentAlignment)32);
		((Control)label3).set_Anchor((AnchorStyles)13);
		((Control)label3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(0, 43));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(276, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Created by: CS");
		label3.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(286, 241));
		((Control)this).get_Controls().Add((Control)(object)customPanel3);
		((Control)this).get_Controls().Add((Control)(object)customPanel2);
		((Control)this).get_Controls().Add((Control)(object)customPanel1);
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("About");
		((Control)this).set_Text("About CS Cropfinder");
		((Control)customPanel3).ResumeLayout(false);
		((Control)customPanel2).ResumeLayout(false);
		((Control)customPanel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
