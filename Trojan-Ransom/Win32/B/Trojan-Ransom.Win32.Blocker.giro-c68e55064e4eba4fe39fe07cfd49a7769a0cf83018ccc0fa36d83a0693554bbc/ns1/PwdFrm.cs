using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns2;
using ns3;

namespace ns1;

public class PwdFrm : Form
{
	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Label label_0;

	private Button button_0;

	private CheckBox checkBox_0;

	public PwdFrm()
	{
		InitializeComponent();
	}

	private void method_0(object sender, EventArgs e)
	{
		Class17.smethod_5(textBox_0, Class17.smethod_4(checkBox_0, 44983), 50680);
	}

	private void method_1(object sender, EventArgs e)
	{
		if (Class17.smethod_6((Control)(object)textBox_0, 32994) != null)
		{
			Class7.String_0 = Class17.smethod_6((Control)(object)textBox_0, 32994);
		}
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Class17.smethod_7(icontainer_0, 15717);
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
		textBox_0 = new TextBox();
		label_0 = new Label();
		button_0 = new Button();
		checkBox_0 = new CheckBox();
		((Control)this).SuspendLayout();
		Class17.smethod_8((Control)(object)textBox_0, new Point(12, 25), 40847);
		Class17.smethod_9((Control)(object)textBox_0, "pwdtextbox", 10011);
		Class17.smethod_10((Control)(object)textBox_0, new Size(251, 20), 8590);
		Class17.smethod_11((Control)(object)textBox_0, 0, 58021);
		Class17.smethod_5(textBox_0, bool_0: true, 50680);
		Class17.smethod_12((Control)(object)label_0, bool_0: true, 23753);
		Class17.smethod_8((Control)(object)label_0, new Point(12, 9), 40847);
		Class17.smethod_9((Control)(object)label_0, "label1", 10011);
		Class17.smethod_10((Control)(object)label_0, new Size(114, 13), 8590);
		Class17.smethod_11((Control)(object)label_0, 1, 58021);
		Class17.smethod_9((Control)(object)label_0, "Please enter password", 10010);
		Class17.smethod_8((Control)(object)button_0, new Point(92, 79), 40847);
		Class17.smethod_9((Control)(object)button_0, "OKButton", 10011);
		Class17.smethod_10((Control)(object)button_0, new Size(75, 23), 8590);
		Class17.smethod_11((Control)(object)button_0, 2, 58021);
		Class17.smethod_9((Control)(object)button_0, "OK", 10010);
		Class17.smethod_13((ButtonBase)(object)button_0, bool_0: true, 59502);
		Class17.smethod_14((Control)(object)button_0, method_1, 54201);
		Class17.smethod_12((Control)(object)checkBox_0, bool_0: true, 23753);
		Class17.smethod_15(checkBox_0, bool_0: true, 20556);
		Class17.smethod_16(checkBox_0, (CheckState)1, 20505);
		Class17.smethod_8((Control)(object)checkBox_0, new Point(12, 51), 40847);
		Class17.smethod_9((Control)(object)checkBox_0, "HidecheckBox", 10011);
		Class17.smethod_10((Control)(object)checkBox_0, new Size(101, 17), 8590);
		Class17.smethod_11((Control)(object)checkBox_0, 3, 58021);
		Class17.smethod_9((Control)(object)checkBox_0, "Hide characters", 10010);
		Class17.smethod_13((ButtonBase)(object)checkBox_0, bool_0: true, 59502);
		Class17.smethod_17(checkBox_0, method_0, 19813);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(275, 114));
		Class17.smethod_18(((Control)this).get_Controls(), (Control)(object)checkBox_0, 22517);
		Class17.smethod_18(((Control)this).get_Controls(), (Control)(object)button_0, 22517);
		Class17.smethod_18(((Control)this).get_Controls(), (Control)(object)label_0, 22517);
		Class17.smethod_18(((Control)this).get_Controls(), (Control)(object)textBox_0, 22517);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PwdFrm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		Class17.smethod_9((Control)(object)this, "Password", 10010);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
