using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class Login : Form
{
	private IContainer icontainer_0;

	private CtrlLogin ctrlLogin1;

	private GClass9 customPanel1;

	[SpecialName]
	public void method_0(CtrlLogin.GDelegate2 gdelegate2_0)
	{
		ctrlLogin1.method_0(gdelegate2_0);
	}

	[SpecialName]
	public void method_1(CtrlLogin.GDelegate2 gdelegate2_0)
	{
		ctrlLogin1.method_1(gdelegate2_0);
	}

	public Login()
	{
		InitializeComponent();
		ctrlLogin1.form_0 = (Form)(object)this;
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
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		customPanel1 = new GClass9();
		ctrlLogin1 = new CtrlLogin();
		((Control)customPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)customPanel1).set_Anchor((AnchorStyles)15);
		customPanel1.method_1(Color.WhiteSmoke);
		customPanel1.method_3(SystemColors.Control);
		customPanel1.method_9(Color.FromArgb(0, 192, 0));
		customPanel1.method_7((BorderStyle)1);
		((Control)customPanel1).get_Controls().Add((Control)(object)ctrlLogin1);
		customPanel1.method_13(20);
		((Control)customPanel1).set_Location(new Point(1, 1));
		((Control)customPanel1).set_Name("customPanel1");
		((Control)customPanel1).set_Padding(new Padding(4));
		((Control)customPanel1).set_Size(new Size(476, 183));
		((Control)customPanel1).set_TabIndex(1);
		((Control)ctrlLogin1).set_BackColor(Color.Transparent);
		((Control)ctrlLogin1).set_Location(new Point(9, 12));
		((Control)ctrlLogin1).set_Name("ctrlLogin1");
		((Control)ctrlLogin1).set_Size(new Size(455, 168));
		((Control)ctrlLogin1).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ControlLightLight);
		((Form)this).set_ClientSize(new Size(477, 187));
		((Control)this).get_Controls().Add((Control)(object)customPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Login");
		((Control)this).set_Text("Login");
		((Control)customPanel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
